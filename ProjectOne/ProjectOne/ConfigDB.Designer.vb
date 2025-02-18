<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfigDB
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
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.SuspendLayout
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = true
        Me.CheckedListBox1.Items.AddRange(New Object() {"1 - Acsses", "2 - SQL Server"})
        Me.CheckedListBox1.Location = New System.Drawing.Point(118, 67)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(116, 34)
        Me.CheckedListBox1.TabIndex = 1
        '
        'ConfigDB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 184)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Name = "ConfigDB"
        Me.Text = "ConfigDB"
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents CheckedListBox1 As CheckedListBox
End Class
