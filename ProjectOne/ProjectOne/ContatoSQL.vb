Imports System.Data.SqlClient

Public Class ContatoSQL
    'Atributos
    Private sql As New SQL
    Private conn As SqlConnection
    Private da As SqlDataAdapter
    Private dt As New DataTable
    Private dr As SqlDataReader
    Private cmd As SqlCommand

    'Construtor
    Sub New()
        'Try
        '    conn = New SqlConnection(sql.strCon)
        '    conn.Open()
        '    MsgBox("SQL: Conexão efetuada com sucesso!" & vbNewLine, vbInformation)
        'Catch ex As Exception
        '    MsgBox("SQL: Não Conectou!" & vbNewLine & ex.Message, vbCritical)
        'End Try
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
            Using conn = New SqlConnection(sql.strCon)
                cmd = New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@nome", Nome)
                cmd.Parameters.AddWithValue("@endereco", Endereco)
                cmd.Parameters.AddWithValue("@celular", Celular)
                cmd.Parameters.AddWithValue("@telefone", Telefone)
                cmd.Parameters.AddWithValue("@email", Email)
                conn.Open()
                retorno = cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return retorno
    End Function

    Public Function AtualizarContato() As Boolean
        Dim retorno As Boolean
        Dim query As String

        Try
            query = "UPDATE contatos SET nome = @nome, endereco = @endereco, celular = @celular, telefone = @telefone, email = @email WHERE id = @id;"
            Using conn = New SqlConnection(sql.strCon)
                conn.Open()
                Using cmd = New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nome", Nome)
                    cmd.Parameters.AddWithValue("@endereco", Endereco)
                    cmd.Parameters.AddWithValue("@celular", Celular)
                    cmd.Parameters.AddWithValue("@telefone", Telefone)
                    cmd.Parameters.AddWithValue("@email", Email)
                    cmd.Parameters.AddWithValue("@id", Id)
                    retorno = cmd.ExecuteNonQuery()
                End Using
            End Using
            Return retorno
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarContato() As DataTable
        Dim query As String
        Dim tabela As New DataTable

        Try
            Using conn = New SqlConnection(sql.strCon)
                query = "SELECT id, nome, endereco, celular, telefone, email FROM contatos ORDER BY id DESC;"
                da = New SqlDataAdapter(query, conn)
                da.Fill(tabela)
                Return tabela
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function ListarContatoEditar(idCont As Integer)
        Dim query As String
        Dim dados(5) As String

        Try
            query = "SELECT id, nome, endereco, celular, telefone, email FROM contatos WHERE id = @id;"
            Using conn = New SqlConnection(sql.strCon)
                    conn.Open()
                    Using cmd = New SqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@id", idCont)
                        dr = cmd.ExecuteReader()
                        dr.Read()
                        dados(1) = dr("nome")
                        dados(2) = dr("endereco")
                        dados(3) = dr("celular")
                        dados(4) = dr("telefone")
                        dados(5) = dr("email")
                        Return dados
                    End Using
            End Using
        
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Public Function DeletarContato(id As Integer) As Boolean
        Dim retorno As Boolean
        Dim query As String

        Try
            query = "DELETE FROM contatos WHERE id=@id;"
            Using conn = New SqlConnection(sql.strCon)
                conn.Open()
                Using cmd = New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    retorno = cmd.ExecuteNonQuery()
                    Return retorno
                End Using
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
