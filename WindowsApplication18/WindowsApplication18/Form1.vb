Public Class Form1
    Sub Calculator()
        Dim length As Double = ComboBox1.SelectedItem
        Dim Height As Double = ComboBox3.SelectedItem
        Dim Width As Double = ComboBox2.SelectedItem
        Dim Rollcover As Double = ComboBox4.SelectedItem
        Dim SingleRollCover As Integer
        SingleRollCover = ((length * Width * Height) / (Rollcover * 4))
        TextBox1.Text = SingleRollCover

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Calculator()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class
