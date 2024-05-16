Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim hours As Integer = TextBox1.Text
        Dim Rate As Double = TextBox2.Text
        MessageBox.Show("Your gross pay is $" & hours * Rate)


    End Sub
End Class
