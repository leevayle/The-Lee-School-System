<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dashboard))
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.BalloonTipText = "The Lee school librarry system is currently running"
        Me.NotifyIcon1.BalloonTipTitle = "Lee school Lib system"
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "The Lee school Library"
        Me.NotifyIcon1.Visible = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1378, 82)
        Me.Panel1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.The_Lee_School_System.My.Resources.Resources.user__2_
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(1294, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(58, 63)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label6.Location = New System.Drawing.Point(91, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "........."
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(1079, 33)
        Me.Label3.MaximumSize = New System.Drawing.Size(300, 38)
        Me.Label3.MinimumSize = New System.Drawing.Size(200, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(200, 38)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "..."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.Label3, "Admin")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Cooper Black", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.LightGray
        Me.Label4.Location = New System.Drawing.Point(237, 19)
        Me.Label4.MinimumSize = New System.Drawing.Size(900, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(900, 45)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "..."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.MediumAquamarine
        Me.Label5.Location = New System.Drawing.Point(67, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "00:00:00 .."
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.Label5, "Current system time")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.Location = New System.Drawing.Point(1183, 18)
        Me.Label1.MinimumSize = New System.Drawing.Size(96, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(96, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "good morning"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Location = New System.Drawing.Point(-2, 81)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1375, 686)
        Me.Panel6.TabIndex = 9
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipTitle = "Tip!"
        '
        'dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1370, 727)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel1)
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MdiChildrenMinimizedAnchorBottom = False
        Me.Name = "dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "The [LS] Library Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
