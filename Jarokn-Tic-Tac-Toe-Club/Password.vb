Public Class Password

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        'This tests if the password is correct'
        If txtPassword.Text = Main.ThePassword Then
            Main.Enabled = True
            Me.Hide()
        Else
            MsgBox("Wrong password. Shutting down.", MsgBoxStyle.Critical, "No More Tries")
            Main.Close()
            Me.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Main.Close()
        Me.Close()
    End Sub

    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Main.Close()
    End Sub
End Class