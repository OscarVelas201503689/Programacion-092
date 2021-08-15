<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Radio_Ahorros = New System.Windows.Forms.RadioButton()
        Me.Radio_Premier = New System.Windows.Forms.RadioButton()
        Me.Radio_Monetario = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Check_Efectivo = New System.Windows.Forms.CheckBox()
        Me.Check_Otrob = New System.Windows.Forms.CheckBox()
        Me.Check_Propio = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Txt_Monto3 = New System.Windows.Forms.TextBox()
        Me.Txt_Monto2 = New System.Windows.Forms.TextBox()
        Me.Txt_Monto1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Txt_SaldoAnt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Btn_Calcular = New System.Windows.Forms.Button()
        Me.Btn_Limpiar = New System.Windows.Forms.Button()
        Me.Btn_Salir = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Radio_Ahorros)
        Me.GroupBox1.Controls.Add(Me.Radio_Premier)
        Me.GroupBox1.Controls.Add(Me.Radio_Monetario)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 208)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(280, 176)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione el tipo de depósito"
        '
        'Radio_Ahorros
        '
        Me.Radio_Ahorros.AutoSize = True
        Me.Radio_Ahorros.Location = New System.Drawing.Point(31, 133)
        Me.Radio_Ahorros.Name = "Radio_Ahorros"
        Me.Radio_Ahorros.Size = New System.Drawing.Size(67, 19)
        Me.Radio_Ahorros.TabIndex = 2
        Me.Radio_Ahorros.TabStop = True
        Me.Radio_Ahorros.Text = "Ahorros"
        Me.Radio_Ahorros.UseVisualStyleBackColor = True
        '
        'Radio_Premier
        '
        Me.Radio_Premier.AutoSize = True
        Me.Radio_Premier.Location = New System.Drawing.Point(31, 86)
        Me.Radio_Premier.Name = "Radio_Premier"
        Me.Radio_Premier.Size = New System.Drawing.Size(124, 19)
        Me.Radio_Premier.TabIndex = 1
        Me.Radio_Premier.TabStop = True
        Me.Radio_Premier.Text = "Monetario Premier"
        Me.Radio_Premier.UseVisualStyleBackColor = True
        '
        'Radio_Monetario
        '
        Me.Radio_Monetario.AutoSize = True
        Me.Radio_Monetario.Location = New System.Drawing.Point(31, 45)
        Me.Radio_Monetario.Name = "Radio_Monetario"
        Me.Radio_Monetario.Size = New System.Drawing.Size(80, 19)
        Me.Radio_Monetario.TabIndex = 0
        Me.Radio_Monetario.TabStop = True
        Me.Radio_Monetario.Text = "Monetario"
        Me.Radio_Monetario.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Check_Efectivo)
        Me.GroupBox2.Controls.Add(Me.Check_Otrob)
        Me.GroupBox2.Controls.Add(Me.Check_Propio)
        Me.GroupBox2.Location = New System.Drawing.Point(332, 208)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(301, 176)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Seleccione el Método de Depósito"
        '
        'Check_Efectivo
        '
        Me.Check_Efectivo.AutoSize = True
        Me.Check_Efectivo.Location = New System.Drawing.Point(29, 133)
        Me.Check_Efectivo.Name = "Check_Efectivo"
        Me.Check_Efectivo.Size = New System.Drawing.Size(68, 19)
        Me.Check_Efectivo.TabIndex = 2
        Me.Check_Efectivo.Text = "Efectivo"
        Me.Check_Efectivo.UseVisualStyleBackColor = True
        '
        'Check_Otrob
        '
        Me.Check_Otrob.AutoSize = True
        Me.Check_Otrob.Location = New System.Drawing.Point(29, 86)
        Me.Check_Otrob.Name = "Check_Otrob"
        Me.Check_Otrob.Size = New System.Drawing.Size(144, 19)
        Me.Check_Otrob.TabIndex = 1
        Me.Check_Otrob.Text = "Cheque de otro banco"
        Me.Check_Otrob.UseVisualStyleBackColor = True
        '
        'Check_Propio
        '
        Me.Check_Propio.AutoSize = True
        Me.Check_Propio.Location = New System.Drawing.Point(29, 45)
        Me.Check_Propio.Name = "Check_Propio"
        Me.Check_Propio.Size = New System.Drawing.Size(105, 19)
        Me.Check_Propio.TabIndex = 0
        Me.Check_Propio.Text = "Cheque Propio"
        Me.Check_Propio.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Txt_Monto3)
        Me.GroupBox3.Controls.Add(Me.Txt_Monto2)
        Me.GroupBox3.Controls.Add(Me.Txt_Monto1)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(668, 208)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(271, 176)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ingrese Monto a Depositar"
        '
        'Txt_Monto3
        '
        Me.Txt_Monto3.Enabled = False
        Me.Txt_Monto3.Location = New System.Drawing.Point(55, 129)
        Me.Txt_Monto3.Name = "Txt_Monto3"
        Me.Txt_Monto3.Size = New System.Drawing.Size(100, 23)
        Me.Txt_Monto3.TabIndex = 5
        Me.Txt_Monto3.Text = "0"
        '
        'Txt_Monto2
        '
        Me.Txt_Monto2.Enabled = False
        Me.Txt_Monto2.Location = New System.Drawing.Point(55, 86)
        Me.Txt_Monto2.Name = "Txt_Monto2"
        Me.Txt_Monto2.Size = New System.Drawing.Size(100, 23)
        Me.Txt_Monto2.TabIndex = 4
        Me.Txt_Monto2.Text = "0"
        '
        'Txt_Monto1
        '
        Me.Txt_Monto1.Enabled = False
        Me.Txt_Monto1.Location = New System.Drawing.Point(55, 40)
        Me.Txt_Monto1.Name = "Txt_Monto1"
        Me.Txt_Monto1.Size = New System.Drawing.Size(100, 23)
        Me.Txt_Monto1.TabIndex = 3
        Me.Txt_Monto1.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Q"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Q"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Q"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Txt_SaldoAnt)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Location = New System.Drawing.Point(957, 248)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(189, 85)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Ingrese Saldo Anterior"
        '
        'Txt_SaldoAnt
        '
        Me.Txt_SaldoAnt.Location = New System.Drawing.Point(55, 40)
        Me.Txt_SaldoAnt.Name = "Txt_SaldoAnt"
        Me.Txt_SaldoAnt.Size = New System.Drawing.Size(100, 23)
        Me.Txt_SaldoAnt.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 15)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Q"
        '
        'Btn_Calcular
        '
        Me.Btn_Calcular.Location = New System.Drawing.Point(481, 418)
        Me.Btn_Calcular.Name = "Btn_Calcular"
        Me.Btn_Calcular.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Calcular.TabIndex = 7
        Me.Btn_Calcular.Text = "Calcular"
        Me.Btn_Calcular.UseVisualStyleBackColor = True
        '
        'Btn_Limpiar
        '
        Me.Btn_Limpiar.Location = New System.Drawing.Point(588, 418)
        Me.Btn_Limpiar.Name = "Btn_Limpiar"
        Me.Btn_Limpiar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Limpiar.TabIndex = 8
        Me.Btn_Limpiar.Text = "Limpiar"
        Me.Btn_Limpiar.UseVisualStyleBackColor = True
        '
        'Btn_Salir
        '
        Me.Btn_Salir.Location = New System.Drawing.Point(696, 418)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Salir.TabIndex = 9
        Me.Btn_Salir.Text = "Salir"
        Me.Btn_Salir.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(41, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(731, 58)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "BANCA VIRTUAL OSCAR VELAS"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1158, 601)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Btn_Salir)
        Me.Controls.Add(Me.Btn_Limpiar)
        Me.Controls.Add(Me.Btn_Calcular)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.Text = "Banco OV S.A."
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Radio_Ahorros As RadioButton
    Friend WithEvents Radio_Premier As RadioButton
    Friend WithEvents Radio_Monetario As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Check_Efectivo As CheckBox
    Friend WithEvents Check_Otrob As CheckBox
    Friend WithEvents Check_Propio As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Txt_Monto3 As TextBox
    Friend WithEvents Txt_Monto2 As TextBox
    Friend WithEvents Txt_Monto1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Txt_SaldoAnt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Btn_Calcular As Button
    Friend WithEvents Btn_Limpiar As Button
    Friend WithEvents Btn_Salir As Button
    Friend WithEvents Label4 As Label
End Class
