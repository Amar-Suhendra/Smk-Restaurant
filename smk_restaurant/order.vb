Imports System.Data.SqlClient
Public Class order
    Dim harga, karbo, pro, t_pro, ttl, t_carbo, tgl, thn, bln, bil, hitung As Integer
    Dim id As String
    Dim ambil As DataGridViewRow
    Dim Rand As New Random
    Private Sub Data()

        Login.query = "Select Name,Price,Carbo,Protein from MsMenu;"
        Login.cmd = New SqlCommand(Login.query, Conn)
        Login.da = New SqlDataAdapter
        Login.dt = New DataTable
        Login.da.SelectCommand = Login.cmd
        Login.da.Fill(Login.dt)

        dtg_menu.DataSource = Login.dt

    End Sub
    Private Sub Awal()
        btn_del.Enabled = False
        tb_menuName.Text = ""
        tb_menuQty.Text = ""
        pb_menu.ImageLocation = ""
    End Sub

    Private Sub Order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Data()
        Awal()
    End Sub
    Private Sub dtg_order_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtg_order.CellDoubleClick
        ambil = dtg_order.Rows(e.RowIndex)
        tb_menuName.Text = ambil.Cells(1).Value
        tb_menuQty.Text = ambil.Cells(2).Value
        btn_del.Enabled = True
        Login.query = "Select * from MsMenu where name = '" & Trim(tb_menuName.Text) & "' ;"
        Login.cmd = New SqlCommand(Login.query, Conn)
        Login.da = New SqlDataAdapter
        Login.dt = New DataTable
        Login.da.SelectCommand = Login.cmd
        Login.da.Fill(Login.dt)

        tb_menuName.Text = Trim(Login.dt.Rows(0).Item("name"))
        pb_menu.ImageLocation = Trim(Login.dt.Rows(0).Item("photo"))
    End Sub
    Private Sub dtg_menu_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtg_menu.CellDoubleClick
        ambil = dtg_menu.Rows(e.RowIndex)
        tb_menuName.Text = ambil.Cells(0).Value

        Login.query = "Select * from MsMenu where name = '" & Trim(tb_menuName.Text) & "' ;"
        Login.cmd = New SqlCommand(Login.query, Conn)
        Login.da = New SqlDataAdapter
        Login.dt = New DataTable
        Login.da.SelectCommand = Login.cmd
        Login.da.Fill(Login.dt)

        tb_menuName.Text = Trim(Login.dt.Rows(0).Item("name"))
        pb_menu.ImageLocation = Trim(Login.dt.Rows(0).Item("photo"))

    End Sub
    Private Sub Btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If tb_menuName.Text = "" Or tb_menuQty.Text = "" Then
            MsgBox("Silahkan pilih menu terlebih dahulu")
        Else
            ttl = Trim(Login.dt.Rows(0).Item("price")) * tb_menuQty.Text
            dtg_order.Rows.Add(Trim(Login.dt.Rows(0).Item("menuid")), tb_menuName.Text, tb_menuQty.Text, Trim(Login.dt.Rows(0).Item("carbo")), Trim(Login.dt.Rows(0).Item("protein")),
            Trim(Login.dt.Rows(0).Item("price")), ttl)
            karbo = Trim(Login.dt.Rows(0).Item("carbo")) * tb_menuQty.Text
            pro = Trim(Login.dt.Rows(0).Item("protein")) * tb_menuQty.Text
        End If
        t_carbo += karbo
        lb_carbo.Text = "Carbo : " & t_carbo

        t_pro += pro
        lb_protein.Text = "Protein : " & t_pro

        harga += ttl
        lb_total.Text = "Total : " & harga
        Awal()
    End Sub
    Private Sub Btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        Dim index As Integer
        If tb_menuName.Text = "" Or tb_menuQty.Text = "" Then
            MsgBox("Silahkan pilih menu terlebih dahulu")
        Else
            index = dtg_order.CurrentCell.RowIndex
            dtg_order.Rows.RemoveAt(index)
            t_carbo -= ambil.Cells(3).Value * tb_menuQty.Text
            t_pro -= ambil.Cells(4).Value * tb_menuQty.Text
            harga -= ambil.Cells(5).Value * tb_menuQty.Text
        End If

        lb_carbo.Text = "Carbo : " & t_carbo
        lb_protein.Text = "Protein : " & t_pro
        lb_total.Text = "Total : " & harga
        Awal()
    End Sub
    Private Sub Bt_order_Click(sender As Object, e As EventArgs) Handles bt_order.Click
        thn = DateTime.Now.ToString("yyyy")
        bln = DateTime.Now.ToString("mm")
        tgl = DateTime.Now.ToString("dd")
        bil = Rand.Next(1000, 9999).ToString
        id = thn & bln & tgl & bil

        If dtg_order.Rows.Count = 0 Then
            MsgBox("Silakan tambahkan menu")
        Else
            Conn.Open()
            hitung = dtg_order.Rows.Count - 1
            For i As Integer = 0 To hitung
                Login.query = "insert into OrderDetail(Orderid,Menuid,Qty,status) values 
                ('" & id & "','" & dtg_order.Rows(i).Cells(0).Value & "','" & dtg_order.Rows(i).Cells(2).Value & "','Preparing');"
                MsgBox(Login.query)
                Login.cmd = New SqlCommand(Login.query, Conn)
                Login.cmd.ExecuteNonQuery()
            Next
            MsgBox("Data berhasil diinput")
            Awal()
            Conn.Close()
        End If

    End Sub

End Class