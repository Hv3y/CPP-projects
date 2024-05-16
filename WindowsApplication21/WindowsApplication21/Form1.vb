Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim userentry As String = "y"
        While userentry <> "n"
            userentry = InputBox("Play Again y/n")
        End While
        MessageBox.Show("Game Over")
    End Sub
End Class
