Public Class EloRating

    Private Property ExpectedA As Integer

    Private Property RatingDiff As Integer

    Private Property RatingNewA As Integer

    Private Property RatingNewB As Integer

    Public Sub EloRatingCalc(ByVal RatingA As Integer, ByVal RatingB As Integer, ByVal Result As Integer)
        ExpectedA = 1 / (1 + 10 ^ ((RatingA - RatingB) / 400))
        RatingDiff = 24 * (Result - ExpectedA)
        RatingNewA = RatingA + RatingDiff
        RatingNewB = RatingB - RatingDiff
    End Sub

End Class
