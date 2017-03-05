Imports System.Data.OleDb

Public Class addBook

    Private datareader As OleDbDataReader

    Private Sub homeLnk_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles homeLnk.LinkClicked
        Main.Show()
        Me.Hide()
    End Sub

    Private Sub bookLnk_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles bookLnk.LinkClicked
        Books.Show()
        Books.fillTable()
        Me.Hide()
    End Sub

    Private Sub dueLnk_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles dueLnk.LinkClicked
        Late.Show()
        Me.Hide()
    End Sub

    Private Sub addBookLnk_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles addBookLnk.LinkClicked
        Me.ResetText()
    End Sub

    Private Sub UsersLnk_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles UsersLnk.LinkClicked
        Users.Show()
        Me.Hide()
    End Sub

    Private Sub accountLnk_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles accountLnk.LinkClicked
        myAccount.Show()
        Me.Hide()
    End Sub

    Private Sub logoutLnk_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles logoutLnk.LinkClicked
        Me.Close()
        Login.logout()
    End Sub

    Private Sub addNew()
        Dim requirements As Boolean = False
        requirements = checkRequirements()
        If requirements = False Then
            Exit Sub
        End If
        Dim bookID As Integer
        Dim pubID As Integer
        Dim authorID As Integer
        Dim connection1, connection2 As OleDbConnection
        Dim command1, command2 As OleDbCommand
        Dim mytransaction1, mytransaction2 As OleDbTransaction

        Dim ConnectionString As String = Login.getConnection
        connection1 = New OleDbConnection(ConnectionString)
        connection2 = New OleDbConnection(ConnectionString)

        connection1.Open()
        connection2.Open()

        mytransaction1 = connection1.BeginTransaction()
        mytransaction2 = connection2.BeginTransaction()
        Try
            command1 = New OleDbCommand
            command1.Connection = connection1
            command1.Transaction = mytransaction1

            command2 = New OleDbCommand
            command2.Connection = connection2
            command2.Transaction = mytransaction2

            command1.CommandText = "SELECT MAX(bookID) from Books"
            datareader = command1.ExecuteReader()
            datareader.Read()
            bookID = datareader(0) + 1
            datareader.Close()

            pubID = addedPublishers.Rows(0).Cells(0).Value.ToString
            command2.CommandText = "INSERT INTO Books(bookID,ISBN,year,pubID,title,genre,edition,description,returnCond,copies) Values ('" + bookID.ToString + "','" + ISBNBox.Text.ToString + "','" + yearBox.Text.ToString + "','" + pubID.ToString + "','" + titleBox.Text.ToString + "','" + genreBox.Text.ToString + "','" + editionBox.Text.ToString + "','" + descBox.Text.ToString + "','" + dueBox.Text.ToString + "','" + copyBox.Text.ToString + "')"
            command2.ExecuteNonQuery()

            For Each auth As DataGridViewRow In addedAuthors.Rows
                authorID = auth.Cells(0).Value.ToString
                command2.CommandText = "INSERT INTO Wrote(bookID, authorID) VALUES (?,?)"
                command2.Parameters.AddWithValue("bookID", bookID.ToString)
                command2.Parameters.AddWithValue("authorID", authorID.ToString)
                command2.ExecuteNonQuery()
            Next
            mytransaction1.Commit()
            mytransaction2.Commit()
            MsgBox("New book added")
        Catch ex As Exception
            mytransaction1.Rollback()
            mytransaction2.Rollback()
            MsgBox(ex.Message)
        End Try
        connection1.Close()
        connection2.Close()
    End Sub

    Private Sub addBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getAuthors()
        getPublishers()
        genreBox.SelectedIndex = 0
    End Sub

    Public Sub getAuthors()
        Dim connection = New OleDbConnection(Login.getConnection)
        Dim dataAdapter As OleDbDataAdapter
        Dim trans As OleDbTransaction

        connection.Open()

        trans = connection.BeginTransaction
        Try
            Dim query As String = "SELECT * FROM Authors"

            Dim command As OleDbCommand = New OleDbCommand(query, connection)
            command.CommandType = CommandType.Text
            command.Transaction = trans

            dataAdapter = New OleDbDataAdapter(command)
            Dim data As DataSet = New DataSet()
            dataAdapter.Fill(data)
            authData.DataSource = data.Tables(0)
            trans.Commit()

        Catch ex As Exception
            MsgBox(ex.Message)
            trans.Rollback()
        End Try
        connection.Close()

    End Sub

    Public Sub getPublishers()
        Dim connection = New OleDbConnection(Login.getConnection)
        Dim dataAdapter As OleDbDataAdapter
        Dim trans As OleDbTransaction

        connection.Open()

        trans = connection.BeginTransaction
        Try
            Dim query As String = "SELECT * FROM Publisher"

            Dim command As OleDbCommand = New OleDbCommand(query, connection)
            command.CommandType = CommandType.Text
            command.Transaction = trans

            dataAdapter = New OleDbDataAdapter(command)
            Dim data As DataSet = New DataSet()
            dataAdapter.Fill(data)
            pubData.DataSource = data.Tables(0)
            trans.Commit()

        Catch ex As Exception
            MsgBox(ex.Message)
            trans.Rollback()
        End Try
        connection.Close()

    End Sub

    Private Function checkRequirements()
        If titleBox.Text.Length = 0 Then
            MsgBox("Please enter a valid title")
            Return False
        End If
        If ISBNBox.Text.Length = 0 Then
            MsgBox("Please enter a valid ISBN")
            Return False
        End If
        If dueBox.Text.Length = 0 And IsNumeric(dueBox) Then
            MsgBox("Please enter a valid number of days to return")
            Return False
        End If
        If copyBox.Text.Length = 0 And IsNumeric(copyBox) Then
            MsgBox("Please enter a valid number of copies")
            Return False
        End If
        If addedPublishers.Rows.Count > 1 Then
            MsgBox("Can only have one publisher per book")
            Return False
        End If
        If genreBox.SelectedIndex = 0 Then
            MsgBox("Please select a genre")
            Return False
        End If
        Return True
    End Function

    Private Sub clearTextBox(ByVal root As Control)
        For Each cntrl As Control In root.Controls
            clearTextBox(cntrl)
            If TypeOf cntrl Is TextBox Then
                CType(cntrl, TextBox).Text = String.Empty
            End If
        Next cntrl
    End Sub

    Private Sub addBookBtn_Click(sender As Object, e As EventArgs) Handles addBookBtn.Click
        addNew()
    End Sub

    Private Sub addAuthBtn_Click(sender As Object, e As EventArgs) Handles addAuthBtn.Click
        If authData.Rows.Count > 0 Then
            addedAuthors.Rows.Add(authData.CurrentRow.Cells(0).Value, authData.CurrentRow.Cells(1).Value, authData.CurrentRow.Cells(2).Value, authData.CurrentRow.Cells(3).Value)
        End If
    End Sub

    Private Sub remBtn_Click(sender As Object, e As EventArgs) Handles remBtn.Click
        If addedAuthors.Rows.Count > 0 Then
            addedAuthors.Rows.Remove(addedAuthors.CurrentRow)
        End If

    End Sub

    Private Sub newAuthBox_Click(sender As Object, e As EventArgs) Handles newAuthBox.Click
        addAuthor.Show()
    End Sub

    Private Sub addPubBtn_Click(sender As Object, e As EventArgs) Handles addPubBtn.Click
        If pubData.Rows.Count > 0 Then
            addedPublishers.Rows.Add(pubData.CurrentRow.Cells(0).Value, pubData.CurrentRow.Cells(1).Value, pubData.CurrentRow.Cells(2).Value)
        End If
    End Sub

    Private Sub remPubBtn_Click(sender As Object, e As EventArgs) Handles remPubBtn.Click
        If addedPublishers.Rows.Count > 0 Then
            addedPublishers.Rows.Remove(addedPublishers.CurrentRow)
        End If
    End Sub

    Private Sub newPubBtn_Click(sender As Object, e As EventArgs) Handles newPubBtn.Click
        addPublisher.Show()
    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        clearTextBox(Me)
    End Sub
End Class