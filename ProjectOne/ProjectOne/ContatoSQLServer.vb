Imports ApplicationBlocks.Data

Public Class ContatoSQLServer : Inherits IContato
    Private sql As New SQL

    Sub New()
        Me.DbHelper = New SqlDbHelper
        Me.strCon = sql.strCon
    End Sub
End Class