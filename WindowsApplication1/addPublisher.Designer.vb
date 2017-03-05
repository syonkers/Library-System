<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addPublisher
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
        Me.submitBtn = New System.Windows.Forms.Button()
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.fnameBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.countryBox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'submitBtn
        '
        Me.submitBtn.Location = New System.Drawing.Point(244, 158)
        Me.submitBtn.Name = "submitBtn"
        Me.submitBtn.Size = New System.Drawing.Size(75, 39)
        Me.submitBtn.TabIndex = 21
        Me.submitBtn.Text = "Submit"
        Me.submitBtn.UseVisualStyleBackColor = True
        '
        'clearBtn
        '
        Me.clearBtn.Location = New System.Drawing.Point(129, 158)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(75, 39)
        Me.clearBtn.TabIndex = 20
        Me.clearBtn.Text = "Clear"
        Me.clearBtn.UseVisualStyleBackColor = True
        '
        'cancelBtn
        '
        Me.cancelBtn.Location = New System.Drawing.Point(12, 158)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(75, 39)
        Me.cancelBtn.TabIndex = 19
        Me.cancelBtn.Text = "Cancel"
        Me.cancelBtn.UseVisualStyleBackColor = True
        '
        'fnameBox
        '
        Me.fnameBox.Location = New System.Drawing.Point(98, 65)
        Me.fnameBox.Name = "fnameBox"
        Me.fnameBox.Size = New System.Drawing.Size(221, 20)
        Me.fnameBox.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Company Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Enter Publisher Info:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Country:"
        '
        'countryBox
        '
        Me.countryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.countryBox.FormattingEnabled = True
        Me.countryBox.Items.AddRange(New Object() {"Afghanistan  ", "Albania  ", "Algeria  ", "Andorra  ", "Angola  ", "Antarctica  ", "Antigua and Barbuda  ", "Argentina  ", "Armenia  ", "Aruba  ", "Australia  ", "Austria  ", "Azerbaijan  ", "Bahamas  ", "Bahrain  ", "Bangladesh  ", "Barbados  ", "Belarus  ", "Belgium  ", "Belize  ", "Benin  ", "Bhutan  ", "Bolivia  ", "Bosnia and Herzegovina  ", "Botswana  ", "Brazil  ", "Brunei  ", "Bulgaria  ", "Burkina Faso  ", "Burundi  ", "Cambodia  ", "Cameroon  ", "Canada  ", "Canary Islands  ", "Cape Verde Islands  ", "Cayman islands  ", "Central African Republic  ", "Chad  ", "Chile  ", "China  ", "Colombia  ", "Comoros  ", "Congo  ", "Cook Islands  ", "Costa Rica  ", "Croatia  ", "Cuba  ", "Cyprus  ", "Czech Republic  ", "Democratic Republic of the Congo (Zaire)  ", "Denmark  ", "Djibouti  ", "Dominica  ", "Dominican Republic  ", "East Timor  ", "Ecuador  ", "Egypt  ", "El Salvador  ", "Equatorial Guinea  ", "Eritrea  ", "Estonia  ", "Ethiopia  ", "Federated States of Micronesia  ", "Fiji  ", "Finland  ", "France  ", "French Guyana  ", "French Polynesia  ", "Gabon  ", "Gambia  ", "Georgia  ", "Germany  ", "Ghana  ", "Greece  ", "Greenland  ", "Grenada  ", "Guatemala  ", "Guinea  ", "Guinea Bissau  ", "Guyana  ", "Haiti  ", "Honduras  ", "Hong Kong  ", "Hungary  ", "Iceland  ", "India  ", "Indonesia  ", "Iran  ", "Iraq  ", "Israel  ", "Italy  ", "Ivory Coast/Côte d’Ivoire  ", "Jamaica  ", "Japan  ", "Jordan  ", "Kazakhstan  ", "Kenya  ", "Kiribati  ", "Kosovo  ", "Kuwait  ", "Kyrgyzstan  ", "Laos  ", "Latvia  ", "Lebanon  ", "Lesotho  ", "Liberia  ", "Libya  ", "Liechtenstein  ", "Lithuania  ", "Luxembourg  ", "Macedonia  ", "Madagascar  ", "Malawi  ", "Malaysia  ", "Maldives  ", "Mali  ", "Malta  ", "Marshall Islands  ", "Martinique  ", "Mauritania  ", "Mauritius  ", "Mexico  ", "Moldova  ", "Monaco  ", "Mongolia  ", "Montenegro  ", "Morocco  ", "Mozambique  ", "Myanmar (Burma)  ", "Namibia  ", "Nauru  ", "Nepal  ", "New Caledonia  ", "New Zealand  ", "Nicaragua  ", "Niger  ", "Nigeria  ", "North Korea  ", "Norway  ", "Oman  ", "Pakistan  ", "Palau  ", "Palestine  ", "Panama  ", "Papua New Guinea  ", "Paraguay  ", "Peru  ", "Philippines  ", "Pitcairn Islands  ", "Poland  ", "Portugal  ", "Puerto Rico  ", "Qatar  ", "Republic of Ireland  ", "Republic of San Marino  ", "Romania  ", "Russia  ", "Rwanda  ", "Samoa  ", "Sao Tome  ", "Saudi Arabia  ", "Scotland  ", "Senegal  ", "Serbia  ", "Seychelles  ", "Sierra Leone  ", "Singapore  ", "Slovakia  ", "Slovenia  ", "Solomon Islands  ", "Somalia  ", "South Africa  ", "South Korea  ", "Spain  ", "Sri Lanka  ", "St. Kitts and Nevis  ", "St. Lucia  ", "St. Vincent and The Grenadines  ", "Sudan  ", "Suriname  ", "Swaziland  ", "Sweden  ", "Switzerland  ", "Syria  ", "Taiwan  ", "Tajikistan  ", "Tanzania  ", "Thailand  ", "The Netherlands  ", "The Vatican  ", "Togo  ", "Tonga  ", "Trinidad and Tobago  ", "Tunisia  ", "Turkey  ", "Turkmenistan  ", "Tuvalu  ", "Uganda  ", "Ukraine  ", "United Arab Emirates  ", "United Kingdom  ", "United States  ", "Uruguay  ", "Uzbekistan  ", "Vanuatu  ", "Venezuela  ", "Vietnam  ", "Wales  ", "West Bank and Gaza  ", "Western Sahara  ", "Yemen  ", "Zambia  ", "Zimbabwe  "})
        Me.countryBox.Location = New System.Drawing.Point(100, 105)
        Me.countryBox.Name = "countryBox"
        Me.countryBox.Size = New System.Drawing.Size(221, 21)
        Me.countryBox.TabIndex = 23
        '
        'addPublisher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 209)
        Me.Controls.Add(Me.countryBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.submitBtn)
        Me.Controls.Add(Me.clearBtn)
        Me.Controls.Add(Me.cancelBtn)
        Me.Controls.Add(Me.fnameBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "addPublisher"
        Me.Text = "addPublisher"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents submitBtn As System.Windows.Forms.Button
    Friend WithEvents clearBtn As System.Windows.Forms.Button
    Friend WithEvents cancelBtn As System.Windows.Forms.Button
    Friend WithEvents fnameBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents countryBox As System.Windows.Forms.ComboBox
End Class
