Imports System.Data.SqlClient

Public Class SQL
    'Private server = "10.0.2.4\SQLEXPRESS"
    'Private dataBase = "contatos"
    'Private user = "contatos"
    'Private pass = "Presys2025@"

    Public server As String
    Public dataBase As String
    Public user As String
    Public pass As String

    Public Shared strCon As String
 
    Public Function connectDb() As Boolean
        strCon = $"Data Source={server}; Integrated Security=False; Initial Catalog={dataBase}; User={user}; Password={pass}"
        Try
            Using conn = New SqlConnection(strCon)
                conn.Open()
                MsgBox("SQL: Conexão efetuada com sucesso!" & vbNewLine, vbInformation)
                Return True
            End Using
        Catch ex As Exception
            MsgBox("Não Conectou!" & vbNewLine & ex.Message, vbCritical)
            Return False
        End Try
    End Function
End Class
