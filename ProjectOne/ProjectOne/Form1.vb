Public Class Form1
    Private objContato As New Contato

    Private Sub ButtonNovo_Click(sender As Object, e As EventArgs) Handles ButtonNovo.Click
        If TxtNome.Text = "" Or TxtEnd.Text = "" Or TxtCell.Text = "" Or TxtEmail.Text = ""
            MessageBox.Show("Preencha todos os campos necessarios!", "Atenção" )
        Else
            Try
                objContato.Nome = TxtNome.Text
                objContato.Endereco = TxtEnd.Text
                objContato.Celular = TxtCell.Text
                objContato.Telefone = TxtTelefone.Text
                objContato.Email = TxtEmail.Text
                If objContato.NovoContato() = True Then
                    MessageBox.Show("Contato cadastrado com sucesso!")
                Else
                    MessageBox.Show("ERRO: Contato não cadastrado com sucesso!")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
        CarregarGrid()
        LimparForm()
        
    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        Dim id As Integer
        Dim dados(5) As String

        id= DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(0).Value
        dados = objContato.ListarContatoEditar(id)

        'MessageBox.Show(dados(0).ToString)
        TxtNome.Text = dados(1).ToString
        TxtEnd.Text = dados(2).ToString
        TxtCell.Text = dados(3).ToString
        TxtTelefone.Text = dados(4).ToString
        TxtEmail.Text = dados(5).ToString

    End Sub

    Private Function CarregarGrid()
        Dim tabela As New DataTable
        tabela = objContato.ListarContato()
        DataGridView1.DataSource = tabela
    End Function

    Private Function LimparForm()
        TxtNome.Text = ""
        TxtEnd.Text = ""
        TxtTelefone.Text = ""
        TxtCell.Text = ""
        TxtEmail.Text = ""
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarGrid()
    End Sub

    Private Sub ButtonDell_Click(sender As Object, e As EventArgs) Handles ButtonDell.Click
        Dim resultado As DialogResult
        resultado = MessageBox.Show("Tem certeza que deseja excluir esse contato?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resultado = DialogResult.Yes Then
            Dim id As Integer
            id= DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(0).Value
        
            If objContato.DeletarContato(id) = True Then
                MessageBox.Show("Contato deletado com sucesso!")
                CarregarGrid()
             Else
                MessageBox.Show("ERRO: Contato não deletado com sucesso!")
            End If
        End If
        
    End Sub

    Private Sub ButtonSalvar_Click(sender As Object, e As EventArgs) Handles ButtonSalvar.Click
        If TxtNome.Text = "" And TxtEnd.Text = "" And TxtCell.Text = "" And TxtEmail.Text = ""
            MessageBox.Show("Preencha todos os campos necessarios!", "Atenção")
        Else
            Dim id As Integer
            id= DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(0).Value
            Try
                objContato.Id = id
                objContato.Nome = TxtNome.Text
                objContato.Endereco = TxtEnd.Text
                objContato.Celular = TxtCell.Text
                objContato.Telefone = TxtTelefone.Text
                objContato.Email = TxtEmail.Text
                If objContato.AtualizarContato() = True Then
                    MessageBox.Show("Contato editado com sucesso!")
                    CarregarGrid()
                    LimparForm()
                Else
                    MessageBox.Show("ERRO: Contato não editado com sucesso!")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ButtonSair_Click(sender As Object, e As EventArgs) Handles ButtonSair.Click
        Application.Exit()
    End Sub

    Private Sub ButtonLimparForm_Click(sender As Object, e As EventArgs) Handles ButtonLimparForm.Click
        LimparForm()
    End Sub
End Class
