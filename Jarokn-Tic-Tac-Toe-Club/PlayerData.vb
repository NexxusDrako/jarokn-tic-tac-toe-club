Public Class PlayerData

    Dim inc As Integer
    Dim MaxRows As Integer
    Dim con As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim sql As String

    Private Sub PlayerData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = TicTacToe.mdb"

        con.Open()
        sql = "SELECT * FROM tblPlayers"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "Players")
        con.Close()

        MaxRows = ds.Tables("Players").Rows.Count
        inc = -1
    End Sub

    Private Sub NavigateRecords()

        con.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = TicTacToe.mdb"

        con.Open()
        sql = "SELECT * FROM tblPlayers"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "Players")
        con.Close()

        txtGiven.Text = ds.Tables("Players").Rows(inc).Item(1)
        txtFamily.Text = ds.Tables("Players").Rows(inc).Item(7)
        txtCity.Text = ds.Tables("Players").Rows(inc).Item(2)
        txtRegion.Text = ds.Tables("Players").Rows(inc).Item(3)
        txtCountry.Text = ds.Tables("Players").Rows(inc).Item(4)
        txtPhone.Text = ds.Tables("Players").Rows(inc).Item(5)
        txtID.Text = ds.Tables("Players").Rows(inc).Item(0)

    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        If inc < MaxRows - 1 Then

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

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim cb As New OleDb.OleDbCommandBuilder(da)
        cb.QuotePrefix = "["
        cb.QuoteSuffix = "]"
        cb.ConflictOption = ConflictOption.OverwriteChanges

        If inc <> -1 Then

            ds.Tables("Players").Rows(inc).Item(0) = inc + 1
            ds.Tables("Players").Rows(inc).Item(1) = txtGiven.Text
            ds.Tables("Players").Rows(inc).Item(7) = txtFamily.Text
            ds.Tables("Players").Rows(inc).Item(2) = txtCity.Text
            ds.Tables("Players").Rows(inc).Item(3) = txtRegion.Text
            ds.Tables("Players").Rows(inc).Item(4) = txtCountry.Text
            ds.Tables("Players").Rows(inc).Item(5) = txtPhone.Text

            da.Update(ds, "Players")

            MsgBox("Data updated")

            inc = -1
            txtGiven.Clear()
            txtFamily.Clear()
            txtCity.Clear()
            txtRegion.Clear()
            txtCountry.Clear()
            txtPhone.Clear()
            txtID.Clear()
        End If
    End Sub

    Private Sub btnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNew.Click
        btnCommit.Enabled = True
        btnAddNew.Enabled = False
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        btnNext.Enabled = False
        btnLast.Enabled = False
        btnFirst.Enabled = False
        btnPrev.Enabled = False

        txtGiven.Clear()
        txtFamily.Clear()
        txtCity.Clear()
        txtRegion.Clear()
        txtCountry.Clear()
        txtPhone.Clear()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        btnCommit.Enabled = False
        btnAddNew.Enabled = True
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
        btnNext.Enabled = True
        btnLast.Enabled = True
        btnFirst.Enabled = True
        btnPrev.Enabled = True

        inc = 0
        NavigateRecords()
    End Sub

    Private Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommit.Click
        If inc <> -1 Then

            Dim cb As New OleDb.OleDbCommandBuilder(da)

            cb.QuotePrefix = "["
            cb.QuoteSuffix = "]"
            cb.ConflictOption = ConflictOption.OverwriteChanges

            Dim dsNewRow As DataRow

            dsNewRow = ds.Tables("Players").NewRow()

            dsNewRow.Item("UserID") = MaxRows + 1
            dsNewRow.Item("Given Names") = txtGiven.Text
            dsNewRow.Item("Surname") = txtFamily.Text
            dsNewRow.Item("City") = txtCity.Text
            dsNewRow.Item("Regional Area") = txtRegion.Text
            dsNewRow.Item("Country") = txtCountry.Text
            dsNewRow.Item("Phone Number") = txtPhone.Text
            dsNewRow.Item("Elo Rating") = 1200

            ds.Tables("Players").Rows.Add(dsNewRow)

            da.Update(ds, "Players")

            MsgBox("New Record added to the Database")

            btnCommit.Enabled = False
            btnAddNew.Enabled = True
            btnUpdate.Enabled = True
            btnDelete.Enabled = True
            btnNext.Enabled = True
            btnLast.Enabled = True
            btnFirst.Enabled = True
            btnPrev.Enabled = True

            MaxRows = MaxRows + 1

            MessageBox.Show("The database window must refresh itself, so it needs to close.  Sorry for the inconvenience.", "Refresh Needed")

            Me.Close()
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If MaxRows <> 1 Then
            If MessageBox.Show("Do you really want to Delete this Record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then

                MsgBox("Operation Cancelled")
                Exit Sub

            End If

            Dim cb As New OleDb.OleDbCommandBuilder(da)

            cb.QuotePrefix = "["
            cb.QuoteSuffix = "]"
            cb.ConflictOption = ConflictOption.OverwriteChanges

            ds.Tables("Players").Rows(inc).Delete()

            da.Update(ds, "Players")

            MaxRows = MaxRows - 1

            inc = 0
            NavigateRecords()
        Else
            MessageBox.Show("You can't delete your last entry, try updating it!", "Don't Be Silly")
        End If

    End Sub
End Class