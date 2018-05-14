Imports System.Threading
Public Class FightForm
    Private BackCounter As Byte
    Private StartCounter As Byte
    Private SameInx As Integer

#Region "MovingWindow by mouse"
    Private Sub Form_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, TimeLay.MouseDown,
            TimeLbl.MouseDown, ScoreTab.MouseDown, EquaLay.MouseDown, Value1Lbl.MouseDown, Value2Lbl.MouseDown, SignLbl.MouseDown,
            EqualLbl.MouseDown, CommLay.MouseDown, CommLbl.MouseDown, LenkaPct.MouseDown, RatPct.MouseDown, CagePct.MouseDown,
            KeyPct.MouseDown
        MouseD(Me, e)
    End Sub

    Private Sub Form_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp, TimeLay.MouseUp,
            TimeLbl.MouseUp, ScoreTab.MouseUp, EquaLay.MouseUp, Value1Lbl.MouseUp, Value2Lbl.MouseUp, SignLbl.MouseUp,
            EqualLbl.MouseUp, CommLay.MouseUp, CommLbl.MouseUp, LenkaPct.MouseUp, RatPct.MouseUp, CagePct.MouseUp,
            KeyPct.MouseUp
        MouseU(Me)
    End Sub

    Private Sub Form_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove, TimeLay.MouseMove,
            TimeLbl.MouseMove, ScoreTab.MouseMove, EquaLay.MouseMove, Value1Lbl.MouseMove, Value2Lbl.MouseMove, SignLbl.MouseMove,
            EqualLbl.MouseMove, CommLay.MouseMove, CommLbl.MouseMove, LenkaPct.MouseMove, RatPct.MouseMove, CagePct.MouseMove,
            KeyPct.MouseMove
        MouseM(Me)
    End Sub
