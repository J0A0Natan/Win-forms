Public Class Pesquisa
    Private c As String
    Private pesquisa As String
    Private ds As DataSet

    Private Sub Pesquisar()
        pesquisa = textPesquisa.Text

        If rbNome.Checked = True Then
            c = "nome"
        ElseIf rbEndereco.Checked = True Then
            c = "endereco"
        ElseIf rbCelular.Checked = True Then
            c = "celular"
        ElseIf rbTelefone.Checked = True Then
            c = "telefone"
        Else
            c = "email"
        End If

        If cbAntes.Checked = True Then
            pesquisa = "%" + pesquisa
        End If

        If cbDepois.Checked = True Then
            pesquisa += "%"
        End If

        ds = Form1.objContato.PesquisarContato(c, pesquisa)
        If ds.Tables.Count = 0 OrElse ds.Tables(0).Rows.Count = 0 Then
            dgvResultado.DataSource = ds
            'MessageBox.Show("Nada foi encontrado!")
        Else
            dgvResultado.DataSource = ds.Tables(0)
        End If
    End Sub

    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        Pesquisar()
    End Sub

    Private Sub textPesquisa_TextChanged(sender As Object, e As EventArgs) Handles textPesquisa.TextChanged
        Pesquisar()
    End Sub
End Class