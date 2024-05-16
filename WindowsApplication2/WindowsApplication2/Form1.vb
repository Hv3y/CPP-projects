Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim radius As Decimal = TextBox1.Text
        Dim height As Decimal = TextBox2.Text
        Dim Pie As Decimal = 3.1459
        Dim Volume As Decimal = Pie * (radius * radius) * height
        Dim Surface As Decimal = 2 * (Pie * (radius)) + 2 * (Pie * radius * height)
        MessageBox.Show("The volume of cylinder is:" & Decimal.Round(Volume, 2).ToString & "to decimal places" & vbNewLine)
    End Sub
End Class
