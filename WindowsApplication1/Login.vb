Imports System.Data.OleDb

Public Class Login

    Private datareader As OleDbDataReader
    Private connection As OleDbConnection = New OleDbConnection(getConnection())

    Public loggedID As Integer
    Public accessLvl As String = "NULL"
    Public username As String

    Public Shared Function getConnection() As String
        Return "Provider=SQLOLEDB;Data Source=" & _
             "(local);Initial Catalog=LibrarySystem;Integrated Security=SSPI"
    End Function

    Public Function getAccessLvl() As String
        Return accessLvl
    End Function

    Public Function getID() As Integer
        Return loggedID
    End Function

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        Dim loginSuccess As Boolean = False
        Dim mytransaction As OleDbTransaction
        Dim command As OleDbCommand

        If usernameBox.Text.Length = 0 Then
            MsgBox("Please enter a valid email")
            Return
        End If

        If passwordBox.Text.Length = 0 Then
            MsgBox("Please enter a password")
            Return
        End If

        connection.Open()
        mytransaction = connection.BeginTransaction()
        command = New OleDbCommand
        command.Connection = connection
        command.Transaction = mytransaction

        Try
            command.CommandText = "SELECT UserID, email, password, role FROM Users WHERE email = '" + usernameBox.Text + "'"
            datareader = command.ExecuteReader()

            datareader.Read()
            If passwordBox.Text = datareader(2).ToString Then
                username = datareader(1).ToString
                loginSuccess = True
                accessLvl = datareader(3).ToString
                loggedID = datareader(0).ToString
            Else
                MsgBox("Incorrect Username or Password")
            End If
            mytransaction.Commit()
        Catch ex As Exception
            mytransaction.Rollback()
            MsgBox("Account does not exist")
        Finally
            datareader.Close()
            connection.Close()
        End Try

        If loginSuccess Then
            Books.setAccessControl()
            Main.setAccessControl()
            myAccount.setAccessControl()
            myAccount.getInfo()
            Me.Hide()
        End If
    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        usernameBox.Text = Nothing
        passwordBox.Text = Nothing
        Me.Hide()
    End Sub

    Public Sub logout()
        usernameBox.Text = Nothing
        passwordBox.Text = Nothing
        accessLvl = "NULL"
        loggedID = -1
        username = Nothing
        Books.setAccessControl()
        Main.setAccessControl()
        myAccount.clearAccountData()
        Main.Show()
    End Sub

End Class
