Public Class frmLogin
    Private helper As New Helper

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.TipoCon = 0 Then
            ChooseDB.Show()
        End If

        If My.Settings.TipoCon = 1 Then
            lblStatus.Text &= "Access"
        Else
            lblStatus.Text &= "SQL"
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim usuario = txtUsuario.Text
        Dim senha = txtSenha.Text

        Dim hashSenha = helper.GerarHashSHA256(senha)
        Dim whereParametro As New Dictionary(Of String, Object) From {{"usuario", usuario}}
        Dim dbResult = helper.Select_(New List(Of String) From {"usuario", "senha"}, "usuarios", whereParametro)
        If dbResult.Rows.Count > 0 Then
            Dim usuarioDb = dbResult.Rows(0)("usuario")
            Dim senhaDb = dbResult.Rows(0)("senha")
            If hashSenha = senhaDb Then
                'MessageBox.Show("Senha correta!")
                Form1.Show()
                Close()
            Else
                MessageBox.Show("Senha incorreta!")
            End If
        Else
            MessageBox.Show("Usuario não encontrado!")
        End If
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Application.Exit()
    End Sub
End Class