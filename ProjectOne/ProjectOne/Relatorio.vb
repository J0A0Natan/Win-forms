Public Class Relatorio
    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub Relatorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cont = New Contato
        CrystalReportViewer1.ReportSource = cont.RelatorioCrystal()
    End Sub
End Class