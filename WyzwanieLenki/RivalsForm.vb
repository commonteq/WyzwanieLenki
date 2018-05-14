Public Class RivalsForm
    Private StoryCounter As Integer
    Private StoryTime As Single
    Private PetCounter As Integer
    Private CageInd As Byte = Nothing
    Private CageInc As SByte = Nothing
    Private CageMovement As SByte = Nothing
    Private SkipNotReplay As Boolean = Nothing

#Region "MovingWindow by mouse"
    Private Sub Form_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, Speech1Lbl.MouseDown,
            Speech2Lbl.MouseDown, LenkaPct.MouseDown, RatPct.MouseDown, Cage1Pct.MouseDown, Cage2Pct.MouseDown,
            Cage3Pct.MouseDown, Cage4Pct.MouseDown, Cage5Pct.MouseDown
        MouseD(Me, e)
    End Sub

    Private Sub Form_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp, Speech1Lbl.MouseUp,
            Speech2Lbl.MouseUp, LenkaPct.MouseUp, RatPct.MouseUp, Cage1Pct.MouseUp, Cage2Pct.MouseUp,
            Cage3Pct.MouseUp, Cage4Pct.MouseUp, Cage5Pct.MouseUp
        MouseU(Me)
    End Sub

    Private Sub Form_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove, Speech1Lbl.MouseMove,
            Speech2Lbl.MouseMove, LenkaPct.MouseMove, RatPct.MouseMove, Cage1Pct.MouseMove, Cage2Pct.MouseMove,
            Cage3Pct.MouseMove, Cage4Pct.MouseMove, Cage5Pct.MouseMove
        MouseM(Me)
    End Sub
