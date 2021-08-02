Imports System.Data.SqlClient
Public Class MMember
    Public Sub Data(search As String)
        Login.query = "Select memberid as ID, Name, Email, Handphone, Joindate from Msmember where 
        concat (memberid,name,email,handphone,joindate) like '%" & Trim(search) & "%'"
        Login.cmd = New SqlCommand(Login.query, Conn)
        Login.da = New SqlDataAdapter
        Login.dt = New DataTable
        Login.da.SelectCommand = Login.cmd
        Login.da.Fill(Login.dt)

        Dtg_member.DataSource = Login.dt
    End Sub

    Public Sub Awal()
        Tb_memberid.Text = ""
        Tb_name.Text = ""
        Tb_email.Text = ""
        Tb_hp.Text = ""
    End Sub

    Private Sub MMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Data("")
    End Sub

    Private Sub Btn_search_Click(sender As Object, e As EventArgs) Handles Btn_search.Click
        Data(Tb_search.Text)
    End Sub

    Private Sub Dtg_member_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dtg_member.CellDoubleClick
        Dim ambil As DataGridViewRow
        ambil = Dtg_member.Rows(e.RowIndex)
        Tb_memberid.Text = ambil.Cells(0).Value
        Tb_memberid.Enabled = False

        Login.query = "Select * from MsMember where memberid = '" & Trim(Tb_memberid.Text) & "';"
        Login.cmd = New SqlCommand(Login.query, Conn)
        Login.da = New SqlDataAdapter
        Login.dt = New DataTable
        Login.da.SelectCommand = Login.cmd
        Login.da.Fill(Login.dt)

        Tb_name.Text = Trim(Login.dt.Rows(0).Item("name"))
        Tb_email.Text = Trim(Login.dt.Rows(0).Item("email"))
        Tb_hp.Text = Trim(Login.dt.Rows(0).Item("handphone"))

    End Sub

    Private Sub Btn_cancel_Click(sender As Object, e As EventArgs) Handles Btn_cancel.Click
        Awal()
    End Sub

    Private Sub Btn_insert_Click(sender As Object, e As EventArgs) Handles Btn_insert.Click
        Dim todaysdate As String = String.Format("{0:yyyy-MM-dd}", DateTime.Now)
        If Tb_name.Text = "" Or Tb_email.Text = "" Or Tb_hp.Text = "" Then
            MsgBox("Isikan semua data")
        Else
            Conn.Open()
            Login.query = "insert into MsMember(Name,Email,Handphone,Joindate) values ('" & Trim(Tb_name.Text) & "','" & Trim(Tb_email.Text) & "',
            '" & Trim(Tb_hp.Text) & "','" & Trim(todaysdate) & "');"
            Login.cmd = New SqlCommand(Login.query, Conn)
            Login.cmd.ExecuteNonQuery()
            MsgBox("Data berhasil diinput")
            Data("")
            Awal()
            Conn.Close()
        End If
    End Sub

    Private Sub Btn_update_Click(sender As Object, e As EventArgs) Handles Btn_update.Click
        If Tb_name.Text = "" Or Tb_email.Text = "" Or Tb_hp.Text = "" Then
            MsgBox("Isikan semua data")
        Else
            Conn.Open()
            Login.query = "update Msmember set name = '" & Trim(Tb_name.Text) & "', email = '" & Trim(Tb_email.Text) & "', handphone = '" & Trim(Tb_hp.Text) & "' 
            where memberid = '" & Trim(Tb_memberid.Text) & "' ;"
            Login.cmd = New SqlCommand(Login.query, Conn)
            Login.cmd.ExecuteNonQuery()
            MsgBox("Data berhasil diupdate")
            Data("")
            Awal()
            Conn.Close()
        End If
    End Sub

    Private Sub Btn_delete_Click(sender As Object, e As EventArgs) Handles Btn_delete.Click
        If Tb_name.Text = "" Or Tb_email.Text = "" Or Tb_hp.Text = "" Then
            MsgBox("Select data terlebih dahulu")
        Else
            Conn.Open()
            Login.query = "delete from MsMember where memberid = '" & Trim(Tb_memberid.Text) & "' ;"
            Login.cmd = New SqlCommand(Login.query, Conn)
            Login.cmd.ExecuteNonQuery()
            MsgBox("Data anda berhasil dihapus")
            Data("")
            Awal()
            Conn.Close()
        End If
    End Sub
End Class