<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MEmployee
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
        Me.Btn_search = New System.Windows.Forms.Button()
        Me.Tb_search = New System.Windows.Forms.TextBox()
        Me.Dtg_emp = New System.Windows.Forms.DataGridView()
        Me.Cb_posi = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Btn_insert = New System.Windows.Forms.Button()
        Me.Btn_update = New System.Windows.Forms.Button()
        Me.Btn_del = New System.Windows.Forms.Button()
        Me.Tb_hp = New System.Windows.Forms.TextBox()
        Me.Tb_empid = New System.Windows.Forms.TextBox()
        Me.Tb_Name = New System.Windows.Forms.TextBox()
        Me.Tb_email = New System.Windows.Forms.TextBox()
        Me.btn_cancel = New System.Windows.Forms.Button()
        CType(Me.Dtg_emp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(292, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Form Manage Employee"
        '
        'Btn_search
        '
        Me.Btn_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_search.Location = New System.Drawing.Point(725, 33)
        Me.Btn_search.Name = "Btn_search"
        Me.Btn_search.Size = New System.Drawing.Size(80, 29)
        Me.Btn_search.TabIndex = 1
        Me.Btn_search.Text = "Search"
        Me.Btn_search.UseVisualStyleBackColor = True
        '
        'Tb_search
        '
        Me.Tb_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_search.Location = New System.Drawing.Point(545, 38)
        Me.Tb_search.Name = "Tb_search"
        Me.Tb_search.Size = New System.Drawing.Size(174, 24)
        Me.Tb_search.TabIndex = 2
        '
        'Dtg_emp
        '
        Me.Dtg_emp.AllowUserToAddRows = False
        Me.Dtg_emp.AllowUserToDeleteRows = False
        Me.Dtg_emp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dtg_emp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtg_emp.Location = New System.Drawing.Point(12, 68)
        Me.Dtg_emp.Name = "Dtg_emp"
        Me.Dtg_emp.ReadOnly = True
        Me.Dtg_emp.Size = New System.Drawing.Size(793, 294)
        Me.Dtg_emp.TabIndex = 3
        '
        'Cb_posi
        '
        Me.Cb_posi.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_posi.FormattingEnabled = True
        Me.Cb_posi.Items.AddRange(New Object() {"cashier", "admin", "chef"})
        Me.Cb_posi.Location = New System.Drawing.Point(321, 494)
        Me.Cb_posi.Name = "Cb_posi"
        Me.Cb_posi.Size = New System.Drawing.Size(195, 26)
        Me.Cb_posi.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(195, 380)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "EmployeeId"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(195, 410)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(195, 440)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Email"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(195, 470)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 18)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Handphone"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(195, 502)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 18)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Position"
        '
        'Btn_insert
        '
        Me.Btn_insert.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_insert.Location = New System.Drawing.Point(245, 548)
        Me.Btn_insert.Name = "Btn_insert"
        Me.Btn_insert.Size = New System.Drawing.Size(80, 29)
        Me.Btn_insert.TabIndex = 10
        Me.Btn_insert.Text = "Insert"
        Me.Btn_insert.UseVisualStyleBackColor = True
        '
        'Btn_update
        '
        Me.Btn_update.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_update.Location = New System.Drawing.Point(370, 548)
        Me.Btn_update.Name = "Btn_update"
        Me.Btn_update.Size = New System.Drawing.Size(80, 29)
        Me.Btn_update.TabIndex = 11
        Me.Btn_update.Text = "Update"
        Me.Btn_update.UseVisualStyleBackColor = True
        '
        'Btn_del
        '
        Me.Btn_del.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_del.Location = New System.Drawing.Point(487, 548)
        Me.Btn_del.Name = "Btn_del"
        Me.Btn_del.Size = New System.Drawing.Size(80, 29)
        Me.Btn_del.TabIndex = 12
        Me.Btn_del.Text = "Delete"
        Me.Btn_del.UseVisualStyleBackColor = True
        '
        'Tb_hp
        '
        Me.Tb_hp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_hp.Location = New System.Drawing.Point(321, 464)
        Me.Tb_hp.Name = "Tb_hp"
        Me.Tb_hp.Size = New System.Drawing.Size(195, 24)
        Me.Tb_hp.TabIndex = 13
        '
        'Tb_empid
        '
        Me.Tb_empid.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_empid.Location = New System.Drawing.Point(321, 374)
        Me.Tb_empid.Name = "Tb_empid"
        Me.Tb_empid.Size = New System.Drawing.Size(195, 24)
        Me.Tb_empid.TabIndex = 14
        '
        'Tb_Name
        '
        Me.Tb_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Name.Location = New System.Drawing.Point(321, 404)
        Me.Tb_Name.Name = "Tb_Name"
        Me.Tb_Name.Size = New System.Drawing.Size(195, 24)
        Me.Tb_Name.TabIndex = 15
        '
        'Tb_email
        '
        Me.Tb_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_email.Location = New System.Drawing.Point(321, 434)
        Me.Tb_email.Name = "Tb_email"
        Me.Tb_email.Size = New System.Drawing.Size(195, 24)
        Me.Tb_email.TabIndex = 16
        '
        'btn_cancel
        '
        Me.btn_cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.Location = New System.Drawing.Point(610, 548)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(78, 29)
        Me.btn_cancel.TabIndex = 17
        Me.btn_cancel.Text = "Clear"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'MEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 600)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.Tb_email)
        Me.Controls.Add(Me.Tb_Name)
        Me.Controls.Add(Me.Tb_empid)
        Me.Controls.Add(Me.Tb_hp)
        Me.Controls.Add(Me.Btn_del)
        Me.Controls.Add(Me.Btn_update)
        Me.Controls.Add(Me.Btn_insert)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Cb_posi)
        Me.Controls.Add(Me.Dtg_emp)
        Me.Controls.Add(Me.Tb_search)
        Me.Controls.Add(Me.Btn_search)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MEmployee"
        Me.Text = "Form Manage Employee"
        CType(Me.Dtg_emp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Btn_search As System.Windows.Forms.Button
    Friend WithEvents Tb_search As System.Windows.Forms.TextBox
    Friend WithEvents Dtg_emp As System.Windows.Forms.DataGridView
    Friend WithEvents Cb_posi As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Btn_insert As System.Windows.Forms.Button
    Friend WithEvents Btn_update As System.Windows.Forms.Button
    Friend WithEvents Btn_del As System.Windows.Forms.Button
    Friend WithEvents Tb_hp As System.Windows.Forms.TextBox
    Friend WithEvents Tb_empid As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Name As System.Windows.Forms.TextBox
    Friend WithEvents Tb_email As System.Windows.Forms.TextBox
    Friend WithEvents btn_cancel As Button
End Class