#End Region

    Private Sub RivalsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSavePosition(Me, False)
        TitleIcon(Me)
        If Sound Then PlaySound("BackRivals", True)

        Me.BackgroundImage = Image.FromFile(PngFromFile("BackRivals"))

        For Each ictrl As Control In Me.Controls
            If TypeOf ictrl Is PictureBox Then
                Dim ctrl As PictureBox = ictrl
                If Strings.Left(ctrl.Name, 4) = "Cage" Then
                    ctrl.Image = ResizeImage(Image.FromFile(PngFromFile("Cage")), 100)
                    ctrl.BackgroundImage = ResizeImage(Image.FromFile(PngFromFile("Pet" & Strings.Right(Strings.Left(ctrl.Name, 5), 1))), 50)
                End If

                Dim str As String = Strings.Left(ctrl.Name, 3)
                If str = "Pet" Then
                    ctrl.Image = ResizeImage(Image.FromFile(PngFromFile("Pet" & Strings.Right(Strings.Left(ctrl.Name, 4), 1))), 50)
                ElseIf str = "Len" Or str = "Rat" Then
                    ctrl.Visible = False
                End If
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
                If ctrl.Name <> "SetBtn" Then
                    ctrl.BackgroundImage = Image.FromFile(PngFromFile("ButtonStart"))
                    ctrl.Visible = False
                    'If ctrl.Name = "OpBtn" Then
                    '    ctrl.Text = TxtFromFile(Lang, "Intro", 1)
                    'End If
                End If
                'Else
                '    ctrl.ForeColor = Color.FromArgb(0, 50, 100)
            End If
        Next

        StoryCounter = 0
        PetCounter = 0
        StoryTimer.Start()
        BackTimer.Start()
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
        StoryCounter += 1
        StoryTime = TimerValueToTime(StoryTimer.Interval, StoryCounter)

        If StoryTime = 600 Then
            StoryCounter = 0
            TimerRestart(StoryTimer)
        End If

        Select Case StoryTime
            Case 1
                OpBtn.Visible = True
                OpBtn.Text = TxtFromFile(Lang, "Intro", 1)
                SkipNotReplay = True
            Case 4
                LenkaPct.Location = New Drawing.Point(0 - 130, LenkaPct.Location.Y)
                LenkaPct.Visible = True
                LenkaPct.Image = ResizeImage(Image.FromFile(PngFromFile("Lenka4")), 100)
                RatPct.Location = New Drawing.Point(800 + 175, RatPct.Location.Y)
                RatPct.Visible = True
                RatPct.Image = ResizeImage(Image.FromFile(PngFromFile("Rat1")), 100)
            Case 5 To 6
                OpBtn.Visible = False
                If LenkaPct.Location.X < 25 Then
                    LenkaPct.Location = New Drawing.Point(LenkaPct.Location.X + 30, LenkaPct.Location.Y)
                Else
                    LenkaPct.Location = New Drawing.Point(25, LenkaPct.Location.Y)
                End If
            Case 7 'Lenka
                SpeechVis(True, False)
                SpeechTxt(True, TxtFromFile(Lang, "Rivals", 1))
            Case 8 To 9.5
                If RatPct.Location.X > 600 Then
                    RatPct.Location = New Drawing.Point(RatPct.Location.X - 30, RatPct.Location.Y)
                Else
                    RatPct.Location = New Drawing.Point(600, RatPct.Location.Y)
                End If
            Case 10 'Rat
                SpeechVis(False, True)
                SpeechTxt(False, TxtFromFile(Lang, "Rivals", 2))
            Case 15 'Lenka
                SpeechVis(True, False)
                SpeechTxt(True, TxtFromFile(Lang, "Rivals", 3))
            Case 20 'Rat
                SpeechVis(False, True)
                SpeechTxt(False, TxtFromFile(Lang, "Rivals", 4))
                RatPct.Image = Image.FromFile(PngFromFile("Rat5"))
            Case 25 'Lenka
                SpeechVis(True, False)
                SpeechTxt(True, TxtFromFile(Lang, "Rivals", 5))
                LenkaPct.Image = Image.FromFile(PngFromFile("Lenka6"))
            Case 30 'Rat
                SpeechVis(False, True)
                SpeechTxt(False, TxtFromFile(Lang, "Rivals", 6))
                RatPct.Image = Image.FromFile(PngFromFile("Rat3"))
            Case 35 'Rat
                SpeechVis(False, True)
                SpeechTxt(False, TxtFromFile(Lang, "Rivals", 7))
            Case 40 'Lenka
                SpeechVis(True, False)
                SpeechTxt(True, TxtFromFile(Lang, "Rivals", 8))
                LenkaPct.Image = Image.FromFile(PngFromFile("Lenka6"))
            Case 45 'Rat
                SpeechVis(False, True)
                SpeechTxt(False, TxtFromFile(Lang, "Rivals", 9))
                RatPct.Image = Image.FromFile(PngFromFile("Rat4"))
            Case 50 'Lenka
                SpeechVis(True, False)
                SpeechTxt(True, TxtFromFile(Lang, "Rivals", 10))
                LenkaPct.Image = Image.FromFile(PngFromFile("Lenka8"))
            Case 55 'Rat
                SpeechVis(False, True)
                SpeechTxt(False, TxtFromFile(Lang, "Rivals", 11))
                RatPct.Image = Image.FromFile(PngFromFile("Rat5"))
            Case 60 'Rat
                SpeechVis(False, True)
                SpeechTxt(False, TxtFromFile(Lang, "Rivals", 12))
            Case 65 'Lenka
                SpeechVis(True, False)
                SpeechTxt(True, TxtFromFile(Lang, "Rivals", 13))
                LenkaPct.Image = Image.FromFile(PngFromFile("Lenka2"))
            Case 70 'waiting
                SpeechVis(False, False)
                StartBtn.Visible = True
                BackTimer.Stop()
                StoryTimer.Stop()
                OpBtn.Visible = True
                OpBtn.Text = TxtFromFile(Lang, "Intro", 2)
                SkipNotReplay = False
        End Select
    End Sub

    Public Sub SpeechVis(Speech1 As Boolean, Speech2 As Boolean)
        Speech1Tbl.Visible = Speech1
        Speech2Tbl.Visible = Speech2
    End Sub

    Public Sub SpeechTxt(Speech1 As Boolean, Text As String)
        If Speech1 = True Then
            Speech1Lbl.Text = Text
        Else
            Speech2Lbl.Text = Text
        End If
    End Sub

    Private Sub NextForm()
        LoadSavePosition(Me, True)
        Fight = 1
        StopSound()
        BattleForm.Show()
        Me.Close()
    End Sub

    Private Sub Replay()
        LoadSavePosition(Me, True)
        RivalsForm_Load(Nothing, Nothing)
    End Sub

    Private Sub Btn_Click(sender As Object, e As EventArgs) Handles StartBtn.Click, OpBtn.Click
        Dim ctrl As Control = CType(sender, Button)
        If ctrl.Name = "StartBtn" Then
            NextForm()
        Else
            If SkipNotReplay = True Then
                NextForm()
            Else
                Replay()
            End If
        End If
    End Sub

    Private Sub DeployForm_MouseHover(sender As Object, e As EventArgs) Handles MyBase.MouseHover, Speech1Lbl.MouseHover,
            Speech2Lbl.MouseHover, LenkaPct.MouseHover, RatPct.MouseHover, Cage1Pct.MouseHover, Cage2Pct.MouseHover,
        Cage3Pct.MouseHover, Cage4Pct.MouseHover, Cage5Pct.MouseHover, SetBtn.MouseHover, OpBtn.MouseHover, StartBtn.MouseHover

        Dim ctrl As Control = CType(sender, Control)
        For Each ictrl As Control In Me.Controls
            If TypeOf ictrl Is Button Then
                If ctrl.Name = ictrl.Name Then
                    ictrl.ForeColor = Color.Yellow
                    'ElseIf ictrl.Name = "SetBtn" Then
                    '    ictrl.ForeColor = Color.FromArgb(0, 50, 100)
                Else
                    ictrl.ForeColor = Color.White
                End If
            End If
        Next
    End Sub

    Private Sub SetBtn_Click(sender As Object, e As EventArgs) Handles SetBtn.Click
        MenuForm.ShowDialog()
    End Sub

    Private Sub RivalsForm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        FormNameGlobal = Me.Name
    End Sub
End Class