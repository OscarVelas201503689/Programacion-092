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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextNombre = New System.Windows.Forms.TextBox()
        Me.TextCarnet = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BTN_SALIR = New System.Windows.Forms.Button()
        Me.BTN_LIMPIARM = New System.Windows.Forms.Button()
        Me.BTN_MOSTRAR = New System.Windows.Forms.Button()
        Me.BTN_ACEPTAR = New System.Windows.Forms.Button()
        Me.ComboFPago = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboDiver = New System.Windows.Forms.ComboBox()
        Me.RadioDiver = New System.Windows.Forms.RadioButton()
        Me.RadioBasico = New System.Windows.Forms.RadioButton()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CARNET = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NIVEL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIVERSIFICADO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INSCRIPCION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CARRERA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MENSUALIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RECARGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Text_InscDisGr = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Text_InscElec = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Text_InscBach = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Text_InscPer = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Text_TotalDiver = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Text_TotalBas = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Text_TotalDep = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Text_TotalTransf = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Text_TotalTarj = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Text_TotalEfe = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Text_TotalG = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Btn_Resultados = New System.Windows.Forms.Button()
        Me.BTN_LIMPIAR_RES = New System.Windows.Forms.Button()
        Me.BTN_FILA = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NOMBRE DEL ALUMNO"
        '
        'TextNombre
        '
        Me.TextNombre.Location = New System.Drawing.Point(174, 32)
        Me.TextNombre.Name = "TextNombre"
        Me.TextNombre.Size = New System.Drawing.Size(100, 23)
        Me.TextNombre.TabIndex = 1
        '
        'TextCarnet
        '
        Me.TextCarnet.Location = New System.Drawing.Point(174, 80)
        Me.TextCarnet.Name = "TextCarnet"
        Me.TextCarnet.Size = New System.Drawing.Size(100, 23)
        Me.TextCarnet.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "CARNET"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.BTN_SALIR)
        Me.GroupBox1.Controls.Add(Me.BTN_LIMPIARM)
        Me.GroupBox1.Controls.Add(Me.BTN_MOSTRAR)
        Me.GroupBox1.Controls.Add(Me.BTN_ACEPTAR)
        Me.GroupBox1.Controls.Add(Me.ComboFPago)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ComboDiver)
        Me.GroupBox1.Controls.Add(Me.RadioDiver)
        Me.GroupBox1.Controls.Add(Me.RadioBasico)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextCarnet)
        Me.GroupBox1.Controls.Add(Me.TextNombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1052, 157)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INGRESO"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(702, 128)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "LIMPIAR ENTRADAS"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BTN_SALIR
        '
        Me.BTN_SALIR.Location = New System.Drawing.Point(851, 128)
        Me.BTN_SALIR.Name = "BTN_SALIR"
        Me.BTN_SALIR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BTN_SALIR.Size = New System.Drawing.Size(75, 23)
        Me.BTN_SALIR.TabIndex = 12
        Me.BTN_SALIR.Text = "SALIR"
        Me.BTN_SALIR.UseVisualStyleBackColor = True
        '
        'BTN_LIMPIARM
        '
        Me.BTN_LIMPIARM.Location = New System.Drawing.Point(908, 84)
        Me.BTN_LIMPIARM.Name = "BTN_LIMPIARM"
        Me.BTN_LIMPIARM.Size = New System.Drawing.Size(113, 23)
        Me.BTN_LIMPIARM.TabIndex = 11
        Me.BTN_LIMPIARM.Text = "LIMPIAR MATRIZ"
        Me.BTN_LIMPIARM.UseVisualStyleBackColor = True
        '
        'BTN_MOSTRAR
        '
        Me.BTN_MOSTRAR.Location = New System.Drawing.Point(809, 84)
        Me.BTN_MOSTRAR.Name = "BTN_MOSTRAR"
        Me.BTN_MOSTRAR.Size = New System.Drawing.Size(75, 23)
        Me.BTN_MOSTRAR.TabIndex = 10
        Me.BTN_MOSTRAR.Text = "MOSTRAR"
        Me.BTN_MOSTRAR.UseVisualStyleBackColor = True
        '
        'BTN_ACEPTAR
        '
        Me.BTN_ACEPTAR.Location = New System.Drawing.Point(702, 84)
        Me.BTN_ACEPTAR.Name = "BTN_ACEPTAR"
        Me.BTN_ACEPTAR.Size = New System.Drawing.Size(75, 23)
        Me.BTN_ACEPTAR.TabIndex = 9
        Me.BTN_ACEPTAR.Text = "ACEPTAR"
        Me.BTN_ACEPTAR.UseVisualStyleBackColor = True
        '
        'ComboFPago
        '
        Me.ComboFPago.FormattingEnabled = True
        Me.ComboFPago.Items.AddRange(New Object() {"EFECTIVO", "TARJETA DE CREDITO", "TRANSFERENCIA ACH", "DEPOSITO BANCARIO"})
        Me.ComboFPago.Location = New System.Drawing.Point(819, 29)
        Me.ComboFPago.Name = "ComboFPago"
        Me.ComboFPago.Size = New System.Drawing.Size(107, 23)
        Me.ComboFPago.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(702, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "FORMA DE PAGO"
        '
        'ComboDiver
        '
        Me.ComboDiver.Enabled = False
        Me.ComboDiver.FormattingEnabled = True
        Me.ComboDiver.Items.AddRange(New Object() {"PERITO CONTADOR", "BACHILLERATO", "ELECTRONICA", "DISEÑO GRAFICO"})
        Me.ComboDiver.Location = New System.Drawing.Point(490, 84)
        Me.ComboDiver.Name = "ComboDiver"
        Me.ComboDiver.Size = New System.Drawing.Size(107, 23)
        Me.ComboDiver.TabIndex = 6
        '
        'RadioDiver
        '
        Me.RadioDiver.AutoSize = True
        Me.RadioDiver.Location = New System.Drawing.Point(356, 84)
        Me.RadioDiver.Name = "RadioDiver"
        Me.RadioDiver.Size = New System.Drawing.Size(107, 19)
        Me.RadioDiver.TabIndex = 5
        Me.RadioDiver.TabStop = True
        Me.RadioDiver.Text = "DIVERSIFICADO"
        Me.RadioDiver.UseVisualStyleBackColor = True
        '
        'RadioBasico
        '
        Me.RadioBasico.AutoSize = True
        Me.RadioBasico.Location = New System.Drawing.Point(356, 36)
        Me.RadioBasico.Name = "RadioBasico"
        Me.RadioBasico.Size = New System.Drawing.Size(66, 19)
        Me.RadioBasico.TabIndex = 4
        Me.RadioBasico.TabStop = True
        Me.RadioBasico.Text = "BÁSICO"
        Me.RadioBasico.UseVisualStyleBackColor = True
        '
        'NOMBRE
        '
        Me.NOMBRE.HeaderText = "NOMBRE"
        Me.NOMBRE.Name = "NOMBRE"
        '
        'CARNET
        '
        Me.CARNET.HeaderText = "CARNET"
        Me.CARNET.Name = "CARNET"
        '
        'NIVEL
        '
        Me.NIVEL.HeaderText = "NIVEL"
        Me.NIVEL.Name = "NIVEL"
        '
        'DIVERSIFICADO
        '
        Me.DIVERSIFICADO.HeaderText = "DIVERSIFICADO"
        Me.DIVERSIFICADO.Name = "DIVERSIFICADO"
        '
        'INSCRIPCION
        '
        Me.INSCRIPCION.HeaderText = "INSCRIPCION"
        Me.INSCRIPCION.Name = "INSCRIPCION"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "NOMBRE"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "CARNET"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "NIVEL"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'CARRERA
        '
        Me.CARRERA.HeaderText = "CARRERA"
        Me.CARRERA.Name = "CARRERA"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "INSCRIPCION"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'MENSUALIDAD
        '
        Me.MENSUALIDAD.HeaderText = "MENSUALIDAD"
        Me.MENSUALIDAD.Name = "MENSUALIDAD"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "NOMBRE"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "CARNET"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "NIVEL"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "CARRERA"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "INSCRIPCION"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "MENSUALIDAD"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "NOMBRE"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "CARNET"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.HeaderText = "NIVEL"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.HeaderText = "CARRERA"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.HeaderText = "INSCRIPCION"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.HeaderText = "MENSUALIDAD"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.RECARGO, Me.TOTAL})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 175)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(1051, 178)
        Me.DataGridView1.TabIndex = 5
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.HeaderText = "NOMBRE"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.HeaderText = "CARNET"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.HeaderText = "NIVEL"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.HeaderText = "CARRERA"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.HeaderText = "INSCRIPCION"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.HeaderText = "MENSUALIDAD"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.HeaderText = "PAGO INICIAL"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.HeaderText = "FORMA DE PAGO"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'RECARGO
        '
        Me.RECARGO.HeaderText = "RECARGO"
        Me.RECARGO.Name = "RECARGO"
        '
        'TOTAL
        '
        Me.TOTAL.HeaderText = "TOTAL"
        Me.TOTAL.Name = "TOTAL"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Text_InscDisGr)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Text_InscElec)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Text_InscBach)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Text_InscPer)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Text_TotalDiver)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Text_TotalBas)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Text_TotalDep)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Text_TotalTransf)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Text_TotalTarj)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Text_TotalEfe)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Text_TotalG)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 359)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(965, 233)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "RESULTADOS"
        '
        'Text_InscDisGr
        '
        Me.Text_InscDisGr.Location = New System.Drawing.Point(851, 181)
        Me.Text_InscDisGr.Name = "Text_InscDisGr"
        Me.Text_InscDisGr.Size = New System.Drawing.Size(100, 23)
        Me.Text_InscDisGr.TabIndex = 21
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(730, 184)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(112, 15)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "INSC. DISEÑO GRAF"
        '
        'Text_InscElec
        '
        Me.Text_InscElec.Location = New System.Drawing.Point(610, 181)
        Me.Text_InscElec.Name = "Text_InscElec"
        Me.Text_InscElec.Size = New System.Drawing.Size(100, 23)
        Me.Text_InscElec.TabIndex = 19
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(489, 184)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(115, 15)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "INSC. ELECTRONICA"
        '
        'Text_InscBach
        '
        Me.Text_InscBach.Location = New System.Drawing.Point(354, 181)
        Me.Text_InscBach.Name = "Text_InscBach"
        Me.Text_InscBach.Size = New System.Drawing.Size(100, 23)
        Me.Text_InscBach.TabIndex = 17
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(252, 184)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 15)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "INSC. BACH"
        '
        'Text_InscPer
        '
        Me.Text_InscPer.Location = New System.Drawing.Point(118, 181)
        Me.Text_InscPer.Name = "Text_InscPer"
        Me.Text_InscPer.Size = New System.Drawing.Size(100, 23)
        Me.Text_InscPer.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(16, 184)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 15)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "INSC. PERITO"
        '
        'Text_TotalDiver
        '
        Me.Text_TotalDiver.Location = New System.Drawing.Point(392, 126)
        Me.Text_TotalDiver.Name = "Text_TotalDiver"
        Me.Text_TotalDiver.Size = New System.Drawing.Size(100, 23)
        Me.Text_TotalDiver.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(252, 129)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 15)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "TOTAL DIVERSIFICADO"
        '
        'Text_TotalBas
        '
        Me.Text_TotalBas.Location = New System.Drawing.Point(125, 126)
        Me.Text_TotalBas.Name = "Text_TotalBas"
        Me.Text_TotalBas.Size = New System.Drawing.Size(100, 23)
        Me.Text_TotalBas.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 129)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 15)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "TOTAL BASICO"
        '
        'Text_TotalDep
        '
        Me.Text_TotalDep.Location = New System.Drawing.Point(839, 70)
        Me.Text_TotalDep.Name = "Text_TotalDep"
        Me.Text_TotalDep.Size = New System.Drawing.Size(100, 23)
        Me.Text_TotalDep.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(730, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 15)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "TOTAL DEPOSITO"
        '
        'Text_TotalTransf
        '
        Me.Text_TotalTransf.Location = New System.Drawing.Point(598, 70)
        Me.Text_TotalTransf.Name = "Text_TotalTransf"
        Me.Text_TotalTransf.Size = New System.Drawing.Size(100, 23)
        Me.Text_TotalTransf.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(489, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "TOTAL TRANSF."
        '
        'Text_TotalTarj
        '
        Me.Text_TotalTarj.Location = New System.Drawing.Point(361, 70)
        Me.Text_TotalTarj.Name = "Text_TotalTarj"
        Me.Text_TotalTarj.Size = New System.Drawing.Size(100, 23)
        Me.Text_TotalTarj.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(252, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 15)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "TOTAL TARJETA"
        '
        'Text_TotalEfe
        '
        Me.Text_TotalEfe.Location = New System.Drawing.Point(125, 70)
        Me.Text_TotalEfe.Name = "Text_TotalEfe"
        Me.Text_TotalEfe.Size = New System.Drawing.Size(100, 23)
        Me.Text_TotalEfe.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 15)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "TOTAL EFECTIVO"
        '
        'Text_TotalG
        '
        Me.Text_TotalG.Location = New System.Drawing.Point(125, 25)
        Me.Text_TotalG.Name = "Text_TotalG"
        Me.Text_TotalG.Size = New System.Drawing.Size(100, 23)
        Me.Text_TotalG.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "TOTAL GENERAL"
        '
        'Btn_Resultados
        '
        Me.Btn_Resultados.Location = New System.Drawing.Point(983, 480)
        Me.Btn_Resultados.Name = "Btn_Resultados"
        Me.Btn_Resultados.Size = New System.Drawing.Size(85, 23)
        Me.Btn_Resultados.TabIndex = 7
        Me.Btn_Resultados.Text = "RESULTADOS"
        Me.Btn_Resultados.UseVisualStyleBackColor = True
        '
        'BTN_LIMPIAR_RES
        '
        Me.BTN_LIMPIAR_RES.Location = New System.Drawing.Point(983, 509)
        Me.BTN_LIMPIAR_RES.Name = "BTN_LIMPIAR_RES"
        Me.BTN_LIMPIAR_RES.Size = New System.Drawing.Size(85, 23)
        Me.BTN_LIMPIAR_RES.TabIndex = 8
        Me.BTN_LIMPIAR_RES.Text = "LIMPIAR"
        Me.BTN_LIMPIAR_RES.UseVisualStyleBackColor = True
        '
        'BTN_FILA
        '
        Me.BTN_FILA.Location = New System.Drawing.Point(983, 451)
        Me.BTN_FILA.Name = "BTN_FILA"
        Me.BTN_FILA.Size = New System.Drawing.Size(85, 23)
        Me.BTN_FILA.TabIndex = 9
        Me.BTN_FILA.Text = "ELIM. FILA"
        Me.BTN_FILA.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(1075, 604)
        Me.Controls.Add(Me.BTN_FILA)
        Me.Controls.Add(Me.BTN_LIMPIAR_RES)
        Me.Controls.Add(Me.Btn_Resultados)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Camino del Saber O.V."
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextNombre As TextBox
    Friend WithEvents TextCarnet As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboFPago As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboDiver As ComboBox
    Friend WithEvents RadioDiver As RadioButton
    Friend WithEvents RadioBasico As RadioButton
    Friend WithEvents NOMBRE As DataGridViewTextBoxColumn
    Friend WithEvents CARNET As DataGridViewTextBoxColumn
    Friend WithEvents NIVEL As DataGridViewTextBoxColumn
    Friend WithEvents DIVERSIFICADO As DataGridViewTextBoxColumn
    Friend WithEvents INSCRIPCION As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents CARRERA As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents MENSUALIDAD As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents RECARGO As DataGridViewTextBoxColumn
    Friend WithEvents TOTAL As DataGridViewTextBoxColumn
    Friend WithEvents BTN_MOSTRAR As Button
    Friend WithEvents BTN_ACEPTAR As Button
    Friend WithEvents BTN_LIMPIARM As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Text_TotalDiver As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Text_TotalBas As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Text_TotalDep As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Text_TotalTransf As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Text_TotalTarj As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Text_TotalEfe As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Text_TotalG As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Text_InscDisGr As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Text_InscElec As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Text_InscBach As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Text_InscPer As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Btn_Resultados As Button
    Friend WithEvents BTN_LIMPIAR_RES As Button
    Friend WithEvents BTN_SALIR As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BTN_FILA As Button
End Class
