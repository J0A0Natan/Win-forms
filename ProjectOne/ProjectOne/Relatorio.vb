Public Class Relatorio
    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Relatorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.tipoConFormNum = 1
            Dim cont = New ContatoAccsses
            CrystalReportViewer1.ReportSource = cont.RelatorioCrystal()
        Else
            Dim cont = New ContatoSQLServer
            CrystalReportViewer1.ReportSource = cont.RelatorioCrystal()
        End If
    End Sub
End Class