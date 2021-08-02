<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cashier
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
        Me.btn_payment = New System.Windows.Forms.Button()
        Me.btn_cpass = New System.Windows.Forms.Button()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lb_welcome = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_payment
        '
        Me.btn_payment.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_payment.Location = New System.Drawing.Point(124, 160)
        Me.btn_payment.Name = "btn_payment"
        Me.btn_payment.Size = New System.Drawing.Size(147, 27)
        Me.btn_payment.TabIndex = 0
        Me.btn_payment.Text = "Payment"
        Me.btn_payment.UseVisualStyleBackColor = True
        '
        'btn_cpass
        '
        Me.btn_cpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cpass.Location = New System.Drawing.Point(124, 207)
        Me.btn_cpass.Name = "btn_cpass"
        Me.btn_cpass.Size = New System.Drawing.Size(147, 27)
        Me.btn_cpass.TabIndex = 1
        Me.btn_cpass.Text = "Change Password"
        Me.btn_cpass.UseVisualStyleBackColor = True
        '
        'btn_logout
        '
        Me.btn_logout.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logout.Location = New System.Drawing.Point(124, 259)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(147, 27)
        Me.btn_logout.TabIndex = 2
        Me.btn_logout.Text = "Logout"
        Me.btn_logout.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(101, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Cashier Navigation"
        '
        'lb_welcome
        '
        Me.lb_welcome.AutoSize = True
        Me.lb_welcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_welcome.Location = New System.Drawing.Point(12, 99)
        Me.lb_welcome.Name = "lb_welcome"
        Me.lb_welcome.Size = New System.Drawing.Size(135, 18)
        Me.lb_welcome.TabIndex = 4
        Me.lb_welcome.Text = "Welcome,  Cashier"
        '
        'Cashier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 330)
        Me.Controls.Add(Me.lb_welcome)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_logout)
        Me.Controls.Add(Me.btn_cpass)
        Me.Controls.Add(Me.btn_payment)
        Me.Name = "Cashier"
        Me.Text = "Cashier"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_payment As System.Windows.Forms.Button
    Friend WithEvents btn_cpass As System.Windows.Forms.Button
    Friend WithEvents btn_logout As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lb_welcome As System.Windows.Forms.Label
End Class
