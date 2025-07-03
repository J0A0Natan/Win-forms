Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Usuarios
    Private helper As New Helper
    Private dt As New DataTable

    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelAlterarSenha.Visible = False
        helper = New Helper
        VizualizarUsuarios()
        If dgvUsuarios.Columns(0).Width <> 30 Then
            dgvUsuarios.Columns(0).Width = 30
        End If
    End Sub

    Private Sub btnCadastrar_Click(sender As Object, e As EventArgs) Handles btnCadastrar.Click
        Dim usuario = helper.Select_(New List(Of String) From {{"usuario"}}, "usuarios", New Dictionary(Of String, Object) From {{"usuario", txtUsuario.Text}})

        If usuario.Rows.Count > 0 Then
            MessageBox.Show("Usuário já existente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If txtSenha.Text.Contains(" ") Or String.IsNullOrWhiteSpace(txtSenha.Text) Then
                MessageBox.Show("Não permitido espaços em branco ou campo vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim hashSenha = helper.GerarHashSHA256(txtSenha.Text)
                Dim dados As New Dictionary(Of String, Object) From {{"usuario", txtUsuario.Text}, {"senha", hashSenha}}

                Try
                    helper.Insert("usuarios", dados)
                    MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtUsuario.Text = ""
                    txtSenha.Text = ""
                    VizualizarUsuarios()
                Catch ex As Exception
                    MessageBox.Show("Erro ao cadastrar usuario: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

    Private Sub VizualizarUsuarios()
        dt = helper.Select_(New List(Of String) From {{"id"}, {"usuario"}, {"created"}}, "usuarios")
        dgvUsuarios.DataSource = dt
    End Sub

    Private Sub btnDeletar_Click(sender As Object, e As EventArgs) Handles btnDeletar.Click
        Dim resposta = MessageBox.Show("Deseja realmente deletar o usuário selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resposta = DialogResult.Yes Then
            Dim id = dgvUsuarios.CurrentRow.Cells("id").Value
            If helper.Delete("usuarios", "id", id) Then
                MessageBox.Show("Usuário deletado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                VizualizarUsuarios()
            Else
                MessageBox.Show("Erro ao deletar usuário!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnAlterarSenha_Click(sender As Object, e As EventArgs) Handles btnAlterarSenha.Click
        PanelAlterarSenha.Visible = Not PanelAlterarSenha.Visible

        If PanelAlterarSenha.Visible = True Then
            cbUsuarios.DataSource = dt
            cbUsuarios.DisplayMember = "usuario"
            AcceptButton = btnAlterar
        End If
    End Sub

    Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click
        PanelAlterarSenha.Visible = False
    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        If txtNovaSenha.Text = txtConfSenha.Text Then
            If txtNovaSenha.Text.Contains(" ") Or String.IsNullOrWhiteSpace(txtNovaSenha.Text) Then
                MessageBox.Show("Não permitido espaços em branco ou campo vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Try
                    Dim senhaHash = helper.GerarHashSHA256(txtNovaSenha.Text)
                    Dim dataHoraAtual As New DateTime
                    If My.Settings.TipoCon = 1 Then
                        dataHoraAtual = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
                    Else
                        dataHoraAtual = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
                    End If
                    Dim colunas = New Dictionary(Of String, Object) From {{"senha", senhaHash}, {"modified", dataHoraAtual}}
                    Dim parametroCondicao = New Dictionary(Of String, Object) From {{"@usuario", cbUsuarios.Text}}
                    helper.Update("usuarios", colunas, "usuario=@usuario", parametroCondicao)
                    MessageBox.Show("Senha alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtNovaSenha.Text = ""
                    txtConfSenha.Text = ""
                Catch ex As Exception
                    Throw
                End Try
            End If
        Else
            MessageBox.Show("As senhas devem ser iguais!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class