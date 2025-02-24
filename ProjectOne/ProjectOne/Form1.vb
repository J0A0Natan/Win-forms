Public Class Form1
    Private objContato As Object
    Public Shared tipoConFormNum As Integer

    Public Function tipoCon(i As Integer)
        If i = 1 Then
            objContato = New Contato()
        ElseIf i = 2 Then
            objContato = New ContatoSQL()
        End If
    End Function
    
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tipoCon(tipoConFormNum)
        CarregarGrid()
    End Sub

    Private Function CarregarGrid()
        Dim tabela As DataTable = objContato.ListarContato()
        DataGridView1.DataSource = tabela
    End Function

    Private Function LimparForm()
        TxtNome.Text = ""
        TxtEnd.Text = ""
        TxtTelefone.Text = ""
        TxtCell.Text = ""
        TxtEmail.Text = ""
    End Function

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
                    MsgBox("Contato cadastrado com sucesso!", vbInformation)
                    CarregarGrid()
                    LimparForm()
                Else
                    MsgBox("ERRO: Contato não cadastrado!", vbObjectError)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        Dim id As Integer
        Dim dados(5) As String

        id= DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(0).Value
        dados = objContato.ListarContatoEditar(id)

        'MessageBox.Show(dados(0).ToString)
        TxtNome.Text = dados(0)
        TxtEnd.Text = dados(1)
        TxtCell.Text = dados(2)
        TxtTelefone.Text = dados(3)
        TxtEmail.Text = dados(4)

    End Sub

    Private Sub ButtonDell_Click(sender As Object, e As EventArgs) Handles ButtonDell.Click
        Dim resultado As DialogResult
        Dim nome As String
        nome = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(1).Value
        resultado = MessageBox.Show("Tem certeza que deseja excluir o contato " & nome & "?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resultado = DialogResult.Yes Then
            Dim id As Integer
            id= DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(0).Value
        
            If objContato.DeletarContato(id) = True Then
                MessageBox.Show("Contato deletado com sucesso!")
                CarregarGrid()
             Else
                MessageBox.Show("ERRO: Contato não deletado!")
            End If
        End If
        
    End Sub

    Private Sub ButtonSalvar_Click(sender As Object, e As EventArgs) Handles ButtonSalvar.Click
        If TxtNome.Text = "" Or TxtEnd.Text = "" Or TxtCell.Text = "" Or TxtEmail.Text = ""
            MessageBox.Show("Preencha todos os campos necessarios!", "Atenção")
        Else
            Dim nome As String
            nome = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(1).Value
            Dim resultado As DialogResult
            resultado = MessageBox.Show("Tem certeza que deseja alterar o contato " & nome & "?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If resultado = DialogResult.Yes Then
                Dim id As Integer
                id= DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(0).Value
                objContato.Id = id
                objContato.Nome = TxtNome.Text
                objContato.Endereco = TxtEnd.Text
                objContato.Celular = TxtCell.Text
                objContato.Telefone = TxtTelefone.Text
                objContato.Email = TxtEmail.Text
                Try
                    If objContato.AtualizarContato() = True Then
                        MsgBox("Contato alterado com sucesso!", vbInformation)
                        CarregarGrid()
                        LimparForm()
                    Else
                        MsgBox("ERRO: Contato não alterado com sucesso!", vbObjectError)
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub ButtonLimparForm_Click(sender As Object, e As EventArgs) Handles ButtonLimparForm.Click
        LimparForm()
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ConfiguraçõesDBToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        ChooseDB.ShowDialog()
    End Sub

    Private Sub RelatorioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelatorioToolStripMenuItem.Click
        Relatorio.ShowDialog()
    End Sub
End Class
