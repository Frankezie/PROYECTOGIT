<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Retirar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Retirar))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_soporte = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.btn_imprimir_boleta = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_subtotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_finalizar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_grabar = New System.Windows.Forms.Button()
        Me.txt_nboleta = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_fecha = New System.Windows.Forms.Label()
        Me.cmb_pago = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_usu = New System.Windows.Forms.Label()
        Me.grilla_retirar = New System.Windows.Forms.DataGridView()
        Me.btn_venta = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_codigo = New System.Windows.Forms.TextBox()
        Me.txt_cantidad1 = New System.Windows.Forms.NumericUpDown()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_precio = New System.Windows.Forms.TextBox()
        Me.txt_margen = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_stock = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.txt_desc = New System.Windows.Forms.RichTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.Column0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grilla_retirar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_cantidad1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CODIGO:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.btn_buscar)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.lbl_fecha)
        Me.GroupBox1.Controls.Add(Me.txt_desc)
        Me.GroupBox1.Controls.Add(Me.txt_total)
        Me.GroupBox1.Controls.Add(Me.txt_stock)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lbl_usu)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txt_margen)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txt_precio)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txt_cantidad1)
        Me.GroupBox1.Controls.Add(Me.btn_soporte)
        Me.GroupBox1.Controls.Add(Me.Button9)
        Me.GroupBox1.Controls.Add(Me.Button8)
        Me.GroupBox1.Controls.Add(Me.Button7)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.btn_imprimir_boleta)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_subtotal)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btn_finalizar)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.grilla_retirar)
        Me.GroupBox1.Controls.Add(Me.btn_venta)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txt_codigo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(7, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1047, 635)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "VENTA"
        '
        'btn_soporte
        '
        Me.btn_soporte.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btn_soporte.Location = New System.Drawing.Point(788, 486)
        Me.btn_soporte.Name = "btn_soporte"
        Me.btn_soporte.Size = New System.Drawing.Size(150, 65)
        Me.btn_soporte.TabIndex = 43
        Me.btn_soporte.Text = "SOPORTE Y AYUDA"
        Me.btn_soporte.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(788, 392)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(150, 65)
        Me.Button9.TabIndex = 42
        Me.Button9.Text = "Button9"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(788, 291)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(150, 65)
        Me.Button8.TabIndex = 41
        Me.Button8.Text = "Button8"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(788, 197)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(150, 65)
        Me.Button7.TabIndex = 40
        Me.Button7.Text = "Button7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(788, 109)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(150, 65)
        Me.Button6.TabIndex = 39
        Me.Button6.Text = "Button6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'btn_imprimir_boleta
        '
        Me.btn_imprimir_boleta.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btn_imprimir_boleta.Location = New System.Drawing.Point(616, 430)
        Me.btn_imprimir_boleta.Name = "btn_imprimir_boleta"
        Me.btn_imprimir_boleta.Size = New System.Drawing.Size(137, 39)
        Me.btn_imprimir_boleta.TabIndex = 37
        Me.btn_imprimir_boleta.Text = "IMPRIMIR BOLETA"
        Me.btn_imprimir_boleta.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(371, 656)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "BOLETA:"
        '
        'txt_subtotal
        '
        Me.txt_subtotal.Enabled = False
        Me.txt_subtotal.Location = New System.Drawing.Point(170, 430)
        Me.txt_subtotal.Multiline = True
        Me.txt_subtotal.Name = "txt_subtotal"
        Me.txt_subtotal.Size = New System.Drawing.Size(132, 39)
        Me.txt_subtotal.TabIndex = 35
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(167, 656)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "SUBTOTAL:"
        '
        'btn_finalizar
        '
        Me.btn_finalizar.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btn_finalizar.Location = New System.Drawing.Point(812, 575)
        Me.btn_finalizar.Name = "btn_finalizar"
        Me.btn_finalizar.Size = New System.Drawing.Size(107, 39)
        Me.btn_finalizar.TabIndex = 33
        Me.btn_finalizar.Text = "FINALIZAR"
        Me.btn_finalizar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_grabar)
        Me.GroupBox2.Controls.Add(Me.txt_nboleta)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cmb_pago)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox2.Location = New System.Drawing.Point(10, 486)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(743, 78)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        '
        'btn_grabar
        '
        Me.btn_grabar.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btn_grabar.Location = New System.Drawing.Point(606, 17)
        Me.btn_grabar.Name = "btn_grabar"
        Me.btn_grabar.Size = New System.Drawing.Size(101, 42)
        Me.btn_grabar.TabIndex = 33
        Me.btn_grabar.Text = "GRABAR"
        Me.btn_grabar.UseVisualStyleBackColor = True
        '
        'txt_nboleta
        '
        Me.txt_nboleta.Location = New System.Drawing.Point(465, 29)
        Me.txt_nboleta.Name = "txt_nboleta"
        Me.txt_nboleta.Size = New System.Drawing.Size(82, 20)
        Me.txt_nboleta.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(392, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "N° BOLETA:"
        '
        'lbl_fecha
        '
        Me.lbl_fecha.AutoSize = True
        Me.lbl_fecha.BackColor = System.Drawing.Color.Transparent
        Me.lbl_fecha.ForeColor = System.Drawing.Color.White
        Me.lbl_fecha.Location = New System.Drawing.Point(337, 569)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(13, 13)
        Me.lbl_fecha.TabIndex = 12
        Me.lbl_fecha.Text = "1"
        '
        'cmb_pago
        '
        Me.cmb_pago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_pago.FormattingEnabled = True
        Me.cmb_pago.Items.AddRange(New Object() {"EFECTIVO", "CREDITO", "DEBITO", "TRANSFERENCIA"})
        Me.cmb_pago.Location = New System.Drawing.Point(230, 29)
        Me.cmb_pago.Name = "cmb_pago"
        Me.cmb_pago.Size = New System.Drawing.Size(139, 21)
        Me.cmb_pago.TabIndex = 34
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(184, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "PAGO:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(16, 567)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 15)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "VENDEDOR:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(279, 567)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 15)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "FECHA:"
        '
        'lbl_usu
        '
        Me.lbl_usu.AutoSize = True
        Me.lbl_usu.BackColor = System.Drawing.Color.Transparent
        Me.lbl_usu.ForeColor = System.Drawing.Color.White
        Me.lbl_usu.Location = New System.Drawing.Point(109, 569)
        Me.lbl_usu.Name = "lbl_usu"
        Me.lbl_usu.Size = New System.Drawing.Size(21, 13)
        Me.lbl_usu.TabIndex = 13
        Me.lbl_usu.Text = "AA"
        '
        'grilla_retirar
        '
        Me.grilla_retirar.AllowUserToAddRows = False
        Me.grilla_retirar.AllowUserToDeleteRows = False
        Me.grilla_retirar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla_retirar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column0, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grilla_retirar.DefaultCellStyle = DataGridViewCellStyle1
        Me.grilla_retirar.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grilla_retirar.Location = New System.Drawing.Point(10, 170)
        Me.grilla_retirar.Name = "grilla_retirar"
        Me.grilla_retirar.ReadOnly = True
        Me.grilla_retirar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grilla_retirar.Size = New System.Drawing.Size(743, 239)
        Me.grilla_retirar.TabIndex = 31
        '
        'btn_venta
        '
        Me.btn_venta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_venta.ForeColor = System.Drawing.Color.Black
        Me.btn_venta.Location = New System.Drawing.Point(788, 24)
        Me.btn_venta.Name = "btn_venta"
        Me.btn_venta.Size = New System.Drawing.Size(150, 61)
        Me.btn_venta.TabIndex = 28
        Me.btn_venta.Text = "A VENTA 2"
        Me.btn_venta.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(243, 31)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "CANTIDAD:"
        '
        'txt_codigo
        '
        Me.txt_codigo.Location = New System.Drawing.Point(62, 24)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(175, 20)
        Me.txt_codigo.TabIndex = 22
        '
        'txt_cantidad1
        '
        Me.txt_cantidad1.Location = New System.Drawing.Point(314, 26)
        Me.txt_cantidad1.Name = "txt_cantidad1"
        Me.txt_cantidad1.Size = New System.Drawing.Size(120, 20)
        Me.txt_cantidad1.TabIndex = 45
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Button1.Location = New System.Drawing.Point(676, 103)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 39)
        Me.Button1.TabIndex = 46
        Me.Button1.Text = "AGREGAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "PRECIO:"
        '
        'txt_precio
        '
        Me.txt_precio.Enabled = False
        Me.txt_precio.Location = New System.Drawing.Point(62, 65)
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(175, 20)
        Me.txt_precio.TabIndex = 48
        '
        'txt_margen
        '
        Me.txt_margen.Enabled = False
        Me.txt_margen.Location = New System.Drawing.Point(314, 65)
        Me.txt_margen.Name = "txt_margen"
        Me.txt_margen.Size = New System.Drawing.Size(175, 20)
        Me.txt_margen.TabIndex = 50
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(259, 72)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 13)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "MARGEN:"
        '
        'txt_stock
        '
        Me.txt_stock.Enabled = False
        Me.txt_stock.Location = New System.Drawing.Point(62, 109)
        Me.txt_stock.Name = "txt_stock"
        Me.txt_stock.Size = New System.Drawing.Size(175, 20)
        Me.txt_stock.TabIndex = 52
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(7, 116)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 13)
        Me.Label13.TabIndex = 51
        Me.Label13.Text = "STOCK:"
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(572, 65)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(175, 20)
        Me.txt_total.TabIndex = 54
        Me.txt_total.Visible = False
        '
        'txt_desc
        '
        Me.txt_desc.Enabled = False
        Me.txt_desc.Location = New System.Drawing.Point(340, 99)
        Me.txt_desc.Name = "txt_desc"
        Me.txt_desc.Size = New System.Drawing.Size(217, 63)
        Me.txt_desc.TabIndex = 55
        Me.txt_desc.Text = ""
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(251, 102)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(83, 13)
        Me.Label15.TabIndex = 56
        Me.Label15.Text = "DESCRIPCION:"
        '
        'btn_buscar
        '
        Me.btn_buscar.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btn_buscar.Location = New System.Drawing.Point(563, 102)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(107, 39)
        Me.btn_buscar.TabIndex = 57
        Me.btn_buscar.Text = "BUSCAR"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'Column0
        '
        Me.Column0.HeaderText = "CODIGO"
        Me.Column0.Name = "Column0"
        Me.Column0.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "DESCRIPCION"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "PRECIO"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "MARGEN"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "CANTIDAD"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "TOTAL"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "STOCK"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(119, 433)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 13)
        Me.Label14.TabIndex = 58
        Me.Label14.Text = "TOTAL:"
        '
        'Retirar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1165, 743)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Retirar"
        Me.Text = "Retirar"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.grilla_retirar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_cantidad1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_fecha As Label
    Friend WithEvents lbl_usu As Label
    Friend WithEvents txt_codigo As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btn_venta As Button
    Friend WithEvents grilla_retirar As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmb_pago As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_subtotal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_finalizar As Button
    Friend WithEvents btn_grabar As Button
    Friend WithEvents txt_nboleta As TextBox
    Friend WithEvents btn_soporte As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents btn_imprimir_boleta As Button
    Friend WithEvents txt_cantidad1 As NumericUpDown
    Friend WithEvents Button1 As Button
    Friend WithEvents txt_margen As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_precio As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_desc As RichTextBox
    Friend WithEvents txt_total As TextBox
    Friend WithEvents txt_stock As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents btn_buscar As Button
    Friend WithEvents Column0 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Label14 As Label
End Class
