<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tb_price = New System.Windows.Forms.TextBox()
        Me.tb_name = New System.Windows.Forms.TextBox()
        Me.tb_menuId = New System.Windows.Forms.TextBox()
        Me.tb_photo = New System.Windows.Forms.TextBox()
        Me.btn_del = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Dtg_menu = New System.Windows.Forms.DataGridView()
        Me.tb_search = New System.Windows.Forms.TextBox()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_carbo = New System.Windows.Forms.TextBox()
        Me.tb_protein = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pb_menu = New System.Windows.Forms.PictureBox()
        Me.btn_file = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        CType(Me.Dtg_menu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_menu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tb_price
        '
        Me.tb_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_price.Location = New System.Drawing.Point(137, 442)
        Me.tb_price.Name = "tb_price"
        Me.tb_price.Size = New System.Drawing.Size(174, 24)
        Me.tb_price.TabIndex = 33
        '
        'tb_name
        '
        Me.tb_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_name.Location = New System.Drawing.Point(137, 412)
        Me.tb_name.Name = "tb_name"
        Me.tb_name.Size = New System.Drawing.Size(174, 24)
        Me.tb_name.TabIndex = 32
        '
        'tb_menuId
        '
        Me.tb_menuId.Enabled = False
        Me.tb_menuId.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_menuId.Location = New System.Drawing.Point(137, 382)
        Me.tb_menuId.Name = "tb_menuId"
        Me.tb_menuId.Size = New System.Drawing.Size(174, 24)
        Me.tb_menuId.TabIndex = 31
        '
        'tb_photo
        '
        Me.tb_photo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_photo.Location = New System.Drawing.Point(137, 472)
        Me.tb_photo.Name = "tb_photo"
        Me.tb_photo.Size = New System.Drawing.Size(174, 24)
        Me.tb_photo.TabIndex = 30
        '
        'btn_del
        '
        Me.btn_del.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_del.Location = New System.Drawing.Point(725, 559)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(80, 29)
        Me.btn_del.TabIndex = 29
        Me.btn_del.Text = "Delete"
        Me.btn_del.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(609, 559)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(80, 29)
        Me.btn_update.TabIndex = 28
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_insert
        '
        Me.btn_insert.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insert.Location = New System.Drawing.Point(484, 559)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(80, 29)
        Me.btn_insert.TabIndex = 27
        Me.btn_insert.Text = "Insert"
        Me.btn_insert.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 510)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 18)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Carbo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 478)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 18)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Photo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 448)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 18)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 418)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 18)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 388)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 18)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "MenuId"
        '
        'Dtg_menu
        '
        Me.Dtg_menu.AllowUserToAddRows = False
        Me.Dtg_menu.AllowUserToDeleteRows = False
        Me.Dtg_menu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dtg_menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtg_menu.Location = New System.Drawing.Point(12, 75)
        Me.Dtg_menu.Name = "Dtg_menu"
        Me.Dtg_menu.ReadOnly = True
        Me.Dtg_menu.Size = New System.Drawing.Size(793, 294)
        Me.Dtg_menu.TabIndex = 20
        '
        'tb_search
        '
        Me.tb_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_search.Location = New System.Drawing.Point(545, 45)
        Me.tb_search.Name = "tb_search"
        Me.tb_search.Size = New System.Drawing.Size(174, 24)
        Me.tb_search.TabIndex = 19
        '
        'btn_search
        '
        Me.btn_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search.Location = New System.Drawing.Point(725, 40)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(80, 29)
        Me.btn_search.TabIndex = 18
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(292, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 25)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Form Manage Menu"
        '
        'tb_carbo
        '
        Me.tb_carbo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_carbo.Location = New System.Drawing.Point(137, 502)
        Me.tb_carbo.Name = "tb_carbo"
        Me.tb_carbo.Size = New System.Drawing.Size(174, 24)
        Me.tb_carbo.TabIndex = 34
        '
        'tb_protein
        '
        Me.tb_protein.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_protein.Location = New System.Drawing.Point(137, 532)
        Me.tb_protein.Name = "tb_protein"
        Me.tb_protein.Size = New System.Drawing.Size(174, 24)
        Me.tb_protein.TabIndex = 35
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 538)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 18)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Protein"
        '
        'pb_menu
        '
        Me.pb_menu.BackColor = System.Drawing.Color.Silver
        Me.pb_menu.Location = New System.Drawing.Point(589, 388)
        Me.pb_menu.Name = "pb_menu"
        Me.pb_menu.Size = New System.Drawing.Size(178, 126)
        Me.pb_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_menu.TabIndex = 37
        Me.pb_menu.TabStop = False
        '
        'btn_file
        '
        Me.btn_file.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_file.Location = New System.Drawing.Point(317, 470)
        Me.btn_file.Name = "btn_file"
        Me.btn_file.Size = New System.Drawing.Size(48, 29)
        Me.btn_file.TabIndex = 38
        Me.btn_file.Text = "..."
        Me.btn_file.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.Location = New System.Drawing.Point(362, 559)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(78, 29)
        Me.btn_cancel.TabIndex = 39
        Me.btn_cancel.Text = "Clear"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'MMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 600)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_file)
        Me.Controls.Add(Me.pb_menu)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tb_protein)
        Me.Controls.Add(Me.tb_carbo)
        Me.Controls.Add(Me.tb_price)
        Me.Controls.Add(Me.tb_name)
        Me.Controls.Add(Me.tb_menuId)
        Me.Controls.Add(Me.tb_photo)
        Me.Controls.Add(Me.btn_del)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Dtg_menu)
        Me.Controls.Add(Me.tb_search)
        Me.Controls.Add(Me.btn_search)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MMenu"
        Me.Text = "Form Manage Menu"
        CType(Me.Dtg_menu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_menu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tb_price As System.Windows.Forms.TextBox
    Friend WithEvents tb_name As System.Windows.Forms.TextBox
    Friend WithEvents tb_menuId As System.Windows.Forms.TextBox
    Friend WithEvents tb_photo As System.Windows.Forms.TextBox
    Friend WithEvents btn_del As System.Windows.Forms.Button
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents btn_insert As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Dtg_menu As System.Windows.Forms.DataGridView
    Friend WithEvents tb_search As System.Windows.Forms.TextBox
    Friend WithEvents btn_search As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tb_carbo As System.Windows.Forms.TextBox
    Friend WithEvents tb_protein As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents pb_menu As System.Windows.Forms.PictureBox
    Friend WithEvents btn_file As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As Button
End Class
