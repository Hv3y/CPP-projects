Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim AssetCost As Integer
        Dim SalvageValue As Integer
        Dim dblDep As Double
        Dim UsefulLife As Integer
        Dim strHeading As String = "Year Depreciation"
        LstDDB.Text = String.Empty
        Integer.TryParse(txtAssetCost.Text, AssetCost)
        Integer.TryParse(txtSalvageValue.Text, SalvageValue)
        Integer.TryParse(cmbUsefulLife.Text, UsefulLife)
        LstSYD.Text = LstSYD.Text & ControlChars.NewLine

        LstSYD.Items.Add(strHeading & ControlChars.NewLine)
        For Intterm = 1 To UsefulLife
            LstSYD.Text = ControlChars.NewLine & Intterm.ToString & ""
            dblDep = Financial.SYD(AssetCost, SalvageValue, UsefulLife, Intterm)
            LstSYD.Items.Add(LstSYD.Text & dblDep.ToString("n2") & " ")




        Next


    End Sub
End Class
