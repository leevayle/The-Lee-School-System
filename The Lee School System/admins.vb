Public Class admins
    Private Sub admins_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim a As New newadmin()
        a.TopLevel = False
        Panel2.Controls.Clear()
        Panel2.Controls.Add(a)
        a.Dock = DockStyle.Fill
        a.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim ab As New adminrecords()
        ab.TopLevel = False
        Panel2.Controls.Clear()
        Panel2.Controls.Add(ab)
        ab.Dock = DockStyle.Fill
        ab.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim da As New deleteadmin()
        da.TopLevel = False
        Panel2.Controls.Clear()
        Panel2.Controls.Add(da)
        da.Dock = DockStyle.Fill
        da.Show()
    End Sub
End Class