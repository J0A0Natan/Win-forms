Imports ApplicationBlocks.Data

Public Class ContatoAccsses : Inherits Contato
    Sub New()
        Me.DbHelper = New OleDBDbHelper
        Dim pathAcsses As String = My.Settings.CaminhoAcsses
        Me.strCon = "Provider=Microsoft.Jet.OleDb.4.0; Data Source=" & pathAcsses
    End Sub
End Class