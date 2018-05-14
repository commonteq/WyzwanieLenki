Public Class LoadForm

    Private Counter As Integer = Nothing

#Region "MovingWindow by mouse"
    Private Sub Form_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, LoadPct.MouseDown,
        ProgBar.MouseDown, StatusTBox.MouseDown, LoadLay.MouseDown
        MouseD(Me, e)
    End Sub

    Private Sub Form_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp, LoadPct.MouseUp,
        ProgBar.MouseUp, StatusTBox.MouseUp, LoadLay.MouseUp
        MouseU(Me)
    End Sub

    Private Sub Form_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove, LoadPct.MouseMove,
        ProgBar.MouseMove, StatusTBox.MouseMove, LoadLay.MouseMove
        MouseM(Me)
    End Sub
#End Region

    Private Sub LoadForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSavePosition(Me, False)
        TitleIcon(Me)

        Dim LoadImg As Image = Image.FromFile(PngFromFile("A0_" & Lang))
        Dim ImgW As Integer = LoadImg.Width
        Dim BoxW As Integer = LoadLay.Width
        Dim Diff As Integer = CInt((BoxW - ImgW) / 2)
        Dim Padd As Padding = New Padding With {
            .Left = Diff
        }

        LoadPct.Padding = Padd
        LoadPct.Image = LoadImg
        LoadTimer.Start()

        'StatusTBox.Text = IsFontIstalled("Thickhead_Dark_Mod")
    End Sub

    Private Sub LoadTimer_Tick(sender As Object, e As EventArgs) Handles LoadTimer.Tick
        Counter += 1
        If Counter = 6 Then
            LoadTimer.Stop()
            LoadSavePosition(Me, True)
            TitleForm.Show()
            Me.Close()
        Else
            ProgBar.Value = Counter
            'StatusTBox.Text = Counter
            LoadSavePosition(Me, True)
        End If
    End Sub

    'Private Function CheckingFiles() As Boolean
    'End Function
End Class