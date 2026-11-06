Imports System.Math

Module Module1_Khai

    '====================================================================
    'CHƯƠNG TRÌNH CON ĐỔI ĐƠN VỊ

    'CHƯƠNG TRÌNH CON CHUYỂN GIÁ TRỊ ĐẦU VÀO SANG ĐỘ THẬP PHÂN
    Public Function TODOTHAPPHAN_Khai(ByRef GIATRIDAUVAO As Single) As Single
        Dim DOO, PHUT, GIAY As Integer

        'Tách độ
        DOO = Int(GIATRIDAUVAO)

        'Tách phút
        PHUT = Int((GIATRIDAUVAO - DOO) * 100)

        'Tách Giây
        GIAY = CInt(Math.Round(
                    ((GIATRIDAUVAO - DOO) * 100 - PHUT) * 100))

        'Độ phút giây -> độ thập phân
        TODOTHAPPHAN_Khai = DOO + PHUT / 60.0 + GIAY / 3600.0
    End Function

    'CHƯƠNG TRÌNH CON CHUYỂN ĐỘ THẬP PHÂN SANG RADIAN
    Public Function D10TORADIAN_Khai(ByRef GIATRIDAUVAO As Single) As Single
        D10TORADIAN_Khai = TODOTHAPPHAN_Khai(GIATRIDAUVAO) * Math.PI / 180
    End Function

    'CHƯƠNG TRÌNH CON RADIAN SANG ĐỘ THẬP PHÂN
    Public Function RADSANGDOTHAPPHAN_Khai(ByRef RADIAN As Double) As Double
        RADSANGDOTHAPPHAN_Khai = RADIAN * 180 / Math.PI
    End Function

    'ĐỘ THẬP PHÂN SANG ĐỘ PHÚT GIÂY
    Public Function DO10TODSM_Khai(ByRef GIATRIDAUVAO As Double) As String

        Dim DOO, PHUT, GIAY As Integer

        DOO = Int(GIATRIDAUVAO)

        PHUT = Int((GIATRIDAUVAO - DOO) * 60)

        GIAY = CInt(Math.Round((((GIATRIDAUVAO - DOO) * 60) - PHUT) * 60))

        If GIAY = 60 Then
            GIAY = 0
            PHUT = PHUT + 1
        End If

        If PHUT = 60 Then
            PHUT = 0
            DOO = DOO + 1
        End If

        DO10TODSM_Khai = DOO.ToString() & "° " &
                      PHUT.ToString("00") & "' " &
                      GIAY.ToString("00") & """"
    End Function
End Module