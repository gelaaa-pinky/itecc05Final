Imports MySql.Data.MySqlClient
Public Class Button_Load_Table
    Dim conn As MySqlConnection
    Dim command As MySqlCommand
    Private Sub SAVE_Click(sender As Object, e As EventArgs) Handles SAVE.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=edata"
        Dim reader As MySqlDataReader

        Try
            conn.Open()
            Dim query As String
            query = "insert into edata.user (ID, Name, Surname, Age) values ('" & IDTextBox1.Text & "','" & NameTextBox2.Text & "' ,'" & SurnameTextBox3.Text & "' ,'" & AgeTextBox4.Text & "')  "
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            Dim count As Integer


            MessageBox.Show("Data SAVED !!")


            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()

        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_Table()

        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=edata"
        Dim reader As MySqlDataReader


        Try
            conn.Open()
            Dim query As String
            query = "SELECT * FROM edata.user"
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader

            While reader.Read
                Dim sName = reader.GetString("Name")
                ComboBox1.Items.Add(sName)
                ListBox1.Items.Add(sName)
            End While

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()

        Finally
            conn.Dispose()
        End Try
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=edata"
        Dim reader As MySqlDataReader

        Try
            conn.Open()
            Dim query As String
            query = "update edata.user set ID='" & IDTextBox1.Text & "', Name='" & NameTextBox2.Text & "' ,Surname='" & SurnameTextBox3.Text & "' ,Age='" & AgeTextBox4.Text & "'where ID= '" & IDTextBox1.Text & "' "
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            Dim count As Integer


            MessageBox.Show("Data UPDATED!!")


            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()

        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=edata"
        Dim reader As MySqlDataReader

        Try
            conn.Open()
            Dim query As String
            query = "Delete from edata.user where ID= '" & IDTextBox1.Text & " ' "
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            Dim count As Integer


            MessageBox.Show("Data  DELETED!!")


            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()

        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=edata"
        Dim reader As MySqlDataReader


        Try
            conn.Open()
            Dim query As String
            query = "SELECT * FROM edata.user where Name= '" & ListBox1.Text & " ' "
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader


            While reader.Read
                IDTextBox1.Text = reader.GetInt32("ID")
                NameTextBox2.Text = reader.GetString("Name")
                SurnameTextBox3.Text = reader.GetString("Surname")
                AgeTextBox4.Text = reader.GetString("Age")
            End While

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()

        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub load_Table()
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=edata"
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource
        Try
            conn.Open()
            Dim Query As String
            Query = "select ID, Name, Surname, Age from edata.user"
            command = New MySqlCommand(Query, conn)
            SDA.SelectCommand = command
            SDA.Fill(dbDataSet)
            DataGridView1.DataSource = bSource
            SDA.Update(dbDataSet)

            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()

        End Try

    End Sub
    Private Sub Button_Load_Table_Click(sender As Object, e As EventArgs) Handles Button4.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=edata"
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource
        Try
            conn.Open()
            Dim Query As String
            Query = "select ID, Name, Surname, Age from edata.user"
            command = New MySqlCommand(Query, conn)
            SDA.SelectCommand = command
            SDA.Fill(dbDataSet)
            DataGridView1.DataSource = bSource
            SDA.Update(dbDataSet)

            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()

        End Try

    End Sub
End Class