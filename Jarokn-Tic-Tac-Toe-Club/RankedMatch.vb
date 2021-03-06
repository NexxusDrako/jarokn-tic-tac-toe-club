﻿Public Class RankedMatch

    Public OTurn As Boolean = True
    Public OElo As Integer
    Public XElo As Integer
    Public OUserID As Integer
    Public XUserID As Integer
    Public Result As Single
    Public Shared RatingNewO As Integer
    Public Shared RatingNewX As Integer

    Private Sub xy00_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xy00.Click
        If OTurn = True Then
            xy00.Text = "O"
        ElseIf OTurn = False Then
            xy00.Text = "X"
        End If
        xy00.Enabled = False
        TurnDone()
    End Sub

    Private Sub xy10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xy10.Click
        If OTurn = True Then
            xy10.Text = "O"
        ElseIf OTurn = False Then
            xy10.Text = "X"
        End If
        xy10.Enabled = False
        TurnDone()
    End Sub

    Private Sub xy20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xy20.Click
        If OTurn = True Then
            xy20.Text = "O"
        ElseIf OTurn = False Then
            xy20.Text = "X"
        End If
        xy20.Enabled = False
        TurnDone()
    End Sub

    Private Sub xy01_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xy01.Click
        If OTurn = True Then
            xy01.Text = "O"
        ElseIf OTurn = False Then
            xy01.Text = "X"
        End If
        xy01.Enabled = False
        TurnDone()
    End Sub

    Private Sub xy11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xy11.Click
        If OTurn = True Then
            xy11.Text = "O"
        ElseIf OTurn = False Then
            xy11.Text = "X"
        End If
        xy11.Enabled = False
        TurnDone()
    End Sub

    Private Sub xy21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xy21.Click
        If OTurn = True Then
            xy21.Text = "O"
        ElseIf OTurn = False Then
            xy21.Text = "X"
        End If
        xy21.Enabled = False
        TurnDone()
    End Sub

    Private Sub xy02_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xy02.Click
        If OTurn = True Then
            xy02.Text = "O"
        ElseIf OTurn = False Then
            xy02.Text = "X"
        End If
        xy02.Enabled = False
        TurnDone()
    End Sub

    Private Sub xy12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xy12.Click
        If OTurn = True Then
            xy12.Text = "O"
        ElseIf OTurn = False Then
            xy12.Text = "X"
        End If
        xy12.Enabled = False
        TurnDone()
    End Sub

    Private Sub xy22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xy22.Click
        If OTurn = True Then
            xy22.Text = "O"
        ElseIf OTurn = False Then
            xy22.Text = "X"
        End If
        xy22.Enabled = False
        TurnDone()
    End Sub

    Public Sub TurnDone()
        'This game changes the player and then calls the check board function'
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
        'This function checks the board for winners'
        If xy00.Text = "O" And xy01.Text = "O" And xy02.Text = "O" Then
            MsgBox("Well done Player O, YOU WON!", MsgBoxStyle.Exclamation, "Player O WINS!")
            Result = 1
            GameWon()
        ElseIf xy00.Text = "O" And xy10.Text = "O" And xy20.Text = "O" Then
            MsgBox("Well done Player O, YOU WON!", MsgBoxStyle.Exclamation, "Player O WINS!")
            Result = 1
            GameWon()
        ElseIf xy00.Text = "O" And xy11.Text = "O" And xy22.Text = "O" Then
            MsgBox("Well done Player O, YOU WON!", MsgBoxStyle.Exclamation, "Player O WINS!")
            Result = 1
            GameWon()
        ElseIf xy02.Text = "O" And xy11.Text = "O" And xy20.Text = "O" Then
            MsgBox("Well done Player O, YOU WON!", MsgBoxStyle.Exclamation, "Player O WINS!")
            Result = 1
            GameWon()
        ElseIf xy10.Text = "O" And xy11.Text = "O" And xy12.Text = "O" Then
            MsgBox("Well done Player O, YOU WON!", MsgBoxStyle.Exclamation, "Player O WINS!")
            Result = 1
            GameWon()
        ElseIf xy20.Text = "O" And xy21.Text = "O" And xy22.Text = "O" Then
            MsgBox("Well done Player O, YOU WON!", MsgBoxStyle.Exclamation, "Player O WINS!")
            Result = 1
            GameWon()
        ElseIf xy01.Text = "O" And xy11.Text = "O" And xy21.Text = "O" Then
            MsgBox("Well done Player O, YOU WON!", MsgBoxStyle.Exclamation, "Player O WINS!")
            Result = 1
            GameWon()
        ElseIf xy02.Text = "O" And xy12.Text = "O" And xy22.Text = "O" Then
            MsgBox("Well done Player O, YOU WON!", MsgBoxStyle.Exclamation, "Player O WINS!")
            Result = 1
            GameWon()
        ElseIf xy00.Text = "X" And xy01.Text = "X" And xy02.Text = "X" Then
            MsgBox("Well done Player X, YOU WON!", MsgBoxStyle.Exclamation, "Player X WINS!")
            Result = 0
            GameWon()
        ElseIf xy00.Text = "X" And xy10.Text = "X" And xy20.Text = "X" Then
            MsgBox("Well done Player X, YOU WON!", MsgBoxStyle.Exclamation, "Player X WINS!")
            Result = 0
            GameWon()
        ElseIf xy00.Text = "X" And xy11.Text = "X" And xy22.Text = "X" Then
            MsgBox("Well done Player X, YOU WON!", MsgBoxStyle.Exclamation, "Player X WINS!")
            Result = 0
            GameWon()
        ElseIf xy02.Text = "X" And xy11.Text = "X" And xy20.Text = "X" Then
            MsgBox("Well done Player X, YOU WON!", MsgBoxStyle.Exclamation, "Player X WINS!")
            Result = 0
            GameWon()
        ElseIf xy10.Text = "X" And xy11.Text = "X" And xy12.Text = "X" Then
            MsgBox("Well done Player X, YOU WON!", MsgBoxStyle.Exclamation, "Player X WINS!")
            Result = 0
            GameWon()
        ElseIf xy20.Text = "X" And xy21.Text = "X" And xy22.Text = "X" Then
            MsgBox("Well done Player X, YOU WON!", MsgBoxStyle.Exclamation, "Player X WINS!")
            Result = 0
            GameWon()
        ElseIf xy01.Text = "X" And xy11.Text = "X" And xy21.Text = "X" Then
            MsgBox("Well done Player X, YOU WON!", MsgBoxStyle.Exclamation, "Player X WINS!")
            Result = 0
            GameWon()
        ElseIf xy02.Text = "X" And xy12.Text = "X" And xy22.Text = "X" Then
            MsgBox("Well done Player X, YOU WON!", MsgBoxStyle.Exclamation, "Player X WINS!")
            Result = 0
            GameWon()
        ElseIf xy00.Text <> Nothing And xy01.Text <> Nothing And xy02.Text <> Nothing And xy10.Text <> Nothing And xy20.Text <> Nothing And xy11.Text <> Nothing And xy12.Text <> Nothing And xy21.Text <> Nothing And xy22.Text <> Nothing Then
            MsgBox("The Match is a Tie!", MsgBoxStyle.Exclamation, "TIE GAME!")
            Result = 0.5
            GameWon()
        End If
    End Sub
    Public Sub GameWon()
        'This function finishes the game when won'
        EloRating.EloRatingCalc(OElo, XElo, Result)
        SaveElo()
    End Sub

    Private Sub SaveElo()
        Dim con As New OleDb.OleDbConnection
        Dim ds As New DataSet
        Dim da As OleDb.OleDbDataAdapter
        Dim sql As String

        con.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = TicTacToe.mdb"

        con.Open()
        Sql = "SELECT * FROM tblPlayers"
        da = New OleDb.OleDbDataAdapter(Sql, con)
        da.Fill(ds, "Players")
        con.Close()

        Dim cb As New OleDb.OleDbCommandBuilder(da)

        cb.QuotePrefix = "["
        cb.QuoteSuffix = "]"
        cb.ConflictOption = ConflictOption.OverwriteChanges

        ds.Tables("Players").Rows(OUserID - 1).Item(6) = RatingNewO
        ds.Tables("Players").Rows(XUserID - 1).Item(6) = RatingNewX

        da.Update(ds, "Players")

        MsgBox("Elo Ratings Updated")

        Me.Close()
    End Sub

    Private Sub RankedMatch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RankedUserPicker.Show()
        Me.Enabled = False
    End Sub
End Class