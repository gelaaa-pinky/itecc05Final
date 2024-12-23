Imports MySql.Data.MySqlClient

Public Class Form1
    Dim conn As MySqlConnection
    Dim command As MySqlCommand
    Public Property Form2 As Object

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        Dim conn = New MySqlConnection
        conn.ConnectionString = "Server=localhost;userid=root;password='';database=edata"

        Try
            conn.Open()
            MessageBox.Show("Connection to MySQL test database was successful!!!!", "TESTING      CONNECTION TO MySQL DATABASE")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Function GetConn() As MySqlConnection
        Return conn
    End Function

    Private Sub ClickLog_Click(sender As Object, e As EventArgs) Handles clickLog.Click
        Dim conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=edata"
        Dim reader As MySqlDataReader

        Try
            conn.Open()
            Dim query As String
            query = "SELECT * FROM account WHERE username = '" & TextBox_UN.Text & "' and password = '" & TextBox_Pass.Text & "'"
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            Dim count As Integer

            count = 0
            While reader.Read
                count = count + 1
            End While

            If count = 1 Then
                MessageBox.Show("Username and Password are correct")
                Form2.Show()
                Me.Hide()
            ElseIf count > 1 Then
                MessageBox.Show("Username and Password are duplicate")

            Else
                MessageBox.Show("Username and Password are incorrect")
            End If

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class