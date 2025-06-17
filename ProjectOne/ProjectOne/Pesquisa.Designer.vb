<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pesquisa
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
        Me.textPesquisa = New System.Windows.Forms.TextBox()
        Me.rbNome = New System.Windows.Forms.RadioButton()
        Me.rbEndereco = New System.Windows.Forms.RadioButton()
        Me.rbCelular = New System.Windows.Forms.RadioButton()
        Me.rbTelefone = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbEmail = New System.Windows.Forms.RadioButton()
        Me.dgvResultado = New System.Windows.Forms.DataGridView()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'textPesquisa
        '
        Me.textPesquisa.Location = New System.Drawing.Point(199, 24)
        Me.textPesquisa.Name = "textPesquisa"
        Me.textPesquisa.Size = New System.Drawing.Size(285, 20)
        Me.textPesquisa.TabIndex = 0
        '
        'rbNome
        '
        Me.rbNome.AutoSize = True
        Me.rbNome.Checked = True
        Me.rbNome.Location = New System.Drawing.Point(10, 20)
        Me.rbNome.Name = "rbNome"
        Me.rbNome.Size = New System.Drawing.Size(53, 17)
        Me.rbNome.TabIndex = 2
        Me.rbNome.TabStop = True
        Me.rbNome.Text = "Nome"
        Me.rbNome.UseVisualStyleBackColor = True
        '
        'rbEndereco
        '
        Me.rbEndereco.AutoSize = True
        Me.rbEndereco.Location = New System.Drawing.Point(10, 43)
        Me.rbEndereco.Name = "rbEndereco"
        Me.rbEndereco.Size = New System.Drawing.Size(71, 17)
        Me.rbEndereco.TabIndex = 3
        Me.rbEndereco.Text = "Endereço"
        Me.rbEndereco.UseVisualStyleBackColor = True
        '
        'rbCelular
        '
        Me.rbCelular.AutoSize = True
        Me.rbCelular.Location = New System.Drawing.Point(10, 66)
        Me.rbCelular.Name = "rbCelular"
        Me.rbCelular.Size = New System.Drawing.Size(57, 17)
        Me.rbCelular.TabIndex = 4
        Me.rbCelular.Text = "Celular"
        Me.rbCelular.UseVisualStyleBackColor = True
        '
        'rbTelefone
        '
        Me.rbTelefone.AutoSize = True
        Me.rbTelefone.Location = New System.Drawing.Point(10, 89)
        Me.rbTelefone.Name = "rbTelefone"
        Me.rbTelefone.Size = New System.Drawing.Size(67, 17)
        Me.rbTelefone.TabIndex = 5
        Me.rbTelefone.Text = "Telefone"
        Me.rbTelefone.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbEmail)
        Me.GroupBox1.Controls.Add(Me.rbCelular)
        Me.GroupBox1.Controls.Add(Me.rbTelefone)
        Me.GroupBox1.Controls.Add(Me.rbNome)
        Me.GroupBox1.Controls.Add(Me.rbEndereco)
        Me.GroupBox1.Location = New System.Drawing.Point(704, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(119, 135)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pesquisar por:"
        '
        'rbEmail
        '
        Me.rbEmail.AutoSize = True
        Me.rbEmail.Location = New System.Drawing.Point(10, 112)
        Me.rbEmail.Name = "rbEmail"
        Me.rbEmail.Size = New System.Drawing.Size(53, 17)
        Me.rbEmail.TabIndex = 6
        Me.rbEmail.Text = "E-mail"
        Me.rbEmail.UseVisualStyleBackColor = True
        '
        'dgvResultado
        '
        Me.dgvResultado.AllowUserToAddRows = False
        Me.dgvResultado.AllowUserToDeleteRows = False
        Me.dgvResultado.AllowUserToResizeRows = False
        Me.dgvResultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResultado.Location = New System.Drawing.Point(12, 67)
        Me.dgvResultado.Name = "dgvResultado"
        Me.dgvResultado.ReadOnly = True
        Me.dgvResultado.Size = New System.Drawing.Size(677, 135)
        Me.dgvResultado.TabIndex = 7
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Location = New System.Drawing.Point(501, 24)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(119, 20)
        Me.btnPesquisar.TabIndex = 8
        Me.btnPesquisar.Text = "Pesquisar"
        Me.btnPesquisar.UseVisualStyleBackColor = True
        Me.btnPesquisar.Visible = False
        '
        'Pesquisa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 224)
        Me.Controls.Add(Me.btnPesquisar)
        Me.Controls.Add(Me.dgvResultado)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.textPesquisa)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Pesquisa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pesquisa"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvResultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents textPesquisa As TextBox
    Friend WithEvents rbNome As RadioButton
    Friend WithEvents rbEndereco As RadioButton
    Friend WithEvents rbCelular As RadioButton
    Friend WithEvents rbTelefone As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbEmail As RadioButton
    Friend WithEvents dgvResultado As DataGridView
    Friend WithEvents btnPesquisar As Button
End Class
