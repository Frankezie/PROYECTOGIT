Imports System.Data.SqlClient
Imports System.Data
Imports iTextSharp.text.pdf
Public Class Productos
    Dim total_registros As String = 0
    Dim varseleccion As Integer = 0
    Dim adaptador As SqlDataAdapter
    Dim datos As DataSet
    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label8.Text = Login.cmb_usuario.Text
        'mostrar_grilla()
        lbl_fecha.Text = DateTime.Now.ToString("yyyy/MM/dd")
        cargar_categorias()
        cargar_ubicacion()
    End Sub


    Sub mostrar_grilla()
        Dim cmd As New SqlCommand("select id_registro as REG ,nombre_producto as PRODUCTO,descripcion_producto as DESCRIPCION,cantidad as CANTIDAD,categoria as CATEGORIA,ubicacion as UBUICACION,codigo as CODIGO,fecha_ingreso as FECHA from productos", conexion)
        conexion.Open()

        Dim adapter As New SqlDataAdapter(cmd)
        Dim mi_data As New DataTable
        adapter.Fill(mi_data)
        grilla_productos.DataSource = mi_data
        cmd = Nothing
        conexion.Close()
    End Sub

    Sub Eliminar()
        miconsulta3("delete from productos where id_registro = '" & txt_registro.Text & "'")
        MsgBox("DATOS GRABADOS CORRECTAMENTE")
        mostrar_grilla()
        limpiar()
    End Sub

    Sub buscar()
        miconsulta4("select * from productos where codigo = '" & txt_codigo.Text & "' ")
        If ds4.Tables(dt4.TableName).Rows.Count > 0 Then


            txt_nombre_producto.Text = ds4.Tables(dt4.TableName).Rows(0).Item("nombre_producto")
            cmb_categoria.Text = ds4.Tables(dt4.TableName).Rows(0).Item("categoria")

            cmb_bodega.Text = ds4.Tables(dt4.TableName).Rows(0).Item("bodega")
            txt_cantidad.Text = ds4.Tables(dt4.TableName).Rows(0).Item("cantidad")
            txt_descripcion.Text = ds4.Tables(dt4.TableName).Rows(0).Item("descripcion_producto")

        End If

    End Sub



    Sub controles(ByRef a As Boolean, ByVal b As Boolean)
        btn_nuevo.Enabled = b
        btn_modificar.Enabled = b
        btn_eliminar.Enabled = b


        txt_nombre_producto.ReadOnly = b
        txt_registro.ReadOnly = b

        txt_cantidad.ReadOnly = b
        cmb_categoria.Enabled = a
        cmb_bodega.Enabled = a
        txt_descripcion.ReadOnly = b

        btn_guardar.Enabled = a
        ' btn_cancelar.Enabled = a

    End Sub
    Sub cargar_categorias()
        Try
            RemoveHandler cmb_categoria.SelectedIndexChanged, AddressOf cmb_categoria_SelectedIndexChanged
            conexion = New SqlConnection()
            conexion.ConnectionString = My.Settings.conexion
            conexion.Open()
            Dim consulta As String
            consulta = "select categoria,id_registro  from categorias order by categoria asc"
            adaptador = New SqlDataAdapter(consulta, conexion)
            datos = New DataSet
            datos.Tables.Add("categorias")
            adaptador.Fill(datos.Tables("categorias"))
            cmb_categoria.DataSource = datos.Tables("categorias")
            cmb_categoria.DisplayMember = "categoria"
            cmb_categoria.ValueMember = "id_registro"

            conexion.Close()
            AddHandler cmb_categoria.SelectedIndexChanged, AddressOf cmb_categoria_SelectedIndexChanged
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Sub cargar_ubicacion()
        Try
            RemoveHandler cmb_bodega.SelectedIndexChanged, AddressOf cmb_bodega_SelectedIndexChanged
            conexion = New SqlConnection()
            conexion.ConnectionString = My.Settings.conexion
            conexion.Open()
            Dim consulta As String
            consulta = "select nombre_bodega,id_bodega from bodega order by nombre_bodega asc"
            adaptador = New SqlDataAdapter(consulta, conexion)
            datos = New DataSet
            datos.Tables.Add("bodega")
            adaptador.Fill(datos.Tables("bodega"))
            cmb_bodega.DataSource = datos.Tables("bodega")
            cmb_bodega.DisplayMember = "bodega"
            cmb_bodega.ValueMember = "nombre_bodega"

            conexion.Close()
            AddHandler cmb_bodega.SelectedIndexChanged, AddressOf cmb_bodega_SelectedIndexChanged
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub limpiar()
        txt_nombre_producto.Text = ""
        cmb_categoria.Text = "Seleccione Categoria"
        cmb_bodega.Text = "Seleccione Ubicacion"
        txt_descripcion.Text = ""
        txt_codigo.Text = ""
        txt_cantidad.Text = "0"
        PictureBox1.Image = Nothing
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        limpiar()
        varseleccion = 1
        controles(True, False)
    End Sub
    Private Function validaciones()
        Dim a As String = ""

        If txt_nombre_producto.Text = "" Then
            a += "Ingrese nombre" & vbNewLine
        End If
        If cmb_categoria.Text = "" Then
            a += "Seleccione Categoria" & vbNewLine
        End If
        If cmb_bodega.Text = "" Then
            a += "Seleccione Ubicacion" & vbNewLine
        End If
        If txt_cantidad.Text = "" Then
            a += "Ingrese  Cantidad" & vbNewLine
        End If


        Return a
    End Function
    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Dim respuesta As String = validaciones()
        If respuesta = "" Then

            If varseleccion = 1 Then

                miconsulta("insert into productos(nombre_producto,descripcion_producto,cantidad,categoria,ubicacion,codigo,fecha_ingreso) values('" & txt_nombre_producto.Text & "','" & txt_descripcion.Text & "','" & txt_cantidad.Text & "','" & cmb_categoria.Text & "','" & cmb_bodega.Text & "','" & txt_codigo.Text & "','" & DateTime.Now.ToString("yyyy/MM/dd") & "')")
                MsgBox("DATOS GRAGADOS CORRECTAMENTE")
                controles(False, True)
                limpiar()
                ' actualizar_datos()
                mostrar_grilla()
            ElseIf varseleccion = 2 Then

                miconsulta("update productos set nombre_producto ='" & txt_nombre_producto.Text & "',descripcion_producto='" & txt_descripcion.Text & "',cantidad='" & txt_cantidad.Text & "',categoria='" & cmb_categoria.Text & "',ubicacion='" & cmb_bodega.Text & "',codigo='" & txt_codigo.Text & "',fecha_ingreso='" & DateTime.Now.ToString("yyyy/MM/dd") & "' where id_registro=" & txt_registro.Text & " ")
                MsgBox("DATOS ACTUALIZADOS")

                controles(False, True)
                limpiar()
                ' actualizar_datos()
                mostrar_grilla()

            End If
        Else
            MsgBox(respuesta, MsgBoxStyle.Information, "Error")
        End If
    End Sub

    Private Sub cmb_categoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_categoria.SelectedIndexChanged

    End Sub

    Private Sub cmb_bodega_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_bodega.SelectedIndexChanged

    End Sub

    Private Sub grilla_productos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grilla_productos.CellDoubleClick
        If e.RowIndex <> -1 Then
            miconsulta2("select * from productos where id_registro=" & grilla_productos.Item(0, e.RowIndex).Value & " ")

            If ds2.Tables(dt2.TableName).Rows.Count > 0 Then
                txt_nombre_producto.Text = ds2.Tables(dt2.TableName).Rows(0).Item("nombre_producto")
                txt_cantidad.Text = ds2.Tables(dt2.TableName).Rows(0).Item("cantidad")
                cmb_categoria.Text = ds2.Tables(dt2.TableName).Rows(0).Item("categoria")
                cmb_bodega.Text = ds2.Tables(dt2.TableName).Rows(0).Item("ubicacion")

                txt_codigo.Text = ds2.Tables(dt2.TableName).Rows(0).Item("codigo")
                txt_descripcion.Text = ds2.Tables(dt2.TableName).Rows(0).Item("descripcion_producto")


                txt_registro.Text = ds2.Tables(dt2.TableName).Rows(0).Item("id_registro")

                lbl_fecha.Text = ds2.Tables(dt2.TableName).Rows(0).Item("fecha_ingreso")

                varseleccion = 3
                controles(False, True)
            End If
        End If
    End Sub

    Private Sub btn_crear_codigo_Click(sender As Object, e As EventArgs) Handles btn_crear_codigo.Click
        Dim bcode As New Barcode128
        bcode.BarHeight = 50
        bcode.Code = txt_codigo.Text
        bcode.GenerateChecksum = True
        bcode.CodeType = Barcode128.CODE128

        Try
            Dim bm As New Bitmap(bcode.CreateDrawingImage(Color.Black, Color.White))
            Dim img As Image
            img = New Bitmap(bm.Width, bm.Height)
            Dim g As Graphics = Graphics.FromImage(img)
            g.FillRectangle(New SolidBrush(Color.White), 0, 0, bm.Width, bm.Height)
            g.DrawImage(bm, 0, 0)
            PictureBox1.Image = img

        Catch ex As Exception
            MsgBox("no se pudo generar el codigo")

        End Try
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(PictureBox1.Width, PictureBox1.Height)
        PictureBox1.DrawToBitmap(bm, New Rectangle(0, 0, bm.Width, bm.Height))
        e.Graphics.DrawImage(bm, 0, 0)

    End Sub

    Private Sub btn_imprimir_codigo_Click(sender As Object, e As EventArgs) Handles btn_imprimir_codigo.Click
        PrintPreviewDialog1.Show()

    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        varseleccion = 2
        controles(True, False)
        mostrar_grilla()
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Eliminar()
        controles(False, True)
        mostrar_grilla()
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        limpiar()
        controles(False, True)
        mostrar_grilla()
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        buscar()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub
End Class
