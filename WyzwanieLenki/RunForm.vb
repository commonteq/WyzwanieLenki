Public Class RunForm
    Private StoryCounter As Integer
    Private StoryTime As Single
    Private RatRunInd As Byte = Nothing
    Private LenkaRunInd As Byte = Nothing
    Private SkipNotReplay As Boolean = Nothing

#Region "MovingWindow by mouse"
    Private Sub Form_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, Cloud1Pct.MouseDown,
            Cloud2Pct.MouseDown, Cloud3Pct.MouseDown, Cloud4Pct.MouseDown, Speech1Lbl.MouseDown,
            LenkaRunPct.MouseDown, RatRunPct.MouseDown, BagPct.MouseDown, SunPct.MouseDown
        MouseD(Me, e)
    End Sub

    Private Sub Form_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp, Cloud1Pct.MouseUp,
            Cloud2Pct.MouseUp, Cloud3Pct.MouseUp, Cloud4Pct.MouseUp, Speech1Lbl.MouseUp,
            LenkaRunPct.MouseUp, RatRunPct.MouseUp, BagPct.MouseUp, SunPct.MouseUp
        MouseU(Me)
    End Sub

    Private Sub Form_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove, Cloud1Pct.MouseMove,
            Cloud2Pct.MouseMove, Cloud3Pct.MouseMove, Cloud4Pct.MouseMove, Speech1Lbl.MouseMove,
            LenkaRunPct.MouseMove, RatRunPct.MouseMove, BagPct.MouseMove, SunPct.MouseMove
        MouseM(Me)
    End Sub
