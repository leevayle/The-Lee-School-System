Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status

Public Class wrong

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

    Private Sub wrong_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        roundCorners(Me)
        Timer1.Enabled = True
        Label3.Visible = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'The loading progressbar
        '----------------------
        If Panel1.Width <= 750 Then
            Panel1.Width += 50
        End If

        'changing text
        If Panel1.Width >= 10 Then


            If Panel1.Width >= 150 Then


                If Panel1.Width >= 250 Then

                    ' MsgBox("stage 1 executed")

                    If Panel1.Width >= 560 Then
                        '  MsgBox("stage 2 executed")
                        Label3.Visible = False
                        Label2.Visible = True
                        Label1.Visible = True
                        If Panel1.Width >= 749 Then

                            Timer1.Stop()
                            Me.Close()



                        End If
                    End If
                End If
            End If
        End If

    End Sub


End Class