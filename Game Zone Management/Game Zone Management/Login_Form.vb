Public Class Login_Form

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub btn_submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_submit.Click
        If txt_uid.Text = " " Or txt_pass.Text = " " Then
            MsgBox("Enter Username or Password!!")
        ElseIf txt_uid.Text = "Admin" And txt_pass.Text = "admin" Then
            Me.Hide()
            Dim obj = New Games
            obj.Show()
        End If
    End Sub

    Public Sub clear()
        txt_uid.Text = ""
        txt_pass.Text = ""

    End Sub

    Private Sub btn_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clear.Click
        clear()
    End Sub
End Class