Imports System.IO

Public Class ChangePass

    Private Sub ChangePass()
        Dim NewPass As String
        NewPass = txtNewPass.Text
        Dim swriter As New StreamWriter("pwd.txt")
        swriter.WriteLine(NewPass)
        swriter.Close()
        Dim stream As StreamReader
        stream = New StreamReader("pwd.txt")
        Main.ThePassword = stream.ReadLine()
        stream.Close()
        Me.Close()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If txtOldPass.Text = Main.ThePassword Then
            If txtNewPass.Text = txtConfirmPass.Text Then
                ChangePass()
            Else
                MsgBox("Your passwords don't match.", MsgBoxStyle.Exclamation, "Passwords Don't Match")
            End If
        Else
            MsgBox("Your password is incorrect", MsgBoxStyle.Exclamation, "Bad Password")
        End If
    End Sub
End Class