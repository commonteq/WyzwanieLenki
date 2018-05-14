Public Class IntroForm
    Private PetCounter As Integer
    Private Pet4Dir As Boolean
    Private PetTime As Single
    Private StoryCounter As Integer
    Private StoryTime As Single
    Private RatRunInd As Byte = Nothing
    Private LenkaRunInd As Byte = Nothing
    Private SkipNotReplay As Boolean = Nothing

#Region "MovingWindow by mouse"
    Private Sub Form_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, Cloud1Pct.MouseDown,
            Cloud2Pct.MouseDown, Cloud3Pct.MouseDown, Cloud4Pct.MouseDown, Speech1Lbl.MouseDown, Speech2Lbl.MouseDown,
            LenkaPct.MouseDown, LenkaRunPct.MouseDown, RatPct.MouseDown, RatRunPct.MouseDown, BagPct.MouseDown,
            Pet1Pct.MouseDown, Pet2Pct.MouseDown, Pet3Pct.MouseDown, Pet4Pct.MouseDown, Pet5Pct.MouseDown, SunPct.MouseDown
        MouseD(Me, e)
    End Sub

    Private Sub Form_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp, Cloud1Pct.MouseUp,
            Cloud2Pct.MouseUp, Cloud3Pct.MouseUp, Cloud4Pct.MouseUp, Speech1Lbl.MouseUp, Speech2Lbl.MouseUp,
            LenkaPct.MouseUp, LenkaRunPct.MouseUp, RatPct.MouseUp, RatRunPct.MouseUp, BagPct.MouseUp,
            Pet1Pct.MouseUp, Pet2Pct.MouseUp, Pet3Pct.MouseUp, Pet4Pct.MouseUp, Pet5Pct.MouseUp, SunPct.MouseUp
        MouseU(Me)
    End Sub

    Private Sub Form_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove, Cloud1Pct.MouseMove,
            Cloud2Pct.MouseMove, Cloud3Pct.MouseMove, Cloud4Pct.MouseMove, Speech1Lbl.MouseMove, Speech2Lbl.MouseMove,
            LenkaPct.MouseMove, LenkaRunPct.MouseMove, RatPct.MouseMove, RatRunPct.MouseMove, BagPct.MouseMove,
            Pet1Pct.MouseMove, Pet2Pct.MouseMove, Pet3Pct.MouseMove, Pet4Pct.MouseMove, Pet5Pct.MouseMove, SunPct.MouseMove
        MouseM(Me)
    End Sub
