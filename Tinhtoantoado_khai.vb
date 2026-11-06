Imports System.Math
Imports System.Security.Cryptography.X509Certificates

Public Class Tinhtoantoado_khai

    Public PHUONGVI_BA As Double,
           PHUONGVI_AP As Double
    Private Sub Button1_Click(ByVal sender As System.Object,
                              ByVal e As System.EventArgs) Handles Button1.Click


        Dim PHUONGVI0 As Double

        Dim DENTA_X As Double
        Dim DENTA_Y As Double

        ' 1. TÍNH DELTA X, DELTA Y

        ' A = điểm máy
        ' B = điểm định hướng
        '
        ' XA - XB ; YA - YB
        ' => đang tính hướng BA

        DENTA_X = Val(TextBox_XMAY_khai.Text) - Val(TextBox_XDHUONG_Khai.Text)

        DENTA_Y = Val(TextBox_YMAY_Khai.Text) - Val(TextBox_YDHUONG_Khai.Text)
        ' 3. TÍNH PHƯƠNG VỊ BA

        If DENTA_X > 0 And DENTA_Y > 0 Then

            PHUONGVI_BA = PHUONGVI0

        ElseIf DENTA_X < 0 And DENTA_Y > 0 Then

            PHUONGVI_BA = 180 - PHUONGVI0

        ElseIf DENTA_X < 0 And DENTA_Y < 0 Then

            PHUONGVI_BA = 180 + PHUONGVI0

        ElseIf DENTA_X > 0 And DENTA_Y < 0 Then

            PHUONGVI_BA = 360 - PHUONGVI0

        End If

        ' 4. TÍNH PHƯƠNG VỊ AP

        ' Công thức:
        '
        ' αAP = αBA + góc bằng - 180°

        PHUONGVI_AP = PHUONGVI_BA + TODOTHAPPHAN_Khai(Val(TextBox_GOCBANG_Khai.Text)) - 180

        ' 5. ĐƯA PHƯƠNG VỊ VỀ KHOẢNG 0° - 360°

        If PHUONGVI_AP < 0 Then
            PHUONGVI_AP = PHUONGVI_AP + 360
        End If

        If PHUONGVI_AP >= 360 Then
            PHUONGVI_AP = PHUONGVI_AP - 360
        End If

        ' 6. TÍNH TỌA ĐỘ X CỦA ĐIỂM P

        TextBox_KQX_Khai.Text = Round(Val(TextBox_XMAY_khai.Text) +
                                Val(TextBox_XMAY_khai.Text) +
                                Val(TextBox_KC_Khai.Text) *
                                Cos(PHUONGVI_AP * Math.PI / 180), 3).ToString("F3")


        ' 7. TÍNH TỌA ĐỘ Y CỦA ĐIỂM P

        TextBox_KQY_Khai.Text = Round(Val(TextBox_YMAY_Khai.Text) +
                                Val(TextBox_KC_Khai.Text) *
                                Sin(PHUONGVI_AP * Math.PI / 180), 3).ToString("F3")


        ' 8. TÍNH ĐỘ CAO

        Dim h_AP As Double

        h_AP = Round(
        Val(TextBox_KC_Khai.Text) *
               Tan(TODOTHAPPHAN_Khai(Val(TextBox_DUNG_Khai.Text)) * Math.PI / 180.0) +
               Val(TextBox_CAOMAY_Khai.Text) -
               Val(TextBox_CAOGUONG_Khai.Text), 3)

        TextBox_KQH_Khai.Text = h_AP + Val(TextBox_HMAY_Khai.Text)


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox_XMAY_khai.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox_YMAY_Khai.TextChanged

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox_GOCBANG_Khai.TextChanged

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox_KQX_Khai_TextChanged(sender As Object, e As EventArgs) Handles TextBox_KQX_Khai.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

        Dim PVGoc As Double
        Dim PVDo As Double
        Dim SaiSo As Double

        PVGoc = Val(TextBox_PhuongViGoc_Khai.Text)
        PVDo = Val(TextBox_PhuongViDo_Khai.Text)

        SaiSo = Math.Abs(PVGoc - PVDo)

        MessageBox.Show("Sai số phương vị = " &
Math.Round(SaiSo, 3).ToString("F3") &
"°")

    End Sub

    Private Sub TextBox_PhuongViDo_Khai_TextChanged(sender As Object, e As EventArgs) Handles TextBox_PhuongViDo_Khai.TextChanged

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox_PhuongViGoc_Khai.Text = PHUONGVI_BA
        TextBox_PhuongViDo_Khai.Text = DO10TODSM_Khai(PHUONGVI_AP)
    End Sub
End Class
