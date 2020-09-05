<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Question
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.KaratTidak = New System.Windows.Forms.RadioButton()
        Me.KaratYa = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.P_Bolong = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BolongLembaran = New System.Windows.Forms.RadioButton()
        Me.BolongPinggiran = New System.Windows.Forms.RadioButton()
        Me.BolongTidak = New System.Windows.Forms.RadioButton()
        Me.BolongYa = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GarisTidak = New System.Windows.Forms.RadioButton()
        Me.GarisYa = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.LipatanTidak = New System.Windows.Forms.RadioButton()
        Me.LipatanYa = New System.Windows.Forms.RadioButton()
        Me.B_Hasil = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.P_Pola = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PolaOli = New System.Windows.Forms.RadioButton()
        Me.PolaKarat = New System.Windows.Forms.RadioButton()
        Me.PolaTidak = New System.Windows.Forms.RadioButton()
        Me.PolaYa = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.P_Bolong.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.P_Pola.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.KaratTidak)
        Me.GroupBox1.Controls.Add(Me.KaratYa)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(166, 66)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Karat ?"
        '
        'KaratTidak
        '
        Me.KaratTidak.AutoSize = True
        Me.KaratTidak.Location = New System.Drawing.Point(7, 43)
        Me.KaratTidak.Name = "KaratTidak"
        Me.KaratTidak.Size = New System.Drawing.Size(52, 17)
        Me.KaratTidak.TabIndex = 1
        Me.KaratTidak.TabStop = True
        Me.KaratTidak.Text = "Tidak"
        Me.KaratTidak.UseVisualStyleBackColor = True
        '
        'KaratYa
        '
        Me.KaratYa.AutoSize = True
        Me.KaratYa.Location = New System.Drawing.Point(7, 20)
        Me.KaratYa.Name = "KaratYa"
        Me.KaratYa.Size = New System.Drawing.Size(38, 17)
        Me.KaratYa.TabIndex = 0
        Me.KaratYa.TabStop = True
        Me.KaratYa.Text = "Ya"
        Me.KaratYa.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.P_Bolong)
        Me.GroupBox2.Controls.Add(Me.BolongTidak)
        Me.GroupBox2.Controls.Add(Me.BolongYa)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 98)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(166, 142)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Bolong ?"
        '
        'P_Bolong
        '
        Me.P_Bolong.Controls.Add(Me.Label2)
        Me.P_Bolong.Controls.Add(Me.BolongLembaran)
        Me.P_Bolong.Controls.Add(Me.BolongPinggiran)
        Me.P_Bolong.Location = New System.Drawing.Point(7, 66)
        Me.P_Bolong.Name = "P_Bolong"
        Me.P_Bolong.Size = New System.Drawing.Size(148, 65)
        Me.P_Bolong.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Bagian?"
        '
        'BolongLembaran
        '
        Me.BolongLembaran.AutoSize = True
        Me.BolongLembaran.Location = New System.Drawing.Point(3, 43)
        Me.BolongLembaran.Name = "BolongLembaran"
        Me.BolongLembaran.Size = New System.Drawing.Size(96, 17)
        Me.BolongLembaran.TabIndex = 3
        Me.BolongLembaran.TabStop = True
        Me.BolongLembaran.Text = "Lembaran Baja"
        Me.BolongLembaran.UseVisualStyleBackColor = True
        '
        'BolongPinggiran
        '
        Me.BolongPinggiran.AutoSize = True
        Me.BolongPinggiran.Location = New System.Drawing.Point(3, 20)
        Me.BolongPinggiran.Name = "BolongPinggiran"
        Me.BolongPinggiran.Size = New System.Drawing.Size(93, 17)
        Me.BolongPinggiran.TabIndex = 2
        Me.BolongPinggiran.TabStop = True
        Me.BolongPinggiran.Text = "Pinggiran Baja"
        Me.BolongPinggiran.UseVisualStyleBackColor = True
        '
        'BolongTidak
        '
        Me.BolongTidak.AutoSize = True
        Me.BolongTidak.Location = New System.Drawing.Point(7, 43)
        Me.BolongTidak.Name = "BolongTidak"
        Me.BolongTidak.Size = New System.Drawing.Size(52, 17)
        Me.BolongTidak.TabIndex = 1
        Me.BolongTidak.TabStop = True
        Me.BolongTidak.Text = "Tidak"
        Me.BolongTidak.UseVisualStyleBackColor = True
        '
        'BolongYa
        '
        Me.BolongYa.AutoSize = True
        Me.BolongYa.Location = New System.Drawing.Point(7, 20)
        Me.BolongYa.Name = "BolongYa"
        Me.BolongYa.Size = New System.Drawing.Size(38, 17)
        Me.BolongYa.TabIndex = 0
        Me.BolongYa.TabStop = True
        Me.BolongYa.Text = "Ya"
        Me.BolongYa.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GarisTidak)
        Me.GroupBox3.Controls.Add(Me.GarisYa)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 246)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(166, 66)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Garis Di Lembaran Baja?"
        '
        'GarisTidak
        '
        Me.GarisTidak.AutoSize = True
        Me.GarisTidak.Location = New System.Drawing.Point(7, 43)
        Me.GarisTidak.Name = "GarisTidak"
        Me.GarisTidak.Size = New System.Drawing.Size(52, 17)
        Me.GarisTidak.TabIndex = 1
        Me.GarisTidak.TabStop = True
        Me.GarisTidak.Text = "Tidak"
        Me.GarisTidak.UseVisualStyleBackColor = True
        '
        'GarisYa
        '
        Me.GarisYa.AutoSize = True
        Me.GarisYa.Location = New System.Drawing.Point(7, 20)
        Me.GarisYa.Name = "GarisYa"
        Me.GarisYa.Size = New System.Drawing.Size(38, 17)
        Me.GarisYa.TabIndex = 0
        Me.GarisYa.TabStop = True
        Me.GarisYa.Text = "Ya"
        Me.GarisYa.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.LipatanTidak)
        Me.GroupBox4.Controls.Add(Me.LipatanYa)
        Me.GroupBox4.Location = New System.Drawing.Point(196, 160)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(166, 66)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Adanya Lipatan?"
        '
        'LipatanTidak
        '
        Me.LipatanTidak.AutoSize = True
        Me.LipatanTidak.Location = New System.Drawing.Point(7, 43)
        Me.LipatanTidak.Name = "LipatanTidak"
        Me.LipatanTidak.Size = New System.Drawing.Size(52, 17)
        Me.LipatanTidak.TabIndex = 1
        Me.LipatanTidak.TabStop = True
        Me.LipatanTidak.Text = "Tidak"
        Me.LipatanTidak.UseVisualStyleBackColor = True
        '
        'LipatanYa
        '
        Me.LipatanYa.AutoSize = True
        Me.LipatanYa.Location = New System.Drawing.Point(7, 20)
        Me.LipatanYa.Name = "LipatanYa"
        Me.LipatanYa.Size = New System.Drawing.Size(38, 17)
        Me.LipatanYa.TabIndex = 0
        Me.LipatanYa.TabStop = True
        Me.LipatanYa.Text = "Ya"
        Me.LipatanYa.UseVisualStyleBackColor = True
        '
        'B_Hasil
        '
        Me.B_Hasil.Location = New System.Drawing.Point(196, 229)
        Me.B_Hasil.Name = "B_Hasil"
        Me.B_Hasil.Size = New System.Drawing.Size(166, 83)
        Me.B_Hasil.TabIndex = 6
        Me.B_Hasil.Text = "Lihat Hasil"
        Me.B_Hasil.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.P_Pola)
        Me.GroupBox5.Controls.Add(Me.PolaTidak)
        Me.GroupBox5.Controls.Add(Me.PolaYa)
        Me.GroupBox5.Location = New System.Drawing.Point(196, 12)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(166, 142)
        Me.GroupBox5.TabIndex = 7
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Adanya Pola?"
        '
        'P_Pola
        '
        Me.P_Pola.Controls.Add(Me.Label3)
        Me.P_Pola.Controls.Add(Me.PolaOli)
        Me.P_Pola.Controls.Add(Me.PolaKarat)
        Me.P_Pola.Location = New System.Drawing.Point(7, 66)
        Me.P_Pola.Name = "P_Pola"
        Me.P_Pola.Size = New System.Drawing.Size(148, 65)
        Me.P_Pola.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Bentuk?"
        '
        'PolaOli
        '
        Me.PolaOli.AutoSize = True
        Me.PolaOli.Location = New System.Drawing.Point(3, 43)
        Me.PolaOli.Name = "PolaOli"
        Me.PolaOli.Size = New System.Drawing.Size(114, 17)
        Me.PolaOli.TabIndex = 3
        Me.PolaOli.TabStop = True
        Me.PolaOli.Text = "Pola Genangan Oli"
        Me.PolaOli.UseVisualStyleBackColor = True
        '
        'PolaKarat
        '
        Me.PolaKarat.AutoSize = True
        Me.PolaKarat.Location = New System.Drawing.Point(3, 20)
        Me.PolaKarat.Name = "PolaKarat"
        Me.PolaKarat.Size = New System.Drawing.Size(139, 17)
        Me.PolaKarat.TabIndex = 2
        Me.PolaKarat.TabStop = True
        Me.PolaKarat.Text = "Pola Karat Merah/Hitam"
        Me.PolaKarat.UseVisualStyleBackColor = True
        '
        'PolaTidak
        '
        Me.PolaTidak.AutoSize = True
        Me.PolaTidak.Location = New System.Drawing.Point(7, 43)
        Me.PolaTidak.Name = "PolaTidak"
        Me.PolaTidak.Size = New System.Drawing.Size(52, 17)
        Me.PolaTidak.TabIndex = 1
        Me.PolaTidak.TabStop = True
        Me.PolaTidak.Text = "Tidak"
        Me.PolaTidak.UseVisualStyleBackColor = True
        '
        'PolaYa
        '
        Me.PolaYa.AutoSize = True
        Me.PolaYa.Location = New System.Drawing.Point(7, 20)
        Me.PolaYa.Name = "PolaYa"
        Me.PolaYa.Size = New System.Drawing.Size(38, 17)
        Me.PolaYa.TabIndex = 0
        Me.PolaYa.TabStop = True
        Me.PolaYa.Text = "Ya"
        Me.PolaYa.UseVisualStyleBackColor = True
        '
        'Question
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 320)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.B_Hasil)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Question"
        Me.Text = "Question"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.P_Bolong.ResumeLayout(False)
        Me.P_Bolong.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.P_Pola.ResumeLayout(False)
        Me.P_Pola.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents KaratTidak As RadioButton
    Friend WithEvents KaratYa As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents P_Bolong As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents BolongLembaran As RadioButton
    Friend WithEvents BolongPinggiran As RadioButton
    Friend WithEvents BolongTidak As RadioButton
    Friend WithEvents BolongYa As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GarisTidak As RadioButton
    Friend WithEvents GarisYa As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents LipatanTidak As RadioButton
    Friend WithEvents LipatanYa As RadioButton
    Friend WithEvents B_Hasil As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents P_Pola As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents PolaOli As RadioButton
    Friend WithEvents PolaKarat As RadioButton
    Friend WithEvents PolaTidak As RadioButton
    Friend WithEvents PolaYa As RadioButton
End Class
