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
        Me.Txt_entradas = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Combo_Cine = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Combo_Funcion = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.List_Total = New System.Windows.Forms.ListBox()
        Me.List_Desc2 = New System.Windows.Forms.ListBox()
        Me.List_Desc1 = New System.Windows.Forms.ListBox()
        Me.List_SubTotal = New System.Windows.Forms.ListBox()
        Me.List_Entradas = New System.Windows.Forms.ListBox()
        Me.List_Cine = New System.Windows.Forms.ListBox()
        Me.List_Funcion = New System.Windows.Forms.ListBox()
        Me.Btn_Calcular = New System.Windows.Forms.Button()
        Me.Btn_LimpiarL = New System.Windows.Forms.Button()
        Me.Btn_LimpiarE = New System.Windows.Forms.Button()
        Me.Btn_LimpiarV = New System.Windows.Forms.Button()
        Me.Btn_Salir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.GroupBox1.Controls.Add(Me.Txt_entradas)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Combo_Cine)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Combo_Funcion)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(313, 163)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso de Datos"
        '
        'Txt_entradas
        '
        Me.Txt_entradas.Location = New System.Drawing.Point(130, 109)
        Me.Txt_entradas.Name = "Txt_entradas"
        Me.Txt_entradas.Size = New System.Drawing.Size(100, 23)
        Me.Txt_entradas.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Número de entradas"
        '
        'Combo_Cine
        '
        Me.Combo_Cine.FormattingEnabled = True
        Me.Combo_Cine.Items.AddRange(New Object() {"A", "B", "C"})
        Me.Combo_Cine.Location = New System.Drawing.Point(130, 72)
        Me.Combo_Cine.Name = "Combo_Cine"
        Me.Combo_Cine.Size = New System.Drawing.Size(121, 23)
        Me.Combo_Cine.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Seleccione Cine"
        '
        'Combo_Funcion
        '
        Me.Combo_Funcion.FormattingEnabled = True
        Me.Combo_Funcion.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.Combo_Funcion.Location = New System.Drawing.Point(130, 26)
        Me.Combo_Funcion.Name = "Combo_Funcion"
        Me.Combo_Funcion.Size = New System.Drawing.Size(121, 23)
        Me.Combo_Funcion.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleccione Función"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.List_Total)
        Me.GroupBox2.Controls.Add(Me.List_Desc2)
        Me.GroupBox2.Controls.Add(Me.List_Desc1)
        Me.GroupBox2.Controls.Add(Me.List_SubTotal)
        Me.GroupBox2.Controls.Add(Me.List_Entradas)
        Me.GroupBox2.Controls.Add(Me.List_Cine)
        Me.GroupBox2.Controls.Add(Me.List_Funcion)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 215)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1005, 237)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultados"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(855, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 15)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Total"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(711, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 15)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Descuento 2"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(572, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 15)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Descuento 1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(428, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 15)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Subtotal"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(289, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 15)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Número de entradas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(145, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Cine"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Función"
        '
        'List_Total
        '
        Me.List_Total.FormattingEnabled = True
        Me.List_Total.ItemHeight = 15
        Me.List_Total.Location = New System.Drawing.Point(853, 43)
        Me.List_Total.Name = "List_Total"
        Me.List_Total.Size = New System.Drawing.Size(120, 169)
        Me.List_Total.TabIndex = 6
        '
        'List_Desc2
        '
        Me.List_Desc2.FormattingEnabled = True
        Me.List_Desc2.ItemHeight = 15
        Me.List_Desc2.Location = New System.Drawing.Point(711, 43)
        Me.List_Desc2.Name = "List_Desc2"
        Me.List_Desc2.Size = New System.Drawing.Size(120, 169)
        Me.List_Desc2.TabIndex = 5
        '
        'List_Desc1
        '
        Me.List_Desc1.FormattingEnabled = True
        Me.List_Desc1.ItemHeight = 15
        Me.List_Desc1.Location = New System.Drawing.Point(574, 43)
        Me.List_Desc1.Name = "List_Desc1"
        Me.List_Desc1.Size = New System.Drawing.Size(120, 169)
        Me.List_Desc1.TabIndex = 4
        '
        'List_SubTotal
        '
        Me.List_SubTotal.FormattingEnabled = True
        Me.List_SubTotal.ItemHeight = 15
        Me.List_SubTotal.Location = New System.Drawing.Point(428, 43)
        Me.List_SubTotal.Name = "List_SubTotal"
        Me.List_SubTotal.Size = New System.Drawing.Size(120, 169)
        Me.List_SubTotal.TabIndex = 3
        '
        'List_Entradas
        '
        Me.List_Entradas.FormattingEnabled = True
        Me.List_Entradas.ItemHeight = 15
        Me.List_Entradas.Location = New System.Drawing.Point(289, 43)
        Me.List_Entradas.Name = "List_Entradas"
        Me.List_Entradas.Size = New System.Drawing.Size(120, 169)
        Me.List_Entradas.TabIndex = 2
        '
        'List_Cine
        '
        Me.List_Cine.FormattingEnabled = True
        Me.List_Cine.ItemHeight = 15
        Me.List_Cine.Location = New System.Drawing.Point(145, 43)
        Me.List_Cine.Name = "List_Cine"
        Me.List_Cine.Size = New System.Drawing.Size(120, 169)
        Me.List_Cine.TabIndex = 1
        '
        'List_Funcion
        '
        Me.List_Funcion.FormattingEnabled = True
        Me.List_Funcion.ItemHeight = 15
        Me.List_Funcion.Location = New System.Drawing.Point(7, 43)
        Me.List_Funcion.Name = "List_Funcion"
        Me.List_Funcion.Size = New System.Drawing.Size(120, 169)
        Me.List_Funcion.TabIndex = 0
        '
        'Btn_Calcular
        '
        Me.Btn_Calcular.Location = New System.Drawing.Point(383, 186)
        Me.Btn_Calcular.Name = "Btn_Calcular"
        Me.Btn_Calcular.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Calcular.TabIndex = 2
        Me.Btn_Calcular.Text = "Calcular"
        Me.Btn_Calcular.UseVisualStyleBackColor = True
        '
        'Btn_LimpiarL
        '
        Me.Btn_LimpiarL.Location = New System.Drawing.Point(464, 186)
        Me.Btn_LimpiarL.Name = "Btn_LimpiarL"
        Me.Btn_LimpiarL.Size = New System.Drawing.Size(98, 23)
        Me.Btn_LimpiarL.TabIndex = 3
        Me.Btn_LimpiarL.Text = "Limpiar Listas"
        Me.Btn_LimpiarL.UseVisualStyleBackColor = True
        '
        'Btn_LimpiarE
        '
        Me.Btn_LimpiarE.Location = New System.Drawing.Point(568, 186)
        Me.Btn_LimpiarE.Name = "Btn_LimpiarE"
        Me.Btn_LimpiarE.Size = New System.Drawing.Size(113, 23)
        Me.Btn_LimpiarE.TabIndex = 4
        Me.Btn_LimpiarE.Text = "Limpiar Entradas"
        Me.Btn_LimpiarE.UseVisualStyleBackColor = True
        '
        'Btn_LimpiarV
        '
        Me.Btn_LimpiarV.Location = New System.Drawing.Point(687, 186)
        Me.Btn_LimpiarV.Name = "Btn_LimpiarV"
        Me.Btn_LimpiarV.Size = New System.Drawing.Size(109, 23)
        Me.Btn_LimpiarV.TabIndex = 5
        Me.Btn_LimpiarV.Text = "Limpiar Vectores"
        Me.Btn_LimpiarV.UseVisualStyleBackColor = True
        '
        'Btn_Salir
        '
        Me.Btn_Salir.Location = New System.Drawing.Point(802, 186)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Salir.TabIndex = 6
        Me.Btn_Salir.Text = "Salir"
        Me.Btn_Salir.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global._201503689_CINE.My.Resources.Resources.banner_1155437_960_720
        Me.PictureBox1.Location = New System.Drawing.Point(385, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(492, 153)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1043, 460)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Btn_Salir)
        Me.Controls.Add(Me.Btn_LimpiarV)
        Me.Controls.Add(Me.Btn_LimpiarE)
        Me.Controls.Add(Me.Btn_LimpiarL)
        Me.Controls.Add(Me.Btn_Calcular)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "SISTEMA DE COBRO CINES GT"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Txt_entradas As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Combo_Cine As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Combo_Funcion As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents List_Total As ListBox
    Friend WithEvents List_Desc2 As ListBox
    Friend WithEvents List_Desc1 As ListBox
    Friend WithEvents List_SubTotal As ListBox
    Friend WithEvents List_Entradas As ListBox
    Friend WithEvents List_Cine As ListBox
    Friend WithEvents List_Funcion As ListBox
    Friend WithEvents Btn_Calcular As Button
    Friend WithEvents Btn_LimpiarL As Button
    Friend WithEvents Btn_LimpiarE As Button
    Friend WithEvents Btn_LimpiarV As Button
    Friend WithEvents Btn_Salir As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
