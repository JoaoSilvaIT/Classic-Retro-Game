<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Texto_Pontos = New System.Windows.Forms.Label()
        Me.Texto_Velocidade = New System.Windows.Forms.Label()
        Me.Cometa_Inimigo1 = New System.Windows.Forms.PictureBox()
        Me.Nave = New System.Windows.Forms.PictureBox()
        Me.Cometa_Inimigo2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.Movimento_Espaço = New System.Windows.Forms.Timer(Me.components)
        Me.Botão_Replay = New System.Windows.Forms.Button()
        Me.Movimento_Cometa1 = New System.Windows.Forms.Timer(Me.components)
        Me.Movimento_Cometa2 = New System.Windows.Forms.Timer(Me.components)
        Me.Movimento_Cometa3 = New System.Windows.Forms.Timer(Me.components)
        Me.Nave_Esquerda = New System.Windows.Forms.Timer(Me.components)
        Me.Nave_Direita = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox16 = New System.Windows.Forms.PictureBox()
        Me.Botão_Menu = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.Cometa_Inimigo3 = New System.Windows.Forms.PictureBox()
        Me.Texto_Final = New System.Windows.Forms.PictureBox()
        CType(Me.Cometa_Inimigo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Nave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cometa_Inimigo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cometa_Inimigo3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Texto_Final, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Texto_Pontos
        '
        Me.Texto_Pontos.BackColor = System.Drawing.Color.Transparent
        Me.Texto_Pontos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Texto_Pontos.ForeColor = System.Drawing.Color.Cornsilk
        Me.Texto_Pontos.Location = New System.Drawing.Point(3, 6)
        Me.Texto_Pontos.Name = "Texto_Pontos"
        Me.Texto_Pontos.Size = New System.Drawing.Size(75, 16)
        Me.Texto_Pontos.TabIndex = 7
        Me.Texto_Pontos.Text = "Score 0"
        '
        'Texto_Velocidade
        '
        Me.Texto_Velocidade.BackColor = System.Drawing.Color.Transparent
        Me.Texto_Velocidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Texto_Velocidade.ForeColor = System.Drawing.Color.Cornsilk
        Me.Texto_Velocidade.Location = New System.Drawing.Point(156, 6)
        Me.Texto_Velocidade.Name = "Texto_Velocidade"
        Me.Texto_Velocidade.Size = New System.Drawing.Size(69, 19)
        Me.Texto_Velocidade.TabIndex = 8
        Me.Texto_Velocidade.Text = "Speed 0"
        '
        'Cometa_Inimigo1
        '
        Me.Cometa_Inimigo1.BackColor = System.Drawing.Color.Transparent
        Me.Cometa_Inimigo1.Image = Global.Car_Game.My.Resources.Resources.Asteroide_3
        Me.Cometa_Inimigo1.Location = New System.Drawing.Point(5, 52)
        Me.Cometa_Inimigo1.Name = "Cometa_Inimigo1"
        Me.Cometa_Inimigo1.Size = New System.Drawing.Size(37, 36)
        Me.Cometa_Inimigo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Cometa_Inimigo1.TabIndex = 11
        Me.Cometa_Inimigo1.TabStop = False
        '
        'Nave
        '
        Me.Nave.BackColor = System.Drawing.Color.Transparent
        Me.Nave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Nave.Image = Global.Car_Game.My.Resources.Resources.Nave
        Me.Nave.Location = New System.Drawing.Point(98, 294)
        Me.Nave.Name = "Nave"
        Me.Nave.Size = New System.Drawing.Size(30, 65)
        Me.Nave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Nave.TabIndex = 13
        Me.Nave.TabStop = False
        '
        'Cometa_Inimigo2
        '
        Me.Cometa_Inimigo2.BackColor = System.Drawing.Color.Transparent
        Me.Cometa_Inimigo2.Image = Global.Car_Game.My.Resources.Resources.Asteroide_3
        Me.Cometa_Inimigo2.Location = New System.Drawing.Point(89, -15)
        Me.Cometa_Inimigo2.Name = "Cometa_Inimigo2"
        Me.Cometa_Inimigo2.Size = New System.Drawing.Size(35, 36)
        Me.Cometa_Inimigo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Cometa_Inimigo2.TabIndex = 15
        Me.Cometa_Inimigo2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Car_Game.My.Resources.Resources.tumblr_inline_mns74aF5iR1qz4rgp540
        Me.PictureBox1.Location = New System.Drawing.Point(12, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(12, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Car_Game.My.Resources.Resources.tumblr_inline_mns74aF5iR1qz4rgp540
        Me.PictureBox3.Location = New System.Drawing.Point(200, 157)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(12, 62)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 19
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Car_Game.My.Resources.Resources.tumblr_inline_mns74aF5iR1qz4rgp540
        Me.PictureBox4.Location = New System.Drawing.Point(66, 157)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(12, 62)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 18
        Me.PictureBox4.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.Car_Game.My.Resources.Resources.tumblr_inline_mns74aF5iR1qz4rgp540
        Me.PictureBox7.Location = New System.Drawing.Point(200, 297)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(12, 62)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 23
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.Car_Game.My.Resources.Resources.tumblr_inline_mns74aF5iR1qz4rgp540
        Me.PictureBox8.Location = New System.Drawing.Point(12, 297)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(12, 62)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 22
        Me.PictureBox8.TabStop = False
        '
        'Movimento_Espaço
        '
        Me.Movimento_Espaço.Enabled = True
        Me.Movimento_Espaço.Interval = 10
        '
        'Botão_Replay
        '
        Me.Botão_Replay.BackColor = System.Drawing.Color.Transparent
        Me.Botão_Replay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Botão_Replay.ForeColor = System.Drawing.Color.Red
        Me.Botão_Replay.Location = New System.Drawing.Point(79, 152)
        Me.Botão_Replay.Name = "Botão_Replay"
        Me.Botão_Replay.Size = New System.Drawing.Size(67, 46)
        Me.Botão_Replay.TabIndex = 25
        Me.Botão_Replay.Text = "Replay"
        Me.Botão_Replay.UseVisualStyleBackColor = False
        Me.Botão_Replay.Visible = False
        '
        'Movimento_Cometa1
        '
        Me.Movimento_Cometa1.Enabled = True
        Me.Movimento_Cometa1.Interval = 10
        '
        'Movimento_Cometa2
        '
        Me.Movimento_Cometa2.Enabled = True
        Me.Movimento_Cometa2.Interval = 10
        '
        'Movimento_Cometa3
        '
        Me.Movimento_Cometa3.Enabled = True
        Me.Movimento_Cometa3.Interval = 10
        '
        'Nave_Esquerda
        '
        Me.Nave_Esquerda.Interval = 10
        '
        'Nave_Direita
        '
        Me.Nave_Direita.Interval = 10
        '
        'PictureBox16
        '
        Me.PictureBox16.Image = Global.Car_Game.My.Resources.Resources.tumblr_inline_mns74aF5iR1qz4rgp540
        Me.PictureBox16.Location = New System.Drawing.Point(200, 3)
        Me.PictureBox16.Name = "PictureBox16"
        Me.PictureBox16.Size = New System.Drawing.Size(12, 62)
        Me.PictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox16.TabIndex = 18
        Me.PictureBox16.TabStop = False
        '
        'Botão_Menu
        '
        Me.Botão_Menu.BackColor = System.Drawing.Color.Transparent
        Me.Botão_Menu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Botão_Menu.ForeColor = System.Drawing.Color.Red
        Me.Botão_Menu.Location = New System.Drawing.Point(79, 201)
        Me.Botão_Menu.Name = "Botão_Menu"
        Me.Botão_Menu.Size = New System.Drawing.Size(67, 46)
        Me.Botão_Menu.TabIndex = 25
        Me.Botão_Menu.Text = "Menu"
        Me.Botão_Menu.UseVisualStyleBackColor = False
        Me.Botão_Menu.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Car_Game.My.Resources.Resources.tumblr_inline_mns74aF5iR1qz4rgp540
        Me.PictureBox2.Location = New System.Drawing.Point(66, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(12, 62)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Car_Game.My.Resources.Resources.tumblr_inline_mns74aF5iR1qz4rgp540
        Me.PictureBox5.Location = New System.Drawing.Point(146, 3)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(12, 62)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 18
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.Car_Game.My.Resources.Resources.tumblr_inline_mns74aF5iR1qz4rgp540
        Me.PictureBox6.Location = New System.Drawing.Point(12, 157)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(12, 62)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 18
        Me.PictureBox6.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = Global.Car_Game.My.Resources.Resources.tumblr_inline_mns74aF5iR1qz4rgp540
        Me.PictureBox9.Location = New System.Drawing.Point(146, 157)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(12, 62)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 19
        Me.PictureBox9.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox10.Image = Global.Car_Game.My.Resources.Resources.tumblr_inline_mns74aF5iR1qz4rgp540
        Me.PictureBox10.Location = New System.Drawing.Point(146, 297)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(12, 62)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 23
        Me.PictureBox10.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.Image = Global.Car_Game.My.Resources.Resources.tumblr_inline_mns74aF5iR1qz4rgp540
        Me.PictureBox11.Location = New System.Drawing.Point(66, 297)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(12, 62)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox11.TabIndex = 23
        Me.PictureBox11.TabStop = False
        '
        'Cometa_Inimigo3
        '
        Me.Cometa_Inimigo3.BackColor = System.Drawing.Color.Transparent
        Me.Cometa_Inimigo3.Image = Global.Car_Game.My.Resources.Resources.Asteroide_1
        Me.Cometa_Inimigo3.Location = New System.Drawing.Point(188, 97)
        Me.Cometa_Inimigo3.Name = "Cometa_Inimigo3"
        Me.Cometa_Inimigo3.Size = New System.Drawing.Size(37, 38)
        Me.Cometa_Inimigo3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Cometa_Inimigo3.TabIndex = 12
        Me.Cometa_Inimigo3.TabStop = False
        '
        'Texto_Final
        '
        Me.Texto_Final.Image = Global.Car_Game.My.Resources.Resources.Game_Over_Espaço
        Me.Texto_Final.Location = New System.Drawing.Point(29, 120)
        Me.Texto_Final.Name = "Texto_Final"
        Me.Texto_Final.Size = New System.Drawing.Size(158, 26)
        Me.Texto_Final.TabIndex = 26
        Me.Texto_Final.TabStop = False
        Me.Texto_Final.Visible = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Car_Game.My.Resources.Resources.tumblr_inline_mns74aF5iR1qz4rgp540
        Me.ClientSize = New System.Drawing.Size(224, 361)
        Me.Controls.Add(Me.Texto_Final)
        Me.Controls.Add(Me.Botão_Menu)
        Me.Controls.Add(Me.Botão_Replay)
        Me.Controls.Add(Me.Cometa_Inimigo2)
        Me.Controls.Add(Me.Nave)
        Me.Controls.Add(Me.Cometa_Inimigo3)
        Me.Controls.Add(Me.Cometa_Inimigo1)
        Me.Controls.Add(Me.Texto_Velocidade)
        Me.Controls.Add(Me.Texto_Pontos)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox16)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox3)
        Me.DoubleBuffered = True
        Me.MaximumSize = New System.Drawing.Size(240, 400)
        Me.MinimumSize = New System.Drawing.Size(240, 400)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.Cometa_Inimigo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Nave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cometa_Inimigo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cometa_Inimigo3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Texto_Final, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Texto_Pontos As Label
    Friend WithEvents Texto_Velocidade As Label
    Friend WithEvents Cometa_Inimigo1 As PictureBox
    Friend WithEvents Nave As PictureBox
    Friend WithEvents Cometa_Inimigo2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Movimento_Espaço As Timer
    Friend WithEvents Botão_Replay As Button
    Friend WithEvents Movimento_Cometa1 As Timer
    Friend WithEvents Movimento_Cometa2 As Timer
    Friend WithEvents Movimento_Cometa3 As Timer
    Friend WithEvents Nave_Esquerda As Timer
    Friend WithEvents Nave_Direita As Timer
    Friend WithEvents PictureBox16 As PictureBox
    Friend WithEvents Botão_Menu As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents Cometa_Inimigo3 As PictureBox
    Friend WithEvents Texto_Final As PictureBox
End Class
