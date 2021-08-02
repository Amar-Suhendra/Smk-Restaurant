<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MMember
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
        Me.Tb_email = New System.Windows.Forms.TextBox()
        Me.Tb_name = New System.Windows.Forms.TextBox()
        Me.Tb_memberid = New System.Windows.Forms.TextBox()
        Me.Tb_hp = New System.Windows.Forms.TextBox()
        Me.Btn_delete = New System.Windows.Forms.Button()
        Me.Btn_update = New System.Windows.Forms.Button()
        Me.Btn_insert = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Dtg_member = New System.Windows.Forms.DataGridView()
        Me.Tb_search = New System.Windows.Forms.TextBox()
        Me.Btn_search = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_cancel = New System.Windows.Forms.Button()
        CType(Me.Dtg_member, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tb_email
        '
        Me.Tb_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_email.Location = New System.Drawing.Point(601, 449)
        Me.Tb_email.Name = "Tb_email"
        Me.Tb_email.Size = New System.Drawing.Size(204, 24)
        Me.Tb_email.TabIndex = 33
        '
        'Tb_name
        '
        Me.Tb_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_name.Location = New System.Drawing.Point(601, 419)
        Me.Tb_name.Name = "Tb_name"
        Me.Tb_name.Size = New System.Drawing.Size(204, 24)
        Me.Tb_name.TabIndex = 32
        '
        'Tb_memberid
        '
        Me.Tb_memberid.Enabled = False
        Me.Tb_memberid.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_memberid.Location = New System.Drawing.Point(601, 389)
        Me.Tb_memberid.Name = "Tb_memberid"
        Me.Tb_memberid.Size = New System.Drawing.Size(204, 24)
        Me.Tb_memberid.TabIndex = 31
        '
        'Tb_hp
        '
        Me.Tb_hp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_hp.Location = New System.Drawing.Point(601, 479)
        Me.Tb_hp.Name = "Tb_hp"
        Me.Tb_hp.Size = New System.Drawing.Size(204, 24)
        Me.Tb_hp.TabIndex = 30
        '
        'Btn_delete
        '
        Me.Btn_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_delete.Location = New System.Drawing.Point(486, 555)
        Me.Btn_delete.Name = "Btn_delete"
        Me.Btn_delete.Size = New System.Drawing.Size(80, 29)
        Me.Btn_delete.TabIndex = 29
        Me.Btn_delete.Text = "Delete"
        Me.Btn_delete.UseVisualStyleBackColor = True
        '
        'Btn_update
        '
        Me.Btn_update.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_update.Location = New System.Drawing.Point(370, 555)
        Me.Btn_update.Name = "Btn_update"
        Me.Btn_update.Size = New System.Drawing.Size(80, 29)
        Me.Btn_update.TabIndex = 28
        Me.Btn_update.Text = "Update"
        Me.Btn_update.UseVisualStyleBackColor = True
        '
        'Btn_insert
        '
        Me.Btn_insert.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_insert.Location = New System.Drawing.Point(245, 555)
        Me.Btn_insert.Name = "Btn_insert"
        Me.Btn_insert.Size = New System.Drawing.Size(80, 29)
        Me.Btn_insert.TabIndex = 27
        Me.Btn_insert.Text = "Insert"
        Me.Btn_insert.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(483, 485)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 18)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Handphone"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(483, 455)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 18)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(483, 425)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 18)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(483, 395)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 18)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "MemberId"
        '
        'Dtg_member
        '
        Me.Dtg_member.AllowUserToAddRows = False
        Me.Dtg_member.AllowUserToDeleteRows = False
        Me.Dtg_member.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dtg_member.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtg_member.Location = New System.Drawing.Point(12, 84)
        Me.Dtg_member.Name = "Dtg_member"
        Me.Dtg_member.ReadOnly = True
        Me.Dtg_member.Size = New System.Drawing.Size(793, 294)
        Me.Dtg_member.TabIndex = 20
        '
        'Tb_search
        '
        Me.Tb_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_search.Location = New System.Drawing.Point(12, 384)
        Me.Tb_search.Name = "Tb_search"
        Me.Tb_search.Size = New System.Drawing.Size(174, 24)
        Me.Tb_search.TabIndex = 19
        '
        'Btn_search
        '
        Me.Btn_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_search.Location = New System.Drawing.Point(192, 384)
        Me.Btn_search.Name = "Btn_search"
        Me.Btn_search.Size = New System.Drawing.Size(80, 29)
        Me.Btn_search.TabIndex = 18
        Me.Btn_search.Text = "Search"
        Me.Btn_search.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(303, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 25)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Form Manage Member"
        '
        'Btn_cancel
        '
        Me.Btn_cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_cancel.Location = New System.Drawing.Point(601, 555)
        Me.Btn_cancel.Name = "Btn_cancel"
        Me.Btn_cancel.Size = New System.Drawing.Size(80, 29)
        Me.Btn_cancel.TabIndex = 34
        Me.Btn_cancel.Text = "Cancel"
        Me.Btn_cancel.UseVisualStyleBackColor = True
        '
        'MMember
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 600)
        Me.Controls.Add(Me.Btn_cancel)
        Me.Controls.Add(Me.Tb_email)
        Me.Controls.Add(Me.Tb_name)
        Me.Controls.Add(Me.Tb_memberid)
        Me.Controls.Add(Me.Tb_hp)
        Me.Controls.Add(Me.Btn_delete)
        Me.Controls.Add(Me.Btn_update)
        Me.Controls.Add(Me.Btn_insert)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Dtg_member)
        Me.Controls.Add(Me.Tb_search)
        Me.Controls.Add(Me.Btn_search)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MMember"
        Me.Text = "Form Manage Member"
        CType(Me.Dtg_member, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Tb_email As System.Windows.Forms.TextBox
    Friend WithEvents Tb_name As System.Windows.Forms.TextBox
    Friend WithEvents Tb_memberid As System.Windows.Forms.TextBox
    Friend WithEvents Tb_hp As System.Windows.Forms.TextBox
    Friend WithEvents Btn_delete As System.Windows.Forms.Button
    Friend WithEvents Btn_update As System.Windows.Forms.Button
    Friend WithEvents Btn_insert As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Dtg_member As System.Windows.Forms.DataGridView
    Friend WithEvents Tb_search As System.Windows.Forms.TextBox
    Friend WithEvents Btn_search As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Btn_cancel As Button
End Class
