Public Class admin

    Private Sub admin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Label2.Text = "Welcome, " & Login.uname
    End Sub

    Private Sub btn_logout_Click(sender As System.Object, e As System.EventArgs) Handles btn_logout.Click
        Me.Close()
        Login.Show()
        Conn.Close()
    End Sub

    Private Sub btn_cpass_Click(sender As System.Object, e As System.EventArgs) Handles btn_cpass.Click
        Form_Change_Password.Show()
    End Sub

    Private Sub btn_order_Click(sender As System.Object, e As System.EventArgs) Handles btn_order.Click
        order.Show()
    End Sub

    Private Sub btn_employee_Click(sender As System.Object, e As System.EventArgs) Handles btn_employee.Click
        MEmployee.Show()
    End Sub

    Private Sub btn_menu_Click(sender As System.Object, e As System.EventArgs) Handles btn_menu.Click
        MMenu.Show()
    End Sub

    Private Sub btn_member_Click(sender As System.Object, e As System.EventArgs) Handles btn_member.Click
        MMember.Show()
    End Sub
End Class