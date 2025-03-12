Imports ApplicationBlocks.Data

Public Class ContatoSQLServer : Inherits IContato
    Private sql As New SQL

    Sub New()
        Me.DbHelper = New SqlDbHelper
        ConfiguraCon()
    End Sub

    Protected Overrides Sub ConfiguraCon()
        Me.strCon = sql.strCon
    End Sub
End Class