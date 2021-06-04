Imports ClosedXML.Excel
Imports System.Text
Public Class Form1
#Region "画面ロード時"
    '画面ロード時イベント
    Private Sub Form1_LoadAsync(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
#End Region

#Region "書き込むボタン押下時"
    Private Async Sub Button1_ClickAsync(sender As Object, e As EventArgs) Handles btn_send.Click
        'マウスカーソルを待機状態にする
        Me.Cursor = Cursors.WaitCursor
        '入力チェック
        If CheckInput(txt_kansou.Text, txt_nippou.Text, txtTemp.Text) <> False Then
            'Excelへ書き込み
            If InputToExcel(txt_dtp.Value.ToString("yyyy/MM/dd"), txt_nippou.Text, txtTemp.Text) = False Then
                Exit Sub
            End If
        Else
            Exit Sub
        End If
        'マウスカーソルを元に戻す
        Me.Cursor = Cursors.Default
        If MessageBox.Show(txtTemp.Text & vbCrLf & "への書き込みが完了しました。" & vbCrLf &
                           "メールを送信しますか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = 1 Then
            'マウスカーソルを待機状態にする
            Me.Cursor = Cursors.WaitCursor
            'メール送信
            Await SendEmail(txt_kansou.Text)
        Else
            Exit Sub
        End If
    End Sub
#End Region

#Region "ファイル選択"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' ファイルダイアログを開く変数を作成しインスタンス化
        Dim FileDialog As New OpenFileDialog()
        ' 各パラメータを設定
        ' 最初に表示されるデフォルトのフォルダ名を設定
        FileDialog.InitialDirectory = "D:\WORK\IUCHI\日報出力"
        ' 最初に表示されるデフォルトのファイル名を設定
        FileDialog.FileName = "井内" & txt_dtp.Value.ToString("yyyyMM") & "教育訓練"
        ' 読込むファイルの種類を設定
        FileDialog.Filter = "エクセルファイル" & "|" & "*.xlsx"
        ' ファイルダイアログのタイトルを設定
        FileDialog.Title = "読込みたいファイルを選択してください。"
        ' ファイルダイアログを閉じる前に現在のフォルダを復元するかしないか
        FileDialog.RestoreDirectory = True
        ' ファイルダイアログを開く

        ' 読込みたいファイルを選択し、開く(OK)ボタンが押されたら
        Dim dttmStr As String = "井内" & txt_dtp.Value.ToString("yyyyMM") & "教育訓練"
        Dim fileNameStr As String = FileDialog.FileName
        If FileDialog.ShowDialog() = DialogResult.OK Then
            If dttmStr = fileNameStr Then
                'テキストボックスにファイルのパスを表示
                txtTemp.Text = FileDialog.FileName
            Else
                MessageBox.Show("正しいファイルを選択してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If

    End Sub
#End Region

#Region "入力チェック"
    Public Function CheckInput(ByVal kansou As String, ByVal nippou As String, ByVal filePath As String) As Boolean

        If filePath = "" Then
            MessageBox.Show("ファイルが選択されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf nippou = "" Then
            MessageBox.Show("やったこと・学んだことを入力してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf kansou = "" Then
            MessageBox.Show("感想を入力してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True

    End Function
#End Region

#Region "Excelへの書き込み処理"

    Public Function InputToExcel(ByVal dt As String, ByVal nippou As String, ByVal filePath As String) As Boolean

        Dim read_colNum As String 'A(日付列)
        Dim write_colNum As String 'C(書き込む列)
        Dim str As String
        Dim wb = New XLWorkbook(filePath)
        '2021/06/02 update start

        Dim ws As IXLWorksheet = wb.Worksheet("受講報告 " & txt_dtp.Value.ToString("MM") & "月")
        '2021/06/02 update end

        'A(日付)列を一行ずつ読み込む
        'カーソルを砂時計にする
        For i = 1 To 50
            read_colNum = "A" & ((i).ToString)
            str = ws.Cell(read_colNum).GetString()
            If str.Length > 10 Then
                str = str.Substring(0, 10)
            End If
            If str = dt Then
                '書き込み
                write_colNum = "C" & (i.ToString)
                ws.Cell(write_colNum).SetValue(nippou)
                wb.Save()
                Exit For
            End If

            'シートにその日付がない場合
            If i = 50 Then
                MessageBox.Show("正しい日付を選択してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        Next

        Return True

    End Function

#End Region

#Region "メール送信処理"
    Async Function SendEmail(ByVal kansou As String) As Task
#Region "メールアドレス、宛名"

        '送信者の名前
        Dim From_Name As String = "井内　隆之介"
        '送信者のメールアドレス
        Dim From_Address As String = "iuchi.r@sys-k.co.jp"

        Dim name As String = ""
        Dim address As String = "iuchi.r@sys-k.co.jp"

        Dim ccname As String = ""
        Dim ccaddress As String = "rrryyyuuu1214@gmail.com"

        '宛先の名前
        Dim To_Name As String = ""
        '宛先のメールアドレス1
        Dim To_Address As String = "kuramoto.a@sys-k.co.jp"


        'CC1名
        Dim Cc1_Name As String = ""
        'CC2名
        Dim Cc2_Name As String = ""
        'CC3名
        Dim Cc3_Name As String = ""
        'CC4名
        Dim Cc4_Name As String = ""
        'CC5名
        Dim Cc5_Name As String = ""
        'CC1メールアドレス
        Dim Cc1_address As String = "hirashima.m@sys-k.co.jp"
        'CC2メールアドレス
        Dim Cc2_address As String = "inoue.k@sys-k.co.jp"
        'CC3メールアドレス
        Dim Cc3_address As String = "inoue.t@sys-k.co.jp"
        'CC4メールアドレス
        Dim Cc4_address As String = "manabe.t@sys-k.co.jp"
        'CC5メールアドレス
        Dim Cc5_address As String = "taniguchi.k@sys-k.co.jp"


#End Region

        'メールタイトル
        Dim Subject As String = txt_dtp.Value.ToString("yyyy年MM月dd日　日報")

        'メール本文
        Dim BodyText As String = "●感想" & vbCrLf & kansou & vbCrLf &
            vbCrLf &
            "*********************************************" & vbCrLf &
             "株式会社　システム企画" & vbCrLf &
           "　井内　隆之介" & vbCrLf &
           "〒815-0033" & vbCrLf &
             "福岡市南区大橋1-20-19　朝日ビル大橋" & vbCrLf &
           "TEL：092-552-0858　FAX：092-554-1524" & vbCrLf &
           "E-MAIL：iuchi.r@sys-k.co.jp" & vbCrLf &
         "URL: https://www.sys-k.co.jp/" & vbCrLf &
            "*********************************************"
        'SMTP サーバー
        Dim SmtpServer As String = "cat-orange-e9aaba7152375f8d.znlc.jp"
        'ポート
        Dim Port As UInteger = 465
        'サーバー認証ユーザー名
        Dim Auth_Username As String = "iuchi.r@sys-k.co.jp"
        'サーバー認証パスワード
        Dim Auth_Password As String = "Sys210410"

        Dim oMsg = New MimeKit.MimeMessage

        '送信者
        oMsg.From.Add(New MimeKit.MailboxAddress(From_Name, From_Address))

        '宛先 = oMsg.To.Add ' CC = oMsg.Cc.Add  'BCC = oMsg.Bcc.Add
        oMsg.To.Add(New MimeKit.MailboxAddress(name, address))
        oMsg.To.Add(New MimeKit.MailboxAddress(ccname, ccaddress))
        'oMsg.To.Add(New MimeKit.MailboxAddress(To_Name, To_Address))
        'oMsg.Cc.Add(New MimeKit.MailboxAddress(Cc1_Name, Cc1_address))
        'oMsg.Cc.Add(New MimeKit.MailboxAddress(Cc2_Name, Cc2_address))
        'oMsg.Cc.Add(New MimeKit.MailboxAddress(Cc3_Name, Cc3_address))
        'oMsg.Cc.Add(New MimeKit.MailboxAddress(Cc4_Name, Cc4_address))
        'oMsg.Cc.Add(New MimeKit.MailboxAddress(Cc5_Name, Cc5_address))

        'タイトル
        oMsg.Subject = Subject

        '本文
        Dim oTextPart = New MimeKit.TextPart(MimeKit.Text.TextFormat.Text)
        oTextPart.Text = BodyText
        oMsg.Body = oTextPart

        'ファイル添付
        Dim path = txtTemp.Text
        Dim attachment = New MimeKit.MimePart("image", "jpeg") _
        With {
                .Content = New MimeKit.MimeContent(System.IO.File.OpenRead(path)),
                .ContentDisposition = New MimeKit.ContentDisposition(),
                .ContentTransferEncoding = MimeKit.ContentEncoding.Base64,
                .FileName = System.IO.Path.GetFileName(path)
        }

        Dim multipart = New MimeKit.Multipart("mixed")
        multipart.Add(oTextPart)
        multipart.Add(attachment)

        oMsg.Body = multipart

        '送信処理
        Using oClient = New MailKit.Net.Smtp.SmtpClient()
            Try
                Me.Cursor = Cursors.WaitCursor
                Await oClient.ConnectAsync(SmtpServer, Port) 　　　　　　　　 '接続
                Await oClient.AuthenticateAsync(Auth_Username, Auth_Password) '認証
                Await oClient.SendAsync(oMsg)                                 '送信
                Await oClient.DisconnectAsync(True)                           '切断
                'マウスカーソルを元に戻す
                Me.Cursor = Cursors.Default
                MessageBox.Show("メールの送信が完了しました。", "完了", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                'マウスカーソルを元に戻す
                Me.Cursor = Cursors.Default
                Throw New Exception(ex.Message & vbCrLf & vbCrLf & "メールの送信が失敗しました。")
                MessageBox.Show("メールの送信が失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Function
            End Try
        End Using

    End Function


#End Region

#Region "その他"

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    'ドラッグ＆ドロップ
    Private Sub txtTemp_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles txtTemp.DragEnter

        'ファイル形式の場合のみ、ドラッグを受け付けます。
        If e.Data.GetDataPresent(DataFormats.FileDrop) = True Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If

    End Sub

    Private Sub txtTemp_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles txtTemp.DragDrop

        'ドラッグされたファイル・フォルダのパスを格納します。
        Dim strFileName As String() = CType(e.Data.GetData(DataFormats.FileDrop, False), String())

        'ファイルの存在確認を行い、ある場合にのみ、
        'テキストボックスにパスを表示します。f
        '（この処理でフォルダを対象外にしています。）
        If System.IO.File.Exists(strFileName(0).ToString) = True Then
            Me.txtTemp.Text = strFileName(0).ToString
        End If

    End Sub

#End Region

End Class



