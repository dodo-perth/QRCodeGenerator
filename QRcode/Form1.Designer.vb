<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.id = New System.Windows.Forms.TextBox()
        Me.pw = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Black = New System.Windows.Forms.Button()
        Me.Green = New System.Windows.Forms.Button()
        Me.Pink = New System.Windows.Forms.Button()
        Me.Yellow = New System.Windows.Forms.Button()
        Me.Color = New System.Windows.Forms.TextBox()
        Me.Blue = New System.Windows.Forms.Button()
        Me.Red = New System.Windows.Forms.Button()
        Me.url = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.qrname = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(114, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 21)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "로그인"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'id
        '
        Me.id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.id.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.id.Location = New System.Drawing.Point(13, 12)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(95, 21)
        Me.id.TabIndex = 1
        '
        'pw
        '
        Me.pw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pw.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.pw.Location = New System.Drawing.Point(13, 39)
        Me.pw.Name = "pw"
        Me.pw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pw.Size = New System.Drawing.Size(95, 21)
        Me.pw.TabIndex = 2
        Me.pw.WordWrap = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(114, 39)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(81, 21)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "회원가입"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("굴림", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label1.Location = New System.Drawing.Point(206, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 11)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "※ 본 프로그램은 네이버 서비스를 사용합니다."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.url)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.qrname)
        Me.GroupBox1.Location = New System.Drawing.Point(224, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(219, 234)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "QR코드 데이터"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("굴림", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label5.Location = New System.Drawing.Point(84, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 11)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "http:// 를 제외하고 입력"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("굴림", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label4.Location = New System.Drawing.Point(148, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 11)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "최대 20글자"
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(6, 193)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(207, 35)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "생성"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Black)
        Me.GroupBox2.Controls.Add(Me.Green)
        Me.GroupBox2.Controls.Add(Me.Pink)
        Me.GroupBox2.Controls.Add(Me.Yellow)
        Me.GroupBox2.Controls.Add(Me.Color)
        Me.GroupBox2.Controls.Add(Me.Blue)
        Me.GroupBox2.Controls.Add(Me.Red)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 94)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(207, 93)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "색상지정"
        '
        'Black
        '
        Me.Black.BackColor = System.Drawing.Color.Black
        Me.Black.Location = New System.Drawing.Point(169, 19)
        Me.Black.Name = "Black"
        Me.Black.Size = New System.Drawing.Size(26, 30)
        Me.Black.TabIndex = 10
        Me.Black.UseVisualStyleBackColor = False
        '
        'Green
        '
        Me.Green.BackColor = System.Drawing.Color.Lime
        Me.Green.Location = New System.Drawing.Point(137, 19)
        Me.Green.Name = "Green"
        Me.Green.Size = New System.Drawing.Size(26, 30)
        Me.Green.TabIndex = 9
        Me.Green.UseVisualStyleBackColor = False
        '
        'Pink
        '
        Me.Pink.BackColor = System.Drawing.Color.Fuchsia
        Me.Pink.Location = New System.Drawing.Point(107, 19)
        Me.Pink.Name = "Pink"
        Me.Pink.Size = New System.Drawing.Size(26, 30)
        Me.Pink.TabIndex = 8
        Me.Pink.UseVisualStyleBackColor = False
        '
        'Yellow
        '
        Me.Yellow.BackColor = System.Drawing.Color.Yellow
        Me.Yellow.Location = New System.Drawing.Point(75, 19)
        Me.Yellow.Name = "Yellow"
        Me.Yellow.Size = New System.Drawing.Size(26, 30)
        Me.Yellow.TabIndex = 7
        Me.Yellow.UseVisualStyleBackColor = False
        '
        'Color
        '
        Me.Color.Enabled = False
        Me.Color.Font = New System.Drawing.Font("굴림", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Color.Location = New System.Drawing.Point(6, 55)
        Me.Color.Name = "Color"
        Me.Color.Size = New System.Drawing.Size(195, 22)
        Me.Color.TabIndex = 6
        Me.Color.Text = "106"
        Me.Color.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Blue
        '
        Me.Blue.BackColor = System.Drawing.Color.Blue
        Me.Blue.Location = New System.Drawing.Point(43, 19)
        Me.Blue.Name = "Blue"
        Me.Blue.Size = New System.Drawing.Size(26, 30)
        Me.Blue.TabIndex = 5
        Me.Blue.UseVisualStyleBackColor = False
        '
        'Red
        '
        Me.Red.BackColor = System.Drawing.Color.Red
        Me.Red.Location = New System.Drawing.Point(13, 19)
        Me.Red.Name = "Red"
        Me.Red.Size = New System.Drawing.Size(26, 30)
        Me.Red.TabIndex = 4
        Me.Red.UseVisualStyleBackColor = False
        '
        'url
        '
        Me.url.Location = New System.Drawing.Point(66, 56)
        Me.url.Name = "url"
        Me.url.Size = New System.Drawing.Size(147, 21)
        Me.url.TabIndex = 3
        Me.url.Text = "naver.com"
        Me.url.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 12)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Url링크 :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "QR이름 :"
        '
        'qrname
        '
        Me.qrname.Location = New System.Drawing.Point(66, 20)
        Me.qrname.MaxLength = 20
        Me.qrname.Name = "qrname"
        Me.qrname.Size = New System.Drawing.Size(147, 21)
        Me.qrname.TabIndex = 0
        Me.qrname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 12
        Me.ListBox1.Location = New System.Drawing.Point(13, 65)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(67, 208)
        Me.ListBox1.TabIndex = 6
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Location = New System.Drawing.Point(86, 226)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(132, 22)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "새로고침"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(86, 67)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(132, 126)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Enabled = False
        Me.MaskedTextBox1.Location = New System.Drawing.Point(86, 199)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(132, 21)
        Me.MaskedTextBox1.TabIndex = 9
        Me.MaskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button5
        '
        Me.Button5.Enabled = False
        Me.Button5.Location = New System.Drawing.Point(86, 251)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(132, 22)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "제거"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 280)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.pw)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.Text = "QR코드 생성기"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents id As System.Windows.Forms.TextBox
    Friend WithEvents pw As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents qrname As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Black As System.Windows.Forms.Button
    Friend WithEvents Green As System.Windows.Forms.Button
    Friend WithEvents Pink As System.Windows.Forms.Button
    Friend WithEvents Yellow As System.Windows.Forms.Button
    Friend WithEvents Color As System.Windows.Forms.TextBox
    Friend WithEvents Blue As System.Windows.Forms.Button
    Friend WithEvents Red As System.Windows.Forms.Button
    Friend WithEvents url As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button

End Class
