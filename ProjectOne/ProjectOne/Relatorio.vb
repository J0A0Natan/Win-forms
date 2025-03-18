Public Class Relatorio
    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Relatorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.tipoConFormNum = 1
            Dim cont = New ContatoAccsses
            'Dim dt As DataTable
            'Dim ds As DataSet1
            'Dim rpt As New CrystalReport

            'ds = cont.RelatorioCrystal()
            'dt = ds.Tables(0)
            'rpt.SetDataSource(dt)

            CrystalReportViewer1.ReportSource = cont.RelatorioCrystal()
            
            'For Each row As DataRow In dt.Rows
            '    Console.WriteLine("ID: " & row("id").ToString)
            '    Console.WriteLine("Nome: " & row("nome").ToString)
            '    Console.WriteLine("E-mail: " & row("email").ToString)
            'Next
        Else
            Dim cont = New ContatoSQLServer
            CrystalReportViewer1.ReportSource = cont.RelatorioCrystal()
        End If
    End Sub
End Class