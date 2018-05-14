Public Class RetrieveForm
    Private StoryCounter As Integer
    Private StoryTime As Single
    Private CageMovement As SByte = Nothing
    Private CageInd As Byte = Nothing
    Private CageInc As SByte = Nothing
    Private Jump As Boolean = Nothing
    Private JumpVal As SByte = Nothing

#Region "MovingWindow by mouse"
    Private Sub Form_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, PetPct.MouseDown,
        Cage1Pct.MouseDown, Cage2Pct.MouseDown, Cage3Pct.MouseDown, Cage4Pct.MouseDown, Cage5Pct.MouseDown
        MouseD(Me, e)
    End Sub

    Private Sub Form_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp, PetPct.MouseUp,
        Cage1Pct.MouseUp, Cage2Pct.MouseUp, Cage3Pct.MouseUp, Cage4Pct.MouseUp, Cage5Pct.MouseUp
        MouseU(Me)
    End Sub

    Private Sub Form_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove, PetPct.MouseMove,
        Cage1Pct.MouseMove, Cage2Pct.MouseMove, Cage3Pct.MouseMove, Cage4Pct.MouseMove, Cage5Pct.MouseMove
        MouseM(Me)
    End Sub
#End Region
    Private Sub RetrieveForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSavePosition(Me, False)
        TitleIcon(Me)
        If Sound Then PlaySound("BackRetrieve", True)

        Me.BackgroundImage = Image.FromFile(PngFromFile("BackDeploy"))

        For i As SByte = 5 To Fight Step -1
            Dim CagePct As PictureBox = CType(Me.Controls("Cage" & i & "Pct"), PictureBox)
            CagePct.BackgroundImage = ResizeImage(Image.FromFile(PngFromFile("Pet" & i)), 50)
        Next

        For Each ictrl As Control In Me.Controls
            If TypeOf ictrl Is PictureBox Then
                Dim ctrl As PictureBox = ictrl
                If Strings.Left(ctrl.Name, 4) = "Cage" Then
                    ctrl.Image = ResizeImage(Image.FromFile(PngFromFile("Cage")), 100)
                End If
                PetPct.Image = ResizeImage(Image.FromFile(PngFromFile("Pet" & Fight)), 50)
                PetPct.Visible = False
            End If
        Next

        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Button Then
                ctrl.Font = New Font(LFont, 20)
                ctrl.ForeColor = Color.White
            End If
        Next

        BackTimer.Start()
        StoryTimer.Start()
    End Sub

    Private Sub BackTimer_Tick(sender As Object, e As EventArgs) Handles BackTimer.Tick
        CageInd += 1
        CageInc = 2

        If CageInd > 4 Then CageInd = 1
        'Wartosci przemieszczenie dla wybranej klatki
        Select Case CageInd
            Case 1 : CageMovement = (-1) * CageInc
            Case 2 : CageMovement = 1 * CageInc
            Case 3 : CageMovement = 1 * CageInc
            Case 4 : CageMovement = (-1) * CageInc
        End Select
        'Poruszanie sie klatek
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

        Dim Cage As PictureBox = CType(Me.Controls("Cage" & Fight & "Pct"), PictureBox)
        If StoryTime = 600 Then
            StoryCounter = 0
            TimerRestart(StoryTimer)
        End If

        Select Case StoryTime
            Case 3.5 : Cage.BackgroundImage = Nothing 'Zwierze znika z klatki
            Case 4.0 : PetPct.Location = New Drawing.Point(60 + (Fight - 1) * 155, 400) 'pozorne opadanie z klatki
                PetPct.Visible = True
            Case 4.5 : PetPct.Location = New Drawing.Point(60 + (Fight - 1) * 155, 480)
            Case 5 To 7
                If PetPct.Location.X > -150 Then 'Przemieszczanie sie za ekran w lewo
                    Jump = Not Jump
                    If Jump = False Then 'Powoduje zludzenie podskakiwania
                        JumpVal = 50
                    Else
                        JumpVal = -50
                    End If
                    PetPct.Location = New Drawing.Point(PetPct.Location.X - 50, PetPct.Location.Y + JumpVal)
                End If
            Case 9
                LoadSavePosition(Me, True)
                Fight += 1
                BackTimer.Stop()
                StoryTimer.Stop()
                'W przypadku ostatniej walki uruchmiany jest ending
                StopSound()
                If Fight > 5 Then OutroForm.Show() Else BattleForm.Show()
                Me.Close()
        End Select
    End Sub

    Private Sub DeployForm_MouseHover(sender As Object, e As EventArgs) Handles MyBase.MouseHover, Cage1Pct.MouseHover,
            Cage2Pct.MouseHover, Cage3Pct.MouseHover, Cage4Pct.MouseHover, Cage5Pct.MouseHover, PetPct.MouseHover, SetBtn.MouseHover
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

    Private Sub RetrieveForm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        FormNameGlobal = Me.Name
    End Sub
End Class