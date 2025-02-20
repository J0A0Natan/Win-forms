Public Class ConfigAcsses
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        My.Settings.CaminhoAcsses = TxtAcsses.Text
        Me.Close()
        ChooseDB.Show()
    End Sub

    Private Sub BtnVoltar_Click(sender As Object, e As EventArgs) Handles BtnVoltar.Click
        Me.Close()
        ChooseDB.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnSelecionar.Click
        Dim openFile As New OpenFileDialog()
        openFile.Title = "Selecione um arquivo "
        openFile.Filter = "Arquivos Access (*.mdb;*.accdb)|*.mdb;*.accdb|Todos os Arquivos (*.*)|*.*"
        openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

        If openFile.ShowDialog() = DialogResult.OK Then
            TxtAcsses.Text = openFile.FileName
        End If
    End Sub

    Private Sub ConfigAcsses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtAcsses.Text = My.Settings.CaminhoAcsses
    End Sub
End Class