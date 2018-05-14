Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox3.Text = ScoreEncode(TextBox1.Text, TextBox2.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox4.Text = ScoreDecode(TextBox3.Text, True)
        TextBox5.Text = ScoreDecode(TextBox3.Text, False)
    End Sub
End Class