#End Region

    Private Sub RunForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSavePosition(Me, False)
        TitleIcon(Me)
        If Sound Then PlaySound("BackRat", True)

        Me.BackgroundImage = Image.FromFile(PngFromFile("BackRun"))

        For Each ictrl As Control In Me.Controls
            If TypeOf ictrl Is PictureBox Then
                Dim ctrl As PictureBox = ictrl
                If Strings.Left(ctrl.Name, 5) = "Cloud" Then ctrl.Image = Image.FromFile(PngFromFile("Cloud"))
                If ctrl.Name = "SunPct" Then ctrl.Image = Image.FromFile(PngFromFile("Sun1"))
            End If

            If TypeOf ictrl Is TableLayoutPanel Then
                Dim ctrl As TableLayoutPanel = ictrl
                ctrl.BackgroundImage = Image.FromFile(PngFromFile("CloudSpeech"))
                ctrl.Font = New Font(Lfont, 14)
                ctrl.ForeColor = Color.FromArgb(0, 50, 100)
                ctrl.Visible = False
            End If

            If TypeOf ictrl Is Button Then
                Dim ctrl As Button = ictrl
                ctrl.Font = New Font(Lfont, 20)
                ctrl.ForeColor = Color.White
                If ctrl.Name = "OpBtn" Then
                    ctrl.BackgroundImage = Image.FromFile(PngFromFile("ButtonStart"))
                    ctrl.Text = TxtFromFile(Lang, "Intro", 1)
                    ctrl.Visible = False
                Else
                    ctrl.ForeColor = Color.FromArgb(0, 50, 100)
                End If
            End If
        Next

        StoryCounter = 0
        BackTimer.Start()
        StoryTimer.Start()
    End Sub

    Private Sub BackTimer_Tick(sender As Object, e As EventArgs) Handles BackTimer.Tick
        Dim CloudStep As SByte = -1
        Dim Rnd As New Random
        Dim Rnd2 As New Random

        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is PictureBox Then
                If Strings.Left(ctrl.Name, 5) = "Cloud" Then
                    If ctrl.Location.X < -140 Then
                        ctrl.Location = New Drawing.Point(800 + (Rnd.Next(0, 150)), ctrl.Location.Y + Rnd2.Next(-10, 10))
                    Else
                        ctrl.Location = New Drawing.Point(ctrl.Location.X + CloudStep, ctrl.Location.Y)
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub StoryTimer_Tick(sender As Object, e As EventArgs) Handles StoryTimer.Tick
        StoryCounter += 1
        StoryTime = TimerValueToTime(StoryTimer.Interval, StoryCounter)
        StoryTimeGlobal = StoryTime

        If StoryTime = 600 Then
            StoryCounter = 0
            TimerRestart(StoryTimer)
        End If

        Select Case StoryTime
            Case 1
                OpBtn.Visible = True
                OpBtn.Text = TxtFromFile(Lang, "Intro", 1)
                SkipNotReplay = True
            Case 2
                RatRunPct.Location = New Drawing.Point(0 - 130, RatRunPct.Location.Y)
                RatRunPct.Visible = True
                BagPct.Visible = True
                BagPct.Location = New Drawing.Point(RatRunPct.Location.X - 130, BagPct.Location.Y)
                BagPct.Image = Image.FromFile(PngFromFile("Bag5"))
            Case 5 To 10
                OpBtn.Visible = False
                RatRunInd += 1
                If RatRunInd > 6 Then
                    RatRunInd = 1
                End If
                RatRunPct.Image = ResizeImage(Image.FromFile(PngFromFile("RatRun" & RatRunInd)), 70)
                If RatRunPct.Location.X < 400 Then
                    RatRunPct.Location = New Drawing.Point(RatRunPct.Location.X + 10, RatRunPct.Location.Y)
                Else
                    RatRunPct.Location = New Drawing.Point(400, RatRunPct.Location.Y)
                End If
                BagPct.Location = New Drawing.Point(RatRunPct.Location.X - 130, BagPct.Location.Y)
            Case 12
                Speech1Tbl.Visible = True
                Speech1Tbl.Location = New Drawing.Point(500, Speech1Tbl.Location.Y)
                Speech1Lbl.Text = TxtFromFile(Lang, "Run", 1)
            Case 17
                Speech1Lbl.Text = TxtFromFile(Lang, "Run", 2)
            Case 22
                Speech1Tbl.Location = New Drawing.Point(10, Speech1Tbl.Location.Y)
                Speech1Lbl.Text = TxtFromFile(Lang, "Run", 3)
                If Sound Then PlaySound("BackRunning", True)
            Case 27
                Speech1Tbl.Location = New Drawing.Point(500, Speech1Tbl.Location.Y)
                Speech1Lbl.Text = TxtFromFile(Lang, "Run", 4)
            Case 28 To 31
                RatRunInd += 1
                If RatRunInd > 6 Then
                    RatRunInd = 1
                End If
                RatRunPct.Image = ResizeImage(Image.FromFile(PngFromFile("RatRun" & RatRunInd)), 70)
                If RatRunPct.Location.X < 1000 Then
                    RatRunPct.Location = New Drawing.Point(RatRunPct.Location.X + 30, RatRunPct.Location.Y)
                Else
                    RatRunPct.Location = New Drawing.Point(1000, RatRunPct.Location.Y)
                End If
                BagPct.Location = New Drawing.Point(RatRunPct.Location.X - 130, BagPct.Location.Y)
            Case 32
                RatRunPct.Visible = False
                BagPct.Visible = False
                Speech1Tbl.Visible = True
                LenkaRunPct.Visible = True
                LenkaRunPct.Location = New Drawing.Point(-200, LenkaRunPct.Location.Y)
            Case 33
                Speech1Lbl.Text = TxtFromFile(Lang, "Run", 5)
                Speech1Tbl.Location = New Drawing.Point(0, Speech1Tbl.Location.Y)
                'PlaySound("BackRunning", True)
            Case 34 To 39
                LenkaRunInd += 1
                If LenkaRunInd > 8 Then
                    LenkaRunInd = 1
                End If
                LenkaRunPct.Image = ResizeImage(Image.FromFile(PngFromFile("LenkaRun" & LenkaRunInd)), 40)

                If LenkaRunPct.Location.X < 900 Then
                    LenkaRunPct.Location = New Drawing.Point(LenkaRunPct.Location.X + 30, LenkaRunPct.Location.Y)
                Else
                    LenkaRunPct.Location = New Drawing.Point(800, LenkaRunPct.Location.Y)
                End If

                If LenkaRunInd = 4 Then
                    If Speech1Tbl.Location.X > 200 Then
                        Speech1Tbl.Location = New Drawing.Point(500, Speech1Tbl.Location.Y)
                    ElseIf Speech1Lbl.Location.X < 0 Then
                        Speech1Tbl.Location = New Drawing.Point(0, Speech1Tbl.Location.Y)
                    Else
                        Speech1Tbl.Location = New Drawing.Point(LenkaRunPct.Location.X + 20, Speech1Tbl.Location.Y)
                    End If
                End If
            Case 40
                OpBtn.Visible = True
                OpBtn.Text = TxtFromFile(Lang, "Intro", 2)
                SkipNotReplay = False
            Case 45
                NextForm()
        End Select
    End Sub

    Private Sub NextForm()
        LoadSavePosition(Me, True)
        StopSound()
        BackTimer.Stop()
        StoryTimer.Stop()
        DeployForm.Show()
        Me.Close()
    End Sub

    Private Sub Replay()
        LoadSavePosition(Me, True)
        Me.RunForm_Load(Nothing, Nothing)
    End Sub

    Private Sub OpBtn_Click(sender As Object, e As EventArgs) Handles OpBtn.Click
        If SkipNotReplay = True Then
            NextForm()
        Else
            Replay()
        End If
    End Sub

    Private Sub RunForm_MouseHover(sender As Object, e As EventArgs) Handles MyBase.MouseHover, Cloud1Pct.MouseHover,
            Cloud2Pct.MouseHover, Cloud3Pct.MouseHover, Cloud4Pct.MouseHover, Speech1Lbl.MouseHover,
            SunPct.MouseHover, LenkaRunPct.MouseHover, BagPct.MouseHover, RatRunPct.MouseHover, SetBtn.MouseHover, OpBtn.MouseHover
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

    Private Sub RunForm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        FormNameGlobal = Me.Name
    End Sub
End Class