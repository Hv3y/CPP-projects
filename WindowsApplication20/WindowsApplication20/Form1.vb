Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Name As String = TextBox1.Text
        Dim Counter As Integer = TextBox2.Text
        For x = 0 To Counter - 1 Step 1
            ListBox1.Items.Add("Your name is:" + Name)
        Next
    End Sub
End Class
