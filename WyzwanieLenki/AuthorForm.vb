Public Class AuthorForm
#Region "MovingWindow by mouse"
    Private Sub Form_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, TabLay.MouseDown,
            A0.MouseDown, A1.MouseDown, A2.MouseDown, M0.MouseDown, M1.MouseDown, M2.MouseDown, M3.MouseDown, M4.MouseDown,
            M5.MouseDown, M6.MouseDown, M7.MouseDown, M8.MouseDown, M9.MouseDown, M10.MouseDown
        MouseD(Me, e)
    End Sub

    Private Sub Form_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp, TabLay.MouseUp,
            A0.MouseUp, A1.MouseUp, A2.MouseUp, M0.MouseUp, M1.MouseUp, M2.MouseUp, M3.MouseUp, M4.MouseUp,
            M5.MouseUp, M6.MouseUp, M7.MouseUp, M8.MouseUp, M9.MouseUp, M10.MouseUp
        MouseU(Me)
    End Sub

    Private Sub Form_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove, TabLay.MouseMove,
            A0.MouseMove, A1.MouseMove, A2.MouseMove, M0.MouseMove, M1.MouseMove, M2.MouseMove, M3.MouseMove, M4.MouseMove,
            M5.MouseMove, M6.MouseMove, M7.MouseMove, M8.MouseMove, M9.MouseMove, M10.MouseMove
        MouseM(Me)
    End Sub
#End Region
    Private Counter As Integer = Nothing

    Private Sub AuthorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSavePosition(Me, False)
        TitleIcon(Me)
        BackTimer.Start()


        For Each ctrl As Control In TabLay.Controls
            If ctrl.Name = "A0" Or ctrl.Name = "M0" Then
                ctrl.Font = New Font(Lfont, 26)
                ctrl.ForeColor = Color.FromArgb(220, 50, 0)
            ElseIf ctrl.Name = "A1" Then
                ctrl.Font = New Font(Lfont, 30)
                ctrl.ForeColor = Color.FromArgb(0, 50, 100)
            Else
                ctrl.Font = New Font(Lfont, 18)
                ctrl.ForeColor = Color.FromArgb(0, 50, 100)
            End If
        Next

        For i As Byte = 1 To 10
            Dim ctrl As Control = CType(TabLay.Controls("M" & i), Control)
            ctrl.Text = TxtFromFile("none", "Music", i)
        Next

        A0.Text = TxtFromFile(Lang, "Author", 1)
        A1.Text = "Łukasz Kłonica"
        A2.Text = TxtFromFile(Lang, "Author", 2)
        M0.Text = TxtFromFile(Lang, "Author", 3)

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
        TitleForm.Show()
        Me.Close()
    End Sub

End Class