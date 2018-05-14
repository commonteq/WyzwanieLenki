<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RunForm
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
        Me.StoryTimer = New System.Windows.Forms.Timer(Me.components)
        Me.LenkaRunPct = New System.Windows.Forms.PictureBox()
        Me.RatRunPct = New System.Windows.Forms.PictureBox()
        Me.BagPct = New System.Windows.Forms.PictureBox()
        Me.SunPct = New System.Windows.Forms.PictureBox()
        Me.Cloud3Pct = New System.Windows.Forms.PictureBox()
        Me.Cloud4Pct = New System.Windows.Forms.PictureBox()
        Me.Cloud2Pct = New System.Windows.Forms.PictureBox()
        Me.Cloud1Pct = New System.Windows.Forms.PictureBox()
        Me.Speech1Tbl = New System.Windows.Forms.TableLayoutPanel()
        Me.Speech1Lbl = New System.Windows.Forms.Label()
        Me.BackTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SetBtn = New System.Windows.Forms.Button()
        Me.OpBtn = New System.Windows.Forms.Button()
        CType(Me.LenkaRunPct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RatRunPct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BagPct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SunPct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cloud3Pct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cloud4Pct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cloud2Pct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cloud1Pct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Speech1Tbl.SuspendLayout()
        Me.SuspendLayout()
        '
        'StoryTimer
        '
        '
        'LenkaRunPct
        '
        Me.LenkaRunPct.BackColor = System.Drawing.Color.Transparent
        Me.LenkaRunPct.Location = New System.Drawing.Point(300, 420)
        Me.LenkaRunPct.Name = "LenkaRunPct"
        Me.LenkaRunPct.Size = New System.Drawing.Size(190, 180)
        Me.LenkaRunPct.TabIndex = 22
        Me.LenkaRunPct.TabStop = False
        '
        'RatRunPct
        '
        Me.RatRunPct.BackColor = System.Drawing.Color.Transparent
        Me.RatRunPct.Location = New System.Drawing.Point(500, 440)
        Me.RatRunPct.Name = "RatRunPct"
        Me.RatRunPct.Size = New System.Drawing.Size(122, 155)
        Me.RatRunPct.TabIndex = 23
        Me.RatRunPct.TabStop = False
        '
        'BagPct
        '
        Me.BagPct.BackColor = System.Drawing.Color.Transparent
        Me.BagPct.Location = New System.Drawing.Point(637, 489)
        Me.BagPct.Name = "BagPct"
        Me.BagPct.Size = New System.Drawing.Size(100, 85)
        Me.BagPct.TabIndex = 24
        Me.BagPct.TabStop = False
        Me.BagPct.Visible = False
        '
        'SunPct
        '
        Me.SunPct.BackColor = System.Drawing.Color.Transparent
        Me.SunPct.Location = New System.Drawing.Point(630, 10)
        Me.SunPct.Name = "SunPct"
        Me.SunPct.Size = New System.Drawing.Size(70, 70)
        Me.SunPct.TabIndex = 25
        Me.SunPct.TabStop = False
        '
        'Cloud3Pct
        '
        Me.Cloud3Pct.BackColor = System.Drawing.Color.Transparent
        Me.Cloud3Pct.Location = New System.Drawing.Point(250, 10)
        Me.Cloud3Pct.Name = "Cloud3Pct"
        Me.Cloud3Pct.Size = New System.Drawing.Size(140, 70)
        Me.Cloud3Pct.TabIndex = 28
        Me.Cloud3Pct.TabStop = False
        '
        'Cloud4Pct
        '
        Me.Cloud4Pct.BackColor = System.Drawing.Color.Transparent
        Me.Cloud4Pct.Location = New System.Drawing.Point(50, 60)
        Me.Cloud4Pct.Name = "Cloud4Pct"
        Me.Cloud4Pct.Size = New System.Drawing.Size(140, 70)
        Me.Cloud4Pct.TabIndex = 27
        Me.Cloud4Pct.TabStop = False
        '
        'Cloud2Pct
        '
        Me.Cloud2Pct.BackColor = System.Drawing.Color.Transparent
        Me.Cloud2Pct.Location = New System.Drawing.Point(450, 60)
        Me.Cloud2Pct.Name = "Cloud2Pct"
        Me.Cloud2Pct.Size = New System.Drawing.Size(140, 70)
        Me.Cloud2Pct.TabIndex = 29
        Me.Cloud2Pct.TabStop = False
        '
        'Cloud1Pct
        '
        Me.Cloud1Pct.BackColor = System.Drawing.Color.Transparent
        Me.Cloud1Pct.Location = New System.Drawing.Point(630, 110)
        Me.Cloud1Pct.Name = "Cloud1Pct"
        Me.Cloud1Pct.Size = New System.Drawing.Size(140, 70)
        Me.Cloud1Pct.TabIndex = 26
        Me.Cloud1Pct.TabStop = False
        '
        'Speech1Tbl
        '
        Me.Speech1Tbl.BackColor = System.Drawing.Color.Transparent
        Me.Speech1Tbl.ColumnCount = 1
        Me.Speech1Tbl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Speech1Tbl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.Speech1Tbl.Controls.Add(Me.Speech1Lbl, 0, 0)
        Me.Speech1Tbl.Location = New System.Drawing.Point(50, 245)
        Me.Speech1Tbl.Margin = New System.Windows.Forms.Padding(50)
        Me.Speech1Tbl.Name = "Speech1Tbl"
        Me.Speech1Tbl.RowCount = 1
        Me.Speech1Tbl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Speech1Tbl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125.0!))
        Me.Speech1Tbl.Size = New System.Drawing.Size(300, 125)
        Me.Speech1Tbl.TabIndex = 30
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
        'BackTimer
        '
        Me.BackTimer.Interval = 1000
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
        Me.SetBtn.TabIndex = 33
        Me.SetBtn.Text = "☺"
        Me.SetBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.SetBtn.UseVisualStyleBackColor = False
        '
        'OpBtn
        '
        Me.OpBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.OpBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.OpBtn.FlatAppearance.BorderSize = 0
        Me.OpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OpBtn.Location = New System.Drawing.Point(600, 500)
        Me.OpBtn.Name = "OpBtn"
        Me.OpBtn.Size = New System.Drawing.Size(180, 50)
        Me.OpBtn.TabIndex = 34
        Me.OpBtn.Text = "Skip"
        Me.OpBtn.UseVisualStyleBackColor = False
        '
        'RunForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.OpBtn)
        Me.Controls.Add(Me.SetBtn)
        Me.Controls.Add(Me.Speech1Tbl)
        Me.Controls.Add(Me.Cloud3Pct)
        Me.Controls.Add(Me.Cloud4Pct)
        Me.Controls.Add(Me.Cloud2Pct)
        Me.Controls.Add(Me.Cloud1Pct)
        Me.Controls.Add(Me.SunPct)
        Me.Controls.Add(Me.BagPct)
        Me.Controls.Add(Me.RatRunPct)
        Me.Controls.Add(Me.LenkaRunPct)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RunForm"
        CType(Me.LenkaRunPct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RatRunPct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BagPct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SunPct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cloud3Pct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cloud4Pct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cloud2Pct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cloud1Pct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Speech1Tbl.ResumeLayout(False)
        Me.Speech1Tbl.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StoryTimer As Timer
    Friend WithEvents LenkaRunPct As PictureBox
    Friend WithEvents RatRunPct As PictureBox
    Friend WithEvents BagPct As PictureBox
    Friend WithEvents SunPct As PictureBox
    Friend WithEvents Cloud3Pct As PictureBox
    Friend WithEvents Cloud4Pct As PictureBox
    Friend WithEvents Cloud2Pct As PictureBox
    Friend WithEvents Cloud1Pct As PictureBox
    Friend WithEvents Speech1Tbl As TableLayoutPanel
    Friend WithEvents Speech1Lbl As Label
    Friend WithEvents BackTimer As Timer
    Friend WithEvents SetBtn As Button
    Friend WithEvents OpBtn As Button
End Class
