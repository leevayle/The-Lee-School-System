Public Class accepted


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


    Private Sub accepted_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        roundCorners(Me)
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Panel1.Width += 20

        If Panel1.Width >= 25 Then
            login.Hide()

            If Panel1.Width >= 190 Then

                Timer1.Enabled = False
                login.TextBox1.Text = ""
                login.TextBox2.Text = ""


                welcome.Show()
                Me.Close()
            End If



        End If

    End Sub
End Class