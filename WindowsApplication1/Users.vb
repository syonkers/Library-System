Public Class Users

    Private Sub logoutLnk_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles logoutLnk.LinkClicked
        Login.logout()
        Main.Show()
        Me.Hide()
    End Sub

    Private Sub accountLnk_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles accountLnk.LinkClicked
        myAccount.Show()
        Me.Hide()
    End Sub

    Private Sub addBookLnk_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles addBookLnk.LinkClicked
        addBook.Show()
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

    Private Sub homeLnk_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles homeLnk.LinkClicked
        Main.Show()
        Me.Hide()
    End Sub

    Private Sub Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibrarySystemDataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.LibrarySystemDataSet.Users)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        addUser.Show()
    End Sub

    Private Sub commitBtn_Click(sender As Object, e As EventArgs) Handles commitBtn.Click
        UsersTableAdapter.Update(UsersBindingSource.DataSource)
    End Sub
End Class