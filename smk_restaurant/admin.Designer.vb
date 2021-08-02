<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin
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
        Me.btn_order = New System.Windows.Forms.Button()
        Me.btn_employee = New System.Windows.Forms.Button()
        Me.btn_menu = New System.Windows.Forms.Button()
        Me.btn_member = New System.Windows.Forms.Button()
        Me.btn_cpass = New System.Windows.Forms.Button()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_order
        '
        Me.btn_order.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_order.Location = New System.Drawing.Point(133, 117)
        Me.btn_order.Name = "btn_order"
        Me.btn_order.Size = New System.Drawing.Size(162, 30)
        Me.btn_order.TabIndex = 0
        Me.btn_order.Text = "Order"
        Me.btn_order.UseVisualStyleBackColor = True
        '
        'btn_employee
        '
        Me.btn_employee.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_employee.Location = New System.Drawing.Point(133, 153)
        Me.btn_employee.Name = "btn_employee"
        Me.btn_employee.Size = New System.Drawing.Size(162, 28)
        Me.btn_employee.TabIndex = 1
        Me.btn_employee.Text = "Manage Employee"
        Me.btn_employee.UseVisualStyleBackColor = True
        '
        'btn_menu
        '
        Me.btn_menu.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_menu.Location = New System.Drawing.Point(133, 187)
        Me.btn_menu.Name = "btn_menu"
        Me.btn_menu.Size = New System.Drawing.Size(162, 32)
        Me.btn_menu.TabIndex = 2
        Me.btn_menu.Text = "Manage Menu"
        Me.btn_menu.UseVisualStyleBackColor = True
        '
        'btn_member
        '
        Me.btn_member.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_member.Location = New System.Drawing.Point(133, 225)
        Me.btn_member.Name = "btn_member"
        Me.btn_member.Size = New System.Drawing.Size(162, 28)
        Me.btn_member.TabIndex = 3
        Me.btn_member.Text = "Manage Member"
        Me.btn_member.UseVisualStyleBackColor = True
        '
        'btn_cpass
        '
        Me.btn_cpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cpass.Location = New System.Drawing.Point(133, 259)
        Me.btn_cpass.Name = "btn_cpass"
        Me.btn_cpass.Size = New System.Drawing.Size(162, 32)
        Me.btn_cpass.TabIndex = 4
        Me.btn_cpass.Text = "Change Password"
        Me.btn_cpass.UseVisualStyleBackColor = True
        '
        'btn_logout
        '
        Me.btn_logout.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logout.Location = New System.Drawing.Point(133, 297)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(162, 30)
        Me.btn_logout.TabIndex = 5
        Me.btn_logout.Text = "Logout"
        Me.btn_logout.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(128, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Admin Navigation"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Welcome, admin"
        '
        'admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 351)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_logout)
        Me.Controls.Add(Me.btn_cpass)
        Me.Controls.Add(Me.btn_member)
        Me.Controls.Add(Me.btn_menu)
        Me.Controls.Add(Me.btn_employee)
        Me.Controls.Add(Me.btn_order)
        Me.Name = "admin"
        Me.Text = "Form Admin Navigation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_order As System.Windows.Forms.Button
    Friend WithEvents btn_employee As System.Windows.Forms.Button
    Friend WithEvents btn_menu As System.Windows.Forms.Button
    Friend WithEvents btn_member As System.Windows.Forms.Button
    Friend WithEvents btn_cpass As System.Windows.Forms.Button
    Friend WithEvents btn_logout As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
