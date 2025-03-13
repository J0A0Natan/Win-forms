Imports ApplicationBlocks.Data

Public MustInherit Class IContato
    'Propriedades
    Public Property Id As Integer
    Public Property Nome As String
    Public Property Endereco As String
    Public Property Celular As String
    Public Property Telefone As String
    Public Property Email As String

    Protected DbHelper
    Protected strCon

    'Metodos
    'Protected MustOverride Sub ConfiguraCon()

    Public Function NovoContato() As Boolean
        Dim query As String

        Try
            query = "INSERT INTO contatos(nome, endereco, celular, telefone, email) VALUES (@nome, @endereco, @celular, @telefone, @email);"

            Dim p1 = DbHelper.NewParameter("@nome", Nome)
            Dim p2 = DbHelper.NewParameter("@endereco", Endereco)
            Dim p3 = DbHelper.NewParameter("@celular", Celular)
            Dim p4 = DbHelper.NewParameter("@telefone", Telefone)
            Dim p5 = DbHelper.NewParameter("@email", Email)

            Return DbHelper.ExecuteNonQuery(strCon, CommandType.Text, query, p1, p2, p3, p4, p5)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function AtualizarContato() As Boolean
        Dim query As String
        Dim p1, p2, p3, p4, p5, p6

        Try
            query = "UPDATE contatos SET nome = @nome, endereco = @endereco, celular = @celular, telefone = @telefone, email = @email WHERE id = @id;"

            p1 = DbHelper.NewParameter("@nome", Nome)
            p2 = DbHelper.NewParameter("@endereco", Endereco)
            p3 = DbHelper.NewParameter("@celular", Celular)
            p4 = DbHelper.NewParameter("@telefone", Telefone)
            p5 = DbHelper.NewParameter("@email", Email)
            p6 = DbHelper.NewParameter("@id", Id)

            Return DbHelper.ExecuteNonQuery(strCon, CommandType.Text, query, p1, p2, p3, p4, p5, p6)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarContato() As DataSet
        Dim query As String
        Try
            query = "SELECT id, nome, endereco, celular, telefone, email FROM contatos ORDER BY id DESC;"
            Return DbHelper.ExecuteDataset(strCon, CommandType.Text, query)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarContatoEditar(idCont As Integer) As Array
        Dim query As String
        Dim dados(5) As String

        Try
            query = "SELECT id, nome, endereco, celular, telefone, email FROM contatos WHERE id = @id;"

            Dim param = DbHelper.NewParameter("@id", idCont)
            Dim dr = DbHelper.ExecuteReader(strCon, CommandType.Text, query, param)
            dr.Read()

            dados(0) = dr("nome").ToString()
            dados(1) = dr("endereco").ToString()
            dados(2) = dr("celular").ToString()
            dados(3) = dr("telefone").ToString()
            dados(4) = dr("email").ToString()
        Catch ex As Exception
            Throw ex
        End Try

        Return dados
    End Function

    Public Function DeletarContato(id As Integer) As Boolean
        Dim query As String

        Try
            query = "DELETE FROM contatos WHERE id=@id;"
            Dim p1 = DbHelper.NewParameter("@id", id)

            Return DbHelper.ExecuteNonQuery(strCon, CommandType.Text, query, p1)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function RelatorioCrystal()
        Dim ds As New DataSet1() 
        Dim rpt As New CrystalReport

        Dim db = DbHelper.NewConnection(strCon)

        Dim dt As DataTable = DbHelper.ExecuteDataSet(strCon, CommandType.Text, query).Tables(0)
        rpt.SetDataSource(dt)

        Return rpt
    End Function
End Class