<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FightForm
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
        Me.LenkaPct = New System.Windows.Forms.PictureBox()
        Me.RatPct = New System.Windows.Forms.PictureBox()
        Me.ScoreTab = New System.Windows.Forms.ProgressBar()
        Me.TimeLbl = New System.Windows.Forms.Label()
        Me.TimeLay = New System.Windows.Forms.TableLayoutPanel()
        Me.Result1Btn = New System.Windows.Forms.Button()
        Me.Result2Btn = New System.Windows.Forms.Button()
        Me.Result3Btn = New System.Windows.Forms.Button()
        Me.Result4Btn = New System.Windows.Forms.Button()
        Me.ResultLay = New System.Windows.Forms.TableLayoutPanel()
        Me.EquaLay = New System.Windows.Forms.TableLayoutPanel()
        Me.Value2Lbl = New System.Windows.Forms.Label()
        Me.SignLbl = New System.Windows.Forms.Label()
        Me.Value1Lbl = New System.Windows.Forms.Label()
        Me.EqualLbl = New System.Windows.Forms.Label()
        Me.CagePct = New System.Windows.Forms.PictureBox()
        Me.KeyPct = New System.Windows.Forms.PictureBox()
        Me.BackTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TimeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.StartTimer = New System.Windows.Forms.Timer(Me.components)
        Me.StartBtn = New System.Windows.Forms.Button()
        Me.SetBtn = New System.Windows.Forms.Button()
        Me.CommLbl = New System.Windows.Forms.Label()
        Me.CommLay = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.LenkaPct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RatPct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TimeLay.SuspendLayout()
        Me.ResultLay.SuspendLayout()
        Me.EquaLay.SuspendLayout()
        CType(Me.CagePct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KeyPct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CommLay.SuspendLayout()
        Me.SuspendLayout()
        '
        'LenkaPct
        '
        Me.LenkaPct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.LenkaPct.Location = New System.Drawing.Point(30, 415)
        Me.LenkaPct.Name = "LenkaPct"
        Me.LenkaPct.Size = New System.Drawing.Size(130, 190)
        Me.LenkaPct.TabIndex = 6
        Me.LenkaPct.TabStop = False
        '
        'RatPct
        '
        Me.RatPct.BackColor = System.Drawing.Color.Transparent
        Me.RatPct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RatPct.Location = New System.Drawing.Point(615, 460)
        Me.RatPct.Name = "RatPct"
        Me.RatPct.Size = New System.Drawing.Size(175, 150)
        Me.RatPct.TabIndex = 7
        Me.RatPct.TabStop = False
        '
        'ScoreTab
        '
        Me.ScoreTab.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ScoreTab.Location = New System.Drawing.Point(150, 12)
        Me.ScoreTab.Maximum = 5
        Me.ScoreTab.Name = "ScoreTab"
        Me.ScoreTab.Size = New System.Drawing.Size(565, 50)
        Me.ScoreTab.Step = 5
        Me.ScoreTab.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ScoreTab.TabIndex = 9
        '
        'TimeLbl
        '
        Me.TimeLbl.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TimeLbl.AutoSize = True
        Me.TimeLbl.Location = New System.Drawing.Point(3, 18)
        Me.TimeLbl.Name = "TimeLbl"
        Me.TimeLbl.Size = New System.Drawing.Size(44, 13)
        Me.TimeLbl.TabIndex = 10
        Me.TimeLbl.Text = "TimeLbl"
        '
        'TimeLay
        '
        Me.TimeLay.BackColor = System.Drawing.Color.Transparent
        Me.TimeLay.ColumnCount = 1
        Me.TimeLay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TimeLay.Controls.Add(Me.TimeLbl, 0, 0)
        Me.TimeLay.Location = New System.Drawing.Point(12, 12)
        Me.TimeLay.Name = "TimeLay"
        Me.TimeLay.RowCount = 1
        Me.TimeLay.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TimeLay.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TimeLay.Size = New System.Drawing.Size(130, 50)
        Me.TimeLay.TabIndex = 11
        '
        'Result1Btn
        '
        Me.Result1Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Result1Btn.FlatAppearance.BorderSize = 0
        Me.Result1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Result1Btn.Location = New System.Drawing.Point(3, 3)
        Me.Result1Btn.Name = "Result1Btn"
        Me.Result1Btn.Size = New System.Drawing.Size(142, 94)
        Me.Result1Btn.TabIndex = 12
        Me.Result1Btn.Text = "Result1Btn"
        Me.Result1Btn.UseVisualStyleBackColor = True
        '
        'Result2Btn
        '
        Me.Result2Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Result2Btn.FlatAppearance.BorderSize = 0
        Me.Result2Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Result2Btn.Location = New System.Drawing.Point(151, 3)
        Me.Result2Btn.Name = "Result2Btn"
        Me.Result2Btn.Size = New System.Drawing.Size(142, 94)
        Me.Result2Btn.TabIndex = 13
        Me.Result2Btn.Text = "Result2Btn"
        Me.Result2Btn.UseVisualStyleBackColor = True
        '
        'Result3Btn
        '
        Me.Result3Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Result3Btn.FlatAppearance.BorderSize = 0
        Me.Result3Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Result3Btn.Location = New System.Drawing.Point(299, 3)
        Me.Result3Btn.Name = "Result3Btn"
        Me.Result3Btn.Size = New System.Drawing.Size(142, 94)
        Me.Result3Btn.TabIndex = 14
        Me.Result3Btn.Text = "Result3Btn"
        Me.Result3Btn.UseVisualStyleBackColor = True
        '
        'Result4Btn
        '
        Me.Result4Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Result4Btn.FlatAppearance.BorderSize = 0
        Me.Result4Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Result4Btn.Location = New System.Drawing.Point(447, 3)
        Me.Result4Btn.Name = "Result4Btn"
        Me.Result4Btn.Size = New System.Drawing.Size(144, 94)
        Me.Result4Btn.TabIndex = 15
        Me.Result4Btn.Text = "Result4Btn"
        Me.Result4Btn.UseVisualStyleBackColor = True
        '
        'ResultLay
        '
        Me.ResultLay.ColumnCount = 4
        Me.ResultLay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.ResultLay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.ResultLay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.ResultLay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.ResultLay.Controls.Add(Me.Result1Btn, 0, 0)
        Me.ResultLay.Controls.Add(Me.Result4Btn, 3, 0)
        Me.ResultLay.Controls.Add(Me.Result2Btn, 1, 0)
        Me.ResultLay.Controls.Add(Me.Result3Btn, 2, 0)
        Me.ResultLay.Location = New System.Drawing.Point(106, 210)
        Me.ResultLay.Name = "ResultLay"
        Me.ResultLay.RowCount = 1
        Me.ResultLay.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.ResultLay.Size = New System.Drawing.Size(594, 100)
        Me.ResultLay.TabIndex = 16
        Me.ResultLay.Visible = False
        '
        'EquaLay
        '
        Me.EquaLay.BackColor = System.Drawing.Color.Transparent
        Me.EquaLay.ColumnCount = 4
        Me.EquaLay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.EquaLay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.EquaLay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.EquaLay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.EquaLay.Controls.Add(Me.Value2Lbl, 2, 0)
        Me.EquaLay.Controls.Add(Me.SignLbl, 1, 0)
        Me.EquaLay.Controls.Add(Me.Value1Lbl, 0, 0)
        Me.EquaLay.Controls.Add(Me.EqualLbl, 3, 0)
        Me.EquaLay.Location = New System.Drawing.Point(150, 100)
        Me.EquaLay.Name = "EquaLay"
        Me.EquaLay.RowCount = 1
        Me.EquaLay.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.EquaLay.Size = New System.Drawing.Size(500, 100)
        Me.EquaLay.TabIndex = 17
        Me.EquaLay.Visible = False
        '
        'Value2Lbl
        '
        Me.Value2Lbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Value2Lbl.AutoSize = True
        Me.Value2Lbl.Location = New System.Drawing.Point(298, 43)
        Me.Value2Lbl.Name = "Value2Lbl"
        Me.Value2Lbl.Size = New System.Drawing.Size(54, 13)
        Me.Value2Lbl.TabIndex = 2
        Me.Value2Lbl.Text = "Value2Lbl"
        '
        'SignLbl
        '
        Me.SignLbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SignLbl.AutoSize = True
        Me.SignLbl.Location = New System.Drawing.Point(186, 43)
        Me.SignLbl.Name = "SignLbl"
        Me.SignLbl.Size = New System.Drawing.Size(28, 13)
        Me.SignLbl.TabIndex = 1
        Me.SignLbl.Text = "Sign"
        '
        'Value1Lbl
        '
        Me.Value1Lbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Value1Lbl.AutoSize = True
        Me.Value1Lbl.Location = New System.Drawing.Point(48, 43)
        Me.Value1Lbl.Name = "Value1Lbl"
        Me.Value1Lbl.Size = New System.Drawing.Size(54, 13)
        Me.Value1Lbl.TabIndex = 0
        Me.Value1Lbl.Text = "Value1Lbl"
        '
        'EqualLbl
        '
        Me.EqualLbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.EqualLbl.AutoSize = True
        Me.EqualLbl.Location = New System.Drawing.Point(426, 43)
        Me.EqualLbl.Name = "EqualLbl"
        Me.EqualLbl.Size = New System.Drawing.Size(48, 13)
        Me.EqualLbl.TabIndex = 3
        Me.EqualLbl.Text = "EqualLbl"
        '
        'CagePct
        '
        Me.CagePct.BackColor = System.Drawing.Color.Transparent
        Me.CagePct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CagePct.Location = New System.Drawing.Point(257, 340)
        Me.CagePct.Name = "CagePct"
        Me.CagePct.Size = New System.Drawing.Size(100, 100)
        Me.CagePct.TabIndex = 20
        Me.CagePct.TabStop = False
        '
        'KeyPct
        '
        Me.KeyPct.BackColor = System.Drawing.Color.Transparent
        Me.KeyPct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.KeyPct.Location = New System.Drawing.Point(500, 385)
        Me.KeyPct.Name = "KeyPct"
        Me.KeyPct.Size = New System.Drawing.Size(50, 25)
        Me.KeyPct.TabIndex = 21
        Me.KeyPct.TabStop = False
        '
        'BackTimer
        '
        Me.BackTimer.Interval = 1000
        '
        'TimeTimer
        '
        Me.TimeTimer.Interval = 1000
        '
        'StartTimer
        '
        Me.StartTimer.Interval = 1000
        '
        'StartBtn
        '
        Me.StartBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.StartBtn.FlatAppearance.BorderSize = 0
        Me.StartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StartBtn.Location = New System.Drawing.Point(310, 500)
        Me.StartBtn.Name = "StartBtn"
        Me.StartBtn.Size = New System.Drawing.Size(180, 50)
        Me.StartBtn.TabIndex = 25
        Me.StartBtn.Text = "START"
        Me.StartBtn.UseVisualStyleBackColor = True
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
        Me.SetBtn.TabIndex = 29
        Me.SetBtn.Text = "☺"
        Me.SetBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.SetBtn.UseVisualStyleBackColor = False
        '
        'CommLbl
        '
        Me.CommLbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CommLbl.AutoSize = True
        Me.CommLbl.BackColor = System.Drawing.Color.Transparent
        Me.CommLbl.Location = New System.Drawing.Point(272, 49)
        Me.CommLbl.Name = "CommLbl"
        Me.CommLbl.Size = New System.Drawing.Size(50, 13)
        Me.CommLbl.TabIndex = 0
        Me.CommLbl.Text = "CommLbl"
        '
        'CommLay
        '
        Me.CommLay.BackColor = System.Drawing.Color.Transparent
        Me.CommLay.ColumnCount = 1
        Me.CommLay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.CommLay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.CommLay.Controls.Add(Me.CommLbl, 0, 0)
        Me.CommLay.Location = New System.Drawing.Point(106, 210)
        Me.CommLay.Name = "CommLay"
        Me.CommLay.RowCount = 1
        Me.CommLay.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.CommLay.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112.0!))
        Me.CommLay.Size = New System.Drawing.Size(594, 112)
        Me.CommLay.TabIndex = 22
        Me.CommLay.Visible = False
        '
        'FightForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.SetBtn)
        Me.Controls.Add(Me.StartBtn)
        Me.Controls.Add(Me.CommLay)
        Me.Controls.Add(Me.KeyPct)
        Me.Controls.Add(Me.CagePct)
        Me.Controls.Add(Me.EquaLay)
        Me.Controls.Add(Me.ResultLay)
        Me.Controls.Add(Me.TimeLay)
        Me.Controls.Add(Me.ScoreTab)
        Me.Controls.Add(Me.RatPct)
        Me.Controls.Add(Me.LenkaPct)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FightForm"
        CType(Me.LenkaPct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RatPct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TimeLay.ResumeLayout(False)
        Me.TimeLay.PerformLayout()
        Me.ResultLay.ResumeLayout(False)
        Me.EquaLay.ResumeLayout(False)
        Me.EquaLay.PerformLayout()
        CType(Me.CagePct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KeyPct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CommLay.ResumeLayout(False)
        Me.CommLay.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LenkaPct As PictureBox
    Friend WithEvents RatPct As PictureBox
    Friend WithEvents ScoreTab As ProgressBar
    Friend WithEvents TimeLbl As Label
    Friend WithEvents TimeLay As TableLayoutPanel
    Friend WithEvents Result1Btn As Button
    Friend WithEvents Result2Btn As Button
    Friend WithEvents Result3Btn As Button
    Friend WithEvents Result4Btn As Button
    Friend WithEvents ResultLay As TableLayoutPanel
    Friend WithEvents EquaLay As TableLayoutPanel
    Friend WithEvents EqualLbl As Label
    Friend WithEvents Value2Lbl As Label
    Friend WithEvents SignLbl As Label
    Friend WithEvents Value1Lbl As Label
    Friend WithEvents CagePct As PictureBox
    Friend WithEvents KeyPct As PictureBox
    Friend WithEvents BackTimer As Timer
    Friend WithEvents TimeTimer As Timer
    Friend WithEvents StartTimer As Timer
    Friend WithEvents StartBtn As Button
    Friend WithEvents SetBtn As Button
    Friend WithEvents CommLbl As Label
    Friend WithEvents CommLay As TableLayoutPanel
End Class
