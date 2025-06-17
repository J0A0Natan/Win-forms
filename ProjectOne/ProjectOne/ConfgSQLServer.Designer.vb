<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConfigSQLServer
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
        Me.TxtServer = New System.Windows.Forms.TextBox()
        Me.TxtDB = New System.Windows.Forms.TextBox()
        Me.TxtUser = New System.Windows.Forms.TextBox()
        Me.TxtPass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.BtnTestar = New System.Windows.Forms.Button()
        Me.BtnVoltar = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtServer
        '
        Me.TxtServer.Location = New System.Drawing.Point(128, 28)
        Me.TxtServer.Name = "TxtServer"
        Me.TxtServer.Size = New System.Drawing.Size(266, 20)
        Me.TxtServer.TabIndex = 0
        '
        'TxtDB
        '
        Me.TxtDB.Location = New System.Drawing.Point(128, 54)
        Me.TxtDB.Name = "TxtDB"
        Me.TxtDB.Size = New System.Drawing.Size(266, 20)
        Me.TxtDB.TabIndex = 1
        '
        'TxtUser
        '
        Me.TxtUser.Location = New System.Drawing.Point(128, 80)
        Me.TxtUser.Name = "TxtUser"
        Me.TxtUser.Size = New System.Drawing.Size(266, 20)
        Me.TxtUser.TabIndex = 2
        '
        'TxtPass
        '
        Me.TxtPass.Location = New System.Drawing.Point(128, 106)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPass.Size = New System.Drawing.Size(266, 20)
        Me.TxtPass.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Server"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Banco de dados"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Usuario"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Senha"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnSalvar
        '
        Me.BtnSalvar.Location = New System.Drawing.Point(300, 186)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(94, 24)
        Me.BtnSalvar.TabIndex = 8
        Me.BtnSalvar.Text = "Salvar"
        Me.BtnSalvar.UseVisualStyleBackColor = True
        '
        'BtnTestar
        '
        Me.BtnTestar.Location = New System.Drawing.Point(168, 186)
        Me.BtnTestar.Name = "BtnTestar"
        Me.BtnTestar.Size = New System.Drawing.Size(94, 24)
        Me.BtnTestar.TabIndex = 9
        Me.BtnTestar.Text = "Testar Conexão"
        Me.BtnTestar.UseVisualStyleBackColor = True
        '
        'BtnVoltar
        '
        Me.BtnVoltar.Location = New System.Drawing.Point(39, 186)
        Me.BtnVoltar.Name = "BtnVoltar"
        Me.BtnVoltar.Size = New System.Drawing.Size(94, 24)
        Me.BtnVoltar.TabIndex = 10
        Me.BtnVoltar.Text = "Voltar"
        Me.BtnVoltar.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.AccessibleDescription = ""
        Me.ProgressBar1.Location = New System.Drawing.Point(39, 177)
        Me.ProgressBar1.MarqueeAnimationSpeed = 40
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(355, 23)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar1.TabIndex = 11
        Me.ProgressBar1.Visible = False
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(41, 161)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(105, 13)
        Me.lblStatus.TabIndex = 12
        Me.lblStatus.Text = "Testando conexão..."
        Me.lblStatus.Visible = False
        '
        'ConfigSQLServer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 250)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.BtnVoltar)
        Me.Controls.Add(Me.BtnTestar)
        Me.Controls.Add(Me.BtnSalvar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtPass)
        Me.Controls.Add(Me.TxtUser)
        Me.Controls.Add(Me.TxtDB)
        Me.Controls.Add(Me.TxtServer)
        Me.Name = "ConfigSQLServer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ConfgSQLServer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtServer As TextBox
    Friend WithEvents TxtDB As TextBox
    Friend WithEvents TxtUser As TextBox
    Friend WithEvents TxtPass As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents BtnTestar As Button
    Friend WithEvents BtnVoltar As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents lblStatus As Label
End Class
