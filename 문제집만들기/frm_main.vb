Public Class frm_main
    Function save_check()
        If (tb_text.Text = "") Then
            Return 0
        End If
        If (tb_title.Text = "") Then
            Return 0
        End If
        If (tb_seq.Text = "") Then
            Return 0
        End If
        If (tb_Num.Text = "") Then
            Return 0
        End If
        If (tb_result.Text = "") Then
            Return 0
        End If
        Return 1
    End Function
    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        If (save_check() = 1) Then
            If (ds_saveData(tb_text.Text, tb_Num.Text, tb_result.Text, cb_image.Checked) = 1) Then
                MsgBox("성공적으로 추가되었습니다.", vbOKOnly, "문제집!")
                tb_text.Text = ""
                If (cb_AutoCount.Checked = True) Then
                    tb_Num.Text = CInt(tb_Num.Text) + 1
                End If
                tb_result.Text = ""
                cb_image.Checked = False
            End If
        Else
            MsgBox("내용을 채워주세요.", vbOKOnly, "입력!")
        End If
    End Sub

    Private Sub btn_setting_Save_Click(sender As Object, e As EventArgs) Handles btn_setting_Save.Click
        If ds_setExam(tb_title.Text, tb_seq.Text) = 2 Then
            MsgBox("새롭게 만드는 문제집이여서 새로운 폴더를 만들었습니다.", vbOKOnly, "와우! 새로운 문제집!")
        Else
            MsgBox("저장이 되었어요.. 같은 문제집에 여러개의 식별형태가 있을 경우 문제집을 읽는 프로그램에 문제가 발생합니다. 실수로 변경했다면 아직 늦지 않았고 다시 저장하면 됩니다.", vbOKOnly, "와우! 문제집!")
        End If
        tb_text.Enabled = True
        tb_Num.Enabled = True
        tb_result.Enabled = True
        btn_Save.Enabled = True
        cb_AutoCount.Enabled = True
        cb_image.Enabled = True
        btn_setting_Save.Enabled = False
    End Sub

    Private Sub tb_title_TextChanged(sender As Object, e As EventArgs) Handles tb_title.TextChanged
        btn_setting_Save.Enabled = True
    End Sub

    Private Sub btn_help_Click(sender As Object, e As EventArgs) Handles btn_help.Click
        System.Diagnostics.Process.Start("http://sotaneum.tistory.com")
    End Sub
End Class
