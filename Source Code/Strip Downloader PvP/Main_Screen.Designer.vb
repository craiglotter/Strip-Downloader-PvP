<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Screen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Screen))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.AutoUpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Button1 = New System.Windows.Forms.Button
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.StatusLabel = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Setting_StripsFolder = New System.Windows.Forms.Label
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button2 = New System.Windows.Forms.Button
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ProxyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProxyToolStripMenuItem, Me.HelpToolStripMenuItem1, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(449, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(40, 20)
        Me.HelpToolStripMenuItem1.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem1, Me.AutoUpdateToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(143, 22)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'AutoUpdateToolStripMenuItem
        '
        Me.AutoUpdateToolStripMenuItem.Name = "AutoUpdateToolStripMenuItem"
        Me.AutoUpdateToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.AutoUpdateToolStripMenuItem.Text = "AutoUpdate"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(43, 218)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 33)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Download Strips"
        Me.ToolTip1.SetToolTip(Me.Button1, "Start Downloading Strips")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'StatusLabel
        '
        Me.StatusLabel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.StatusLabel.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.StatusLabel.Location = New System.Drawing.Point(0, 348)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.StatusLabel.Size = New System.Drawing.Size(449, 18)
        Me.StatusLabel.TabIndex = 21
        Me.StatusLabel.Text = "Application Loaded"
        Me.StatusLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(19, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Save Strips to:"
        '
        'Setting_StripsFolder
        '
        Me.Setting_StripsFolder.AutoEllipsis = True
        Me.Setting_StripsFolder.ForeColor = System.Drawing.Color.Olive
        Me.Setting_StripsFolder.Location = New System.Drawing.Point(134, 54)
        Me.Setting_StripsFolder.Name = "Setting_StripsFolder"
        Me.Setting_StripsFolder.Size = New System.Drawing.Size(248, 13)
        Me.Setting_StripsFolder.TabIndex = 29
        Me.ToolTip1.SetToolTip(Me.Setting_StripsFolder, "Folder to which Strips will be Downloaded")
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Enabled = False
        Me.ProgressBar1.Location = New System.Drawing.Point(21, 316)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(407, 23)
        Me.ProgressBar1.TabIndex = 35
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(43, 257)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(143, 33)
        Me.Button2.TabIndex = 39
        Me.Button2.Text = "Cancel"
        Me.ToolTip1.SetToolTip(Me.Button2, "Cancel Operation")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(134, 28)
        Me.DateTimePicker1.MinDate = New Date(1998, 5, 4, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(88, 20)
        Me.DateTimePicker1.TabIndex = 41
        Me.ToolTip1.SetToolTip(Me.DateTimePicker1, "Starting Date Range of Strips to Download")
        Me.DateTimePicker1.Value = New Date(1998, 5, 4, 7, 40, 0, 0)
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(250, 28)
        Me.DateTimePicker2.MinDate = New Date(1998, 5, 4, 0, 0, 0, 0)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(88, 20)
        Me.DateTimePicker2.TabIndex = 42
        Me.ToolTip1.SetToolTip(Me.DateTimePicker2, "Ending Date Range of Strips to Download")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(19, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Strips to Download:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.Setting_StripsFolder)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Gray
        Me.GroupBox1.Location = New System.Drawing.Point(21, 112)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(407, 87)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Strip Downloader"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(228, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 13)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "to"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Gray
        Me.GroupBox2.Location = New System.Drawing.Point(220, 205)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(208, 102)
        Me.GroupBox2.TabIndex = 45
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Last Strip Downloaded"
        '
        'ProxyToolStripMenuItem
        '
        Me.ProxyToolStripMenuItem.Name = "ProxyToolStripMenuItem"
        Me.ProxyToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.ProxyToolStripMenuItem.Text = "Proxy"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(6, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(196, 77)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Strip_Downloader_PvP.My.Resources.Resources.Form_Banner
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(449, 69)
        Me.Panel1.TabIndex = 11
        '
        'Main_Screen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 366)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.StatusLabel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Main_Screen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HelpToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AutoUpdateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents StatusLabel As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Setting_StripsFolder As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ProxyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
