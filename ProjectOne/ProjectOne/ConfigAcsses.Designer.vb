<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfigAcsses
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
        Me.TxtAcsses = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnVoltar = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(115, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Caminho para o arquivo .mdb"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtAcsses
        '
        Me.TxtAcsses.Location = New System.Drawing.Point(62, 87)
        Me.TxtAcsses.Name = "TxtAcsses"
        Me.TxtAcsses.Size = New System.Drawing.Size(261, 20)
        Me.TxtAcsses.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(151, 113)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Salvar"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'BtnVoltar
        '
        Me.BtnVoltar.Location = New System.Drawing.Point(151, 142)
        Me.BtnVoltar.Name = "BtnVoltar"
        Me.BtnVoltar.Size = New System.Drawing.Size(75, 23)
        Me.BtnVoltar.TabIndex = 3
        Me.BtnVoltar.Text = "Voltar"
        Me.BtnVoltar.UseVisualStyleBackColor = true
        '
        'ConfigAcsses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 204)
        Me.Controls.Add(Me.BtnVoltar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtAcsses)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ConfigAcsses"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ConfigAcsses"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtAcsses As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnVoltar As Button
End Class
