<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Books
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
        Me.accountLnk = New System.Windows.Forms.LinkLabel()
        Me.dueLnk = New System.Windows.Forms.LinkLabel()
        Me.addBookLnk = New System.Windows.Forms.LinkLabel()
        Me.UsersLnk = New System.Windows.Forms.LinkLabel()
        Me.logoutLnk = New System.Windows.Forms.LinkLabel()
        Me.homeLnk = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.loginLnk = New System.Windows.Forms.LinkLabel()
        Me.rentBtn = New System.Windows.Forms.Button()
        Me.commitBtn = New System.Windows.Forms.Button()
        Me.searchBox = New System.Windows.Forms.TextBox()
        Me.searchBtn = New System.Windows.Forms.Button()
        Me.addBtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.authorsBox = New System.Windows.Forms.ListBox()
        Me.booksGrid = New System.Windows.Forms.DataGridView()
        Me.resetBtn = New System.Windows.Forms.Button()
        CType(Me.booksGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'accountLnk
        '
        Me.accountLnk.AutoSize = True
        Me.accountLnk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.accountLnk.Location = New System.Drawing.Point(460, 9)
        Me.accountLnk.Name = "accountLnk"
        Me.accountLnk.Size = New System.Drawing.Size(77, 16)
        Me.accountLnk.TabIndex = 41
        Me.accountLnk.TabStop = True
        Me.accountLnk.Text = "My Account"
        '
        'dueLnk
        '
        Me.dueLnk.AutoSize = True
        Me.dueLnk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dueLnk.Location = New System.Drawing.Point(263, 9)
        Me.dueLnk.Name = "dueLnk"
        Me.dueLnk.Size = New System.Drawing.Size(62, 16)
        Me.dueLnk.TabIndex = 39
        Me.dueLnk.TabStop = True
        Me.dueLnk.Text = "OverDue"
        '
        'addBookLnk
        '
        Me.addBookLnk.AutoSize = True
        Me.addBookLnk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addBookLnk.Location = New System.Drawing.Point(331, 9)
        Me.addBookLnk.Name = "addBookLnk"
        Me.addBookLnk.Size = New System.Drawing.Size(68, 16)
        Me.addBookLnk.TabIndex = 38
        Me.addBookLnk.TabStop = True
        Me.addBookLnk.Text = "Add Book"
        '
        'UsersLnk
        '
        Me.UsersLnk.AutoSize = True
        Me.UsersLnk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsersLnk.Location = New System.Drawing.Point(405, 9)
        Me.UsersLnk.Name = "UsersLnk"
        Me.UsersLnk.Size = New System.Drawing.Size(44, 16)
        Me.UsersLnk.TabIndex = 37
        Me.UsersLnk.TabStop = True
        Me.UsersLnk.Text = "Users"
        '
        'logoutLnk
        '
        Me.logoutLnk.AutoSize = True
        Me.logoutLnk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logoutLnk.Location = New System.Drawing.Point(543, 9)
        Me.logoutLnk.Name = "logoutLnk"
        Me.logoutLnk.Size = New System.Drawing.Size(49, 16)
        Me.logoutLnk.TabIndex = 36
        Me.logoutLnk.TabStop = True
        Me.logoutLnk.Text = "Logout"
        Me.logoutLnk.Visible = False
        '
        'homeLnk
        '
        Me.homeLnk.AutoSize = True
        Me.homeLnk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.homeLnk.Location = New System.Drawing.Point(11, 9)
        Me.homeLnk.Name = "homeLnk"
        Me.homeLnk.Size = New System.Drawing.Size(45, 16)
        Me.homeLnk.TabIndex = 35
        Me.homeLnk.TabStop = True
        Me.homeLnk.Text = "Home"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 16)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Books"
        '
        'loginLnk
        '
        Me.loginLnk.AutoSize = True
        Me.loginLnk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginLnk.Location = New System.Drawing.Point(543, 9)
        Me.loginLnk.Name = "loginLnk"
        Me.loginLnk.Size = New System.Drawing.Size(41, 16)
        Me.loginLnk.TabIndex = 43
        Me.loginLnk.TabStop = True
        Me.loginLnk.Text = "Login"
        '
        'rentBtn
        '
        Me.rentBtn.Location = New System.Drawing.Point(478, 273)
        Me.rentBtn.Name = "rentBtn"
        Me.rentBtn.Size = New System.Drawing.Size(114, 39)
        Me.rentBtn.TabIndex = 45
        Me.rentBtn.Text = "Rent"
        Me.rentBtn.UseVisualStyleBackColor = True
        '
        'commitBtn
        '
        Me.commitBtn.Location = New System.Drawing.Point(478, 360)
        Me.commitBtn.Name = "commitBtn"
        Me.commitBtn.Size = New System.Drawing.Size(115, 39)
        Me.commitBtn.TabIndex = 46
        Me.commitBtn.Text = "Update"
        Me.commitBtn.UseVisualStyleBackColor = True
        '
        'searchBox
        '
        Me.searchBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchBox.Location = New System.Drawing.Point(12, 281)
        Me.searchBox.Name = "searchBox"
        Me.searchBox.Size = New System.Drawing.Size(220, 22)
        Me.searchBox.TabIndex = 47
        '
        'searchBtn
        '
        Me.searchBtn.Location = New System.Drawing.Point(14, 309)
        Me.searchBtn.Name = "searchBtn"
        Me.searchBtn.Size = New System.Drawing.Size(95, 23)
        Me.searchBtn.TabIndex = 50
        Me.searchBtn.Text = "Search"
        Me.searchBtn.UseVisualStyleBackColor = True
        '
        'addBtn
        '
        Me.addBtn.Location = New System.Drawing.Point(366, 360)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(106, 39)
        Me.addBtn.TabIndex = 51
        Me.addBtn.Text = "Add Book"
        Me.addBtn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(263, 269)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Authors"
        '
        'authorsBox
        '
        Me.authorsBox.FormattingEnabled = True
        Me.authorsBox.Location = New System.Drawing.Point(266, 285)
        Me.authorsBox.Name = "authorsBox"
        Me.authorsBox.Size = New System.Drawing.Size(206, 69)
        Me.authorsBox.TabIndex = 52
        '
        'booksGrid
        '
        Me.booksGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.booksGrid.Location = New System.Drawing.Point(14, 39)
        Me.booksGrid.Name = "booksGrid"
        Me.booksGrid.Size = New System.Drawing.Size(581, 227)
        Me.booksGrid.TabIndex = 54
        '
        'resetBtn
        '
        Me.resetBtn.Location = New System.Drawing.Point(141, 309)
        Me.resetBtn.Name = "resetBtn"
        Me.resetBtn.Size = New System.Drawing.Size(91, 23)
        Me.resetBtn.TabIndex = 55
        Me.resetBtn.Text = "Reset"
        Me.resetBtn.UseVisualStyleBackColor = True
        '
        'Books
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 420)
        Me.Controls.Add(Me.resetBtn)
        Me.Controls.Add(Me.booksGrid)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.authorsBox)
        Me.Controls.Add(Me.addBtn)
        Me.Controls.Add(Me.searchBtn)
        Me.Controls.Add(Me.searchBox)
        Me.Controls.Add(Me.commitBtn)
        Me.Controls.Add(Me.rentBtn)
        Me.Controls.Add(Me.loginLnk)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.accountLnk)
        Me.Controls.Add(Me.dueLnk)
        Me.Controls.Add(Me.addBookLnk)
        Me.Controls.Add(Me.UsersLnk)
        Me.Controls.Add(Me.logoutLnk)
        Me.Controls.Add(Me.homeLnk)
        Me.Name = "Books"
        Me.Text = "Books"
        CType(Me.booksGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents accountLnk As System.Windows.Forms.LinkLabel
    Friend WithEvents dueLnk As System.Windows.Forms.LinkLabel
    Friend WithEvents addBookLnk As System.Windows.Forms.LinkLabel
    Friend WithEvents UsersLnk As System.Windows.Forms.LinkLabel
    Friend WithEvents logoutLnk As System.Windows.Forms.LinkLabel
    Friend WithEvents homeLnk As System.Windows.Forms.LinkLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents loginLnk As System.Windows.Forms.LinkLabel
    Friend WithEvents rentBtn As System.Windows.Forms.Button
    Friend WithEvents commitBtn As System.Windows.Forms.Button
    Friend WithEvents searchBox As System.Windows.Forms.TextBox
    Friend WithEvents searchBtn As System.Windows.Forms.Button
    Friend WithEvents addBtn As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents authorsBox As System.Windows.Forms.ListBox
    Friend WithEvents booksGrid As System.Windows.Forms.DataGridView
    Friend WithEvents resetBtn As System.Windows.Forms.Button
End Class
