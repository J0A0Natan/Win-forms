Imports System.Data.OleDb

Public Class Contato
    'Atributos
    Private conn As OleDbConnection
    Private comando As OleDbCommand
    Private da As OleDbDataAdapter
    Private dr As OleDbDataReader

    'Construtor
    Sub New()
        conn = New OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0; Data Source=T:\WinForms\Database\Database2.mdb")
    End Sub

    Public Property Id As Integer
    Public Property Nome As String
    Public Property Endereco As String
    Public Property Celular As String
    Public Property Telefone As String
    Public Property Email As String

    'Metodos
    Public Function NovoContato() As Boolean
        Dim retorno As Boolean
        Dim query As String

        Try
            query = "INSERT INTO contatos(nome, endereco, celular, telefone, email) VALUES (@nome, @endereco, @celular, @telefone, @email);"
            comando = New OleDbCommand
            comando.Connection = conn
            comando.CommandType = CommandType.Text
            comando.CommandText = query
            comando.Parameters.AddWithValue("@nome", Nome)
            comando.Parameters.AddWithValue("@endereco", Endereco)
            comando.Parameters.AddWithValue("@celular", Celular)
            comando.Parameters.AddWithValue("@telefone", Telefone)
            comando.Parameters.AddWithValue("@email", Email)
            conn.Open()
            retorno = comando.ExecuteNonQuery
            conn.Close()
            Return retorno
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function AtualizarContato() As Boolean
        Dim retorno As Boolean
        Dim query As String

        Try
            query = "UPDATE contatos SET nome = @nome, endereco = @endereco, celular = @celular, telefone = @telefone, email = @email WHERE id = @id;"
            comando = New OleDbCommand
            comando.Connection = conn
            comando.CommandType = CommandType.Text
            comando.CommandText = query
            comando.Parameters.AddWithValue("@nome", Nome)
            comando.Parameters.AddWithValue("@endereco", Endereco)
            comando.Parameters.AddWithValue("@celular", Celular)
            comando.Parameters.AddWithValue("@telefone", Telefone)
            comando.Parameters.AddWithValue("@email", Email)
            comando.Parameters.AddWithValue("@id", Id)
            conn.Open()
            retorno = comando.ExecuteNonQuery
            conn.Close()
            Return retorno
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarContato() As DataTable
        Dim query As String
        Dim tabela As New DataTable

        Try
            query = "SELECT id, nome, endereco, celular, telefone, email FROM contatos;"
            comando = New OleDbCommand
            comando.Connection = conn
            comando.CommandType = CommandType.Text
            comando.CommandText = query
            conn.Open()
            da = New OleDbDataAdapter(comando)
            da.Fill(tabela)
            conn.Close()

            Return tabela
            
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarContatoEditar(idCont As Integer) 
        Dim query As String
        Dim dados(5) As String

        Try
            query = "SELECT id, nome, endereco, celular, telefone, email FROM contatos WHERE id = @id;"
            comando = New OleDbCommand
            comando.Connection = conn
            comando.CommandType = CommandType.Text
            comando.CommandText = query
            comando.Parameters.AddWithValue("@id", idCont)
            conn.Open()
            dr = comando.ExecuteReader()
            dr.Read()
            dados(1) = dr("nome").ToString
            dados(2) = dr("endereco").ToString
            dados(3) = dr("celular").ToString
            dados(4) = dr("telefone").ToString
            dados(5) = dr("email").ToString
            conn.Close()

            Return dados
            
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function DeletarContato(id As Integer) As Boolean
        Dim retorno As Boolean
        Dim query As String

        Try
            query = "DELETE FROM contatos WHERE id=@id;"
            comando = New OleDbCommand
            comando.Connection = conn
            comando.CommandType = CommandType.Text
            comando.CommandText = query
            comando.Parameters.AddWithValue("@id", id)
            conn.Open()
            retorno = comando.ExecuteNonQuery
            conn.Close()
            Return retorno
            
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
