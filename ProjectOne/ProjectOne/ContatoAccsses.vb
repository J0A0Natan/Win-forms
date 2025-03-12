Imports ApplicationBlocks.Data

Public Class ContatoAccsses : Inherits IContato
    Private pathAcsses As String = My.Settings.CaminhoAcsses
    Private OleDBHelper As New OleDBDbHelper
    Private strCon = "Provider=Microsoft.Jet.OleDb.4.0; Data Source=" & pathAcsses

    'Metodos
    Public Overrides Function NovoContato() As Boolean
        Dim query As String

        Try
            query = "INSERT INTO contatos(nome, endereco, celular, telefone, email) VALUES (@nome, @endereco, @celular, @telefone, @email);"

            Dim p1 = OleDBHelper.NewParameter("@nome", Nome)
            Dim p2 = OleDBHelper.NewParameter("@endereco", Endereco)
            Dim p3 = OleDBHelper.NewParameter("@celular", Celular)
            Dim p4 = OleDBHelper.NewParameter("@telefone", Telefone)
            Dim p5 = OleDBHelper.NewParameter("@email", Email)

            Return OleDBHelper.ExecuteNonQuery(strCon, CommandType.Text, query, p1, p2, p3, p4, p5)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Overrides Function AtualizarContato() As Boolean
        Dim query As String
        Dim p1, p2, p3, p4, p5, p6

        Try
            query = "UPDATE contatos SET nome = @nome, endereco = @endereco, celular = @celular, telefone = @telefone, email = @email WHERE id = @id;"

            p1 = OleDBHelper.NewParameter("@nome", Nome)
            p2 = OleDBHelper.NewParameter("@endereco", Endereco)
            p3 = OleDBHelper.NewParameter("@celular", Celular)
            p4 = OleDBHelper.NewParameter("@telefone", Telefone)
            p5 = OleDBHelper.NewParameter("@email", Email)
            p6 = OleDBHelper.NewParameter("@id", Id)

            Return OleDBHelper.ExecuteNonQuery(strCon, CommandType.Text, query, p1, p2, p3, p4, p5, p6)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Overrides Function ListarContato() As DataSet
        Dim query As String
        Try
            query = "SELECT id, nome, endereco, celular, telefone, email FROM contatos ORDER BY id DESC;"
            Return OleDBHelper.ExecuteDataset(strCon, CommandType.Text, query)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Overrides Function ListarContatoEditar(idCont As Integer) As Array
        Dim query As String
        Dim dados(5) As String

        Try
            query = "SELECT id, nome, endereco, celular, telefone, email FROM contatos WHERE id = @id;"

            Dim param = OleDBHelper.NewParameter("@id", idCont)
            Dim dr = OleDBHelper.ExecuteReader(strCon, CommandType.Text, query, param)
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

    Public Overrides Function DeletarContato(id As Integer) As Boolean
        Dim query As String

        Try
            query = "DELETE FROM contatos WHERE id=@id;"
            Dim p1 = OleDBHelper.NewParameter("@id", id)

            Return OleDBHelper.ExecuteNonQuery(strCon, CommandType.Text, query, p1)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class