Imports System.Data.OleDb

Public Class addPublisher

    Private datareader As OleDbDataReader

    Private Sub clearFields()
        Dim txt As Control
        For Each txt In Controls
            If TypeOf txt Is TextBox Then
                txt.Text = ""
            End If
        Next
    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        clearFields()
    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        clearFields()
        Me.Hide()
    End Sub

    Private Sub submitBtn_Click(sender As Object, e As EventArgs) Handles submitBtn.Click
        If fnameBox.Text.Length = 0 Then
            MsgBox("Please enter a valid name")
            Return
        End If
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

            command1.CommandText = "SELECT MAX(pubID) from Publisher"
            datareader = command1.ExecuteReader()
            datareader.Read()
            newID = datareader(0) + 1
            datareader.Close()

            command2.CommandText = "INSERT INTO Publisher(pubID,name,country) Values (?,?,?)"
            command2.Parameters.AddWithValue("authorID", newID.ToString)
            command2.Parameters.AddWithValue("name", fnameBox.Text)
            command2.Parameters.AddWithValue("country", countryBox.Text)
            command2.ExecuteNonQuery()
            mytransaction1.Commit()
            mytransaction2.Commit()
            MsgBox("New publisher added")
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
        addBook.getPublishers()
    End Sub

    Private Sub addPublisher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        countryBox.SelectedIndex = 0
    End Sub
End Class