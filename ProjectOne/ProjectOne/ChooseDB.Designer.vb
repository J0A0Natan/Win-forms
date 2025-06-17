<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChooseDB
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnSelecionar = New System.Windows.Forms.Button()
        Me.rdAccess = New System.Windows.Forms.RadioButton()
        Me.rdSqlServer = New System.Windows.Forms.RadioButton()
        Me.BtnConfig = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(127, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Banco de Dados"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnSelecionar
        '
        Me.BtnSelecionar.Location = New System.Drawing.Point(113, 136)
        Me.BtnSelecionar.Name = "BtnSelecionar"
        Me.BtnSelecionar.Size = New System.Drawing.Size(121, 23)
        Me.BtnSelecionar.TabIndex = 2
        Me.BtnSelecionar.Text = "Selecionar"
        Me.BtnSelecionar.UseVisualStyleBackColor = True
        '
        'rdAccess
        '
        Me.rdAccess.AutoSize = True
        Me.rdAccess.Location = New System.Drawing.Point(130, 66)
        Me.rdAccess.Name = "rdAccess"
        Me.rdAccess.Size = New System.Drawing.Size(74, 17)
        Me.rdAccess.TabIndex = 3
        Me.rdAccess.TabStop = True
        Me.rdAccess.Text = "1 - Acsses"
        Me.rdAccess.UseVisualStyleBackColor = True
        '
        'rdSqlServer
        '
        Me.rdSqlServer.AutoSize = True
        Me.rdSqlServer.Location = New System.Drawing.Point(130, 90)
        Me.rdSqlServer.Name = "rdSqlServer"
        Me.rdSqlServer.Size = New System.Drawing.Size(95, 17)
        Me.rdSqlServer.TabIndex = 4
        Me.rdSqlServer.TabStop = True
        Me.rdSqlServer.Text = "2 - SQL Server"
        Me.rdSqlServer.UseVisualStyleBackColor = True
        '
        'BtnConfig
        '
        Me.BtnConfig.Location = New System.Drawing.Point(113, 174)
        Me.BtnConfig.Name = "BtnConfig"
        Me.BtnConfig.Size = New System.Drawing.Size(121, 23)
        Me.BtnConfig.TabIndex = 5
        Me.BtnConfig.Text = "Configurar"
        Me.BtnConfig.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 241)
        Me.ProgressBar1.MarqueeAnimationSpeed = 30
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(332, 23)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar1.TabIndex = 6
        Me.ProgressBar1.Visible = False
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(86, 225)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(169, 13)
        Me.lblStatus.TabIndex = 7
        Me.lblStatus.Text = "Conectando ao banco de dados..."
        Me.lblStatus.Visible = False
        '
        'ChooseDB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 276)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.BtnConfig)
        Me.Controls.Add(Me.rdSqlServer)
        Me.Controls.Add(Me.rdAccess)
        Me.Controls.Add(Me.BtnSelecionar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ChooseDB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Escolha de banco de dados"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSelecionar As Button
    Friend WithEvents rdAccess As RadioButton
    Friend WithEvents rdSqlServer As RadioButton
    Friend WithEvents BtnConfig As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents lblStatus As Label
End Class
