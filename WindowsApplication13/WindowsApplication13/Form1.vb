Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim iLength, iWidth, iHeight As Integer
        Dim rArea, rCoverage, iTotal As Double
        iLength = cmbLength.SelectedItem 'Assign var to ComboBoxes
        iHeight = cmbHeight.SelectedItem
        iWidth = cmbWidth.SelectedItem
        rCoverage = cmbCoverage.SelectedItem
        rArea = (2 * (iLength * iHeight)) + (2 * (iWidth * iHeight)) 'Formula for wallpaper surface area
        iTotal = rArea / rCoverage 'Surface Area divided by roll coverage for amount of rolls
        edtSingle.Text = Math.Ceiling(iTotal)
    End Sub
    Private Sub Calculator(ByRef height As Integer, ByRef width As Integer, ByRef Length As Integer   
                           ByRef rollcoverage As Decimal, ByRef singlroll As Integer,
 ByRef area As Integer)
        Length = CInt(cmbLength.Text)
        width = CInt(cmbWidth.Text)
        height = CInt(cmbHeight.Text)
        rollcoverage = CDbl(cmbRollCover.Text)
        area = (((width * height) * 2) + ((Length * height) * 2))
        singleroll = Math.Ceiling(area / rollcoverage)
txtSingleRoll: .Text = CStr(singleroll)

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
    Handles cmbLength.SelectedIndexChanged
txtSingleRoll: .Clear()
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)
  Handles cmbWidth.SelectedIndexChanged
txtSingleRoll: .Clear()

    End Sub
    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs)
  Handles cmbHeight.SelectedIndexChanged
txtSingleRoll: .Clear()
    End Sub
    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs)
  Handles cmbRollCover.SelectedIndexChanged
txtSingleRoll: .Clear()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub
End Class
