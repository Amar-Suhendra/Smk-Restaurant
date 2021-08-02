Public Class chef

    Private Sub chef_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Label2.Text = "Welcome, " & Login.uname
    End Sub

    Private Sub btn_vorder_Click(sender As System.Object, e As System.EventArgs) Handles btn_vorder.Click
        Vorder.Show()
        Me.Hide()
    End Sub

    Private Sub bnt_cpass_Click(sender As System.Object, e As System.EventArgs) Handles bnt_cpass.Click
        Form_Change_Password.Show()
        Me.Hide()

    End Sub

    Private Sub btn_logout_Click(sender As System.Object, e As System.EventArgs) Handles btn_logout.Click
        Login.Show()
        Me.Close()
        Conn.Close()
    End Sub
End Class