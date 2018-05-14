Imports System.Drawing.Text
Public Class TitleForm
    Private StoryCounter As Integer = Nothing
    Private StoryTime As Integer = Nothing

#Region "MovingWindow by mouse"
    Private Sub Form_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, A1Pct.MouseDown,
            A2Pct.MouseDown, TitleLay.MouseDown, LenkaPct.MouseDown, PetPct.MouseDown, RatPct.MouseDown,
            Title1Lbl.MouseDown, Title2Lbl.MouseDown
        MouseD(Me, e)
    End Sub

    Private Sub Form_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp, A1Pct.MouseUp,
            A2Pct.MouseUp, TitleLay.MouseUp, LenkaPct.MouseUp, PetPct.MouseUp, RatPct.MouseUp,
            Title1Lbl.MouseUp, Title2Lbl.MouseUp
        MouseU(Me)
    End Sub

    Private Sub Form_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove, A1Pct.MouseMove,
            A2Pct.MouseMove, TitleLay.MouseMove, LenkaPct.MouseMove, PetPct.MouseMove, RatPct.MouseMove,
            Title1Lbl.MouseMove, Title2Lbl.MouseMove
        MouseM(Me)
    End Sub
#End Region

    Private Sub TitleForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSavePosition(Me, False)
        TitleIcon(Me)
        TxtLoad()
        If Sound Then PlaySound("BackTitle", True)
        For Each ctrl As Label In TitleLay.Controls
            ctrl.Font = New Font(Lfont, 24)
            ctrl.ForeColor = Color.FromArgb(0, 50, 100)
        Next

        StartBtn.BackgroundImage = Image.FromFile(PngFromFile("ButtonStart"))
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Button Then
                ctrl.Font = New Font(Lfont, 20)
                ctrl.ForeColor = Color.White
            End If
        Next
        SetBtn.ForeColor = Color.FromArgb(0, 50, 100)

        'Initial images settings
        LenkaPct.Location = New Drawing.Point(30, 410 + 200)
        LenkaPct.Image = Image.FromFile(PngFromFile("Lenka4"))
        RatPct.Location = New Drawing.Point(615 + 175 + 15, 460)
        RatPct.Image = Image.FromFile(PngFromFile("Rat1"))
        PetPct.Location = New Drawing.Point(190, 460)
        PetPct.Image = Image.FromFile(PngFromFile("Pet5"))
        PetPct.Visible = False

        StoryTimer.Start()
    End Sub

    Private Sub TxtLoad()
        Dim A1 As Image = Image.FromFile(PngFromFile("A1_" & Lang))
        Dim A2 As Image = Image.FromFile(PngFromFile("A2_" & Lang))
        A1Pct.Width = A1.Width
        A2Pct.Width = A2.Width
        A2Pct.Left = (Me.Width - A2.Width) - A1Pct.Location.X
        A1Pct.Image = A1
        A2Pct.Image = A2

        Title1Lbl.Text = TxtFromFile(Lang, "Title", 2)
        Title2Lbl.Text = TxtFromFile(Lang, "Title", 3)
    End Sub


    Private Sub Btn_MouseHover(sender As Object, e As EventArgs) Handles StartBtn.MouseHover, SetBtn.MouseHover,
            Me.MouseHover, A1Pct.MouseHover, A2Pct.MouseHover, TitleLay.MouseHover, LenkaPct.MouseHover,
            RatPct.MouseHover, PetPct.MouseHover

        Dim ictrl As Control = CType(sender, Control)
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Button Then
                If ctrl.Name = "SetBtn" Then
                    ctrl.ForeColor = Color.FromArgb(0, 50, 100)
                Else
                    ctrl.ForeColor = Color.White
                End If
            End If
        Next
        ictrl.ForeColor = Color.Yellow
    End Sub

    Private Sub StoryTimer_Tick(sender As Object, e As EventArgs) Handles StoryTimer.Tick
        StoryCounter += 1
        StoryTime = TimerValueToTime(StoryTimer.Interval, StoryCounter)
        StoryTimeGlobal = StoryTime
        Select Case StoryTime
            Case 1
                LenkaPct.Location = New Drawing.Point(30, 410 + 200)
            Case 2 To 3
                If LenkaPct.Location.Y > 410 Then
                    LenkaPct.Location = New Drawing.Point(30, LenkaPct.Location.Y - 5)
                Else
                    LenkaPct.Location = New Drawing.Point(30, 410)
                End If
            Case 4
                LenkaPct.Image = Image.FromFile(PngFromFile("Lenka2"))
            Case 5
                LenkaPct.Image = Image.FromFile(PngFromFile("Lenka4"))
            Case 6
                PetPct.Visible = True
            Case 7
                LenkaPct.Image = Image.FromFile(PngFromFile("Lenka3"))
            Case 8
                LenkaPct.Image = Image.FromFile(PngFromFile("Lenka4"))
            Case 9
                LenkaPct.Visible = False
            Case 10
                RatPct.Location = New Drawing.Point(615 + 190, 460)
            Case 11 To 12
                If RatPct.Location.X > 615 Then
                    RatPct.Location = New Drawing.Point(RatPct.Location.X - 5, RatPct.Location.Y)
                Else
                    RatPct.Location = New Drawing.Point(615, RatPct.Location.Y)
                End If
            Case 13
                RatPct.Image = Image.FromFile(PngFromFile("Rat2"))
                StartBtn.Visible = False
            Case 14 To 16
                If RatPct.Location.X > 0 - RatPct.Width Then
                    RatPct.Location = New Drawing.Point(RatPct.Location.X - 5, RatPct.Location.Y)
                Else
                    RatPct.Location = New Drawing.Point(0 - RatPct.Width)
                    RatPct.Visible = False
                End If

                If RatPct.Location.X <= PetPct.Location.X + PetPct.Width Then
                    PetPct.Visible = False
                Else
                    PetPct.Visible = True
                End If
            Case 17
                LenkaPct.Visible = True
            Case 18
                LenkaPct.Image = Image.FromFile(PngFromFile("Lenka5"))
                StartBtn.Visible = True
            Case 25
                ScoreForm.Show()
                Me.Close()
                'Case 60
                '    TimerRestart(StoryTimer)
                '    StoryCounter = 0
        End Select
    End Sub

    Private Sub StartBtn_Click(sender As Object, e As EventArgs) Handles StartBtn.Click, SetBtn.Click
        Dim ctrl As Control = CType(sender, Control)

        Select Case ctrl.Name
            Case "StartBtn"
                LoadSavePosition(Me, True)
                LevelForm.Show()
                Me.Close()
            Case "SetBtn"
                MenuForm.ShowDialog()
        End Select
    End Sub

    Private Sub TitleForm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        TxtLoad()
        FormNameGlobal = Me.Name

    End Sub

    Private Sub TitleForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown, StartBtn.KeyDown
        'Label1.Text = e.KeyData
        If e.KeyData = Keys.Control + Keys.Shift + Keys.A Then
            AdminForm.Show()
            Me.Close()
        End If
    End Sub
End Class