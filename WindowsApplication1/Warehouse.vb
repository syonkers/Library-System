Imports System.Data.OleDb

Public Class Warehouse

    Private Shared Function getWarehouseConnection() As String
        Return "Provider=SQLOLEDB;Data Source=" & _
             "(local);Initial Catalog=LibraryWarehouse;Integrated Security=SSPI"
    End Function

    Private Sub dateCheck_CheckedChanged(sender As Object, e As EventArgs) Handles dateCheck.CheckedChanged
        If dateCheck.Checked Then
            fromLbl.Show()
            fromCalender.Show()
            toCalender.Show()
            toLbl.Show()
        Else
            fromCalender.Hide()
            fromLbl.Hide()
            toCalender.Hide()
            toLbl.Hide()
            allCheck.Checked = False
        End If
    End Sub

    Private Sub pubCheck_CheckedChanged(sender As Object, e As EventArgs) Handles pubCheck.CheckedChanged
        If pubCheck.Checked Then
            pubLbl.Show()
            nameCombo.Show()
            nameLbl.Show()
            countryCombo.Show()
            countryLbl.Show()
            countryCombo.SelectedIndex = 0
            nameCombo.SelectedIndex = 0
        Else
            pubLbl.Hide()
            nameCombo.Hide()
            nameLbl.Hide()
            countryCombo.Hide()
            countryLbl.Hide()
            allCheck.Checked = False
        End If
    End Sub

    Private Sub genreCheck_CheckedChanged(sender As Object, e As EventArgs) Handles genreCheck.CheckedChanged
        If genreCheck.Checked Then
            genreCombo.Show()
            genreLbl.Show()
            genreCombo.SelectedIndex = 0
        Else
            genreCombo.Hide()
            genreLbl.Hide()
            allCheck.Checked = False
        End If
    End Sub

    Private Sub allCheck_CheckedChanged(sender As Object, e As EventArgs) Handles allCheck.CheckedChanged
        If allCheck.Checked Then
            genreCheck.Checked = True
            pubCheck.Checked = True
            dateCheck.Checked = True
        End If
    End Sub

    Private Sub backLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles backLink.LinkClicked
        Main.Show()
        Me.Hide()
    End Sub

    Public Sub updateWarehouse()
        fillTimeTable()
        fillBooksTable()
        fillPublisherTable()
        fillMainTable()
        fillNameCombo()
    End Sub

    Public Sub fillNameCombo()
        Dim connection As OleDbConnection = New OleDbConnection(getWarehouseConnection())
        Dim transaction As OleDbTransaction
        Dim command As OleDbCommand = New OleDbCommand
        Dim ds As DataSet = New DataSet
        Dim datadapter As OleDbDataAdapter = New OleDbDataAdapter

        connection.Open()
        transaction = connection.BeginTransaction
        command.Connection = connection
        command.Transaction = transaction

        Try
            command.CommandText = "SELECT publisher from wPublisher"
            datadapter.SelectCommand = command
            datadapter.Fill(ds)
            datadapter.Dispose()
            command.Dispose()
            nameCombo.DataSource = ds.Tables(0)
            nameCombo.ValueMember = "publisher"
            nameCombo.DisplayMember = "publisher"
            transaction.Commit()
        Catch ex As Exception
            transaction.Rollback()
            MsgBox(ex.Message)
        End Try
        connection.Close()
    End Sub

    Private Sub fillTimeTable()
        Dim oldest As Date
        Dim currDate = Date.Today
        Dim oldestID As Integer

        Dim connection As OleDbConnection = New OleDbConnection(getWarehouseConnection())
        Dim transaction As OleDbTransaction
        Dim myReader, myReader2 As OleDbDataReader
        Dim command As OleDbCommand

        connection.Open()
        transaction = connection.BeginTransaction()
        command = New OleDbCommand
        command.Connection = connection
        command.Transaction = transaction

        Try
            command.CommandText = "SELECT Max(timeID) FROM wTime"
            myReader = command.ExecuteReader()
            myReader.Read()
            oldestID = myReader(0)
            myReader.Close()
            command.CommandText = "SELECT theDate FROM wTime WHERE (wTime.timeID = '" + oldestID.ToString + "')"
            myReader2 = command.ExecuteReader()
            myReader2.Read()
            oldest = myReader2(0)
            myReader2.Close()
            While oldest.Date <> currDate.Date
                oldestID = oldestID + 1
                oldest = oldest.AddDays(1)
                command.CommandText = "INSERT INTO wTime(timeID,theDate) Values ('" + oldestID.ToString + "','" + oldest.Date + "')"
                command.ExecuteNonQuery()
            End While
            transaction.Commit()
        Catch ex As Exception
            transaction.Rollback()
            MsgBox(ex.Message)
        End Try
        connection.Close()
    End Sub

    Private Sub fillBooksTable()
        Dim currID As Integer
        Dim connection As OleDbConnection = New OleDbConnection(getWarehouseConnection())
        Dim transaction As OleDbTransaction
        Dim myReader As OleDbDataReader
        Dim command As OleDbCommand

        connection.Open()
        transaction = connection.BeginTransaction()
        command = New OleDbCommand
        command.Connection = connection
        command.Transaction = transaction

        Try
            command.CommandText = "SELECT max(bookID) from wBooks"
            myReader = command.ExecuteReader()
            myReader.Read()
            currID = myReader(0)
            currID = currID + 1
            myReader.Close()
            command.CommandText = "INSERT INTO wBooks(bookID,name,genre) SELECT Books.bookID, Books.title, Books.genre FROM LibrarySystem.dbo.Books WHERE (Books.bookID >= '" + currID.ToString + "')"
            command.ExecuteNonQuery()
            transaction.Commit()
        Catch ex As Exception
            transaction.Rollback()
            MsgBox(ex.Message)
        End Try
        connection.Close()
    End Sub


    Private Sub fillPublisherTable()
        Dim currID As Integer
        Dim connection As OleDbConnection = New OleDbConnection(getWarehouseConnection())
        Dim transaction As OleDbTransaction
        Dim myReader As OleDbDataReader
        Dim command As OleDbCommand

        connection.Open()
        transaction = connection.BeginTransaction()
        command = New OleDbCommand
        command.Connection = connection
        command.Transaction = transaction

        Try
            command.CommandText = "SELECT max(publisherID) from wPublisher"
            myReader = command.ExecuteReader()
            myReader.Read()
            currID = myReader(0)
            currID = currID + 1
            myReader.Close()
            command.CommandText = "INSERT INTO wPublisher(publisherID,publisher,country) SELECT Publisher.pubID, Publisher.name, Publisher.country FROM LibrarySystem.dbo.Publisher WHERE (Publisher.pubID >= '" + currID.ToString + "')"
            command.ExecuteNonQuery()
            transaction.Commit()
        Catch ex As Exception
            transaction.Rollback()
            MsgBox(ex.Message)
        End Try
        connection.Close()
    End Sub

    Private Sub fillMainTable()
        Dim currID As Integer
        Dim currDate As Date
        Dim tempTimeID As String
        Dim borrowDate As Date
        Dim connection As OleDbConnection = New OleDbConnection(getWarehouseConnection())
        Dim transaction As OleDbTransaction
        Dim myReader, myReader2 As OleDbDataReader
        Dim command As OleDbCommand

        connection.Open()
        transaction = connection.BeginTransaction()
        command = New OleDbCommand
        command.Connection = connection
        command.Transaction = transaction

        Try
            command.CommandText = "SELECT max(mainID) from wMain"
            myReader = command.ExecuteReader()
            myReader.Read()
            currID = myReader(0)
            myReader.Close()
            command.CommandText = "SELECT theDate FROM wTime,wMain WHERE (wTime.timeID = wMain.timeID) AND (wMain.mainID = '" + currID.ToString + "')"
            myReader2 = command.ExecuteReader
            myReader2.Read()
            currDate = myReader2(0)
            myReader2.Close()
            getLibraryInfo(currDate.Date)
            For i As Integer = 0 To Me.tempGrid.Rows.Count - 1
                borrowDate = Me.tempGrid.Rows(i).Cells(0).Value
                If borrowDate <> Nothing Then
                    command.CommandText = "SELECT wTime.timeID FROM wTime WHERE (wTime.theDate = '" + Me.tempGrid.Rows(i).Cells(0).Value + "')"
                    tempTimeID = command.ExecuteScalar()
                    currID = currID + 1
                    command.CommandText = "INSERT INTO wMain(mainID,bookID,publisherID,timeID) VALUES ('" + currID.ToString + "','" + Me.tempGrid.Rows(i).Cells(1).Value.ToString + "','" + Me.tempGrid.Rows(i).Cells(2).Value.ToString + "','" + tempTimeID.ToString + "')"
                    command.ExecuteNonQuery()
                End If
            Next
            transaction.Commit()
        Catch ex As Exception
            transaction.Rollback()
            MsgBox(ex.Message)
        End Try
        connection.Close()
    End Sub

    Public Sub getLastDate()
        Dim oldestID As Integer
        Dim oldest As Date
        Dim connection As OleDbConnection = New OleDbConnection(getWarehouseConnection())
        Dim transaction As OleDbTransaction
        Dim myReader, myReader2 As OleDbDataReader
        Dim command As OleDbCommand

        connection.Open()
        transaction = connection.BeginTransaction()
        command = New OleDbCommand
        command.Connection = connection
        command.Transaction = transaction

        Try
            command.CommandText = "SELECT Max(timeID) FROM wTime"
            myReader = command.ExecuteReader()
            myReader.Read()
            oldestID = myReader(0)
            myReader.Close()
            command.CommandText = "SELECT theDate FROM wTime WHERE (wTime.timeID = '" + oldestID.ToString + "')"
            myReader2 = command.ExecuteReader()
            myReader2.Read()
            oldest = myReader2(0)
            myReader2.Close()
            dateLbl.Text = oldest.Date
        Catch ex As Exception
            transaction.Rollback()
            MsgBox(ex.Message)
        End Try
        connection.Close()

    End Sub

    Private Sub getLibraryInfo(currDate As Date)
        Dim connection As OleDbConnection = New OleDbConnection(Login.getConnection())
        Dim myTransaction As OleDbTransaction
        Dim command As OleDbCommand
        Dim table As DataTable
        connection.Open()

        myTransaction = connection.BeginTransaction
        command = New OleDbCommand
        command.Connection = connection
        command.Transaction = myTransaction

        Try
            command.CommandText = "SELECT Borrowed.borrowDate, Borrowed.bookID, Books.pubID FROM Borrowed, Books WHERE (Borrowed.bookID = Books.bookID) AND (Borrowed.borrowDate > '" + currDate.Date + "')"
            table = New DataTable
            Using datadapter As New OleDbDataAdapter(command)
                datadapter.Fill(table)
            End Using
            tempGrid.DataSource = New BindingSource(table, Nothing)
            myTransaction.Commit()
        Catch ex As Exception
            MsgBox(ex.Message)
            myTransaction.Rollback()
        End Try
        connection.Close()
    End Sub

    Private Function getFromString()
        Dim query As String = "FROM wMain, "
        If (dateCheck.Checked = False And pubCheck.Checked = False And genreCheck.Checked = False) Then
            query = "FROM wMain"
            Return query
        End If
        If dateCheck.Checked = True And (genreCheck.Checked = True Or pubCheck.Checked = True) Then
            query = query + "wTime, "
        ElseIf dateCheck.Checked = True Then
            query = query + "wTime "
        End If

        If genreCheck.Checked = True And pubCheck.Checked = True Then
            query = query + "wBooks, "
        ElseIf genreCheck.Checked = True And pubCheck.Checked = False Then
            query = query + "wBooks "
        End If

        If pubCheck.Checked = True Then
            query = query + "wPublisher "
        End If
        Return query
    End Function

    Private Function getWhereString()
        Dim query As String = "WHERE "
        query = getJoins(query)

        If (dateCheck.Checked = False And pubCheck.Checked = False And genreCheck.Checked = False) Then
            query = ""
            Return query
        End If
        If dateCheck.Checked = True And pubCheck.Checked = False And genreCheck.Checked = False Then
            Dim fromDate As Date = getFromCalender()
            Dim toDate As Date = getToCalender()
            query = query + "(wTime.theDate >= '" + fromDate.Date + "') AND (wTime.theDate <= '" + toDate.Date + "')"
        ElseIf dateCheck.Checked = True And (pubCheck.Checked = True Or genreCheck.Checked = True) Then
            Dim fromDate As Date = getFromCalender()
            Dim toDate As Date = getToCalender()
            query = query + "(wTime.theDate >= '" + fromDate.Date + "') AND (wTime.theDate <= '" + toDate.Date + "') AND "
        End If


        If genreCheck.Checked = True And pubCheck.Checked = False Then
            query = query + "(wBooks.genre = '" + genreCombo.Text + "')"
        ElseIf genreCheck.Checked = True And pubCheck.Checked = True Then
            query = query + "(wBooks.genre = '" + genreCombo.Text + "') AND "
        End If


        If pubCheck.Checked = True Then
            If nameCombo.SelectedIndex <> 0 And countryCombo.SelectedIndex = 0 Then
                query = query + "(wPublisher.publisher = '" + nameCombo.Text + "')"
            ElseIf nameCombo.SelectedIndex = 0 And countryCombo.SelectedIndex <> 0 Then
                query = query + "(wPublisher.country = '" + countryCombo.Text + "')"
            Else
                query = query + "(wPublisher.country = '" + countryCombo.Text + "') AND (wPublisher.publisher = '" + nameCombo.SelectedValue.ToString + "')"
            End If
        End If


        Return query
    End Function

    Private Function getJoins(query As String)
        If dateCheck.Checked = True And pubCheck.Checked = False And genreCheck.Checked = False Then
            query = query + "(wMain.timeID = wTime.timeID) AND "
        ElseIf dateCheck.Checked = True And (pubCheck.Checked = True Or genreCheck.Checked = True) Then
            query = query + "(wMain.timeID = wTime.timeID) AND "
        End If
        If genreCheck.Checked = True And pubCheck.Checked = False Then
            query = query + "(wMain.bookID = wBooks.bookID) AND "
        ElseIf genreCheck.Checked = True And pubCheck.Checked = True Then
            query = query + "(wMain.bookID = wBooks.bookID) AND "
        End If
        If pubCheck.Checked = True Then
            query = query + "(wMain.publisherID = wPublisher.publisherID) AND "
        End If
        Return query
    End Function

    Private Function getFromCalender()
        Dim fromDate As Date
        fromDate = fromCalender.Value.Year.ToString + "/" + fromCalender.Value.Month.ToString + "/" + fromCalender.Value.Day.ToString
        Return fromDate
    End Function

    Private Function getToCalender()
        Dim toDate As Date
        toDate = toCalender.Value.Year.ToString + "/" + toCalender.Value.Month.ToString + "/" + toCalender.Value.Day.ToString
        Return toDate
    End Function

    Private Sub searchBtn_Click(sender As Object, e As EventArgs) Handles searchBtn.Click
        Dim connection As OleDbConnection = New OleDbConnection(getWarehouseConnection())
        Dim command As New OleDbCommand
        Dim transaction As OleDbTransaction

        connection.Open()
        transaction = connection.BeginTransaction()
        command.Connection = connection
        command.Transaction = transaction

        Try
            If genreCheck.Checked And genreCombo.SelectedIndex = 0 Then
                MsgBox("Please select a specific genre or unselect the genre box at the top of the window")
                Exit Sub
            End If
            If pubCheck.Checked And nameCombo.SelectedIndex = 0 And countryCombo.SelectedIndex = 0 Then
                MsgBox("Please specify a publisher name/country or unselect the publisher box at the topof the window")
                Exit Sub
            End If
            Dim query As String = "SELECT count(*) "
            query = query + getFromString() + getWhereString()
            command.CommandText = query
            Dim count As Integer = command.ExecuteScalar()
            resultsLbl.Text = count
            transaction.Commit()
        Catch ex As Exception
            transaction.Rollback()
            MsgBox(ex.Message)
        End Try
        connection.Close()
    End Sub

    Private Sub updateBtn_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles updateBtn.LinkClicked
        updateWarehouse()
    End Sub
End Class