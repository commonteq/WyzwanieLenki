<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm
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
        Me.TabLay = New System.Windows.Forms.TableLayoutPanel()
        Me.LoadBtn = New System.Windows.Forms.Button()
        Me.Score1 = New System.Windows.Forms.TextBox()
        Me.AdminLbl = New System.Windows.Forms.Label()
        Me.No1 = New System.Windows.Forms.Label()
        Me.No2 = New System.Windows.Forms.Label()
        Me.No3 = New System.Windows.Forms.Label()
        Me.No4 = New System.Windows.Forms.Label()
        Me.No5 = New System.Windows.Forms.Label()
        Me.Name1 = New System.Windows.Forms.TextBox()
        Me.Name2 = New System.Windows.Forms.TextBox()
        Me.Name3 = New System.Windows.Forms.TextBox()
        Me.Name4 = New System.Windows.Forms.TextBox()
        Me.Score2 = New System.Windows.Forms.TextBox()
        Me.Score3 = New System.Windows.Forms.TextBox()
        Me.Score4 = New System.Windows.Forms.TextBox()
        Me.Score5 = New System.Windows.Forms.TextBox()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.CheatChBox = New System.Windows.Forms.CheckBox()
        Me.FormCBox = New System.Windows.Forms.ComboBox()
        Me.OpenBtn = New System.Windows.Forms.Button()
        Me.GoBtn = New System.Windows.Forms.Button()
        Me.Name5 = New System.Windows.Forms.TextBox()
        Me.SortBtn = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.LevelLbl = New System.Windows.Forms.Label()
        Me.LevelNum = New System.Windows.Forms.NumericUpDown()
        Me.FightNum = New System.Windows.Forms.NumericUpDown()
        Me.FightLbl = New System.Windows.Forms.Label()
        Me.ValScore = New System.Windows.Forms.TextBox()
        Me.ScoreBtn = New System.Windows.Forms.Button()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.ValScoreLbl = New System.Windows.Forms.Label()
        Me.TabLay.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.LevelNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FightNum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabLay
        '
        Me.TabLay.ColumnCount = 4
        Me.TabLay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TabLay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300.0!))
        Me.TabLay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300.0!))
        Me.TabLay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TabLay.Controls.Add(Me.LoadBtn, 3, 1)
        Me.TabLay.Controls.Add(Me.Score1, 2, 1)
        Me.TabLay.Controls.Add(Me.AdminLbl, 0, 0)
        Me.TabLay.Controls.Add(Me.No1, 0, 1)
        Me.TabLay.Controls.Add(Me.No2, 0, 2)
        Me.TabLay.Controls.Add(Me.No3, 0, 3)
        Me.TabLay.Controls.Add(Me.No4, 0, 4)
        Me.TabLay.Controls.Add(Me.No5, 0, 5)
        Me.TabLay.Controls.Add(Me.Name1, 1, 1)
        Me.TabLay.Controls.Add(Me.Name2, 1, 2)
        Me.TabLay.Controls.Add(Me.Name3, 1, 3)
        Me.TabLay.Controls.Add(Me.Name4, 1, 4)
        Me.TabLay.Controls.Add(Me.Score2, 2, 2)
        Me.TabLay.Controls.Add(Me.Score3, 2, 3)
        Me.TabLay.Controls.Add(Me.Score4, 2, 4)
        Me.TabLay.Controls.Add(Me.Score5, 2, 5)
        Me.TabLay.Controls.Add(Me.CloseBtn, 3, 8)
        Me.TabLay.Controls.Add(Me.CheatChBox, 1, 8)
        Me.TabLay.Controls.Add(Me.FormCBox, 1, 6)
        Me.TabLay.Controls.Add(Me.OpenBtn, 0, 6)
        Me.TabLay.Controls.Add(Me.GoBtn, 0, 7)
        Me.TabLay.Controls.Add(Me.Name5, 1, 5)
        Me.TabLay.Controls.Add(Me.SortBtn, 3, 2)
        Me.TabLay.Controls.Add(Me.TableLayoutPanel1, 1, 7)
        Me.TabLay.Controls.Add(Me.ValScore, 2, 7)
        Me.TabLay.Controls.Add(Me.ScoreBtn, 3, 7)
        Me.TabLay.Controls.Add(Me.SaveBtn, 3, 4)
        Me.TabLay.Controls.Add(Me.ClearBtn, 3, 3)
        Me.TabLay.Controls.Add(Me.ValScoreLbl, 2, 6)
        Me.TabLay.Location = New System.Drawing.Point(0, 0)
        Me.TabLay.Name = "TabLay"
        Me.TabLay.RowCount = 9
        Me.TabLay.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TabLay.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65.0!))
        Me.TabLay.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65.0!))
        Me.TabLay.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65.0!))
        Me.TabLay.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65.0!))
        Me.TabLay.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65.0!))
        Me.TabLay.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65.0!))
        Me.TabLay.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65.0!))
        Me.TabLay.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65.0!))
        Me.TabLay.Size = New System.Drawing.Size(800, 600)
        Me.TabLay.TabIndex = 0
        '
        'LoadBtn
        '
        Me.LoadBtn.Location = New System.Drawing.Point(703, 83)
        Me.LoadBtn.Name = "LoadBtn"
        Me.LoadBtn.Size = New System.Drawing.Size(94, 59)
        Me.LoadBtn.TabIndex = 23
        Me.LoadBtn.Text = "Load"
        Me.LoadBtn.UseVisualStyleBackColor = True
        '
        'Score1
        '
        Me.Score1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Score1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Score1.Location = New System.Drawing.Point(403, 106)
        Me.Score1.Name = "Score1"
        Me.Score1.Size = New System.Drawing.Size(294, 13)
        Me.Score1.TabIndex = 13
        '
        'AdminLbl
        '
        Me.AdminLbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AdminLbl.AutoSize = True
        Me.TabLay.SetColumnSpan(Me.AdminLbl, 4)
        Me.AdminLbl.Location = New System.Drawing.Point(382, 33)
        Me.AdminLbl.Name = "AdminLbl"
        Me.AdminLbl.Size = New System.Drawing.Size(36, 13)
        Me.AdminLbl.TabIndex = 0
        Me.AdminLbl.Text = "Admin"
        '
        'No1
        '
        Me.No1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.No1.AutoSize = True
        Me.No1.Location = New System.Drawing.Point(36, 106)
        Me.No1.Name = "No1"
        Me.No1.Size = New System.Drawing.Size(27, 13)
        Me.No1.TabIndex = 1
        Me.No1.Text = "No1"
        '
        'No2
        '
        Me.No2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.No2.AutoSize = True
        Me.No2.Location = New System.Drawing.Point(36, 171)
        Me.No2.Name = "No2"
        Me.No2.Size = New System.Drawing.Size(27, 13)
        Me.No2.TabIndex = 2
        Me.No2.Text = "No2"
        '
        'No3
        '
        Me.No3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.No3.AutoSize = True
        Me.No3.Location = New System.Drawing.Point(36, 236)
        Me.No3.Name = "No3"
        Me.No3.Size = New System.Drawing.Size(27, 13)
        Me.No3.TabIndex = 3
        Me.No3.Text = "No3"
        '
        'No4
        '
        Me.No4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.No4.AutoSize = True
        Me.No4.Location = New System.Drawing.Point(36, 301)
        Me.No4.Name = "No4"
        Me.No4.Size = New System.Drawing.Size(27, 13)
        Me.No4.TabIndex = 4
        Me.No4.Text = "No4"
        '
        'No5
        '
        Me.No5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.No5.AutoSize = True
        Me.No5.Location = New System.Drawing.Point(36, 366)
        Me.No5.Name = "No5"
        Me.No5.Size = New System.Drawing.Size(27, 13)
        Me.No5.TabIndex = 5
        Me.No5.Text = "No5"
        '
        'Name1
        '
        Me.Name1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Name1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Name1.Location = New System.Drawing.Point(103, 106)
        Me.Name1.Name = "Name1"
        Me.Name1.Size = New System.Drawing.Size(294, 13)
        Me.Name1.TabIndex = 8
        '
        'Name2
        '
        Me.Name2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Name2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Name2.Location = New System.Drawing.Point(103, 171)
        Me.Name2.Name = "Name2"
        Me.Name2.Size = New System.Drawing.Size(294, 13)
        Me.Name2.TabIndex = 9
        '
        'Name3
        '
        Me.Name3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Name3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Name3.Location = New System.Drawing.Point(103, 236)
        Me.Name3.Name = "Name3"
        Me.Name3.Size = New System.Drawing.Size(294, 13)
        Me.Name3.TabIndex = 10
        '
        'Name4
        '
        Me.Name4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Name4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Name4.Location = New System.Drawing.Point(103, 301)
        Me.Name4.Name = "Name4"
        Me.Name4.Size = New System.Drawing.Size(294, 13)
        Me.Name4.TabIndex = 11
        '
        'Score2
        '
        Me.Score2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Score2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Score2.Location = New System.Drawing.Point(403, 171)
        Me.Score2.Name = "Score2"
        Me.Score2.Size = New System.Drawing.Size(294, 13)
        Me.Score2.TabIndex = 14
        '
        'Score3
        '
        Me.Score3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Score3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Score3.Location = New System.Drawing.Point(403, 236)
        Me.Score3.Name = "Score3"
        Me.Score3.Size = New System.Drawing.Size(294, 13)
        Me.Score3.TabIndex = 15
        '
        'Score4
        '
        Me.Score4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Score4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Score4.Location = New System.Drawing.Point(403, 301)
        Me.Score4.Name = "Score4"
        Me.Score4.Size = New System.Drawing.Size(294, 13)
        Me.Score4.TabIndex = 16
        '
        'Score5
        '
        Me.Score5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Score5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Score5.Location = New System.Drawing.Point(403, 366)
        Me.Score5.Name = "Score5"
        Me.Score5.Size = New System.Drawing.Size(294, 13)
        Me.Score5.TabIndex = 17
        '
        'CloseBtn
        '
        Me.CloseBtn.Location = New System.Drawing.Point(703, 538)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(94, 59)
        Me.CloseBtn.TabIndex = 21
        Me.CloseBtn.Text = "Close"
        Me.CloseBtn.UseVisualStyleBackColor = True
        '
        'CheatChBox
        '
        Me.CheatChBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.CheatChBox.AutoSize = True
        Me.CheatChBox.Location = New System.Drawing.Point(103, 559)
        Me.CheatChBox.Name = "CheatChBox"
        Me.CheatChBox.Size = New System.Drawing.Size(54, 17)
        Me.CheatChBox.TabIndex = 6
        Me.CheatChBox.Text = "Cheat"
        Me.CheatChBox.UseVisualStyleBackColor = True
        '
        'FormCBox
        '
        Me.FormCBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.FormCBox.FormattingEnabled = True
        Me.FormCBox.Items.AddRange(New Object() {"Battle", "Deploy", "Ending", "Fight", "Intro", "Lang", "Level", "Load", "Menu", "Outro", "Retrieve", "Rivals", "Run", "Score", "Title"})
        Me.FormCBox.Location = New System.Drawing.Point(103, 427)
        Me.FormCBox.Name = "FormCBox"
        Me.FormCBox.Size = New System.Drawing.Size(294, 21)
        Me.FormCBox.TabIndex = 18
        '
        'OpenBtn
        '
        Me.OpenBtn.Location = New System.Drawing.Point(3, 408)
        Me.OpenBtn.Name = "OpenBtn"
        Me.OpenBtn.Size = New System.Drawing.Size(94, 59)
        Me.OpenBtn.TabIndex = 19
        Me.OpenBtn.Text = "Open"
        Me.OpenBtn.UseVisualStyleBackColor = True
        '
        'GoBtn
        '
        Me.GoBtn.Location = New System.Drawing.Point(3, 473)
        Me.GoBtn.Name = "GoBtn"
        Me.GoBtn.Size = New System.Drawing.Size(94, 59)
        Me.GoBtn.TabIndex = 24
        Me.GoBtn.Text = "Go"
        Me.GoBtn.UseVisualStyleBackColor = True
        '
        'Name5
        '
        Me.Name5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Name5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Name5.Location = New System.Drawing.Point(103, 366)
        Me.Name5.Name = "Name5"
        Me.Name5.Size = New System.Drawing.Size(294, 13)
        Me.Name5.TabIndex = 12
        '
        'SortBtn
        '
        Me.SortBtn.Location = New System.Drawing.Point(703, 148)
        Me.SortBtn.Name = "SortBtn"
        Me.SortBtn.Size = New System.Drawing.Size(94, 59)
        Me.SortBtn.TabIndex = 26
        Me.SortBtn.Text = "Sort"
        Me.SortBtn.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.LevelLbl, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LevelNum, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.FightNum, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.FightLbl, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(103, 473)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(294, 59)
        Me.TableLayoutPanel1.TabIndex = 27
        '
        'LevelLbl
        '
        Me.LevelLbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LevelLbl.AutoSize = True
        Me.LevelLbl.Location = New System.Drawing.Point(204, 8)
        Me.LevelLbl.Name = "LevelLbl"
        Me.LevelLbl.Size = New System.Drawing.Size(33, 13)
        Me.LevelLbl.TabIndex = 27
        Me.LevelLbl.Text = "Level"
        '
        'LevelNum
        '
        Me.LevelNum.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LevelNum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LevelNum.Location = New System.Drawing.Point(150, 36)
        Me.LevelNum.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.LevelNum.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.LevelNum.Name = "LevelNum"
        Me.LevelNum.Size = New System.Drawing.Size(141, 16)
        Me.LevelNum.TabIndex = 25
        Me.LevelNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.LevelNum.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'FightNum
        '
        Me.FightNum.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.FightNum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FightNum.Location = New System.Drawing.Point(3, 36)
        Me.FightNum.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.FightNum.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.FightNum.Name = "FightNum"
        Me.FightNum.Size = New System.Drawing.Size(141, 16)
        Me.FightNum.TabIndex = 22
        Me.FightNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.FightNum.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'FightLbl
        '
        Me.FightLbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FightLbl.AutoSize = True
        Me.FightLbl.Location = New System.Drawing.Point(58, 8)
        Me.FightLbl.Name = "FightLbl"
        Me.FightLbl.Size = New System.Drawing.Size(30, 13)
        Me.FightLbl.TabIndex = 26
        Me.FightLbl.Text = "Fight"
        '
        'ValScore
        '
        Me.ValScore.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ValScore.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ValScore.Location = New System.Drawing.Point(403, 496)
        Me.ValScore.Name = "ValScore"
        Me.ValScore.Size = New System.Drawing.Size(294, 13)
        Me.ValScore.TabIndex = 28
        '
        'ScoreBtn
        '
        Me.ScoreBtn.Location = New System.Drawing.Point(703, 473)
        Me.ScoreBtn.Name = "ScoreBtn"
        Me.ScoreBtn.Size = New System.Drawing.Size(94, 59)
        Me.ScoreBtn.TabIndex = 29
        Me.ScoreBtn.Text = "Score"
        Me.ScoreBtn.UseVisualStyleBackColor = True
        '
        'SaveBtn
        '
        Me.SaveBtn.Location = New System.Drawing.Point(703, 278)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(94, 59)
        Me.SaveBtn.TabIndex = 20
        Me.SaveBtn.Text = "Save"
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'ClearBtn
        '
        Me.ClearBtn.Location = New System.Drawing.Point(703, 213)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(94, 59)
        Me.ClearBtn.TabIndex = 30
        Me.ClearBtn.Text = "Clear"
        Me.ClearBtn.UseVisualStyleBackColor = True
        '
        'ValScoreLbl
        '
        Me.ValScoreLbl.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ValScoreLbl.AutoSize = True
        Me.ValScoreLbl.Location = New System.Drawing.Point(647, 431)
        Me.ValScoreLbl.Name = "ValScoreLbl"
        Me.ValScoreLbl.Size = New System.Drawing.Size(50, 13)
        Me.ValScoreLbl.TabIndex = 31
        Me.ValScoreLbl.Text = "ValScore"
        '
        'AdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.TabLay)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminForm"
        Me.Text = "AdminForm"
        Me.TabLay.ResumeLayout(False)
        Me.TabLay.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.LevelNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FightNum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabLay As TableLayoutPanel
    Friend WithEvents AdminLbl As Label
    Friend WithEvents No1 As Label
    Friend WithEvents No2 As Label
    Friend WithEvents No3 As Label
    Friend WithEvents No4 As Label
    Friend WithEvents No5 As Label
    Friend WithEvents CheatChBox As CheckBox
    Friend WithEvents Score1 As TextBox
    Friend WithEvents Name1 As TextBox
    Friend WithEvents Name2 As TextBox
    Friend WithEvents Name3 As TextBox
    Friend WithEvents Name4 As TextBox
    Friend WithEvents Name5 As TextBox
    Friend WithEvents Score2 As TextBox
    Friend WithEvents Score3 As TextBox
    Friend WithEvents Score4 As TextBox
    Friend WithEvents Score5 As TextBox
    Friend WithEvents OpenBtn As Button
    Friend WithEvents FormCBox As ComboBox
    Friend WithEvents SaveBtn As Button
    Friend WithEvents CloseBtn As Button
    Friend WithEvents FightNum As NumericUpDown
    Friend WithEvents LoadBtn As Button
    Friend WithEvents GoBtn As Button
    Friend WithEvents LevelNum As NumericUpDown
    Friend WithEvents SortBtn As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LevelLbl As Label
    Friend WithEvents FightLbl As Label
    Friend WithEvents ValScore As TextBox
    Friend WithEvents ScoreBtn As Button
    Friend WithEvents ClearBtn As Button
    Friend WithEvents ValScoreLbl As Label
End Class
