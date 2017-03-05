Imports System.Data.OleDb

Public Class addUser

    Private datareader As OleDbDataReader

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

            command1.CommandText = "SELECT MAX(userID) from Users"
            datareader = command1.ExecuteReader()
            datareader.Read()
            newID = datareader(0) + 1
            datareader.Close()

            command2.CommandText = "INSERT INTO Users(userID,email,password,Fname,Lname,schoolMajor,degreeProgram,street,city,province,postalCode,phoneNum,numBooks,role) Values (?,?,?,?,?,?,?,?,?,?,?,?,?,?)"
            command2.Parameters.AddWithValue("userID", newID.ToString)
            command2.Parameters.AddWithValue("email", usernameBox.Text)
            command2.Parameters.AddWithValue("password", passwordBox.Text)
            command2.Parameters.AddWithValue("Fname", fnameBox.Text)
            command2.Parameters.AddWithValue("Lname", lnameBox.Text)
            command2.Parameters.AddWithValue("schoolMajor", majorBox.Text)
            command2.Parameters.AddWithValue("degreeProgram", degreeBox.Text)
            command2.Parameters.AddWithValue("street", addressBox.Text)
            command2.Parameters.AddWithValue("city", cityBox.Text)
            command2.Parameters.AddWithValue("province", provinceBox.Text)
            command2.Parameters.AddWithValue("postalCode", zipBox.Text)
            command2.Parameters.AddWithValue("phoneNum", phoneBox.Text)
            command2.Parameters.AddWithValue("numBooks", numBox.Text)
            command2.Parameters.AddWithValue("role", roleBox.Text)
            command2.ExecuteNonQuery()

            mytransaction1.Commit()
            mytransaction2.Commit()
            MsgBox("New user added")
            Dim txt As Control
            For Each txt In Controls
                If TypeOf txt Is TextBox Then
                    txt.Text = ""
                End If
            Next
            Users.UsersTableAdapter.Fill(Users.LibrarySystemDataSet.Users)
            Me.Hide()
        Catch ex As Exception
            mytransaction1.Rollback()
            mytransaction2.Rollback()
            MsgBox(ex.Message)
        End Try
        connection1.Close()
        connection2.Close()
    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        Dim txt As Control
        For Each txt In Controls
            If TypeOf txt Is TextBox Then
                txt.Text = ""
            End If
        Next
    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Me.Hide()
    End Sub

    Private Sub addUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        roleBox.SelectedIndex = 0
    End Sub
End Class