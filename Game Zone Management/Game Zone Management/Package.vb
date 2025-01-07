Public Class Package

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_gold.Click

    End Sub

    Private Sub lbl_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_next.Click
        Me.Hide()
        Dim obj = New Bill
        obj.Show()
    End Sub

    Private Sub btn_previous_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_previous.Click
        Me.Hide()
        Dim obj = New Registration
        obj.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_end.Click
        Application.Exit()
    End Sub

    Private Sub cmbx_package_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbx_package.SelectedIndexChanged

    End Sub
End Class