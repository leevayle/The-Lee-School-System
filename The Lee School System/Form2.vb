
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status
Imports System.Data.OleDb

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Specify your MS Access database file path
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\lee school.accdb;Jet OLEDB:Database Password=A1B2C3;"

        ' Specify the table name
        Dim tableName As String = "[admins]"

        ' Create a connection to the MS Access database
        Using connection As New OleDbConnection(connectionString)
            ' Open the database connection
            connection.Open()

            ' Create a command to retrieve the total count of entries
            Dim commandText As String = $"SELECT COUNT(*) FROM {tableName}"
            Using command As New OleDbCommand(commandText, connection)
                ' Execute the command and get the total count
                Dim totalEntries As Integer = CInt(command.ExecuteScalar())

                ' Update the Label control's text with the total count
                Label12.Text = $"{totalEntries}"
            End Using
        End Using


        'table 2
        ' Specify the table name
        Dim tableName1 As String = "[all books]"

        ' Create a connection to the MS Access database
        Using connection As New OleDbConnection(connectionString)
            ' Open the database connection
            connection.Open()

            ' Create a command to retrieve the total count of entries
            Dim commandText As String = $"SELECT COUNT(*) FROM {tableName1}"
            Using command As New OleDbCommand(commandText, connection)
                ' Execute the command and get the total count
                Dim totalEntries1 As Integer = CInt(command.ExecuteScalar())

                ' Update the Label control's text with the total count
                Label5.Text = $"{totalEntries1}"
            End Using
        End Using


        'table 2
        ' Specify the table name
        Dim tableName2 As String = "[borrowed books]"

        ' Create a connection to the MS Access database
        Using connection As New OleDbConnection(connectionString)
            ' Open the database connection
            connection.Open()

            ' Create a command to retrieve the total count of entries
            Dim commandText As String = $"SELECT COUNT(*) FROM {tableName2}"
            Using command As New OleDbCommand(commandText, connection)
                ' Execute the command and get the total count
                Dim totalEntries2 As Integer = CInt(command.ExecuteScalar())

                ' Update the Label control's text with the total count
                Label6.Text = $"{totalEntries2}"
            End Using
        End Using

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        ' Me.Hide()
        Dim AD As New admins()
        AD.TopLevel = False
        dashboardmin.Panel2.Controls.Clear()
        dashboardmin.Panel2.Controls.Add(AD)
        admins.Dock = DockStyle.Fill
        AD.Show()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        out.Show()
    End Sub


End Class