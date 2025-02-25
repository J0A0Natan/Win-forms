<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Relatorio
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
        Me.CrystalReportViewer2 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.CrystalReport13 = New ProjectOne.CrystalReport1()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout
        Me.SuspendLayout
        '
        'CrystalReportViewer2
        '
        Me.CrystalReportViewer2.ActiveViewIndex = 0
        Me.CrystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer2.Location = New System.Drawing.Point(0, 24)
        Me.CrystalReportViewer2.Name = "CrystalReportViewer2"
        Me.CrystalReportViewer2.ReportSource = Me.CrystalReport13
        Me.CrystalReportViewer2.Size = New System.Drawing.Size(1114, 569)
        Me.CrystalReportViewer2.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SairToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1114, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'Relatorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1114, 593)
        Me.Controls.Add(Me.CrystalReportViewer2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Relatorio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatorio"
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents CrystalReportViewer2 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CrystalReport13 As CrystalReport1

    Private Sub CrystalReport11_InitReport(sender As Object, e As EventArgs)

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
End Class
