<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Late
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
        Me.homeLnk = New System.Windows.Forms.LinkLabel()
        Me.addBookLnk = New System.Windows.Forms.LinkLabel()
        Me.bookLnk = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.UsersLnk = New System.Windows.Forms.LinkLabel()
        Me.logoutLnk = New System.Windows.Forms.LinkLabel()
        Me.accountLnk = New System.Windows.Forms.LinkLabel()
        Me.LoginBtn = New System.Windows.Forms.LinkLabel()
        Me.dueGrid = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.updateBtn = New System.Windows.Forms.Button()
        CType(Me.dueGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'homeLnk
        '
        Me.homeLnk.AutoSize = True
        Me.homeLnk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.homeLnk.Location = New System.Drawing.Point(12, 9)
        Me.homeLnk.Name = "homeLnk"
        Me.homeLnk.Size = New System.Drawing.Size(45, 16)
        Me.homeLnk.TabIndex = 21
        Me.homeLnk.TabStop = True
        Me.homeLnk.Text = "Home"
        '
        'addBookLnk
        '
        Me.addBookLnk.AutoSize = True
        Me.addBookLnk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addBookLnk.Location = New System.Drawing.Point(339, 9)
        Me.addBookLnk.Name = "addBookLnk"
        Me.addBookLnk.Size = New System.Drawing.Size(68, 16)
        Me.addBookLnk.TabIndex = 20
        Me.addBookLnk.TabStop = True
        Me.addBookLnk.Text = "Add Book"
        '
        'bookLnk
        '
        Me.bookLnk.AutoSize = True
        Me.bookLnk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bookLnk.Location = New System.Drawing.Point(63, 9)
        Me.bookLnk.Name = "bookLnk"
        Me.bookLnk.Size = New System.Drawing.Size(47, 16)
        Me.bookLnk.TabIndex = 19
        Me.bookLnk.TabStop = True
        Me.bookLnk.Text = "Books"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(268, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 16)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Over Due"
        '
        'UsersLnk
        '
        Me.UsersLnk.AutoSize = True
        Me.UsersLnk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsersLnk.Location = New System.Drawing.Point(413, 9)
        Me.UsersLnk.Name = "UsersLnk"
        Me.UsersLnk.Size = New System.Drawing.Size(44, 16)
        Me.UsersLnk.TabIndex = 17
        Me.UsersLnk.TabStop = True
        Me.UsersLnk.Text = "Users"
        '
        'logoutLnk
        '
        Me.logoutLnk.AutoSize = True
        Me.logoutLnk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logoutLnk.Location = New System.Drawing.Point(546, 9)
        Me.logoutLnk.Name = "logoutLnk"
        Me.logoutLnk.Size = New System.Drawing.Size(49, 16)
        Me.logoutLnk.TabIndex = 16
        Me.logoutLnk.TabStop = True
        Me.logoutLnk.Text = "Logout"
        '
        'accountLnk
        '
        Me.accountLnk.AutoSize = True
        Me.accountLnk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.accountLnk.Location = New System.Drawing.Point(463, 9)
        Me.accountLnk.Name = "accountLnk"
        Me.accountLnk.Size = New System.Drawing.Size(77, 16)
        Me.accountLnk.TabIndex = 15
        Me.accountLnk.TabStop = True
        Me.accountLnk.Text = "My Account"
        '
        'LoginBtn
        '
        Me.LoginBtn.AutoSize = True
        Me.LoginBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginBtn.Location = New System.Drawing.Point(546, 9)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.Size = New System.Drawing.Size(41, 16)
        Me.LoginBtn.TabIndex = 14
        Me.LoginBtn.TabStop = True
        Me.LoginBtn.Text = "Login"
        '
        'dueGrid
        '
        Me.dueGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dueGrid.Location = New System.Drawing.Point(12, 60)
        Me.dueGrid.Name = "dueGrid"
        Me.dueGrid.Size = New System.Drawing.Size(583, 253)
        Me.dueGrid.TabIndex = 22
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(463, 335)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 63)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Notify Selected User"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(299, 335)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(136, 63)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Notify All"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'updateBtn
        '
        Me.updateBtn.Location = New System.Drawing.Point(15, 335)
        Me.updateBtn.Name = "updateBtn"
        Me.updateBtn.Size = New System.Drawing.Size(140, 63)
        Me.updateBtn.TabIndex = 25
        Me.updateBtn.Text = "Update"
        Me.updateBtn.UseVisualStyleBackColor = True
        '
        'Late
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 426)
        Me.Controls.Add(Me.updateBtn)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dueGrid)
        Me.Controls.Add(Me.homeLnk)
        Me.Controls.Add(Me.addBookLnk)
        Me.Controls.Add(Me.bookLnk)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.UsersLnk)
        Me.Controls.Add(Me.logoutLnk)
        Me.Controls.Add(Me.accountLnk)
        Me.Controls.Add(Me.LoginBtn)
        Me.Name = "Late"
        Me.Text = "Late Dues"
        CType(Me.dueGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents homeLnk As System.Windows.Forms.LinkLabel
    Friend WithEvents addBookLnk As System.Windows.Forms.LinkLabel
    Friend WithEvents bookLnk As System.Windows.Forms.LinkLabel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents UsersLnk As System.Windows.Forms.LinkLabel
    Friend WithEvents logoutLnk As System.Windows.Forms.LinkLabel
    Friend WithEvents accountLnk As System.Windows.Forms.LinkLabel
    Friend WithEvents LoginBtn As System.Windows.Forms.LinkLabel
    Friend WithEvents dueGrid As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents updateBtn As System.Windows.Forms.Button
End Class
