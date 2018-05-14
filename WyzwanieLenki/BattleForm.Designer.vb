<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BattleForm
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
        Me.BackTimer = New System.Windows.Forms.Timer(Me.components)
        Me.StoryTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TitleLay = New System.Windows.Forms.TableLayoutPanel()
        Me.Title2Lbl = New System.Windows.Forms.Label()
        Me.Title1Lbl = New System.Windows.Forms.Label()
        Me.StartBtn = New System.Windows.Forms.Button()
        Me.CagePct = New System.Windows.Forms.PictureBox()
        Me.SetBtn = New System.Windows.Forms.Button()
        Me.ScoreLbl = New System.Windows.Forms.Label()
        Me.ScoreLay = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.LenkaPct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RatPct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TitleLay.SuspendLayout()
        CType(Me.CagePct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ScoreLay.SuspendLayout()
        Me.SuspendLayout()
        '
        'LenkaPct
        '
        Me.LenkaPct.BackColor = System.Drawing.Color.Transparent
        Me.LenkaPct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.LenkaPct.Location = New System.Drawing.Point(140, 297)
        Me.LenkaPct.Name = "LenkaPct"
        Me.LenkaPct.Size = New System.Drawing.Size(120, 265)
        Me.LenkaPct.TabIndex = 14
        Me.LenkaPct.TabStop = False
        '
        'RatPct
        '
        Me.RatPct.BackColor = System.Drawing.Color.Transparent
        Me.RatPct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RatPct.Location = New System.Drawing.Point(540, 352)
        Me.RatPct.Name = "RatPct"
        Me.RatPct.Size = New System.Drawing.Size(175, 210)
        Me.RatPct.TabIndex = 15
        Me.RatPct.TabStop = False
        '
        'BackTimer
        '
        '
        'TitleLay
        '
        Me.TitleLay.ColumnCount = 1
        Me.TitleLay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TitleLay.Controls.Add(Me.Title2Lbl, 0, 1)
        Me.TitleLay.Controls.Add(Me.Title1Lbl, 0, 0)
        Me.TitleLay.Location = New System.Drawing.Point(100, 23)
        Me.TitleLay.Name = "TitleLay"
        Me.TitleLay.RowCount = 2
        Me.TitleLay.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TitleLay.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TitleLay.Size = New System.Drawing.Size(600, 200)
        Me.TitleLay.TabIndex = 16
        '
        'Title2Lbl
        '
        Me.Title2Lbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Title2Lbl.AutoSize = True
        Me.Title2Lbl.Location = New System.Drawing.Point(276, 187)
        Me.Title2Lbl.Name = "Title2Lbl"
        Me.Title2Lbl.Size = New System.Drawing.Size(47, 13)
        Me.Title2Lbl.TabIndex = 1
        Me.Title2Lbl.Text = "Title2Lbl"
        Me.Title2Lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Title1Lbl
        '
        Me.Title1Lbl.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Title1Lbl.AutoSize = True
        Me.Title1Lbl.Location = New System.Drawing.Point(276, 0)
        Me.Title1Lbl.Name = "Title1Lbl"
        Me.Title1Lbl.Size = New System.Drawing.Size(47, 13)
        Me.Title1Lbl.TabIndex = 0
        Me.Title1Lbl.Text = "Title1Lbl"
        Me.Title1Lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'StartBtn
        '
        Me.StartBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.StartBtn.FlatAppearance.BorderSize = 0
        Me.StartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StartBtn.Location = New System.Drawing.Point(310, 500)
        Me.StartBtn.Name = "StartBtn"
        Me.StartBtn.Size = New System.Drawing.Size(180, 50)
        Me.StartBtn.TabIndex = 17
        Me.StartBtn.Text = "START"
        Me.StartBtn.UseVisualStyleBackColor = True
        '
        'CagePct
        '
        Me.CagePct.BackColor = System.Drawing.Color.Transparent
        Me.CagePct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CagePct.Location = New System.Drawing.Point(350, 300)
        Me.CagePct.Name = "CagePct"
        Me.CagePct.Size = New System.Drawing.Size(100, 100)
        Me.CagePct.TabIndex = 19
        Me.CagePct.TabStop = False
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
        Me.SetBtn.TabIndex = 28
        Me.SetBtn.Text = "☺"
        Me.SetBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.SetBtn.UseVisualStyleBackColor = False
        '
        'ScoreLbl
        '
        Me.ScoreLbl.AutoSize = True
        Me.ScoreLbl.Location = New System.Drawing.Point(3, 0)
        Me.ScoreLbl.Name = "ScoreLbl"
        Me.ScoreLbl.Size = New System.Drawing.Size(35, 13)
        Me.ScoreLbl.TabIndex = 29
        Me.ScoreLbl.Text = "Score"
        '
        'ScoreLay
        '
        Me.ScoreLay.BackColor = System.Drawing.Color.Transparent
        Me.ScoreLay.ColumnCount = 1
        Me.ScoreLay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.ScoreLay.Controls.Add(Me.ScoreLbl, 0, 0)
        Me.ScoreLay.Location = New System.Drawing.Point(0, 0)
        Me.ScoreLay.Name = "ScoreLay"
        Me.ScoreLay.RowCount = 1
        Me.ScoreLay.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.ScoreLay.Size = New System.Drawing.Size(130, 50)
        Me.ScoreLay.TabIndex = 30
        '
        'BattleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.ScoreLay)
        Me.Controls.Add(Me.TitleLay)
        Me.Controls.Add(Me.SetBtn)
        Me.Controls.Add(Me.CagePct)
        Me.Controls.Add(Me.StartBtn)
        Me.Controls.Add(Me.RatPct)
        Me.Controls.Add(Me.LenkaPct)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BattleForm"
        CType(Me.LenkaPct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RatPct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TitleLay.ResumeLayout(False)
        Me.TitleLay.PerformLayout()
        CType(Me.CagePct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ScoreLay.ResumeLayout(False)
        Me.ScoreLay.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LenkaPct As PictureBox
    Friend WithEvents RatPct As PictureBox
    Friend WithEvents BackTimer As Timer
    Friend WithEvents StoryTimer As Timer
    Friend WithEvents TitleLay As TableLayoutPanel
    Friend WithEvents Title2Lbl As Label
    Friend WithEvents Title1Lbl As Label
    Friend WithEvents StartBtn As Button
    Friend WithEvents CagePct As PictureBox
    Friend WithEvents SetBtn As Button
    Friend WithEvents ScoreLbl As Label
    Friend WithEvents ScoreLay As TableLayoutPanel
End Class
