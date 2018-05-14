Public Class MenuForm



    Private Sub MenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSavePosition(Me, False)
        TitleIcon(Me)

        Me.Location = New Drawing.Point(Me.Location.X + 400 - Me.Width / 2, Me.Location.Y)

        For Each ctrl As Control In TabLay.Controls
            If TypeOf ctrl Is Button Then
                If ctrl.Name = "ExitBtn" Then
                    ctrl.ForeColor = Color.FromArgb(220, 50, 0)
                ElseIf ctrl.Name = "RetrnBtn" Then
                    ctrl.ForeColor = Color.FromArgb(0, 180, 0)
                ElseIf ctrl.Name = "BeginBtn" Then
                    ctrl.ForeColor = Color.FromArgb(220, 220, 120)
                Else
                    ctrl.ForeColor = Color.White
                End If
                ctrl.Font = New Font(LFont, 14)
                ctrl.BackgroundImage = Image.FromFile(PngFromFile("ButtonStart"))
            Else
                ctrl.Font = New Font(LFont, 30)
                ctrl.ForeColor = Color.FromArgb(0, 50, 100)
            End If

        Next
        PauseLbl.Text = TxtFromFile(Lang, "Menu", 1)
        RetrnBtn.Text = TxtFromFile(Lang, "Menu", 2)
        SoundBtn.Text = TxtFromFile(Lang, "Menu", 3) & " " & SoundStr(Sound)
        LangBtn.Text = TxtFromFile(Lang, "Menu", 4) & " " & Lang
        BeginBtn.Text = TxtFromFile(Lang, "Menu", 5)
        ExitBtn.Text = TxtFromFile(Lang, "Menu", 6)
    End Sub

    Private Function SoundStr(Snd As Boolean) As String
        Dim Str As String
        If Snd Then
            Str = "ON"
        Else
            Str = "OFF"
        End If
        Return Str
    End Function

    Private Sub ReturnBtn_MouseHover(sender As Object, e As EventArgs) Handles RetrnBtn.MouseHover, ExitBtn.MouseHover,
        BeginBtn.MouseHover, SoundBtn.MouseHover, LangBtn.MouseHover, TabLay.MouseHover
        Dim ctrl As Control = CType(sender, Control)
        For Each ictrl As Control In TabLay.Controls
            If TypeOf ictrl Is Button Then
                If ictrl.Name = "ExitBtn" Then
                    ictrl.ForeColor = Color.FromArgb(220, 50, 0)
                ElseIf ictrl.Name = "RetrnBtn" Then
                    ictrl.ForeColor = Color.FromArgb(0, 180, 0)
                ElseIf ictrl.Name = "BeginBtn" Then
                    ictrl.ForeColor = Color.FromArgb(220, 220, 120)
                Else
                    ictrl.ForeColor = Color.White
                End If
            End If
        Next
        ctrl.ForeColor = Color.Yellow
    End Sub

    Private Sub ReturnBtn_Click(sender As Object, e As EventArgs) Handles RetrnBtn.Click, ExitBtn.Click, BeginBtn.Click,
        SoundBtn.Click, LangBtn.Click
        Dim ctrl As Control = CType(sender, Control)
        Select Case ctrl.Name
            Case "RetrnBtn"
                Me.Close()
            Case "ExitBtn"
                Me.Close()
                LangForm.Close()
            Case "BeginBtn"
                For i As SByte = Application.OpenForms.Count To 1 Step -1
                    Dim fm As Form = Application.OpenForms(i - 1)
                    If fm.Name = "LangForm" Or fm.Name = "TitleForm" Then
                        fm.Hide()
                    Else
                        fm.Close()
                    End If
                Next
                TitleForm.Show()
                TitleForm.BringToFront()
            Case "SoundBtn"
                Sound = Not Sound
                If Sound = True Then
                    Dim FName As String = Strings.Replace(FormNameGlobal, "Form", "")
                    PlaySoundBack(FName, StoryTimeGlobal)
                Else
                    StopSound()
                End If




            Case "LangBtn"
                If Lang = "PL" Then
                    Lang = "EN"
                ElseIf Lang = "EN" Then
                    Lang = "PL"
                End If
        End Select
        MenuForm_Load(Nothing, Nothing)
    End Sub
End Class