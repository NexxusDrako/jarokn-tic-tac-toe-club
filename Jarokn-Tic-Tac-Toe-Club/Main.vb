Imports System.IO

Public Class Main

    Public Shared ThePassword As String

    Private Sub FriendlyMatchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FriendlyMatchToolStripMenuItem.Click
        FriendlyMatch.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim file As System.IO.FileStream
        If System.IO.File.Exists("pwd.txt") = True Then
            Dim stream As StreamReader
            stream = New StreamReader("pwd.txt")
            ThePassword = stream.ReadLine()
            stream.Close()
        Else
            file = System.IO.File.Create("pwd.txt")
            file.Close()
            Dim swriter As New StreamWriter("pwd.txt")
            swriter.WriteLine("tictactoe")
            swriter.Close()
            Dim stream As StreamReader
            stream = New StreamReader("pwd.txt")
            ThePassword = stream.ReadLine()
            stream.Close()
        End If
        Me.Enabled = False
        Password.Show()
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        ChangePass.Show()
    End Sub

    Private Sub PlayersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlayersToolStripMenuItem.Click
        PlayerData.Show()
    End Sub
End Class
