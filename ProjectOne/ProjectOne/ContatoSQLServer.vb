Imports ApplicationBlocks.Data

Public Class ContatoSQLServer : Inherits Contato
    Private sql As New SQL

    Sub New()
        Me.DbHelper = New SqlDbHelper
        Me.strCon = sql.strCon
    End Sub
End Class