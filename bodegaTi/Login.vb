Imports System.Data.SqlClient
Imports System.Data

Public Class Login
    Dim total_registros As String = 0
    Dim varseleccion As Integer = 0
    Dim adaptador As SqlDataAdapter
    Dim datos As DataSet
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Principal.ShowDialog()
        miconsulta("select * from usuarios where usuario= '" & cmb_usuario.Text & "' and clave='" & txt_clave.Text & "'")
        If ds.Tables(dt.TableName).Rows.Count > 0 Then

            Principal.Owner = Me.Owner

            'tipo_usuario = ds.Tables(dt.TableName).Rows(0).Item("tipo")
            Me.Visible = False
            Principal.ShowDialog()
            'limpiar()


            ' MsgBox("Acceso Restringido", MsgBoxStyle.Critical)
        End If
    End Sub
    Sub cargar_usuario()
        Try
            conexion = New SqlConnection()
            conexion.ConnectionString = My.Settings.conexion
            conexion.Open()
            Dim consulta As String
            consulta = "select * from usuarios"
            adaptador = New SqlDataAdapter(consulta, conexion)
            datos = New DataSet
            datos.Tables.Add("usuarios")
            adaptador.Fill(datos.Tables("usuarios"))
            cmb_usuario.DataSource = datos.Tables("usuarios")
            cmb_usuario.DisplayMember = "usuario"



        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_usuario()
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub
End Class