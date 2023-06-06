Public Class welcome


    Private Sub welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If Panel1.Width <= 600 Then
            Panel1.Width += 2
        End If

        If Panel1.Width >= 500 Then
            dashboard.Show()
            Timer1.Enabled = False

            Panel1.Width = 10
            Me.Close()
        End If

    End Sub
End Class