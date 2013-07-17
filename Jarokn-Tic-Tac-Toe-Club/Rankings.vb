Public Class Rankings

    Private Sub Rankings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TicTacToeDataSet.tblPlayers' table. You can move, or remove it, as needed.
        Me.TblPlayersTableAdapter.Fill(Me.TicTacToeDataSet.tblPlayers)
        'This line of code sorts the data by Elo Rating
        DataGridView1.Sort(DataGridView1.Columns(6), System.ComponentModel.ListSortDirection.Descending)
    End Sub
End Class