Public Class dashboardmax
    Private Sub dashboardmax_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim mn As New Form2()
        mn.TopLevel = False
        Panel4.Controls.Add(mn)
        mn.Dock = DockStyle.Fill
        mn.Show()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim max As New dashboardmin()
        max.TopLevel = False
        dashboard.Panel6.Controls.Clear()
        dashboard.Panel6.Controls.Add(max)
        max.Dock = DockStyle.Fill
        max.Show()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim M As New Form2()
        M.TopLevel = False
        Panel4.Controls.Clear()
        Panel4.Controls.Add(M)
        M.Dock = DockStyle.Fill
        M.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        out.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim a As New admins()
        a.TopLevel = False
        Panel4.Controls.Clear()
        Panel4.Controls.Add(a)
        a.Dock = DockStyle.Fill
        a.Show()


    End Sub


End Class