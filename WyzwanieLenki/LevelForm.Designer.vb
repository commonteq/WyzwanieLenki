<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LevelForm
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
        Me.Level2Btn = New System.Windows.Forms.Button()
        Me.Level1Btn = New System.Windows.Forms.Button()
        Me.Level3Btn = New System.Windows.Forms.Button()
        Me.StartBtn = New System.Windows.Forms.Button()
        Me.DesTBox = New System.Windows.Forms.TextBox()
        Me.SetBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Level2Btn
        '
        Me.Level2Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Level2Btn.FlatAppearance.BorderSize = 0
        Me.Level2Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Level2Btn.Location = New System.Drawing.Point(310, 140)
        Me.Level2Btn.Name = "Level2Btn"
        Me.Level2Btn.Size = New System.Drawing.Size(180, 50)
        Me.Level2Btn.TabIndex = 5
        Me.Level2Btn.Text = "Level2"
        Me.Level2Btn.UseVisualStyleBackColor = True
        '
        'Level1Btn
        '
        Me.Level1Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Level1Btn.FlatAppearance.BorderSize = 0
        Me.Level1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Level1Btn.Location = New System.Drawing.Point(310, 48)
        Me.Level1Btn.Name = "Level1Btn"
        Me.Level1Btn.Size = New System.Drawing.Size(180, 50)
        Me.Level1Btn.TabIndex = 6
        Me.Level1Btn.Text = "Level1"
        Me.Level1Btn.UseVisualStyleBackColor = True
        '
        'Level3Btn
        '
        Me.Level3Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Level3Btn.FlatAppearance.BorderSize = 0
        Me.Level3Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Level3Btn.Location = New System.Drawing.Point(310, 232)
        Me.Level3Btn.Name = "Level3Btn"
        Me.Level3Btn.Size = New System.Drawing.Size(180, 50)
        Me.Level3Btn.TabIndex = 7
        Me.Level3Btn.Text = "Level3"
        Me.Level3Btn.UseVisualStyleBackColor = True
        '
        'StartBtn
        '
        Me.StartBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.StartBtn.FlatAppearance.BorderSize = 0
        Me.StartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StartBtn.Location = New System.Drawing.Point(310, 500)
        Me.StartBtn.Name = "StartBtn"
        Me.StartBtn.Size = New System.Drawing.Size(180, 50)
        Me.StartBtn.TabIndex = 8
        Me.StartBtn.Text = "Start"
        Me.StartBtn.UseVisualStyleBackColor = True
        '
        'DesTBox
        '
        Me.DesTBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DesTBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DesTBox.Location = New System.Drawing.Point(12, 342)
        Me.DesTBox.Multiline = True
        Me.DesTBox.Name = "DesTBox"
        Me.DesTBox.Size = New System.Drawing.Size(776, 107)
        Me.DesTBox.TabIndex = 10
        Me.DesTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SetBtn
        '
        Me.SetBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SetBtn.FlatAppearance.BorderSize = 0
        Me.SetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SetBtn.Location = New System.Drawing.Point(738, 12)
        Me.SetBtn.Name = "SetBtn"
        Me.SetBtn.Size = New System.Drawing.Size(50, 50)
        Me.SetBtn.TabIndex = 12
        Me.SetBtn.Text = "☺"
        Me.SetBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.SetBtn.UseVisualStyleBackColor = True
        '
        'LevelForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.SetBtn)
        Me.Controls.Add(Me.DesTBox)
        Me.Controls.Add(Me.StartBtn)
        Me.Controls.Add(Me.Level3Btn)
        Me.Controls.Add(Me.Level1Btn)
        Me.Controls.Add(Me.Level2Btn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LevelForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Level2Btn As Button
    Friend WithEvents Level1Btn As Button
    Friend WithEvents Level3Btn As Button
    Friend WithEvents StartBtn As Button
    Friend WithEvents DesTBox As TextBox
    Friend WithEvents SetBtn As Button
End Class
