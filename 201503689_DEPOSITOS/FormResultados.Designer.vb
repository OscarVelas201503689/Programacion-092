<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormResultados
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
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Txt_SaldoTtl = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Txt_InteresCalc = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.TxtInteres = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Txt_DepositoT = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Btn_Regresar = New System.Windows.Forms.Button()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Txt_SaldoTtl)
        Me.GroupBox8.Controls.Add(Me.Label8)
        Me.GroupBox8.Location = New System.Drawing.Point(752, 43)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(206, 85)
        Me.GroupBox8.TabIndex = 13
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Total Final"
        '
        'Txt_SaldoTtl
        '
        Me.Txt_SaldoTtl.Enabled = False
        Me.Txt_SaldoTtl.Location = New System.Drawing.Point(83, 42)
        Me.Txt_SaldoTtl.Name = "Txt_SaldoTtl"
        Me.Txt_SaldoTtl.Size = New System.Drawing.Size(100, 23)
        Me.Txt_SaldoTtl.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 15)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Saldo Total"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Txt_InteresCalc)
        Me.GroupBox7.Controls.Add(Me.Label7)
        Me.GroupBox7.Location = New System.Drawing.Point(489, 43)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(206, 85)
        Me.GroupBox7.TabIndex = 12
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Interes Calculado"
        '
        'Txt_InteresCalc
        '
        Me.Txt_InteresCalc.Enabled = False
        Me.Txt_InteresCalc.Location = New System.Drawing.Point(83, 42)
        Me.Txt_InteresCalc.Name = "Txt_InteresCalc"
        Me.Txt_InteresCalc.Size = New System.Drawing.Size(100, 23)
        Me.Txt_InteresCalc.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 15)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Total Interes"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.TxtInteres)
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Location = New System.Drawing.Point(246, 43)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(195, 85)
        Me.GroupBox6.TabIndex = 11
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Interes Total"
        '
        'TxtInteres
        '
        Me.TxtInteres.Enabled = False
        Me.TxtInteres.Location = New System.Drawing.Point(83, 42)
        Me.TxtInteres.Name = "TxtInteres"
        Me.TxtInteres.Size = New System.Drawing.Size(100, 23)
        Me.TxtInteres.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Valor Interes"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Txt_DepositoT)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 43)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(189, 85)
        Me.GroupBox5.TabIndex = 14
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "SubTotal después del Depósito"
        '
        'Txt_DepositoT
        '
        Me.Txt_DepositoT.Enabled = False
        Me.Txt_DepositoT.Location = New System.Drawing.Point(55, 40)
        Me.Txt_DepositoT.Name = "Txt_DepositoT"
        Me.Txt_DepositoT.Size = New System.Drawing.Size(100, 23)
        Me.Txt_DepositoT.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Q"
        '
        'Btn_Regresar
        '
        Me.Btn_Regresar.Location = New System.Drawing.Point(452, 167)
        Me.Btn_Regresar.Name = "Btn_Regresar"
        Me.Btn_Regresar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Regresar.TabIndex = 15
        Me.Btn_Regresar.Text = "Regresar"
        Me.Btn_Regresar.UseVisualStyleBackColor = True
        '
        'FormResultados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1003, 241)
        Me.Controls.Add(Me.Btn_Regresar)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Name = "FormResultados"
        Me.Text = "FormResultados"
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents Txt_SaldoTtl As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Txt_InteresCalc As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents TxtInteres As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Txt_DepositoT As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Btn_Regresar As Button
End Class
