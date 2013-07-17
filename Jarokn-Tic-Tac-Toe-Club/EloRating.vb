Public Class EloRating

    Public Shared Sub EloRatingCalc(ByVal RatingO As Single, ByVal RatingX As Single, ByVal Result As Single)

        Dim ExpectedA As Single
        Dim RatingDiff As Single
        Dim RatingNewO As Single
        Dim RatingNewX As Single

        ExpectedA = 1 / (1 + 10 ^ ((RatingO - RatingX) / 400))
        RatingDiff = 24 * (Result - ExpectedA)
        RatingNewO = RatingO + RatingDiff
        RatingNewX = RatingX - RatingDiff
        RankedMatch.RatingNewO = CInt(RatingNewO)
        RankedMatch.RatingNewX = CInt(RatingNewX)
    End Sub

End Class
