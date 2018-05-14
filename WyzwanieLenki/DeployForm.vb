Public Class DeployForm
    Private StoryCounter As Integer
    Private StoryTime As Single
    Private RatRunInd As Byte = Nothing
    Private LenkaRunInd As Byte = Nothing
    Private CageFirst As Boolean = False
    Private CageMovement As SByte = Nothing
    Private CageInd As Byte = Nothing
    Private CageInc As SByte = Nothing
    Private SkipNotReplay As Boolean = Nothing

#Region "MovingWindow by mouse"
    Private Sub Form_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, Speech1Lbl.MouseDown,
            LenkaRunPct.MouseDown, RatRunPct.MouseDown, BagPct.MouseDown, Cage1Pct.MouseDown, Cage2Pct.MouseDown,
            Cage3Pct.MouseDown, Cage4Pct.MouseDown, Cage5Pct.MouseDown
        MouseD(Me, e)
    End Sub

    Private Sub Form_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp, Speech1Lbl.MouseUp,
            LenkaRunPct.MouseUp, RatRunPct.MouseUp, BagPct.MouseUp, Cage1Pct.MouseUp, Cage2Pct.MouseUp,
            Cage3Pct.MouseUp, Cage4Pct.MouseUp, Cage5Pct.MouseUp
        MouseU(Me)
    End Sub

    Private Sub Form_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove, Speech1Lbl.MouseMove,
            LenkaRunPct.MouseMove, RatRunPct.MouseMove, BagPct.MouseMove, Cage1Pct.MouseMove, Cage2Pct.MouseMove,
            Cage3Pct.MouseMove, Cage4Pct.MouseMove, Cage5Pct.MouseMove
        MouseM(Me)
    End Sub
