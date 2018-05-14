Public Class OutroForm
    Private PetCounter As Integer
    Private Pet4Dir As Boolean
    Private PetTime As Single
    Private StoryCounter As Integer
    Private StoryTime As Single
    Private LenkaRunInd As Byte = Nothing
    Private DefPet(5) As Point
    Private Jump As Boolean = Nothing
    Private JumpVal As SByte = Nothing
    Private SkipNotReplay As Boolean = Nothing

#Region "MovingWindow by mouse"
    Private Sub Form_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, Cloud1Pct.MouseDown,
            Cloud2Pct.MouseDown, Cloud3Pct.MouseDown, Cloud4Pct.MouseDown, LenkaPct.MouseDown, LenkaRunPct.MouseDown,
            Pet1Pct.MouseDown, Pet2Pct.MouseDown, Pet3Pct.MouseDown, Pet4Pct.MouseDown, Pet5Pct.MouseDown, SunPct.MouseDown
        MouseD(Me, e)
    End Sub

    Private Sub Form_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp, Cloud1Pct.MouseUp,
            Cloud2Pct.MouseUp, Cloud3Pct.MouseUp, Cloud4Pct.MouseUp, LenkaPct.MouseUp, LenkaRunPct.MouseUp,
            Pet1Pct.MouseUp, Pet2Pct.MouseUp, Pet3Pct.MouseUp, Pet4Pct.MouseUp, Pet5Pct.MouseUp, SunPct.MouseUp
        MouseU(Me)
    End Sub

    Private Sub Form_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove, Cloud1Pct.MouseMove,
            Cloud2Pct.MouseMove, Cloud3Pct.MouseMove, Cloud4Pct.MouseMove, LenkaPct.MouseMove, LenkaRunPct.MouseMove,
            Pet1Pct.MouseMove, Pet2Pct.MouseMove, Pet3Pct.MouseMove, Pet4Pct.MouseMove, Pet5Pct.MouseMove, SunPct.MouseMove
        MouseM(Me)
    End Sub
