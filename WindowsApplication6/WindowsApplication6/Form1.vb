Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim number As Integer = TextBox1.Text
        Dim Total As Integer
        For i = 0 To 12 Step 1
            Total = number * 1
            ListBox1.Items.Add(number.ToString & "x" & i.ToString & "=" & Total.ToString)
        Next
       
    End Sub
End Class
