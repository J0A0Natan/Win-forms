Imports System.Data.Common
Imports System.Security.Cryptography
Imports System.Text
Imports ApplicationBlocks.Data

Public Class Helper
    Public DbHelper
    Public strCon
    Private ReadOnly sql As New SQL

    ' Construtor
    Sub New()
        If My.Settings.TipoCon = 1 Then
            DbHelper = New OleDBDbHelper
            Dim CaminhoAcsses As String = My.Settings.CaminhoAcsses
            strCon = "Provider=Microsoft.Jet.OleDb.4.0; Data Source=" & CaminhoAcsses
        Else
            DbHelper = New SqlDbHelper
            strCon = sql.strCon
        End If
    End Sub

    Public Function Select_(
                           colunas As List(Of String),
                           tabela As String,
                           Optional whereParametro As Dictionary(Of String, Object) = Nothing,
                           Optional orderBy As String = "",
                           Optional ascDesc As String = "ASC"
    ) As DataTable
        Try
            Dim colunasF = String.Join(", ", colunas)
            Dim query = $"SELECT {colunasF} FROM {tabela} "

            Dim parametro As DbParameter = Nothing
            If whereParametro IsNot Nothing Then
                Dim nomeParametro = $"@{whereParametro.Keys(0)}"
                query &= $"WHERE {whereParametro.Keys(0)} = {nomeParametro} "
                parametro = DbHelper.NewParameter(nomeParametro, whereParametro.Values(0))
            End If

            If Not orderBy = "" Then
                query &= $"ORDER BY {orderBy} {ascDesc.ToUpper()}"
            End If

            Dim ds = DbHelper.ExecuteDataset(strCon, CommandType.Text, query, parametro)
            Return ds.Tables(0)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Insert(tabela As String, colunas As Dictionary(Of String, Object)) As Boolean
        Try
            Dim nomesColunas As New List(Of String)
            Dim nomesParametros As New List(Of String)
            Dim parametros As New List(Of DbParameter)

            For Each coluna In colunas
                Dim nomeParametro = "@" & coluna.Key
                nomesColunas.Add(coluna.Key)
                nomesParametros.Add(nomeParametro)
                parametros.Add(DbHelper.NewParameter(nomeParametro, coluna.Value))
            Next

            Dim query As String = $"INSERT INTO {tabela} ({String.Join(", ", nomesColunas)}) VALUES ({String.Join(", ", nomesParametros)})"

            Return DbHelper.ExecuteNonQuery(strCon, CommandType.Text, query, parametros.ToArray())
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Update(tabela As String, colunas As Dictionary(Of String, Object), condicao As String, parametrosCondicao As Dictionary(Of String, Object)) As Boolean
        Try
            Dim setClause As New List(Of String)
            Dim parametros As New List(Of DbParameter)

            For Each coluna In colunas
                Dim nomeParametro = "@" & coluna.Key
                setClause.Add(coluna.Key & " = " & nomeParametro)
                parametros.Add(DbHelper.NewParameter(nomeParametro, coluna.Value))
            Next

            ' Adiciona todos os parâmetros da condição
            For Each cond In parametrosCondicao
                parametros.Add(DbHelper.NewParameter(cond.Key, cond.Value))
            Next

            Dim query = $"UPDATE {tabela} SET {String.Join(", ", setClause)} WHERE {condicao}"
            Return DbHelper.ExecuteNonQuery(strCon, CommandType.Text, query, parametros.ToArray())
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Delete(tabela As String, colunaCond As String, valorCond As Object) As Boolean
        Try
            Dim nomeParametro = "@" & colunaCond
            Dim parametroCond = DbHelper.NewParameter(nomeParametro, valorCond)

            Dim query = $"DELETE FROM {tabela} WHERE {colunaCond} = {nomeParametro}"
            Return DbHelper.ExecuteNonQuery(strCon, CommandType.Text, query, parametroCond)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GerarHashSHA256(texto As String) As String
        Using sha256 As SHA256 = SHA256.Create
            Dim bytesTexto As Byte() = Encoding.UTF8.GetBytes(texto)
            Dim hashBytes As Byte() = sha256.ComputeHash(bytesTexto)

            Dim sb As New StringBuilder()
            For Each b As Byte In hashBytes
                sb.Append(b.ToString("x2")) ' Formato hexadecimal
            Next

            Return sb.ToString()
        End Using
    End Function
End Class