#End Region

    Private Sub OutroForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSavePosition(Me, False)
        TitleIcon(Me)
        If Sound Then PlaySound("BackIntro", True)
        Me.BackgroundImage = Image.FromFile(PngFromFile("BackIntro"))

        'Zapis domyslnych pozycji dla kazdego zwierzecia (pozycje w domku)
        Pet4Pct.Location = New Drawing.Point(170, 282)
        For i As Byte = 1 To 5
            Dim Ctrl As PictureBox = CType(Me.Controls("Pet" & i & "Pct"), PictureBox)
            Ctrl.Visible = False
            DefPet(i) = New Drawing.Point(Ctrl.Location.X, Ctrl.Location.Y)
        Next

        For Each ictrl As Control In Me.Controls
            If TypeOf ictrl Is PictureBox Then
                Dim ctrl As PictureBox = ictrl
                If Strings.Left(ctrl.Name, 5) = "Cloud" Then ctrl.Image = Image.FromFile(PngFromFile("Cloud"))

                If Strings.Left(ctrl.Name, 3) = "Pet" Then
                    ctrl.Image = ResizeImage(Image.FromFile(PngFromFile("Pet" & Strings.Right(Strings.Left(ctrl.Name, 4), 1))), 50)
                End If

                Select Case ctrl.Name
                    Case "SunPct" : ctrl.Image = Image.FromFile(PngFromFile("Sun1"))
                    Case "LenkaPct"
                        ctrl.Image = ResizeImage(Image.FromFile(PngFromFile("Lenka1")), 50)
                        ctrl.Visible = False
                End Select
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

        PetTimer.Stop() 'ze wzgledu na mozliwosc Replay (powoduja anomalie z polozeniem zwierzat)
        'PetTimer.Start() 'uruchamiany jest pozniej
        PetCounter = 0
        Pet4Dir = False
        StoryCounter = 0
        BackTimer.Start()
        StoryTimer.Start()
        Jump = False
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

        If StoryTime = 600 Then '600 = 60s * 10 = 10min
            StoryCounter = 0
            TimerRestart(StoryTimer)
        End If

        Select Case StoryTime
            Case 1
                OpBtn.Visible = True
                OpBtn.Text = TxtFromFile(Lang, "Intro", 1)
                SkipNotReplay = True
            Case 4
                OpBtn.Visible = False
                LenkaRunPct.Visible = True
                LenkaRunPct.Location = New Drawing.Point(800, LenkaRunPct.Location.Y)
            Case 5 To 8
                LenkaRunInd += 1
                If LenkaRunInd > 8 Then
                    LenkaRunInd = 1
                End If

                Dim bmp As Bitmap = ResizeImage(Image.FromFile(PngFromFile("LenkaRun" & LenkaRunInd)), 40)
                bmp.RotateFlip(RotateFlipType.RotateNoneFlipX)
                LenkaRunPct.Image = bmp

                If LenkaRunPct.Location.X > 300 Then
                    LenkaRunPct.Location = New Drawing.Point(LenkaRunPct.Location.X - 20, LenkaRunPct.Location.Y)
                Else
                    LenkaRunPct.Location = New Drawing.Point(300, LenkaRunPct.Location.Y)
                    LenkaRunPct.Visible = False
                End If
            Case 9
                For i As Byte = 1 To 5
                    Dim Ctrl As PictureBox = CType(Me.Controls("Pet" & i & "Pct"), PictureBox)
                    Ctrl.Visible = True
                    Ctrl.Location = New Drawing.Point(800 + i * 200, 500)
                Next
                LenkaPct.Location = New Drawing.Point(15 - 65, LenkaPct.Location.Y)
            Case 10 To 11
                LenkaPct.Visible = True
                If LenkaPct.Location.X < 15 Then
                    LenkaPct.Location = New Drawing.Point(LenkaPct.Location.X + 10, LenkaPct.Location.Y)
                Else
                    LenkaPct.Location = New Drawing.Point(15, LenkaPct.Location.Y)
                End If
            Case 12 To 21
                Jump = Not Jump
                If Jump = False Then
                    JumpVal = 50
                Else
                    JumpVal = -50
                End If

                For i As Byte = 1 To 5
                    Dim Ctrl As PictureBox = CType(Me.Controls("Pet" & i & "Pct"), PictureBox)
                    Ctrl.Visible = True

                    If Ctrl.Location.X > 300 Then
                        Ctrl.Location = New Drawing.Point(Ctrl.Location.X - 20, Ctrl.Location.Y + JumpVal)
                    Else
                        Ctrl.Location = DefPet(i)
                    End If
                Next
            Case 21.5 : PetTimer.Start()
            Case 22 To 24
                If LenkaPct.Location.X > -65 Then
                    LenkaPct.Location = New Drawing.Point(LenkaPct.Location.X - 10, LenkaPct.Location.Y)
                Else
                    LenkaPct.Location = New Drawing.Point(-65, LenkaPct.Location.Y)
                End If
            Case 26 To 29
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
                    LenkaRunPct.Visible = False
                End If
            Case 30
                OpBtn.Visible = True
                OpBtn.Text = TxtFromFile(Lang, "Intro", 2)
                SkipNotReplay = False
            Case 35
                LoadSavePosition(Me, True)
                EndingForm.Show()
                Me.Close()
        End Select
    End Sub

    Private Sub NextForm()
        LoadSavePosition(Me, True)
        BackTimer.Stop()
        PetTimer.Stop()
        StoryTimer.Stop()
        StopSound()
        EndingForm.Show()
        'System.Threading.Thread.Sleep(100)
        Me.Close()
    End Sub

    Private Sub Replay()
        'PetTimer.Stop()
        LoadSavePosition(Me, True)
        Me.OutroForm_Load(Nothing, Nothing)
    End Sub

    Private Sub OpBtn_Click(sender As Object, e As EventArgs) Handles OpBtn.Click
        If SkipNotReplay = True Then
            NextForm()
        Else
            Replay()
        End If
    End Sub

    Private Sub Btn_MouseHover(sender As Object, e As EventArgs) Handles MyBase.MouseHover, Cloud1Pct.MouseHover,
        Cloud2Pct.MouseHover, Cloud3Pct.MouseHover, Cloud4Pct.MouseHover, LenkaPct.MouseHover, LenkaRunPct.MouseHover,
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

    Private Sub OutroForm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        FormNameGlobal = Me.Name
    End Sub
End Class