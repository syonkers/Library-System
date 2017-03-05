Public Class Main

    Public Sub setAccessControl()
        If Login.getAccessLvl() = "user" Then
            accountLnk.Visible = True
            logoutLnk.Visible = True
            LoginBtn.Visible = False
            dueLnk.Visible = False
            addBookLnk.Visible = False
            UsersLnk.Visible = False
            whouseBtn.Visible = False
        ElseIf Login.getAccessLvl() = "employee" Then
            accountLnk.Visible = True
            logoutLnk.Visible = True
            LoginBtn.Visible = False
            UsersLnk.Visible = True
            addBookLnk.Visible = True
            dueLnk.Visible = True
            whouseBtn.Visible = True
        Else
            logoutLnk.Visible = False
            LoginBtn.Visible = True
            accountLnk.Visible = False
            UsersLnk.Visible = False
            addBookLnk.Visible = False
            dueLnk.Visible = False
            whouseBtn.Visible = False
        End If
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setAccessControl()
    End Sub


    Private Sub UsersLnk_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles UsersLnk.LinkClicked
        Users.Show()
        Me.Hide()
    End Sub

    Private Sub addBookLnk_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles addBookLnk.LinkClicked
        addBook.Show()
        Me.Hide()
    End Sub

    Private Sub LoginBtn_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LoginBtn.LinkClicked
        Login.Show()
    End Sub

    Private Sub logoutLnk_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles logoutLnk.LinkClicked
        Login.logout()
    End Sub

    Private Sub accountLnk_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles accountLnk.LinkClicked
        myAccount.Show()
        Me.Hide()
    End Sub

    Private Sub dueLnk_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles dueLnk.LinkClicked
        Late.Show()
        Me.Hide()
    End Sub

    Private Sub bookLnk_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles bookLnk.LinkClicked
        Books.Show()
        Me.Hide()
    End Sub

    Private Sub searchBtn_Click(sender As Object, e As EventArgs) Handles searchBtn.Click
        Dim keywords As String = searchBox.Text
        Books.Show()
        Books.searchTable(keywords)
        Me.Hide()
    End Sub

    Private Sub whouseBtn_Click(sender As Object, e As EventArgs) Handles whouseBtn.Click
        Warehouse.Show()
        Warehouse.fillNameCombo()
        Warehouse.getLastDate()
        Me.Hide()
    End Sub
End Class