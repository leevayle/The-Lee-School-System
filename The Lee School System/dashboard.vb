

Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status

Public Class dashboard
    Dim strng As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\lee school.accdb;Jet OLEDB:Database Password=A1B2C3;"
    Dim conn As New OleDbConnection(strng)


    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        welcome.Close()

        'loading the dashboard as the child form
        Dim m As New dashboardmin()
        m.TopLevel = False
        Panel6.Controls.Add(m)
        m.Dock = DockStyle.Fill
        m.Show()




        Timer1.Enabled = True
        Dim user As String = login.Label4.Text
        Label3.Text = user

        login.Hide()


        'displaying the name of the school
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        Dim cmdschol As OleDbCommand = New OleDbCommand("SELECT [name] FROM [info]", conn)
        cmdschol.ExecuteNonQuery().ToString()
        Dim reader As OleDbDataReader = cmdschol.ExecuteReader()
        If reader.Read() Then
            Label4.Text = reader("Name").ToString() + " Library"
        End If

        reader.Close()
        cmdschol.Dispose()
        conn.Close()
        'conn.Dispose()



    End Sub




    'printing the time to the dashboard
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim t As String = DateTime.Now.ToString("HH")
        Label5.Text = DateTime.Now.ToString("h:mm:ss:tt")
        Label6.Text = DateTime.Now.ToString("dddd dd")

        If t <= 11 Then
            Me.Label1.Text = "Good morning"

        ElseIf t <= 12 Then
            Label1.Text = "Good lunch"

        ElseIf t <= 14 Then
            Label1.Text = "Good afernoon"

        ElseIf t <= 16 Then
            Label1.Text = "Good evening"

        ElseIf t >= (19) Then
            Label1.Text = "Good night"

        End If

    End Sub



    Private Sub Button8_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        ' admins.Hide()
        ' Panel6.Controls.Clear()
        ' Dim admins As New menu()
        ' menu.TopLevel = False
        ' Panel6.Controls.Add(menu)
        ' menu.Dock = DockStyle.Fill
        ' menu.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        Panel6.Controls.Clear()
        Dim dm As New dashboardmin()
        dm.TopLevel = False
        Panel6.Controls.Add(dm)
        dm.Dock = DockStyle.Fill
        dm.Show()




    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)

        out.Show()
    End Sub



    Private Sub Button8_Click_1(sender As Object, e As EventArgs)

        Panel6.Controls.Clear()
        Dim admins As New admins()
        admins.TopLevel = False
        Panel6.Controls.Add(admins)
        admins.Dock = DockStyle.Fill
        admins.Show()
    End Sub






    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        Dim usr As String
        usr = Label3.Text
        Dim message As String = "You are currently Logged in as " + usr + ". Do you wish to log out?"


        Dim result As DialogResult = MessageBox.Show(message, "Log Out?", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            out.Show()
        End If


    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

        Dim user As String = login.Label4.Text
        Label3.Text = user

    End Sub



    Private Sub quit(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'out.Show()
        Dim logout As String
        logout = DateTime.Now.ToString("hh:mm:ss:tt")
        Dim adminA As String = login.Label4.Text
        'Updating the log out time in the log records file
        Dim myFile As System.IO.StreamWriter
        myFile = My.Computer.FileSystem.OpenTextFileWriter("c:\users\public\Admin Log In records.txt", True)

        myFile.WriteLine("")
        myFile.WriteLine("Log out time of :" + adminA)
        myFile.WriteLine(logout)
        myFile.WriteLine("<-- <-- <-- <-- <-- <-- <--")
        myFile.Close()

        Application.Exit()
    End Sub
End Class