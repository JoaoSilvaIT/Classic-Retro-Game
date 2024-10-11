<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Movimento_Estrada = New System.Windows.Forms.Timer(Me.components)
        Me.Carro_Esquerda = New System.Windows.Forms.Timer(Me.components)
        Me.Carro_Direita = New System.Windows.Forms.Timer(Me.components)
        Me.Movimento_Inimigo1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Movimento_Inimigo2 = New System.Windows.Forms.Timer(Me.components)
        Me.Movimento_Inimigo3 = New System.Windows.Forms.Timer(Me.components)
        Me.Texto_Pontos = New System.Windows.Forms.Label()
        Me.Texto_Velocidade = New System.Windows.Forms.Label()
        Me.Botão_Replay = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Texto_Final = New System.Windows.Forms.PictureBox()
        Me.Carro = New System.Windows.Forms.PictureBox()
        Me.Carro_Inimigo2 = New System.Windows.Forms.PictureBox()
        Me.Carro_Inimigo1 = New System.Windows.Forms.PictureBox()
        Me.Carro_Inimigo3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        CType(Me.Texto_Final, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Carro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Carro_Inimigo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Carro_Inimigo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Carro_Inimigo3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Movimento_Estrada
        '
        Me.Movimento_Estrada.Enabled = True
        Me.Movimento_Estrada.Interval = 10
        '
        'Carro_Esquerda
        '
        Me.Carro_Esquerda.Interval = 10
        '
        'Carro_Direita
        '
        Me.Carro_Direita.Interval = 10
        '
        'Movimento_Inimigo1
        '
        Me.Movimento_Inimigo1.Enabled = True
        Me.Movimento_Inimigo1.Interval = 10
        '
        'Movimento_Inimigo2
        '
        Me.Movimento_Inimigo2.Enabled = True
        Me.Movimento_Inimigo2.Interval = 10
        '
        'Movimento_Inimigo3
        '
        Me.Movimento_Inimigo3.Enabled = True
        Me.Movimento_Inimigo3.Interval = 10
        '
        'Texto_Pontos
        '
        Me.Texto_Pontos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Texto_Pontos.ForeColor = System.Drawing.Color.Cornsilk
        Me.Texto_Pontos.Location = New System.Drawing.Point(1, 5)
        Me.Texto_Pontos.Name = "Texto_Pontos"
        Me.Texto_Pontos.Size = New System.Drawing.Size(75, 16)
        Me.Texto_Pontos.TabIndex = 6
        Me.Texto_Pontos.Text = "Score 0"
        '
        'Texto_Velocidade
        '
        Me.Texto_Velocidade.BackColor = System.Drawing.Color.Transparent
        Me.Texto_Velocidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Texto_Velocidade.ForeColor = System.Drawing.Color.Cornsilk
        Me.Texto_Velocidade.Location = New System.Drawing.Point(150, 5)
        Me.Texto_Velocidade.Name = "Texto_Velocidade"
        Me.Texto_Velocidade.Size = New System.Drawing.Size(77, 16)
        Me.Texto_Velocidade.TabIndex = 6
        Me.Texto_Velocidade.Text = "Speed 0"
        '
        'Botão_Replay
        '
        Me.Botão_Replay.BackColor = System.Drawing.Color.Transparent
        Me.Botão_Replay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Botão_Replay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Botão_Replay.ForeColor = System.Drawing.Color.Red
        Me.Botão_Replay.Location = New System.Drawing.Point(82, 149)
        Me.Botão_Replay.Name = "Botão_Replay"
        Me.Botão_Replay.Size = New System.Drawing.Size(67, 46)
        Me.Botão_Replay.TabIndex = 7
        Me.Botão_Replay.Text = "Replay"
        Me.Botão_Replay.UseVisualStyleBackColor = False
        Me.Botão_Replay.Visible = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(82, 195)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(67, 46)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Menu"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Texto_Final
        '
        Me.Texto_Final.Image = Global.Car_Game.My.Resources.Resources.Fundo_Carros
        Me.Texto_Final.Location = New System.Drawing.Point(30, 116)
        Me.Texto_Final.Name = "Texto_Final"
        Me.Texto_Final.Size = New System.Drawing.Size(166, 28)
        Me.Texto_Final.TabIndex = 8
        Me.Texto_Final.TabStop = False
        Me.Texto_Final.Visible = False
        '
        'Carro
        '
        Me.Carro.BackColor = System.Drawing.Color.Transparent
        Me.Carro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Carro.Image = Global.Car_Game.My.Resources.Resources.Jogador1
        Me.Carro.Location = New System.Drawing.Point(101, 292)
        Me.Carro.Name = "Carro"
        Me.Carro.Size = New System.Drawing.Size(31, 66)
        Me.Carro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Carro.TabIndex = 1
        Me.Carro.TabStop = False
        '
        'Carro_Inimigo2
        '
        Me.Carro_Inimigo2.BackColor = System.Drawing.Color.Transparent
        Me.Carro_Inimigo2.Image = Global.Car_Game.My.Resources.Resources.Carro_Inimigo_2
        Me.Carro_Inimigo2.Location = New System.Drawing.Point(102, -65)
        Me.Carro_Inimigo2.Name = "Carro_Inimigo2"
        Me.Carro_Inimigo2.Size = New System.Drawing.Size(24, 70)
        Me.Carro_Inimigo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Carro_Inimigo2.TabIndex = 4
        Me.Carro_Inimigo2.TabStop = False
        '
        'Carro_Inimigo1
        '
        Me.Carro_Inimigo1.BackColor = System.Drawing.Color.Transparent
        Me.Carro_Inimigo1.Image = Global.Car_Game.My.Resources.Resources.Carro_Inimigo_1
        Me.Carro_Inimigo1.Location = New System.Drawing.Point(4, 42)
        Me.Carro_Inimigo1.Name = "Carro_Inimigo1"
        Me.Carro_Inimigo1.Size = New System.Drawing.Size(31, 63)
        Me.Carro_Inimigo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Carro_Inimigo1.TabIndex = 3
        Me.Carro_Inimigo1.TabStop = False
        '
        'Carro_Inimigo3
        '
        Me.Carro_Inimigo3.BackColor = System.Drawing.Color.Transparent
        Me.Carro_Inimigo3.Image = Global.Car_Game.My.Resources.Resources.Carro_Inimigo_3
        Me.Carro_Inimigo3.Location = New System.Drawing.Point(181, 160)
        Me.Carro_Inimigo3.Name = "Carro_Inimigo3"
        Me.Carro_Inimigo3.Size = New System.Drawing.Size(31, 63)
        Me.Carro_Inimigo3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Carro_Inimigo3.TabIndex = 2
        Me.Carro_Inimigo3.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.Location = New System.Drawing.Point(155, -49)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(10, 96)
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.White
        Me.PictureBox4.Location = New System.Drawing.Point(66, 73)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(10, 96)
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.White
        Me.PictureBox8.Location = New System.Drawing.Point(155, 315)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(10, 96)
        Me.PictureBox8.TabIndex = 0
        Me.PictureBox8.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.White
        Me.PictureBox6.Location = New System.Drawing.Point(66, 315)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(10, 96)
        Me.PictureBox6.TabIndex = 0
        Me.PictureBox6.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Location = New System.Drawing.Point(66, 190)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(10, 96)
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(66, -49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(10, 96)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.White
        Me.PictureBox7.Location = New System.Drawing.Point(155, 73)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(10, 96)
        Me.PictureBox7.TabIndex = 0
        Me.PictureBox7.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.White
        Me.PictureBox5.Location = New System.Drawing.Point(155, 190)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(10, 96)
        Me.PictureBox5.TabIndex = 0
        Me.PictureBox5.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(224, 361)
        Me.Controls.Add(Me.Texto_Final)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Botão_Replay)
        Me.Controls.Add(Me.Carro)
        Me.Controls.Add(Me.Carro_Inimigo2)
        Me.Controls.Add(Me.Carro_Inimigo1)
        Me.Controls.Add(Me.Carro_Inimigo3)
        Me.Controls.Add(Me.Texto_Velocidade)
        Me.Controls.Add(Me.Texto_Pontos)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox5)
        Me.MaximumSize = New System.Drawing.Size(240, 400)
        Me.MinimumSize = New System.Drawing.Size(240, 400)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.SystemColors.MenuHighlight
        CType(Me.Texto_Final, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Carro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Carro_Inimigo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Carro_Inimigo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Carro_Inimigo3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Movimento_Estrada As Timer
    Friend WithEvents Carro As PictureBox
    Friend WithEvents Carro_Esquerda As Timer
    Friend WithEvents Carro_Direita As Timer
    Friend WithEvents Carro_Inimigo3 As PictureBox
    Friend WithEvents Carro_Inimigo1 As PictureBox
    Friend WithEvents Carro_Inimigo2 As PictureBox
    Friend WithEvents Movimento_Inimigo1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Movimento_Inimigo2 As Timer
    Friend WithEvents Movimento_Inimigo3 As Timer
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Texto_Pontos As Label
    Friend WithEvents Texto_Velocidade As Label
    Friend WithEvents Botão_Replay As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Texto_Final As PictureBox
End Class
