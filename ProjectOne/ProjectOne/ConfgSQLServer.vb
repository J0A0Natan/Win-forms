Public Class ConfigSQLServer
    Private conn As New SQL
    Private Sub BtnTestar_Click(sender As Object, e As EventArgs) Handles BtnTestar.Click
        conn.server = TxtServer.Text.ToString
        conn.dataBase = TxtDB.Text.ToString
        conn.user = TxtUser.Text.ToString
        conn.pass = TxtPass.Text.ToString

        conn.connectDb()
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        Form1.tipoConFormNum = 2
        Me.Hide()
        Form1.Show()
    End Sub
End Class