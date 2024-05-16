Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Radius As Decimal = txtRadius.Text
        Dim Height As Decimal = txtHEight.Text
        Dim pie As Decimal = 0
        Dim Volume As Decimal = 0
        pie=3,1415926536
        SurfaceArea=2* (pie *(Radius) +2* (pie*Radius* Height)
        MessageBox.Show(surfaceArea.Tostring)
    End Sub
End Class
