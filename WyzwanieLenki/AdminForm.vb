Public Class AdminForm
#Region "MovingWindow by mouse"
    Private Sub Form_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, AdminLbl.MouseDown, TabLay.MouseDown
        MouseD(Me, e)
    End Sub

    Private Sub Form_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp, AdminLbl.MouseUp, TabLay.MouseUp
        MouseU(Me)
    End Sub

    Private Sub Form_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove, AdminLbl.MouseMove, TabLay.MouseMove
        MouseM(Me)
    End Sub
#End Region

    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSavePosition(Me, False)
        TitleIcon(Me)
        LevelNum.Value = Level
        CheatChBox.Checked = Cheat
        For Each ctrl As Control In TabLay.Controls
            ctrl.Font = New Font(Lfont, 14)
            ctrl.ForeColor = Color.FromArgb(0, 50, 100)
        Next
    End Sub

    Public Sub ShowFormDynamically(frmForm As String)
        Dim obj As Object = Activator.CreateInstance(Type.GetType(“WyzwanieLenki.” + frmForm))
        obj.ShowDialog()
        Me.Close()
    End Sub

    Private Sub LoadScore()
        For Each ctrl As Control In TabLay.Controls
            Dim str As String = Strings.Left(ctrl.Name, 2)
            If TypeOf ctrl Is TextBox Then
                If str = "Na" Then
                    ctrl.Text = ScoreDecode(TxtFromFile("none", "Scores", CByte(Strings.Right(ctrl.Name, 1))), True)
                ElseIf str = "Sc" Then
                    ctrl.Text = ScoreDecode(TxtFromFile("none", "Scores", CByte(Strings.Right(ctrl.Name, 1))), False)
                End If

            ElseIf TypeOf ctrl Is Label Then
                If str = "No" Then
                    ctrl.Text = Strings.Right(ctrl.Name, 1) & "."
                End If
            End If
        Next
    End Sub

    Private Sub LoadBtn_Click(sender As Object, e As EventArgs) Handles LoadBtn.Click
        LoadScore()
    End Sub

    Private Sub CheatChBox_CheckedChanged(sender As Object, e As EventArgs) Handles CheatChBox.CheckedChanged
        Cheat = Not Cheat
    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        TitleForm.Show()
        Me.Close()
    End Sub

    Private Sub Btn_Click(sender As Object, e As EventArgs) Handles OpenBtn.Click
        Dim vForm As String = FormCBox.Text + "Form"
        Try
            ShowFormDynamically(vForm)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Num_ValueChanged(sender As Object, e As EventArgs) Handles FightNum.ValueChanged
        Fight = FightNum.Value
    End Sub

    Private Sub GoBtn_Click(sender As Object, e As EventArgs) Handles GoBtn.Click
        FormCBox.Text = "Fight"
        Btn_Click(sender, e)
    End Sub

    Private Sub LevelNum_ValueChanged(sender As Object, e As EventArgs) Handles LevelNum.ValueChanged
        Level = LevelNum.Value
    End Sub

    Private Sub SortBtn_Click(sender As Object, e As EventArgs) Handles SortBtn.Click
        Dim Name(4) As String
        Dim Val(4) As Integer
        For i As Byte = 0 To 4
            Dim ctrl1 As Control = CType(TabLay.Controls("Name" & i + 1), Control)
            'If Not IsNothing(ctrl1.Text) Then Name(i) = ctrl1.Text Else Name(i) = "empty"
            Name(i) = ctrl1.Text
            'ctrl1.Text <> "" Then Name(i) = ctrl1.Text Else Name(i) = "empty"
            Dim ctrl2 As Control = CType(TabLay.Controls("Score" & i + 1), Control)
            If IsNumeric(ctrl2.Text) Then Val(i) = CInt(ctrl2.Text) Else Val(i) = 0
            'integer.TryParse(ctrl2.Text, Val(i))
        Next

        Dim SName(4) As String
        SName = ScoreListSort(Name, Val, True)
        Dim SVal(4) As Integer
        SVal = ScoreListSort(Name, Val, False)

        For i As Byte = 0 To 4
            Dim ctrl1 As Control = CType(TabLay.Controls("Name" & i + 1), Control)
            Dim ctrl2 As Control = CType(TabLay.Controls("Score" & i + 1), Control)
            ctrl1.Text = SName(i)
            ctrl2.Text = SVal(i)
        Next
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Dim Name(4) As String
        Dim Val(4) As Integer
        For i As Byte = 0 To 4
            Dim ctrl1 As Control = CType(TabLay.Controls("Name" & i + 1), Control)
            If ctrl1.Text <> "" Then Name(i) = ctrl1.Text
            Dim ctrl2 As Control = CType(TabLay.Controls("Score" & i + 1), Control)
            Integer.TryParse(ctrl2.Text, Val(i))
        Next
        ScoreListWrite(Name, Val, "Scores")
    End Sub

    Private Sub ScoreBtn_Click(sender As Object, e As EventArgs) Handles ScoreBtn.Click
        If Not IsNothing(ValScore.Text) Then
            Score = CInt(ValScore.Text)
        End If
        ValScoreLbl.Text = Score
    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        For i As Byte = 0 To 4
            Dim ctrl1 As Control = CType(TabLay.Controls("Name" & i + 1), Control)
            Dim ctrl2 As Control = CType(TabLay.Controls("Score" & i + 1), Control)
            ctrl1.Text = ""
            ctrl2.Text = ""
        Next
    End Sub
End Class