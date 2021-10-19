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
        Me.Btn_LimpiarE = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Text_TotalDaños = New System.Windows.Forms.TextBox()
        Me.Combo_Registro = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Combo_Taller = New System.Windows.Forms.ComboBox()
        Me.Combo_Genero = New System.Windows.Forms.ComboBox()
        Me.Text_Daños = New System.Windows.Forms.TextBox()
        Me.Text_Edad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Text_totalDed = New System.Windows.Forms.TextBox()
        Me.Btn_Deducibles = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.List_Daños = New System.Windows.Forms.ListBox()
        Me.List_Deducible = New System.Windows.Forms.ListBox()
        Me.List_Taller = New System.Windows.Forms.ListBox()
        Me.List_Registro = New System.Windows.Forms.ListBox()
        Me.List_Genero = New System.Windows.Forms.ListBox()
        Me.List_Edad = New System.Windows.Forms.ListBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Text_M25 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Text_GF = New System.Windows.Forms.TextBox()
        Me.Text_GM1825 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Text_Rext = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Text_TotalCond = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Btn_LimpiarEs = New System.Windows.Forms.Button()
        Me.Btn_Salir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Turquoise
        Me.GroupBox1.Controls.Add(Me.Btn_LimpiarE)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Text_TotalDaños)
        Me.GroupBox1.Controls.Add(Me.Combo_Registro)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Combo_Taller)
        Me.GroupBox1.Controls.Add(Me.Combo_Genero)
        Me.GroupBox1.Controls.Add(Me.Text_Daños)
        Me.GroupBox1.Controls.Add(Me.Text_Edad)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(959, 243)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS DEL CONDUCTOR"
        '
        'Btn_LimpiarE
        '
        Me.Btn_LimpiarE.Location = New System.Drawing.Point(240, 202)
        Me.Btn_LimpiarE.Name = "Btn_LimpiarE"
        Me.Btn_LimpiarE.Size = New System.Drawing.Size(118, 23)
        Me.Btn_LimpiarE.TabIndex = 27
        Me.Btn_LimpiarE.Text = "Limpiar Entradas"
        Me.Btn_LimpiarE.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(781, 159)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 26
        Me.Button5.Text = "Total"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Text_TotalDaños
        '
        Me.Text_TotalDaños.Location = New System.Drawing.Point(771, 112)
        Me.Text_TotalDaños.Name = "Text_TotalDaños"
        Me.Text_TotalDaños.Size = New System.Drawing.Size(96, 23)
        Me.Text_TotalDaños.TabIndex = 25
        '
        'Combo_Registro
        '
        Me.Combo_Registro.FormattingEnabled = True
        Me.Combo_Registro.Items.AddRange(New Object() {"1 - Guatemalteco", "0 - Extranjero"})
        Me.Combo_Registro.Location = New System.Drawing.Point(120, 117)
        Me.Combo_Registro.Name = "Combo_Registro"
        Me.Combo_Registro.Size = New System.Drawing.Size(178, 23)
        Me.Combo_Registro.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(687, 92)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(248, 15)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Total de los montos de los daños ocasionados"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(499, 186)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(118, 23)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Limpiar Vectores"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(499, 136)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Mostrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(499, 88)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Combo_Taller
        '
        Me.Combo_Taller.FormattingEnabled = True
        Me.Combo_Taller.Items.AddRange(New Object() {"Taller de Confianza", "Taller de Aseguradora"})
        Me.Combo_Taller.Location = New System.Drawing.Point(499, 32)
        Me.Combo_Taller.Name = "Combo_Taller"
        Me.Combo_Taller.Size = New System.Drawing.Size(178, 23)
        Me.Combo_Taller.TabIndex = 9
        '
        'Combo_Genero
        '
        Me.Combo_Genero.FormattingEnabled = True
        Me.Combo_Genero.Items.AddRange(New Object() {"M", "F"})
        Me.Combo_Genero.Location = New System.Drawing.Point(57, 69)
        Me.Combo_Genero.Name = "Combo_Genero"
        Me.Combo_Genero.Size = New System.Drawing.Size(178, 23)
        Me.Combo_Genero.TabIndex = 8
        '
        'Text_Daños
        '
        Me.Text_Daños.Location = New System.Drawing.Point(203, 164)
        Me.Text_Daños.Name = "Text_Daños"
        Me.Text_Daños.Size = New System.Drawing.Size(178, 23)
        Me.Text_Daños.TabIndex = 6
        '
        'Text_Edad
        '
        Me.Text_Edad.Location = New System.Drawing.Point(57, 32)
        Me.Text_Edad.Name = "Text_Edad"
        Me.Text_Edad.Size = New System.Drawing.Size(178, 23)
        Me.Text_Edad.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(459, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Taller"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(181, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Monto de los daños ocasionados"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Código de Registro"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Género"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Edad"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Text_totalDed)
        Me.GroupBox2.Controls.Add(Me.Btn_Deducibles)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.List_Daños)
        Me.GroupBox2.Controls.Add(Me.List_Deducible)
        Me.GroupBox2.Controls.Add(Me.List_Taller)
        Me.GroupBox2.Controls.Add(Me.List_Registro)
        Me.GroupBox2.Controls.Add(Me.List_Genero)
        Me.GroupBox2.Controls.Add(Me.List_Edad)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 262)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(823, 363)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DATOS ALMACENADOS"
        '
        'Text_totalDed
        '
        Me.Text_totalDed.Enabled = False
        Me.Text_totalDed.Location = New System.Drawing.Point(651, 328)
        Me.Text_totalDed.Name = "Text_totalDed"
        Me.Text_totalDed.Size = New System.Drawing.Size(100, 23)
        Me.Text_totalDed.TabIndex = 19
        '
        'Btn_Deducibles
        '
        Me.Btn_Deducibles.Location = New System.Drawing.Point(539, 327)
        Me.Btn_Deducibles.Name = "Btn_Deducibles"
        Me.Btn_Deducibles.Size = New System.Drawing.Size(106, 23)
        Me.Btn_Deducibles.TabIndex = 18
        Me.Btn_Deducibles.Text = "Total Deducibles"
        Me.Btn_Deducibles.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(651, 19)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(65, 15)
        Me.Label17.TabIndex = 17
        Me.Label17.Text = "Deducibles"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(525, 19)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(106, 15)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "Taller de Confianza"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(399, 19)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 15)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "Daños"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(273, 19)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 15)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Registro"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(144, 19)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 15)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Género"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(18, 23)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 15)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Edades"
        '
        'List_Daños
        '
        Me.List_Daños.FormattingEnabled = True
        Me.List_Daños.ItemHeight = 15
        Me.List_Daños.Location = New System.Drawing.Point(399, 47)
        Me.List_Daños.Name = "List_Daños"
        Me.List_Daños.Size = New System.Drawing.Size(120, 274)
        Me.List_Daños.TabIndex = 11
        '
        'List_Deducible
        '
        Me.List_Deducible.FormattingEnabled = True
        Me.List_Deducible.ItemHeight = 15
        Me.List_Deducible.Location = New System.Drawing.Point(651, 47)
        Me.List_Deducible.Name = "List_Deducible"
        Me.List_Deducible.Size = New System.Drawing.Size(120, 274)
        Me.List_Deducible.TabIndex = 9
        '
        'List_Taller
        '
        Me.List_Taller.FormattingEnabled = True
        Me.List_Taller.ItemHeight = 15
        Me.List_Taller.Location = New System.Drawing.Point(525, 47)
        Me.List_Taller.Name = "List_Taller"
        Me.List_Taller.Size = New System.Drawing.Size(120, 274)
        Me.List_Taller.TabIndex = 10
        '
        'List_Registro
        '
        Me.List_Registro.FormattingEnabled = True
        Me.List_Registro.ItemHeight = 15
        Me.List_Registro.Location = New System.Drawing.Point(273, 47)
        Me.List_Registro.Name = "List_Registro"
        Me.List_Registro.Size = New System.Drawing.Size(120, 274)
        Me.List_Registro.TabIndex = 8
        '
        'List_Genero
        '
        Me.List_Genero.FormattingEnabled = True
        Me.List_Genero.ItemHeight = 15
        Me.List_Genero.Location = New System.Drawing.Point(144, 47)
        Me.List_Genero.Name = "List_Genero"
        Me.List_Genero.Size = New System.Drawing.Size(120, 274)
        Me.List_Genero.TabIndex = 7
        '
        'List_Edad
        '
        Me.List_Edad.FormattingEnabled = True
        Me.List_Edad.ItemHeight = 15
        Me.List_Edad.Location = New System.Drawing.Point(18, 47)
        Me.List_Edad.Name = "List_Edad"
        Me.List_Edad.Size = New System.Drawing.Size(120, 274)
        Me.List_Edad.TabIndex = 6
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(1028, 291)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(78, 23)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Estadísticas"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(934, 344)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(183, 15)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Conductores menores de 25 años"
        '
        'Text_M25
        '
        Me.Text_M25.Location = New System.Drawing.Point(1133, 339)
        Me.Text_M25.Name = "Text_M25"
        Me.Text_M25.Size = New System.Drawing.Size(97, 23)
        Me.Text_M25.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(934, 379)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(185, 15)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Conductores de género femenino"
        '
        'Text_GF
        '
        Me.Text_GF.Location = New System.Drawing.Point(1134, 379)
        Me.Text_GF.Name = "Text_GF"
        Me.Text_GF.Size = New System.Drawing.Size(96, 23)
        Me.Text_GF.TabIndex = 17
        '
        'Text_GM1825
        '
        Me.Text_GM1825.Location = New System.Drawing.Point(1134, 420)
        Me.Text_GM1825.Name = "Text_GM1825"
        Me.Text_GM1825.Size = New System.Drawing.Size(96, 23)
        Me.Text_GM1825.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(854, 423)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(265, 15)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Conductores de género masculino de 18-25 años"
        '
        'Text_Rext
        '
        Me.Text_Rext.Location = New System.Drawing.Point(1133, 459)
        Me.Text_Rext.Name = "Text_Rext"
        Me.Text_Rext.Size = New System.Drawing.Size(96, 23)
        Me.Text_Rext.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(922, 462)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(197, 15)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Conductores con registro extranjero"
        '
        'Text_TotalCond
        '
        Me.Text_TotalCond.Location = New System.Drawing.Point(1134, 498)
        Me.Text_TotalCond.Name = "Text_TotalCond"
        Me.Text_TotalCond.Size = New System.Drawing.Size(96, 23)
        Me.Text_TotalCond.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(938, 501)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(179, 15)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Total de Conductores Ingresados"
        '
        'Btn_LimpiarEs
        '
        Me.Btn_LimpiarEs.Location = New System.Drawing.Point(1013, 560)
        Me.Btn_LimpiarEs.Name = "Btn_LimpiarEs"
        Me.Btn_LimpiarEs.Size = New System.Drawing.Size(118, 23)
        Me.Btn_LimpiarEs.TabIndex = 28
        Me.Btn_LimpiarEs.Text = "Limpiar Estadísticas"
        Me.Btn_LimpiarEs.UseVisualStyleBackColor = True
        '
        'Btn_Salir
        '
        Me.Btn_Salir.Location = New System.Drawing.Point(1071, 114)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(118, 23)
        Me.Btn_Salir.TabIndex = 29
        Me.Btn_Salir.Text = "Salir"
        Me.Btn_Salir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1269, 629)
        Me.Controls.Add(Me.Btn_Salir)
        Me.Controls.Add(Me.Btn_LimpiarEs)
        Me.Controls.Add(Me.Text_TotalCond)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Text_Rext)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Text_GM1825)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Text_GF)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Text_M25)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "AGENCIA DE SEGUROS O.V."
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Combo_Registro As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Combo_Taller As ComboBox
    Friend WithEvents Combo_Genero As ComboBox
    Friend WithEvents Text_Daños As TextBox
    Friend WithEvents Text_Edad As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents List_Daños As ListBox
    Friend WithEvents List_Deducible As ListBox
    Friend WithEvents List_Taller As ListBox
    Friend WithEvents List_Registro As ListBox
    Friend WithEvents List_Genero As ListBox
    Friend WithEvents List_Edad As ListBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Text_M25 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Text_GF As TextBox
    Friend WithEvents Text_GM1825 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Text_Rext As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Text_TotalCond As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Text_TotalDaños As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Text_totalDed As TextBox
    Friend WithEvents Btn_Deducibles As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Btn_LimpiarE As Button
    Friend WithEvents Btn_LimpiarEs As Button
    Friend WithEvents Btn_Salir As Button
End Class
