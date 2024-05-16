Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim iLength, iWidth, iHeight As Integer
        Dim rArea, rCoverage, iTotal As Double

        iLength = ComboBox1.SelectedItem 'Assign var to ComboBoxes
        iHeight = ComboBox3.SelectedItem
        iWidth = ComboBox2.SelectedItem
        rCoverage = ComboBox4.SelectedItem
        rArea = (2 * (iLength * iHeight)) + (2 * (iWidth * iHeight)) 'Formula for wallpaper surface
        iTotal = rArea / rCoverage 'Surface Area divided by roll coverage for amount of rolls
        TextBox1.Text = Math.Ceiling(iTotal)
    End Sub 
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox3.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
        ComboBox4.SelectedIndex = -1
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        ComboBox3.SelectedIndex = -1
        ComboBox1.SelectedIndex = -1
        ComboBox4.SelectedIndex = -1
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        ComboBox1.SelectedIndex = -1 'Clear All[ CITATION Mic19 \l 1033 ]
        ComboBox2.SelectedIndex = -1
        ComboBox4.SelectedIndex = -1
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        ComboBox1.SelectedIndex = -1
        ComboBox3.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
