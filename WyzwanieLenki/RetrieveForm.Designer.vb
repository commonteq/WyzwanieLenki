<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RetrieveForm
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
        Me.Cage5Pct = New System.Windows.Forms.PictureBox()
        Me.Cage4Pct = New System.Windows.Forms.PictureBox()
        Me.Cage3Pct = New System.Windows.Forms.PictureBox()
        Me.Cage2Pct = New System.Windows.Forms.PictureBox()
        Me.Cage1Pct = New System.Windows.Forms.PictureBox()
        Me.BackTimer = New System.Windows.Forms.Timer(Me.components)
        Me.StoryTimer = New System.Windows.Forms.Timer(Me.components)
        Me.PetPct = New System.Windows.Forms.PictureBox()
        Me.SetBtn = New System.Windows.Forms.Button()
        CType(Me.Cage5Pct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cage4Pct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cage3Pct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cage2Pct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cage1Pct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PetPct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cage5Pct
        '
        Me.Cage5Pct.BackColor = System.Drawing.Color.Transparent
        Me.Cage5Pct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Cage5Pct.Location = New System.Drawing.Point(652, 290)
        Me.Cage5Pct.Name = "Cage5Pct"
        Me.Cage5Pct.Size = New System.Drawing.Size(110, 100)
        Me.Cage5Pct.TabIndex = 31
        Me.Cage5Pct.TabStop = False
        '
        'Cage4Pct
        '
        Me.Cage4Pct.BackColor = System.Drawing.Color.Transparent
        Me.Cage4Pct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Cage4Pct.Location = New System.Drawing.Point(500, 290)
        Me.Cage4Pct.Name = "Cage4Pct"
        Me.Cage4Pct.Size = New System.Drawing.Size(110, 100)
        Me.Cage4Pct.TabIndex = 30
        Me.Cage4Pct.TabStop = False
        '
        'Cage3Pct
        '
        Me.Cage3Pct.BackColor = System.Drawing.Color.Transparent
        Me.Cage3Pct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Cage3Pct.Location = New System.Drawing.Point(345, 290)
        Me.Cage3Pct.Name = "Cage3Pct"
        Me.Cage3Pct.Size = New System.Drawing.Size(110, 100)
        Me.Cage3Pct.TabIndex = 29
        Me.Cage3Pct.TabStop = False
        '
        'Cage2Pct
        '
        Me.Cage2Pct.BackColor = System.Drawing.Color.Transparent
        Me.Cage2Pct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Cage2Pct.Location = New System.Drawing.Point(192, 290)
        Me.Cage2Pct.Name = "Cage2Pct"
        Me.Cage2Pct.Size = New System.Drawing.Size(110, 100)
        Me.Cage2Pct.TabIndex = 28
        Me.Cage2Pct.TabStop = False
        '
        'Cage1Pct
        '
        Me.Cage1Pct.BackColor = System.Drawing.Color.Transparent
        Me.Cage1Pct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Cage1Pct.Location = New System.Drawing.Point(37, 290)
        Me.Cage1Pct.Name = "Cage1Pct"
        Me.Cage1Pct.Size = New System.Drawing.Size(100, 100)
        Me.Cage1Pct.TabIndex = 27
        Me.Cage1Pct.TabStop = False
        '
        'BackTimer
        '
        Me.BackTimer.Interval = 1000
        '
        'StoryTimer
        '
        '
        'PetPct
        '
        Me.PetPct.BackColor = System.Drawing.Color.Transparent
        Me.PetPct.Location = New System.Drawing.Point(680, 480)
        Me.PetPct.Name = "PetPct"
        Me.PetPct.Size = New System.Drawing.Size(65, 65)
        Me.PetPct.TabIndex = 34
        Me.PetPct.TabStop = False
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
        Me.SetBtn.TabIndex = 37
        Me.SetBtn.Text = "☺"
        Me.SetBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.SetBtn.UseVisualStyleBackColor = False
        '
        'RetrieveForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.SetBtn)
        Me.Controls.Add(Me.PetPct)
        Me.Controls.Add(Me.Cage5Pct)
        Me.Controls.Add(Me.Cage4Pct)
        Me.Controls.Add(Me.Cage3Pct)
        Me.Controls.Add(Me.Cage2Pct)
        Me.Controls.Add(Me.Cage1Pct)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RetrieveForm"
        CType(Me.Cage5Pct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cage4Pct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cage3Pct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cage2Pct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cage1Pct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PetPct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Cage5Pct As PictureBox
    Friend WithEvents Cage4Pct As PictureBox
    Friend WithEvents Cage3Pct As PictureBox
    Friend WithEvents Cage2Pct As PictureBox
    Friend WithEvents Cage1Pct As PictureBox
    Friend WithEvents BackTimer As Timer
    Friend WithEvents StoryTimer As Timer
    Friend WithEvents PetPct As PictureBox
    Friend WithEvents SetBtn As Button
End Class
