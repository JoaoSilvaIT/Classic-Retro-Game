Public Class Form1
    Dim Velocidade As Integer
    Dim Estrada(7) As PictureBox
    Dim Pontuação As Integer = 0
    Dim Rand As New Random()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Velocidade = 3
        Estrada(0) = PictureBox1
        Estrada(1) = PictureBox2
        Estrada(2) = PictureBox3
        Estrada(3) = PictureBox4
        Estrada(4) = PictureBox5
        Estrada(5) = PictureBox6
        Estrada(6) = PictureBox7
        Estrada(7) = PictureBox8

    End Sub
    Private Sub Movimento_Estrada_Tick(sender As Object, e As EventArgs) Handles Movimento_Estrada.Tick
        Texto_Velocidade.Text = "Speed " & Velocidade
        For x As Integer = 0 To 7
            Estrada(x).Top += Velocidade
            If Estrada(x).Top >= Me.Height Then
                Estrada(x).Top = -Estrada(x).Height
            End If
        Next
        If Pontuação < 10 Then
            Velocidade = 3
        ElseIf Pontuação > 10 And Pontuação < 30 Then
            Velocidade = 4
        ElseIf Pontuação > 20 And Pontuação < 30 Then
            Velocidade = 5
        ElseIf Pontuação > 30 And Pontuação < 40 Then
            Velocidade = 7
        ElseIf Pontuação > 40 And Pontuação < 50 Then
            Velocidade = 10
        End If

        If (Carro.Bounds.IntersectsWith(Carro_Inimigo1.Bounds)) Then
            Texto_Final.Visible = True
            Movimento_Estrada.Stop()
            Movimento_Inimigo1.Stop()
            Movimento_Inimigo2.Stop()
            Movimento_Inimigo3.Stop()
            Botão_Replay.Visible = True
            Button1.Visible = True
            My.Computer.Audio.Play(My.Resources.Perder, AudioPlayMode.Background)

        ElseIf (Carro.Bounds.IntersectsWith(Carro_Inimigo2.Bounds)) Then
            Texto_Final.Visible = True
            Texto_Final.Visible = True
            Movimento_Estrada.Stop()
            Movimento_Inimigo1.Stop()
            Movimento_Inimigo2.Stop()
            Movimento_Inimigo3.Stop()
            Botão_Replay.Visible = True
            Button1.Visible = True
            My.Computer.Audio.Play(My.Resources.Perder, AudioPlayMode.Background)
        ElseIf (Carro.Bounds.IntersectsWith(Carro_Inimigo3.Bounds)) Then
            Texto_Final.Visible = True
            Texto_Final.Visible = True
            Movimento_Estrada.Stop()
            Movimento_Inimigo1.Stop()
            Movimento_Inimigo2.Stop()
            Movimento_Inimigo3.Stop()
            Botão_Replay.Visible = True
            Button1.Visible = True
            My.Computer.Audio.Play(My.Resources.Perder, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Right Then
            Carro_Direita.Start()

        ElseIf e.KeyCode = Keys.Left Then
            Carro_Esquerda.Start()
        End If
    End Sub

    Private Sub Carro_Esquerda_Tick(sender As Object, e As EventArgs) Handles Carro_Esquerda.Tick
        If (Carro.Location.X > -1) Then
            Carro.Left -= 5
        End If
    End Sub

    Private Sub Carro_Direita_Tick(sender As Object, e As EventArgs) Handles Carro_Direita.Tick
        If (Carro.Location.X < 195) Then
            Carro.Left += 5
        End If
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        Carro_Direita.Stop()
        Carro_Esquerda.Stop()
    End Sub

    Private Sub Movimento_Inimigo1_Tick(sender As Object, e As EventArgs) Handles Movimento_Inimigo1.Tick
        Carro_Inimigo1.Top += Velocidade * 1.1
        If Carro_Inimigo1.Top >= Me.Height Then
            Carro_Inimigo1.Top = -(CInt(Math.Ceiling(Rnd() * 150)) + Carro_Inimigo1.Height)
            Dim newX As Integer = Rand.Next(0, 35)
            Carro_Inimigo1.Left = newX
            Pontuação += 1
            Texto_Pontos.Text = "Score " & Pontuação
        End If
    End Sub

    Private Sub Movimento_Inimigo2_Tick(sender As Object, e As EventArgs) Handles Movimento_Inimigo2.Tick
        Carro_Inimigo2.Top += Velocidade * 1.5
        If Carro_Inimigo2.Top >= Me.Height Then
            Carro_Inimigo2.Top = -(CInt(Math.Ceiling(Rnd() * 150)) + Carro_Inimigo2.Height)
            Dim newX2 As Integer = Rand.Next(75, 131)
            Carro_Inimigo2.Left = newX2
            Pontuação += 1
            Texto_Pontos.Text = "Score " & Pontuação
        End If
    End Sub

    Private Sub Movimento_Inimigo3_Tick(sender As Object, e As EventArgs) Handles Movimento_Inimigo3.Tick
        Carro_Inimigo3.Top += Velocidade * 1.2
        If Carro_Inimigo3.Top >= Me.Height Then
            Carro_Inimigo3.Top = -(CInt(Math.Ceiling(Rnd() * 150)) + Carro_Inimigo3.Height)
            Dim newX3 As Integer = Rand.Next(160, 196)
            Carro_Inimigo3.Left = newX3
            Pontuação += 1
            Texto_Pontos.Text = "Score " & Pontuação
        End If
    End Sub
    Private Sub Button_Replay(sender As Object, e As EventArgs) Handles Button1.Click, Botão_Replay.Click
        Pontuação = 0
        Me.Controls.Clear()
        InitializeComponent()
        Form1_Load(e, e)
    End Sub

    Private Sub Button_1(sender As Object, e As EventArgs) Handles Button1.Click, Button1.Click
        Form3.Show()
        Me.Hide()
        Movimento_Estrada.Stop()
        Movimento_Inimigo1.Stop()
        Movimento_Inimigo2.Stop()
        Movimento_Inimigo3.Stop()
        My.Computer.Audio.Play(My.Resources.Menu, AudioPlayMode.Background)
    End Sub

    Private Sub GameForm_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible Then
            Movimento_Estrada.Enabled = True
            Movimento_Inimigo1.Enabled = True
            Movimento_Inimigo2.Enabled = True
            Movimento_Inimigo3.Enabled = True
        Else
            Movimento_Estrada.Enabled = False
            Movimento_Inimigo1.Enabled = False
            Movimento_Inimigo2.Enabled = False
            Movimento_Inimigo3.Enabled = False
        End If
    End Sub

End Class

