<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCadastroLogin
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
        Me.lblSenha = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.btnCadastrar = New System.Windows.Forms.Button()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblSenha
        '
        Me.lblSenha.AutoSize = True
        Me.lblSenha.Location = New System.Drawing.Point(12, 98)
        Me.lblSenha.Name = "lblSenha"
        Me.lblSenha.Size = New System.Drawing.Size(41, 13)
        Me.lblSenha.TabIndex = 14
        Me.lblSenha.Text = "Senha:"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(12, 47)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(46, 13)
        Me.lblUsuario.TabIndex = 13
        Me.lblUsuario.Text = "Usuario:"
        '
        'btnCadastrar
        '
        Me.btnCadastrar.Location = New System.Drawing.Point(90, 177)
        Me.btnCadastrar.Name = "btnCadastrar"
        Me.btnCadastrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCadastrar.TabIndex = 12
        Me.btnCadastrar.Text = "Cadastrar"
        Me.btnCadastrar.UseVisualStyleBackColor = True
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(12, 114)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(242, 20)
        Me.txtSenha.TabIndex = 11
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(12, 63)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(242, 20)
        Me.txtUsuario.TabIndex = 10
        '
        'FrmCadastroLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(266, 246)
        Me.Controls.Add(Me.lblSenha)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.btnCadastrar)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.txtUsuario)
        Me.Name = "FrmCadastroLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSenha As Label
    Friend WithEvents lblUsuario As Label
    Friend WithEvents btnCadastrar As Button
    Friend WithEvents txtSenha As TextBox
    Friend WithEvents txtUsuario As TextBox
End Class
