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
        Me.Radio_king = New System.Windows.Forms.RadioButton()
        Me.Radio_queen = New System.Windows.Forms.RadioButton()
        Me.Radio_mat = New System.Windows.Forms.RadioButton()
        Me.Radio_Imperial = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Check_Hiloc = New System.Windows.Forms.CheckBox()
        Me.Check_Seda = New System.Windows.Forms.CheckBox()
        Me.Check_Alg = New System.Windows.Forms.CheckBox()
        Me.Check_Lino = New System.Windows.Forms.CheckBox()
        Me.Txt_lino = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CalcularToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_Total = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Txt_Hiloc = New System.Windows.Forms.TextBox()
        Me.Txt_seda = New System.Windows.Forms.TextBox()
        Me.Txt_algodon = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Txt_venta = New System.Windows.Forms.TextBox()
        Me.Txt_THiloc = New System.Windows.Forms.TextBox()
        Me.Txt_TSeda = New System.Windows.Forms.TextBox()
        Me.Txt_TAlg = New System.Windows.Forms.TextBox()
        Me.Txt_TLino = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Radio_king)
        Me.GroupBox1.Controls.Add(Me.Radio_queen)
        Me.GroupBox1.Controls.Add(Me.Radio_mat)
        Me.GroupBox1.Controls.Add(Me.Radio_Imperial)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(227, 195)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione el tipo de Cubrecama"
        '
        'Radio_king
        '
        Me.Radio_king.AutoSize = True
        Me.Radio_king.Location = New System.Drawing.Point(30, 153)
        Me.Radio_king.Name = "Radio_king"
        Me.Radio_king.Size = New System.Drawing.Size(49, 19)
        Me.Radio_king.TabIndex = 3
        Me.Radio_king.TabStop = True
        Me.Radio_king.Text = "King"
        Me.Radio_king.UseVisualStyleBackColor = True
        '
        'Radio_queen
        '
        Me.Radio_queen.AutoSize = True
        Me.Radio_queen.Location = New System.Drawing.Point(30, 117)
        Me.Radio_queen.Name = "Radio_queen"
        Me.Radio_queen.Size = New System.Drawing.Size(60, 19)
        Me.Radio_queen.TabIndex = 2
        Me.Radio_queen.TabStop = True
        Me.Radio_queen.Text = "Queen"
        Me.Radio_queen.UseVisualStyleBackColor = True
        '
        'Radio_mat
        '
        Me.Radio_mat.AutoSize = True
        Me.Radio_mat.Location = New System.Drawing.Point(30, 74)
        Me.Radio_mat.Name = "Radio_mat"
        Me.Radio_mat.Size = New System.Drawing.Size(90, 19)
        Me.Radio_mat.TabIndex = 1
        Me.Radio_mat.TabStop = True
        Me.Radio_mat.Text = "Matrimonial"
        Me.Radio_mat.UseVisualStyleBackColor = True
        '
        'Radio_Imperial
        '
        Me.Radio_Imperial.AutoSize = True
        Me.Radio_Imperial.Location = New System.Drawing.Point(30, 33)
        Me.Radio_Imperial.Name = "Radio_Imperial"
        Me.Radio_Imperial.Size = New System.Drawing.Size(68, 19)
        Me.Radio_Imperial.TabIndex = 0
        Me.Radio_Imperial.TabStop = True
        Me.Radio_Imperial.Text = "Imperial"
        Me.Radio_Imperial.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Check_Hiloc)
        Me.GroupBox2.Controls.Add(Me.Check_Seda)
        Me.GroupBox2.Controls.Add(Me.Check_Alg)
        Me.GroupBox2.Controls.Add(Me.Check_Lino)
        Me.GroupBox2.Location = New System.Drawing.Point(306, 54)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(271, 195)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Seleccione el tipo de material"
        '
        'Check_Hiloc
        '
        Me.Check_Hiloc.AutoSize = True
        Me.Check_Hiloc.Location = New System.Drawing.Point(30, 153)
        Me.Check_Hiloc.Name = "Check_Hiloc"
        Me.Check_Hiloc.Size = New System.Drawing.Size(84, 19)
        Me.Check_Hiloc.TabIndex = 3
        Me.Check_Hiloc.Text = "Hilo Crudo"
        Me.Check_Hiloc.UseVisualStyleBackColor = True
        '
        'Check_Seda
        '
        Me.Check_Seda.AutoSize = True
        Me.Check_Seda.Location = New System.Drawing.Point(30, 117)
        Me.Check_Seda.Name = "Check_Seda"
        Me.Check_Seda.Size = New System.Drawing.Size(51, 19)
        Me.Check_Seda.TabIndex = 2
        Me.Check_Seda.Text = "Seda"
        Me.Check_Seda.UseVisualStyleBackColor = True
        '
        'Check_Alg
        '
        Me.Check_Alg.AutoSize = True
        Me.Check_Alg.Location = New System.Drawing.Point(30, 74)
        Me.Check_Alg.Name = "Check_Alg"
        Me.Check_Alg.Size = New System.Drawing.Size(72, 19)
        Me.Check_Alg.TabIndex = 1
        Me.Check_Alg.Text = "Algodón"
        Me.Check_Alg.UseVisualStyleBackColor = True
        '
        'Check_Lino
        '
        Me.Check_Lino.AutoSize = True
        Me.Check_Lino.Location = New System.Drawing.Point(30, 33)
        Me.Check_Lino.Name = "Check_Lino"
        Me.Check_Lino.Size = New System.Drawing.Size(49, 19)
        Me.Check_Lino.TabIndex = 0
        Me.Check_Lino.Text = "Lino"
        Me.Check_Lino.UseVisualStyleBackColor = True
        '
        'Txt_lino
        '
        Me.Txt_lino.Enabled = False
        Me.Txt_lino.Location = New System.Drawing.Point(89, 29)
        Me.Txt_lino.Name = "Txt_lino"
        Me.Txt_lino.Size = New System.Drawing.Size(102, 23)
        Me.Txt_lino.TabIndex = 3
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalcularToolStripMenuItem, Me.LimpiarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(865, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CalcularToolStripMenuItem
        '
        Me.CalcularToolStripMenuItem.Name = "CalcularToolStripMenuItem"
        Me.CalcularToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.CalcularToolStripMenuItem.Text = "&Calcular"
        '
        'LimpiarToolStripMenuItem
        '
        Me.LimpiarToolStripMenuItem.Name = "LimpiarToolStripMenuItem"
        Me.LimpiarToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.LimpiarToolStripMenuItem.Text = "&Limpiar"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Precio de Costo Total"
        '
        'Txt_Total
        '
        Me.Txt_Total.Location = New System.Drawing.Point(164, 39)
        Me.Txt_Total.Name = "Txt_Total"
        Me.Txt_Total.Size = New System.Drawing.Size(100, 23)
        Me.Txt_Total.TabIndex = 6
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.Txt_Hiloc)
        Me.GroupBox3.Controls.Add(Me.Txt_seda)
        Me.GroupBox3.Controls.Add(Me.Txt_algodon)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Txt_lino)
        Me.GroupBox3.Location = New System.Drawing.Point(609, 54)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(228, 195)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ingrese las Yardas"
        '
        'Txt_Hiloc
        '
        Me.Txt_Hiloc.Enabled = False
        Me.Txt_Hiloc.Location = New System.Drawing.Point(89, 157)
        Me.Txt_Hiloc.Name = "Txt_Hiloc"
        Me.Txt_Hiloc.Size = New System.Drawing.Size(102, 23)
        Me.Txt_Hiloc.TabIndex = 10
        '
        'Txt_seda
        '
        Me.Txt_seda.Enabled = False
        Me.Txt_seda.Location = New System.Drawing.Point(89, 115)
        Me.Txt_seda.Name = "Txt_seda"
        Me.Txt_seda.Size = New System.Drawing.Size(102, 23)
        Me.Txt_seda.TabIndex = 9
        '
        'Txt_algodon
        '
        Me.Txt_algodon.Enabled = False
        Me.Txt_algodon.Location = New System.Drawing.Point(89, 72)
        Me.Txt_algodon.Name = "Txt_algodon"
        Me.Txt_algodon.Size = New System.Drawing.Size(102, 23)
        Me.Txt_algodon.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Hilo Crudo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Seda"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Algodón"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Lino"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Txt_venta)
        Me.GroupBox4.Controls.Add(Me.Txt_THiloc)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Txt_TSeda)
        Me.GroupBox4.Controls.Add(Me.Txt_Total)
        Me.GroupBox4.Controls.Add(Me.Txt_TAlg)
        Me.GroupBox4.Controls.Add(Me.Txt_TLino)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Location = New System.Drawing.Point(32, 270)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(805, 185)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Resultados"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(19, 103)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 15)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Precio de Venta"
        '
        'Txt_venta
        '
        Me.Txt_venta.Location = New System.Drawing.Point(164, 95)
        Me.Txt_venta.Name = "Txt_venta"
        Me.Txt_venta.Size = New System.Drawing.Size(100, 23)
        Me.Txt_venta.TabIndex = 20
        '
        'Txt_THiloc
        '
        Me.Txt_THiloc.Enabled = False
        Me.Txt_THiloc.Location = New System.Drawing.Point(451, 142)
        Me.Txt_THiloc.Name = "Txt_THiloc"
        Me.Txt_THiloc.Size = New System.Drawing.Size(102, 23)
        Me.Txt_THiloc.TabIndex = 18
        '
        'Txt_TSeda
        '
        Me.Txt_TSeda.Enabled = False
        Me.Txt_TSeda.Location = New System.Drawing.Point(451, 103)
        Me.Txt_TSeda.Name = "Txt_TSeda"
        Me.Txt_TSeda.Size = New System.Drawing.Size(102, 23)
        Me.Txt_TSeda.TabIndex = 17
        '
        'Txt_TAlg
        '
        Me.Txt_TAlg.Enabled = False
        Me.Txt_TAlg.Location = New System.Drawing.Point(451, 65)
        Me.Txt_TAlg.Name = "Txt_TAlg"
        Me.Txt_TAlg.Size = New System.Drawing.Size(102, 23)
        Me.Txt_TAlg.TabIndex = 16
        '
        'Txt_TLino
        '
        Me.Txt_TLino.Enabled = False
        Me.Txt_TLino.Location = New System.Drawing.Point(451, 20)
        Me.Txt_TLino.Name = "Txt_TLino"
        Me.Txt_TLino.Size = New System.Drawing.Size(102, 23)
        Me.Txt_TLino.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(352, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 15)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Total Hilo Crudo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(354, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 15)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Total Lino"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(352, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 15)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Total Seda"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(352, 68)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 15)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Total Algodón"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(865, 476)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Fábrica de Cubrecamas O.V."
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Radio_king As RadioButton
    Friend WithEvents Radio_queen As RadioButton
    Friend WithEvents Radio_mat As RadioButton
    Friend WithEvents Radio_Imperial As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Check_Hiloc As CheckBox
    Friend WithEvents Check_Seda As CheckBox
    Friend WithEvents Check_Alg As CheckBox
    Friend WithEvents Check_Lino As CheckBox
    Friend WithEvents Txt_lino As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CalcularToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_Total As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Txt_Hiloc As TextBox
    Friend WithEvents Txt_seda As TextBox
    Friend WithEvents Txt_algodon As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Txt_venta As TextBox
    Friend WithEvents Txt_THiloc As TextBox
    Friend WithEvents Txt_TSeda As TextBox
    Friend WithEvents Txt_TAlg As TextBox
    Friend WithEvents Txt_TLino As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
