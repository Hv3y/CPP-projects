Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Add(Txtname.Text & vbTab & Txtemail.Text)
    End Sub

    Private Sub Txtname_TextChanged(sender As Object, e As EventArgs) Handles Txtname.TextChanged

    End Sub
End Class