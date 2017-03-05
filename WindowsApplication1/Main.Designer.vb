<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.searchBox = New System.Windows.Forms.TextBox()
        Me.searchBtn = New System.Windows.Forms.Button()
        Me.LoginBtn = New System.Windows.Forms.LinkLabel()
        Me.accountLnk = New System.Windows.Forms.LinkLabel()
        Me.logoutLnk = New System.Windows.Forms.LinkLabel()
        Me.UsersLnk = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bookLnk = New System.Windows.Forms.LinkLabel()
        Me.addBookLnk = New System.Windows.Forms.LinkLabel()
        Me.dueLnk = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.whouseBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'searchBox
        '
        Me.searchBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchBox.Location = New System.Drawing.Point(78, 177)
        Me.searchBox.Name = "searchBox"
        Me.searchBox.Size = New System.Drawing.Size(277, 26)
        Me.searchBox.TabIndex = 0
        '
        'searchBtn
        '
        Me.searchBtn.Location = New System.Drawing.Point(372, 177)
        Me.searchBtn.Name = "searchBtn"
        Me.searchBtn.Size = New System.Drawing.Size(122, 26)
        Me.searchBtn.TabIndex = 1
        Me.searchBtn.Text = "Search"
        Me.searchBtn.UseVisualStyleBackColor = True
        '
        'LoginBtn
        '
        Me.LoginBtn.AutoSize = True
        Me.LoginBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginBtn.Location = New System.Drawing.Point(552, 9)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.Size = New System.Drawing.Size(41, 16)
        Me.LoginBtn.TabIndex = 3
        Me.LoginBtn.TabStop = True
        Me.LoginBtn.Text = "Login"
        '
        'accountLnk
        '
        Me.accountLnk.AutoSize = True
        Me.accountLnk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.accountLnk.Location = New System.Drawing.Point(469, 9)
        Me.accountLnk.Name = "accountLnk"
        Me.accountLnk.Size = New System.Drawing.Size(77, 16)
        Me.accountLnk.TabIndex = 6
        Me.accountLnk.TabStop = True
        Me.accountLnk.Text = "My Account"
        Me.accountLnk.Visible = False
        '
        'logoutLnk
        '
        Me.logoutLnk.AutoSize = True
        Me.logoutLnk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logoutLnk.Location = New System.Drawing.Point(552, 9)
        Me.logoutLnk.Name = "logoutLnk"
        Me.logoutLnk.Size = New System.Drawing.Size(49, 16)
        Me.logoutLnk.TabIndex = 7
        Me.logoutLnk.TabStop = True
        Me.logoutLnk.Text = "Logout"
        Me.logoutLnk.Visible = False
        '
        'UsersLnk
        '
        Me.UsersLnk.AutoSize = True
        Me.UsersLnk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsersLnk.Location = New System.Drawing.Point(419, 9)
        Me.UsersLnk.Name = "UsersLnk"
        Me.UsersLnk.Size = New System.Drawing.Size(44, 16)
        Me.UsersLnk.TabIndex = 8
        Me.UsersLnk.TabStop = True
        Me.UsersLnk.Text = "Users"
        Me.UsersLnk.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Home"
        '
        'bookLnk
        '
        Me.bookLnk.AutoSize = True
        Me.bookLnk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bookLnk.Location = New System.Drawing.Point(63, 9)
        Me.bookLnk.Name = "bookLnk"
        Me.bookLnk.Size = New System.Drawing.Size(47, 16)
        Me.bookLnk.TabIndex = 11
        Me.bookLnk.TabStop = True
        Me.bookLnk.Text = "Books"
        '
        'addBookLnk
        '
        Me.addBookLnk.AutoSize = True
        Me.addBookLnk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addBookLnk.Location = New System.Drawing.Point(345, 9)
        Me.addBookLnk.Name = "addBookLnk"
        Me.addBookLnk.Size = New System.Drawing.Size(68, 16)
        Me.addBookLnk.TabIndex = 12
        Me.addBookLnk.TabStop = True
        Me.addBookLnk.Text = "Add Book"
        Me.addBookLnk.Visible = False
        '
        'dueLnk
        '
        Me.dueLnk.AutoSize = True
        Me.dueLnk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dueLnk.Location = New System.Drawing.Point(274, 9)
        Me.dueLnk.Name = "dueLnk"
        Me.dueLnk.Size = New System.Drawing.Size(65, 16)
        Me.dueLnk.TabIndex = 13
        Me.dueLnk.TabStop = True
        Me.dueLnk.Text = "Over Due"
        Me.dueLnk.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(78, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Search for book with keyword:"
        '
        'whouseBtn
        '
        Me.whouseBtn.Location = New System.Drawing.Point(491, 263)
        Me.whouseBtn.Name = "whouseBtn"
        Me.whouseBtn.Size = New System.Drawing.Size(110, 63)
        Me.whouseBtn.TabIndex = 15
        Me.whouseBtn.Text = "Warehouse"
        Me.whouseBtn.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 329)
        Me.Controls.Add(Me.whouseBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dueLnk)
        Me.Controls.Add(Me.addBookLnk)
        Me.Controls.Add(Me.bookLnk)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.UsersLnk)
        Me.Controls.Add(Me.logoutLnk)
        Me.Controls.Add(Me.accountLnk)
        Me.Controls.Add(Me.LoginBtn)
        Me.Controls.Add(Me.searchBtn)
        Me.Controls.Add(Me.searchBox)
        Me.Name = "Main"
        Me.Text = "Library System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents searchBox As System.Windows.Forms.TextBox
    Friend WithEvents searchBtn As System.Windows.Forms.Button
    Friend WithEvents LoginBtn As System.Windows.Forms.LinkLabel
    Friend WithEvents accountLnk As System.Windows.Forms.LinkLabel
    Friend WithEvents logoutLnk As System.Windows.Forms.LinkLabel
    Friend WithEvents UsersLnk As System.Windows.Forms.LinkLabel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents bookLnk As System.Windows.Forms.LinkLabel
    Friend WithEvents addBookLnk As System.Windows.Forms.LinkLabel
    Friend WithEvents dueLnk As System.Windows.Forms.LinkLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents whouseBtn As System.Windows.Forms.Button
End Class
