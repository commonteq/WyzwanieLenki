<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuForm
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
        Me.RetrnBtn = New System.Windows.Forms.Button()
        Me.SoundBtn = New System.Windows.Forms.Button()
        Me.LangBtn = New System.Windows.Forms.Button()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.BeginBtn = New System.Windows.Forms.Button()
        Me.TabLay = New System.Windows.Forms.TableLayoutPanel()
        Me.PauseLbl = New System.Windows.Forms.Label()
        Me.TabLay.SuspendLayout()
        Me.SuspendLayout()
        '
        'RetrnBtn
        '
        Me.RetrnBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RetrnBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RetrnBtn.FlatAppearance.BorderSize = 0
        Me.RetrnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RetrnBtn.Location = New System.Drawing.Point(60, 125)
        Me.RetrnBtn.Name = "RetrnBtn"
        Me.RetrnBtn.Size = New System.Drawing.Size(180, 50)
        Me.RetrnBtn.TabIndex = 7
        Me.RetrnBtn.Text = "Return"
        Me.RetrnBtn.UseVisualStyleBackColor = True
        '
        'SoundBtn
        '
        Me.SoundBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SoundBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SoundBtn.FlatAppearance.BorderSize = 0
        Me.SoundBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SoundBtn.Location = New System.Drawing.Point(60, 425)
        Me.SoundBtn.Name = "SoundBtn"
        Me.SoundBtn.Size = New System.Drawing.Size(180, 50)
        Me.SoundBtn.TabIndex = 8
        Me.SoundBtn.Text = "Sound"
        Me.SoundBtn.UseVisualStyleBackColor = True
        '
        'LangBtn
        '
        Me.LangBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LangBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.LangBtn.FlatAppearance.BorderSize = 0
        Me.LangBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LangBtn.Location = New System.Drawing.Point(60, 525)
        Me.LangBtn.Name = "LangBtn"
        Me.LangBtn.Size = New System.Drawing.Size(180, 50)
        Me.LangBtn.TabIndex = 9
        Me.LangBtn.Text = "Language"
        Me.LangBtn.UseVisualStyleBackColor = True
        '
        'ExitBtn
        '
        Me.ExitBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ExitBtn.FlatAppearance.BorderSize = 0
        Me.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitBtn.Location = New System.Drawing.Point(60, 225)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(180, 50)
        Me.ExitBtn.TabIndex = 10
        Me.ExitBtn.Text = "Exit"
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'BeginBtn
        '
        Me.BeginBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BeginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BeginBtn.FlatAppearance.BorderSize = 0
        Me.BeginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BeginBtn.Location = New System.Drawing.Point(60, 325)
        Me.BeginBtn.Name = "BeginBtn"
        Me.BeginBtn.Size = New System.Drawing.Size(180, 50)
        Me.BeginBtn.TabIndex = 11
        Me.BeginBtn.Text = "Begin"
        Me.BeginBtn.UseVisualStyleBackColor = True
        '
        'TabLay
        '
        Me.TabLay.BackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.TabLay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TabLay.ColumnCount = 1
        Me.TabLay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TabLay.Controls.Add(Me.LangBtn, 0, 5)
        Me.TabLay.Controls.Add(Me.SoundBtn, 0, 4)
        Me.TabLay.Controls.Add(Me.BeginBtn, 0, 3)
        Me.TabLay.Controls.Add(Me.ExitBtn, 0, 2)
        Me.TabLay.Controls.Add(Me.RetrnBtn, 0, 1)
        Me.TabLay.Controls.Add(Me.PauseLbl, 0, 0)
        Me.TabLay.Location = New System.Drawing.Point(0, 0)
        Me.TabLay.Name = "TabLay"
        Me.TabLay.RowCount = 6
        Me.TabLay.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TabLay.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TabLay.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TabLay.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TabLay.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TabLay.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TabLay.Size = New System.Drawing.Size(300, 600)
        Me.TabLay.TabIndex = 13
        '
        'PauseLbl
        '
        Me.PauseLbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PauseLbl.AutoSize = True
        Me.PauseLbl.Location = New System.Drawing.Point(131, 43)
        Me.PauseLbl.Name = "PauseLbl"
        Me.PauseLbl.Size = New System.Drawing.Size(37, 13)
        Me.PauseLbl.TabIndex = 12
        Me.PauseLbl.Text = "Pause"
        '
        'MenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(300, 600)
        Me.Controls.Add(Me.TabLay)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MenuForm"
        Me.ShowInTaskbar = False
        Me.Text = "MenuForm"
        Me.TabLay.ResumeLayout(False)
        Me.TabLay.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RetrnBtn As Button
    Friend WithEvents SoundBtn As Button
    Friend WithEvents LangBtn As Button
    Friend WithEvents ExitBtn As Button
    Friend WithEvents BeginBtn As Button
    Friend WithEvents TabLay As TableLayoutPanel
    Friend WithEvents PauseLbl As Label
End Class
