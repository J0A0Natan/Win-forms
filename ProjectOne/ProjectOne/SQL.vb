Imports System.Data.SqlClient

Public Class SQL
    'Private server = "10.0.2.4\SQLEXPRESS"
    'Private dataBase = "contatos"
    'Private user = "contatos"
    'Private pass = "Presys2025@"

    Public server As String = My.Settings.ServidorSQL
    Public dataBase As String = My.Settings.BancoDeDados
    Public user As String = My.Settings.UsuarioSQL
    Public pass As String = My.Settings.SenhaSQL

    Public strCon = $"Data Source={server}; Integrated Security=False; Initial Catalog={dataBase}; User={user}; Password={pass}"
 
    'Public Function connectDb() As Boolean
    '    'strCon = $"Data Source={server}; Integrated Security=False; Initial Catalog={dataBase}; User={user}; Password={pass}"
    '    Try
    '        Using conn = New SqlConnection(strCon)
    '            conn.Open()
    '            MsgBox("SQL: Conexão efetuada com sucesso!" & vbNewLine, vbInformation)
    '            Return True
    '        End Using
    '    Catch ex As Exception
    '        MsgBox("Não Conectou!" & vbNewLine & ex.Message, vbCritical)
    '        Return False
    '    End Try
    'End Function
End Class
