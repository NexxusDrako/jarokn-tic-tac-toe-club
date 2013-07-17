Public Class RankedUserPicker

    Dim inc As Integer
    Dim MaxRows As Integer
    Dim con As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim sql As String
    Dim OPicked As Boolean

    Private Sub RankedUserPicker_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = TicTacToe.mdb"

        con.Open()
        sql = "SELECT * FROM tblPlayers"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "Players")
        con.Close()

        MaxRows = ds.Tables("Players").Rows.Count
        inc = -1
        OPicked = False
    End Sub

    Private Sub NavigateRecords()

        txtGiven.Text = ds.Tables("Players").Rows(inc).Item(1)
        txtFamily.Text = ds.Tables("Players").Rows(inc).Item(7)
        txtCity.Text = ds.Tables("Players").Rows(inc).Item(2)
        txtRegion.Text = ds.Tables("Players").Rows(inc).Item(3)
        txtCountry.Text = ds.Tables("Players").Rows(inc).Item(4)
        txtID.Text = ds.Tables("Players").Rows(inc).Item(0)
        txtElo.Text = ds.Tables("Players").Rows(inc).Item(6)

    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        If inc <> MaxRows - 1 Then

            inc = inc + 1

            NavigateRecords()

        Else

            MsgBox("No More Rows")

        End If
    End Sub

    Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click
        If inc > 0 Then

            inc = inc - 1

            NavigateRecords()

        ElseIf inc = -1 Then

            MsgBox("No Records Yet")

        ElseIf inc = 0 Then

            MsgBox("First Record")

        End If
    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        If inc <> MaxRows - 1 Then

            inc = MaxRows - 1

            NavigateRecords()

        End If
    End Sub

    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
        If inc <> 0 Then

            inc = 0

            NavigateRecords()

        End If
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If Not OPicked Then
            OPicked = True
            RankedMatch.OElo = CInt(txtElo.Text)
            RankedMatch.OUserID = CInt(txtID.Text)
            Me.Text = "Pick Player X"
            inc = -1
            txtGiven.Clear()
            txtFamily.Clear()
            txtCity.Clear()
            txtRegion.Clear()
            txtCountry.Clear()
            txtElo.Clear()
            txtID.Clear()
        ElseIf OPicked Then
            RankedMatch.XUserID = CInt(txtID.Text)
            If RankedMatch.XUserID <> RankedMatch.OUserID Then
                RankedMatch.XElo = CInt(txtElo.Text)
                Me.Close()
                RankedMatch.Enabled = True
            Else
                RankedMatch.XUserID = Nothing
                MessageBox.Show("You can't play against yourself!", "Don't Be Silly")
            End If
        End If
    End Sub
End Class