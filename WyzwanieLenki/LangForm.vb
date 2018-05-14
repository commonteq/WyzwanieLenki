Public Class LangForm
#Region "MovingWindow by mouse"
    Private Sub Form_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, LangLay.MouseDown, LangLbl.MouseDown
        MouseD(Me, e)
    End Sub

    Private Sub Form_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp, LangLay.MouseUp, LangLbl.MouseUp
        MouseU(Me)
    End Sub

    Private Sub Form_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove, LangLay.MouseMove, LangLbl.MouseMove
        MouseM(Me)
    End Sub
#End Region

    'Operation during loading form
    Private Sub LangForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.Icon
        Me.Text = "Wyzwanie Lenki"
        FontFromFile("Thickhead_Dark_Mod.ttf")

        'Set for buttons (font, color, text)
        For Each ctrl As Control In Me.Controls 'Set 
            If Strings.Right(ctrl.Name, 3) = "Btn" Then
                If Strings.Left(ctrl.Name, 2) = "PL" Then
                    ctrl.Text = TxtFromFile("none", "Lang", 2)
                Else
                    ctrl.Text = TxtFromFile("none", "Lang", 3)
                End If
                ctrl.BackgroundImage = Image.FromFile(PngFromFile("ButtonStart"))
                ctrl.Font = New Font(Lfont, 20)
                ctrl.ForeColor = Color.White
            End If
        Next

        'Set for label
        For Each ctrl As Control In LangLay.Controls
            ctrl.Text = TxtFromFile("none", "Lang", 1)
            ctrl.Font = New Font(Lfont, 30)
            ctrl.ForeColor = Color.FromArgb(0, 50, 100)
        Next
    End Sub

    'Mark correct button
    Private Sub Btn_MouseHover(sender As Object, e As EventArgs) Handles PLBtn.MouseHover, ENBtn.MouseHover,
        Me.MouseHover, LangLay.MouseHover

        Dim ctrl As Control = CType(sender, Control)
        Dim LLang As String = Strings.Left(ctrl.Name, 2)

        For Each ctrl In Me.Controls
            ctrl.ForeColor = Color.White
        Next

        If LLang = "PL" Then
            PLBtn.ForeColor = Color.Yellow
        ElseIf LLang = "EN" Then
            ENBtn.ForeColor = Color.Yellow
        End If
    End Sub

    'Choose Button (Lang to global variable)
    Private Sub Btn_Click(sender As Object, e As EventArgs) Handles PLBtn.Click, ENBtn.Click
        Dim ctrl As Control = CType(sender, Control)
        Lang = Strings.Left(ctrl.Name, 2)
        LoadSavePosition(Me, True)
        LoadForm.Show()
        System.Threading.Thread.Sleep(50)
        Me.Hide()
    End Sub



End Class