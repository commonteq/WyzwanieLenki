

Public Class Form1
    'Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
    '    Select Case e.KeyCode
    '        Case Keys.Left : PictureBox1.Location = New Drawing.Point(PictureBox1.Location.X - 10, PictureBox1.Location.Y)
    '        Case Keys.Right : PictureBox1.Location = New Drawing.Point(PictureBox1.Location.X + 10, PictureBox1.Location.Y)
    '    End Select
    'End Sub


    Private Sub EndingForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Left Then
            Label1.Text = "Left"
        ElseIf e.KeyCode = Keys.A Then
            Label1.Text = "A"
        Else
            Label1.Text = e.KeyCode
        End If

    End Sub
End Class