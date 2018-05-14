Public Class BattleForm
    Private BackCounter As Byte
    Private RatCounter As Byte


#Region "MovingWindow by mouse"
    Private Sub Form_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, TitleLay.MouseDown,
            Title1Lbl.MouseDown, Title2Lbl.MouseDown, LenkaPct.MouseDown, RatPct.MouseDown, CagePct.MouseDown
        MouseD(Me, e)
    End Sub

    Private Sub Form_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp, TitleLay.MouseUp,
            Title1Lbl.MouseUp, Title2Lbl.MouseUp, LenkaPct.MouseUp, RatPct.MouseUp, CagePct.MouseUp
        MouseU(Me)
    End Sub

    Private Sub Form_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove, TitleLay.MouseMove,
            Title1Lbl.MouseMove, Title2Lbl.MouseMove, LenkaPct.MouseMove, RatPct.MouseMove, CagePct.MouseMove
        MouseM(Me)
    End Sub
#End Region

    Private Sub BattleForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSavePosition(Me, False)
        TitleIcon(Me)
        If Sound Then PlaySound("BackBattle", True)
        For Each ctrl As Label In TitleLay.Controls
            If CByte(Strings.Left(Strings.Right(ctrl.Name, 4), 1)) = 1 Then
                ctrl.Font = New Font(LFont, 40)
                ctrl.ForeColor = Color.FromArgb(220, 50, 0)
                'ctrl.Text = TxtFromFile(Lang, "Battle", 1) & Fight
            Else
                ctrl.Font = New Font(LFont, 22)
                ctrl.ForeColor = Color.FromArgb(0, 50, 100)
                'ctrl.Text = TxtFromFile(Lang, "Battle", 2)
            End If
        Next

        ScoreLbl.Font = New Font(LFont, 22)
        ScoreLbl.ForeColor = Color.FromArgb(0, 50, 100)
        ScoreLbl.Text = Score


        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Button Then
                ctrl.Font = New Font(LFont, 20)
                ctrl.ForeColor = Color.White
            End If
        Next

        StartBtn.BackgroundImage = Image.FromFile(PngFromFile("ButtonStart"))
        CagePct.Image = Image.FromFile(PngFromFile("Cage"))
        CagePct.BackgroundImage = ResizeImage(Image.FromFile(PngFromFile("Pet" & Fight)), 70)
        BackTimer.Start()
        TxtLoad()
    End Sub

    Private Sub TxtLoad()
        Title1Lbl.Text = TxtFromFile(Lang, "Battle", 1) & Fight
        Title2Lbl.Text = TxtFromFile(Lang, "Battle", 2)
    End Sub


    Private Sub BackTimer_Tick(sender As Object, e As EventArgs) Handles BackTimer.Tick
        BackCounter += 1
        RatCounter += 1
        If BackCounter > 2 Then BackCounter = 1
        If RatCounter > 10 Then RatCounter = 0
        LenkaPct.Image = ResizeImage(Image.FromFile(PngFromFile("LenkaRun" & BackCounter + 1)), 70)

        RatPct.Image = ResizeImage(Image.FromFile(PngFromFile("RatRun5")), 100)

        If RatCounter > 0 And RatCounter < 6 Then
            Dim btm As Bitmap = ResizeImage(Image.FromFile(PngFromFile("RatRun" & BackCounter + 4)), 100)
            btm.RotateFlip(RotateFlipType.RotateNoneFlipX)
            RatPct.Image = btm
            CagePct.Location = New Drawing.Point(CagePct.Location.X, CagePct.Location.Y - 2)
        ElseIf RatCounter >= 6 Then
            RatPct.Image = ResizeImage(Image.FromFile(PngFromFile("RatRun" & BackCounter + 4)), 100)
            CagePct.Location = New Drawing.Point(CagePct.Location.X, CagePct.Location.Y + 2)
        End If
    End Sub

    Private Sub StartBtn_Click(sender As Object, e As EventArgs) Handles StartBtn.Click
        LoadSavePosition(Me, True)
        StopSound()
        FightForm.Show()
        Me.Close()
    End Sub

    Private Sub DeployForm_MouseHover(sender As Object, e As EventArgs) Handles MyBase.MouseHover, Title1Lbl.MouseHover,
            Title2Lbl.MouseHover, TitleLay.MouseHover, LenkaPct.MouseHover, RatPct.MouseHover, CagePct.MouseHover,
            SetBtn.MouseHover, StartBtn.MouseHover
        Dim ctrl As Control = CType(sender, Control)
        For Each ictrl As Control In Me.Controls
            If TypeOf ictrl Is Button Then
                If ctrl.Name = ictrl.Name Then
                    ictrl.ForeColor = Color.Yellow
                ElseIf ictrl.Name = "SetBtn" Then
                    ictrl.ForeColor = Color.FromArgb(0, 50, 100)
                Else
                    ictrl.ForeColor = Color.White
                End If
            End If
        Next
    End Sub

    Private Sub SetBtn_Click(sender As Object, e As EventArgs) Handles SetBtn.Click
        MenuForm.ShowDialog()
    End Sub

    Private Sub BattleForm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        TxtLoad()
    End Sub
End Class