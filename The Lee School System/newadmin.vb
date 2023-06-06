Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports System.Data.OleDb
Imports System.Security.Cryptography

Public Class newadmin




    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged



        If CheckBox1.Checked Then

            TextBox3.PasswordChar = ""
        Else
            TextBox3.PasswordChar = "●"

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'validating data before submitting

        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            enterinfo.Show()
        End If

        Dim con As New OleDbConnection(connectionString:="Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\lee school.accdb;Jet OLEDB:Database Password=A1B2C3;")
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT*FROM [admins] where [email] ='" & TextBox3.Text & "'", con)
        con.Open()
        Dim sd As OleDbDataAdapter = New OleDbDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        sd.Fill(dt)

        If (dt.Rows.Count >= 1) Then
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            ' success_log_in.Show()
            MessageBox.Show("someone registered with that e-mail! try a different one.")
        Else
            'Errorscreen.Show()


            Dim cmd1 As OleDbCommand = New OleDbCommand("INSERT INTO  [admins] ([first name],[email],[password]) VALUES ('" & TextBox1.Text & "', '" & TextBox2.Text & "','" & TextBox3.Text & "' )", con)

            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            cmd1.ExecuteNonQuery()
            con.Close()
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            MessageBox.Show("Admin Added to the database successfully!")


        End If


    End Sub


End Class