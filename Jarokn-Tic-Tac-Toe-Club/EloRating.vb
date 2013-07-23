Public Class EloRating

    Public Shared Sub EloRatingCalc(ByVal Ro As Single, ByVal Rx As Single, ByVal Result As Single)

        Dim Eo As Single
        Dim Ex As Single

        Eo = 1 / (1 + 10 ^ ((Rx - Ro) / 400))
        Ex = 1 / (1 + 10 ^ ((Ro - Rx) / 400))
        If Result = 1 Then
            RankedMatch.RatingNewO = Ro + 24 * (1 - Eo)
            RankedMatch.RatingNewX = Rx + 24 * (0 - Ex)
        ElseIf Result = 0.5 Then
            RankedMatch.RatingNewO = Ro
            RankedMatch.RatingNewX = Rx
        ElseIf Result = 0 Then
            RankedMatch.RatingNewO = Ro + 24 * (0 - Eo)
            RankedMatch.RatingNewX = Rx + 24 * (1 - Ex)
        End If
    End Sub

End Class
