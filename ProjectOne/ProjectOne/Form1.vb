Public Class Form1
    Public Shared objContato

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objContato = New Contato
        CarregarGrid()
        dgvContatos.Columns("id").HeaderText = "ID"
        dgvContatos.Columns("nome").HeaderText = "Nome"
        dgvContatos.Columns("endereco").HeaderText = "Endereço"
        dgvContatos.Columns("telefone").HeaderText = "Telefone"
        dgvContatos.Columns("celular").HeaderText = "Celular"
        dgvContatos.Columns("email").HeaderText = "E-mail"

        dgvContatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvContatos.Columns("ID").Width = 40
        dgvContatos.Columns("Telefone").Width = 90
        dgvContatos.Columns("Celular").Width = 90
    End Sub

    Private Sub CarregarGrid()
        dgvContatos.DataSource = objContato.ListarContato()
    End Sub

    Private Sub LimparForm()
        TxtNome.Text = ""
        TxtEndereco.Text = ""
        TxtTelefone.Text = ""
        TxtCell.Text = ""
        TxtEmail.Text = ""
    End Sub

    Private Sub cmdCadastrar_Click(sender As Object, e As EventArgs) Handles cmdCadastrar.Click
        If TxtNome.Text = "" Or TxtEndereco.Text = "" Or TxtCell.Text = "" Or TxtEmail.Text = ""
            MessageBox.Show("Preencha todos os campos necessarios!", "Atenção" )
        Else
            Try
                objContato.Nome = TxtNome.Text
                objContato.Endereco = TxtEndereco.Text
                objContato.Celular = TxtCell.Text
                objContato.Telefone = TxtTelefone.Text
                objContato.Email = TxtEmail.Text
                If objContato.NovoContato() = True Then
                    MsgBox("Contato cadastrado com sucesso!", vbInformation)
                    CarregarGrid()
                    LimparForm()
                End If
            Catch ex As Exception
                MessageBox.Show("ERRO: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub cmdEditar_Click(sender As Object, e As EventArgs) Handles cmdEditar.Click
        Dim id As Integer
        Dim dados(5) As String

        id = dgvContatos.Rows(dgvContatos.CurrentRow.Index).Cells(0).Value
        dados = objContato.ListarContatoEditar(id)

        TxtNome.Text = dados(0)
        TxtEndereco.Text = dados(1)
        TxtCell.Text = dados(2)
        TxtTelefone.Text = dados(3)
        TxtEmail.Text = dados(4)

    End Sub

    Private Sub cmdDeletar_Click(sender As Object, e As EventArgs) Handles cmdDeletar.Click
        Dim resultado As DialogResult
        Dim nome As String
        nome = dgvContatos.Rows(dgvContatos.CurrentRow.Index).Cells(1).Value
        resultado = MessageBox.Show("Tem certeza que deseja excluir o contato " & nome & "?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resultado = DialogResult.Yes Then
            Dim id As Integer
            id = dgvContatos.Rows(dgvContatos.CurrentRow.Index).Cells(0).Value

            Try
                objContato.DeletarContato(id)
                MessageBox.Show("Contato deletado com sucesso!")
                CarregarGrid()
            Catch ex As Exception
                MessageBox.Show("ERRO: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub cmdSalvar_Click(sender As Object, e As EventArgs) Handles cmdSalvar.Click
        If TxtNome.Text = "" Or TxtEndereco.Text = "" Or TxtCell.Text = "" Or TxtEmail.Text = ""
            MessageBox.Show("Preencha todos os campos necessarios!", "Atenção")
        Else
            Dim nome = dgvContatos.Rows(dgvContatos.CurrentRow.Index).Cells(1).Value
            Dim resultado = MessageBox.Show("Tem certeza que deseja alterar o contato " & nome & "?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If resultado = DialogResult.Yes Then
                Dim id = dgvContatos.Rows(dgvContatos.CurrentRow.Index).Cells(0).Value
                objContato.Id = id
                objContato.Nome = TxtNome.Text
                objContato.Endereco = TxtEndereco.Text
                objContato.Celular = TxtCell.Text
                objContato.Telefone = TxtTelefone.Text
                objContato.Email = TxtEmail.Text
                Try
                    objContato.AtualizarContato()
                    MsgBox("Contato alterado com sucesso!", vbInformation)
                    CarregarGrid()
                    LimparForm()
                Catch ex As Exception
                    MessageBox.Show("ERRO: " & ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub cmdLimparForm_Click(sender As Object, e As EventArgs) Handles cmdLimparForm.Click
        LimparForm()
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub RelatorioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelatorioToolStripMenuItem.Click
        Relatorio.ShowDialog()
    End Sub

    Private Sub PesquisarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PesquisarToolStripMenuItem.Click
        Pesquisa.ShowDialog()
    End Sub

    Private Sub CadastrarUsuarioToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles CadastrarUsuarioToolStripMenuItem.Click
        FrmCadastroLogin.ShowDialog()
    End Sub

    Private Sub ConfigurarBancoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfigurarBancoToolStripMenuItem.Click
        ChooseDB.Show()
        Close()
    End Sub
End Class
