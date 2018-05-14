Imports System.IO
Imports System.Drawing.Text

Module Functions
    Public Level As Byte = Nothing 'Difficulty level
    Public LfontColl As PrivateFontCollection = Nothing ' = New PrivateFontCollection 'Font from file
    Public Lfont As FontFamily = Nothing 'FontFamily
    Public Fight As Byte = Nothing 'Number of fight
    Public Equation As Byte = Nothing 'Number of equation
    Public Cheat As Boolean = False 'Activated or Deactivated Cheat
    Public Score As Integer = Nothing 'Final Score
    Public Lang As String = Nothing 'Choosen language
    Public MouseX As Integer
    Public MouseY As Integer
    Public Drag As Boolean
    Public ErrorState As Boolean = Nothing
    Public Sound As Boolean = True
    Public StoryTimeGlobal As Integer
    Public FormNameGlobal As String

    'Save/Load global position of form
    Public Sub LoadSavePosition(MeForm As Form, Save As Boolean)
        MeForm.StartPosition = FormStartPosition.Manual 'Set form position
        Dim X As Integer = Nothing 'helpful variables
        Dim Y As Integer = Nothing

        If Save = True Then 'save location of form to global settings
            CallByName(My.Settings, "SetPosX", CallType.Set, MeForm.Location.X)
            CallByName(My.Settings, "SetPosY", CallType.Set, MeForm.Location.Y)
        Else 'load location of form from global settings
            X = CallByName(My.Settings, "SetPosX", CallType.Get)
            Y = CallByName(My.Settings, "SetPosy", CallType.Get)
            MeForm.Location = New Drawing.Point(X, Y) 'Set location of form
        End If
    End Sub

    'MouseDown
    Public Sub MouseD(Meform As Form, e As MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Left Then 'Only for left mouse button
            Drag = True
            MouseX = Windows.Forms.Cursor.Position.X - Meform.Left
            MouseY = Windows.Forms.Cursor.Position.Y - Meform.Top
        End If
    End Sub

    'MouseMove
    Public Sub MouseM(MeForm As Form)
        If Drag = True Then
            MeForm.Top = Windows.Forms.Cursor.Position.Y - MouseY
            MeForm.Left = Windows.Forms.Cursor.Position.X - MouseX
        End If
    End Sub

    'MouseUp
    Public Sub MouseU(MeForm As Form)
        LoadSavePosition(MeForm, True)
        Drag = False
    End Sub

    Public Sub TitleIcon(MeForm As Form)
        MeForm.Icon = My.Resources.Icon
        MeForm.Text = TxtFromFile(Lang, "Title", 1)
    End Sub

    'Path to folder with images
    Public Function PngFromFile(Name As String) As String
        Dim str As String = AppDomain.CurrentDomain.BaseDirectory & "data\img\" & Name & ".png"
        Return str
    End Function

    Public Function IcoFromFile(Name As String) As String
        Dim str As String = AppDomain.CurrentDomain.BaseDirectory & "data\img\" & Name & ".ico"
        Return str

    End Function

    'Path to text file and specific line
    Public Function TxtFromFile(Language As String, Filename As String, Line As Byte) As String
        'Lfont.AddFontFile(AppDomain.CurrentDomain.BaseDirectory & "data\fonts\Thickhead_Dark_Mod.ttf")
        Dim str As String

        If Language = "none" Then
            str = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory & "data\txt\" & Filename & ".txt").ElementAt(Line).ToString
        Else
            str = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory & "data\txt\" & Language & "\" & Filename & ".txt").ElementAt(Line).ToString
        End If
        Return str
    End Function

    'Resize Image
    Public Function ResizeImage(ByVal InputImage As Image, Percent As Byte) As Image
        Dim NewWidth As Integer = Math.Round(InputImage.Size.Width * Percent / 100, 0)
        Dim NewHeight As Integer = Math.Round(InputImage.Size.Height * Percent / 100, 0)
        Return New Bitmap(InputImage, New Size(NewWidth, NewHeight))
    End Function

    'Restart timer
    Public Sub TimerRestart(Timer As Timer)
        Timer.Stop()
        Timer.Start()
    End Sub

    'Time in second from timer values
    Public Function TimerValueToTime(TimerInterval As UInteger, TimerValue As UInteger) As Single
        Dim factor As Single = 1000 / TimerInterval
        Return TimerValue / factor
    End Function

    'Revers of TimerValueToTime
    Public Function TimeToTimerValue(TimerInterval As UInteger, TimeInSeconds As Single) As UInteger
        Dim factor As UInteger = 1000 / TimerInterval
        Return factor * TimeInSeconds
    End Function

    'Generate random values (depends of Difficulty level)
    Public Function GenerateVal(Level As Byte, ValNo As Byte, sign As Byte) As Integer
        System.Threading.Thread.Sleep(10)
        Dim RndVal As New Random
        Dim Val As Byte = Nothing

        Select Case Level
            Case 1 '+ - to  10
                Val = RndVal.Next(0, 11) '0-10
            Case 2 '+ - * / to 20
                Select Case sign
                    Case 1, 2 'All for + & - 
                        Val = RndVal.Next(0, 21) '0-20
                    Case 3
                        If ValNo = 1 Then 'for first
                            Val = RndVal.Next(0, 11) '0-10
                        Else 'for second 0-2
                            Val = RndVal.Next(0, 3) '0-2
                        End If
                    Case 4
                        If ValNo = 1 Then 'For first
                            Val = RndVal.Next(1, 21) '1-20
                        Else
                            Val = RndVal.Next(1, 11) '1-10
                        End If
                End Select
            Case 3 '+ - * / to 100
                Select Case sign
                    Case 1, 2 'All + -
                        Val = RndVal.Next(0, 101) '0-100
                    Case 3 '*
                        Val = RndVal.Next(0, 11) '0-10
                    Case 4 '/
                        If ValNo = 1 Then 'for first
                            Val = RndVal.Next(1, 101) '1-100
                        Else 'for second
                            Val = RndVal.Next(1, 11) '1-10
                        End If
                End Select
        End Select
        Return Val
    End Function

    'Function generate sign depends on difficulty level, where:
    '1 -, 2 +, 3 *, 4 / 
    Public Function GenerateSign(Level As Byte) As Byte
        System.Threading.Thread.Sleep(10)
        Dim RndVal As New Random
        Dim Val As Byte = Nothing
        Select Case Level
            Case 1
                Val = RndVal.Next(1, 3)
            Case 2
                Val = RndVal.Next(1, 5)
            Case 3
                Val = RndVal.Next(1, 5)
        End Select
        Return Val
    End Function

    'Convert from Value to Sign 
    Public Function ConvertSignToChar(Sing As Byte) As Char
        Dim sign As Char = Nothing
        Select Case Sing
            Case 1
                sign = "+"
            Case 2
                sign = "-"
            Case 3
                sign = "*"
            Case 4
                sign = "/"
        End Select
        Return sign
    End Function

    'Convert from Sign to Value
    Public Function ConvertCharToSing(Sing As Char) As Byte
        Dim sign As Byte = Nothing
        Select Case Sing
            Case "+"
                sign = 1
            Case "-"
                sign = 2
            Case "*"
                sign = 3
            Case "/"
                sign = 4
        End Select
        Return sign
    End Function

    'Calculation equation
    Public Function CalcVal(val1 As Integer, val2 As Integer, sign As Byte) As Double
        Dim Res As Integer = Nothing
        Select Case sign
            Case 1
                Res = val1 + val2
            Case 2
                Res = val1 - val2
            Case 3
                Res = val1 * val2
            Case 4
                Res = val1 / val2
        End Select
        Return Res
    End Function

    'Funkcja sprawdza wynik w zaleznosci od Levelu oraz znaku oraz zwraca True/false, gdzie
    'wartosc rownania nie moze byc wieksza niz zalozona dla konkretnego poziomu
    'nie moze byc mniejsza od zera i wynik rownania musi byc liczba calkowita
    Public Function CheckResult(level As Byte, val1 As Integer, val2 As Integer, sign As Byte) As Boolean
        Dim Check As Boolean = Nothing
        Dim MaxRes As Integer = Nothing

        Select Case level
            Case 1
                MaxRes = 10
            Case 2
                MaxRes = 20
            Case 3
                MaxRes = 100
        End Select

        If CalcVal(val1, val2, sign) > MaxRes Or CalcVal(val1, val2, sign) < 0 Or CalcVal(val1, val2, sign) <> CInt(CalcVal(val1, val2, sign)) Then
            Check = False
        Else
            Check = True
        End If
        Return Check
    End Function

    Public Function ScoreEncode(Name As String, Value As String) As String
        Dim str As String = Name & "/" & Value
        Dim bytes() As Byte = System.Text.Encoding.UTF8.GetBytes(str)
        ScoreEncode = Convert.ToBase64String(bytes)
    End Function

    Public Function ScoreDecode(CodedStr As String, GetName As Boolean) As String
        Dim Pos As Byte
        Dim Name As String = Nothing
        Dim Value As String = Nothing

        Try
            Dim bytes() As Byte = Convert.FromBase64String(CodedStr)
            'Marcin/1321
            Dim Str As String = System.Text.Encoding.UTF8.GetString(bytes)
            Dim Ch As Char = "/"
            Pos = Str.IndexOf(Ch)
            Name = Str.Substring(0, Pos)
            Value = Str.Substring((Pos + 1), (Str.Length - (Pos + 1)))
        Catch ex As Exception
            ScoreDecode = "Error"
        End Try

        If GetName = True Then
            ScoreDecode = Name
        Else
            ScoreDecode = Value
        End If
    End Function

    Public Function Scoring(TimeMax As Integer, TimeValue As Integer, Lvl As Byte) As Integer
        Return Math.Round((TimeValue * 100 / TimeMax), 2) * Lvl * 100
    End Function

    Public Function ScoreListSort(Name() As String, Value() As Integer, GetName As Boolean) As Array
        Dim Dtable As New Data.DataTable
        Dim NewName(Name.Length - 1) As String
        Dim NewValue(Name.Length - 1) As Integer
        Dtable.Columns.Add("Name")
        Dtable.Columns.Add("Value", GetType(Integer))

        For i As Byte = 0 To Name.Length - 1
            Dtable.Rows.Add(Name(i), Value(i))
        Next

        Dim DView As DataView = Dtable.DefaultView
        'DView.Sort = "Value ASC"
        DView.Sort = "Value Desc"

        For i As Byte = 0 To Name.Length - 1
            NewName(i) = DView(i)(0)
            NewValue(i) = DView(i)(1)
        Next

        If GetName = True Then
            Return NewName
        Else
            Return NewValue
        End If
    End Function

    Public Sub ScoreListWrite(Name() As String, Value() As Integer, Filename As String)
        Dim pth As String = AppDomain.CurrentDomain.BaseDirectory & "data\txt\" & Filename & ".txt"
        Dim lines(5) As String

        lines(0) = "[Scores]"
        For i As Byte = 1 To 5
            lines(i) = ScoreEncode(Name(i - 1), Value(i - 1))
        Next
        'File.AppendAllLines(pth, lines)
        File.WriteAllLines(pth, lines)
    End Sub

    Public Sub PlaySound(Filename As String, Background As Boolean)
        Dim pth As String = AppDomain.CurrentDomain.BaseDirectory & "data\snd\" & Filename & ".wav"
        If Background Then
            My.Computer.Audio.Play(pth, AudioPlayMode.BackgroundLoop)
        Else
            My.Computer.Audio.Play(pth, AudioPlayMode.WaitToComplete)
        End If
    End Sub

    Public Sub StopSound()
        My.Computer.Audio.Stop()
    End Sub

    Public Sub PlaySoundBack(FormName As String, StoryTimeG As Integer)
        If Sound = True Then
            Select Case FormName
                Case "Intro" '3
                    If StoryTimeG >= 0 And StoryTimeG <= 32 Then
                        PlaySound("BackIntro", True)
                    ElseIf StoryTimeG > 33 And StoryTimeG < 79 Then
                        PlaySound("BackRat", True)
                    ElseIf StoryTimeG >= 79 And StoryTimeG < 99 Then
                        PlaySound("BackIntro", True)
                    ElseIf StoryTimeG >= 99 Then
                        PlaySound("BackRunning", True)
                    End If
                Case "Run" '2
                    If StoryTimeG >= 0 And StoryTimeG < 22 Then
                        PlaySound("BackRat", True)
                    Else
                        PlaySound("BackRunning", True)
                    End If
                Case "Deploy" '2
                    If StoryTimeG >= 0 And StoryTimeG < 46 Then
                        PlaySound("BackDeploy", True)
                    Else
                        PlaySound("BackRunning", True)
                    End If
                Case "Level"
                    PlaySound("BackTitle", True)
                Case "Outro"
                    PlaySound("BackIntro", True)
                Case Else
                    PlaySound("Back" & FormName, True)
            End Select
        End If
    End Sub

    Public Function IsFontIstalled(FontName As String) As Boolean
        Using TFont As Font = New Font(FontName, 20)
            Return CBool(String.Compare(FontName, TFont.Name, StringComparison.InvariantCultureIgnoreCase) = 0)
        End Using
    End Function

    Public Sub FontFromFile(FontName As String)
        LfontColl = New PrivateFontCollection
        LfontColl.AddFontFile(AppDomain.CurrentDomain.BaseDirectory & "data\fonts\" & FontName)
        Lfont = LfontColl.Families(0)
    End Sub
End Module
