Imports System.Data.SqlClient
Public Class Retirar
    Dim total_registros As String = 0
    Dim varseleccion As Integer = 0
    Dim adaptador As SqlDataAdapter
    Dim datos As DataSet
    Private Sub Retirar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

        cargar_usuario()

    End Sub
    Sub cargar_usuario()
        Try
            conexion = New SqlConnection()
            conexion.ConnectionString = My.Settings.conexion
            conexion.Open()
            Dim consulta As String
            consulta = "select cantidad from productos where codigo='" & txt_codigo.Text & "'"
            adaptador = New SqlDataAdapter(consulta, conexion)
            datos = New DataSet
            datos.Tables.Add("productos")
            adaptador.Fill(datos.Tables("productos"))
            cmb_cantidad.DataSource = datos.Tables("productos")
            cmb_cantidad.DisplayMember = "cantidad"




        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class