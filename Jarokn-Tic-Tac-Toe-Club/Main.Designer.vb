<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FriendlyMatchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RankedMatchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RankingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OnlineHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.PlayersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.PlayersToolStripMenuItem, Me.PlayToolStripMenuItem, Me.RankingsToolStripMenuItem, Me.StatsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(352, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangePasswordToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'PlayToolStripMenuItem
        '
        Me.PlayToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FriendlyMatchToolStripMenuItem, Me.RankedMatchToolStripMenuItem})
        Me.PlayToolStripMenuItem.Name = "PlayToolStripMenuItem"
        Me.PlayToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.PlayToolStripMenuItem.Text = "Play"
        '
        'FriendlyMatchToolStripMenuItem
        '
        Me.FriendlyMatchToolStripMenuItem.Name = "FriendlyMatchToolStripMenuItem"
        Me.FriendlyMatchToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.FriendlyMatchToolStripMenuItem.Text = "Friendly Match"
        '
        'RankedMatchToolStripMenuItem
        '
        Me.RankedMatchToolStripMenuItem.Name = "RankedMatchToolStripMenuItem"
        Me.RankedMatchToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.RankedMatchToolStripMenuItem.Text = "Ranked Match"
        '
        'RankingsToolStripMenuItem
        '
        Me.RankingsToolStripMenuItem.Name = "RankingsToolStripMenuItem"
        Me.RankingsToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.RankingsToolStripMenuItem.Text = "Rankings"
        '
        'StatsToolStripMenuItem
        '
        Me.StatsToolStripMenuItem.Name = "StatsToolStripMenuItem"
        Me.StatsToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.StatsToolStripMenuItem.Text = "Stats"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OnlineHelpToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'OnlineHelpToolStripMenuItem
        '
        Me.OnlineHelpToolStripMenuItem.Name = "OnlineHelpToolStripMenuItem"
        Me.OnlineHelpToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OnlineHelpToolStripMenuItem.Text = "Online Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(36, 24)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(282, 58)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Jarokn Tic-Tac-Toe Club" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "By Jarokn Games"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PlayersToolStripMenuItem
        '
        Me.PlayersToolStripMenuItem.Name = "PlayersToolStripMenuItem"
        Me.PlayersToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.PlayersToolStripMenuItem.Text = "Players"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 86)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.Text = "Jarokn Tic-Tac-Toe Club"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FriendlyMatchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RankedMatchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RankingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OnlineHelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents ChangePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlayersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
