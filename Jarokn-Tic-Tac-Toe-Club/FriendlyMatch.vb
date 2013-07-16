Public Class FriendlyMatch

    Private Property OTurn As Boolean
    Private Property OScore As Integer
    Private Property XScore As Integer

    Public Sub MatchVars()
        OTurn = True
        OScore = 0
        XScore = 0
    End Sub

    Private Sub xy00_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xy00.Click
        If OTurn = True Then
            xy00.Text = "O"
        ElseIf OTurn = False Then
            xy00.Text = "X"
        End If
        TurnDone()
    End Sub

    Private Sub xy10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xy10.Click
        If OTurn = True Then
            xy10.Text = "O"
        ElseIf OTurn = False Then
            xy10.Text = "X"
        End If
        TurnDone()
    End Sub

    Private Sub xy20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xy20.Click
        If OTurn = True Then
            xy20.Text = "O"
        ElseIf OTurn = False Then
            xy20.Text = "X"
        End If
        TurnDone()
    End Sub

    Private Sub xy01_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xy01.Click
        If OTurn = True Then
            xy01.Text = "O"
        ElseIf OTurn = False Then
            xy01.Text = "X"
        End If
        TurnDone()
    End Sub

    Private Sub xy11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xy11.Click
        If OTurn = True Then
            xy11.Text = "O"
        ElseIf OTurn = False Then
            xy11.Text = "X"
        End If
        TurnDone()
    End Sub

    Private Sub xy21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xy21.Click
        If OTurn = True Then
            xy21.Text = "O"
        ElseIf OTurn = False Then
            xy21.Text = "X"
        End If
        TurnDone()
    End Sub

    Private Sub xy02_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xy02.Click
        If OTurn = True Then
            xy02.Text = "O"
        ElseIf OTurn = False Then
            xy02.Text = "X"
        End If
        TurnDone()
    End Sub

    Private Sub xy12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xy12.Click
        If OTurn = True Then
            xy12.Text = "O"
        ElseIf OTurn = False Then
            xy12.Text = "X"
        End If
        TurnDone()
    End Sub

    Private Sub xy22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xy22.Click
        If OTurn = True Then
            xy22.Text = "O"
        ElseIf OTurn = False Then
            xy22.Text = "X"
        End If
        TurnDone()
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        ResetBoard()
    End Sub

    Public Sub ResetBoard()
        OTurn = True
        txtWhosPlaying.Text = "Player O's Turn!"
        xy00.Text = ""
        xy01.Text = ""
        xy02.Text = ""
        xy10.Text = ""
        xy11.Text = ""
        xy12.Text = ""
        xy20.Text = ""
        xy21.Text = ""
        xy22.Text = ""
    End Sub

    Public Sub TurnDone()
        If OTurn = True Then
            OTurn = False
            txtWhosPlaying.Text = "Player X's Turn!"
        Else
            OTurn = True
            txtWhosPlaying.Text = "Player O's Turn!"
        End If
        CheckBoard()
    End Sub

    Public Sub CheckBoard()
        If xy00.Text = "O" And xy01.Text = "O" And xy02.Text = "O" Then
            MsgBox("Well done Player O, YOU WON!", MsgBoxStyle.Exclamation, "Player O WINS!")
            OScore = OScore + 1
            GameWon()
        ElseIf xy00.Text = "O" And xy10.Text = "O" And xy20.Text = "O" Then
            MsgBox("Well done Player O, YOU WON!", MsgBoxStyle.Exclamation, "Player O WINS!")
            OScore = OScore + 1
            GameWon()
        ElseIf xy00.Text = "O" And xy11.Text = "O" And xy22.Text = "O" Then
            MsgBox("Well done Player O, YOU WON!", MsgBoxStyle.Exclamation, "Player O WINS!")
            OScore = OScore + 1
            GameWon()
        ElseIf xy02.Text = "O" And xy11.Text = "O" And xy20.Text = "O" Then
            MsgBox("Well done Player O, YOU WON!", MsgBoxStyle.Exclamation, "Player O WINS!")
            OScore = OScore + 1
            GameWon()
        ElseIf xy00.Text = "X" And xy01.Text = "X" And xy02.Text = "X" Then
            MsgBox("Well done Player X, YXU WIN!", MsgBoxStyle.Exclamation, "Player X WINS!")
            XScore = XScore + 1
            GameWon()
        ElseIf xy00.Text = "X" And xy10.Text = "X" And xy20.Text = "X" Then
            MsgBox("Well done Player X, YOU WIN!", MsgBoxStyle.Exclamation, "Player X WINS!")
            XScore = XScore + 1
            GameWon()
        ElseIf xy00.Text = "X" And xy11.Text = "X" And xy22.Text = "X" Then
            MsgBox("Well done Player X, YOU WIN!", MsgBoxStyle.Exclamation, "Player X WINS!")
            XScore = XScore + 1
            GameWon()
        ElseIf xy02.Text = "X" And xy11.Text = "X" And xy20.Text = "X" Then
            MsgBox("Well done Player X, YOU WIN!", MsgBoxStyle.Exclamation, "Player X WINS!")
            XScore = XScore + 1
            GameWon()
        End If
    End Sub
    Public Sub GameWon()
        ResetBoard()
        txtScore.Text = "Score: O " & OScore & " - X " & XScore
    End Sub
End Class