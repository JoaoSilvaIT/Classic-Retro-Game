Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Carros.Click
        Form1.Show()
        Me.Hide()
        My.Computer.Audio.Play(My.Resources.Escolha, AudioPlayMode.Background)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form2.Show()
        Me.Hide()
        My.Computer.Audio.Play(My.Resources.Escolha, AudioPlayMode.Background)
    End Sub

    Public Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim gameForm As New Form4()
        gameForm.ResetGame()
        gameForm.Show()
        Me.Hide()
        My.Computer.Audio.Play(My.Resources.Escolha, AudioPlayMode.Background)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Botão_Saida.Click
        Me.Close()
    End Sub


    Private Sub MenuForm_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible Then
            My.Computer.Audio.Play(My.Resources.Menu, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        Form5.Show()
        Me.Hide()
    End Sub
End Class