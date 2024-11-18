Public Class Form1

    Dim Winhttp As New WinHttp.WinHttpRequest
    Private Property Temp As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Winhttp.Open("POST", "https://nid.naver.com/nidlogin.login")
        Winhttp.SetRequestHeader("Referer", "http://nid.naver.com/nidlogin.login?url=http%3A%2F%2Fqr.naver.com%2Fcode%2FcreateForm.nhn")
        Winhttp.SetRequestHeader("Content-Type", "application/x-www-form-urlencoded")
        Winhttp.Send("enctp=2&svctype=0&id=" & id.Text & "&pw=" & pw.Text)

        If InStr(System.Text.Encoding.Default.GetString(Winhttp.ResponseBody), "http://static.nid.naver.com/sso/cr") Then
            MsgBox("로그인 성공", vbInformation, "로그인 성공")
            Button3.Enabled = True
            id.Enabled = False
            pw.Enabled = False
            Button1.Enabled = False
            Button2.Enabled = False
            Button4.Enabled = True
            Button5.Enabled = True
            '로그인 성공시 버튼의 활성화

            ListBox1.Items.Clear()
            '리스트 박스에 있는 QR코드의 아이템들을 새로고침

            Winhttp.Open("GET", "http://qr.naver.com/code/codeAdmin.nhn")
            Winhttp.Send()

            For i = 1 To UBound(Split(Winhttp.ResponseText, """qrName"": """))
                Temp = Split(Split(Winhttp.ResponseText, """qrName"": """)(i), """,""")(0)
                ListBox1.Items.Add(Temp)
            Next

        Else
            MsgBox("로그인 실패", vbCritical, "로그인 실패")
            pw.Text = ""
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Shell("explorer https://nid.naver.com/nidregister.form")

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Winhttp.Open("POST", "http://qr.naver.com/code/createCode.nhn")
        Winhttp.SetRequestHeader("Referer", "http://qr.naver.com/code/createForm.nhn")
        Winhttp.SetRequestHeader("Content-Type", "application/x-www-form-urlencoded; charset=utf-8")
        Winhttp.Send("qrNaverId=" & id.Text & "qrcdNo=&qrCodeUrl=&qrSaveStatusCd=79&qrColorBorderCd=" & Color.Text & "&qrDirectLinkTypeCd=29&qrDirectLink=http://" & url.Text & "&qrSearchWord=&qrAttachOrder=L%7CD%7CI%7CV%7CM%7CC&qrSubjectFontTypeCd=157&qrLogoImgUrl=&qrLandingSkinTypeCd=177&qrAttachImgViewTypeCd=164&qrBorderSkinTypeCd=237&qrUserBorderSkinUrl=&qrCenterImgUrl=&qrLocation=241&qrUserBorderSkinThumbnailUrl=&qrCenterImgThumbnailUrl=&qrVersion=30&qrCodePub=dea62bbf29c1f283264adc13ce7db885a24448f62b81605f1316dd84b91e9910eabbe4ece66cb9ce396967f35fc45f8748ce9dcefab6289b6cbd2fbbf6d29c1e791f0e346a0aacf76be3358f40ff436cf75237a2d421aa4432e20211716818a0b700dd19f543513a4a97ecd9ea1ef65f3&qrCodeExp=10001&qrName=" & qrname.Text & "&qrLogoTypeCd=24&qrSubject=&qrLocationTypeCd=241&qrAttachLinkList[0].linkSubject=&qrAttachLinkList[0].linkUrl=&qrAttachLinkList[1].linkSubject=&qrAttachLinkList[1].linkUrl=&qrAttachLinkList[2].linkSubject=&qrAttachLinkList[2].linkUrl=&qrAttachLinkList[3].linkSubject=&qrAttachLinkList[3].linkUrl=&qrAttachLinkList[4].linkSubject=&qrAttachLinkList[4].linkUrl=&qrDesc=")
        If qrname.Text.Length > 20 Then
            MsgBox("실패하였습니다. (글자수 최대 20)")
        Else

            ListBox1.Items.Clear()

            Winhttp.Open("GET", "http://qr.naver.com/code/codeAdmin.nhn")
            Winhttp.Send()

            For i = 1 To UBound(Split(Winhttp.ResponseText, """qrName"": """))
                Temp = Split(Split(Winhttp.ResponseText, """qrName"": """)(i), """,""")(0)
                ListBox1.Items.Add(Temp)
            Next
            MsgBox("생성 성공", vbInformation, "생성 성공")
        End If
    End Sub

    Private Sub Red_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Red.Click
        Color.Text = "10"
    End Sub

    Private Sub Blue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Blue.Click
        Color.Text = "18"
    End Sub

    Private Sub Yellow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Yellow.Click
        Color.Text = "13"
    End Sub

    Private Sub Pink_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pink.Click
        Color.Text = "105"
    End Sub

    Private Sub Green_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Green.Click
        Color.Text = "15"
    End Sub

    Private Sub Black_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Black.Click
        Color.Text = "106"
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ListBox1.Items.Clear()

        Winhttp.Open("GET", "http://qr.naver.com/code/codeAdmin.nhn")
        Winhttp.Send()

        For i = 1 To UBound(Split(Winhttp.ResponseText, """qrName"": """))
            Temp = Split(Split(Winhttp.ResponseText, """qrName"": """)(i), """,""")(0)
            ListBox1.Items.Add(Temp)
        Next

    End Sub
    Private Sub pw_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles pw.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
        End If
    End Sub
    Public Sub LoadImageFromUrl(ByRef url As String, ByVal pb As PictureBox)
        Dim request As Net.HttpWebRequest = DirectCast(Net.HttpWebRequest.Create(url), Net.HttpWebRequest)
        Dim response As Net.HttpWebResponse = DirectCast(request.GetResponse, Net.HttpWebResponse)
        Dim img As Image = Image.FromStream(response.GetResponseStream())
        response.Close()
        pb.SizeMode = PictureBoxSizeMode.StretchImage
        pb.Image = img
    End Sub
    Private Sub ListBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.Click
        Temp = ListBox1.SelectedIndex
        If Temp < 0 Then
        Else
            LoadImageFromUrl(Split(Split(Winhttp.ResponseText, """qrCodeImgUrl"": """)(Temp + 1), """,""")(0), PictureBox1)
            MaskedTextBox1.Text = (Split(Split(Winhttp.ResponseText, """qrcdNo"": """)(Temp + 1), """,""")(0))
        End If
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Winhttp.Open("POST", "http://qr.naver.com/code/deleteCodes.nhn")
        Winhttp.SetRequestHeader("Referer", "http://qr.naver.com/code/codeAdmin.nhn")
        Winhttp.SetRequestHeader("Content-Type", "application/x-www-form-urlencoded")
        Winhttp.Send("qrcdNo=&menu=myList&page=&search=&preSearch=&startDate=&endDate=&chkQrcdNo=" & MaskedTextBox1.Text & "&deleteValues=" & MaskedTextBox1.Text & "&retUrl=%2Fcode%2FcodeAdmin.nhn%3Fmenu%3DmyList")

        ListBox1.Items.Clear()
        Winhttp.Open("GET", "http://qr.naver.com/code/codeAdmin.nhn")
        Winhttp.Send()

        For i = 1 To UBound(Split(Winhttp.ResponseText, """qrName"": """))
            Temp = Split(Split(Winhttp.ResponseText, """qrName"": """)(i), """,""")(0)
            ListBox1.Items.Add(Temp)
        Next
        MsgBox("삭제 성공", vbInformation, "삭제 성공")
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class
'Split(Split(Winhttp.ResponseText, """qrCodeImgUrl"": """)(i), """,""")(0)
'LoadImageFromUrl(이미지주소, 픽쳐박스이름)
'LoadImageFromUrl(Split(Split(Winhttp.ResponseText, """qrCodeImgUrl"": """)(i+1), """,""")(0), PictureBox1)