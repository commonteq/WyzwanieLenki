<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScoreForm
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
        Me.ScoreLay = New System.Windows.Forms.TableLayoutPanel()
        Me.No5 = New System.Windows.Forms.Label()
        Me.TitleLbl = New System.Windows.Forms.Label()
        Me.Score1 = New System.Windows.Forms.Label()
        Me.Score2 = New System.Windows.Forms.Label()
        Me.Score3 = New System.Windows.Forms.Label()
        Me.Score4 = New System.Windows.Forms.Label()
        Me.Score5 = New System.Windows.Forms.Label()
        Me.Name1 = New System.Windows.Forms.Label()
        Me.Name3 = New System.Windows.Forms.Label()
        Me.Name2 = New System.Windows.Forms.Label()
        Me.Name4 = New System.Windows.Forms.Label()
        Me.Name5 = New System.Windows.Forms.Label()
        Me.No1 = New System.Windows.Forms.Label()
        Me.No2 = New System.Windows.Forms.Label()
        Me.No3 = New System.Windows.Forms.Label()
        Me.No4 = New System.Windows.Forms.Label()
        Me.BackTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ScoreLay.SuspendLayout()
        Me.SuspendLayout()
        '
        'ScoreLay
        '
        Me.ScoreLay.ColumnCount = 3
        Me.ScoreLay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.ScoreLay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350.0!))
        Me.ScoreLay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350.0!))
        Me.ScoreLay.Controls.Add(Me.No5, 0, 5)
        Me.ScoreLay.Controls.Add(Me.TitleLbl, 0, 0)
        Me.ScoreLay.Controls.Add(Me.Score1, 2, 1)
        Me.ScoreLay.Controls.Add(Me.Score2, 2, 2)
        Me.ScoreLay.Controls.Add(Me.Score3, 2, 3)
        Me.ScoreLay.Controls.Add(Me.Score4, 2, 4)
        Me.ScoreLay.Controls.Add(Me.Score5, 2, 5)
        Me.ScoreLay.Controls.Add(Me.Name1, 1, 1)
        Me.ScoreLay.Controls.Add(Me.Name3, 1, 3)
        Me.ScoreLay.Controls.Add(Me.Name2, 1, 2)
        Me.ScoreLay.Controls.Add(Me.Name4, 1, 4)
        Me.ScoreLay.Controls.Add(Me.Name5, 1, 5)
        Me.ScoreLay.Controls.Add(Me.No1, 0, 1)
        Me.ScoreLay.Controls.Add(Me.No2, 0, 2)
        Me.ScoreLay.Controls.Add(Me.No3, 0, 3)
        Me.ScoreLay.Controls.Add(Me.No4, 0, 4)
        Me.ScoreLay.Location = New System.Drawing.Point(0, 0)
        Me.ScoreLay.Name = "ScoreLay"
        Me.ScoreLay.RowCount = 6
        Me.ScoreLay.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77.0!))
        Me.ScoreLay.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.ScoreLay.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.ScoreLay.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.ScoreLay.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.ScoreLay.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.ScoreLay.Size = New System.Drawing.Size(800, 600)
        Me.ScoreLay.TabIndex = 0
        '
        'No5
        '
        Me.No5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.No5.AutoSize = True
        Me.No5.Location = New System.Drawing.Point(36, 532)
        Me.No5.Name = "No5"
        Me.No5.Size = New System.Drawing.Size(27, 13)
        Me.No5.TabIndex = 15
        Me.No5.Text = "No5"
        '
        'TitleLbl
        '
        Me.TitleLbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TitleLbl.AutoSize = True
        Me.ScoreLay.SetColumnSpan(Me.TitleLbl, 3)
        Me.TitleLbl.Location = New System.Drawing.Point(386, 32)
        Me.TitleLbl.Name = "TitleLbl"
        Me.TitleLbl.Size = New System.Drawing.Size(27, 13)
        Me.TitleLbl.TabIndex = 0
        Me.TitleLbl.Text = "Title"
        '
        'Score1
        '
        Me.Score1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Score1.AutoSize = True
        Me.Score1.Location = New System.Drawing.Point(756, 120)
        Me.Score1.Name = "Score1"
        Me.Score1.Size = New System.Drawing.Size(41, 13)
        Me.Score1.TabIndex = 1
        Me.Score1.Text = "Score1"
        '
        'Score2
        '
        Me.Score2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Score2.AutoSize = True
        Me.Score2.Location = New System.Drawing.Point(756, 220)
        Me.Score2.Name = "Score2"
        Me.Score2.Size = New System.Drawing.Size(41, 13)
        Me.Score2.TabIndex = 2
        Me.Score2.Text = "Score2"
        '
        'Score3
        '
        Me.Score3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Score3.AutoSize = True
        Me.Score3.Location = New System.Drawing.Point(756, 320)
        Me.Score3.Name = "Score3"
        Me.Score3.Size = New System.Drawing.Size(41, 13)
        Me.Score3.TabIndex = 3
        Me.Score3.Text = "Score3"
        '
        'Score4
        '
        Me.Score4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Score4.AutoSize = True
        Me.Score4.Location = New System.Drawing.Point(756, 420)
        Me.Score4.Name = "Score4"
        Me.Score4.Size = New System.Drawing.Size(41, 13)
        Me.Score4.TabIndex = 4
        Me.Score4.Text = "Score4"
        '
        'Score5
        '
        Me.Score5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Score5.AutoSize = True
        Me.Score5.Location = New System.Drawing.Point(756, 532)
        Me.Score5.Name = "Score5"
        Me.Score5.Size = New System.Drawing.Size(41, 13)
        Me.Score5.TabIndex = 5
        Me.Score5.Text = "Score5"
        '
        'Name1
        '
        Me.Name1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Name1.AutoSize = True
        Me.Name1.Location = New System.Drawing.Point(103, 120)
        Me.Name1.Name = "Name1"
        Me.Name1.Size = New System.Drawing.Size(41, 13)
        Me.Name1.TabIndex = 6
        Me.Name1.Text = "Name1"
        '
        'Name3
        '
        Me.Name3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Name3.AutoSize = True
        Me.Name3.Location = New System.Drawing.Point(103, 320)
        Me.Name3.Name = "Name3"
        Me.Name3.Size = New System.Drawing.Size(41, 13)
        Me.Name3.TabIndex = 8
        Me.Name3.Text = "Name3"
        '
        'Name2
        '
        Me.Name2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Name2.AutoSize = True
        Me.Name2.Location = New System.Drawing.Point(103, 220)
        Me.Name2.Name = "Name2"
        Me.Name2.Size = New System.Drawing.Size(41, 13)
        Me.Name2.TabIndex = 7
        Me.Name2.Text = "Name2"
        '
        'Name4
        '
        Me.Name4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Name4.AutoSize = True
        Me.Name4.Location = New System.Drawing.Point(103, 420)
        Me.Name4.Name = "Name4"
        Me.Name4.Size = New System.Drawing.Size(41, 13)
        Me.Name4.TabIndex = 9
        Me.Name4.Text = "Name4"
        '
        'Name5
        '
        Me.Name5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Name5.AutoSize = True
        Me.Name5.Location = New System.Drawing.Point(103, 532)
        Me.Name5.Name = "Name5"
        Me.Name5.Size = New System.Drawing.Size(41, 13)
        Me.Name5.TabIndex = 10
        Me.Name5.Text = "Name5"
        '
        'No1
        '
        Me.No1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.No1.AutoSize = True
        Me.No1.Location = New System.Drawing.Point(36, 120)
        Me.No1.Name = "No1"
        Me.No1.Size = New System.Drawing.Size(27, 13)
        Me.No1.TabIndex = 11
        Me.No1.Text = "No1"
        '
        'No2
        '
        Me.No2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.No2.AutoSize = True
        Me.No2.Location = New System.Drawing.Point(36, 220)
        Me.No2.Name = "No2"
        Me.No2.Size = New System.Drawing.Size(27, 13)
        Me.No2.TabIndex = 12
        Me.No2.Text = "No2"
        '
        'No3
        '
        Me.No3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.No3.AutoSize = True
        Me.No3.Location = New System.Drawing.Point(36, 320)
        Me.No3.Name = "No3"
        Me.No3.Size = New System.Drawing.Size(27, 13)
        Me.No3.TabIndex = 13
        Me.No3.Text = "No3"
        '
        'No4
        '
        Me.No4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.No4.AutoSize = True
        Me.No4.Location = New System.Drawing.Point(36, 420)
        Me.No4.Name = "No4"
        Me.No4.Size = New System.Drawing.Size(27, 13)
        Me.No4.TabIndex = 14
        Me.No4.Text = "No4"
        '
        'BackTimer
        '
        Me.BackTimer.Interval = 1000
        '
        'ScoreForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.ScoreLay)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ScoreForm"
        Me.Text = "ScoreForm"
        Me.ScoreLay.ResumeLayout(False)
        Me.ScoreLay.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ScoreLay As TableLayoutPanel
    Friend WithEvents Score5 As Label
    Friend WithEvents Score4 As Label
    Friend WithEvents Score3 As Label
    Friend WithEvents Score2 As Label
    Friend WithEvents Score1 As Label
    Friend WithEvents TitleLbl As Label
    Friend WithEvents No5 As Label
    Friend WithEvents Name1 As Label
    Friend WithEvents Name3 As Label
    Friend WithEvents Name2 As Label
    Friend WithEvents Name4 As Label
    Friend WithEvents Name5 As Label
    Friend WithEvents No1 As Label
    Friend WithEvents No2 As Label
    Friend WithEvents No3 As Label
    Friend WithEvents No4 As Label
    Friend WithEvents BackTimer As Timer
End Class
