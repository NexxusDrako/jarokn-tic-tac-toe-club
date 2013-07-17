<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rankings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TblPlayersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TicTacToeDataSet = New Jarokn_Tic_Tac_Toe_Club.TicTacToeDataSet()
        Me.TblPlayersTableAdapter = New Jarokn_Tic_Tac_Toe_Club.TicTacToeDataSetTableAdapters.tblPlayersTableAdapter()
        Me.UserID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GivenNamesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SurnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegionalAreaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CountryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EloRatingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPlayersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TicTacToeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserID, Me.GivenNamesDataGridViewTextBoxColumn, Me.SurnameDataGridViewTextBoxColumn, Me.CityDataGridViewTextBoxColumn, Me.RegionalAreaDataGridViewTextBoxColumn, Me.CountryDataGridViewTextBoxColumn, Me.EloRatingDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblPlayersBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(13, 13)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(767, 541)
        Me.DataGridView1.TabIndex = 0
        '
        'TblPlayersBindingSource
        '
        Me.TblPlayersBindingSource.DataMember = "tblPlayers"
        Me.TblPlayersBindingSource.DataSource = Me.TicTacToeDataSet
        '
        'TicTacToeDataSet
        '
        Me.TicTacToeDataSet.DataSetName = "TicTacToeDataSet"
        Me.TicTacToeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblPlayersTableAdapter
        '
        Me.TblPlayersTableAdapter.ClearBeforeFill = True
        '
        'UserID
        '
        Me.UserID.DataPropertyName = "UserID"
        Me.UserID.HeaderText = "UserID"
        Me.UserID.Name = "UserID"
        Me.UserID.ReadOnly = True
        '
        'GivenNamesDataGridViewTextBoxColumn
        '
        Me.GivenNamesDataGridViewTextBoxColumn.DataPropertyName = "Given Names"
        Me.GivenNamesDataGridViewTextBoxColumn.HeaderText = "Given Names"
        Me.GivenNamesDataGridViewTextBoxColumn.Name = "GivenNamesDataGridViewTextBoxColumn"
        Me.GivenNamesDataGridViewTextBoxColumn.ReadOnly = True
        Me.GivenNamesDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'SurnameDataGridViewTextBoxColumn
        '
        Me.SurnameDataGridViewTextBoxColumn.DataPropertyName = "Surname"
        Me.SurnameDataGridViewTextBoxColumn.HeaderText = "Surname"
        Me.SurnameDataGridViewTextBoxColumn.Name = "SurnameDataGridViewTextBoxColumn"
        Me.SurnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.SurnameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'CityDataGridViewTextBoxColumn
        '
        Me.CityDataGridViewTextBoxColumn.DataPropertyName = "City"
        Me.CityDataGridViewTextBoxColumn.HeaderText = "City"
        Me.CityDataGridViewTextBoxColumn.Name = "CityDataGridViewTextBoxColumn"
        Me.CityDataGridViewTextBoxColumn.ReadOnly = True
        Me.CityDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'RegionalAreaDataGridViewTextBoxColumn
        '
        Me.RegionalAreaDataGridViewTextBoxColumn.DataPropertyName = "Regional Area"
        Me.RegionalAreaDataGridViewTextBoxColumn.HeaderText = "Regional Area"
        Me.RegionalAreaDataGridViewTextBoxColumn.Name = "RegionalAreaDataGridViewTextBoxColumn"
        Me.RegionalAreaDataGridViewTextBoxColumn.ReadOnly = True
        Me.RegionalAreaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'CountryDataGridViewTextBoxColumn
        '
        Me.CountryDataGridViewTextBoxColumn.DataPropertyName = "Country"
        Me.CountryDataGridViewTextBoxColumn.HeaderText = "Country"
        Me.CountryDataGridViewTextBoxColumn.Name = "CountryDataGridViewTextBoxColumn"
        Me.CountryDataGridViewTextBoxColumn.ReadOnly = True
        Me.CountryDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'EloRatingDataGridViewTextBoxColumn
        '
        Me.EloRatingDataGridViewTextBoxColumn.DataPropertyName = "Elo Rating"
        Me.EloRatingDataGridViewTextBoxColumn.HeaderText = "Elo Rating"
        Me.EloRatingDataGridViewTextBoxColumn.Name = "EloRatingDataGridViewTextBoxColumn"
        Me.EloRatingDataGridViewTextBoxColumn.ReadOnly = True
        Me.EloRatingDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'Rankings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Rankings"
        Me.Text = "Rankings"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPlayersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TicTacToeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TicTacToeDataSet As Jarokn_Tic_Tac_Toe_Club.TicTacToeDataSet
    Friend WithEvents TblPlayersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblPlayersTableAdapter As Jarokn_Tic_Tac_Toe_Club.TicTacToeDataSetTableAdapters.tblPlayersTableAdapter
    Friend WithEvents UserIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GivenNamesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SurnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RegionalAreaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CountryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EloRatingDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
