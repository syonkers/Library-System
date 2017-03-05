<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class myAccount
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.fnameBox = New System.Windows.Forms.TextBox()
        Me.numBox = New System.Windows.Forms.TextBox()
        Me.majorBox = New System.Windows.Forms.TextBox()
        Me.degreeBox = New System.Windows.Forms.TextBox()
        Me.phoneBox = New System.Windows.Forms.TextBox()
        Me.zipBox = New System.Windows.Forms.TextBox()
        Me.provinceBox = New System.Windows.Forms.TextBox()
        Me.cityBox = New System.Windows.Forms.TextBox()
        Me.addressBox = New System.Windows.Forms.TextBox()
        Me.lnameBox = New System.Windows.Forms.TextBox()
        Me.roleBox = New System.Windows.Forms.TextBox()
        Me.homeLnk = New System.Windows.Forms.LinkLabel()
        Me.logoutLnk = New System.Windows.Forms.LinkLabel()
        Me.UsersLnk = New System.Windows.Forms.LinkLabel()
        Me.addBookLnk = New System.Windows.Forms.LinkLabel()
        Me.dueLnk = New System.Windows.Forms.LinkLabel()
        Me.bookLnk = New System.Windows.Forms.LinkLabel()
        Me.accountLnk = New System.Windows.Forms.LinkLabel()
        Me.returnBtn = New System.Windows.Forms.Button()
        Me.borrowGrid = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.emailBox = New System.Windows.Forms.TextBox()
        Me.historyGrid = New System.Windows.Forms.DataGridView()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        CType(Me.borrowGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.historyGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 287)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "*First Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 313)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "*Last Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 391)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "*Province:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 339)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "*Address:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(67, 365)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "*City:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(300, 291)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "*Postal/Zip Code:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(333, 313)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Phone No."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(346, 339)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Degree:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(355, 365)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Major:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(341, 391)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "# Books:"
        '
        'fnameBox
        '
        Me.fnameBox.Enabled = False
        Me.fnameBox.Location = New System.Drawing.Point(104, 284)
        Me.fnameBox.Name = "fnameBox"
        Me.fnameBox.ReadOnly = True
        Me.fnameBox.Size = New System.Drawing.Size(165, 20)
        Me.fnameBox.TabIndex = 10
        '
        'numBox
        '
        Me.numBox.Enabled = False
        Me.numBox.Location = New System.Drawing.Point(397, 388)
        Me.numBox.Name = "numBox"
        Me.numBox.ReadOnly = True
        Me.numBox.Size = New System.Drawing.Size(165, 20)
        Me.numBox.TabIndex = 11
        '
        'majorBox
        '
        Me.majorBox.Enabled = False
        Me.majorBox.Location = New System.Drawing.Point(397, 362)
        Me.majorBox.Name = "majorBox"
        Me.majorBox.ReadOnly = True
        Me.majorBox.Size = New System.Drawing.Size(165, 20)
        Me.majorBox.TabIndex = 12
        '
        'degreeBox
        '
        Me.degreeBox.Enabled = False
        Me.degreeBox.Location = New System.Drawing.Point(397, 336)
        Me.degreeBox.Name = "degreeBox"
        Me.degreeBox.ReadOnly = True
        Me.degreeBox.Size = New System.Drawing.Size(165, 20)
        Me.degreeBox.TabIndex = 13
        '
        'phoneBox
        '
        Me.phoneBox.Enabled = False
        Me.phoneBox.Location = New System.Drawing.Point(397, 310)
        Me.phoneBox.Name = "phoneBox"
        Me.phoneBox.ReadOnly = True
        Me.phoneBox.Size = New System.Drawing.Size(165, 20)
        Me.phoneBox.TabIndex = 14
        '
        'zipBox
        '
        Me.zipBox.Enabled = False
        Me.zipBox.Location = New System.Drawing.Point(397, 284)
        Me.zipBox.Name = "zipBox"
        Me.zipBox.ReadOnly = True
        Me.zipBox.Size = New System.Drawing.Size(165, 20)
        Me.zipBox.TabIndex = 15
        '
        'provinceBox
        '
        Me.provinceBox.Enabled = False
        Me.provinceBox.Location = New System.Drawing.Point(104, 388)
        Me.provinceBox.Name = "provinceBox"
        Me.provinceBox.ReadOnly = True
        Me.provinceBox.Size = New System.Drawing.Size(165, 20)
        Me.provinceBox.TabIndex = 16
        '
        'cityBox
        '
        Me.cityBox.Enabled = False
        Me.cityBox.Location = New System.Drawing.Point(104, 362)
        Me.cityBox.Name = "cityBox"
        Me.cityBox.ReadOnly = True
        Me.cityBox.Size = New System.Drawing.Size(165, 20)
        Me.cityBox.TabIndex = 17
        '
        'addressBox
        '
        Me.addressBox.Enabled = False
        Me.addressBox.Location = New System.Drawing.Point(104, 336)
        Me.addressBox.Name = "addressBox"
        Me.addressBox.ReadOnly = True
        Me.addressBox.Size = New System.Drawing.Size(165, 20)
        Me.addressBox.TabIndex = 18
        '
        'lnameBox
        '
        Me.lnameBox.Enabled = False
        Me.lnameBox.Location = New System.Drawing.Point(104, 310)
        Me.lnameBox.Name = "lnameBox"
        Me.lnameBox.ReadOnly = True
        Me.lnameBox.Size = New System.Drawing.Size(165, 20)
        Me.lnameBox.TabIndex = 19
        '
        'roleBox
        '
        Me.roleBox.Enabled = False
        Me.roleBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roleBox.Location = New System.Drawing.Point(12, 213)
        Me.roleBox.Name = "roleBox"
        Me.roleBox.ReadOnly = True
        Me.roleBox.Size = New System.Drawing.Size(110, 22)
        Me.roleBox.TabIndex = 20
        '
        'homeLnk
        '
        Me.homeLnk.AutoSize = True
        Me.homeLnk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.homeLnk.Location = New System.Drawing.Point(12, 9)
        Me.homeLnk.Name = "homeLnk"
        Me.homeLnk.Size = New System.Drawing.Size(45, 16)
        Me.homeLnk.TabIndex = 28
        Me.homeLnk.TabStop = True
        Me.homeLnk.Text = "Home"
        '
        'logoutLnk
        '
        Me.logoutLnk.AutoSize = True
        Me.logoutLnk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logoutLnk.Location = New System.Drawing.Point(718, 9)
        Me.logoutLnk.Name = "logoutLnk"
        Me.logoutLnk.Size = New System.Drawing.Size(49, 16)
        Me.logoutLnk.TabIndex = 29
        Me.logoutLnk.TabStop = True
        Me.logoutLnk.Text = "Logout"
        '
        'UsersLnk
        '
        Me.UsersLnk.AutoSize = True
        Me.UsersLnk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsersLnk.Location = New System.Drawing.Point(580, 9)
        Me.UsersLnk.Name = "UsersLnk"
        Me.UsersLnk.Size = New System.Drawing.Size(44, 16)
        Me.UsersLnk.TabIndex = 30
        Me.UsersLnk.TabStop = True
        Me.UsersLnk.Text = "Users"
        '
        'addBookLnk
        '
        Me.addBookLnk.AutoSize = True
        Me.addBookLnk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addBookLnk.Location = New System.Drawing.Point(506, 9)
        Me.addBookLnk.Name = "addBookLnk"
        Me.addBookLnk.Size = New System.Drawing.Size(68, 16)
        Me.addBookLnk.TabIndex = 31
        Me.addBookLnk.TabStop = True
        Me.addBookLnk.Text = "Add Book"
        '
        'dueLnk
        '
        Me.dueLnk.AutoSize = True
        Me.dueLnk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dueLnk.Location = New System.Drawing.Point(438, 9)
        Me.dueLnk.Name = "dueLnk"
        Me.dueLnk.Size = New System.Drawing.Size(62, 16)
        Me.dueLnk.TabIndex = 32
        Me.dueLnk.TabStop = True
        Me.dueLnk.Text = "OverDue"
        '
        'bookLnk
        '
        Me.bookLnk.AutoSize = True
        Me.bookLnk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bookLnk.Location = New System.Drawing.Point(63, 9)
        Me.bookLnk.Name = "bookLnk"
        Me.bookLnk.Size = New System.Drawing.Size(47, 16)
        Me.bookLnk.TabIndex = 33
        Me.bookLnk.TabStop = True
        Me.bookLnk.Text = "Books"
        '
        'accountLnk
        '
        Me.accountLnk.AutoSize = True
        Me.accountLnk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.accountLnk.Location = New System.Drawing.Point(635, 9)
        Me.accountLnk.Name = "accountLnk"
        Me.accountLnk.Size = New System.Drawing.Size(77, 16)
        Me.accountLnk.TabIndex = 34
        Me.accountLnk.TabStop = True
        Me.accountLnk.Text = "My Account"
        '
        'returnBtn
        '
        Me.returnBtn.Location = New System.Drawing.Point(303, 213)
        Me.returnBtn.Name = "returnBtn"
        Me.returnBtn.Size = New System.Drawing.Size(97, 58)
        Me.returnBtn.TabIndex = 36
        Me.returnBtn.Text = "Return"
        Me.returnBtn.UseVisualStyleBackColor = True
        '
        'borrowGrid
        '
        Me.borrowGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.borrowGrid.Location = New System.Drawing.Point(15, 57)
        Me.borrowGrid.Name = "borrowGrid"
        Me.borrowGrid.Size = New System.Drawing.Size(385, 150)
        Me.borrowGrid.TabIndex = 37
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(63, 258)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 13)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "Email:"
        '
        'emailBox
        '
        Me.emailBox.Enabled = False
        Me.emailBox.Location = New System.Drawing.Point(104, 255)
        Me.emailBox.Name = "emailBox"
        Me.emailBox.ReadOnly = True
        Me.emailBox.Size = New System.Drawing.Size(165, 20)
        Me.emailBox.TabIndex = 39
        '
        'historyGrid
        '
        Me.historyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.historyGrid.Location = New System.Drawing.Point(424, 57)
        Me.historyGrid.Name = "historyGrid"
        Me.historyGrid.Size = New System.Drawing.Size(343, 150)
        Me.historyGrid.TabIndex = 40
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(13, 38)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 13)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "Current: "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(424, 37)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 13)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "History:"
        '
        'myAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 420)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.historyGrid)
        Me.Controls.Add(Me.emailBox)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.borrowGrid)
        Me.Controls.Add(Me.returnBtn)
        Me.Controls.Add(Me.accountLnk)
        Me.Controls.Add(Me.bookLnk)
        Me.Controls.Add(Me.dueLnk)
        Me.Controls.Add(Me.addBookLnk)
        Me.Controls.Add(Me.UsersLnk)
        Me.Controls.Add(Me.logoutLnk)
        Me.Controls.Add(Me.homeLnk)
        Me.Controls.Add(Me.roleBox)
        Me.Controls.Add(Me.lnameBox)
        Me.Controls.Add(Me.addressBox)
        Me.Controls.Add(Me.cityBox)
        Me.Controls.Add(Me.provinceBox)
        Me.Controls.Add(Me.zipBox)
        Me.Controls.Add(Me.phoneBox)
        Me.Controls.Add(Me.degreeBox)
        Me.Controls.Add(Me.majorBox)
        Me.Controls.Add(Me.numBox)
        Me.Controls.Add(Me.fnameBox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "myAccount"
        Me.Text = "My Account"
        CType(Me.borrowGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.historyGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents fnameBox As System.Windows.Forms.TextBox
    Friend WithEvents numBox As System.Windows.Forms.TextBox
    Friend WithEvents majorBox As System.Windows.Forms.TextBox
    Friend WithEvents degreeBox As System.Windows.Forms.TextBox
    Friend WithEvents phoneBox As System.Windows.Forms.TextBox
    Friend WithEvents zipBox As System.Windows.Forms.TextBox
    Friend WithEvents provinceBox As System.Windows.Forms.TextBox
    Friend WithEvents cityBox As System.Windows.Forms.TextBox
    Friend WithEvents addressBox As System.Windows.Forms.TextBox
    Friend WithEvents lnameBox As System.Windows.Forms.TextBox
    Friend WithEvents roleBox As System.Windows.Forms.TextBox
    Friend WithEvents homeLnk As System.Windows.Forms.LinkLabel
    Friend WithEvents logoutLnk As System.Windows.Forms.LinkLabel
    Friend WithEvents UsersLnk As System.Windows.Forms.LinkLabel
    Friend WithEvents addBookLnk As System.Windows.Forms.LinkLabel
    Friend WithEvents dueLnk As System.Windows.Forms.LinkLabel
    Friend WithEvents bookLnk As System.Windows.Forms.LinkLabel
    Friend WithEvents accountLnk As System.Windows.Forms.LinkLabel
    Friend WithEvents returnBtn As System.Windows.Forms.Button
    Friend WithEvents borrowGrid As System.Windows.Forms.DataGridView
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents emailBox As System.Windows.Forms.TextBox
    Friend WithEvents historyGrid As System.Windows.Forms.DataGridView
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
