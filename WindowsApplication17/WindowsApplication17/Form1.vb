Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Cost, Value, Life, Depr As Double
        Cost = TextBox1.Text
        Value = TextBox2.Text
        Life = ComboBox1.Text
        ListBox1.Text = "Year " & vbTab & " Depreciation"
        ListBox2.Text = "Year" & vbTab & "Depreciation"
        For Period As Double = 1 To 5 Step 1
            Depr = Financial.DDB(Cost, Value, Life, Period)
            ListBox1.Append()
            ListBox2.Text(vbNewLine & Period & vbTab & Depr.ToString("##,###.00"))
        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
