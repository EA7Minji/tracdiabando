Imports System.Math

Module ModuleCM_khai

    Function ChiaManh(X_Khai As Double, Y_Khai As Double, tyLe_Khai As Integer)

        '================ 1:10.000 ================
        Dim X10000_Khai As Double
        Dim Y10000_Khai As Double

        X10000_Khai = Ceiling(X_Khai / 6000) * 6000
        Y10000_Khai = 500000 + Floor((Y_Khai - 500000) / 6000) * 6000

        If tyLe_Khai = 0 Then
            Return "10-" &
                   (X10000_Khai / 1000 Mod 1000).ToString("000") &
                   (Y10000_Khai / 1000).ToString("000")
        End If

        '================ 1:5.000 ================
        Dim hang5000_Khai As Integer
        Dim cot5000_Khai As Integer

        hang5000_Khai = CInt(Floor((X10000_Khai - X_Khai) / 3000))
        cot5000_Khai = CInt(Floor((Y_Khai - Y10000_Khai) / 3000))

        Dim X5000_Khai As Double
        Dim Y5000_Khai As Double

        X5000_Khai = X10000_Khai - hang5000_Khai * 3000
        Y5000_Khai = Y10000_Khai + cot5000_Khai * 3000

        If tyLe_Khai = 1 Then
            Return (X5000_Khai / 1000 Mod 1000).ToString("000") &
                   (Y5000_Khai / 1000).ToString("000")
        End If

        '================ 1:2.000 ================
        Dim hang2000_Khai As Integer
        Dim cot2000_Khai As Integer
        Dim so2000_Khai As Integer

        hang2000_Khai = CInt(Floor((X5000_Khai - X_Khai) / 1000))
        cot2000_Khai = CInt(Floor((Y_Khai - Y5000_Khai) / 1000))

        so2000_Khai = hang2000_Khai * 3 + cot2000_Khai + 1

        Dim X2000_Khai As Double
        Dim Y2000_Khai As Double

        X2000_Khai = X5000_Khai - hang2000_Khai * 1000
        Y2000_Khai = Y5000_Khai + cot2000_Khai * 1000

        If tyLe_Khai = 2 Then
            Return (X5000_Khai / 1000 Mod 1000).ToString("000") &
                   (Y5000_Khai / 1000).ToString("000") &
                   "-" &
                   so2000_Khai.ToString()
        End If

        '================ 1:1.000 ================
        If tyLe_Khai = 3 Then

            Dim hang1000_Khai As Integer
            Dim cot1000_Khai As Integer
            Dim kyTu_Khai As String

            hang1000_Khai = CInt(Floor((X2000_Khai - X_Khai) / 500))
            cot1000_Khai = CInt(Floor((Y_Khai - Y2000_Khai) / 500))

            Select Case hang1000_Khai * 2 + cot1000_Khai
                Case 0 : kyTu_Khai = "a"
                Case 1 : kyTu_Khai = "b"
                Case 2 : kyTu_Khai = "c"
                Case 3 : kyTu_Khai = "d"
                Case Else
                    Return "Tọa độ không hợp lệ"
            End Select

            Return (X5000_Khai / 1000 Mod 1000).ToString("000") &
                   (Y5000_Khai / 1000).ToString("000") &
                   "-" &
                   so2000_Khai.ToString() &
                   "-" &
                   kyTu_Khai
        End If

        '================ 1:500 ================
        If tyLe_Khai = 4 Then

            Dim hang500_Khai As Integer
            Dim cot500_Khai As Integer
            Dim so500_Khai As Integer

            hang500_Khai = CInt(Floor((X2000_Khai - X_Khai) / 250))
            cot500_Khai = CInt(Floor((Y_Khai - Y2000_Khai) / 250))

            so500_Khai = hang500_Khai * 4 + cot500_Khai + 1

            If so500_Khai < 1 Or so500_Khai > 16 Then
                Return "Tọa độ không hợp lệ"
            End If

            Return (X5000_Khai / 1000 Mod 1000).ToString("000") &
                   (Y5000_Khai / 1000).ToString("000") &
                   "-" &
                   so2000_Khai.ToString() &
                   "-(" &
                   so500_Khai.ToString() &
                   ")"
        End If

        '================ 1:200 ================
        If tyLe_Khai = 5 Then

            Dim hang200_Khai As Integer
            Dim cot200_Khai As Integer
            Dim so200_Khai As Integer

            hang200_Khai = CInt(Floor((X2000_Khai - X_Khai) / 100))
            cot200_Khai = CInt(Floor((Y_Khai - Y2000_Khai) / 100))

            so200_Khai = hang200_Khai * 10 + cot200_Khai + 1

            If so200_Khai < 1 Or so200_Khai > 100 Then
                Return "Tọa độ không hợp lệ"
            End If

            Return (X5000_Khai / 1000 Mod 1000).ToString("000") &
                   (Y5000_Khai / 1000).ToString("000") &
                   "-" &
                   so2000_Khai.ToString() &
                   "-" &
                   so200_Khai.ToString()
        End If

        '================ LỖI TỶ LỆ ================
        Return "Chưa chọn đúng tỷ lệ"

    End Function

End Module