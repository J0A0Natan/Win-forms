Public Class Contato
    'Propriedades
    Public Property Id As Integer
    Public Property Nome As String
    Public Property Endereco As String
    Public Property Celular As String
    Public Property Telefone As String
    Public Property Email As String

    Private ReadOnly helper As New Helper

    Public Function NovoContato() As Boolean
        Dim dados As New Dictionary(Of String, Object) From {{"nome", Nome}, {"endereco", Endereco}, {"celular", Celular}, {"telefone", Telefone}, {"email", Email}}
        Return helper.Insert("contatos", dados)
    End Function

    Public Function AtualizarContato() As Boolean
        Dim dados As New Dictionary(Of String, Object) From {{"nome", Nome}, {"endereco", Endereco}, {"celular", Celular}, {"telefone", Telefone}, {"email", Email}}
        Dim parametrosCondicao As New Dictionary(Of String, Object) From {{"@id", Id}}
        Return helper.Update("contatos", dados, "id = @id", parametrosCondicao)
    End Function

    Public Function DeletarContato(id As Integer) As Boolean
        Return helper.Delete("contatos", "id", id)
    End Function

    Public Function ListarContato() As DataTable
        Dim colunas As New List(Of String) From {"id", "nome", "endereco", "celular", "telefone", "email"}
        Return helper.Select_(colunas, "contatos", orderBy:="id", ascDesc:="desc")
    End Function

    Public Function ListarContatoEditar(idCont As Integer) As Array
        Dim query As String
        Dim dados(5) As String

        Try
            query = "SELECT id, nome, endereco, celular, telefone, email FROM contatos WHERE id = @id;"

            Dim param = helper.DbHelper.NewParameter("@id", idCont)
            Dim dr = helper.DbHelper.ExecuteReader(helper.strCon, CommandType.Text, query, param)
            dr.Read()

            dados(0) = dr("nome").ToString()
            dados(1) = dr("endereco").ToString()
            dados(2) = dr("celular").ToString()
            dados(3) = dr("telefone").ToString()
            dados(4) = dr("email").ToString()
            Return dados
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function RelatorioCrystal()
        Dim dt As DataTable
        Dim ds As DataSet
        Dim rpt As New CrystalReport
        Dim query = "SELECT * FROM contatos"

        ds = helper.DbHelper.ExecuteDataset(helper.strCon, CommandType.Text, query)
        dt = ds.Tables(0)
        rpt.SetDataSource(dt)

        Return rpt
    End Function

    Public Function PesquisarContato(coluna As String, pesquisa As String)
        Dim query = $"SELECT * FROM contatos WHERE {coluna} LIKE @pesquisa"
        Dim param = helper.DbHelper.NewParameter("@pesquisa", DbType.String, pesquisa)

        Try
            If pesquisa <> "%" And pesquisa <> "%%" Then
                Return helper.DbHelper.ExecuteDataset(helper.strCon, CommandType.Text, query, param)
            Else
                Return New DataSet()
            End If

        Catch ex As Exception
            MessageBox.Show("ERRO: " + ex.Message)
            Return Nothing
        End Try
    End Function
End Class