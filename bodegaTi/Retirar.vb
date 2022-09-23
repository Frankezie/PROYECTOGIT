Imports System.Data.SqlClient
Public Class Retirar
    Dim total_registros As String = 0
    Dim varseleccion As Integer = 0
    Dim adaptador As SqlDataAdapter
    Dim datos As DataSet
    Private Sub Retirar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_usu.Text = Login.cmb_usuario.Text

        lbl_fecha.Text = DateTime.Now.ToString("yyyy/MM/dd")
    End Sub

    Sub limpiar()
        txt_codigo.Text = ""
        txt_desc.Text = ""
        txt_precio.Text = ""
        txt_margen.Text = ""
        txt_cantidad1.Text = ""
        txt_total.Text = ""
        txt_stock.Text = ""
    End Sub

    Sub total()
        Dim linea As DataGridViewRow
        Dim valor As Long
        ' Dim v As Long

        For Each linea In grilla_retirar.Rows
            valor = valor + linea.Cells(5).Value
        Next

        txt_subtotal.Text = " $ " & FormatNumber(valor)
        'Dim v As Long = valor * 0.19
        'TXT_IVA.Text = " $ " & FormatNumber(v)
        'txt_total.Text = " $ " & FormatNumber(valor + v)
    End Sub

    Public Sub llenagrid()
        Dim row(7) As String
        row(0) = txt_codigo.Text
        row(1) = txt_desc.Text
        row(2) = txt_precio.Text
        row(3) = txt_margen.Text
        row(4) = txt_cantidad1.Text
        row(5) = txt_total.Text
        row(6) = txt_stock.Text


        Dim rowtosave As String() = New String() {row(1), row(2), row(3), row(4), row(5), row(6), row(7)}
        grilla_retirar.Rows.Add(row)
    End Sub

    Sub Buscar()

        Try
            ' Condicion para validar si el campo queda vacío no deje seguir con el proceso ya que sin numero de orden no se puede registrar el registro.
            If String.IsNullOrEmpty(txt_codigo.Text) Then
                MsgBox("No puede dejar el campo " & txt_codigo.Text & " vacío", MsgBoxStyle.Information, "VALIDAR")
                txt_codigo.Select()
            Else
                miconsulta2("SELECT  [id_registro],[nombre_producto],[descripcion_producto],[stock],[categoria],[codigo],[ubicacion],[fecha_ingreso],[precio_bruto],[precio_neto],[margen] FROM [inventario].[dbo].[productos] WHERE codigo = '" & txt_codigo.Text & "'")

                If ds2.Tables(dt2.TableName).Rows.Count > 0 Then
                    txt_desc.Text = ds2.Tables(dt2.TableName).Rows(0).Item("descripcion_producto")
                    txt_precio.Text = ds2.Tables(dt2.TableName).Rows(0).Item("precio_neto")
                    txt_margen.Text = ds2.Tables(dt2.TableName).Rows(0).Item("margen")
                    txt_stock.Text = ds2.Tables(dt2.TableName).Rows(0).Item("stock")

                    MsgBox("Numero de orden: " & txt_codigo.Text & " encontrada!", MsgBoxStyle.Information, "VALIDAR")

                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs)

    '    cargar_usuario()

    'End Sub
    'Sub cargar_usuario()
    '    Try
    '        conexion = New SqlConnection()
    '        conexion.ConnectionString = My.Settings.conexion
    '        conexion.Open()
    '        Dim consulta As String
    '        consulta = "select cantidad from productos where codigo='" & txt_codigo.Text & "'"
    '        adaptador = New SqlDataAdapter(consulta, conexion)
    '        datos = New DataSet
    '        datos.Tables.Add("productos")
    '        adaptador.Fill(datos.Tables("productos"))
    '        cmb_cantidad.DataSource = datos.Tables("productos")
    '        cmb_cantidad.DisplayMember = "cantidad"




    '    Catch ex As Exception
    '        MsgBox(ex.Message)

    '    End Try

    'End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_venta.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grilla_retirar.CellContentClick

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txt_total.Text = txt_precio.Text * txt_cantidad1.Text

        llenagrid()
        total()
        limpiar()
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_margen.TextChanged

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_desc.TextChanged

    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Buscar()

    End Sub

    Private Sub txt_total_TextChanged(sender As Object, e As EventArgs) Handles txt_total.TextChanged

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub txt_subtotal_TextChanged(sender As Object, e As EventArgs) Handles txt_subtotal.TextChanged

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles lbl_fecha.Click

    End Sub
End Class