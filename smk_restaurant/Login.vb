Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Public Class Login
    Public query, emid, hp, uname, email, password, position, hashpass As String
    Public da As SqlDataAdapter
    Public dt As DataTable
    Public cmd As SqlCommand

    Private Sub Login_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Function SHA512(ByVal Sourcetext As String)
        Dim a() As Byte = Encoding.UTF8.GetBytes(Sourcetext)
        Dim b As Byte()
        Dim c As New SHA512Managed
        b = c.ComputeHash(a)

        Dim d As String = Convert.ToBase64String(b)
        Return d
    End Function

    Private Sub btn_login_Click(sender As System.Object, e As System.EventArgs) Handles btn_login.Click
        If tb_email.Text = "" Or tb_pass.Text = "" Then
            MsgBox("Isikan semua data anda")
        Else
            Conn.Open()
            query = "Select * from MsEmployee where email ='" & Trim(tb_email.Text) & "'"
            cmd = New SqlCommand(query, Conn)
            da = New SqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)

            If dt.Rows.Count <= 0 Then
                MsgBox("Email atau password anda salah")
                Conn.Close()
                Exit Sub
            Else
                hashpass = SHA512(tb_pass.Text)
                emid = Trim(dt.Rows(0).Item("employeeid"))
                email = Trim(dt.Rows(0).Item("email"))
                uname = Trim(dt.Rows(0).Item("name"))
                password = Trim(dt.Rows(0).Item("password"))
                hp = Trim(dt.Rows(0).Item("handphone"))
                position = Trim(dt.Rows(0).Item("position"))

                If hashpass <> password Then
                    MsgBox("Email atau password anda salah")
                    Conn.Close()
                    Exit Sub
                Else
                    tb_email.Clear()
                    tb_pass.Clear()
                    If position = "admin" Then
                        admin.Show()
                        Me.Hide()
                    ElseIf position = "chef" Then
                        chef.Show()
                        Me.Hide()
                    ElseIf position = "cashier" Then
                        Cashier.Show()
                        Me.Hide()
                    End If
                End If
            End If
        End If
        Conn.Close()
    End Sub
End Class