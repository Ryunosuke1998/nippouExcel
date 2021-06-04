<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nippou = New System.Windows.Forms.TextBox()
        Me.btn_send = New System.Windows.Forms.Button()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.txt_kansou = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_dtp = New System.Windows.Forms.DateTimePicker()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.txtTemp = New System.Windows.Forms.TextBox()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(155, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(492, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "やったこと・学んだこと"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_nippou
        '
        Me.txt_nippou.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_nippou.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_nippou.Location = New System.Drawing.Point(155, 128)
        Me.txt_nippou.Multiline = True
        Me.txt_nippou.Name = "txt_nippou"
        Me.txt_nippou.Size = New System.Drawing.Size(492, 100)
        Me.txt_nippou.TabIndex = 1
        '
        'btn_send
        '
        Me.btn_send.Location = New System.Drawing.Point(338, 375)
        Me.btn_send.Name = "btn_send"
        Me.btn_send.Size = New System.Drawing.Size(127, 37)
        Me.btn_send.TabIndex = 10
        Me.btn_send.Text = "ファイルに書き込む"
        Me.btn_send.UseVisualStyleBackColor = True
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.BackColor = System.Drawing.SystemColors.Info
        Me.lbl_date.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_date.Location = New System.Drawing.Point(155, 18)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(52, 21)
        Me.lbl_date.TabIndex = 4
        Me.lbl_date.Text = "日付"
        '
        'txt_kansou
        '
        Me.txt_kansou.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_kansou.Location = New System.Drawing.Point(155, 253)
        Me.txt_kansou.Multiline = True
        Me.txt_kansou.Name = "txt_kansou"
        Me.txt_kansou.Size = New System.Drawing.Size(492, 100)
        Me.txt_kansou.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(155, 231)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(492, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "感想"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button1.Location = New System.Drawing.Point(155, 42)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 61)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "ファイルの選択"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_dtp
        '
        Me.txt_dtp.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_dtp.Location = New System.Drawing.Point(213, 18)
        Me.txt_dtp.Name = "txt_dtp"
        Me.txt_dtp.Size = New System.Drawing.Size(152, 22)
        Me.txt_dtp.TabIndex = 11
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.Color.IndianRed
        Me.btn_close.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_close.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_close.Location = New System.Drawing.Point(689, 399)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(99, 39)
        Me.btn_close.TabIndex = 12
        Me.btn_close.Text = "終了"
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'txtTemp
        '
        Me.txtTemp.AllowDrop = True
        Me.txtTemp.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtTemp.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.txtTemp.Location = New System.Drawing.Point(288, 42)
        Me.txtTemp.Multiline = True
        Me.txtTemp.Name = "txtTemp"
        Me.txtTemp.Size = New System.Drawing.Size(359, 61)
        Me.txtTemp.TabIndex = 14
        Me.txtTemp.Text = "もしくはここにファイルをドラッグ&ドロップ"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 450)
        Me.Controls.Add(Me.txtTemp)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.txt_dtp)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_kansou)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.btn_send)
        Me.Controls.Add(Me.txt_nippou)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_nippou As TextBox
    Friend WithEvents btn_send As Button
    Friend WithEvents lbl_date As Label
    Friend WithEvents txt_kansou As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents BindingSource2 As BindingSource
    Friend WithEvents Button1 As Button
    Friend WithEvents txt_dtp As DateTimePicker
    Friend WithEvents btn_close As Button
    Friend WithEvents txtTemp As TextBox
End Class
