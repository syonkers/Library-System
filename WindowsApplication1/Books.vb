Imports System.Data.OleDb

Public Class Books

    Public Sub setAccessControl()
        If Login.getAccessLvl() = "user" Then
            accountLnk.Visible = True
            logoutLnk.Visible = True
            loginLnk.Visible = False
            dueLnk.Visible = False
            addBookLnk.Visible = False
            UsersLnk.Visible = False
            commitBtn.Visible = False
            rentBtn.Visible = True
            addBtn.Visible = False
            booksGrid.AllowUserToDeleteRows = False
            booksGrid.AllowUserToAddRows = False
            booksGrid.ReadOnly = True
        ElseIf Login.getAccessLvl() = "employee" Then
            accountLnk.Visible = True
            logoutLnk.Visible = True
            loginLnk.Visible = False
            UsersLnk.Visible = True
            addBookLnk.Visible = True
            dueLnk.Visible = True
            booksGrid.AllowUserToAddRows = True
            booksGrid.AllowUserToDeleteRows = True
            booksGrid.ReadOnly = False
            rentBtn.Visible = True
            commitBtn.Visible = True
            addBtn.Visible = True
        Else
            logoutLnk.Visible = False
            loginLnk.Visible = True
            accountLnk.Visible = False
            UsersLnk.Visible = False
            addBookLnk.Visible = False
            dueLnk.Visible = False
            booksGrid.AllowUserToAddRows = False
            booksGrid.AllowUserToDeleteRows = False
            booksGrid.ReadOnly = True
            rentBtn.Visible = False
            commitBtn.Visible = False
            addBtn.Visible = False
        End If
    End Sub

    Private Sub logoutLnk_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles logoutLnk.LinkClicked
        Me.Close()
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

    Private Sub dueLnk_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles dueLnk.LinkClicked
        Late.Show()
        Me.Hide()
    End Sub

    Private Sub homeLnk_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles homeLnk.LinkClicked
        Main.Show()
        Me.Hide()
    End Sub

    Private Sub loginLnk_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles loginLnk.LinkClicked
        Login.Show()
        Me.Refresh()
    End Sub

    Private Sub Books_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillTable()
        setAccessControl()
    End Sub

    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        addBook.Show()
    End Sub

    Public Sub fillTable()
        Dim connection = New OleDbConnection(Login.getConnection)
        Dim myTransaction As OleDbTransaction
        connection.Open()

        myTransaction = connection.BeginTransaction
        Try
            Dim query As String = "SELECT Books.bookID, Books.title, Books.ISBN, Books.genre, Publisher.name, Books.year, Books.edition, Books.description, Books.returnCond, Books.copies FROM Books, Publisher WHERE (Books.pubID = Publisher.pubID)"
            Dim command As OleDbCommand = New OleDbCommand(query, connection)
            command.CommandType = CommandType.Text
            command.Transaction = myTransaction

            Dim dataAdapter As OleDbDataAdapter = New OleDbDataAdapter
            dataAdapter.SelectCommand = command
            Dim data As DataSet = New DataSet()
            dataAdapter.Fill(data)
            booksGrid.DataSource = data.Tables(0)
            myTransaction.Commit()
        Catch ex As Exception
            MsgBox(ex.Message)
            myTransaction.Rollback()
        End Try
        connection.Close()
    End Sub

    Public Sub searchTable(keyword)
        Dim connection = New OleDbConnection(Login.getConnection)
        Dim myTrans As OleDbTransaction
        Dim dataAdapter As OleDbDataAdapter

        connection.Open()

        myTrans = connection.BeginTransaction
        Try
            Dim query As String = "SELECT Books.bookID, Books.title, Books.ISBN, Books.genre, Publisher.name, Books.year, Books.edition, Books.description, Books.returnCond, Books.copies FROM Books, Publisher WHERE (Books.pubID = Publisher.pubID) and (Books.title Like '%" + keyword.ToString + "%')"
            Dim command As OleDbCommand = New OleDbCommand(query, connection)
            command.CommandType = CommandType.Text
            command.Transaction = myTrans

            dataAdapter = New OleDbDataAdapter(command)
            Dim data As DataSet = New DataSet()
            dataAdapter.Fill(data)
            booksGrid.DataSource = data.Tables(0)
            myTrans.Commit()
        Catch ex As Exception
            MsgBox(ex.Message)
            myTrans.Rollback()
        End Try
        connection.Close()
    End Sub

    Private Sub searchBtn_Click(sender As Object, e As EventArgs) Handles searchBtn.Click
        Dim keyword As String = searchBox.Text
        searchTable(keyword)
    End Sub

    Private Sub resetBtn_Click(sender As Object, e As EventArgs) Handles resetBtn.Click
        fillTable()
        searchBox.Text = ""
    End Sub

    Private Sub rentBtn_Click(sender As Object, e As EventArgs) Handles rentBtn.Click
        Dim eligibile As Boolean = False
        eligibile = checkEligibility()
        If eligibile = False Then
            MsgBox("Limit on number of books able to rent reached, please return some of the books you currently have rented before renting more")
            Exit Sub
        End If
        Dim id As String = booksGrid.CurrentRow.Cells(0).Value.ToString
        Dim copies = checkAvailability(id)
        If copies = 0 Then
            MsgBox("No more copies of this book are availiable, please try again later")
            Exit Sub
        End If
        Dim numDays As Integer = getDays(id)
        Dim connection1, connection2 As OleDbConnection
        Dim command1, command2 As OleDbCommand
        Dim transaction1, transaction2 As OleDbTransaction
        Dim curDate As Date = Date.Today

        connection1 = New OleDbConnection(Login.getConnection)
        connection2 = New OleDbConnection(Login.getConnection)

        connection1.Open()
        connection2.Open()

        transaction1 = connection1.BeginTransaction
        transaction2 = connection2.BeginTransaction

        Try
            command1 = New OleDbCommand
            command1.Connection = connection1
            command1.Transaction = transaction1

            command1.CommandText = "INSERT Into Borrowed(userID,bookID,borrowDate,returnDate,status) VALUES (?,?,?,?,?)"
            command1.Parameters.AddWithValue("userID", Login.getID().ToString)
            command1.Parameters.AddWithValue("bookID", id.ToString)
            command1.Parameters.AddWithValue("borrowDate", curDate.ToString("yyyy-MM-dd"))
            command1.Parameters.AddWithValue("returnDate", curDate.AddDays(numDays).ToString("yyyy-MM-dd"))
            command1.Parameters.AddWithValue("status", "rented")
            command1.ExecuteNonQuery()

            command2 = New OleDbCommand
            command2.Connection = connection2
            command2.Transaction = transaction2

            Dim newCopies As Integer = copies - 1
            command2.CommandText = "UPDATE Books SET Books.copies = '" + newCopies.ToString + "' WHERE (bookID = '" + id.ToString + "')"
            command2.ExecuteNonQuery()

            transaction1.Commit()
            transaction2.Commit()
            MsgBox("Successfully rented book")
            myAccount.getBooks()
        Catch ex As Exception
            transaction1.Rollback()
            transaction2.Rollback()
            MsgBox(ex.Message)
        End Try
        connection1.Close()
        connection2.Close()
        fillTable()
    End Sub

    Private Function checkEligibility()
        Dim rented As Integer
        Dim total As Integer

        Dim connection As OleDbConnection = New OleDbConnection(Login.getConnection)
        Dim command As OleDbCommand
        Dim transaction As OleDbTransaction
        Dim datareader As OleDbDataReader

        connection.Open()
        transaction = connection.BeginTransaction
        Try
            command = New OleDbCommand
            command.Connection = connection
            command.Transaction = transaction

            command.CommandText = "SELECT count(Borrowed.status) FROM Borrowed WHERE (Borrowed.userID = '" + Login.getID().ToString + "') AND (Borrowed.status = 'Late' OR Borrowed.status = 'Rented')"
            datareader = command.ExecuteReader()
            datareader.Read()
            rented = datareader(0)
            datareader.Close()

            command.CommandText = "SELECT Users.numBooks FROM Users WHERE (Users.userID = '" + Login.getID.ToString + "')"
            datareader = command.ExecuteReader()
            datareader.Read()
            total = datareader(0)
            datareader.Close()

            transaction.Commit()
        Catch ex As Exception
            transaction.Rollback()
            MsgBox(ex.Message)
        End Try
        connection.Close()
        If total > rented Then
            Return True
        End If
        Return False
    End Function

    Private Function checkAvailability(id)
        Dim connection As OleDbConnection = New OleDbConnection(Login.getConnection)
        Dim command As OleDbCommand
        Dim transaction As OleDbTransaction
        Dim datareader As OleDbDataReader
        Dim copies As Integer = 0

        connection.Open()

        transaction = connection.BeginTransaction
        Try
            command = New OleDbCommand
            command.Connection = connection
            command.Transaction = transaction

            command.CommandText = "SELECT Books.copies FROM Books WHERE bookID = '" + id.ToString + "'"
            datareader = command.ExecuteReader()
            datareader.Read()
            copies = datareader(0)
            datareader.Close()

            transaction.Commit()
        Catch ex As Exception
            transaction.Rollback()
            MsgBox(ex.Message)
        End Try
        connection.Close()
        Return copies
    End Function

    Private Function getDays(id)
        Dim connection As OleDbConnection = New OleDbConnection(Login.getConnection)
        Dim command As OleDbCommand
        Dim transaction As OleDbTransaction
        Dim datareader As OleDbDataReader
        Dim days As Integer

        connection.Open()

        transaction = connection.BeginTransaction
        Try
            command = New OleDbCommand
            command.Connection = connection
            command.Transaction = transaction

            command.CommandText = "SELECT returnCond FROM Books WHERE bookID = '" + id.ToString + "'"
            datareader = command.ExecuteReader()
            datareader.Read()
            days = datareader(0)
            datareader.Close()

            transaction.Commit()
        Catch ex As Exception
            transaction.Rollback()
            MsgBox(ex.Message)
        End Try
        connection.Close()
        Return days
    End Function

End Class