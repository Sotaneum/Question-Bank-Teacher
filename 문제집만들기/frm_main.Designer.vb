<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_main
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
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_main))
        Me.tb_text = New System.Windows.Forms.TextBox()
        Me.tb_Num = New System.Windows.Forms.TextBox()
        Me.cb_AutoCount = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_result = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_seq = New System.Windows.Forms.TextBox()
        Me.tb_title = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.btn_setting_Save = New System.Windows.Forms.Button()
        Me.cb_image = New System.Windows.Forms.CheckBox()
        Me.btn_help = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_test = New System.Windows.Forms.Button()
        Me.cb_Item = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tb_text
        '
        Me.tb_text.Enabled = False
        Me.tb_text.Location = New System.Drawing.Point(12, 12)
        Me.tb_text.Multiline = True
        Me.tb_text.Name = "tb_text"
        Me.tb_text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tb_text.Size = New System.Drawing.Size(412, 397)
        Me.tb_text.TabIndex = 0
        '
        'tb_Num
        '
        Me.tb_Num.Enabled = False
        Me.tb_Num.Location = New System.Drawing.Point(498, 156)
        Me.tb_Num.Name = "tb_Num"
        Me.tb_Num.Size = New System.Drawing.Size(152, 21)
        Me.tb_Num.TabIndex = 1
        Me.tb_Num.Text = "1"
        '
        'cb_AutoCount
        '
        Me.cb_AutoCount.AutoSize = True
        Me.cb_AutoCount.Checked = True
        Me.cb_AutoCount.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_AutoCount.Enabled = False
        Me.cb_AutoCount.Location = New System.Drawing.Point(553, 140)
        Me.cb_AutoCount.Name = "cb_AutoCount"
        Me.cb_AutoCount.Size = New System.Drawing.Size(106, 16)
        Me.cb_AutoCount.TabIndex = 2
        Me.cb_AutoCount.Text = "자동카운트(+1)"
        Me.cb_AutoCount.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(436, 159)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "고유번호"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(436, 253)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "답"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tb_result
        '
        Me.tb_result.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tb_result.Enabled = False
        Me.tb_result.Location = New System.Drawing.Point(498, 250)
        Me.tb_result.Name = "tb_result"
        Me.tb_result.Size = New System.Drawing.Size(152, 21)
        Me.tb_result.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(436, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "식별형태"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tb_seq
        '
        Me.tb_seq.Location = New System.Drawing.Point(498, 48)
        Me.tb_seq.Name = "tb_seq"
        Me.tb_seq.Size = New System.Drawing.Size(152, 21)
        Me.tb_seq.TabIndex = 1
        Me.tb_seq.Text = "^"
        '
        'tb_title
        '
        Me.tb_title.Location = New System.Drawing.Point(498, 21)
        Me.tb_title.Name = "tb_title"
        Me.tb_title.Size = New System.Drawing.Size(152, 21)
        Me.tb_title.TabIndex = 1
        Me.tb_title.Text = "Exam_"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(436, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "문제집"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_Save
        '
        Me.btn_Save.Enabled = False
        Me.btn_Save.Location = New System.Drawing.Point(438, 288)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(212, 32)
        Me.btn_Save.TabIndex = 4
        Me.btn_Save.Text = "저장"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'btn_setting_Save
        '
        Me.btn_setting_Save.Location = New System.Drawing.Point(438, 102)
        Me.btn_setting_Save.Name = "btn_setting_Save"
        Me.btn_setting_Save.Size = New System.Drawing.Size(212, 32)
        Me.btn_setting_Save.TabIndex = 4
        Me.btn_setting_Save.Text = "저장"
        Me.btn_setting_Save.UseVisualStyleBackColor = True
        '
        'cb_image
        '
        Me.cb_image.AutoSize = True
        Me.cb_image.Enabled = False
        Me.cb_image.Location = New System.Drawing.Point(544, 226)
        Me.cb_image.Name = "cb_image"
        Me.cb_image.Size = New System.Drawing.Size(100, 16)
        Me.cb_image.TabIndex = 2
        Me.cb_image.Text = "이미지 활성화"
        Me.cb_image.UseVisualStyleBackColor = True
        '
        'btn_help
        '
        Me.btn_help.Location = New System.Drawing.Point(438, 377)
        Me.btn_help.Name = "btn_help"
        Me.btn_help.Size = New System.Drawing.Size(212, 32)
        Me.btn_help.TabIndex = 4
        Me.btn_help.Text = "도움말"
        Me.btn_help.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label5.Location = New System.Drawing.Point(0, 412)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(667, 37)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "ⓒ2018 이동건" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "cyydo96@naver.com , http://sotaneum.tistory.com"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_test
        '
        Me.btn_test.Location = New System.Drawing.Point(438, 190)
        Me.btn_test.Name = "btn_test"
        Me.btn_test.Size = New System.Drawing.Size(34, 37)
        Me.btn_test.TabIndex = 6
        Me.btn_test.Text = "test"
        Me.btn_test.UseVisualStyleBackColor = True
        '
        'cb_Item
        '
        Me.cb_Item.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Item.FormattingEnabled = True
        Me.cb_Item.Items.AddRange(New Object() {"A", "1"})
        Me.cb_Item.Location = New System.Drawing.Point(498, 75)
        Me.cb_Item.Name = "cb_Item"
        Me.cb_Item.Size = New System.Drawing.Size(97, 20)
        Me.cb_Item.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(436, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 18)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "문항형태"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 449)
        Me.Controls.Add(Me.cb_Item)
        Me.Controls.Add(Me.btn_test)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_setting_Save)
        Me.Controls.Add(Me.btn_help)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cb_image)
        Me.Controls.Add(Me.cb_AutoCount)
        Me.Controls.Add(Me.tb_result)
        Me.Controls.Add(Me.tb_title)
        Me.Controls.Add(Me.tb_seq)
        Me.Controls.Add(Me.tb_Num)
        Me.Controls.Add(Me.tb_text)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_main"
        Me.Text = "문제집 만들기"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tb_text As TextBox
    Friend WithEvents tb_Num As TextBox
    Friend WithEvents cb_AutoCount As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tb_result As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tb_seq As TextBox
    Friend WithEvents tb_title As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_Save As Button
    Friend WithEvents btn_setting_Save As Button
    Friend WithEvents cb_image As CheckBox
    Friend WithEvents btn_help As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_test As Button
    Friend WithEvents cb_Item As ComboBox
    Friend WithEvents Label6 As Label
End Class
