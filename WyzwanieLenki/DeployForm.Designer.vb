<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DeployForm
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
        Me.Cage1Pct = New System.Windows.Forms.PictureBox()
        Me.Cage2Pct = New System.Windows.Forms.PictureBox()
        Me.Cage3Pct = New System.Windows.Forms.PictureBox()
        Me.Cage4Pct = New System.Windows.Forms.PictureBox()
        Me.Cage5Pct = New System.Windows.Forms.PictureBox()
        Me.BackTimer = New System.Windows.Forms.Timer(Me.components)
        Me.StoryTimer = New System.Windows.Forms.Timer(Me.components)
        Me.LenkaRunPct = New System.Windows.Forms.PictureBox()
        Me.RatRunPct = New System.Windows.Forms.PictureBox()
        Me.BagPct = New System.Windows.Forms.PictureBox()
        Me.Speech1Tbl = New System.Windows.Forms.TableLayoutPanel()
        Me.Speech1Lbl = New System.Windows.Forms.Label()
        Me.SetBtn = New System.Windows.Forms.Button()
        Me.OpBtn = New System.Windows.Forms.Button()
        CType(Me.Cage1Pct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cage2Pct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cage3Pct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cage4Pct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cage5Pct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LenkaRunPct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RatRunPct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BagPct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Speech1Tbl.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cage1Pct
        '
        Me.Cage1Pct.BackColor = System.Drawing.Color.Transparent
        Me.Cage1Pct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Cage1Pct.Location = New System.Drawing.Point(37, 290)
        Me.Cage1Pct.Name = "Cage1Pct"
        Me.Cage1Pct.Size = New System.Drawing.Size(100, 100)
        Me.Cage1Pct.TabIndex = 12
        Me.Cage1Pct.TabStop = False
        '
        'Cage2Pct
        '
        Me.Cage2Pct.BackColor = System.Drawing.Color.Transparent
        Me.Cage2Pct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Cage2Pct.Location = New System.Drawing.Point(192, 290)
        Me.Cage2Pct.Name = "Cage2Pct"
        Me.Cage2Pct.Size = New System.Drawing.Size(110, 100)
        Me.Cage2Pct.TabIndex = 13
        Me.Cage2Pct.TabStop = False
        '
        'Cage3Pct
        '
        Me.Cage3Pct.BackColor = System.Drawing.Color.Transparent
        Me.Cage3Pct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Cage3Pct.Location = New System.Drawing.Point(345, 290)
        Me.Cage3Pct.Name = "Cage3Pct"
        Me.Cage3Pct.Size = New System.Drawing.Size(110, 100)
        Me.Cage3Pct.TabIndex = 14
        Me.Cage3Pct.TabStop = False
        '
        'Cage4Pct
        '
        Me.Cage4Pct.BackColor = System.Drawing.Color.Transparent
        Me.Cage4Pct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Cage4Pct.Location = New System.Drawing.Point(500, 290)
        Me.Cage4Pct.Name = "Cage4Pct"
        Me.Cage4Pct.Size = New System.Drawing.Size(110, 100)
        Me.Cage4Pct.TabIndex = 15
        Me.Cage4Pct.TabStop = False
        '
        'Cage5Pct
        '
        Me.Cage5Pct.BackColor = System.Drawing.Color.Transparent
        Me.Cage5Pct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Cage5Pct.Location = New System.Drawing.Point(652, 290)
        Me.Cage5Pct.Name = "Cage5Pct"
        Me.Cage5Pct.Size = New System.Drawing.Size(110, 100)
        Me.Cage5Pct.TabIndex = 16
        Me.Cage5Pct.TabStop = False
        '
        'BackTimer
        '
        Me.BackTimer.Interval = 1000
        '
        'StoryTimer
        '
        '
        'LenkaRunPct
        '
        Me.LenkaRunPct.BackColor = System.Drawing.Color.Transparent
        Me.LenkaRunPct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.LenkaRunPct.Location = New System.Drawing.Point(12, 405)
        Me.LenkaRunPct.Name = "LenkaRunPct"
        Me.LenkaRunPct.Size = New System.Drawing.Size(190, 180)
        Me.LenkaRunPct.TabIndex = 23
        Me.LenkaRunPct.TabStop = False
        Me.LenkaRunPct.Visible = False
        '
        'RatRunPct
        '
        Me.RatRunPct.BackColor = System.Drawing.Color.Transparent
        Me.RatRunPct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.RatRunPct.Location = New System.Drawing.Point(208, 430)
        Me.RatRunPct.Name = "RatRunPct"
        Me.RatRunPct.Size = New System.Drawing.Size(122, 155)
        Me.RatRunPct.TabIndex = 24
        Me.RatRunPct.TabStop = False
        Me.RatRunPct.Visible = False
        '
        'BagPct
        '
        Me.BagPct.BackColor = System.Drawing.Color.Transparent
        Me.BagPct.Location = New System.Drawing.Point(336, 490)
        Me.BagPct.Name = "BagPct"
        Me.BagPct.Size = New System.Drawing.Size(100, 85)
        Me.BagPct.TabIndex = 25
        Me.BagPct.TabStop = False
        Me.BagPct.Visible = False
        '
        'Speech1Tbl
        '
        Me.Speech1Tbl.BackColor = System.Drawing.Color.Transparent
        Me.Speech1Tbl.ColumnCount = 1
        Me.Speech1Tbl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Speech1Tbl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.Speech1Tbl.Controls.Add(Me.Speech1Lbl, 0, 0)
        Me.Speech1Tbl.Location = New System.Drawing.Point(488, 265)
        Me.Speech1Tbl.Margin = New System.Windows.Forms.Padding(50)
        Me.Speech1Tbl.Name = "Speech1Tbl"
        Me.Speech1Tbl.RowCount = 1
        Me.Speech1Tbl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Speech1Tbl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125.0!))
        Me.Speech1Tbl.Size = New System.Drawing.Size(300, 125)
        Me.Speech1Tbl.TabIndex = 26
        Me.Speech1Tbl.Visible = False
        '
        'Speech1Lbl
        '
        Me.Speech1Lbl.AutoSize = True
        Me.Speech1Lbl.Location = New System.Drawing.Point(3, 0)
        Me.Speech1Lbl.Name = "Speech1Lbl"
        Me.Speech1Lbl.Size = New System.Drawing.Size(64, 13)
        Me.Speech1Lbl.TabIndex = 16
        Me.Speech1Lbl.Text = "Speech1Lbl"
        '
        'SetBtn
        '
        Me.SetBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SetBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SetBtn.FlatAppearance.BorderSize = 0
        Me.SetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SetBtn.Location = New System.Drawing.Point(738, 12)
        Me.SetBtn.Name = "SetBtn"
        Me.SetBtn.Size = New System.Drawing.Size(50, 50)
        Me.SetBtn.TabIndex = 27
        Me.SetBtn.Text = "☺"
        Me.SetBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.SetBtn.UseVisualStyleBackColor = False
        '
        'OpBtn
        '
        Me.OpBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.OpBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.OpBtn.FlatAppearance.BorderSize = 0
        Me.OpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OpBtn.Location = New System.Drawing.Point(600, 500)
        Me.OpBtn.Name = "OpBtn"
        Me.OpBtn.Size = New System.Drawing.Size(180, 50)
        Me.OpBtn.TabIndex = 28
        Me.OpBtn.Text = "Skip"
        Me.OpBtn.UseVisualStyleBackColor = False
        '
        'DeployForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.OpBtn)
        Me.Controls.Add(Me.SetBtn)
        Me.Controls.Add(Me.Speech1Tbl)
        Me.Controls.Add(Me.BagPct)
        Me.Controls.Add(Me.RatRunPct)
        Me.Controls.Add(Me.LenkaRunPct)
        Me.Controls.Add(Me.Cage5Pct)
        Me.Controls.Add(Me.Cage4Pct)
        Me.Controls.Add(Me.Cage3Pct)
        Me.Controls.Add(Me.Cage2Pct)
        Me.Controls.Add(Me.Cage1Pct)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DeployForm"
        CType(Me.Cage1Pct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cage2Pct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cage3Pct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cage4Pct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cage5Pct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LenkaRunPct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RatRunPct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BagPct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Speech1Tbl.ResumeLayout(False)
        Me.Speech1Tbl.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Cage1Pct As PictureBox
    Friend WithEvents Cage2Pct As PictureBox
    Friend WithEvents Cage3Pct As PictureBox
    Friend WithEvents Cage4Pct As PictureBox
    Friend WithEvents Cage5Pct As PictureBox
    Friend WithEvents BackTimer As Timer
    Friend WithEvents StoryTimer As Timer
    Friend WithEvents LenkaRunPct As PictureBox
    Friend WithEvents RatRunPct As PictureBox
    Friend WithEvents BagPct As PictureBox
    Friend WithEvents Speech1Tbl As TableLayoutPanel
    Friend WithEvents Speech1Lbl As Label
    Friend WithEvents SetBtn As Button
    Friend WithEvents OpBtn As Button
End Class
