Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Public Class MEmployee
    Dim Pass As String
    Private Sub Data(search As String)
        Login.query = "select employeeid as ID, Name, Email, Handphone, Position from MsEmployee where 
        concat(employeeid, Name, Email, Handphone, Position) like '%" & Trim(search) & "%'"
        Login.cmd = New SqlCommand(Login.query, Conn)
        Login.da = New SqlDataAdapter
        Login.dt = New DataTable
        Login.da.SelectCommand = Login.cmd
        Login.da.Fill(Login.dt)

        Dtg_emp.DataSource = Login.dt

    End Sub

    Private Sub Awal()
        Tb_empid.Enabled = True
        Tb_empid.Text = ""
        Tb_email.Text = ""
        Tb_Name.Text = ""
        Tb_hp.Text = ""
        Cb_posi.Text = ""

    End Sub
    Private Function SHA512(ByVal Sourcetext As String)
        Dim a() As Byte = Encoding.UTF8.GetBytes(Sourcetext)
        Dim b As Byte()
        Dim c As New SHA512Managed
        b = c.ComputeHash(a)

        Dim d As String = Convert.ToBase64String(b)
        Return d
    End Function

    Private Sub MEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Data("")
    End Sub

    Private Sub Btn_search_Click(sender As Object, e As EventArgs) Handles Btn_search.Click
        Data(Tb_search.Text)
    End Sub

    Private Sub Dtg_emp_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dtg_emp.CellDoubleClick
        Dim ambil As DataGridViewRow
        ambil = Dtg_emp.Rows(e.RowIndex)
        Tb_empid.Text = ambil.Cells(0).Value
        Tb_empid.Enabled = False

        Login.query = "Select * from MsEmployee where employeeid = '" & Trim(Tb_empid.Text) & "';"
        Login.cmd = New SqlCommand(Login.query, Conn)
        Login.da = New SqlDataAdapter
        Login.dt = New DataTable
        Login.da.SelectCommand = Login.cmd
        Login.da.Fill(Login.dt)

        Tb_Name.Text = Trim(Login.dt.Rows(0).Item("name"))
        Tb_email.Text = Trim(Login.dt.Rows(0).Item("email"))
        Tb_hp.Text = Trim(Login.dt.Rows(0).Item("handphone"))
        Cb_posi.Text = Trim(Login.dt.Rows(0).Item("position"))
    End Sub

    Private Sub Btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Awal()
    End Sub

    Private Sub Btn_insert_Click(sender As Object, e As EventArgs) Handles Btn_insert.Click
        If Tb_empid.Text = "" Or Tb_Name.Text = "" Or Tb_email.Text = "" Or Tb_hp.Text = "" Or Cb_posi.Text = "" Then
            MsgBox("Isikan semua data")
        Else
            Pass = SHA512("Default123")
            Conn.Open()
            Login.query = "Insert into MsEmployee(employeeid,name,email,password,handphone,position) values ('" & Trim(Tb_empid.Text) & "',
            '" & Trim(Tb_Name.Text) & "','" & Trim(Tb_email.Text) & "','" & Trim(Pass) & "','" & Trim(Tb_hp.Text) & "','" & Trim(Cb_posi.Text) & "')"
            Login.cmd = New SqlCommand(Login.query, Conn)
            Login.cmd.ExecuteNonQuery()
            MsgBox("Data berhasil diinput")
            Data("")
            Awal()
            Conn.Close()
        End If
    End Sub

    Private Sub Btn_update_Click(sender As Object, e As EventArgs) Handles Btn_update.Click
        If Tb_empid.Text = "" Or Tb_Name.Text = "" Or Tb_email.Text = "" Or Tb_hp.Text = "" Or Cb_posi.Text = "" Then
            MsgBox("Select data terlebih dahulu")
        Else
            Conn.Open()
            Login.query = "Update MsEmployee set name = '" & Trim(Tb_Name.Text) & "', email = '" & Trim(Tb_email.Text) & "', handphone = '" & Trim(Tb_hp.Text) & "', 
            position = '" & Trim(Cb_posi.Text) & "' where employeeid = '" & Trim(Tb_empid.Text) & "' ;"
            Login.cmd = New SqlCommand(Login.query, Conn)
            Login.cmd.ExecuteNonQuery()
            MsgBox("Data anda berhasil diperbaharui")
            Data("")
            Awal()
            Conn.Close()
        End If
    End Sub

    Private Sub Btn_del_Click(sender As Object, e As EventArgs) Handles Btn_del.Click
        If Tb_empid.Text = "" Or Tb_Name.Text = "" Or Tb_email.Text = "" Or Tb_hp.Text = "" Or Cb_posi.Text = "" Then
            MsgBox("Select data terlebih dahulu")
        Else
            Conn.Open()
            Login.query = "delete from MsEmployee where employeeid = '" & Trim(Tb_empid.Text) & "' ;"
            Login.cmd = New SqlCommand(Login.query, Conn)
            Login.cmd.ExecuteNonQuery()
            MsgBox("Data anda berhasil dihapus")
            Data("")
            Awal()
            Conn.Close()
        End If
    End Sub
End Class