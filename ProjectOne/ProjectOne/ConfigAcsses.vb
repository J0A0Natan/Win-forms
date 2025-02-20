Public Class ConfigAcsses
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.tipoConFormNum = 1
        Contato.pathAcsses = TxtAcsses.Text
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub BtnVoltar_Click(sender As Object, e As EventArgs) Handles BtnVoltar.Click
        Me.Close()
        ChooseDB.Show()
    End Sub
End Class