<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoadForm
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
        Me.LoadTimer = New System.Windows.Forms.Timer(Me.components)
        Me.LoadPct = New System.Windows.Forms.PictureBox()
        Me.ProgBar = New System.Windows.Forms.ProgressBar()
        Me.StatusTBox = New System.Windows.Forms.TextBox()
        Me.LoadLay = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.LoadPct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LoadLay.SuspendLayout()
        Me.SuspendLayout()
        '
        'LoadTimer
        '
        Me.LoadTimer.Interval = 500
        '
        'LoadPct
        '
        Me.LoadPct.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LoadPct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.LoadPct.Location = New System.Drawing.Point(3, 3)
        Me.LoadPct.Name = "LoadPct"
        Me.LoadPct.Size = New System.Drawing.Size(744, 94)
        Me.LoadPct.TabIndex = 1
        Me.LoadPct.TabStop = False
        '
        'ProgBar
        '
        Me.ProgBar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ProgBar.Location = New System.Drawing.Point(100, 500)
        Me.ProgBar.Maximum = 5
        Me.ProgBar.Name = "ProgBar"
        Me.ProgBar.Size = New System.Drawing.Size(600, 50)
        Me.ProgBar.Step = 5
        Me.ProgBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgBar.TabIndex = 2
        '
        'StatusTBox
        '
        Me.StatusTBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StatusTBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.StatusTBox.Enabled = False
        Me.StatusTBox.Location = New System.Drawing.Point(100, 218)
        Me.StatusTBox.Multiline = True
        Me.StatusTBox.Name = "StatusTBox"
        Me.StatusTBox.ReadOnly = True
        Me.StatusTBox.Size = New System.Drawing.Size(600, 264)
        Me.StatusTBox.TabIndex = 3
        '
        'LoadLay
        '
        Me.LoadLay.ColumnCount = 1
        Me.LoadLay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.LoadLay.Controls.Add(Me.LoadPct, 0, 0)
        Me.LoadLay.Location = New System.Drawing.Point(25, 50)
        Me.LoadLay.Name = "LoadLay"
        Me.LoadLay.RowCount = 1
        Me.LoadLay.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.LoadLay.Size = New System.Drawing.Size(750, 100)
        Me.LoadLay.TabIndex = 4
        '
        'LoadForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.LoadLay)
        Me.Controls.Add(Me.StatusTBox)
        Me.Controls.Add(Me.ProgBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoadForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.LoadPct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LoadLay.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LoadTimer As Timer
    Friend WithEvents LoadPct As PictureBox
    Friend WithEvents ProgBar As ProgressBar
    Friend WithEvents StatusTBox As TextBox
    Friend WithEvents LoadLay As TableLayoutPanel
End Class
