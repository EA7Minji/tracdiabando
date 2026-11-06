Public Class chiamanhbando_khai
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ChiaManh_Khai.Click
        Dim X As Double = Double.Parse(TextBoxX_Khai.Text)
        Dim Y As Double = Double.Parse(TextBoxY_Khai.Text)

        Dim tyLe As Integer = ComboBoxTL_Khai.SelectedIndex

        TextBoxKQ_Khai.Text = ModuleCM_khai.ChiaManh(X, Y, tyLe)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxTL_Khai.SelectedIndexChanged

    End Sub
End Class