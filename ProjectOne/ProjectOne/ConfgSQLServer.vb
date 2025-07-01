Imports System.Data.SqlClient

Public Class ConfigSQLServer
    Private conn As SqlConnection

    Private Async Sub BtnTestar_Click(sender As Object, e As EventArgs) Handles BtnTestar.Click
        ProgressBar1.Visible = True
        lblStatus.Visible = True
        BtnSalvar.Visible = False
        BtnTestar.Visible = False
        BtnVoltar.Visible = False
        Dim result As Boolean = Await Task.Run(Function()
                                                   Return TestarCon()
                                               End Function)
        ProgressBar1.Visible = False
        lblStatus.Visible = False
        BtnSalvar.Visible = True
        BtnTestar.Visible = True
        BtnVoltar.Visible = True

        If result = True Then
            MsgBox("Conexão efetuada com sucesso!" & vbNewLine, vbInformation)
        Else
            MsgBox("Falha ao conectar com o banco de dados!" & vbNewLine, vbCritical)
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

    Public Function TestarCon() As Boolean
        If TxtServer.Text = "" Or TxtDB.Text = "" Or TxtUser.Text = "" Then
            MsgBox("Preencha todos os campos necessarios!", vbExclamation, "Atenção")
            Return False
        Else
            Dim strCon = $"Data Source={TxtServer.Text}; Integrated Security=False; Initial Catalog={TxtDB.Text}; User={TxtUser.Text}; Password={TxtPass.Text}"

            Try
                Using conn = New SqlConnection(strCon)
                    conn.Open()
                    Return True
                    'MsgBox("SQL: Conexão efetuada com sucesso!" & vbNewLine, vbInformation)
                End Using
            Catch ex As Exception
                Return False
                'MsgBox("Falha ao conectar com o banco de dados!" & vbNewLine & ex.Message, vbCritical)
            End Try
        End If
    End Function
End Class