Public Class ChooseDB
    Private Sub BtnSelecionar_Click(sender As Object, e As EventArgs) Handles BtnSelecionar.Click
        Dim escolha As Integer
        If RadioButton1.Checked = True Then
            escolha = 1
        ElseIf RadioButton2.Checked = True Then
            escolha = 2
        End If

        'MessageBox.Show("Opção selecionada: " & escolha)
        Form1.tipoConFormNum = escolha
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub ConfigDB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButton1.Checked = True 
    End Sub
End Class