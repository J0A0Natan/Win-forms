Public Class FrmCadastroLogin
    Private helper 'As New Helper
    Private Sub btnCadastrar_Click(sender As Object, e As EventArgs)
        Dim usuario = helper.Select_(New List(Of String) From {{"usuario"}}, "usuarios", New Dictionary(Of String, Object) From {{"usuario", txtUsuario.Text}})

        If usuario.Rows.Count > 0 Then
            MessageBox.Show("Usuário já existente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim hashSenha = helper.GerarHashSHA256(txtSenha.Text)
            Dim dados As New Dictionary(Of String, Object) From {{"usuario", txtUsuario.Text}, {"senha", hashSenha}}

            Try
                helper.Insert("usuarios", dados)
                MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtUsuario.Text = ""
                txtSenha.Text = ""
            Catch ex As Exception
                MessageBox.Show("Erro ao cadastrar usuario: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub FrmCadastroLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        helper = New Helper
    End Sub
End Class