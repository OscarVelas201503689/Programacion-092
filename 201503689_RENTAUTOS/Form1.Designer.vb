<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Txt_dias = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Combo_Marca = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_Placa = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_Nit = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Txt_Tarjeta = New System.Windows.Forms.TextBox()
        Me.Txt_efectivo = New System.Windows.Forms.TextBox()
        Me.Check_Tarjeta = New System.Windows.Forms.CheckBox()
        Me.Check_Efectivo = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.List_Total = New System.Windows.Forms.ListBox()
        Me.List_Descuento = New System.Windows.Forms.ListBox()
        Me.List_Parcial = New System.Windows.Forms.ListBox()
        Me.List_Dias = New System.Windows.Forms.ListBox()
        Me.List_Marca = New System.Windows.Forms.ListBox()
        Me.List_Placa = New System.Windows.Forms.ListBox()
        Me.List_Nit = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CalcularToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarEntradasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarVectoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarListasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Txt_dias)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Combo_Marca)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Txt_Placa)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Txt_Nit)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(278, 213)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Ingreso"
        '
        'Txt_dias
        '
        Me.Txt_dias.Location = New System.Drawing.Point(109, 163)
        Me.Txt_dias.Name = "Txt_dias"
        Me.Txt_dias.Size = New System.Drawing.Size(100, 23)
        Me.Txt_dias.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Días a alquilar"
        '
        'Combo_Marca
        '
        Me.Combo_Marca.FormattingEnabled = True
        Me.Combo_Marca.Items.AddRange(New Object() {"Honda", "Mercedes Benz", "Toyota", "Mazda"})
        Me.Combo_Marca.Location = New System.Drawing.Point(109, 118)
        Me.Combo_Marca.Name = "Combo_Marca"
        Me.Combo_Marca.Size = New System.Drawing.Size(121, 23)
        Me.Combo_Marca.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Escoja Marca"
        '
        'Txt_Placa
        '
        Me.Txt_Placa.Location = New System.Drawing.Point(109, 74)
        Me.Txt_Placa.Name = "Txt_Placa"
        Me.Txt_Placa.Size = New System.Drawing.Size(100, 23)
        Me.Txt_Placa.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ingrese Placa"
        '
        'Txt_Nit
        '
        Me.Txt_Nit.Location = New System.Drawing.Point(109, 30)
        Me.Txt_Nit.Name = "Txt_Nit"
        Me.Txt_Nit.Size = New System.Drawing.Size(100, 23)
        Me.Txt_Nit.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese su NIT"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Txt_Tarjeta)
        Me.GroupBox2.Controls.Add(Me.Txt_efectivo)
        Me.GroupBox2.Controls.Add(Me.Check_Tarjeta)
        Me.GroupBox2.Controls.Add(Me.Check_Efectivo)
        Me.GroupBox2.Location = New System.Drawing.Point(318, 85)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(244, 123)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Método de Pago"
        '
        'Txt_Tarjeta
        '
        Me.Txt_Tarjeta.Enabled = False
        Me.Txt_Tarjeta.Location = New System.Drawing.Point(119, 79)
        Me.Txt_Tarjeta.Name = "Txt_Tarjeta"
        Me.Txt_Tarjeta.Size = New System.Drawing.Size(100, 23)
        Me.Txt_Tarjeta.TabIndex = 9
        '
        'Txt_efectivo
        '
        Me.Txt_efectivo.Enabled = False
        Me.Txt_efectivo.Location = New System.Drawing.Point(119, 26)
        Me.Txt_efectivo.Name = "Txt_efectivo"
        Me.Txt_efectivo.Size = New System.Drawing.Size(100, 23)
        Me.Txt_efectivo.TabIndex = 8
        '
        'Check_Tarjeta
        '
        Me.Check_Tarjeta.AutoSize = True
        Me.Check_Tarjeta.Location = New System.Drawing.Point(29, 81)
        Me.Check_Tarjeta.Name = "Check_Tarjeta"
        Me.Check_Tarjeta.Size = New System.Drawing.Size(60, 19)
        Me.Check_Tarjeta.TabIndex = 3
        Me.Check_Tarjeta.Text = "Tarjeta"
        Me.Check_Tarjeta.UseVisualStyleBackColor = True
        '
        'Check_Efectivo
        '
        Me.Check_Efectivo.AutoSize = True
        Me.Check_Efectivo.Location = New System.Drawing.Point(29, 30)
        Me.Check_Efectivo.Name = "Check_Efectivo"
        Me.Check_Efectivo.Size = New System.Drawing.Size(68, 19)
        Me.Check_Efectivo.TabIndex = 2
        Me.Check_Efectivo.Text = "Efectivo"
        Me.Check_Efectivo.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.DodgerBlue
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.List_Total)
        Me.GroupBox3.Controls.Add(Me.List_Descuento)
        Me.GroupBox3.Controls.Add(Me.List_Parcial)
        Me.GroupBox3.Controls.Add(Me.List_Dias)
        Me.GroupBox3.Controls.Add(Me.List_Marca)
        Me.GroupBox3.Controls.Add(Me.List_Placa)
        Me.GroupBox3.Controls.Add(Me.List_Nit)
        Me.GroupBox3.Location = New System.Drawing.Point(18, 265)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(899, 291)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Resultados"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(627, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(130, 15)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "DESCUENTO/RECARGO"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(510, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 15)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "PAGO PARCIAL"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(384, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 15)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "DÍAS A ALQUILAR"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(258, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(49, 15)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "MARCA"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(132, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "PLACA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "NIT"
        '
        'List_Total
        '
        Me.List_Total.FormattingEnabled = True
        Me.List_Total.ItemHeight = 15
        Me.List_Total.Location = New System.Drawing.Point(762, 46)
        Me.List_Total.Name = "List_Total"
        Me.List_Total.Size = New System.Drawing.Size(120, 229)
        Me.List_Total.TabIndex = 6
        '
        'List_Descuento
        '
        Me.List_Descuento.FormattingEnabled = True
        Me.List_Descuento.ItemHeight = 15
        Me.List_Descuento.Location = New System.Drawing.Point(636, 46)
        Me.List_Descuento.Name = "List_Descuento"
        Me.List_Descuento.Size = New System.Drawing.Size(120, 229)
        Me.List_Descuento.TabIndex = 5
        '
        'List_Parcial
        '
        Me.List_Parcial.FormattingEnabled = True
        Me.List_Parcial.ItemHeight = 15
        Me.List_Parcial.Location = New System.Drawing.Point(510, 46)
        Me.List_Parcial.Name = "List_Parcial"
        Me.List_Parcial.Size = New System.Drawing.Size(120, 229)
        Me.List_Parcial.TabIndex = 4
        '
        'List_Dias
        '
        Me.List_Dias.FormattingEnabled = True
        Me.List_Dias.ItemHeight = 15
        Me.List_Dias.Location = New System.Drawing.Point(384, 46)
        Me.List_Dias.Name = "List_Dias"
        Me.List_Dias.Size = New System.Drawing.Size(120, 229)
        Me.List_Dias.TabIndex = 3
        '
        'List_Marca
        '
        Me.List_Marca.FormattingEnabled = True
        Me.List_Marca.ItemHeight = 15
        Me.List_Marca.Location = New System.Drawing.Point(258, 46)
        Me.List_Marca.Name = "List_Marca"
        Me.List_Marca.Size = New System.Drawing.Size(120, 229)
        Me.List_Marca.TabIndex = 2
        '
        'List_Placa
        '
        Me.List_Placa.FormattingEnabled = True
        Me.List_Placa.ItemHeight = 15
        Me.List_Placa.Location = New System.Drawing.Point(132, 46)
        Me.List_Placa.Name = "List_Placa"
        Me.List_Placa.Size = New System.Drawing.Size(120, 229)
        Me.List_Placa.TabIndex = 1
        '
        'List_Nit
        '
        Me.List_Nit.FormattingEnabled = True
        Me.List_Nit.ItemHeight = 15
        Me.List_Nit.Location = New System.Drawing.Point(6, 46)
        Me.List_Nit.Name = "List_Nit"
        Me.List_Nit.Size = New System.Drawing.Size(120, 229)
        Me.List_Nit.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalcularToolStripMenuItem, Me.LimpiarEntradasToolStripMenuItem, Me.LimpiarVectoresToolStripMenuItem, Me.LimpiarListasToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(941, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CalcularToolStripMenuItem
        '
        Me.CalcularToolStripMenuItem.Name = "CalcularToolStripMenuItem"
        Me.CalcularToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.CalcularToolStripMenuItem.Text = "&Calcular"
        '
        'LimpiarEntradasToolStripMenuItem
        '
        Me.LimpiarEntradasToolStripMenuItem.Name = "LimpiarEntradasToolStripMenuItem"
        Me.LimpiarEntradasToolStripMenuItem.Size = New System.Drawing.Size(107, 20)
        Me.LimpiarEntradasToolStripMenuItem.Text = "Limpiar Entradas"
        '
        'LimpiarVectoresToolStripMenuItem
        '
        Me.LimpiarVectoresToolStripMenuItem.Name = "LimpiarVectoresToolStripMenuItem"
        Me.LimpiarVectoresToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.LimpiarVectoresToolStripMenuItem.Text = "Limpiar Vectores"
        '
        'LimpiarListasToolStripMenuItem
        '
        Me.LimpiarListasToolStripMenuItem.Name = "LimpiarListasToolStripMenuItem"
        Me.LimpiarListasToolStripMenuItem.Size = New System.Drawing.Size(91, 20)
        Me.LimpiarListasToolStripMenuItem.Text = "Limpiar Listas"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global._201503689_RENTAUTOS.My.Resources.Resources._67437424_389976118299099_3140512548198023168_n
        Me.PictureBox1.Location = New System.Drawing.Point(575, 39)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(342, 220)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(763, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(39, 15)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "TOTAL"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(941, 568)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "RENTA AUTOS OV"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Txt_dias As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Combo_Marca As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Txt_Placa As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_Nit As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Check_Tarjeta As CheckBox
    Friend WithEvents Check_Efectivo As CheckBox
    Friend WithEvents Txt_Tarjeta As TextBox
    Friend WithEvents Txt_efectivo As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents List_Total As ListBox
    Friend WithEvents List_Descuento As ListBox
    Friend WithEvents List_Parcial As ListBox
    Friend WithEvents List_Dias As ListBox
    Friend WithEvents List_Marca As ListBox
    Friend WithEvents List_Placa As ListBox
    Friend WithEvents List_Nit As ListBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CalcularToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarEntradasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarVectoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarListasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label11 As Label
End Class
