Imports System.Data.SqlClient

Public Class ChooseDB
    Private conn As SqlConnection
    Private ReadOnly sqlString As New SQL

    Private Async Sub BtnSelecionar_Click(sender As Object, e As EventArgs) Handles BtnSelecionar.Click
        'Dim escolha As Integer
        If rdAccess.Checked = True Then
            My.Settings.TipoCon = 1
        ElseIf rdSqlServer.Checked = True Then
            My.Settings.TipoCon = 2
        End If

        If My.Settings.CaminhoAcsses = "" And My.Settings.TipoCon = 1 Then
            MsgBox("Configure o acesso antes!", vbExclamation, "Atenção")
        ElseIf My.Settings.ServidorSQL = "" And My.Settings.TipoCon = 2 Then
            MsgBox("Configure a conexão com o banco antes!", vbExclamation, "Atenção")
        Else
            If My.Settings.TipoCon = 1 Then
                Hide()
                Form1.Show()
            Else
                ' Mostra os elementos de "carregando"
                lblStatus.Visible = True
                ProgressBar1.Visible = True
                BtnSelecionar.Enabled = False
                BtnConfig.Enabled = False

                ' Executa a conexão em segundo plano
                Dim sucesso As Boolean = Await Task.Run(Function()
                                                            Return TestarConSQL()
                                                        End Function)

                ' Esconde os elementos de carregando
                lblStatus.Visible = False
                ProgressBar1.Visible = False
                BtnSelecionar.Enabled = True
                BtnConfig.Enabled = True

                ' Mostra o resultado
                If sucesso Then
                    'MessageBox.Show("Conexão realizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Hide()
                    Form1.Show()
                Else
                    MessageBox.Show("Erro ao conectar ao banco.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Sub ConfigDB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rdAccess.Checked = True
    End Sub

    Private Sub BtnConfig_Click(sender As Object, e As EventArgs) Handles BtnConfig.Click
        If rdAccess.Checked = True Then
            ConfigAcsses.Show()
            Me.Hide()
        ElseIf rdSqlServer.Checked = True Then
            ConfigSQLServer.Show()
            Me.Hide()
        End If
    End Sub

    Public Function TestarConSQL() As Boolean
        Dim strCon = sqlString.strCon

        Try
            Using conn = New SqlConnection(strCon)
                conn.Open()
                Return True
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class