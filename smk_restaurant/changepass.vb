Imports System.Security.Cryptography
Imports System.Text
Imports System.Data.SqlClient
Public Class Form_Change_Password
    Dim newpass, oldpass As String
    Private Function SHA512(ByVal Sourcetext As String)
        Dim a() As Byte = Encoding.UTF8.GetBytes(Sourcetext)
        Dim b As Byte()
        Dim c As New SHA512Managed
        b = c.ComputeHash(a)

        Dim d As String = Convert.ToBase64String(b)
        Return d
    End Function

    Function ValidatePassword(ByVal pwd As String,
    Optional ByVal minLength As Integer = 8,
    Optional ByVal numUpper As Integer = 1,
    Optional ByVal numLower As Integer = 1,
    Optional ByVal numNumbers As Integer = 1)

        ' Replace [A-Z] with \p{Lu}, to allow for Unicode uppercase letters.
        Dim upper As New System.Text.RegularExpressions.Regex("[A-Z]")
        Dim lower As New System.Text.RegularExpressions.Regex("[a-z]")
        Dim number As New System.Text.RegularExpressions.Regex("[0-9]")

        ' Check the length.
        If Len(pwd) < minLength Then Return False
        ' Check for minimum number of occurrences.
        If upper.Matches(pwd).Count < numUpper Then Return False
        If lower.Matches(pwd).Count < numLower Then Return False
        If number.Matches(pwd).Count < numNumbers Then Return False

        ' Passed all checks.
        Return True
    End Function

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'oldpass = SHA512(tb_oldpass.Text)
        oldpass = tb_oldpass.Text
        If oldpass <> Login.password Then
            MsgBox("Password lama anda tidak sama")
        Else
            If tb_newpass.Text <> tb_confpass.Text Then
                MsgBox("New Password dan Confirm Password harus sama")
            Else
                If ValidatePassword(tb_newpass.Text) = False Then
                    MsgBox("New Password harus sepanjang 8 karakter dan mengandung huruf kapital, huruf kecil dan juga angka")
                Else
                    Conn.Open()
                    newpass = SHA512(tb_newpass.Text)
                    Login.query = "Update MsEmployee set Password='" & Trim(newpass) & "' where Employeeid = '" & Trim(Login.emid) & "'"
                    Login.cmd = New SqlCommand(Login.query, Conn)
                    Login.cmd.ExecuteNonQuery()
                    MsgBox("Password anda berhasil diubah")
                    Conn.Close()
                    If Login.position = "admin" Then
                        admin.Show()
                        Me.Close()
                    ElseIf Login.position = "cashier" Then
                        Cashier.Show()
                        Me.Close()
                    ElseIf Login.position = "chef" Then
                        chef.Show()
                        Me.Close()
                    End If
                End If
            End If
        End If

    End Sub
End Class