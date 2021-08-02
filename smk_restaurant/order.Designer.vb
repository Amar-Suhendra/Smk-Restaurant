<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class order
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtg_menu = New System.Windows.Forms.DataGridView()
        Me.dtg_order = New System.Windows.Forms.DataGridView()
        Me.pb_menu = New System.Windows.Forms.PictureBox()
        Me.tb_menuName = New System.Windows.Forms.TextBox()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_menuQty = New System.Windows.Forms.TextBox()
        Me.btn_del = New System.Windows.Forms.Button()
        Me.bt_order = New System.Windows.Forms.Button()
        Me.lb_carbo = New System.Windows.Forms.Label()
        Me.lb_protein = New System.Windows.Forms.Label()
        Me.lb_total = New System.Windows.Forms.Label()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.menu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.carbo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.protein = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dtg_menu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtg_order, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_menu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(290, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Form Order"
        '
        'dtg_menu
        '
        Me.dtg_menu.AllowUserToAddRows = False
        Me.dtg_menu.AllowUserToDeleteRows = False
        Me.dtg_menu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtg_menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_menu.Location = New System.Drawing.Point(12, 56)
        Me.dtg_menu.Name = "dtg_menu"
        Me.dtg_menu.ReadOnly = True
        Me.dtg_menu.Size = New System.Drawing.Size(674, 182)
        Me.dtg_menu.TabIndex = 1
        '
        'dtg_order
        '
        Me.dtg_order.AllowUserToAddRows = False
        Me.dtg_order.AllowUserToDeleteRows = False
        Me.dtg_order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtg_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_order.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.menu, Me.qty, Me.carbo, Me.protein, Me.price, Me.total})
        Me.dtg_order.Location = New System.Drawing.Point(12, 396)
        Me.dtg_order.Name = "dtg_order"
        Me.dtg_order.ReadOnly = True
        Me.dtg_order.Size = New System.Drawing.Size(674, 185)
        Me.dtg_order.TabIndex = 2
        '
        'pb_menu
        '
        Me.pb_menu.BackColor = System.Drawing.Color.Silver
        Me.pb_menu.Location = New System.Drawing.Point(90, 256)
        Me.pb_menu.Name = "pb_menu"
        Me.pb_menu.Size = New System.Drawing.Size(147, 122)
        Me.pb_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_menu.TabIndex = 3
        Me.pb_menu.TabStop = False
        '
        'tb_menuName
        '
        Me.tb_menuName.Enabled = False
        Me.tb_menuName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_menuName.Location = New System.Drawing.Point(384, 256)
        Me.tb_menuName.Name = "tb_menuName"
        Me.tb_menuName.Size = New System.Drawing.Size(143, 24)
        Me.tb_menuName.TabIndex = 4
        '
        'btn_add
        '
        Me.btn_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Location = New System.Drawing.Point(319, 349)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(81, 29)
        Me.btn_add.TabIndex = 5
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(289, 262)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Menu Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(292, 292)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Qty"
        '
        'tb_menuQty
        '
        Me.tb_menuQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_menuQty.Location = New System.Drawing.Point(384, 286)
        Me.tb_menuQty.Name = "tb_menuQty"
        Me.tb_menuQty.Size = New System.Drawing.Size(143, 24)
        Me.tb_menuQty.TabIndex = 7
        '
        'btn_del
        '
        Me.btn_del.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_del.Location = New System.Drawing.Point(446, 349)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(81, 29)
        Me.btn_del.TabIndex = 9
        Me.btn_del.Text = "Delete"
        Me.btn_del.UseVisualStyleBackColor = True
        '
        'bt_order
        '
        Me.bt_order.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_order.Location = New System.Drawing.Point(305, 587)
        Me.bt_order.Name = "bt_order"
        Me.bt_order.Size = New System.Drawing.Size(81, 29)
        Me.bt_order.TabIndex = 10
        Me.bt_order.Text = "Order"
        Me.bt_order.UseVisualStyleBackColor = True
        '
        'lb_carbo
        '
        Me.lb_carbo.AutoSize = True
        Me.lb_carbo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_carbo.Location = New System.Drawing.Point(9, 584)
        Me.lb_carbo.Name = "lb_carbo"
        Me.lb_carbo.Size = New System.Drawing.Size(61, 18)
        Me.lb_carbo.TabIndex = 11
        Me.lb_carbo.Text = "Carbo : "
        '
        'lb_protein
        '
        Me.lb_protein.AutoSize = True
        Me.lb_protein.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_protein.Location = New System.Drawing.Point(137, 584)
        Me.lb_protein.Name = "lb_protein"
        Me.lb_protein.Size = New System.Drawing.Size(67, 18)
        Me.lb_protein.TabIndex = 12
        Me.lb_protein.Text = "Protein : "
        '
        'lb_total
        '
        Me.lb_total.AutoSize = True
        Me.lb_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_total.Location = New System.Drawing.Point(550, 584)
        Me.lb_total.Name = "lb_total"
        Me.lb_total.Size = New System.Drawing.Size(53, 18)
        Me.lb_total.TabIndex = 13
        Me.lb_total.Text = "Total : "
        '
        'Column1
        '
        Me.Column1.HeaderText = "menuid"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'menu
        '
        Me.menu.HeaderText = "Menu"
        Me.menu.Name = "menu"
        Me.menu.ReadOnly = True
        '
        'qty
        '
        Me.qty.HeaderText = "Qty"
        Me.qty.Name = "qty"
        Me.qty.ReadOnly = True
        '
        'carbo
        '
        Me.carbo.HeaderText = "Carbo"
        Me.carbo.Name = "carbo"
        Me.carbo.ReadOnly = True
        '
        'protein
        '
        Me.protein.HeaderText = "Protein"
        Me.protein.Name = "protein"
        Me.protein.ReadOnly = True
        '
        'price
        '
        Me.price.HeaderText = "Price"
        Me.price.Name = "price"
        Me.price.ReadOnly = True
        '
        'total
        '
        Me.total.HeaderText = "Total"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        '
        'order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 627)
        Me.Controls.Add(Me.lb_total)
        Me.Controls.Add(Me.lb_protein)
        Me.Controls.Add(Me.lb_carbo)
        Me.Controls.Add(Me.bt_order)
        Me.Controls.Add(Me.btn_del)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tb_menuQty)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.tb_menuName)
        Me.Controls.Add(Me.pb_menu)
        Me.Controls.Add(Me.dtg_order)
        Me.Controls.Add(Me.dtg_menu)
        Me.Controls.Add(Me.Label1)
        Me.Name = "order"
        Me.Text = "Form Order"
        CType(Me.dtg_menu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtg_order, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_menu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dtg_menu As DataGridView
    Friend WithEvents dtg_order As DataGridView
    Friend WithEvents pb_menu As PictureBox
    Friend WithEvents tb_menuName As TextBox
    Friend WithEvents btn_add As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tb_menuQty As TextBox
    Friend WithEvents btn_del As Button
    Friend WithEvents bt_order As Button
    Friend WithEvents lb_carbo As Label
    Friend WithEvents lb_protein As Label
    Friend WithEvents lb_total As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents menu As DataGridViewTextBoxColumn
    Friend WithEvents qty As DataGridViewTextBoxColumn
    Friend WithEvents carbo As DataGridViewTextBoxColumn
    Friend WithEvents protein As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
End Class
