Public Class LevelForm

#Region "MovingWindow by mouse"
    Private Sub Form_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, DesTBox.MouseDown
        MouseD(Me, e)
    End Sub

    Private Sub Form_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp, DesTBox.MouseUp
        MouseU(Me)
    End Sub

    Private Sub Form_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove, DesTBox.MouseMove
        MouseM(Me)
    End Sub
#End Region

    Private Sub LevelForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSavePosition(Me, False)
        TitleIcon(Me)
        For Each ctrl As Control In Me.Controls
            ctrl.Font = New Font(LFont, 20)
            ctrl.ForeColor = Color.White

            If ctrl.Name <> "SetBtn" Then
                ctrl.BackgroundImage = Image.FromFile(PngFromFile("ButtonStart"))
            End If
        Next

        SetBtn.ForeColor = Color.FromArgb(0, 50, 100)
        DesTBox.Font = New Font(LFont, 18)
        DesTBox.ForeColor = Color.FromArgb(0, 50, 100)
        CType(Me.Controls("Level1Btn"), Button).PerformClick()
    End Sub

    Private Sub LevelBtn_Click(sender As Object, e As EventArgs) Handles Level1Btn.Click, Level2Btn.Click, Level3Btn.Click
        Dim ctrl As Control = CType(sender, Control)
        Dim LevelNo As Byte = CByte(Strings.Right(Strings.Left(ctrl.Name, 6), 1))
        Level = LevelNo

        For Each ictrl As Control In Me.Controls
            If TypeOf ictrl Is Button And ictrl.Name <> "SetBtn" Then
                ictrl.ForeColor = Color.White
            End If
        Next

        ctrl.ForeColor = Color.Yellow
        DesTBox.Text = TxtFromFile(Lang, "LevelDescription", LevelNo)
    End Sub

    Private Sub Btn_MouseHover(sender As Object, e As EventArgs) Handles StartBtn.MouseHover, SetBtn.MouseHover,
            DesTBox.MouseHover, Level1Btn.MouseHover, Level2Btn.MouseHover, Level3Btn.MouseHover, Me.MouseHover
        Dim ctrl As Control = CType(sender, Control)
        If ctrl.Name = "StartBtn" Or ctrl.Name = "SetBtn" Then
            ctrl.ForeColor = Color.Yellow
        Else
            StartBtn.ForeColor = Color.White
            SetBtn.ForeColor = Color.FromArgb(0, 50, 100)
        End If
    End Sub

    Private Sub StartBtn_Click(sender As Object, e As EventArgs) Handles StartBtn.Click
        StopSound()
        Score = 0
        LoadSavePosition(Me, True)

        IntroForm.Show()

        'RunForm.Show()
        'DeployForm.Show()
        'RivalsForm.Show()
        'BattleForm.Show()
        'RetrieveForm.Show()
        'OutroForm.Show()
        'EndingForm.Show()
        'LangForm.Show()
        'Form1.Show()
        'MenuForm.ShowDialog()
        'ScoreForm.Show()
        'AuthorForm.Show()
        Me.Close()
    End Sub

    Private Sub SetBtn_Click(sender As Object, e As EventArgs) Handles SetBtn.Click
        MenuForm.ShowDialog()
    End Sub

    Private Sub TxtLoad()
        For Each ctrl As Control In Me.Controls
            If Strings.Left(ctrl.Name, 5) = "Level" Then
                Dim No As Byte = Strings.Right(Strings.Left(ctrl.Name, 6), 1)
                ctrl.Text = TxtFromFile(Lang, "Level", No)
            End If
        Next
        StartBtn.Text = TxtFromFile(Lang, "Level", 4)
        DesTBox.Text = TxtFromFile(Lang, "LevelDescription", Level)
    End Sub

    Private Sub LevelForm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        TxtLoad()
        FormNameGlobal = Me.Name
    End Sub
End Class