<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LangForm
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
        Me.PLBtn = New System.Windows.Forms.Button()
        Me.ENBtn = New System.Windows.Forms.Button()
        Me.LangLbl = New System.Windows.Forms.Label()
        Me.LangLay = New System.Windows.Forms.TableLayoutPanel()
        Me.LangLay.SuspendLayout()
        Me.SuspendLayout()
        '
        'PLBtn
        '
        Me.PLBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PLBtn.FlatAppearance.BorderSize = 0
        Me.PLBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PLBtn.Location = New System.Drawing.Point(150, 500)
        Me.PLBtn.Name = "PLBtn"
        Me.PLBtn.Size = New System.Drawing.Size(180, 50)
        Me.PLBtn.TabIndex = 7
        Me.PLBtn.Text = "PL"
        Me.PLBtn.UseVisualStyleBackColor = True
        '
        'ENBtn
        '
        Me.ENBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ENBtn.FlatAppearance.BorderSize = 0
        Me.ENBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ENBtn.Location = New System.Drawing.Point(470, 500)
        Me.ENBtn.Name = "ENBtn"
        Me.ENBtn.Size = New System.Drawing.Size(180, 50)
        Me.ENBtn.TabIndex = 8
        Me.ENBtn.Text = "EN"
        Me.ENBtn.UseVisualStyleBackColor = True
        '
        'LangLbl
        '
        Me.LangLbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LangLbl.AutoSize = True
        Me.LangLbl.Location = New System.Drawing.Point(384, 31)
        Me.LangLbl.Name = "LangLbl"
        Me.LangLbl.Size = New System.Drawing.Size(31, 13)
        Me.LangLbl.TabIndex = 9
        Me.LangLbl.Text = "Lang"
        '
        'LangLay
        '
        Me.LangLay.ColumnCount = 1
        Me.LangLay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.LangLay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.LangLay.Controls.Add(Me.LangLbl, 0, 0)
        Me.LangLay.Location = New System.Drawing.Point(0, 50)
        Me.LangLay.Name = "LangLay"
        Me.LangLay.RowCount = 1
        Me.LangLay.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.LangLay.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.LangLay.Size = New System.Drawing.Size(800, 75)
        Me.LangLay.TabIndex = 10
        '
        'LangForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.LangLay)
        Me.Controls.Add(Me.ENBtn)
        Me.Controls.Add(Me.PLBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LangForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Wyzwanie Lenki"
        Me.LangLay.ResumeLayout(False)
        Me.LangLay.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PLBtn As Button
    Friend WithEvents ENBtn As Button
    Friend WithEvents LangLbl As Label
    Friend WithEvents LangLay As TableLayoutPanel
End Class
