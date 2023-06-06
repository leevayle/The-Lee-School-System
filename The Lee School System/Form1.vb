
'Designed by lee 0748673538
Imports System.Data.OleDb

Public Class Form1



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


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        roundCorners(Me)
        Timer1.Enabled = True

        Dim strng As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= .\lee school.accdb;Jet OLEDB:Database Password=A1B2C3;"
        Dim conn As New OleDbConnection(strng)
        conn.Open()

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        Dim cmdschol As OleDbCommand = New OleDbCommand("SELECT [name] FROM [info]", conn)
        Dim reader As OleDbDataReader = cmdschol.ExecuteReader()
        If reader.Read() Then
            Label1.Text = reader("Name").ToString()
        End If

        reader.Close()
        cmdschol.Dispose()
        conn.Close()
        conn.Dispose()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'The loading progressbar
        '----------------------
        If Panel2.Width <= 750 Then
            Panel2.Width += 3
        End If

        'changing text
        If Panel2.Width >= 10 Then
            Label5.Text = "Starting up"
            If Panel2.Width >= 150 Then
                Label5.Text = "Initializing"
                If Panel2.Width >= 250 Then
                    Label5.Text = "Getting data"
                    If Panel2.Width >= 500 Then
                        Label5.Text = "  Opening  "
                        If Panel2.Width >= 749 Then

                            Timer1.Enabled = False
                            login.Show()



                        End If
                    End If
                End If
            End If
        End If

    End Sub
End Class