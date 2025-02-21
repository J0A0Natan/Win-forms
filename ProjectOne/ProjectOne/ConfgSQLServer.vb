Imports System.Data.SqlClient

Public Class ConfigSQLServer
    Private conn As SqlConnection

    Private Sub BtnTestar_Click(sender As Object, e As EventArgs) Handles BtnTestar.Click
        If TxtServer.Text = "" Or TxtDB.Text = "" Or TxtUser.Text = ""
            MsgBox("Preencha todos os campos necessarios!", vbExclamation)
        Else
            Dim strCon = $"Data Source={TxtServer.Text}; Integrated Security=False; Initial Catalog={TxtDB.Text}; User={TxtUser.Text}; Password={TxtPass.Text}"

            Try
                Using conn = New SqlConnection(strCon)
                    conn.Open()
                    MsgBox("SQL: Conexão efetuada com sucesso!" & vbNewLine, vbInformation)
                End Using
            Catch ex As Exception
                MsgBox("Falha ao conectar com o banco de dados!" & vbNewLine & ex.Message, vbCritical)
            End Try
        End If
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        My.Settings.ServidorSQL = TxtServer.Text
        My.Settings.BancoDeDados = TxtDB.Text
        My.Settings.UsuarioSQL = TxtUser.Text
        My.Settings.SenhaSQL = TxtPass.Text
        Me.Close()
        ChooseDB.Show()
    End Sub

    Private Sub BtnVoltar_Click(sender As Object, e As EventArgs) Handles BtnVoltar.Click
        Me.Close()
        ChooseDB.Show()
    End Sub

    Private Sub ConfigSQLServer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtServer.Text = My.Settings.ServidorSQL
        TxtDB.Text = My.Settings.BancoDeDados
        TxtUser.Text = My.Settings.UsuarioSQL
        'TxtPass.Text = My.Settings.SenhaSQL
    End Sub
End Class