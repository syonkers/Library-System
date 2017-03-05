<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Users
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
        Me.components = New System.ComponentModel.Container()
        Me.bookLnk = New System.Windows.Forms.LinkLabel()
        Me.accountLnk = New System.Windows.Forms.LinkLabel()
        Me.dueLnk = New System.Windows.Forms.LinkLabel()
        Me.addBookLnk = New System.Windows.Forms.LinkLabel()
        Me.logoutLnk = New System.Windows.Forms.LinkLabel()
        Me.homeLnk = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.commitBtn = New System.Windows.Forms.Button()
        Me.addBtn = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LibrarySystemDataSet = New WindowsApplication1.LibrarySystemDataSet()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsersTableAdapter = New WindowsApplication1.LibrarySystemDataSetTableAdapters.UsersTableAdapter()
        Me.UserIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SchoolMajorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DegreeProgramDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StreetDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvinceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PostalCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumBooksDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibrarySystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bookLnk
        '
        Me.bookLnk.AutoSize = True
        Me.bookLnk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bookLnk.Location = New System.Drawing.Point(60, 9)
        Me.bookLnk.Name = "bookLnk"
        Me.bookLnk.Size = New System.Drawing.Size(47, 16)
        Me.bookLnk.TabIndex = 53
        Me.bookLnk.TabStop = True
        Me.bookLnk.Text = "Books"
        '
        'accountLnk
        '
        Me.accountLnk.AutoSize = True
        Me.accountLnk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.accountLnk.Location = New System.Drawing.Point(458, 9)
        Me.accountLnk.Name = "accountLnk"
        Me.accountLnk.Size = New System.Drawing.Size(77, 16)
        Me.accountLnk.TabIndex = 52
        Me.accountLnk.TabStop = True
        Me.accountLnk.Text = "My Account"
        '
        'dueLnk
        '
        Me.dueLnk.AutoSize = True
        Me.dueLnk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dueLnk.Location = New System.Drawing.Point(266, 9)
        Me.dueLnk.Name = "dueLnk"
        Me.dueLnk.Size = New System.Drawing.Size(62, 16)
        Me.dueLnk.TabIndex = 51
        Me.dueLnk.TabStop = True
        Me.dueLnk.Text = "OverDue"
        '
        'addBookLnk
        '
        Me.addBookLnk.AutoSize = True
        Me.addBookLnk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addBookLnk.Location = New System.Drawing.Point(334, 9)
        Me.addBookLnk.Name = "addBookLnk"
        Me.addBookLnk.Size = New System.Drawing.Size(68, 16)
        Me.addBookLnk.TabIndex = 50
        Me.addBookLnk.TabStop = True
        Me.addBookLnk.Text = "Add Book"
        '
        'logoutLnk
        '
        Me.logoutLnk.AutoSize = True
        Me.logoutLnk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logoutLnk.Location = New System.Drawing.Point(541, 9)
        Me.logoutLnk.Name = "logoutLnk"
        Me.logoutLnk.Size = New System.Drawing.Size(49, 16)
        Me.logoutLnk.TabIndex = 48
        Me.logoutLnk.TabStop = True
        Me.logoutLnk.Text = "Logout"
        '
        'homeLnk
        '
        Me.homeLnk.AutoSize = True
        Me.homeLnk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.homeLnk.Location = New System.Drawing.Point(9, 9)
        Me.homeLnk.Name = "homeLnk"
        Me.homeLnk.Size = New System.Drawing.Size(45, 16)
        Me.homeLnk.TabIndex = 47
        Me.homeLnk.TabStop = True
        Me.homeLnk.Text = "Home"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(408, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Users"
        '
        'commitBtn
        '
        Me.commitBtn.Location = New System.Drawing.Point(130, 373)
        Me.commitBtn.Name = "commitBtn"
        Me.commitBtn.Size = New System.Drawing.Size(108, 35)
        Me.commitBtn.TabIndex = 56
        Me.commitBtn.Text = "Update"
        Me.commitBtn.UseVisualStyleBackColor = True
        '
        'addBtn
        '
        Me.addBtn.Location = New System.Drawing.Point(12, 373)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(112, 35)
        Me.addBtn.TabIndex = 57
        Me.addBtn.Text = "Add New"
        Me.addBtn.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserIDDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn, Me.FnameDataGridViewTextBoxColumn, Me.LnameDataGridViewTextBoxColumn, Me.SchoolMajorDataGridViewTextBoxColumn, Me.DegreeProgramDataGridViewTextBoxColumn, Me.StreetDataGridViewTextBoxColumn, Me.CityDataGridViewTextBoxColumn, Me.ProvinceDataGridViewTextBoxColumn, Me.PostalCodeDataGridViewTextBoxColumn, Me.PhoneNumDataGridViewTextBoxColumn, Me.NumBooksDataGridViewTextBoxColumn, Me.RoleDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.UsersBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(13, 45)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(580, 322)
        Me.DataGridView1.TabIndex = 58
        '
        'LibrarySystemDataSet
        '
        Me.LibrarySystemDataSet.DataSetName = "LibrarySystemDataSet"
        Me.LibrarySystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "Users"
        Me.UsersBindingSource.DataSource = Me.LibrarySystemDataSet
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'UserIDDataGridViewTextBoxColumn
        '
        Me.UserIDDataGridViewTextBoxColumn.DataPropertyName = "userID"
        Me.UserIDDataGridViewTextBoxColumn.HeaderText = "userID"
        Me.UserIDDataGridViewTextBoxColumn.Name = "UserIDDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "password"
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        '
        'FnameDataGridViewTextBoxColumn
        '
        Me.FnameDataGridViewTextBoxColumn.DataPropertyName = "Fname"
        Me.FnameDataGridViewTextBoxColumn.HeaderText = "Fname"
        Me.FnameDataGridViewTextBoxColumn.Name = "FnameDataGridViewTextBoxColumn"
        '
        'LnameDataGridViewTextBoxColumn
        '
        Me.LnameDataGridViewTextBoxColumn.DataPropertyName = "Lname"
        Me.LnameDataGridViewTextBoxColumn.HeaderText = "Lname"
        Me.LnameDataGridViewTextBoxColumn.Name = "LnameDataGridViewTextBoxColumn"
        '
        'SchoolMajorDataGridViewTextBoxColumn
        '
        Me.SchoolMajorDataGridViewTextBoxColumn.DataPropertyName = "schoolMajor"
        Me.SchoolMajorDataGridViewTextBoxColumn.HeaderText = "schoolMajor"
        Me.SchoolMajorDataGridViewTextBoxColumn.Name = "SchoolMajorDataGridViewTextBoxColumn"
        '
        'DegreeProgramDataGridViewTextBoxColumn
        '
        Me.DegreeProgramDataGridViewTextBoxColumn.DataPropertyName = "degreeProgram"
        Me.DegreeProgramDataGridViewTextBoxColumn.HeaderText = "degreeProgram"
        Me.DegreeProgramDataGridViewTextBoxColumn.Name = "DegreeProgramDataGridViewTextBoxColumn"
        '
        'StreetDataGridViewTextBoxColumn
        '
        Me.StreetDataGridViewTextBoxColumn.DataPropertyName = "street"
        Me.StreetDataGridViewTextBoxColumn.HeaderText = "street"
        Me.StreetDataGridViewTextBoxColumn.Name = "StreetDataGridViewTextBoxColumn"
        '
        'CityDataGridViewTextBoxColumn
        '
        Me.CityDataGridViewTextBoxColumn.DataPropertyName = "city"
        Me.CityDataGridViewTextBoxColumn.HeaderText = "city"
        Me.CityDataGridViewTextBoxColumn.Name = "CityDataGridViewTextBoxColumn"
        '
        'ProvinceDataGridViewTextBoxColumn
        '
        Me.ProvinceDataGridViewTextBoxColumn.DataPropertyName = "province"
        Me.ProvinceDataGridViewTextBoxColumn.HeaderText = "province"
        Me.ProvinceDataGridViewTextBoxColumn.Name = "ProvinceDataGridViewTextBoxColumn"
        '
        'PostalCodeDataGridViewTextBoxColumn
        '
        Me.PostalCodeDataGridViewTextBoxColumn.DataPropertyName = "postalCode"
        Me.PostalCodeDataGridViewTextBoxColumn.HeaderText = "postalCode"
        Me.PostalCodeDataGridViewTextBoxColumn.Name = "PostalCodeDataGridViewTextBoxColumn"
        '
        'PhoneNumDataGridViewTextBoxColumn
        '
        Me.PhoneNumDataGridViewTextBoxColumn.DataPropertyName = "phoneNum"
        Me.PhoneNumDataGridViewTextBoxColumn.HeaderText = "phoneNum"
        Me.PhoneNumDataGridViewTextBoxColumn.Name = "PhoneNumDataGridViewTextBoxColumn"
        '
        'NumBooksDataGridViewTextBoxColumn
        '
        Me.NumBooksDataGridViewTextBoxColumn.DataPropertyName = "numBooks"
        Me.NumBooksDataGridViewTextBoxColumn.HeaderText = "numBooks"
        Me.NumBooksDataGridViewTextBoxColumn.Name = "NumBooksDataGridViewTextBoxColumn"
        '
        'RoleDataGridViewTextBoxColumn
        '
        Me.RoleDataGridViewTextBoxColumn.DataPropertyName = "role"
        Me.RoleDataGridViewTextBoxColumn.HeaderText = "role"
        Me.RoleDataGridViewTextBoxColumn.Name = "RoleDataGridViewTextBoxColumn"
        '
        'Users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 420)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.addBtn)
        Me.Controls.Add(Me.commitBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bookLnk)
        Me.Controls.Add(Me.accountLnk)
        Me.Controls.Add(Me.dueLnk)
        Me.Controls.Add(Me.addBookLnk)
        Me.Controls.Add(Me.logoutLnk)
        Me.Controls.Add(Me.homeLnk)
        Me.Name = "Users"
        Me.Text = "Users"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibrarySystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bookLnk As System.Windows.Forms.LinkLabel
    Friend WithEvents accountLnk As System.Windows.Forms.LinkLabel
    Friend WithEvents dueLnk As System.Windows.Forms.LinkLabel
    Friend WithEvents addBookLnk As System.Windows.Forms.LinkLabel
    Friend WithEvents logoutLnk As System.Windows.Forms.LinkLabel
    Friend WithEvents homeLnk As System.Windows.Forms.LinkLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents commitBtn As System.Windows.Forms.Button
    Friend WithEvents addBtn As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents LibrarySystemDataSet As WindowsApplication1.LibrarySystemDataSet
    Friend WithEvents UsersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsersTableAdapter As WindowsApplication1.LibrarySystemDataSetTableAdapters.UsersTableAdapter
    Friend WithEvents UserIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SchoolMajorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DegreeProgramDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StreetDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProvinceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PostalCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhoneNumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumBooksDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RoleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
