Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Username As String = TextBox1.Text
        Dim Password As Integer = TextBox2.Text
        If Password = 20220505 Then
            MessageBox.Show("Your Password was successful")
        ElseIf Password > 20220505 Then
            MessageBox.Show("your Password was not successful")
        ElseIf Password < 20220505 Then
            MessageBox.Show("your Password was not successful")


        End If
    End Sub
End Class
