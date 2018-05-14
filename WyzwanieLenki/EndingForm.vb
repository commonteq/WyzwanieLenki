Imports System.Windows.Forms

Public Class EndingForm
    Private StoryCounter As Integer
    Private StoryTime As Single
    Private RatRunInd As Byte = Nothing
    Private LenkaRunInd As Byte = Nothing
    Private IncX As SByte
    Private IncT As SByte
    Private TxtInd As Byte = Nothing
    Private TxtStr As String = Nothing
    Private TxtCnt As Integer = Nothing
    Private ScoreToHigh As Boolean = Nothing


#Region "MovingWindow by mouse"
    Private Sub Form_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, Cloud1Pct.MouseDown,
            Cloud2Pct.MouseDown, Cloud3Pct.MouseDown, Cloud4Pct.MouseDown, LenkaRunPct.MouseDown, TitleLay.MouseDown,
            TitleLbl.MouseDown, TextLbl.MouseDown
        MouseD(Me, e)
    End Sub

    Private Sub Form_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp, Cloud1Pct.MouseUp,
            Cloud2Pct.MouseUp, Cloud3Pct.MouseUp, Cloud4Pct.MouseUp, LenkaRunPct.MouseUp, TitleLay.MouseUp,
            TitleLbl.MouseUp, TextLbl.MouseUp
        MouseU(Me)
    End Sub

    Private Sub Form_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove, Cloud1Pct.MouseMove,
            Cloud2Pct.MouseMove, Cloud3Pct.MouseMove, Cloud4Pct.MouseMove, LenkaRunPct.MouseMove, TitleLay.MouseMove,
            TitleLbl.MouseMove, TextLbl.MouseMove
        MouseM(Me)
    End Sub
