Public Class SQL
    Public server As String = My.Settings.ServidorSQL
    Public dataBase As String = My.Settings.BancoDeDados
    Public user As String = My.Settings.UsuarioSQL
    Public pass As String = My.Settings.SenhaSQL

    Public strCon = $"Data Source={server}; Integrated Security=False; Initial Catalog={dataBase}; User={user}; Password={pass}"
End Class