Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim score As Integer = TextBox1.Text
        If score >= 70 Then
            MessageBox.Show("that test score is an A grade")
        ElseIf score >= 60 Then
            MessageBox.Show("that test score is an B grade")
        ElseIf score >= 50 Then
            MessageBox.Show("that test score is an C grade")
        ElseIf score >= 40 Then
            MessageBox.Show("that test score is a fail grade")
        ElseIf score >= 30 Then
            MessageBox.Show("that test score is a fail grade")

        End If
    End Sub
End Class
