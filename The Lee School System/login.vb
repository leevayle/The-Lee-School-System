Imports System.Collections.ObjectModel
Imports System.Data.OleDb
Imports Microsoft.VisualBasic.ApplicationServices

Public Class login

    'connecting to the database
    Dim strng As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= .\lee school.accdb;Jet OLEDB:Database Password=A1B2C3;"
    Dim conn As New OleDbConnection(strng)


    'rounded corners
    '-----------------
    Private Sub roundCorners(obj As Form)

        obj.FormBorderStyle = FormBorderStyle.None

        Dim DGP As New Drawing2D.GraphicsPath
        DGP.StartFigure()
        'top left corner
        DGP.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        DGP.AddLine(40, 0, obj.Width - 40, 0)

        'top right corner
        DGP.AddArc(New Rectangle(obj.Width - 40, 0, 40, 40), -90, 90)
        DGP.AddLine(obj.Width, 40, obj.Width, obj.Height - 40)

        'buttom right corner
        DGP.AddArc(New Rectangle(obj.Width - 40, obj.Height - 40, 40, 40), 0, 90)
        DGP.AddLine(obj.Width - 40, obj.Height, 40, obj.Height)

        'buttom left corner
        DGP.AddArc(New Rectangle(0, obj.Height - 40, 40, 40), 90, 90)
        DGP.CloseFigure()

        obj.Region = New Region(DGP)

    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim strng As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\lee school.accdb;Jet OLEDB:Database Password=A1B2C3;"
        'Dim conn As New OleDbConnection(strng)
        conn.Open()
        TextBox1.AutoSize = False
        TextBox2.AutoSize = False
        roundCorners(Me)
        Form1.Close()

        TextBox1.Text = ""
        TextBox2.Text = ""

        'getting values for school information
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        Dim cmdschol As OleDbCommand = New OleDbCommand("SELECT [name] FROM [info]", conn)
        ' cmdschol.ExecuteNonQuery().ToString()
        Dim reader As OleDbDataReader = cmdschol.ExecuteReader()
        If reader.Read() Then
            Label3.Text = reader("Name").ToString()
        End If

        reader.Close()
        cmdschol.Dispose()
        conn.Close()
        'conn.Dispose()


    End Sub

    Private Sub check(sender As Object, e As EventArgs) Handles TextBox1.TextChanged, TextBox2.TextChanged
        'both have no text
        If (TextBox1.Text = "" And TextBox2.Text = "") Then
            Panel2.Width = 50
            Panel2.BackColor = Color.OrangeRed

            'no text in tb1
        ElseIf Not (TextBox2.Text = "") And (TextBox1.Text = "") Then
            Panel2.Width = 200
            Panel2.BackColor = Color.Yellow

            'no text in tb2
        ElseIf Not (TextBox1.Text = "") And (TextBox2.Text = "") Then
            Panel2.Width = 200
            Panel2.BackColor = Color.Yellow


            'both have text
        ElseIf Not (TextBox1.Text = "" And TextBox2.Text = "") Then
            Panel2.Width = 500
            Panel2.BackColor = Color.Lime

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Close()
        dashboard.Close()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If


        Application.Exit()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label4.AutoSize = False
        Label4.Width = 100

        'logged in username
        Dim user As String
        user = TextBox1.Text
        Label4.Text = user


        If (TextBox1.Text = "") And (TextBox2.Text = "") Then
            enterinfo.Show()

        ElseIf conn.State = ConnectionState.Closed Then
            conn.Open()

        Else
            Dim logincmd As OleDbCommand = New OleDbCommand("SELECT * FROM [admins] where [first name]='" & TextBox1.Text & "' and [password]='" & TextBox2.Text & "' ", conn)
            Dim loginrd As OleDbDataReader = logincmd.ExecuteReader
            If (loginrd.Read() = True) Then
                'reader.Close()
                conn.Close()

                'Obtaining the timer reading
                Dim login As String
                login = DateTime.Now.ToString("hh:mm:ss:tt")
                Dim logind As String = DateTime.Now.ToString("dd - ddd - MMM - yyyy")

                'Updating the log out time in the log records file
                Dim myFile As System.IO.StreamWriter
                myFile = My.Computer.FileSystem.OpenTextFileWriter("c:\users\public\Admin Log In records.txt", True)

                myFile.WriteLine("")
                myFile.WriteLine("On: " + logind)
                myFile.WriteLine("At:" + login)
                myFile.WriteLine("Admin: " + user)
                myFile.WriteLine("Logged into the system.")
                myFile.WriteLine("--> --> --> --> --> --> -->")
                myFile.Close()

                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
                'showing the password accepted screen
                accepted.Show()

            Else
                wrong.Show()
                'conn.Close()
                Form1.Close()
            End If

        End If



    End Sub


End Class