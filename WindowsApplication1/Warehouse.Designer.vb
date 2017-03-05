<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Warehouse
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
        Me.backLink = New System.Windows.Forms.LinkLabel()
        Me.genreLbl = New System.Windows.Forms.Label()
        Me.fromLbl = New System.Windows.Forms.Label()
        Me.toLbl = New System.Windows.Forms.Label()
        Me.pubLbl = New System.Windows.Forms.Label()
        Me.nameLbl = New System.Windows.Forms.Label()
        Me.countryLbl = New System.Windows.Forms.Label()
        Me.genreCombo = New System.Windows.Forms.ComboBox()
        Me.nameCombo = New System.Windows.Forms.ComboBox()
        Me.countryCombo = New System.Windows.Forms.ComboBox()
        Me.dateCheck = New System.Windows.Forms.CheckBox()
        Me.pubCheck = New System.Windows.Forms.CheckBox()
        Me.genreCheck = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.searchBtn = New System.Windows.Forms.Button()
        Me.allCheck = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.resultsLbl = New System.Windows.Forms.Label()
        Me.fromCalender = New System.Windows.Forms.DateTimePicker()
        Me.toCalender = New System.Windows.Forms.DateTimePicker()
        Me.tempGrid = New System.Windows.Forms.DataGridView()
        Me.updateBtn = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dateLbl = New System.Windows.Forms.Label()
        CType(Me.tempGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'backLink
        '
        Me.backLink.AutoSize = True
        Me.backLink.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backLink.Location = New System.Drawing.Point(12, 9)
        Me.backLink.Name = "backLink"
        Me.backLink.Size = New System.Drawing.Size(39, 16)
        Me.backLink.TabIndex = 0
        Me.backLink.TabStop = True
        Me.backLink.Text = "Back"
        '
        'genreLbl
        '
        Me.genreLbl.AutoSize = True
        Me.genreLbl.Location = New System.Drawing.Point(12, 307)
        Me.genreLbl.Name = "genreLbl"
        Me.genreLbl.Size = New System.Drawing.Size(39, 13)
        Me.genreLbl.TabIndex = 1
        Me.genreLbl.Text = "Genre:"
        Me.genreLbl.Visible = False
        '
        'fromLbl
        '
        Me.fromLbl.AutoSize = True
        Me.fromLbl.Location = New System.Drawing.Point(25, 107)
        Me.fromLbl.Name = "fromLbl"
        Me.fromLbl.Size = New System.Drawing.Size(33, 13)
        Me.fromLbl.TabIndex = 2
        Me.fromLbl.Text = "From:"
        Me.fromLbl.Visible = False
        '
        'toLbl
        '
        Me.toLbl.AutoSize = True
        Me.toLbl.Location = New System.Drawing.Point(29, 137)
        Me.toLbl.Name = "toLbl"
        Me.toLbl.Size = New System.Drawing.Size(23, 13)
        Me.toLbl.TabIndex = 3
        Me.toLbl.Text = "To:"
        Me.toLbl.Visible = False
        '
        'pubLbl
        '
        Me.pubLbl.AutoSize = True
        Me.pubLbl.Location = New System.Drawing.Point(-1, 180)
        Me.pubLbl.Name = "pubLbl"
        Me.pubLbl.Size = New System.Drawing.Size(53, 13)
        Me.pubLbl.TabIndex = 4
        Me.pubLbl.Text = "Publisher:"
        Me.pubLbl.Visible = False
        '
        'nameLbl
        '
        Me.nameLbl.AutoSize = True
        Me.nameLbl.Location = New System.Drawing.Point(50, 214)
        Me.nameLbl.Name = "nameLbl"
        Me.nameLbl.Size = New System.Drawing.Size(38, 13)
        Me.nameLbl.TabIndex = 11
        Me.nameLbl.Text = "Name:"
        Me.nameLbl.Visible = False
        '
        'countryLbl
        '
        Me.countryLbl.AutoSize = True
        Me.countryLbl.Location = New System.Drawing.Point(42, 266)
        Me.countryLbl.Name = "countryLbl"
        Me.countryLbl.Size = New System.Drawing.Size(46, 13)
        Me.countryLbl.TabIndex = 12
        Me.countryLbl.Text = "Country:"
        Me.countryLbl.Visible = False
        '
        'genreCombo
        '
        Me.genreCombo.FormattingEnabled = True
        Me.genreCombo.Items.AddRange(New Object() {"--ALL--", "Adventure", "Science Fiction", "Fantasy", "Thriller", "Horror", "Western", "Biography", "History", "English", "Law", "Business", "Philosophy", "Medical", "Psychology", "Sociology", "Anthropology", "Mathematics", "Biology", "Chemistry", "Physics", "Engineering", "Computer Science"})
        Me.genreCombo.Location = New System.Drawing.Point(52, 323)
        Me.genreCombo.Name = "genreCombo"
        Me.genreCombo.Size = New System.Drawing.Size(208, 21)
        Me.genreCombo.TabIndex = 13
        Me.genreCombo.Visible = False
        '
        'nameCombo
        '
        Me.nameCombo.FormattingEnabled = True
        Me.nameCombo.Items.AddRange(New Object() {"--ALL--"})
        Me.nameCombo.Location = New System.Drawing.Point(94, 211)
        Me.nameCombo.Name = "nameCombo"
        Me.nameCombo.Size = New System.Drawing.Size(167, 21)
        Me.nameCombo.TabIndex = 14
        Me.nameCombo.Visible = False
        '
        'countryCombo
        '
        Me.countryCombo.FormattingEnabled = True
        Me.countryCombo.Items.AddRange(New Object() {"--ALL--", "Afghanistan  ", "Albania  ", "Algeria  ", "Andorra  ", "Angola  ", "Antarctica  ", "Antigua and Barbuda  ", "Argentina  ", "Armenia  ", "Aruba  ", "Australia  ", "Austria  ", "Azerbaijan  ", "Bahamas  ", "Bahrain  ", "Bangladesh  ", "Barbados  ", "Belarus  ", "Belgium  ", "Belize  ", "Benin  ", "Bhutan  ", "Bolivia  ", "Bosnia and Herzegovina  ", "Botswana  ", "Brazil  ", "Brunei  ", "Bulgaria  ", "Burkina Faso  ", "Burundi  ", "Cambodia  ", "Cameroon  ", "Canada  ", "Canary Islands  ", "Cape Verde Islands  ", "Cayman islands  ", "Central African Republic  ", "Chad  ", "Chile  ", "China  ", "Colombia  ", "Comoros  ", "Congo  ", "Cook Islands  ", "Costa Rica  ", "Croatia  ", "Cuba  ", "Cyprus  ", "Czech Republic  ", "Democratic Republic of the Congo (Zaire)  ", "Denmark  ", "Djibouti  ", "Dominica  ", "Dominican Republic  ", "East Timor  ", "Ecuador  ", "Egypt  ", "El Salvador  ", "Equatorial Guinea  ", "Eritrea  ", "Estonia  ", "Ethiopia  ", "Federated States of Micronesia  ", "Fiji  ", "Finland  ", "France  ", "French Guyana  ", "French Polynesia  ", "Gabon  ", "Gambia  ", "Georgia  ", "Germany  ", "Ghana  ", "Greece  ", "Greenland  ", "Grenada  ", "Guatemala  ", "Guinea  ", "Guinea Bissau  ", "Guyana  ", "Haiti  ", "Honduras  ", "Hong Kong  ", "Hungary  ", "Iceland  ", "India  ", "Indonesia  ", "Iran  ", "Iraq  ", "Israel  ", "Italy  ", "Ivory Coast/Côte d’Ivoire  ", "Jamaica  ", "Japan  ", "Jordan  ", "Kazakhstan  ", "Kenya  ", "Kiribati  ", "Kosovo  ", "Kuwait  ", "Kyrgyzstan  ", "Laos  ", "Latvia  ", "Lebanon  ", "Lesotho  ", "Liberia  ", "Libya  ", "Liechtenstein  ", "Lithuania  ", "Luxembourg  ", "Macedonia  ", "Madagascar  ", "Malawi  ", "Malaysia  ", "Maldives  ", "Mali  ", "Malta  ", "Marshall Islands  ", "Martinique  ", "Mauritania  ", "Mauritius  ", "Mexico  ", "Moldova  ", "Monaco  ", "Mongolia  ", "Montenegro  ", "Morocco  ", "Mozambique  ", "Myanmar (Burma)  ", "Namibia  ", "Nauru  ", "Nepal  ", "New Caledonia  ", "New Zealand  ", "Nicaragua  ", "Niger  ", "Nigeria  ", "North Korea  ", "Norway  ", "Oman  ", "Pakistan  ", "Palau  ", "Palestine  ", "Panama  ", "Papua New Guinea  ", "Paraguay  ", "Peru  ", "Philippines  ", "Pitcairn Islands  ", "Poland  ", "Portugal  ", "Puerto Rico  ", "Qatar  ", "Republic of Ireland  ", "Republic of San Marino  ", "Romania  ", "Russia  ", "Rwanda  ", "Samoa  ", "Sao Tome  ", "Saudi Arabia  ", "Scotland  ", "Senegal  ", "Serbia  ", "Seychelles  ", "Sierra Leone  ", "Singapore  ", "Slovakia  ", "Slovenia  ", "Solomon Islands  ", "Somalia  ", "South Africa  ", "South Korea  ", "Spain  ", "Sri Lanka  ", "St. Kitts and Nevis  ", "St. Lucia  ", "St. Vincent and The Grenadines  ", "Sudan  ", "Suriname  ", "Swaziland  ", "Sweden  ", "Switzerland  ", "Syria  ", "Taiwan  ", "Tajikistan  ", "Tanzania  ", "Thailand  ", "The Netherlands  ", "The Vatican  ", "Togo  ", "Tonga  ", "Trinidad and Tobago  ", "Tunisia  ", "Turkey  ", "Turkmenistan  ", "Tuvalu  ", "Uganda  ", "Ukraine  ", "United Arab Emirates  ", "United Kingdom  ", "United States  ", "Uruguay  ", "Uzbekistan  ", "Vanuatu  ", "Venezuela  ", "Vietnam  ", "Wales  ", "West Bank and Gaza  ", "Western Sahara  ", "Yemen  ", "Zambia  ", "Zimbabwe  "})
        Me.countryCombo.Location = New System.Drawing.Point(95, 266)
        Me.countryCombo.Name = "countryCombo"
        Me.countryCombo.Size = New System.Drawing.Size(167, 21)
        Me.countryCombo.TabIndex = 15
        Me.countryCombo.Visible = False
        '
        'dateCheck
        '
        Me.dateCheck.AutoSize = True
        Me.dateCheck.Location = New System.Drawing.Point(88, 54)
        Me.dateCheck.Name = "dateCheck"
        Me.dateCheck.Size = New System.Drawing.Size(49, 17)
        Me.dateCheck.TabIndex = 16
        Me.dateCheck.Text = "Date"
        Me.dateCheck.UseVisualStyleBackColor = True
        '
        'pubCheck
        '
        Me.pubCheck.AutoSize = True
        Me.pubCheck.Location = New System.Drawing.Point(143, 54)
        Me.pubCheck.Name = "pubCheck"
        Me.pubCheck.Size = New System.Drawing.Size(69, 17)
        Me.pubCheck.TabIndex = 17
        Me.pubCheck.Text = "Publisher"
        Me.pubCheck.UseVisualStyleBackColor = True
        '
        'genreCheck
        '
        Me.genreCheck.AutoSize = True
        Me.genreCheck.Location = New System.Drawing.Point(220, 54)
        Me.genreCheck.Name = "genreCheck"
        Me.genreCheck.Size = New System.Drawing.Size(55, 17)
        Me.genreCheck.TabIndex = 18
        Me.genreCheck.Text = "Genre"
        Me.genreCheck.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Search By:"
        '
        'searchBtn
        '
        Me.searchBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchBtn.Location = New System.Drawing.Point(15, 380)
        Me.searchBtn.Name = "searchBtn"
        Me.searchBtn.Size = New System.Drawing.Size(145, 29)
        Me.searchBtn.TabIndex = 20
        Me.searchBtn.Text = "Search"
        Me.searchBtn.UseVisualStyleBackColor = True
        '
        'allCheck
        '
        Me.allCheck.AutoSize = True
        Me.allCheck.Location = New System.Drawing.Point(282, 54)
        Me.allCheck.Name = "allCheck"
        Me.allCheck.Size = New System.Drawing.Size(37, 17)
        Me.allCheck.TabIndex = 21
        Me.allCheck.Text = "All"
        Me.allCheck.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(84, 431)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Results:"
        '
        'resultsLbl
        '
        Me.resultsLbl.AutoSize = True
        Me.resultsLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resultsLbl.Location = New System.Drawing.Point(166, 431)
        Me.resultsLbl.Name = "resultsLbl"
        Me.resultsLbl.Size = New System.Drawing.Size(54, 20)
        Me.resultsLbl.TabIndex = 23
        Me.resultsLbl.Text = "---------"
        '
        'fromCalender
        '
        Me.fromCalender.Location = New System.Drawing.Point(64, 101)
        Me.fromCalender.Name = "fromCalender"
        Me.fromCalender.Size = New System.Drawing.Size(200, 20)
        Me.fromCalender.TabIndex = 24
        Me.fromCalender.Visible = False
        '
        'toCalender
        '
        Me.toCalender.Location = New System.Drawing.Point(65, 137)
        Me.toCalender.Name = "toCalender"
        Me.toCalender.Size = New System.Drawing.Size(200, 20)
        Me.toCalender.TabIndex = 25
        Me.toCalender.Visible = False
        '
        'tempGrid
        '
        Me.tempGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tempGrid.Location = New System.Drawing.Point(318, 468)
        Me.tempGrid.Name = "tempGrid"
        Me.tempGrid.Size = New System.Drawing.Size(10, 10)
        Me.tempGrid.TabIndex = 26
        Me.tempGrid.Visible = False
        '
        'updateBtn
        '
        Me.updateBtn.AutoSize = True
        Me.updateBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateBtn.Location = New System.Drawing.Point(57, 9)
        Me.updateBtn.Name = "updateBtn"
        Me.updateBtn.Size = New System.Drawing.Size(53, 16)
        Me.updateBtn.TabIndex = 27
        Me.updateBtn.TabStop = True
        Me.updateBtn.Text = "Update"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(167, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Last Updated On:"
        '
        'dateLbl
        '
        Me.dateLbl.AutoSize = True
        Me.dateLbl.Location = New System.Drawing.Point(264, 12)
        Me.dateLbl.Name = "dateLbl"
        Me.dateLbl.Size = New System.Drawing.Size(22, 13)
        Me.dateLbl.TabIndex = 29
        Me.dateLbl.Text = "-----"
        '
        'Warehouse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 478)
        Me.Controls.Add(Me.dateLbl)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.updateBtn)
        Me.Controls.Add(Me.tempGrid)
        Me.Controls.Add(Me.toCalender)
        Me.Controls.Add(Me.fromCalender)
        Me.Controls.Add(Me.resultsLbl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.allCheck)
        Me.Controls.Add(Me.searchBtn)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.genreCheck)
        Me.Controls.Add(Me.pubCheck)
        Me.Controls.Add(Me.dateCheck)
        Me.Controls.Add(Me.countryCombo)
        Me.Controls.Add(Me.nameCombo)
        Me.Controls.Add(Me.genreCombo)
        Me.Controls.Add(Me.countryLbl)
        Me.Controls.Add(Me.nameLbl)
        Me.Controls.Add(Me.pubLbl)
        Me.Controls.Add(Me.toLbl)
        Me.Controls.Add(Me.fromLbl)
        Me.Controls.Add(Me.genreLbl)
        Me.Controls.Add(Me.backLink)
        Me.Name = "Warehouse"
        Me.Text = "Warehouse"
        CType(Me.tempGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents backLink As System.Windows.Forms.LinkLabel
    Friend WithEvents genreLbl As System.Windows.Forms.Label
    Friend WithEvents fromLbl As System.Windows.Forms.Label
    Friend WithEvents toLbl As System.Windows.Forms.Label
    Friend WithEvents pubLbl As System.Windows.Forms.Label
    Friend WithEvents nameLbl As System.Windows.Forms.Label
    Friend WithEvents countryLbl As System.Windows.Forms.Label
    Friend WithEvents genreCombo As System.Windows.Forms.ComboBox
    Friend WithEvents nameCombo As System.Windows.Forms.ComboBox
    Friend WithEvents countryCombo As System.Windows.Forms.ComboBox
    Friend WithEvents dateCheck As System.Windows.Forms.CheckBox
    Friend WithEvents pubCheck As System.Windows.Forms.CheckBox
    Friend WithEvents genreCheck As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents searchBtn As System.Windows.Forms.Button
    Friend WithEvents allCheck As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents resultsLbl As System.Windows.Forms.Label
    Friend WithEvents fromCalender As System.Windows.Forms.DateTimePicker
    Friend WithEvents toCalender As System.Windows.Forms.DateTimePicker
    Friend WithEvents tempGrid As System.Windows.Forms.DataGridView
    Friend WithEvents updateBtn As System.Windows.Forms.LinkLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dateLbl As System.Windows.Forms.Label
End Class
