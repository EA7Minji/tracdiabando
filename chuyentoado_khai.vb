Public Class chuyentoado_khai

    Private Sub ButtonNhapFile_Khai_Click(sender As Object, e As EventArgs) Handles ButtonNhapFile_Khai.Click

        OpenFileDialog_Khai.Filter = "Text Files (*.txt)|*.txt"

        If OpenFileDialog_Khai.ShowDialog() = DialogResult.OK Then

            TextBoxFile_Khai.Text = OpenFileDialog_Khai.FileName

            'Đọc và xem file đầu vào
            Dim noiDung As String = IO.File.ReadAllText(TextBoxFile_Khai.Text)

            MessageBox.Show(noiDung, "File đầu vào")

        End If

    End Sub


    Private Sub ButtonXuat_Khai_Click(sender As Object, e As EventArgs) Handles ButtonXuat_Khai.Click

        Dim noiDung As String = IO.File.ReadAllText(TextBoxFile_Khai.Text)

        Dim ketQua As String = ""

        If noiDung.Contains("5") Then ketQua = ketQua & "5" & vbCrLf
        If noiDung.Contains("g") Then ketQua = ketQua & "g" & vbCrLf
        If noiDung.Contains("N") Then ketQua = ketQua & "N"

        MessageBox.Show(ketQua, "Kết quả lấy ra")

    End Sub

End Class