#End Region

    Private Sub Intro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSavePosition(Me, False)
        TitleIcon(Me)
        If Sound Then PlaySound("BackIntro", True)

        Me.BackgroundImage = Image.FromFile(PngFromFile("BackIntro"))

        For Each ictrl As Control In Me.Controls
            If TypeOf ictrl Is PictureBox Then
                Dim ctrl As PictureBox = ictrl
                If Strings.Left(ctrl.Name, 5) = "Cloud" Then ctrl.Image = Image.FromFile(PngFromFile("Cloud"))

                If Strings.Left(ctrl.Name, 3) = "Pet" Then
                    ctrl.Image = ResizeImage(Image.FromFile(PngFromFile("Pet" & Strings.Right(Strings.Left(ctrl.Name, 4), 1))), 50)
                    ctrl.Visible = True
                End If

                Select Case ctrl.Name
                    Case "SunPct" : ctrl.Image = Image.FromFile(PngFromFile("Sun1"))
                    Case "LenkaPct"
                        ctrl.Image = ResizeImage(Image.FromFile(PngFromFile("Lenka1")), 50)
                        ctrl.Visible = False
                    Case "RatPct"
                        ctrl.Image = ResizeImage(Image.FromFile(PngFromFile("Rat2")), 100)
                        ctrl.Visible = False
                End Select
            End If

            If TypeOf ictrl Is TableLayoutPanel Then
                Dim ctrl As TableLayoutPanel = ictrl
                Dim No As Byte = CByte(Strings.Left(Strings.Right(ctrl.Name, 4), 1))
                Dim btm As Bitmap = Image.FromFile(PngFromFile("CloudSpeech"))
                If No = 1 Then
                    ctrl.BackgroundImage = btm
                ElseIf No = 2 Then
                    btm.RotateFlip(RotateFlipType.RotateNoneFlipX)
                    ctrl.BackgroundImage = btm
                End If
                ctrl.Font = New Font(LFont, 14)
                ctrl.ForeColor = Color.FromArgb(0, 50, 100)
                ctrl.Visible = False
            End If

            If TypeOf ictrl Is Button Then
                Dim ctrl As Button = ictrl
                ctrl.Font = New Font(LFont, 20)
                ctrl.ForeColor = Color.White
                If ctrl.Name = "OpBtn" Then
                    ctrl.BackgroundImage = Image.FromFile(PngFromFile("ButtonStart"))
                    'ctrl.Text = TxtFromFile(Lang, "Intro", 1)
                    ctrl.Visible = False
                Else
                    ctrl.ForeColor = Color.FromArgb(0, 50, 100)
                End If
            End If
        Next

        Pet4Pct.Location = New Drawing.Point(170, 282)
        PetCounter = 0
        StoryCounter = 0
        BackTimer.Start()
        PetTimer.Start()
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

    Private Sub PetTimer_Tick(sender As Object, e As EventArgs) Handles PetTimer.Tick
        PetCounter += 1
        PetTime = TimerValueToTime(PetTimer.Interval, PetCounter)

        Select Case PetTime
            Case 1 : Pet1Pct.Location = New Drawing.Point(Pet1Pct.Location.X, Pet1Pct.Location.Y - 10)
            Case 1.2 : Pet1Pct.Location = New Drawing.Point(Pet1Pct.Location.X, Pet1Pct.Location.Y + 10)
            Case 2 : Pet3Pct.Image = ResizeImage(Image.FromFile(PngFromFile("Pet3")), 25)
            Case 2.5 : Pet3Pct.Image = ResizeImage(Image.FromFile(PngFromFile("Pet3")), 50)
            Case 3
                Dim bitmp2 As Bitmap = Pet2Pct.Image
                bitmp2.RotateFlip(RotateFlipType.RotateNoneFlipX)
                Pet2Pct.Image = bitmp2
        End Select

        If PetTime > 4 Then
            Dim bitmp5 As Bitmap
            bitmp5 = Pet5Pct.Image
            bitmp5.RotateFlip(RotateFlipType.Rotate90FlipNone)
            Pet5Pct.Image = bitmp5
        End If

        If Pet4Dir = True Then
            Pet4Pct.Location = New Drawing.Point(Pet4Pct.Location.X + 1, Pet4Pct.Location.Y)
        Else
            Pet4Pct.Location = New Drawing.Point(Pet4Pct.Location.X - 1, Pet4Pct.Location.Y)
        End If

        If PetTime = 6 Then 'timer restartuje sie po 6s
            TimerRestart(PetTimer)
            PetCounter = 0
            Pet4Dir = Not Pet4Dir

            Dim bitmp4 As Bitmap
            bitmp4 = Pet4Pct.Image
            bitmp4.RotateFlip(RotateFlipType.RotateNoneFlipX)
            Pet4Pct.Image = bitmp4
        End If
    End Sub

    Private Sub StoryTimer_Tick(sender As Object, e As EventArgs) Handles StoryTimer.Tick
        StoryCounter += 1
        StoryTime = TimerValueToTime(StoryTimer.Interval, StoryCounter)
        StoryTimeGlobal = StoryTime

        If StoryTime = 600 Then '600 = 60s * 10 = 10min
            StoryCounter = 0
            TimerRestart(StoryTimer)
        End If

        Select Case StoryTime
            Case 1
                OpBtn.Visible = True
                OpBtn.Text = TxtFromFile(Lang, "Intro", 1)
                SkipNotReplay = True
            Case 4 'Lenka zaczyna wychodzic do okna
                OpBtn.Visible = False
                LenkaPct.Visible = True
                LenkaPct.Location = New Drawing.Point(15 - 65, LenkaPct.Location.Y)
            Case 5 To 7 'Lenka wychodzi do okna
                If LenkaPct.Location.X < 15 Then
                    LenkaPct.Location = New Drawing.Point(LenkaPct.Location.X + 10, LenkaPct.Location.Y)
                Else
                    LenkaPct.Location = New Drawing.Point(15, LenkaPct.Location.Y)
                End If
            Case 8 'zaczyna mowic
                Speech1Tbl.Visible = True
                Speech1Lbl.Text = TxtFromFile(Lang, "IntroSpeechL", 1)
            Case 10
                Speech1Lbl.Text = TxtFromFile(Lang, "IntroSpeechL", 2)
                LenkaPct.Image = ResizeImage(Image.FromFile(PngFromFile("Lenka3")), 50)
            Case 15
                LenkaPct.Image = ResizeImage(Image.FromFile(PngFromFile("Lenka6")), 50)
                Speech1Tbl.Visible = False
            Case 17
                Speech1Tbl.Visible = True
                Speech1Lbl.Text = TxtFromFile(Lang, "IntroSpeechL", 3)
            Case 22
                Speech1Lbl.Text = TxtFromFile(Lang, "IntroSpeechL", 4)
            Case 27
                Speech1Tbl.Visible = False
            Case 28 To 30
                If LenkaPct.Location.X > -65 Then
                    LenkaPct.Location = New Drawing.Point(LenkaPct.Location.X - 10, LenkaPct.Location.Y)
                Else
                    LenkaPct.Location = New Drawing.Point(-65, LenkaPct.Location.Y)
                End If
            Case 32 'Rat location 625; 470 Size:175; 150
                RatPct.Visible = True
                RatPct.Location = New Drawing.Point(625 + 175, RatPct.Location.Y)
                If Sound Then PlaySound("BackRat", True)
            Case 33 To 34
                If RatPct.Location.X > 625 Then
                    RatPct.Location = New Drawing.Point(RatPct.Location.X - 20, RatPct.Location.Y)
                Else
                    RatPct.Location = New Drawing.Point(625, RatPct.Location.Y)
                End If
            Case 36
                Speech2Tbl.Visible = True
                Speech2Lbl.Text = TxtFromFile(Lang, "IntroSpeechR", 1)
            Case 41
                Speech2Lbl.Text = TxtFromFile(Lang, "IntroSpeechR", 2)
                RatPct.Image = ResizeImage(Image.FromFile(PngFromFile("Rat3")), 100)
            Case 46
                Dim btm As Bitmap = ResizeImage(Image.FromFile(PngFromFile("Rat3")), 100)
                btm.RotateFlip(RotateFlipType.RotateNoneFlipX)
                RatPct.Image = btm
                Speech2Tbl.Visible = False
            Case 47 To 48
                If RatPct.Location.X < 625 + 175 Then
                    RatPct.Location = New Drawing.Point(RatPct.Location.X + 20, RatPct.Location.Y)
                Else
                    RatPct.Location = New Drawing.Point(625 + 175, RatPct.Location.Y)
                End If
                RatRunPct.Location = New Drawing.Point(800, RatRunPct.Location.Y)
            Case 52 To 57  'Szczur idzie po zabawki
                RatRunInd += 1
                If RatRunInd > 6 Then
                    RatRunInd = 1
                End If

                Dim btm As Bitmap = ResizeImage(Image.FromFile(PngFromFile("RatRun" & RatRunInd)), 70)
                btm.RotateFlip(RotateFlipType.RotateNoneFlipX)
                RatRunPct.Image = btm

                If RatRunPct.Location.X > 300 Then
                    RatRunPct.Location = New Drawing.Point(RatRunPct.Location.X - 10, RatRunPct.Location.Y)
                Else
                    RatRunPct.Location = New Drawing.Point(300, RatRunPct.Location.Y)
                End If
                Dim btm2 As Bitmap = ResizeImage(Image.FromFile(PngFromFile("Bag0")), 100)
                btm2.RotateFlip(RotateFlipType.RotateNoneFlipX)
                BagPct.Image = btm2
                BagPct.Visible = True
                BagPct.Location = New Drawing.Point(RatRunPct.Location.X + 130, BagPct.Location.Y)
            Case 58
                Dim btm As Bitmap = Speech2Tbl.BackgroundImage
                btm.RotateFlip(RotateFlipType.RotateNoneFlipX)
                Speech2Tbl.BackgroundImage = btm
                Speech2Tbl.Visible = True
                Speech2Tbl.Location = New Drawing.Point(Speech2Tbl.Location.X - 50, Speech2Tbl.Location.Y)
                Speech2Lbl.Text = TxtFromFile(Lang, "IntroSpeechR", 3)
            Case 59
                SunPct.Image = Image.FromFile(PngFromFile("Sun2"))
                Pet1Pct.Visible = False
                Dim btm As Bitmap = ResizeImage(Image.FromFile(PngFromFile("Bag1")), 100)
                btm.RotateFlip(RotateFlipType.RotateNoneFlipX)
                BagPct.Image = btm
            Case 61
                Pet2Pct.Visible = False
                Dim btm As Bitmap = ResizeImage(Image.FromFile(PngFromFile("Bag2")), 100)
                btm.RotateFlip(RotateFlipType.RotateNoneFlipX)
                BagPct.Image = btm
            Case 62
                Pet3Pct.Visible = False
                Dim btm As Bitmap = ResizeImage(Image.FromFile(PngFromFile("Bag3")), 100)
                btm.RotateFlip(RotateFlipType.RotateNoneFlipX)
                BagPct.Image = btm
            Case 63
                Pet5Pct.Visible = False
                Dim btm As Bitmap = ResizeImage(Image.FromFile(PngFromFile("Bag4")), 100)
                btm.RotateFlip(RotateFlipType.RotateNoneFlipX)
                BagPct.Image = btm
            Case 64
                Pet4Pct.Visible = False
                Dim btm As Bitmap = ResizeImage(Image.FromFile(PngFromFile("Bag5")), 100)
                btm.RotateFlip(RotateFlipType.RotateNoneFlipX)
                BagPct.Image = btm
            Case 65
                PetTimer.Stop()
                Speech2Lbl.Text = TxtFromFile(Lang, "IntroSpeechR", 4)
            Case 70 To 76 'Szczur wraca
                SunPct.Image = Image.FromFile(PngFromFile("Sun3"))
                Speech2Tbl.Visible = False
                RatRunInd += 1
                If RatRunInd > 6 Then
                    RatRunInd = 1
                End If
                RatRunPct.Image = ResizeImage(Image.FromFile(PngFromFile("RatRun" & RatRunInd)), 70)
                If RatRunPct.Location.X < 800 Then
                    RatRunPct.Location = New Drawing.Point(RatRunPct.Location.X + 10, RatRunPct.Location.Y)
                    BagPct.Image = ResizeImage(Image.FromFile(PngFromFile("Bag5")), 100)
                    BagPct.Location = New Drawing.Point(RatRunPct.Location.X - 130, BagPct.Location.Y)
                Else
                    RatRunPct.Location = New Drawing.Point(800, RatRunPct.Location.Y)
                    BagPct.Visible = False
                End If

            Case 79
                If Sound Then PlaySound("BackIntro", True)
                RatRunPct.Visible = False
                LenkaPct.Image = ResizeImage(Image.FromFile(PngFromFile("Lenka1")), 50)
                LenkaPct.Visible = True
                Speech1Tbl.Visible = True
                Speech1Lbl.Text = TxtFromFile(Lang, "IntroSpeechL", 5)
            Case 80 To 82
                If LenkaPct.Location.X < 15 Then
                    LenkaPct.Location = New Drawing.Point(LenkaPct.Location.X + 10, LenkaPct.Location.Y)
                Else
                    LenkaPct.Location = New Drawing.Point(15, LenkaPct.Location.Y)
                End If
            Case 83
                LenkaPct.Image = ResizeImage(Image.FromFile(PngFromFile("Lenka8")), 50)
                Speech1Lbl.Text = TxtFromFile(Lang, "IntroSpeechL", 6)
            Case 88
                LenkaPct.Image = ResizeImage(Image.FromFile(PngFromFile("Lenka6")), 50)
                Speech1Lbl.Text = TxtFromFile(Lang, "IntroSpeechL", 7)
            Case 93
                LenkaPct.Image = ResizeImage(Image.FromFile(PngFromFile("Lenka2")), 50)
                Speech1Lbl.Text = TxtFromFile(Lang, "IntroSpeechL", 8)

            Case 95 To 97
                If LenkaPct.Location.X > -65 Then
                    LenkaPct.Location = New Drawing.Point(LenkaPct.Location.X - 10, LenkaPct.Location.Y)
                Else
                    LenkaPct.Location = New Drawing.Point(-65, LenkaPct.Location.Y)
                End If
            Case 98
                LenkaPct.Visible = False
                Speech1Tbl.Visible = False
                LenkaRunPct.Location = New Drawing.Point(300, LenkaRunPct.Location.Y)
            Case 99
                If Sound Then PlaySound("BackRunning", True)
            Case 100 To 103 'Lenka biegnie
                SunPct.Image = Image.FromFile(PngFromFile("Sun1"))
                LenkaRunPct.Visible = True
                LenkaRunInd += 1
                If LenkaRunInd > 8 Then
                    LenkaRunInd = 1
                End If
                LenkaRunPct.Image = ResizeImage(Image.FromFile(PngFromFile("LenkaRun" & LenkaRunInd)), 40)

                If LenkaRunPct.Location.X < 800 Then
                    LenkaRunPct.Location = New Drawing.Point(LenkaRunPct.Location.X + 20, LenkaRunPct.Location.Y)
                Else
                    LenkaRunPct.Location = New Drawing.Point(800, LenkaRunPct.Location.Y)
                End If
            Case 104
                OpBtn.Visible = True
                OpBtn.Text = TxtFromFile(Lang, "Intro", 2)
                SkipNotReplay = False
            Case 109
                NextForm()
        End Select
    End Sub

    Private Sub OpBtn_Click(sender As Object, e As EventArgs) Handles OpBtn.Click
        If SkipNotReplay = True Then
            NextForm()
        Else
            Replay()
        End If
    End Sub

    Private Sub NextForm()
        LoadSavePosition(Me, True)
        StopSound()
        BackTimer.Stop()
        PetTimer.Stop()
        StoryTimer.Stop()
        RunForm.Show()
        Me.Close()
    End Sub

    Private Sub Replay()
        LoadSavePosition(Me, True)
        Me.Intro_Load(Nothing, Nothing)
    End Sub


    Private Sub Btn_MouseHover(sender As Object, e As EventArgs) Handles MyBase.MouseHover, Cloud1Pct.MouseHover,
            Cloud2Pct.MouseHover, Cloud3Pct.MouseHover, Cloud4Pct.MouseHover, Speech1Lbl.MouseHover, Speech2Lbl.MouseHover,
            LenkaPct.MouseHover, LenkaRunPct.MouseHover, RatPct.MouseHover, RatRunPct.MouseHover, BagPct.MouseHover,
            Pet1Pct.MouseHover, Pet2Pct.MouseHover, Pet3Pct.MouseHover, Pet4Pct.MouseHover, Pet5Pct.MouseHover, SunPct.MouseHover,
            SetBtn.MouseHover, OpBtn.MouseHover

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

    Private Sub IntroForm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        FormNameGlobal = Me.Name
    End Sub
End Class