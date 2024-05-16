Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Number As Integer = TextBox1.Text
        Dim Total As Integer
        For i = 0 To 12 Step 1
            Total = Number * i
            ListBox1.Items.Add(Number.ToString & "x" & i.ToString & "=" & Total.ToString)
        Next
    End Sub
End Class
