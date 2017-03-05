Imports System.Data.OleDb

Public Class Late

    Private Sub logoutLnk_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles logoutLnk.LinkClicked
        Me.Hide()
        Login.logout()
    End Sub

    Private Sub accountLnk_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles accountLnk.LinkClicked
        myAccount.Show()
        Me.Hide()
    End Sub

    Private Sub UsersLnk_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles UsersLnk.LinkClicked
        Users.Show()
        Me.Hide()
    End Sub

    Private Sub addBookLnk_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles addBookLnk.LinkClicked
        addBook.Show()
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

    Private Sub getLate()
        Dim connection = New OleDbConnection(Login.getConnection)
        Dim dataAdapter As OleDbDataAdapter
        Dim trans As OleDbTransaction

        connection.Open()

        trans = connection.BeginTransaction
        Try
            Dim query As String = "SELECT Users.Fname, Users.Lname, Books.title, Books.returnCond, Borrowed.borrowDate, Borrowed.returnDate, Borrowed.status " & _
                "FROM Books, Borrowed, Users " & _
                "WHERE (Borrowed.userID = Users.userID) and (Books.bookID = Borrowed.bookID) and Borrowed.status = 'late'"

            Dim command As OleDbCommand = New OleDbCommand(query, connection)
            command.CommandType = CommandType.Text
            command.Transaction = trans

            dataAdapter = New OleDbDataAdapter(command)
            Dim data As DataSet = New DataSet()
            dataAdapter.Fill(data)
            dueGrid.DataSource = data.Tables(0)
            trans.Commit()

        Catch ex As Exception
            MsgBox(ex.Message)
            trans.Rollback()
        End Try
        connection.Close()

    End Sub

    Private Sub Late_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getLate()
    End Sub

    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        Dim connection As OleDbConnection
        Dim cmd As OleDbCommand
        Dim trans As OleDbTransaction

        Dim currDate As Date
        currDate = Date.Today

        connection = New OleDbConnection(Login.getConnection())
        connection.Open()

        trans = connection.BeginTransaction
        Try
            cmd = New OleDbCommand
            cmd.Connection = connection
            cmd.Transaction = trans

            cmd.CommandText = "UPDATE Borrowed SET Borrowed.status = 'late' WHERE (Borrowed.returnDate < '" + currDate.Date + "') AND (Borrowed.status = 'rented')"
            cmd.ExecuteNonQuery()
            trans.Commit()
            getLate()
        Catch ex As Exception
            trans.Rollback()
            MsgBox(ex.Message)
        End Try
    End Sub
End Class