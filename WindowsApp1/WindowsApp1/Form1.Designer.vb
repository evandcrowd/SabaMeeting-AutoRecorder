<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ButtonStart = New System.Windows.Forms.Button()
        Me.ButtonStop = New System.Windows.Forms.Button()
        Me.recordingList = New System.Windows.Forms.CheckedListBox()
        Me.timeleftLabel = New System.Windows.Forms.Label()
        Me.timeleftNumber = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnVersion = New System.Windows.Forms.Button()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ApplicationName = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnMini = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonStart
        '
        Me.ButtonStart.BackColor = System.Drawing.Color.Transparent
        Me.ButtonStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.ButtonStart.FlatAppearance.BorderSize = 0
        Me.ButtonStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.ButtonStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.ButtonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonStart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ButtonStart.Location = New System.Drawing.Point(293, 63)
        Me.ButtonStart.Name = "ButtonStart"
        Me.ButtonStart.Size = New System.Drawing.Size(94, 74)
        Me.ButtonStart.TabIndex = 0
        Me.ButtonStart.Text = "🞂"
        Me.ButtonStart.UseVisualStyleBackColor = False
        '
        'ButtonStop
        '
        Me.ButtonStop.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.ButtonStop.FlatAppearance.BorderSize = 0
        Me.ButtonStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.ButtonStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.ButtonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonStop.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ButtonStop.Location = New System.Drawing.Point(423, 66)
        Me.ButtonStop.Name = "ButtonStop"
        Me.ButtonStop.Size = New System.Drawing.Size(51, 71)
        Me.ButtonStop.TabIndex = 1
        Me.ButtonStop.Text = "■"
        Me.ButtonStop.UseVisualStyleBackColor = False
        '
        'recordingList
        '
        Me.recordingList.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.recordingList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.recordingList.ForeColor = System.Drawing.Color.White
        Me.recordingList.FormattingEnabled = True
        Me.recordingList.Location = New System.Drawing.Point(12, 36)
        Me.recordingList.Name = "recordingList"
        Me.recordingList.Size = New System.Drawing.Size(267, 120)
        Me.recordingList.TabIndex = 2
        '
        'timeleftLabel
        '
        Me.timeleftLabel.AutoSize = True
        Me.timeleftLabel.ForeColor = System.Drawing.SystemColors.Control
        Me.timeleftLabel.Location = New System.Drawing.Point(290, 36)
        Me.timeleftLabel.Name = "timeleftLabel"
        Me.timeleftLabel.Size = New System.Drawing.Size(80, 13)
        Me.timeleftLabel.TabIndex = 3
        Me.timeleftLabel.Text = "Time recording:"
        '
        'timeleftNumber
        '
        Me.timeleftNumber.AutoSize = True
        Me.timeleftNumber.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.timeleftNumber.Location = New System.Drawing.Point(387, 33)
        Me.timeleftNumber.Name = "timeleftNumber"
        Me.timeleftNumber.Size = New System.Drawing.Size(0, 13)
        Me.timeleftNumber.TabIndex = 4
        '
        'btnRemove
        '
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnRemove.Location = New System.Drawing.Point(12, 167)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(139, 23)
        Me.btnRemove.TabIndex = 6
        Me.btnRemove.Text = "Remove selected from list"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnAbout
        '
        Me.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbout.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAbout.Location = New System.Drawing.Point(157, 167)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(67, 23)
        Me.btnAbout.TabIndex = 7
        Me.btnAbout.Text = "About"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'btnVersion
        '
        Me.btnVersion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVersion.ForeColor = System.Drawing.Color.White
        Me.btnVersion.Location = New System.Drawing.Point(230, 167)
        Me.btnVersion.Name = "btnVersion"
        Me.btnVersion.Size = New System.Drawing.Size(67, 23)
        Me.btnVersion.TabIndex = 8
        Me.btnVersion.Text = "Version"
        Me.btnVersion.UseVisualStyleBackColor = True
        '
        'timer
        '
        Me.timer.Interval = 1000
        '
        'ProgressBar1
        '
        Me.ProgressBar1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ProgressBar1.Location = New System.Drawing.Point(303, 167)
        Me.ProgressBar1.MarqueeAnimationSpeed = 1000
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(179, 23)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(23, 22)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'ApplicationName
        '
        Me.ApplicationName.AutoSize = True
        Me.ApplicationName.BackColor = System.Drawing.Color.Transparent
        Me.ApplicationName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApplicationName.ForeColor = System.Drawing.Color.Crimson
        Me.ApplicationName.Location = New System.Drawing.Point(37, 2)
        Me.ApplicationName.Name = "ApplicationName"
        Me.ApplicationName.Size = New System.Drawing.Size(220, 18)
        Me.ApplicationName.TabIndex = 11
        Me.ApplicationName.Text = "SabaMeeting Auto-Recorder"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(434, 0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(56, 22)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "X"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnMini
        '
        Me.btnMini.BackColor = System.Drawing.Color.AliceBlue
        Me.btnMini.FlatAppearance.BorderSize = 0
        Me.btnMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMini.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMini.Location = New System.Drawing.Point(376, 0)
        Me.btnMini.Name = "btnMini"
        Me.btnMini.Size = New System.Drawing.Size(56, 22)
        Me.btnMini.TabIndex = 13
        Me.btnMini.Text = "-"
        Me.btnMini.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(489, 199)
        Me.Controls.Add(Me.btnMini)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.ApplicationName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnVersion)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.timeleftNumber)
        Me.Controls.Add(Me.timeleftLabel)
        Me.Controls.Add(Me.recordingList)
        Me.Controls.Add(Me.ButtonStop)
        Me.Controls.Add(Me.ButtonStart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "SabaMeeting Auto Recorder"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonStart As Button
    Friend WithEvents ButtonStop As Button
    Friend WithEvents recordingList As CheckedListBox
    Friend WithEvents timeleftLabel As Label
    Friend WithEvents timeleftNumber As Label
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnAbout As Button
    Friend WithEvents btnVersion As Button
    Friend WithEvents timer As Timer
    Public WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ApplicationName As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnMini As Button
End Class
