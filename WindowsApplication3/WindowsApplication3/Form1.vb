Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Name As Decimal = TextBox1.Text
    End Sub
   MessageBox.Show ("Your name is:") & Decimal.ToString
End Class
