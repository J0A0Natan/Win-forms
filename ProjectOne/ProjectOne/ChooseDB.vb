Public Class ChooseDB
    Private Sub BtnSelecionar_Click(sender As Object, e As EventArgs) Handles BtnSelecionar.Click
        Dim escolha As Integer
        If rdAccess.Checked = True Then
            escolha = 1
        ElseIf rdSqlServer.Checked = True Then
            escolha = 2
        End If

        If My.Settings.CaminhoAcsses = "" And escolha = 1 Then
            MsgBox("Configure o acesso antes!", vbExclamation, "Atenção")
        ElseIf My.Settings.ServidorSQL = "" And escolha = 2 Then
            MsgBox("Configure a conexão com o banco antes!", vbExclamation, "Atenção")
        Else
            Form1.tipoConNum = escolha
            Me.Hide()
            Form1.Show()
        End If
    End Sub

    Private Sub ConfigDB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rdAccess.Checked = True
    End Sub

    Private Sub BtnConfig_Click(sender As Object, e As EventArgs) Handles BtnConfig.Click
        If rdAccess.Checked = True Then
            ConfigAcsses.Show()
            Me.Hide()
        ElseIf rdSqlServer.Checked = True Then
            ConfigSQLServer.Show()
            Me.Hide()
        End If
    End Sub
End Class