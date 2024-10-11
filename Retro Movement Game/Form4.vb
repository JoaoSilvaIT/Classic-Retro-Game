Class Form4
    Dim goup As Boolean
    Dim godown As Boolean
    Dim bullets As New List(Of PictureBox)()
    Dim score As Integer = 0
    Dim speed As Integer = 3
    Dim rand As New Random()
    Dim playerSpeed As Integer = 7
    Dim index As Integer
    Dim bulletsToRemove As New List(Of PictureBox)
    Dim minY As Integer = -60
    Dim maxY As Integer = 300


    Private Sub keyisdown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Up Then
            goup = True
        End If

        If e.KeyCode = Keys.Down Then
            godown = True
        End If
        If e.KeyCode = Keys.Space Then
            makeBullet()
            My.Computer.Audio.Play(My.Resources.Tiro, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub keyisup(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Up Then
            goup = False
        End If

        If e.KeyCode = Keys.Down Then
            godown = False
        End If
    End Sub

    Private Sub gametick(sender As Object, e As EventArgs) Handles gameTimer.Tick
        ufo.Left -= speed
        ufo2.Left -= speed
        ally.Left -= speed
        ally2.Left -= speed

        Label1.Text = "Score " & score
        Label2.Text = "Speed " & speed
        If Score < 10 Then
            speed = 3

        ElseIf score > 10 And score < 30 Then
            speed = 4
        ElseIf score > 20 And score < 30 Then
            speed = 5
        ElseIf score > 30 And score < 40 Then
            speed = 7
        ElseIf score > 40 And score < 50 Then
            speed = 10

        End If
        If goup Then
            player.Top -= playerSpeed / 1.4
        End If

        If godown Then
            player.Top += playerSpeed / 1.4
        End If

        If player.Bounds.IntersectsWith(ufo.Bounds) Or player.Bounds.IntersectsWith(ufo2.Bounds) Or player.Bounds.IntersectsWith(ally.Bounds) Or player.Bounds.IntersectsWith(ally2.Bounds) Then
            gameTimer.Stop()
            Botão_Replay.Visible = True
            Botão_Menu.Visible = True
            Texto_Final.Visible = True
            If Me.Visible = True Then My.Computer.Audio.Play(My.Resources.Perder, AudioPlayMode.Background)
        End If
        If Me.Visible = False Then
            My.Resources.Perder.Close()
            For Each bullet As PictureBox In bullets
                Me.Controls.Remove(bullet)
                bullet.Dispose()
            Next
            bullets.Clear()
        End If

        If ufo.Left < -50 Then
            ufo.Left = 800 + rand.Next(0, 300)
            ufo.Top = rand.Next(0, 300)
        End If

        If ufo2.Left < -50 Then
            ufo2.Left = 800 + rand.Next(0, 300)
            ufo2.Top = rand.Next(0, 300)
        End If

        If ally.Left < -50 Then
            ally.Left = 800 + rand.Next(0, 300)
            ally.Top = rand.Next(0, 300)
        End If

        If ally2.Left < -50 Then
            ally2.Left = 800 + rand.Next(0, 300)
            ally2.Top = rand.Next(0, 300)
        End If

        If player.Top < -6 Then
            player.Top = -6
        End If

        If player.Top > 318 Then
            player.Top = 318
        End If

        For Each bullet As PictureBox In bullets
            If bullet.Visible Then
                bullet.Left += 15
            ElseIf gameTimer.Enabled = False Then
                bullet.Visible = False
            End If

            If bullet.Left > 780 Then
                bullet.Hide()
            ElseIf bullet.Bounds.IntersectsWith(ally.Bounds) Then
                gameTimer.Stop()
                Botão_Replay.Visible = True
                Botão_Menu.Visible = True
                Texto_Final.Visible = True
                bulletsToRemove.Add(bullet)
                My.Computer.Audio.Play(My.Resources.Perder, AudioPlayMode.Background)
            ElseIf bullet.Bounds.IntersectsWith(ally2.Bounds) Then
                gameTimer.Stop()
                Botão_Replay.Visible = True
                Botão_Menu.Visible = True
                Texto_Final.Visible = True
                bulletsToRemove.Add(bullet)
                My.Computer.Audio.Play(My.Resources.Perder, AudioPlayMode.Background)
            ElseIf bullet.Bounds.IntersectsWith(ufo.Bounds) Then
                score += 1
                ufo.Left = 800 + rand.Next(0, 300)
                ufo.Top = rand.Next(0, 318)
                bulletsToRemove.Add(bullet)
                bullet.Visible = False
                My.Computer.Audio.Play(My.Resources.Ponto, AudioPlayMode.Background)
            ElseIf bullet.Bounds.IntersectsWith(ufo2.Bounds) Then
                score += 1
                ufo2.Left = 800 + rand.Next(0, 300)
                ufo2.Top = rand.Next(0, 318)
                bulletsToRemove.Add(bullet)
                bullet.Visible = False
                My.Computer.Audio.Play(My.Resources.Ponto, AudioPlayMode.Background)
            End If
        Next
        For Each bullet As PictureBox In bulletsToRemove
            bullets.Remove(bullet)
            bullet.Dispose()
        Next

        Dim pictureBoxLocations As New List(Of Point)
        pictureBoxLocations.Add(ufo.Location)
        pictureBoxLocations.Add(ufo2.Location)
        pictureBoxLocations.Add(ally.Location)
        pictureBoxLocations.Add(ally2.Location)

        For i As Integer = 0 To pictureBoxLocations.Count - 1
            For j As Integer = i + 1 To pictureBoxLocations.Count - 1
                If Math.Abs(pictureBoxLocations(i).X - pictureBoxLocations(j).X) < 64 AndAlso
           Math.Abs(pictureBoxLocations(i).Y - pictureBoxLocations(j).Y) < 64 Then
                    If pictureBoxLocations(i).Y < pictureBoxLocations(j).Y Then
                        Dim newY As Integer = pictureBoxLocations(i).Y - minY

                        Dim overlappingPictureBox As Point = FindOverlappingPictureBox(pictureBoxLocations, i, newY)
                        If overlappingPictureBox = Nothing Then
                            pictureBoxLocations(i) = New Point(pictureBoxLocations(i).X, newY)
                        Else

                            pictureBoxLocations(i) = New Point(pictureBoxLocations(i).X, overlappingPictureBox.Y - minY)
                        End If
                    Else
                        Dim newY As Integer = pictureBoxLocations(j).Y - minY

                        Dim overlappingPictureBox As Point = FindOverlappingPictureBox(pictureBoxLocations, j, newY)
                        If overlappingPictureBox = Nothing Then
                            pictureBoxLocations(j) = New Point(pictureBoxLocations(j).X, newY)
                        Else

                            pictureBoxLocations(j) = New Point(pictureBoxLocations(j).X, overlappingPictureBox.Y - minY)
                        End If
                    End If
                End If
            Next
        Next
        ufo.Location = pictureBoxLocations(0)
        ufo2.Location = pictureBoxLocations(1)
        ally.Location = pictureBoxLocations(2)
        ally2.Location = pictureBoxLocations(3)
    End Sub
    Private Sub makeBullet()
        Dim bullet As New PictureBox
        bullet.Size = New Size(10, 3.5)
        bullet.BackColor = Color.Black
        bullet.Left = (player.Left + player.Width)
        bullet.Top = player.Top + (player.Height / 2) - 2
        bullet.BringToFront()
        bullets.Add(bullet)
        Me.Controls.Add(bullet)
    End Sub
    Private Sub Botão_Replay_Click(sender As Object, e As EventArgs) Handles Botão_Replay.Click
        Botão_Replay.Visible = False
        Botão_Menu.Visible = False
        Texto_Final.Visible = False
        gameTimer.Stop()
        Me.ResetGame()
        Me.Focus()
    End Sub

    Private Sub Button_Menu_Click(sender As Object, e As EventArgs) Handles Botão_Menu.Click
        Form3.Show()
        Me.Hide()
        gameTimer.Stop()
        ResetGame()
    End Sub

    Public Sub ResetGame()
        For Each bullet As PictureBox In bullets
            Me.Controls.Remove(bullet)
            bullet.Dispose()
        Next
        bullets.Clear()
        player.Top = 219
        player.Visible = True
        ufo.Left = 750 + rand.Next(0, 300)
        ufo.Top = rand.Next(0, 318)
        ufo2.Left = 750 + rand.Next(0, 300)
        ufo2.Top = rand.Next(0, 318)
        ally.Left = 750 + rand.Next(0, 300)
        ally.Top = rand.Next(0, 318)
        ally2.Left = 750 + rand.Next(0, 300)
        ally2.Top = rand.Next(0, 318)
        score = 0
        Label1.Text = "Score: " & score
        gameTimer.Start()
        Botão_Replay.Visible = False
        Botão_Menu.Visible = False
        Texto_Final.Visible = False
        goup = False
        godown = False
        gameTimer.Start()
    End Sub

    Function FindOverlappingPictureBox(pictureBoxLocations As List(Of Point), currentPictureBoxIndex As Integer, newY As Integer) As Point
        For i As Integer = 0 To pictureBoxLocations.Count - 1
            If i <> currentPictureBoxIndex Then
                If Math.Abs(pictureBoxLocations(currentPictureBoxIndex).X - pictureBoxLocations(i).X) < 100 AndAlso
                   Math.Abs(newY - pictureBoxLocations(i).Y) < 100 Then
                    Return pictureBoxLocations(i)
                End If
            End If
        Next
        Return Nothing
    End Function

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
