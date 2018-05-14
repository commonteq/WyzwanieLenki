Public Class ScoreForm
    Private Counter As Byte = Nothing
#Region "MovingWindow by mouse"
    Private Sub Form_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, ScoreLay.MouseDown,
            No1.MouseDown, No2.MouseDown, No3.MouseDown, No4.MouseDown, No5.MouseDown, TitleLbl.MouseDown,
            Name1.MouseDown, Name2.MouseDown, Name3.MouseDown, Name4.MouseDown, Name5.MouseDown,
            Score1.MouseDown, Score2.MouseDown, Score3.MouseDown, Score4.MouseDown, Score5.MouseDown
        MouseD(Me, e)
    End Sub

    Private Sub Form_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp, ScoreLay.MouseUp,
            No1.MouseUp, No2.MouseUp, No3.MouseUp, No4.MouseUp, No5.MouseUp, TitleLbl.MouseUp,
            Name1.MouseUp, Name2.MouseUp, Name3.MouseUp, Name4.MouseUp, Name5.MouseUp,
            Score1.MouseUp, Score2.MouseUp, Score3.MouseUp, Score4.MouseUp, Score5.MouseUp
        MouseU(Me)
    End Sub

    Private Sub Form_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove, ScoreLay.MouseMove,
            No1.MouseMove, No2.MouseMove, No3.MouseMove, No4.MouseMove, No5.MouseMove, TitleLbl.MouseMove,
            Name1.MouseMove, Name2.MouseMove, Name3.MouseMove, Name4.MouseMove, Name5.MouseMove,
            Score1.MouseMove, Score2.MouseMove, Score3.MouseMove, Score4.MouseMove, Score5.MouseMove
        MouseM(Me)
    End Sub
#End Region


    Private Sub ScoreForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSavePosition(Me, False)
        TitleIcon(Me)

        For Each ctrl As Label In ScoreLay.Controls
            ctrl.Font = New Font(Lfont, 28)
            If ctrl.Name = "TitleLbl" Then
                ctrl.ForeColor = Color.FromArgb(220, 50, 0)
                ctrl.Text = TxtFromFile(Lang, "Title", 4)
            Else

                ctrl.ForeColor = Color.FromArgb(0, 50, 100)
            End If
        Next
        LoadScore()
        BackTimer.Start()
    End Sub


    Private Sub LoadScore()
        For Each ctrl As Label In ScoreLay.Controls
            Dim str As String = Strings.Left(ctrl.Name, 2)
            If str = "No" Then
                ctrl.Text = Strings.Right(ctrl.Name, 1) & "."
            ElseIf str = "Na" Then
                ctrl.Text = ScoreDecode(TxtFromFile("none", "Scores", CByte(Strings.Right(ctrl.Name, 1))), True)
            ElseIf str = "Sc" Then
                ctrl.Text = ScoreDecode(TxtFromFile("none", "Scores", CByte(Strings.Right(ctrl.Name, 1))), False)
            End If
        Next
    End Sub

    Private Sub BackTimer_Tick(sender As Object, e As EventArgs) Handles BackTimer.Tick
        Counter += 1
        If Counter >= 5 Then
            NextForm()
        End If
    End Sub

    Private Sub NextForm()
        LoadSavePosition(Me, True)
        BackTimer.Stop()
        AuthorForm.Show()
        Me.Close()
    End Sub


End Class