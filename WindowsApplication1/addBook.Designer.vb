<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addBook
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.titleBox = New System.Windows.Forms.TextBox()
        Me.dueBox = New System.Windows.Forms.TextBox()
        Me.yearBox = New System.Windows.Forms.TextBox()
        Me.editionBox = New System.Windows.Forms.TextBox()
        Me.ISBNBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.addBookBtn = New System.Windows.Forms.Button()
        Me.addAuthBtn = New System.Windows.Forms.Button()
        Me.accountLnk = New System.Windows.Forms.LinkLabel()
        Me.dueLnk = New System.Windows.Forms.LinkLabel()
        Me.addBookLnk = New System.Windows.Forms.LinkLabel()
        Me.UsersLnk = New System.Windows.Forms.LinkLabel()
        Me.logoutLnk = New System.Windows.Forms.LinkLabel()
        Me.homeLnk = New System.Windows.Forms.LinkLabel()
        Me.remBtn = New System.Windows.Forms.Button()
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.bookLnk = New System.Windows.Forms.LinkLabel()
        Me.AuthorDataSet = New WindowsApplication1.AuthorDataSet()
        Me.AuthorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AuthorsTableAdapter = New WindowsApplication1.AuthorDataSetTableAdapters.AuthorsTableAdapter()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.descBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.copyBox = New System.Windows.Forms.TextBox()
        Me.newAuthBox = New System.Windows.Forms.Button()
        Me.authData = New System.Windows.Forms.DataGridView()
        Me.Publisher = New System.Windows.Forms.Label()
        Me.pubData = New System.Windows.Forms.DataGridView()
        Me.addPubBtn = New System.Windows.Forms.Button()
        Me.remPubBtn = New System.Windows.Forms.Button()
        Me.newPubBtn = New System.Windows.Forms.Button()
        Me.addedAuthors = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.addedPublishers = New System.Windows.Forms.DataGridView()
        Me.pubID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pubName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.country = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.genreBox = New System.Windows.Forms.ComboBox()
        CType(Me.AuthorDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuthorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.authData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pubData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.addedAuthors, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.addedPublishers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(102, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Title:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 244)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Return Time(days):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(100, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Year:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(90, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Edition:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(97, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "ISBN:"
        '
        'titleBox
        '
        Me.titleBox.Location = New System.Drawing.Point(133, 70)
        Me.titleBox.Name = "titleBox"
        Me.titleBox.Size = New System.Drawing.Size(155, 20)
        Me.titleBox.TabIndex = 5
        '
        'dueBox
        '
        Me.dueBox.Location = New System.Drawing.Point(133, 241)
        Me.dueBox.Name = "dueBox"
        Me.dueBox.Size = New System.Drawing.Size(155, 20)
        Me.dueBox.TabIndex = 30
        '
        'yearBox
        '
        Me.yearBox.Location = New System.Drawing.Point(133, 206)
        Me.yearBox.Name = "yearBox"
        Me.yearBox.Size = New System.Drawing.Size(155, 20)
        Me.yearBox.TabIndex = 20
        '
        'editionBox
        '
        Me.editionBox.Location = New System.Drawing.Point(133, 171)
        Me.editionBox.Name = "editionBox"
        Me.editionBox.Size = New System.Drawing.Size(155, 20)
        Me.editionBox.TabIndex = 15
        '
        'ISBNBox
        '
        Me.ISBNBox.Location = New System.Drawing.Point(133, 106)
        Me.ISBNBox.Name = "ISBNBox"
        Me.ISBNBox.Size = New System.Drawing.Size(155, 20)
        Me.ISBNBox.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(36, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Book Information:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(308, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Authors:"
        '
        'addBookBtn
        '
        Me.addBookBtn.Location = New System.Drawing.Point(39, 349)
        Me.addBookBtn.Name = "addBookBtn"
        Me.addBookBtn.Size = New System.Drawing.Size(105, 35)
        Me.addBookBtn.TabIndex = 50
        Me.addBookBtn.Text = "Add Book"
        Me.addBookBtn.UseVisualStyleBackColor = True
        '
        'addAuthBtn
        '
        Me.addAuthBtn.Location = New System.Drawing.Point(356, 215)
        Me.addAuthBtn.Name = "addAuthBtn"
        Me.addAuthBtn.Size = New System.Drawing.Size(105, 23)
        Me.addAuthBtn.TabIndex = 60
        Me.addAuthBtn.Text = "Add Author"
        Me.addAuthBtn.UseVisualStyleBackColor = True
        '
        'accountLnk
        '
        Me.accountLnk.AutoSize = True
        Me.accountLnk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.accountLnk.Location = New System.Drawing.Point(769, 9)
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
        Me.dueLnk.Location = New System.Drawing.Point(577, 9)
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
        Me.addBookLnk.Location = New System.Drawing.Point(645, 9)
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
        Me.UsersLnk.Location = New System.Drawing.Point(719, 9)
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
        Me.logoutLnk.Location = New System.Drawing.Point(852, 9)
        Me.logoutLnk.Name = "logoutLnk"
        Me.logoutLnk.Size = New System.Drawing.Size(49, 16)
        Me.logoutLnk.TabIndex = 36
        Me.logoutLnk.TabStop = True
        Me.logoutLnk.Text = "Logout"
        '
        'homeLnk
        '
        Me.homeLnk.AutoSize = True
        Me.homeLnk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.homeLnk.Location = New System.Drawing.Point(12, 9)
        Me.homeLnk.Name = "homeLnk"
        Me.homeLnk.Size = New System.Drawing.Size(45, 16)
        Me.homeLnk.TabIndex = 35
        Me.homeLnk.TabStop = True
        Me.homeLnk.Text = "Home"
        '
        'remBtn
        '
        Me.remBtn.Location = New System.Drawing.Point(501, 215)
        Me.remBtn.Name = "remBtn"
        Me.remBtn.Size = New System.Drawing.Size(95, 23)
        Me.remBtn.TabIndex = 65
        Me.remBtn.Text = "Remove Author"
        Me.remBtn.UseVisualStyleBackColor = True
        '
        'cancelBtn
        '
        Me.cancelBtn.Location = New System.Drawing.Point(186, 349)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(102, 35)
        Me.cancelBtn.TabIndex = 55
        Me.cancelBtn.Text = "Cancel"
        Me.cancelBtn.UseVisualStyleBackColor = True
        '
        'bookLnk
        '
        Me.bookLnk.AutoSize = True
        Me.bookLnk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bookLnk.Location = New System.Drawing.Point(63, 9)
        Me.bookLnk.Name = "bookLnk"
        Me.bookLnk.Size = New System.Drawing.Size(47, 16)
        Me.bookLnk.TabIndex = 46
        Me.bookLnk.TabStop = True
        Me.bookLnk.Text = "Books"
        '
        'AuthorDataSet
        '
        Me.AuthorDataSet.DataSetName = "AuthorDataSet"
        Me.AuthorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AuthorsBindingSource
        '
        Me.AuthorsBindingSource.DataMember = "Authors"
        Me.AuthorsBindingSource.DataSource = Me.AuthorDataSet
        '
        'AuthorsTableAdapter
        '
        Me.AuthorsTableAdapter.ClearBeforeFill = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(69, 321)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Description:"
        '
        'descBox
        '
        Me.descBox.Location = New System.Drawing.Point(133, 318)
        Me.descBox.Name = "descBox"
        Me.descBox.Size = New System.Drawing.Size(155, 20)
        Me.descBox.TabIndex = 40
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(85, 283)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 49
        Me.Label10.Text = "Copies:"
        '
        'copyBox
        '
        Me.copyBox.Location = New System.Drawing.Point(133, 280)
        Me.copyBox.Name = "copyBox"
        Me.copyBox.Size = New System.Drawing.Size(155, 20)
        Me.copyBox.TabIndex = 35
        '
        'newAuthBox
        '
        Me.newAuthBox.Location = New System.Drawing.Point(409, 373)
        Me.newAuthBox.Name = "newAuthBox"
        Me.newAuthBox.Size = New System.Drawing.Size(121, 35)
        Me.newAuthBox.TabIndex = 70
        Me.newAuthBox.Text = "New Author"
        Me.newAuthBox.UseVisualStyleBackColor = True
        '
        'authData
        '
        Me.authData.AllowUserToAddRows = False
        Me.authData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.authData.Location = New System.Drawing.Point(311, 64)
        Me.authData.Name = "authData"
        Me.authData.Size = New System.Drawing.Size(299, 145)
        Me.authData.TabIndex = 71
        '
        'Publisher
        '
        Me.Publisher.AutoSize = True
        Me.Publisher.Location = New System.Drawing.Point(612, 46)
        Me.Publisher.Name = "Publisher"
        Me.Publisher.Size = New System.Drawing.Size(58, 13)
        Me.Publisher.TabIndex = 72
        Me.Publisher.Text = "Publishers:"
        '
        'pubData
        '
        Me.pubData.AllowUserToAddRows = False
        Me.pubData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.pubData.Location = New System.Drawing.Point(657, 63)
        Me.pubData.Name = "pubData"
        Me.pubData.Size = New System.Drawing.Size(244, 145)
        Me.pubData.TabIndex = 73
        '
        'addPubBtn
        '
        Me.addPubBtn.Location = New System.Drawing.Point(657, 214)
        Me.addPubBtn.Name = "addPubBtn"
        Me.addPubBtn.Size = New System.Drawing.Size(95, 23)
        Me.addPubBtn.TabIndex = 74
        Me.addPubBtn.Text = "Add Pub"
        Me.addPubBtn.UseVisualStyleBackColor = True
        '
        'remPubBtn
        '
        Me.remPubBtn.Location = New System.Drawing.Point(813, 214)
        Me.remPubBtn.Name = "remPubBtn"
        Me.remPubBtn.Size = New System.Drawing.Size(88, 23)
        Me.remPubBtn.TabIndex = 75
        Me.remPubBtn.Text = "Remove Pub"
        Me.remPubBtn.UseVisualStyleBackColor = True
        '
        'newPubBtn
        '
        Me.newPubBtn.Location = New System.Drawing.Point(722, 373)
        Me.newPubBtn.Name = "newPubBtn"
        Me.newPubBtn.Size = New System.Drawing.Size(123, 35)
        Me.newPubBtn.TabIndex = 77
        Me.newPubBtn.Text = "New Publisher"
        Me.newPubBtn.UseVisualStyleBackColor = True
        '
        'addedAuthors
        '
        Me.addedAuthors.AllowUserToAddRows = False
        Me.addedAuthors.AllowUserToDeleteRows = False
        Me.addedAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.addedAuthors.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Fname, Me.Lname, Me.email})
        Me.addedAuthors.Location = New System.Drawing.Point(311, 256)
        Me.addedAuthors.Name = "addedAuthors"
        Me.addedAuthors.ReadOnly = True
        Me.addedAuthors.Size = New System.Drawing.Size(299, 111)
        Me.addedAuthors.TabIndex = 78
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'Fname
        '
        Me.Fname.HeaderText = "Fname"
        Me.Fname.Name = "Fname"
        Me.Fname.ReadOnly = True
        '
        'Lname
        '
        Me.Lname.HeaderText = "Lname"
        Me.Lname.Name = "Lname"
        Me.Lname.ReadOnly = True
        '
        'email
        '
        Me.email.HeaderText = "email"
        Me.email.Name = "email"
        Me.email.ReadOnly = True
        '
        'addedPublishers
        '
        Me.addedPublishers.AllowUserToAddRows = False
        Me.addedPublishers.AllowUserToDeleteRows = False
        Me.addedPublishers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.addedPublishers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.pubID, Me.pubName, Me.country})
        Me.addedPublishers.Location = New System.Drawing.Point(657, 256)
        Me.addedPublishers.Name = "addedPublishers"
        Me.addedPublishers.ReadOnly = True
        Me.addedPublishers.Size = New System.Drawing.Size(244, 111)
        Me.addedPublishers.TabIndex = 79
        '
        'pubID
        '
        Me.pubID.HeaderText = "pubID"
        Me.pubID.Name = "pubID"
        Me.pubID.ReadOnly = True
        '
        'pubName
        '
        Me.pubName.HeaderText = "Publisher"
        Me.pubName.Name = "pubName"
        Me.pubName.ReadOnly = True
        '
        'country
        '
        Me.country.HeaderText = "Country"
        Me.country.Name = "country"
        Me.country.ReadOnly = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(90, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "Genre:"
        '
        'genreBox
        '
        Me.genreBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.genreBox.FormattingEnabled = True
        Me.genreBox.Items.AddRange(New Object() {"Select Genre", "Adventure", "Science Fiction", "Fantasy", "Thriller", "Horror", "Western", "Biography", "History", "English", "Law", "Business", "Philosophy", "Medical", "Psychology", "Sociology", "Anthropology", "Mathematics", "Biology", "Chemistry", "Physics", "Engineering", "Computer Science"})
        Me.genreBox.Location = New System.Drawing.Point(134, 139)
        Me.genreBox.Name = "genreBox"
        Me.genreBox.Size = New System.Drawing.Size(154, 21)
        Me.genreBox.TabIndex = 81
        '
        'addBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 420)
        Me.Controls.Add(Me.genreBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.addedPublishers)
        Me.Controls.Add(Me.addedAuthors)
        Me.Controls.Add(Me.newPubBtn)
        Me.Controls.Add(Me.remPubBtn)
        Me.Controls.Add(Me.addPubBtn)
        Me.Controls.Add(Me.pubData)
        Me.Controls.Add(Me.Publisher)
        Me.Controls.Add(Me.authData)
        Me.Controls.Add(Me.newAuthBox)
        Me.Controls.Add(Me.copyBox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.descBox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.bookLnk)
        Me.Controls.Add(Me.cancelBtn)
        Me.Controls.Add(Me.remBtn)
        Me.Controls.Add(Me.accountLnk)
        Me.Controls.Add(Me.dueLnk)
        Me.Controls.Add(Me.addBookLnk)
        Me.Controls.Add(Me.UsersLnk)
        Me.Controls.Add(Me.logoutLnk)
        Me.Controls.Add(Me.homeLnk)
        Me.Controls.Add(Me.addAuthBtn)
        Me.Controls.Add(Me.addBookBtn)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ISBNBox)
        Me.Controls.Add(Me.editionBox)
        Me.Controls.Add(Me.yearBox)
        Me.Controls.Add(Me.dueBox)
        Me.Controls.Add(Me.titleBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "addBook"
        Me.Text = "Add Book"
        CType(Me.AuthorDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuthorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.authData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pubData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.addedAuthors, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.addedPublishers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents titleBox As System.Windows.Forms.TextBox
    Friend WithEvents dueBox As System.Windows.Forms.TextBox
    Friend WithEvents yearBox As System.Windows.Forms.TextBox
    Friend WithEvents editionBox As System.Windows.Forms.TextBox
    Friend WithEvents ISBNBox As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents addBookBtn As System.Windows.Forms.Button
    Friend WithEvents addAuthBtn As System.Windows.Forms.Button
    Friend WithEvents accountLnk As System.Windows.Forms.LinkLabel
    Friend WithEvents dueLnk As System.Windows.Forms.LinkLabel
    Friend WithEvents addBookLnk As System.Windows.Forms.LinkLabel
    Friend WithEvents UsersLnk As System.Windows.Forms.LinkLabel
    Friend WithEvents logoutLnk As System.Windows.Forms.LinkLabel
    Friend WithEvents homeLnk As System.Windows.Forms.LinkLabel
    Friend WithEvents remBtn As System.Windows.Forms.Button
    Friend WithEvents cancelBtn As System.Windows.Forms.Button
    Friend WithEvents bookLnk As System.Windows.Forms.LinkLabel
    Friend WithEvents AuthorDataSet As WindowsApplication1.AuthorDataSet
    Friend WithEvents AuthorsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AuthorsTableAdapter As WindowsApplication1.AuthorDataSetTableAdapters.AuthorsTableAdapter
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents descBox As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents copyBox As System.Windows.Forms.TextBox
    Friend WithEvents newAuthBox As System.Windows.Forms.Button
    Friend WithEvents authData As System.Windows.Forms.DataGridView
    Friend WithEvents Publisher As System.Windows.Forms.Label
    Friend WithEvents pubData As System.Windows.Forms.DataGridView
    Friend WithEvents addPubBtn As System.Windows.Forms.Button
    Friend WithEvents remPubBtn As System.Windows.Forms.Button
    Friend WithEvents newPubBtn As System.Windows.Forms.Button
    Friend WithEvents addedAuthors As System.Windows.Forms.DataGridView
    Friend WithEvents addedPublishers As System.Windows.Forms.DataGridView
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Lname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pubID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pubName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents country As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents genreBox As System.Windows.Forms.ComboBox
End Class
