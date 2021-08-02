Public Class Cashier


    Private Sub Cashier_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lb_welcome.Text = "Welcome, " & Login.uname
    End Sub

    Private Sub btn_logout_Click(sender As System.Object, e As System.EventArgs) Handles btn_logout.Click
        Me.Close()
        Login.Show()
        Conn.Close()
    End Sub

    Private Sub btn_cpass_Click(sender As System.Object, e As System.EventArgs) Handles btn_cpass.Click
        Form_Change_Password.Show()
        Me.Hide()
    End Sub

    Private Sub btn_payment_Click(sender As System.Object, e As System.EventArgs) Handles btn_payment.Click
        payment.Show()
        Me.Hide()
    End Sub

End Class