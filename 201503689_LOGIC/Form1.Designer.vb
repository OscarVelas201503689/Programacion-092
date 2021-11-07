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
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OperarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MostrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdenarAscendenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdenarDescendenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarEntradasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarVectoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DPI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VALOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MESES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TASA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Gray
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(639, 126)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INGRESOS"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(436, 71)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 23)
        Me.TextBox4.TabIndex = 7
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(436, 33)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 23)
        Me.TextBox3.TabIndex = 6
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(148, 71)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 23)
        Me.TextBox2.TabIndex = 5
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(47, 33)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 23)
        Me.TextBox1.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(294, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "MESES PARA PAGAR"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(294, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "VALOR DEL ARTÍCULO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NOMBRE DEL CLIENTE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DPI"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OperarToolStripMenuItem, Me.MostrarToolStripMenuItem, Me.OrdenarAscendenteToolStripMenuItem, Me.OrdenarDescendenteToolStripMenuItem, Me.LimpiarEntradasToolStripMenuItem, Me.LimpiarVectoresToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(709, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OperarToolStripMenuItem
        '
        Me.OperarToolStripMenuItem.Name = "OperarToolStripMenuItem"
        Me.OperarToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.OperarToolStripMenuItem.Text = "Operar"
        '
        'MostrarToolStripMenuItem
        '
        Me.MostrarToolStripMenuItem.Name = "MostrarToolStripMenuItem"
        Me.MostrarToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.MostrarToolStripMenuItem.Text = "Mostrar"
        '
        'OrdenarAscendenteToolStripMenuItem
        '
        Me.OrdenarAscendenteToolStripMenuItem.Name = "OrdenarAscendenteToolStripMenuItem"
        Me.OrdenarAscendenteToolStripMenuItem.Size = New System.Drawing.Size(127, 20)
        Me.OrdenarAscendenteToolStripMenuItem.Text = "Ordenar Ascendente"
        '
        'OrdenarDescendenteToolStripMenuItem
        '
        Me.OrdenarDescendenteToolStripMenuItem.Name = "OrdenarDescendenteToolStripMenuItem"
        Me.OrdenarDescendenteToolStripMenuItem.Size = New System.Drawing.Size(133, 20)
        Me.OrdenarDescendenteToolStripMenuItem.Text = "Ordenar Descendente"
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
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DPI, Me.NOMBRE, Me.VALOR, Me.MESES, Me.TASA, Me.TOTAL})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 181)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(639, 248)
        Me.DataGridView1.TabIndex = 2
        '
        'DPI
        '
        Me.DPI.HeaderText = "DPI"
        Me.DPI.Name = "DPI"
        '
        'NOMBRE
        '
        Me.NOMBRE.HeaderText = "NOMBRE"
        Me.NOMBRE.Name = "NOMBRE"
        '
        'VALOR
        '
        Me.VALOR.HeaderText = "VALOR"
        Me.VALOR.Name = "VALOR"
        '
        'MESES
        '
        Me.MESES.HeaderText = "MESES"
        Me.MESES.Name = "MESES"
        '
        'TASA
        '
        Me.TASA.HeaderText = "TASA"
        Me.TASA.Name = "TASA"
        '
        'TOTAL
        '
        Me.TOTAL.HeaderText = "TOTAL"
        Me.TOTAL.Name = "TOTAL"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(709, 470)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Electrodomésticos Logic O.V."
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OperarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MostrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrdenarAscendenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrdenarDescendenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarEntradasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarVectoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DPI As DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE As DataGridViewTextBoxColumn
    Friend WithEvents VALOR As DataGridViewTextBoxColumn
    Friend WithEvents MESES As DataGridViewTextBoxColumn
    Friend WithEvents TASA As DataGridViewTextBoxColumn
    Friend WithEvents TOTAL As DataGridViewTextBoxColumn
End Class
