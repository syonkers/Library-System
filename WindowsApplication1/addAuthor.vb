Imports System.Data.OleDb

Public Class addAuthor

    Private datareader As OleDbDataReader

    Private Sub clearFields()
        Dim txt As Control
        For Each txt In Controls
            If TypeOf txt Is TextBox Then
                txt.Text = ""
            End If
        Next
    End Sub

    Private Sub submitBtn_Click(sender As Object, e As EventArgs) Handles submitBtn.Click
        Dim newID As Integer
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

            command1.CommandText = "SELECT MAX(authorID) from Authors"
            datareader = command1.ExecuteReader()
            datareader.Read()
            newID = datareader(0) + 1
            datareader.Close()

            command2.CommandText = "INSERT INTO Authors(authorID,Fname,Lname,email) Values (?,?,?,?)"
            command2.Parameters.AddWithValue("authorID", newID.ToString)
            command2.Parameters.AddWithValue("Fname", fnameBox.Text)
            command2.Parameters.AddWithValue("Lname", lnameBox.Text)
            command2.Parameters.AddWithValue("email", emailBox.Text)
            command2.ExecuteNonQuery()

            mytransaction1.Commit()
            mytransaction2.Commit()
            MsgBox("New author added")
            clearFields()
            Me.Hide()
        Catch ex As Exception
            clearFields()
            mytransaction1.Rollback()
            mytransaction2.Rollback()
            MsgBox(ex.Message)
        End Try
        connection1.Close()
        connection2.Close()
        addBook.getAuthors()
    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        clearFields()
    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        clearFields()
        Me.Hide()
    End Sub
End Class