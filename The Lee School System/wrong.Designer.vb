<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class wrong
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.The_Lee_School_System.My.Resources.Resources._6ef9f2fd6425c578274e72ce1f44a778
        Me.PictureBox1.Location = New System.Drawing.Point(-172, -106)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(565, 428)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label1.Location = New System.Drawing.Point(222, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 55)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "WRONG"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label2.Location = New System.Drawing.Point(200, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(249, 55)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "DETAILS!"
        Me.Label2.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 270
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(244, 212)
        Me.Panel1.MaximumSize = New System.Drawing.Size(750, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 10)
        Me.Panel1.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Orange
        Me.Label3.Location = New System.Drawing.Point(187, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(289, 55)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "CHECKING"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Panel2.Location = New System.Drawing.Point(-16, -17)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(555, 19)
        Me.Panel2.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Panel3.Location = New System.Drawing.Point(-24, 220)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(555, 19)
        Me.Panel3.TabIndex = 6
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Panel4.Location = New System.Drawing.Point(511, -2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(10, 227)
        Me.Panel4.TabIndex = 7
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Panel5.Location = New System.Drawing.Point(-8, -13)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(10, 234)
        Me.Panel5.TabIndex = 8
        '
        'wrong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(513, 222)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "wrong"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
End Class
