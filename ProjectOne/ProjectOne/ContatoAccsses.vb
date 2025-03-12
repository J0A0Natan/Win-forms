Imports ApplicationBlocks.Data

Public Class ContatoAccsses : Inherits IContato
    Sub New()
        Me.DbHelper = New OleDBDbHelper
        ConfiguraCon()
    End Sub

    Protected Overrides Sub ConfiguraCon()
        Dim pathAcsses As String = My.Settings.CaminhoAcsses
        Me.strCon = "Provider=Microsoft.Jet.OleDb.4.0; Data Source=" & pathAcsses
    End Sub
End Class