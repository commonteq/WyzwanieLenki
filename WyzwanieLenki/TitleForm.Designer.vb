<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TitleForm
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
        Me.A1Pct = New System.Windows.Forms.PictureBox()
        Me.A2Pct = New System.Windows.Forms.PictureBox()
        Me.TitleLay = New System.Windows.Forms.TableLayoutPanel()
        Me.Title2Lbl = New System.Windows.Forms.Label()
        Me.Title1Lbl = New System.Windows.Forms.Label()
        Me.StartBtn = New System.Windows.Forms.Button()
        Me.StoryTimer = New System.Windows.Forms.Timer(Me.components)
        Me.LenkaPct = New System.Windows.Forms.PictureBox()
        Me.RatPct = New System.Windows.Forms.PictureBox()
        Me.PetPct = New System.Windows.Forms.PictureBox()
        Me.SetBtn = New System.Windows.Forms.Button()
        CType(Me.A1Pct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.A2Pct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TitleLay.SuspendLayout()
        CType(Me.LenkaPct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RatPct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PetPct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'A1Pct
        '
        Me.A1Pct.Location = New System.Drawing.Point(30, 40)
        Me.A1Pct.Name = "A1Pct"
        Me.A1Pct.Size = New System.Drawing.Size(758, 90)
        Me.A1Pct.TabIndex = 1
        Me.A1Pct.TabStop = False
        '
        'A2Pct
        '
        Me.A2Pct.Location = New System.Drawing.Point(30, 136)
        Me.A2Pct.Name = "A2Pct"
        Me.A2Pct.Size = New System.Drawing.Size(758, 90)
        Me.A2Pct.TabIndex = 2
        Me.A2Pct.TabStop = False
        '
        'TitleLay
        '
        Me.TitleLay.ColumnCount = 1
        Me.TitleLay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TitleLay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TitleLay.Controls.Add(Me.Title2Lbl, 0, 1)
        Me.TitleLay.Controls.Add(Me.Title1Lbl, 0, 0)
        Me.TitleLay.Location = New System.Drawing.Point(30, 250)
        Me.TitleLay.Name = "TitleLay"
        Me.TitleLay.RowCount = 2
        Me.TitleLay.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TitleLay.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TitleLay.Size = New System.Drawing.Size(758, 130)
        Me.TitleLay.TabIndex = 3
        '
        'Title2Lbl
        '
        Me.Title2Lbl.AutoSize = True
        Me.Title2Lbl.Location = New System.Drawing.Point(50, 65)
        Me.Title2Lbl.Margin = New System.Windows.Forms.Padding(50, 0, 3, 0)
        Me.Title2Lbl.Name = "Title2Lbl"
        Me.Title2Lbl.Size = New System.Drawing.Size(47, 13)
        Me.Title2Lbl.TabIndex = 1
        Me.Title2Lbl.Text = "Title2Lbl"
        '
        'Title1Lbl
        '
        Me.Title1Lbl.AutoSize = True
        Me.Title1Lbl.Location = New System.Drawing.Point(3, 0)
        Me.Title1Lbl.Name = "Title1Lbl"
        Me.Title1Lbl.Size = New System.Drawing.Size(47, 13)
        Me.Title1Lbl.TabIndex = 0
        Me.Title1Lbl.Text = "Title1Lbl"
        '
        'StartBtn
        '
        Me.StartBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.StartBtn.FlatAppearance.BorderSize = 0
        Me.StartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StartBtn.Location = New System.Drawing.Point(310, 500)
        Me.StartBtn.Name = "StartBtn"
        Me.StartBtn.Size = New System.Drawing.Size(180, 50)
        Me.StartBtn.TabIndex = 4
        Me.StartBtn.Text = "START"
        Me.StartBtn.UseVisualStyleBackColor = True
        '
        'StoryTimer
        '
        Me.StoryTimer.Interval = 10
        '
        'LenkaPct
        '
        Me.LenkaPct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.LenkaPct.Location = New System.Drawing.Point(30, 410)
        Me.LenkaPct.Name = "LenkaPct"
        Me.LenkaPct.Size = New System.Drawing.Size(130, 190)
        Me.LenkaPct.TabIndex = 5
        Me.LenkaPct.TabStop = False
        '
        'RatPct
        '
        Me.RatPct.BackColor = System.Drawing.Color.Transparent
        Me.RatPct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RatPct.Location = New System.Drawing.Point(615, 450)
        Me.RatPct.Name = "RatPct"
        Me.RatPct.Size = New System.Drawing.Size(175, 150)
        Me.RatPct.TabIndex = 6
        Me.RatPct.TabStop = False
        '
        'PetPct
        '
        Me.PetPct.BackColor = System.Drawing.Color.Transparent
        Me.PetPct.Location = New System.Drawing.Point(190, 460)
        Me.PetPct.Name = "PetPct"
        Me.PetPct.Size = New System.Drawing.Size(100, 140)
        Me.PetPct.TabIndex = 7
        Me.PetPct.TabStop = False
        '
        'SetBtn
        '
        Me.SetBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SetBtn.FlatAppearance.BorderSize = 0
        Me.SetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SetBtn.Location = New System.Drawing.Point(738, 12)
        Me.SetBtn.Name = "SetBtn"
        Me.SetBtn.Size = New System.Drawing.Size(50, 50)
        Me.SetBtn.TabIndex = 8
        Me.SetBtn.Text = "☺"
        Me.SetBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.SetBtn.UseVisualStyleBackColor = True
        '
        'TitleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.SetBtn)
        Me.Controls.Add(Me.StartBtn)
        Me.Controls.Add(Me.RatPct)
        Me.Controls.Add(Me.LenkaPct)
        Me.Controls.Add(Me.PetPct)
        Me.Controls.Add(Me.TitleLay)
        Me.Controls.Add(Me.A2Pct)
        Me.Controls.Add(Me.A1Pct)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TitleForm"
        Me.Text = "Wyzwanie Lenki"
        CType(Me.A1Pct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.A2Pct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TitleLay.ResumeLayout(False)
        Me.TitleLay.PerformLayout()
        CType(Me.LenkaPct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RatPct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PetPct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents A1Pct As PictureBox
    Friend WithEvents A2Pct As PictureBox
    Friend WithEvents TitleLay As TableLayoutPanel
    Friend WithEvents Title2Lbl As Label
    Friend WithEvents Title1Lbl As Label
    Friend WithEvents StartBtn As Button
    Friend WithEvents StoryTimer As Timer
    Friend WithEvents LenkaPct As PictureBox
    Friend WithEvents RatPct As PictureBox
    Friend WithEvents PetPct As PictureBox
    Friend WithEvents SetBtn As Button
End Class
