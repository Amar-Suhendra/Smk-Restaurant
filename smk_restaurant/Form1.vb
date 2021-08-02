Public Class Form1
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Conn.Open()
        If Conn.State = ConnectionState.Open Then
            MsgBox("berhasil")
            Conn.Close()
        Else
            MsgBox("gagal")
        End If
    End Sub
End Class