#End Region

    Private Sub DeployForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSavePosition(Me, False)
        TitleIcon(Me)
        If Sound Then PlaySound("BackDeploy", True)

        Me.BackgroundImage = Image.FromFile(PngFromFile("BackDeploy"))

        For Each ictrl As Control In Me.Controls
            If TypeOf ictrl Is PictureBox Then
                Dim ctrl As PictureBox = ictrl
                If Strings.Left(ctrl.Name, 4) = "Cage" Then ctrl.Image = ResizeImage(Image.FromFile(PngFromFile("Cage")), 100)
            End If

            If TypeOf ictrl Is TableLayoutPanel Then
                Dim ctrl As TableLayoutPanel = ictrl
                ctrl.BackgroundImage = Image.FromFile(PngFromFile("CloudSpeech"))
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
        CageInd += 1
        CageInc = 2

        If CageInd > 4 Then
            CageInd = 1
        End If

        Select Case CageInd
            Case 1 : CageMovement = (-1) * CageInc
            Case 2 : CageMovement = 1 * CageInc
            Case 3 : CageMovement = 1 * CageInc
            Case 4 : CageMovement = (-1) * CageInc
        End Select

        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is PictureBox Then
                Select Case Strings.Right(Strings.Left(ctrl.Name, 5), 1)
                    Case 1 : ctrl.Location = New Drawing.Point(ctrl.Location.X + CageMovement, ctrl.Location.Y)
                    Case 2 : ctrl.Location = New Drawing.Point(ctrl.Location.X + CageMovement, ctrl.Location.Y + CageMovement)
                    Case 3 : ctrl.Location = New Drawing.Point(ctrl.Location.X, ctrl.Location.Y + CageMovement)
                    Case 4 : ctrl.Location = New Drawing.Point(ctrl.Location.X - CageMovement, ctrl.Location.Y - CageMovement)
                    Case 5 : ctrl.Location = New Drawing.Point(ctrl.Location.X + CageMovement, ctrl.Location.Y - CageMovement)
                End Select
            End If
        Next
    End Sub


    Private Sub StoryTimer_Tick(sender As Object, e As EventArgs) Handles StoryTimer.Tick
        Dim BagOffset As Integer = 130
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
                BagPct.Location = New Drawing.Point(RatRunPct.Location.X - BagOffset, BagPct.Location.Y)
                BagPct.Image = Image.FromFile(PngFromFile("Bag5"))
            Case 5 To 6.5 'Szczur wchodzi
                OpBtn.Visible = False
                RatRunInd += 1
                If RatRunInd > 6 Then
                    RatRunInd = 1
                End If

                RatRunPct.Image = ResizeImage(Image.FromFile(PngFromFile("RatRun" & RatRunInd)), 70)
                If RatRunPct.Location.X < 30 Then
                    RatRunPct.Location = New Drawing.Point(RatRunPct.Location.X + 10, RatRunPct.Location.Y)
                Else
                    RatRunPct.Location = New Drawing.Point(30, RatRunPct.Location.Y)
                End If
                BagPct.Location = New Drawing.Point(RatRunPct.Location.X - BagOffset, BagPct.Location.Y)
            Case 7 'Pierwsza klatka - uzupelnia zwierzeciem
                Cage1Pct.BackgroundImage = ResizeImage(Image.FromFile(PngFromFile("Pet1")), 50)
                BagPct.Image = ResizeImage(Image.FromFile(PngFromFile("Bag4")), 80)
                Speech1Tbl.Visible = True
                Speech1Tbl.Location = New Drawing.Point(150, Speech1Tbl.Location.Y)
                Speech1Lbl.Text = TxtFromFile(Lang, "Deploy", 1)
            Case 10 To 11.5 'Przechodzi do drugiej
                Speech1Tbl.Visible = False
                RatRunInd += 1
                If RatRunInd > 6 Then
                    RatRunInd = 1
                End If

                RatRunPct.Image = ResizeImage(Image.FromFile(PngFromFile("RatRun" & RatRunInd)), 70)
                If RatRunPct.Location.X < 180 Then
                    RatRunPct.Location = New Drawing.Point(RatRunPct.Location.X + 10, RatRunPct.Location.Y)
                Else
                    RatRunPct.Location = New Drawing.Point(180, RatRunPct.Location.Y)
                End If
                BagPct.Location = New Drawing.Point(RatRunPct.Location.X - BagOffset, BagPct.Location.Y)
            Case 12 'Druga klataka - uzupelnia zwierzeciem
                Cage2Pct.BackgroundImage = ResizeImage(Image.FromFile(PngFromFile("Pet2")), 50)
                BagPct.Image = ResizeImage(Image.FromFile(PngFromFile("Bag3")), 80)
                Speech1Tbl.Visible = True
                Speech1Tbl.Location = New Drawing.Point(300, Speech1Tbl.Location.Y)
                Speech1Lbl.Text = TxtFromFile(Lang, "Deploy", 2)
            Case 16 To 17.5 'Idzie do trzeciej
                Speech1Tbl.Visible = False
                RatRunInd += 1
                If RatRunInd > 6 Then
                    RatRunInd = 1
                End If

                RatRunPct.Image = ResizeImage(Image.FromFile(PngFromFile("RatRun" & RatRunInd)), 70)
                If RatRunPct.Location.X < 330 Then
                    RatRunPct.Location = New Drawing.Point(RatRunPct.Location.X + 10, RatRunPct.Location.Y)
                Else
                    RatRunPct.Location = New Drawing.Point(330, RatRunPct.Location.Y)
                End If
                BagPct.Location = New Drawing.Point(RatRunPct.Location.X - BagOffset, BagPct.Location.Y)
            Case 18 'trzecia klatka
                Cage3Pct.BackgroundImage = ResizeImage(Image.FromFile(PngFromFile("Pet3")), 50)
                BagPct.Image = ResizeImage(Image.FromFile(PngFromFile("Bag2")), 80)
                Speech1Tbl.Visible = True
                Speech1Tbl.Location = New Drawing.Point(450, Speech1Tbl.Location.Y)
                Speech1Lbl.Text = TxtFromFile(Lang, "Deploy", 3)
            Case 22 To 23.5 'idzie do czwartej
                Speech1Tbl.Visible = False
                RatRunInd += 1
                If RatRunInd > 6 Then
                    RatRunInd = 1
                End If

                RatRunPct.Image = ResizeImage(Image.FromFile(PngFromFile("RatRun" & RatRunInd)), 70)
                If RatRunPct.Location.X < 480 Then
                    RatRunPct.Location = New Drawing.Point(RatRunPct.Location.X + 10, RatRunPct.Location.Y)
                Else
                    RatRunPct.Location = New Drawing.Point(480, RatRunPct.Location.Y)
                End If
                BagPct.Location = New Drawing.Point(RatRunPct.Location.X - BagOffset, BagPct.Location.Y)
            Case 24 'czwarta klatka
                Cage4Pct.BackgroundImage = ResizeImage(Image.FromFile(PngFromFile("Pet4")), 50)
                BagPct.Image = ResizeImage(Image.FromFile(PngFromFile("Bag1")), 80)
                Speech1Tbl.Visible = True
                Speech1Tbl.Location = New Drawing.Point(180, Speech1Tbl.Location.Y)
                Dim btm As Bitmap = Speech1Tbl.BackgroundImage
                btm.RotateFlip(RotateFlipType.RotateNoneFlipX)
                Speech1Tbl.BackgroundImage = btm
                Speech1Lbl.Text = TxtFromFile(Lang, "Deploy", 4)
            Case 28 To 29.5 'idze do piatej
                Speech1Tbl.Visible = False
                RatRunInd += 1
                If RatRunInd > 6 Then
                    RatRunInd = 1
                End If

                RatRunPct.Image = ResizeImage(Image.FromFile(PngFromFile("RatRun" & RatRunInd)), 70)
                If RatRunPct.Location.X < 630 Then
                    RatRunPct.Location = New Drawing.Point(RatRunPct.Location.X + 10, RatRunPct.Location.Y)
                Else
                    RatRunPct.Location = New Drawing.Point(630, RatRunPct.Location.Y)
                End If
                BagPct.Location = New Drawing.Point(RatRunPct.Location.X - BagOffset, BagPct.Location.Y)
            Case 30 'piatka klatka
                Cage5Pct.BackgroundImage = ResizeImage(Image.FromFile(PngFromFile("Pet5")), 50)
                BagPct.Image = ResizeImage(Image.FromFile(PngFromFile("Bag0")), 80)
                Speech1Tbl.Visible = True
                Speech1Tbl.Location = New Drawing.Point(330, Speech1Tbl.Location.Y)
                Speech1Lbl.Text = TxtFromFile(Lang, "Deploy", 5)
            Case 34 'komentarz przed wyjsciem
                Speech1Lbl.Text = TxtFromFile(Lang, "Deploy", 6)
            Case 38 To 41.5 'wychodzi
                Speech1Tbl.Visible = False
                RatRunInd += 1
                If RatRunInd > 6 Then
                    RatRunInd = 1
                End If

                RatRunPct.Image = ResizeImage(Image.FromFile(PngFromFile("RatRun" & RatRunInd)), 70)
                If RatRunPct.Location.X < 1000 Then
                    RatRunPct.Location = New Drawing.Point(RatRunPct.Location.X + 10, RatRunPct.Location.Y)
                Else
                    RatRunPct.Location = New Drawing.Point(1000, RatRunPct.Location.Y)
                End If
                BagPct.Location = New Drawing.Point(RatRunPct.Location.X - BagOffset, BagPct.Location.Y)
            Case 46 'Ustawienia
                RatRunPct.Visible = False
                BagPct.Visible = False
                LenkaRunPct.Visible = True
                LenkaRunPct.Location = New Drawing.Point(-200, LenkaRunPct.Location.Y)
                If Sound Then PlaySound("BackRunning", True)
            Case 47 To 49 'Lenka wchodzi
                LenkaRunInd += 1
                If LenkaRunInd > 8 Then
                    LenkaRunInd = 1
                End If
                LenkaRunPct.Image = ResizeImage(Image.FromFile(PngFromFile("LenkaRun" & LenkaRunInd)), 40)

                If LenkaRunPct.Location.X < 400 Then
                    LenkaRunPct.Location = New Drawing.Point(LenkaRunPct.Location.X + 30, LenkaRunPct.Location.Y)
                Else
                    LenkaRunPct.Location = New Drawing.Point(400, LenkaRunPct.Location.Y)
                End If
            Case 50 'gada
                'Dim btm As Bitmap = Speech1Tbl.BackgroundImage
                'btm.RotateFlip(RotateFlipType.RotateNoneFlipX)
                'Speech1Tbl.BackgroundImage = btm
                Speech1Tbl.Location = New Drawing.Point(150, Speech1Tbl.Location.Y)
                Speech1Tbl.Visible = True
                Speech1Lbl.Text = TxtFromFile(Lang, "Deploy", 7)
            Case 55 'gada
                Speech1Lbl.Text = TxtFromFile(Lang, "Deploy", 8)
            Case 60 'gada
                Speech1Lbl.Text = TxtFromFile(Lang, "Deploy", 9)
            Case 65 To 67 'wychodzi
                Speech1Tbl.Visible = False
                LenkaRunInd += 1
                If LenkaRunInd > 8 Then
                    LenkaRunInd = 1
                End If
                LenkaRunPct.Image = ResizeImage(Image.FromFile(PngFromFile("LenkaRun" & LenkaRunInd)), 40)

                If LenkaRunPct.Location.X < 900 Then
                    LenkaRunPct.Location = New Drawing.Point(LenkaRunPct.Location.X + 30, LenkaRunPct.Location.Y)
                Else
                    LenkaRunPct.Location = New Drawing.Point(900, LenkaRunPct.Location.Y)
                End If
            Case 68
                OpBtn.Visible = True
                OpBtn.Text = TxtFromFile(Lang, "Intro", 2)
                SkipNotReplay = False
            Case 72 'koniec sceny
                NextForm()
        End Select
    End Sub

    Private Sub NextForm()
        LoadSavePosition(Me, True)
        StopSound()
        BackTimer.Stop()
        StoryTimer.Stop()
        RivalsForm.Show()
        Me.Close()
    End Sub

    Private Sub Replay()
        LoadSavePosition(Me, True)
        DeployForm_Load(Nothing, Nothing)
    End Sub

    Private Sub OpBtn_Click(sender As Object, e As EventArgs) Handles OpBtn.Click
        If SkipNotReplay = True Then
            NextForm()
        Else
            Replay()
        End If
    End Sub

    Private Sub DeployForm_MouseHover(sender As Object, e As EventArgs) Handles MyBase.MouseHover, Speech1Lbl.MouseHover,
            LenkaRunPct.MouseHover, RatRunPct.MouseHover, BagPct.MouseHover, Cage1Pct.MouseHover, Cage2Pct.MouseHover,
            Cage3Pct.MouseHover, Cage4Pct.MouseHover, Cage5Pct.MouseHover, SetBtn.MouseHover, OpBtn.MouseHover

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

    Private Sub DeployForm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        FormNameGlobal = Me.Name
    End Sub
End Class