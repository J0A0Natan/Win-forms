Imports System.Data.OleDb

Public Class Relatorio
    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Relatorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As OleDbConnection
        Dim dt As OleDbDataAdapter
        Dim ds As DataSet
        Dim query As String

        con = New OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0; Data Source=" & My.Settings.CaminhoAcsses)
        con.Open()

        query = "SELECT * FROM contatos"
        dt = New OleDbDataAdapter(query, con)
        ds = New DataSet
        dt.Fill(ds, "contatos")

        Dim rpt As New CrystalReport1
        rpt.SetDataSource(ds)

        CrystalReportViewer2.ReportSource = rpt

        con.Close()
        dt.Dispose()
        ds.Dispose()
    End Sub
End Class