#End Region

    Private Sub EndingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSavePosition(Me, False)
        TitleIcon(Me)
        If Sound Then PlaySound("BackEnding", True)
        Me.BackgroundImage = Image.FromFile(PngFromFile("BackRun"))

        For Each ictrl As Control In Me.Controls
            If TypeOf ictrl Is PictureBox Then
                Dim ctrl As PictureBox = ictrl
                If Strings.Left(ctrl.Name, 5) = "Cloud" Then
                    ctrl.Image = Image.FromFile(PngFromFile("Cloud"))
                End If
            End If

            If TypeOf ictrl Is TableLayoutPanel Then
                Dim jctrl As TableLayoutPanel = ictrl
                For Each ctrl As Control In jctrl.Controls
                    If ctrl.Name = "TitleLbl" Then
                        ctrl.Font = New Font(LFont, 40)
                        ctrl.ForeColor = Color.FromArgb(220, 50, 0)
                    ElseIf ctrl.Name = "OKbtn" Then
                        ctrl.BackgroundImage = Image.FromFile(PngFromFile("ButtonSet"))
                        ctrl.Font = New Font(LFont, 16)
                        ctrl.ForeColor = Color.White
                    ElseIf ctrl.Name = "NameTBox" Then
                        ctrl.Font = New Font(LFont, 40)
                        ctrl.ForeColor = Color.FromArgb(0, 180, 0)
                    Else
                        ctrl.Font = New Font(LFont, 22)
                        ctrl.ForeColor = Color.FromArgb(0, 50, 100)
                    End If
                Next
            End If

            If TypeOf ictrl Is Button Then
                If ictrl.Name = "SetBtn" Then
                    ictrl.Font = New Font(LFont, 20)
                    ictrl.ForeColor = Color.FromArgb(0, 50, 100)
                End If
            End If
        Next

        NameLay.Visible = False
        TitleLay.Visible = False
        BackTimer.Start()
        StoryTimer.Start()
        StoryCounter = 0
        OpBtn.Visible = False
        OpBtn.BackgroundImage = Image.FromFile(PngFromFile("ButtonStart"))
        OpBtn.ForeColor = Color.White
        OpBtn.Font = New Font(Lfont, 16)

        'LenkaRunPct.Image = ResizeImage(Image.FromFile(PngFromFile("LenkaRun1")), 40)

        Select Case Level
            Case 1
                LenkaRunPct.Width = 190
                LenkaRunPct.Height = 180
                LenkaRunPct.Location = New Drawing.Point(340, 420)
            Case 2
                LenkaRunPct.Width = 170
                LenkaRunPct.Height = 200
                LenkaRunPct.Location = New Drawing.Point(330, 375)
            Case 3
                LenkaRunPct.Width = 380
                LenkaRunPct.Height = 230
                LenkaRunPct.Location = New Drawing.Point(210, 340)
        End Select

        ExLay.Visible = False


    End Sub

    Private Sub BackTimer_Tick(sender As Object, e As EventArgs) Handles BackTimer.Tick
        Dim CloudStep As SByte = -10
        Dim Rnd As New Random
        Dim Rnd2 As New Random

        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is PictureBox Then
                If Strings.Left(ctrl.Name, 5) = "Cloud" Then
                    If ctrl.Location.X < -140 Then
                        Dim ctrlNo As Byte = CByte(Strings.Left(Strings.Right(ctrl.Name, 4), 1))
                        Dim ctrlPrev As Byte = Nothing
                        If ctrlNo = 1 Then
                            ctrlPrev = 4
                        Else
                            ctrlPrev = ctrlNo - 1
                        End If

                        Dim ctrl2 As PictureBox = CType(Me.Controls("Cloud" & ctrlPrev & "Pct"), PictureBox)

                        ctrl.Location = New Drawing.Point(800 + (Rnd.Next(0, 150)), ctrl.Location.Y + Rnd2.Next(-10, 10))
                        'Dodatkowe przesuniecie w przypadku kiedy poprzednia i nastepna chumra nachodza na siebie
                        If ctrl.Location.X < ctrl2.Location.X + ctrl.Width Then
                            ctrl.Location = New Drawing.Point(ctrl2.Location.X + ctrl.Width + 50, ctrl.Location.Y)
                        End If
                    Else
                        ctrl.Location = New Drawing.Point(ctrl.Location.X + CloudStep, ctrl.Location.Y)
                    End If
                End If
            End If
        Next

        LenkaRunInd += 1

        Select Case Level
            Case 1 'Running
                If LenkaRunInd > 8 Then
                    LenkaRunInd = 1
                End If
                LenkaRunPct.Image = ResizeImage(Image.FromFile(PngFromFile("LenkaRun" & LenkaRunInd)), 40)
                LenkaRunPct.Location = New Drawing.Point(LenkaRunPct.Location.X + IncX, LenkaRunPct.Location.Y)
            Case 2 'Bike
                If LenkaRunInd > 2 Then
                    LenkaRunInd = 1
                End If
                LenkaRunPct.Image = ResizeImage(Image.FromFile(PngFromFile("Bike" & LenkaRunInd)), 100)
                LenkaRunPct.Location = New Drawing.Point(LenkaRunPct.Location.X + IncX, LenkaRunPct.Location.Y)
            Case 3 'Bus
                If LenkaRunInd > 2 Then
                    LenkaRunInd = 1
                End If
                LenkaRunPct.Image = ResizeImage(Image.FromFile(PngFromFile("Bus" & LenkaRunInd)), 100)
                LenkaRunPct.Location = New Drawing.Point(LenkaRunPct.Location.X + IncX, LenkaRunPct.Location.Y)
        End Select

        If BackTimer.Interval + IncT < 10 Then
            BackTimer.Interval = 10
        ElseIf BackTimer.Interval + IncT > 2000 Then
            BackTimer.Interval = 2000
        Else
            BackTimer.Interval += IncT
        End If
    End Sub

    Private Sub SetBtn_Click(sender As Object, e As EventArgs) Handles SetBtn.Click
        MenuForm.ShowDialog()
    End Sub

    Private Sub NameTBox_KeyDown(sender As Object, e As KeyEventArgs) Handles NameTBox.KeyDown
        If NameTBox.TextLength >= 10 And e.KeyCode <> Keys.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub NameTBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NameTBox.KeyPress
        If e.KeyChar = "/" Or e.KeyChar = "\" Then
            e.Handled = True
        End If
    End Sub

    Private Sub NameTBox_TextChanged(sender As Object, e As EventArgs) Handles NameTBox.TextChanged
        If NameTBox.TextLength > 0 Then OKbtn.Visible = True Else OKbtn.Visible = False
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
                TitleLbl.Text = ""
            Case 2
                TxtInd = 1
                TxtStr = TxtFromFile(Lang, "Ending", 2)
                TitleTimer.Start()
                TitleLay.Visible = True
                TextLbl.Visible = False
            Case 4
                TextLbl.Text = ""
            Case 5
                TxtInd = 2
                TxtStr = TxtFromFile(Lang, "Ending", 3)
                TitleTimer.Start()
                TextLbl.Visible = True
            Case 12
                TextLbl.Text = TextLbl.Text & " " & Score & "."
            Case 14
                Dim MinScore As Integer = ScoreDecode(TxtFromFile("none", "Scores", 5), False) 'From list
                If Score > MinScore Then
                    ScoreToHigh = True
                Else
                    ScoreToHigh = False
                End If
            Case 17
                If ScoreToHigh = False Then
                    TxtStr = TxtFromFile(Lang, "Ending", 4) & " [" & Score & "]"
                Else
                    TxtStr = TxtFromFile(Lang, "Ending", 5)
                End If
                TxtInd = 2
                TitleTimer.Start()
            Case 30
                If ScoreToHigh = False Then
                    OpBtn.Text = TxtFromFile(Lang, "Ending", 1)
                    OpBtn.Visible = True
                Else
                    TxtInd = 1
                    TxtStr = TxtFromFile(Lang, "Ending", 6)
                    TitleTimer.Start()
                    TextLbl.Visible = False
                    'NameLay.Visible = True
                    'NameTBox.Visible = True
                    'NameTBox.Text = "dupa"
                    'OKbtn.Visible = True
                End If
            Case 32
                If ScoreToHigh = True Then
                    NameLay.Visible = True
                    NameTBox.Visible = True
                    OKbtn.Visible = False
                    NameTBox.Select()
                End If
                StoryTimer.Stop()
        End Select
    End Sub

    Private Sub TitleTimer_Tick(sender As Object, e As EventArgs) Handles TitleTimer.Tick
        TxtCnt += 1
        Select Case TxtInd
            Case 1
                TitleLbl.Text = Strings.Left(TxtStr, TxtCnt)
            Case 2
                TextLbl.Text = Strings.Left(TxtStr, TxtCnt)
        End Select
        If TxtCnt >= TxtStr.Length Then
            TxtCnt = 0
            TitleTimer.Stop()
        End If
    End Sub

    Private Sub OKbtn_Click(sender As Object, e As EventArgs) Handles OKbtn.Click
        OpBtn.Text = TxtFromFile(Lang, "Ending", 1)
        OpBtn.Visible = True
        TitleLay.Visible = False

        Dim Name(5) As String
        Dim Val(5) As Integer

        Name(0) = NameTBox.Text
        Val(0) = Score

        For i As Byte = 1 To 5
            Name(i) = ScoreDecode(TxtFromFile("none", "Scores", i), True)
            Val(i) = ScoreDecode(TxtFromFile("none", "Scores", i), False)
        Next

        Dim SName(5) As String
        Dim SVal(5) As Integer
        SName = ScoreListSort(Name, Val, True)
        SVal = ScoreListSort(Name, Val, False)

        ScoreListWrite(SName, SVal, "Scores")

        NameTBox.Visible = False
        OKbtn.Visible = False

        TitleLay.Visible = False
        NameLay.Visible = False
        ExLay.Visible = True
        OpBtn.Visible = True
    End Sub

    Private Sub OpBtn_Click(sender As Object, e As EventArgs) Handles OpBtn.Click
        StopSound()
        TitleForm.Show()
        Me.Close()
    End Sub

    Private Sub Btn_MouseHover(sender As Object, e As EventArgs) Handles Me.MouseHover, OpBtn.MouseHover,
    SetBtn.MouseHover, TitleLay.MouseHover, TitleLbl.MouseHover, TextLbl.MouseHover, NameTBox.MouseHover,
    OKbtn.MouseHover, LenkaRunPct.MouseHover, NameLay.MouseHover
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
        If TypeOf ictrl Is Button Then
            ictrl.ForeColor = Color.Yellow
        End If
    End Sub

    Private Sub EndingForm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        FormNameGlobal = Me.Name
    End Sub

    Private Sub TimerBtn_Click(sender As Object, e As EventArgs) Handles MBtn.Click, PBtn.Click, DBtn.Click
        Dim Def As Integer = 100
        Dim Inc As Byte = 10
        Dim Btn As Button = CType(sender, Button)
        Dim Op As Char = Strings.Left(Btn.Name, 1)

        Select Case Op
            Case "M"
                BackTimer.Interval += Inc
            Case "P"
                If BackTimer.Interval > 20 Then
                    BackTimer.Interval -= Inc
                End If
            Case "D"
                BackTimer.Interval = Def
        End Select
    End Sub

    Private Sub LBtn_Click(sender As Object, e As EventArgs) Handles LBtn.Click, RBtn.Click, CBtn.Click
        Dim btn As Button = CType(sender, Button)
        Dim Op As Char = Strings.Left(btn.Name, 1)
        Dim Inc As Byte = 10
        Dim Mv As Integer = Nothing

        Select Case Op
            Case "L"
                LenkaRunPct.Location = New Drawing.Point(LenkaRunPct.Location.X - Inc, LenkaRunPct.Location.Y)
            Case "R"
                LenkaRunPct.Location = New Drawing.Point(LenkaRunPct.Location.X + Inc, LenkaRunPct.Location.Y)
            Case "C"
                Select Case Level
                    Case 1
                        LenkaRunPct.Location = New Drawing.Point(340, 420)
                    Case 2
                        LenkaRunPct.Location = New Drawing.Point(330, 375)
                    Case 3
                        LenkaRunPct.Location = New Drawing.Point(210, 340)
                End Select
        End Select

        If LenkaRunPct.Location.X < (0 - LenkaRunPct.Width) Then
            LenkaRunPct.Location = New Drawing.Point(0 - LenkaRunPct.Width, LenkaRunPct.Location.Y)
        ElseIf LenkaRunPct.Location.X > (800 + LenkaRunPct.Width) Then
            LenkaRunPct.Location = New Drawing.Point(800 + LenkaRunPct.Width, LenkaRunPct.Location.Y)
        End If
    End Sub
End Class