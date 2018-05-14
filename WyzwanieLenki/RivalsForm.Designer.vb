<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RivalsForm
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
        Me.components = New System.ComponentModel.Container()
        Me.LenkaPct = New System.Windows.Forms.PictureBox()
        Me.RatPct = New System.Windows.Forms.PictureBox()
        Me.Cage5Pct = New System.Windows.Forms.PictureBox()
        Me.Cage4Pct = New System.Windows.Forms.PictureBox()
        Me.Cage3Pct = New System.Windows.Forms.PictureBox()
        Me.Cage2Pct = New System.Windows.Forms.PictureBox()
        Me.Cage1Pct = New System.Windows.Forms.PictureBox()
        Me.Speech2Tbl = New System.Windows.Forms.TableLayoutPanel()
        Me.Speech2Lbl = New System.Windows.Forms.Label()
        Me.Speech1Tbl = New System.Windows.Forms.TableLayoutPanel()
        Me.Speech1Lbl = New System.Windows.Forms.Label()
        Me.StoryTimer = New System.Windows.Forms.Timer(Me.components)
        Me.StartBtn = New System.Windows.Forms.Button()
        Me.BackTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SetBtn = New System.Windows.Forms.Button()
        Me.OpBtn = New System.Windows.Forms.Button()
        CType(Me.LenkaPct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RatPct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cage5Pct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cage4Pct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cage3Pct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cage2Pct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cage1Pct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Speech2Tbl.SuspendLayout()
        Me.Speech1Tbl.SuspendLayout()
        Me.SuspendLayout()
        '
        'LenkaPct
        '
        Me.LenkaPct.BackColor = System.Drawing.Color.Transparent
        Me.LenkaPct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.LenkaPct.Location = New System.Drawing.Point(12, 415)
        Me.LenkaPct.Name = "LenkaPct"
        Me.LenkaPct.Size = New System.Drawing.Size(130, 190)
        Me.LenkaPct.TabIndex = 13
        Me.LenkaPct.TabStop = False
        Me.LenkaPct.Visible = False
        '
        'RatPct
        '
        Me.RatPct.BackColor = System.Drawing.Color.Transparent
        Me.RatPct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RatPct.Location = New System.Drawing.Point(613, 460)
        Me.RatPct.Name = "RatPct"
        Me.RatPct.Size = New System.Drawing.Size(175, 150)
        Me.RatPct.TabIndex = 14
        Me.RatPct.TabStop = False
        Me.RatPct.Visible = False
        '
        'Cage5Pct
        '
        Me.Cage5Pct.BackColor = System.Drawing.Color.Transparent
        Me.Cage5Pct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Cage5Pct.Location = New System.Drawing.Point(652, 111)
        Me.Cage5Pct.Name = "Cage5Pct"
        Me.Cage5Pct.Size = New System.Drawing.Size(110, 100)
        Me.Cage5Pct.TabIndex = 31
        Me.Cage5Pct.TabStop = False
        '
        'Cage4Pct
        '
        Me.Cage4Pct.BackColor = System.Drawing.Color.Transparent
        Me.Cage4Pct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Cage4Pct.Location = New System.Drawing.Point(500, 111)
        Me.Cage4Pct.Name = "Cage4Pct"
        Me.Cage4Pct.Size = New System.Drawing.Size(110, 100)
        Me.Cage4Pct.TabIndex = 30
        Me.Cage4Pct.TabStop = False
        '
        'Cage3Pct
        '
        Me.Cage3Pct.BackColor = System.Drawing.Color.Transparent
        Me.Cage3Pct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Cage3Pct.Location = New System.Drawing.Point(345, 111)
        Me.Cage3Pct.Name = "Cage3Pct"
        Me.Cage3Pct.Size = New System.Drawing.Size(110, 100)
        Me.Cage3Pct.TabIndex = 29
        Me.Cage3Pct.TabStop = False
        '
        'Cage2Pct
        '
        Me.Cage2Pct.BackColor = System.Drawing.Color.Transparent
        Me.Cage2Pct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Cage2Pct.Location = New System.Drawing.Point(192, 111)
        Me.Cage2Pct.Name = "Cage2Pct"
        Me.Cage2Pct.Size = New System.Drawing.Size(110, 100)
        Me.Cage2Pct.TabIndex = 28
        Me.Cage2Pct.TabStop = False
        '
        'Cage1Pct
        '
        Me.Cage1Pct.BackColor = System.Drawing.Color.Transparent
        Me.Cage1Pct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Cage1Pct.Location = New System.Drawing.Point(37, 111)
        Me.Cage1Pct.Name = "Cage1Pct"
        Me.Cage1Pct.Size = New System.Drawing.Size(100, 100)
        Me.Cage1Pct.TabIndex = 27
        Me.Cage1Pct.TabStop = False
        '
        'Speech2Tbl
        '
        Me.Speech2Tbl.BackColor = System.Drawing.Color.Transparent
        Me.Speech2Tbl.ColumnCount = 1
        Me.Speech2Tbl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Speech2Tbl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.Speech2Tbl.Controls.Add(Me.Speech2Lbl, 0, 0)
        Me.Speech2Tbl.Location = New System.Drawing.Point(360, 264)
        Me.Speech2Tbl.Margin = New System.Windows.Forms.Padding(50)
        Me.Speech2Tbl.Name = "Speech2Tbl"
        Me.Speech2Tbl.RowCount = 1
        Me.Speech2Tbl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Speech2Tbl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125.0!))
        Me.Speech2Tbl.Size = New System.Drawing.Size(300, 125)
        Me.Speech2Tbl.TabIndex = 33
        Me.Speech2Tbl.Visible = False
        '
        'Speech2Lbl
        '
        Me.Speech2Lbl.AutoSize = True
        Me.Speech2Lbl.Location = New System.Drawing.Point(3, 0)
        Me.Speech2Lbl.Name = "Speech2Lbl"
        Me.Speech2Lbl.Size = New System.Drawing.Size(64, 13)
        Me.Speech2Lbl.TabIndex = 16
        Me.Speech2Lbl.Text = "Speech2Lbl"
        '
        'Speech1Tbl
        '
        Me.Speech1Tbl.BackColor = System.Drawing.Color.Transparent
        Me.Speech1Tbl.ColumnCount = 1
        Me.Speech1Tbl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Speech1Tbl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.Speech1Tbl.Controls.Add(Me.Speech1Lbl, 0, 0)
        Me.Speech1Tbl.Location = New System.Drawing.Point(120, 264)
        Me.Speech1Tbl.Margin = New System.Windows.Forms.Padding(50)
        Me.Speech1Tbl.Name = "Speech1Tbl"
        Me.Speech1Tbl.RowCount = 1
        Me.Speech1Tbl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Speech1Tbl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125.0!))
        Me.Speech1Tbl.Size = New System.Drawing.Size(300, 125)
        Me.Speech1Tbl.TabIndex = 32
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
        'StoryTimer
        '
        '
        'StartBtn
        '
        Me.StartBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.StartBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.StartBtn.FlatAppearance.BorderSize = 0
        Me.StartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StartBtn.Location = New System.Drawing.Point(310, 500)
        Me.StartBtn.Name = "StartBtn"
        Me.StartBtn.Size = New System.Drawing.Size(180, 50)
        Me.StartBtn.TabIndex = 34
        Me.StartBtn.Text = "Start"
        Me.StartBtn.UseVisualStyleBackColor = False
        Me.StartBtn.Visible = False
        '
        'BackTimer
        '
        Me.BackTimer.Interval = 1000
        '
        'SetBtn
        '
        Me.SetBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.SetBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SetBtn.FlatAppearance.BorderSize = 0
        Me.SetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SetBtn.Location = New System.Drawing.Point(738, 12)
        Me.SetBtn.Name = "SetBtn"
        Me.SetBtn.Size = New System.Drawing.Size(50, 50)
        Me.SetBtn.TabIndex = 36
        Me.SetBtn.Text = "☺"
        Me.SetBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.SetBtn.UseVisualStyleBackColor = False
        '
        'OpBtn
        '
        Me.OpBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.OpBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.OpBtn.FlatAppearance.BorderSize = 0
        Me.OpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OpBtn.Location = New System.Drawing.Point(600, 500)
        Me.OpBtn.Name = "OpBtn"
        Me.OpBtn.Size = New System.Drawing.Size(180, 50)
        Me.OpBtn.TabIndex = 37
        Me.OpBtn.Text = "Skip"
        Me.OpBtn.UseVisualStyleBackColor = False
        '
        'RivalsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.OpBtn)
        Me.Controls.Add(Me.SetBtn)
        Me.Controls.Add(Me.StartBtn)
        Me.Controls.Add(Me.RatPct)
        Me.Controls.Add(Me.LenkaPct)
        Me.Controls.Add(Me.Cage5Pct)
        Me.Controls.Add(Me.Cage4Pct)
        Me.Controls.Add(Me.Cage3Pct)
        Me.Controls.Add(Me.Cage2Pct)
        Me.Controls.Add(Me.Cage1Pct)
        Me.Controls.Add(Me.Speech2Tbl)
        Me.Controls.Add(Me.Speech1Tbl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RivalsForm"
        CType(Me.LenkaPct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RatPct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cage5Pct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cage4Pct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cage3Pct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cage2Pct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cage1Pct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Speech2Tbl.ResumeLayout(False)
        Me.Speech2Tbl.PerformLayout()
        Me.Speech1Tbl.ResumeLayout(False)
        Me.Speech1Tbl.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LenkaPct As PictureBox
    Friend WithEvents RatPct As PictureBox
    Friend WithEvents Cage5Pct As PictureBox
    Friend WithEvents Cage4Pct As PictureBox
    Friend WithEvents Cage3Pct As PictureBox
    Friend WithEvents Cage2Pct As PictureBox
    Friend WithEvents Cage1Pct As PictureBox
    Friend WithEvents Speech2Tbl As TableLayoutPanel
    Friend WithEvents Speech2Lbl As Label
    Friend WithEvents Speech1Tbl As TableLayoutPanel
    Friend WithEvents Speech1Lbl As Label
    Friend WithEvents StoryTimer As Timer
    Friend WithEvents StartBtn As Button
    Friend WithEvents BackTimer As Timer
    Friend WithEvents SetBtn As Button
    Friend WithEvents OpBtn As Button
End Class
