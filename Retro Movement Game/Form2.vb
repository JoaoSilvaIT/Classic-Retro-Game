Public Class Form2
    Dim Velocidade As Integer
    Dim Espaço(15) As PictureBox
    Dim Pontuação As Integer = 0
    Dim Rand As New Random
    Private gameRunning As Boolean = False
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Velocidade = 2
        Espaço(0) = PictureBox1
        Espaço(1) = PictureBox2
        Espaço(2) = PictureBox3
        Espaço(3) = PictureBox4
        Espaço(4) = PictureBox5
        Espaço(5) = PictureBox6
        Espaço(6) = PictureBox7
        Espaço(7) = PictureBox8
        Espaço(8) = PictureBox9
        Espaço(9) = PictureBox10
        Espaço(10) = PictureBox11
        Espaço(11) = PictureBox16
    End Sub

    Private Sub Movimento_Espaço_Tick(sender As Object, e As EventArgs) Handles Movimento_Espaço.Tick
        Texto_Velocidade.Text = "Speed " & Velocidade
        For x As Integer = 0 To 11
            Espaço(x).Top += Velocidade
            If Espaço(x).Top >= Me.Height Then
                Espaço(x).Top = -Espaço(x).Height
            End If
        Next
        If Pontuação < 10 Then
            Velocidade = 2
        ElseIf Pontuação > 10 And Pontuação < 30 Then
            Velocidade = 3
        ElseIf Pontuação > 20 And Pontuação < 30 Then
            Velocidade = 5
        ElseIf Pontuação > 30 And Pontuação < 40 Then
            Velocidade = 6
        ElseIf Pontuação > 40 And Pontuação < 50 Then
            Velocidade = 7
        End If

        If (Nave.Bounds.IntersectsWith(Cometa_Inimigo1.Bounds)) Then
            Texto_Final.Visible = True
            Movimento_Espaço.Stop()
            Movimento_Cometa1.Stop()
            Movimento_Cometa2.Stop()
            Movimento_Cometa3.Stop()
            Botão_Replay.Visible = True
            Botão_Menu.Visible = True
            My.Computer.Audio.Play(My.Resources.Perder, AudioPlayMode.Background)

        ElseIf (Nave.Bounds.IntersectsWith(Cometa_Inimigo2.Bounds)) Then
            Texto_Final.Visible = True
            Texto_Final.Visible = True
            Movimento_Espaço.Stop()
            Movimento_Cometa1.Stop()
            Movimento_Cometa2.Stop()
            Movimento_Cometa3.Stop()
            Botão_Replay.Visible = True
            Botão_Menu.Visible = True
            My.Computer.Audio.Play(My.Resources.Perder, AudioPlayMode.Background)

        ElseIf (Nave.Bounds.IntersectsWith(Cometa_Inimigo3.Bounds)) Then
            Texto_Final.Visible = True
            Texto_Final.Visible = True
            Movimento_Espaço.Stop()
            Movimento_Cometa1.Stop()
            Movimento_Cometa2.Stop()
            Movimento_Cometa3.Stop()
            Botão_Replay.Visible = True
            Botão_Menu.Visible = True
            My.Computer.Audio.Play(My.Resources.Perder, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Right Then
            Nave_Direita.Start()

        ElseIf e.KeyCode = Keys.Left Then
            Nave_Esquerda.Start()
        End If
    End Sub

    Private Sub Nave_Esquerda_Tick(sender As Object, e As EventArgs) Handles Nave_Esquerda.Tick
        If (Nave.Location.X > -1) Then
            Nave.Left -= 5
        End If
    End Sub

    Private Sub Nave_Direita_Tick(sender As Object, e As EventArgs) Handles Nave_Direita.Tick
        If (Nave.Location.X < 192) Then
            Nave.Left += 5
        End If
    End Sub

    Private Sub Form2_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        Nave_Direita.Stop()
        Nave_Esquerda.Stop()
    End Sub

    Private Sub Movimento_Cometa1_Tick(sender As Object, e As EventArgs) Handles Movimento_Cometa1.Tick
        Cometa_Inimigo1.Top += Velocidade
        If Cometa_Inimigo1.Top >= Me.Height Then
            Cometa_Inimigo1.Top = -(CInt(Math.Ceiling(Rnd() * 150)) + Cometa_Inimigo1.Height)
            Dim newX As Integer = Rand.Next(-1, 33)
            Cometa_Inimigo1.Left = newX
            Pontuação += 1
            Texto_Pontos.Text = "Score " & Pontuação
        End If
    End Sub

    Private Sub Movimento_Cometa2_Tick(sender As Object, e As EventArgs) Handles Movimento_Cometa2.Tick
        Cometa_Inimigo2.Top += Velocidade * 1.3
        If Cometa_Inimigo2.Top >= Me.Height Then
            Cometa_Inimigo2.Top = -(CInt(Math.Ceiling(Rnd() * 150)) + Cometa_Inimigo2.Height)
            Dim newX2 As Integer = Rand.Next(70, 113)
            Cometa_Inimigo2.Left = newX2
            Pontuação += 1
            Texto_Pontos.Text = "Score " & Pontuação
        End If
    End Sub

    Private Sub Movimento_Cometa3_Tick(sender As Object, e As EventArgs) Handles Movimento_Cometa3.Tick
        Cometa_Inimigo3.Top += Velocidade * 1.25
        If Cometa_Inimigo3.Top >= Me.Height Then
            Cometa_Inimigo3.Top = -(CInt(Math.Ceiling(Rnd() * 150)) + Cometa_Inimigo3.Height)
            Dim newX3 As Integer = Rand.Next(153, 185)
            Cometa_Inimigo3.Left = newX3
            Pontuação += 1
            Texto_Pontos.Text = "Score " & Pontuação
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Botão_Replay.Click, Botão_Menu.Click
        Pontuação = 0
        Me.Controls.Clear()
        InitializeComponent()
        Form2_Load(e, e)
    End Sub

    Private Sub Botão_Menu_Click(sender As Object, e As EventArgs) Handles Botão_Menu.Click
        Form3.Show()
        Me.Hide()
        Movimento_Espaço.Stop()
        Movimento_Cometa1.Stop()
        Movimento_Cometa2.Stop()
        Movimento_Cometa3.Stop()
        My.Computer.Audio.Play(My.Resources.Menu, AudioPlayMode.Background)
    End Sub

    Private Sub GameForm_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible Then
            Movimento_Espaço.Enabled = True
            Movimento_Cometa1.Enabled = True
            Movimento_Cometa2.Enabled = True
            Movimento_Cometa3.Enabled = True
        Else
            Movimento_Espaço.Enabled = False
            Movimento_Cometa1.Enabled = False
            Movimento_Cometa2.Enabled = False
            Movimento_Cometa3.Enabled = False
        End If
    End Sub
End Class
