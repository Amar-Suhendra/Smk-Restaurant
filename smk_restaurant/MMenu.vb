Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging
Public Class MMenu
    Private Sub Data(search As String)

        Login.query = "Select menuid as ID,Name,Price,Carbo,Protein from MsMenu where 
        concat(menuid,name,price,carbo,protein) like '%" & Trim(search) & "%' ;"
        Login.cmd = New SqlCommand(Login.query, Conn)
        Login.da = New SqlDataAdapter
        Login.dt = New DataTable
        Login.da.SelectCommand = Login.cmd
        Login.da.Fill(Login.dt)

        Dtg_menu.DataSource = Login.dt

    End Sub
    Private Sub Awal()
        tb_menuId.Clear()
        tb_name.Clear()
        tb_price.Clear()
        tb_photo.Clear()
        tb_carbo.Clear()
        tb_protein.Clear()
        pb_menu.ImageLocation = ""
    End Sub
    Private Sub Btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        Data(tb_search.Text)
    End Sub
    Private Sub MMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Data("")
    End Sub
    Private Sub Dtg_menu_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dtg_menu.CellDoubleClick
        Dim ambil As DataGridViewRow
        ambil = Dtg_menu.Rows(e.RowIndex)
        tb_menuId.Text = ambil.Cells(0).Value

        Login.query = "Select * from MsMenu where menuid = '" & Trim(tb_menuId.Text) & "' ;"
        Login.cmd = New SqlCommand(Login.query, Conn)
        Login.da = New SqlDataAdapter
        Login.dt = New DataTable
        Login.da.SelectCommand = Login.cmd
        Login.da.Fill(Login.dt)

        tb_name.Text = Trim(Login.dt.Rows(0).Item("name"))
        tb_price.Text = Trim(Login.dt.Rows(0).Item("price"))
        tb_photo.Text = Trim(Login.dt.Rows(0).Item("photo"))
        tb_carbo.Text = Trim(Login.dt.Rows(0).Item("carbo"))
        tb_protein.Text = Trim(Login.dt.Rows(0).Item("protein"))
        pb_menu.ImageLocation = Trim(Login.dt.Rows(0).Item("photo"))
    End Sub
    Private Sub Btn_file_Click(sender As Object, e As EventArgs) Handles btn_file.Click
        Dim bukafile As New OpenFileDialog With {
            .Filter = "*.jpg,*.png,*.jpeg|",
            .Multiselect = False
            }
        bukafile.ShowDialog()
        tb_photo.Text = bukafile.FileName
        pb_menu.ImageLocation = tb_photo.Text

    End Sub
    Private Sub Btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Login.query = "insert into MsMenu(Name,Price,Photo,Carbo,Protein) values('" & Trim(tb_name.Text) & "','" & Trim(tb_price.Text) & "',
        '" & Trim(tb_photo.Text) & "','" & Trim(tb_carbo.Text) & "','" & Trim(tb_protein.Text) & "');"
        If tb_name.Text = "" Or tb_price.Text = "" Or tb_photo.Text = "" Or tb_carbo.Text = "" Or tb_protein.Text = "" Then
            MsgBox("mohon isi semua Data")
        Else
            Conn.Open()
            Login.cmd = New SqlCommand(Login.query, Conn)
            Login.cmd.ExecuteNonQuery()
            MsgBox("Data berhasil diinput")
            Data("")
            Awal()
            Conn.Close()
        End If
    End Sub
    Private Sub Btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If tb_menuId.Text = "" Then
            MsgBox("Select Data terlebih dahulu")
        Else
            Conn.Open()
            Login.query = "update MsMenu set Name = '" & Trim(tb_name.Text) & "', Price = '" & Trim(tb_price.Text) & "',
            Photo = '" & Trim(tb_photo.Text) & "', Carbo = '" & Trim(tb_carbo.Text) & "', Protein = '" & Trim(tb_protein.Text) & "' 
            where Menuid = '" & Trim(tb_menuId.Text) & "'"
            Login.cmd = New SqlCommand(Login.query, Conn)
            Login.cmd.ExecuteNonQuery()
            MsgBox("Menu berhasil di perbaharui")
            Data("")
            Awal()
            Conn.Close()
        End If
    End Sub

    Private Sub Btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        If tb_menuId.Text = "" Then
            MsgBox("Select Data terlebih dahulu")
        Else
            Conn.Open()
            Login.query = "delete from MsMenu where Menuid = '" & Trim(tb_menuId.Text) & "';"
            Login.cmd = New SqlCommand(Login.query, Conn)
            Login.cmd.ExecuteNonQuery()
            MsgBox("Data berhasil dihapus")
            Data("")
            Awal()
            Conn.Close()
        End If

    End Sub
    Private Sub Btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Awal()
    End Sub
End Class