<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.gameTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ufo2 = New System.Windows.Forms.PictureBox()
        Me.ufo = New System.Windows.Forms.PictureBox()
        Me.player = New System.Windows.Forms.PictureBox()
        Me.ally = New System.Windows.Forms.PictureBox()
        Me.ally2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Botão_Replay = New System.Windows.Forms.Button()
        Me.Botão_Menu = New System.Windows.Forms.Button()
        Me.Texto_Final = New System.Windows.Forms.PictureBox()
        CType(Me.ufo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ufo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.player, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ally, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ally2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Texto_Final, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gameTimer
        '
        Me.gameTimer.Enabled = True
        Me.gameTimer.Interval = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-1, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "00"
        '
        'ufo2
        '
        Me.ufo2.BackColor = System.Drawing.Color.Transparent
        Me.ufo2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ufo2.Image = Global.Car_Game.My.Resources.Resources.UFO
        Me.ufo2.Location = New System.Drawing.Point(602, 1)
        Me.ufo2.Name = "ufo2"
        Me.ufo2.Size = New System.Drawing.Size(67, 54)
        Me.ufo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ufo2.TabIndex = 3
        Me.ufo2.TabStop = False
        '
        'ufo
        '
        Me.ufo.BackColor = System.Drawing.Color.Transparent
        Me.ufo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ufo.Image = Global.Car_Game.My.Resources.Resources.UFO_2
        Me.ufo.Location = New System.Drawing.Point(709, 190)
        Me.ufo.Name = "ufo"
        Me.ufo.Size = New System.Drawing.Size(64, 60)
        Me.ufo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ufo.TabIndex = 3
        Me.ufo.TabStop = False
        '
        'player
        '
        Me.player.BackColor = System.Drawing.Color.Transparent
        Me.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.player.Image = Global.Car_Game.My.Resources.Resources.Helicopter
        Me.player.Location = New System.Drawing.Point(12, 152)
        Me.player.Name = "player"
        Me.player.Size = New System.Drawing.Size(100, 55)
        Me.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.player.TabIndex = 0
        Me.player.TabStop = False
        '
        'ally
        '
        Me.ally.BackColor = System.Drawing.Color.Transparent
        Me.ally.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ally.Image = Global.Car_Game.My.Resources.Resources.Avião_Aliado
        Me.ally.Location = New System.Drawing.Point(709, 113)
        Me.ally.Name = "ally"
        Me.ally.Size = New System.Drawing.Size(87, 36)
        Me.ally.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ally.TabIndex = 3
        Me.ally.TabStop = False
        '
        'ally2
        '
        Me.ally2.BackColor = System.Drawing.Color.Transparent
        Me.ally2.BackgroundImage = Global.Car_Game.My.Resources.Resources.Helicoptero_Aliado
        Me.ally2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ally2.Location = New System.Drawing.Point(558, 316)
        Me.ally2.Name = "ally2"
        Me.ally2.Size = New System.Drawing.Size(111, 50)
        Me.ally2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ally2.TabIndex = 3
        Me.ally2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(705, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "00"
        '
        'Botão_Replay
        '
        Me.Botão_Replay.BackColor = System.Drawing.Color.Transparent
        Me.Botão_Replay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Botão_Replay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Botão_Replay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Botão_Replay.Location = New System.Drawing.Point(342, 152)
        Me.Botão_Replay.Name = "Botão_Replay"
        Me.Botão_Replay.Size = New System.Drawing.Size(89, 46)
        Me.Botão_Replay.TabIndex = 9
        Me.Botão_Replay.Text = "Replay"
        Me.Botão_Replay.UseVisualStyleBackColor = False
        Me.Botão_Replay.Visible = False
        '
        'Botão_Menu
        '
        Me.Botão_Menu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Botão_Menu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Botão_Menu.Location = New System.Drawing.Point(342, 200)
        Me.Botão_Menu.Name = "Botão_Menu"
        Me.Botão_Menu.Size = New System.Drawing.Size(89, 46)
        Me.Botão_Menu.TabIndex = 8
        Me.Botão_Menu.Text = "Menu"
        Me.Botão_Menu.UseVisualStyleBackColor = True
        Me.Botão_Menu.Visible = False
        '
        'Texto_Final
        '
        Me.Texto_Final.Image = Global.Car_Game.My.Resources.Resources.Game_Over_Helicopetero
        Me.Texto_Final.Location = New System.Drawing.Point(308, 124)
        Me.Texto_Final.Name = "Texto_Final"
        Me.Texto_Final.Size = New System.Drawing.Size(155, 25)
        Me.Texto_Final.TabIndex = 10
        Me.Texto_Final.TabStop = False
        Me.Texto_Final.Visible = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Car_Game.My.Resources.Resources.Background_3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(799, 367)
        Me.Controls.Add(Me.Texto_Final)
        Me.Controls.Add(Me.player)
        Me.Controls.Add(Me.Botão_Menu)
        Me.Controls.Add(Me.Botão_Replay)
        Me.Controls.Add(Me.ally2)
        Me.Controls.Add(Me.ufo2)
        Me.Controls.Add(Me.ally)
        Me.Controls.Add(Me.ufo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.MaximumSize = New System.Drawing.Size(815, 406)
        Me.MinimumSize = New System.Drawing.Size(815, 406)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.TransparencyKey = System.Drawing.Color.White
        CType(Me.ufo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ufo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.player, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ally, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ally2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Texto_Final, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gameTimer As Timer
    Friend WithEvents player As PictureBox
    Friend WithEvents ufo As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ufo2 As PictureBox
    Friend WithEvents ally As PictureBox
    Friend WithEvents ally2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Botão_Replay As Button
    Friend WithEvents Botão_Menu As Button
    Friend WithEvents Texto_Final As PictureBox
End Class
