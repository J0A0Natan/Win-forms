<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuarios
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpVizualizar = New System.Windows.Forms.TabPage()
        Me.PanelAlterarSenha = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbUsuarios = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNovaSenha = New System.Windows.Forms.TextBox()
        Me.btnVoltar = New System.Windows.Forms.Button()
        Me.txtConfSenha = New System.Windows.Forms.TextBox()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAlterarSenha = New System.Windows.Forms.Button()
        Me.btnDeletar = New System.Windows.Forms.Button()
        Me.dgvUsuarios = New System.Windows.Forms.DataGridView()
        Me.tpCadastrar = New System.Windows.Forms.TabPage()
        Me.lblSenha = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.btnCadastrar = New System.Windows.Forms.Button()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TabControl1.SuspendLayout()
        Me.tpVizualizar.SuspendLayout()
        Me.PanelAlterarSenha.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpCadastrar.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpVizualizar)
        Me.TabControl1.Controls.Add(Me.tpCadastrar)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(297, 332)
        Me.TabControl1.TabIndex = 0
        '
        'tpVizualizar
        '
        Me.tpVizualizar.Controls.Add(Me.PanelAlterarSenha)
        Me.tpVizualizar.Controls.Add(Me.btnAlterarSenha)
        Me.tpVizualizar.Controls.Add(Me.btnDeletar)
        Me.tpVizualizar.Controls.Add(Me.dgvUsuarios)
        Me.tpVizualizar.Location = New System.Drawing.Point(4, 22)
        Me.tpVizualizar.Name = "tpVizualizar"
        Me.tpVizualizar.Padding = New System.Windows.Forms.Padding(3)
        Me.tpVizualizar.Size = New System.Drawing.Size(289, 306)
        Me.tpVizualizar.TabIndex = 1
        Me.tpVizualizar.Text = "Vizualizar"
        Me.tpVizualizar.UseVisualStyleBackColor = True
        '
        'PanelAlterarSenha
        '
        Me.PanelAlterarSenha.Controls.Add(Me.GroupBox2)
        Me.PanelAlterarSenha.Controls.Add(Me.GroupBox1)
        Me.PanelAlterarSenha.Location = New System.Drawing.Point(3, 35)
        Me.PanelAlterarSenha.Name = "PanelAlterarSenha"
        Me.PanelAlterarSenha.Size = New System.Drawing.Size(283, 271)
        Me.PanelAlterarSenha.TabIndex = 3
        Me.PanelAlterarSenha.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbUsuarios)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(277, 53)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Usuario"
        '
        'cbUsuarios
        '
        Me.cbUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUsuarios.FormattingEnabled = True
        Me.cbUsuarios.Location = New System.Drawing.Point(19, 19)
        Me.cbUsuarios.Name = "cbUsuarios"
        Me.cbUsuarios.Size = New System.Drawing.Size(242, 21)
        Me.cbUsuarios.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNovaSenha)
        Me.GroupBox1.Controls.Add(Me.btnVoltar)
        Me.GroupBox1.Controls.Add(Me.txtConfSenha)
        Me.GroupBox1.Controls.Add(Me.btnAlterar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(277, 203)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Alterar Senha"
        '
        'txtNovaSenha
        '
        Me.txtNovaSenha.Location = New System.Drawing.Point(19, 34)
        Me.txtNovaSenha.Name = "txtNovaSenha"
        Me.txtNovaSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNovaSenha.Size = New System.Drawing.Size(242, 20)
        Me.txtNovaSenha.TabIndex = 4
        '
        'btnVoltar
        '
        Me.btnVoltar.Location = New System.Drawing.Point(102, 158)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(75, 23)
        Me.btnVoltar.TabIndex = 7
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.UseVisualStyleBackColor = True
        '
        'txtConfSenha
        '
        Me.txtConfSenha.Location = New System.Drawing.Point(19, 89)
        Me.txtConfSenha.Name = "txtConfSenha"
        Me.txtConfSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfSenha.Size = New System.Drawing.Size(242, 20)
        Me.txtConfSenha.TabIndex = 5
        '
        'btnAlterar
        '
        Me.btnAlterar.Location = New System.Drawing.Point(102, 129)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(75, 23)
        Me.btnAlterar.TabIndex = 6
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nova senha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Confirmar nova senha"
        '
        'btnAlterarSenha
        '
        Me.btnAlterarSenha.Location = New System.Drawing.Point(146, 6)
        Me.btnAlterarSenha.Name = "btnAlterarSenha"
        Me.btnAlterarSenha.Size = New System.Drawing.Size(140, 23)
        Me.btnAlterarSenha.TabIndex = 2
        Me.btnAlterarSenha.Text = "Alterar senha"
        Me.btnAlterarSenha.UseVisualStyleBackColor = True
        '
        'btnDeletar
        '
        Me.btnDeletar.Location = New System.Drawing.Point(3, 6)
        Me.btnDeletar.Name = "btnDeletar"
        Me.btnDeletar.Size = New System.Drawing.Size(140, 23)
        Me.btnDeletar.TabIndex = 1
        Me.btnDeletar.Text = "Deletar"
        Me.btnDeletar.UseVisualStyleBackColor = True
        '
        'dgvUsuarios
        '
        Me.dgvUsuarios.AllowUserToAddRows = False
        Me.dgvUsuarios.AllowUserToDeleteRows = False
        Me.dgvUsuarios.AllowUserToResizeColumns = False
        Me.dgvUsuarios.AllowUserToResizeRows = False
        Me.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsuarios.Location = New System.Drawing.Point(3, 35)
        Me.dgvUsuarios.Name = "dgvUsuarios"
        Me.dgvUsuarios.ReadOnly = True
        Me.dgvUsuarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvUsuarios.Size = New System.Drawing.Size(283, 271)
        Me.dgvUsuarios.TabIndex = 0
        '
        'tpCadastrar
        '
        Me.tpCadastrar.Controls.Add(Me.GroupBox3)
        Me.tpCadastrar.Location = New System.Drawing.Point(4, 22)
        Me.tpCadastrar.Name = "tpCadastrar"
        Me.tpCadastrar.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCadastrar.Size = New System.Drawing.Size(289, 306)
        Me.tpCadastrar.TabIndex = 0
        Me.tpCadastrar.Text = "Cadastrar"
        Me.tpCadastrar.UseVisualStyleBackColor = True
        '
        'lblSenha
        '
        Me.lblSenha.AutoSize = True
        Me.lblSenha.Location = New System.Drawing.Point(15, 78)
        Me.lblSenha.Name = "lblSenha"
        Me.lblSenha.Size = New System.Drawing.Size(41, 13)
        Me.lblSenha.TabIndex = 9
        Me.lblSenha.Text = "Senha:"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(15, 27)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(46, 13)
        Me.lblUsuario.TabIndex = 8
        Me.lblUsuario.Text = "Usuario:"
        '
        'btnCadastrar
        '
        Me.btnCadastrar.Location = New System.Drawing.Point(95, 151)
        Me.btnCadastrar.Name = "btnCadastrar"
        Me.btnCadastrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCadastrar.TabIndex = 3
        Me.btnCadastrar.Text = "Cadastrar"
        Me.btnCadastrar.UseVisualStyleBackColor = True
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(15, 94)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(242, 20)
        Me.txtSenha.TabIndex = 2
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(15, 43)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(242, 20)
        Me.txtUsuario.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnCadastrar)
        Me.GroupBox3.Controls.Add(Me.lblSenha)
        Me.GroupBox3.Controls.Add(Me.txtUsuario)
        Me.GroupBox3.Controls.Add(Me.lblUsuario)
        Me.GroupBox3.Controls.Add(Me.txtSenha)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(277, 294)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Novo usuario"
        '
        'Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 356)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Usuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuarios"
        Me.TabControl1.ResumeLayout(False)
        Me.tpVizualizar.ResumeLayout(False)
        Me.PanelAlterarSenha.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpCadastrar.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpCadastrar As TabPage
    Friend WithEvents tpVizualizar As TabPage
    Friend WithEvents lblSenha As Label
    Friend WithEvents lblUsuario As Label
    Friend WithEvents btnCadastrar As Button
    Friend WithEvents txtSenha As TextBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents dgvUsuarios As DataGridView
    Friend WithEvents btnAlterarSenha As Button
    Friend WithEvents btnDeletar As Button
    Friend WithEvents PanelAlterarSenha As Panel
    Friend WithEvents btnAlterar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtConfSenha As TextBox
    Friend WithEvents txtNovaSenha As TextBox
    Friend WithEvents btnVoltar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbUsuarios As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
End Class