#End Region

    'Ustawienia dla elementow formularza
    Private Sub FightForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSavePosition(Me, False)
        TitleIcon(Me)
        If Sound Then PlaySound("BackFight", True)

        Dim FontS As Byte = 24
        Dim FontM As Byte = 40
        Dim FontB As Byte = 50
        For Each iLay As Control In Me.Controls
            If TypeOf iLay Is TableLayoutPanel Then
                Dim Lay As TableLayoutPanel = iLay
                For Each ictrl As Control In Lay.Controls
                    If TypeOf ictrl Is Label Then
                        Dim ctrl As Label = ictrl
                        If ctrl.Name = "TimeLbl" Then
                            ctrl.Font = New Font(LFont, FontS)
                            ctrl.ForeColor = Color.FromArgb(0, 50, 100)
                        ElseIf ctrl.Name = "CommLbl" Then
                            ctrl.Font = New Font(LFont, FontB)
                            ctrl.ForeColor = Color.FromArgb(220, 50, 0)
                        Else
                            ctrl.Font = New Font(LFont, FontM)
                            ctrl.ForeColor = Color.FromArgb(0, 50, 100)
                        End If
                    ElseIf TypeOf ictrl Is Button Then
                        Dim ctrl As Button = ictrl
                        ctrl.Font = New Font(LFont, FontM)
                        ctrl.ForeColor = Color.White
                        ctrl.BackgroundImage = Image.FromFile(PngFromFile("ButtonNumber"))
                    End If
                Next
            End If
        Next

        LenkaPct.Visible = True
        LenkaPct.Image = ResizeImage(Image.FromFile(PngFromFile("Lenka1")), 100)
        RatPct.Visible = True
        RatPct.Image = ResizeImage(Image.FromFile(PngFromFile("Rat1")), 100)
        CagePct.Image = Image.FromFile(PngFromFile("Cage"))
        CagePct.BackgroundImage = ResizeImage(Image.FromFile(PngFromFile("Pet" & Fight)), 70)
        KeyPct.Image = Image.FromFile(PngFromFile("Key"))
        StartBtn.BackgroundImage = Image.FromFile(PngFromFile("ButtonStart"))
        StartBtn.Font = New Font(LFont, 20)
        StartBtn.ForeColor = Color.White
        StartBtn.Visible = False
        SetBtn.ForeColor = Color.FromArgb(0, 50, 100)
        SetBtn.Font = New Font(LFont, 20)
        BackTimer.Start() 'uruchamia timer dla elementow tla
        StartTimer.Start() 'uruchamia timer dla procedury startowej
        'TimeLbl.Text = TxtFromFile(Lang, "Fight", 1)
        If Fight = 1 Then Score = 0 'Resetowania wyniku dla pierwszej walki
    End Sub

    Private Sub TxtLoad()
        TimeLbl.Text = TxtFromFile(Lang, "Fight", 1)
    End Sub

    'Tykania dla elementow tla
    Private Sub BackTimer_Tick(sender As Object, e As EventArgs) Handles BackTimer.Tick
        BackCounter += 1
        If BackCounter > 4 Then BackCounter = 0
        LenkaPct.Location = New Drawing.Point(LenkaPct.Location.X - 2 + BackCounter, LenkaPct.Location.Y)
        RatPct.Location = New Drawing.Point(RatPct.Location.X, RatPct.Location.Y - 2 + BackCounter)
        CagePct.Location = New Drawing.Point(CagePct.Location.X - 2 + BackCounter, CagePct.Location.Y - 2 + BackCounter)
    End Sub

    'Timer dla rozpoczecia pojedynku
    Private Sub StartTimer_Tick(sender As Object, e As EventArgs) Handles StartTimer.Tick
        StartCounter += 1
        StartProcedure(StartCounter) 'Uruchomienia procedury startowej
    End Sub

    'Procedura startowa / odliczanie i dostosowanie elementow
    Private Sub StartProcedure(Counter As Byte)
        Select Case Counter
            Case 1
                CommLay.Visible = True
                CommLbl.Text = "3"
            Case 2 : CommLbl.Text = "2"
            Case 3 : CommLbl.Text = "1"
            Case 4 : CommLbl.Text = TxtFromFile(Lang, "Fight", 3)
            Case 5
                ResetBar(Fight) 'Resetuje progressbar
                TimeTimer.Start() 'Uruchamia timer dla odliczania wlasciwego
                CommLay.Visible = False 'ukrywa elementy komunikatow
                StartTimer.Stop() 'zatrzymuje timer dla procedury startowej
                Equation = 1
                AssignButtons()
        End Select
    End Sub

    'Procedura resetuje/ustawia progressbar dla wartosci poczatkowych
    Private Sub ResetBar(FightNo As Byte)
        Dim Cycle As Byte = Nothing 'Ilosc cykli dla czasu
        Select Case FightNo 'Rozny czas dla roznych walk o zwierzeta (wzrastajacy poziom trudnosci)
            Case 1 : Cycle = 60 '60s
            Case 2 : Cycle = 50
            Case 3 : Cycle = 40
            Case 4 : Cycle = 30
            Case 5 : Cycle = 20 '20s
        End Select
        ScoreTab.Maximum = Cycle 'ustawienie maksymalnej ilosci cykli
        ScoreTab.Step = 1
        ScoreTab.Value = Cycle 'ustawienie poczatkowej wartosci na wypelnony
        TimerRestart(TimeTimer) 'Restartuje timer dla walki glownej
        'TimeTimer.Start() 'uruchamia 
    End Sub

    'Timer dla odliczania wlasciwego / pomniejszajacy sie pasek
    Private Sub TimeTimer_Tick(sender As Object, e As EventArgs) Handles TimeTimer.Tick
        DefaultFace()
        If ScoreTab.Value > 0 Then
            ScoreTab.Value -= 1
        Else 'Kiedy ProgressBar = 0
            GameOver() 'uruchamiana procedura GameOver
        End If
    End Sub

    'Procedura GameOver 
    Private Sub GameOver()
        TimeTimer.Stop() 'Zatrzymuje glowny timer
        ChangeFace(False)
        CommLay.Visible = True 'Pokazuje 
        CommLbl.Text = TxtFromFile(Lang, "Fight", 4)
        StartBtn.Text = TxtFromFile(Lang, "Fight", 5)
        StartBtn.Visible = True
        ResultLay.Visible = False
        EquaLay.Visible = False
    End Sub

    Private Sub AssignButtons()
        EquaLay.Visible = True
        ResultLay.Visible = True

        For Each ctrl As Control In ResultLay.Controls
            ctrl.Visible = True
        Next

        Dim check As Boolean = Nothing 'czy wynik miesci sie w kryteriach tj. nie moze byc ujemny
        Dim vall1 As Byte = Nothing 'pierwsza wartosc
        Dim vall2 As Byte = Nothing 'druga wartosc
        Dim signn As Byte = Nothing 'znak rownania
        Dim res As Integer = Nothing 'wynik rownania

        'Sprawdzanie poprawnosci rownania w zaleznosci od wygenrowanych liczb oraz znaku. Z zal dla dzielenia, ze:
        'dzielnik musi byc mniejszy niz dzielna (automatycznie likwiduje mozliwosc wystapenia ulamkow)
        'Reszta z dzielenia musi byc rozna od 0
        'Wynik dzielenia musi byc liczba calkowita (dodatkowe zabezpieczenie)
        signn = GenerateSign(Level) 'przesione powyzej petli co zapewnia rowny % podzial wystapienia znaku
        Do Until check = True
            vall1 = GenerateVal(Level, 1, signn)
            vall2 = GenerateVal(Level, 2, signn)

            'Zabezpieczneie, aby obie wartosci nie byly takie same zbyt czesto. Regulowany przez SameInx > 10.
            'Zwiekszanie tej wartosci powoduje np. SameInx>10 przy SAmeInx<> 1, generowana nowa wartosc, 
            'co powoduje, ze w 9 przypadkach na 10 liczba druga bedzie generowana jeszcze raz
            If vall1 = vall2 Then
                SameInx += 1
                If SameInx > 10 Then SameInx = 0
            End If

            If SameInx <> 1 Then vall2 = GenerateVal(Level, 2, signn)


            If signn = 4 Then
                If vall2 > vall1 Or (vall1 Mod vall2 <> 0) Or (vall1 / vall2 <> CInt(vall1 / vall2)) Then
                    check = False
                Else
                    res = CalcVal(vall1, vall2, signn)
                    check = CheckResult(Level, vall1, vall2, signn)
                End If
            Else
                res = CalcVal(vall1, vall2, signn)
                check = CheckResult(Level, vall1, vall2, signn)
            End If
        Loop

        'Tablica z wartosciami wygenerowanymi losowa w zaleznosci od Level
        Dim ValTab(4) As Byte
        For i As Byte = 1 To 3
            ValTab(i) = GenerateVal(Level, 1, signn)
        Next
        ValTab(4) = res 'Ostatnia wartosc jest poprawnym wynikiem

        'Petla sorujaca wartosc w tabeli, ktore beda przypisywane do wartosci na przyciskach
        'Dzieki sortowaniu, prawidlowy wynik nie zawsze bedzie w tym samym miejscu
        'Dodatkowo jesli wartosci obok siebie sa rowne, jedna zostanie zastapiona nowa losowa (petla k)
        'Petla j po przez kilkukrotne przejscie calej procedury zmniejsza prawdopodobienstwo wystaienia
        'takich samych wartosci.

        'Odczekanie w petli k pomaga zlikwidowac problem, ze prawidlowy wynik zostaje usuniety. Dzieje sie to 
        'dlatego, ze jesli prawidlowy wynik sie powtarza w losowej wartosc to obydwie zostaja zastapione innymi, 
        'takimi samymi. Odczekani powoduje, ze wygenerowany wartosc roznia sie miedzy soba.

        For j As Byte = 1 To 5
            Array.Sort(ValTab)
            For k As Byte = 2 To 4 '2 zamiast jeden w przypadku kiedy res=0 wtedy gdzie k-1 dla k=1 jest zawsze 0
                If ValTab(k - 1) = ValTab(k) Then
                    System.Threading.Thread.Sleep(10) 'odczekanie niweluje problem ze zadne wynik nie jest poprawny
                    ValTab(k) = GenerateVal(Level, 1, signn)
                End If
            Next
        Next

        'Petla m wpisuje wartosc z tablicy do poszczegolnych przyciskow
        For m As Byte = 1 To 4
            Dim ctrl As Control = CType(ResultLay.Controls("Result" & m & "Btn"), Control)
            ctrl.Text = ValTab(m)
        Next

        If Cheat = True Then
            'Petla zaznaczajaca prawidlowy wynik Cheat :D
            For Each ctrl As Control In ResultLay.Controls
                If ctrl.Text = res Then
                    ctrl.ForeColor = Color.Red
                Else
                    ctrl.ForeColor = Color.White
                End If
            Next
        End If
        'Wpisywanie wygenerowanego rownania do odpowiednich pol
        Value1Lbl.Text = vall1
        Value2Lbl.Text = vall2
        SignLbl.Text = ConvertSignToChar(signn)
        EqualLbl.Text = "="
    End Sub

    Private Sub StartBtn_Click(sender As Object, e As EventArgs) Handles StartBtn.Click
        LoadSavePosition(Me, True)
        StopSound()
        Me.Close()
        TitleForm.Show()
    End Sub

    Private Sub Result1Btn_Click(sender As Object, e As EventArgs) Handles Result1Btn.Click, Result2Btn.Click,
            Result3Btn.Click, Result4Btn.Click
        Dim Btn As Button = CType(sender, Button)
        Dim Res = CalcVal(CInt(Value1Lbl.Text), CInt(Value2Lbl.Text), ConvertCharToSing(SignLbl.Text))
        Dim Inc As Byte = 20

        'Przy kliknieciu w wynik. Jesli jest prawidlowy dodaje numer rownania +=1, w przypadku kiedy 
        'jest to 20 rownanie przechodzi do nastepnej walki. Jesli wybrana wartosc nie rowna wynikowi
        'to czas zostaje skrocony o Inc (pasek postepu)
        If CInt(Btn.Text) = Res Then
            If Equation >= 20 Then 'Nastepna walka
                NextFight()
            Else
                Equation += 1 'Numer rownania zostaje zwiekszony
                Score += Scoring(ScoreTab.Maximum, ScoreTab.Value, Level)
                ResetBar(Level) 'Restart czasu
                KeyPosition(Equation) 'Przesuwa klucz w zaleznosci od rownania
                AssignButtons() 'Procedura przypisania nowych wartosci do przyciskow
                ChangeFace(True) 'Zmienia twarz postacia na +1 dla lenki
            End If
        Else
            If ScoreTab.Value - Inc < 0 Then 'Zabezpieczenie przed ujemna wartoscia dla progressbar
                ScoreTab.Value = 0
            Else
                ScoreTab.Value -= Inc 'pomniejsza czas w przypadku zlej odpowiedzi
                Btn.Visible = False 'ukrywa wybrany przycisk ze zla wartoscia
                ChangeFace(False) 'zmienia twarz postaciom na -1 dla Lenki
            End If
        End If
    End Sub

    'Uruchamia nastepna walke, ale najpierw formularz odzysku zwierzecia
    Private Sub NextFight()
        LoadSavePosition(Me, True)
        StopSound()
        RetrieveForm.Show()
        TimeTimer.Stop()
        Me.Close()
    End Sub

    'Procedura przesuwa klucz z pierwotnej pozycji do klatki. Pozycja klucza jest zdefiniowna przez
    'numer rownania. Klucz przesuwa sie tylko w przypadku dobrej odpowiedzi. W przypadku zlej jest gameover.
    Private Sub KeyPosition(Equation)
        Dim PosMax As Integer = 500
        Dim PosMin As Integer = 360
        Dim diff As Integer = CInt((PosMax - PosMin) / 20)
        KeyPct.Location = New Drawing.Point(PosMax - Equation * diff, KeyPct.Location.Y)
    End Sub

    'Procedura zmienia twarz postacia w zaleznosci czy odpowiedz byla prawidlowa czy nie
    Private Sub ChangeFace(AnswerGood As Boolean)
        Dim RatRnd As New Random
        Dim RatNo As Byte = Nothing
        Dim LenkaRnd As New Random
        Dim LenkaNo As Byte = Nothing

        If AnswerGood = True Then
            RatNo = RatRnd.Next(6, 9) 'Smutny szczur
            LenkaNo = LenkaRnd.Next(1, 5) 'Wesola Lenka
        Else
            RatNo = RatRnd.Next(2, 6) 'Wesoly szczur
            LenkaNo = LenkaRnd.Next(6, 10) 'Smutna Lenka
        End If
        LenkaPct.Image = Image.FromFile(PngFromFile("Lenka" & LenkaNo))
        RatPct.Image = Image.FromFile(PngFromFile("Rat" & RatNo))
    End Sub

    'Domysle twarze postaci = neturalne
    Private Sub DefaultFace()
        LenkaPct.Image = Image.FromFile(PngFromFile("Lenka4"))
        RatPct.Image = Image.FromFile(PngFromFile("Rat1"))
    End Sub

    Private Sub SetBtn_Click(sender As Object, e As EventArgs) Handles SetBtn.Click
        MenuForm.ShowDialog()
    End Sub

    Private Sub FightForm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        TxtLoad()
        FormNameGlobal = Me.Name
    End Sub

    Private Sub SetBtn_MouseHover(sender As Object, e As EventArgs) Handles SetBtn.MouseHover, StartBtn.MouseHover,
            Result1Btn.MouseHover, Result2Btn.MouseHover, Result3Btn.MouseHover, Result4Btn.MouseHover, Me.MouseHover,
            Value1Lbl.MouseHover, Value2Lbl.MouseHover, SignLbl.MouseHover, EqualLbl.MouseHover, CommLbl.MouseHover,
            CagePct.MouseHover, KeyPct.MouseHover, LenkaPct.MouseHover, RatPct.MouseHover, TimeLbl.MouseHover

        Dim ictrl As Control = CType(sender, Control)

        For Each ctrl As Button In ResultLay.Controls
            ctrl.ForeColor = Color.White
        Next

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
End Class