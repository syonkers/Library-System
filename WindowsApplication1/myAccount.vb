Imports System.Data.OleDb

Public Class myAccount

    Private Sub clearTextBox(ByVal root As Control)
        For Each cntrl As Control In root.Controls
            clearTextBox(cntrl)
            If TypeOf cntrl Is TextBox Then
                CType(cntrl, TextBox).Text = String.Empty
            End If
        Next cntrl
    End Sub

    Public Sub clearAccountData()
        clearTextBox(Me)
    End Sub

    Public Sub setAccessControl()
        If Login.getAccessLvl() = "user" Then
            accountLnk.Visible = True
            logoutLnk.Visible = True
            dueLnk.Visible = False
            addBookLnk.Visible = False
            UsersLnk.Visible = False
        ElseIf Login.getAccessLvl() = "employee" Then
            accountLnk.Visible = True
            logoutLnk.Visible = True
            UsersLnk.Visible = True
            addBookLnk.Visible = True
            dueLnk.Visible = True
        End If
    End Sub

    Private Sub logoutLnk_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles logoutLnk.LinkClicked
        Me.Hide()
        Login.logout()
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

    Private Sub bookLnk_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles bookLnk.LinkClicked
        Books.Show()
        Me.Hide()
    End Sub

    Private Sub homeLnk_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles homeLnk.LinkClicked
        Main.Show()
        Me.Hide()
    End Sub

    Public Sub updateStatus()
        Dim connection As OleDbConnection
        Dim cmd As OleDbCommand
        Dim trans As OleDbTransaction

        Dim bookID As Integer

        Dim rentDate As Date
        Dim currDate As Date
        Dim dueDate As Date
        currDate = Date.Today

        connection = New OleDbConnection(Login.getConnection())
        connection.Open()

        trans = connection.BeginTransaction
        Try
            cmd = New OleDbCommand
            cmd.Connection = connection
            cmd.Transaction = trans

            For i As Integer = 0 To Me.borrowGrid.Rows.Count - 1
                dueDate = Me.borrowGrid.Rows(i).Cells(1).Value
                If dueDate <> Nothing Then
                    bookID = Me.borrowGrid.Rows(i).Cells(4).Value.ToString
                    rentDate = Me.borrowGrid.Rows(i).Cells(0).Value.ToString
                    If currDate > dueDate Then
                        cmd.CommandText = "UPDATE Borrowed SET Borrowed.status = 'late' " + _
                                      "WHERE (Borrowed.bookID = '" + bookID.ToString + "') AND (Borrowed.userID = '" + Login.getID().ToString + "') AND (Borrowed.borrowDate = '" + rentDate.Date + "')"
                        cmd.ExecuteNonQuery()
                    End If
                End If
            Next
            trans.Commit()
        Catch ex As Exception
            trans.Rollback()
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub getInfo()
        Dim connection As OleDbConnection
        Dim cmd As OleDbCommand
        Dim trans As OleDbTransaction
        Dim datareader As OleDbDataReader

        connection = New OleDbConnection(Login.getConnection)
        connection.Open()

        trans = connection.BeginTransaction
        Try
            cmd = New OleDbCommand
            cmd.Connection = connection
            cmd.Transaction = trans

            cmd.CommandText = "SELECT email, Fname, Lname, schoolMajor, degreeProgram, street, city, province, postalCode, phoneNum, numBooks, role FROM Users WHERE userID = '" + Login.getID.ToString + "'"
            datareader = cmd.ExecuteReader()
            datareader.Read()

            emailBox.Text = datareader(0).ToString
            fnameBox.Text = datareader(1).ToString
            lnameBox.Text = datareader(2).ToString
            majorBox.Text = datareader(3).ToString
            degreeBox.Text = datareader(4).ToString
            addressBox.Text = datareader(5).ToString
            cityBox.Text = datareader(6).ToString
            provinceBox.Text = datareader(7).ToString
            zipBox.Text = datareader(8).ToString
            phoneBox.Text = datareader(9).ToString
            numBox.Text = datareader(10).ToString
            roleBox.Text = datareader(11).ToString
            datareader.Close()

            trans.Commit()
        Catch ex As Exception
            MsgBox(ex.Message)
            trans.Rollback()
        End Try
        connection.Close()
        getBooks()
        updateStatus()
        getHistory()

    End Sub

    Private Sub getHistory()
        Dim connection = New OleDbConnection(Login.getConnection)
        Dim dataAdapter As OleDbDataAdapter
        Dim trans As OleDbTransaction

        connection.Open()

        trans = connection.BeginTransaction
        Try
            Dim query As String = "SELECT distinct(Borrowed.borrowDate), Borrowed.returnDate,Books.title FROM Books, Borrowed, Users " & _
         "WHERE (Borrowed.userID = '" + Login.getID.ToString + "') and (Books.bookID = Borrowed.bookID) and (Borrowed.status = 'returned') "

            Dim command As OleDbCommand = New OleDbCommand(query, connection)
            command.CommandType = CommandType.Text
            command.Transaction = trans

            dataAdapter = New OleDbDataAdapter(command)
            Dim data As DataSet = New DataSet()
            dataAdapter.Fill(data)
            historyGrid.DataSource = data.Tables(0)
            trans.Commit()

        Catch ex As Exception
            MsgBox(ex.Message)
            trans.Rollback()
        End Try
        connection.Close()
    End Sub

    Public Sub getBooks()
        Dim connection = New OleDbConnection(Login.getConnection)
        Dim dataAdapter As OleDbDataAdapter
        Dim trans As OleDbTransaction

        connection.Open()

        trans = connection.BeginTransaction
        Try
            Dim query As String = "SELECT distinct(Borrowed.borrowDate), Borrowed.returnDate,Books.title, Borrowed.status, Books.bookID FROM Books, Borrowed, Users " & _
         "WHERE (Borrowed.userID = '" + Login.getID.ToString + "') AND (Books.bookID = Borrowed.bookID) AND (Borrowed.status = 'rented' OR Borrowed.status = 'late')"

            Dim command As OleDbCommand = New OleDbCommand(query, connection)
            command.CommandType = CommandType.Text
            command.Transaction = trans

            dataAdapter = New OleDbDataAdapter(command)
            Dim data As DataSet = New DataSet()
            dataAdapter.Fill(data)
            borrowGrid.DataSource = data.Tables(0)
            trans.Commit()

        Catch ex As Exception
            MsgBox(ex.Message)
            trans.Rollback()
        End Try
        connection.Close()

    End Sub

    Private Function getBookCopies(bookID)
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

            command.CommandText = "SELECT Books.copies FROM Books WHERE bookID = '" + BookID.ToString + "'"
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

    Private Sub returnBtn_Click(sender As Object, e As EventArgs) Handles returnBtn.Click
        Dim copies As Integer
        Dim bookID As Integer
        bookID = borrowGrid.CurrentRow.Cells(4).Value.ToString
        copies = getBookCopies(bookID)
        Dim newCopies As Integer = copies + 1
        Dim rentDate As String
        rentDate = borrowGrid.CurrentRow.Cells(0).Value.ToString

        Dim connection As OleDbConnection = New OleDbConnection(Login.getConnection)
        Dim command As OleDbCommand
        Dim transaction As OleDbTransaction

        connection.Open()

        transaction = connection.BeginTransaction
        Try
            command = New OleDbCommand
            command.Connection = connection
            command.Transaction = transaction

            command.CommandText = "UPDATE Books SET Books.copies = '" + newCopies.ToString + "' WHERE (bookID = '" + bookID.ToString + "')"
            command.ExecuteNonQuery()

            command.CommandText = "UPDATE Borrowed SET Borrowed.status = 'returned' " + _
                                  "WHERE (bookID = '" + bookID.ToString + "') AND (Borrowed.userID = '" + Login.getID().ToString + "') AND (Borrowed.borrowDate = '" + rentDate.ToString + "')"
            command.ExecuteNonQuery()
            transaction.Commit()
            MsgBox("Sucessfully returned book")
        Catch ex As Exception
            transaction.Rollback()
            MsgBox(ex.Message)
        End Try
        connection.Close()
        getBooks()
        getHistory()
    End Sub
End Class