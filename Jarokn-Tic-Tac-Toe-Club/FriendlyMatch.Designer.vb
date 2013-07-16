<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FriendlyMatch
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
        Me.xy00 = New System.Windows.Forms.Button()
        Me.xy10 = New System.Windows.Forms.Button()
        Me.xy20 = New System.Windows.Forms.Button()
        Me.xy01 = New System.Windows.Forms.Button()
        Me.xy11 = New System.Windows.Forms.Button()
        Me.xy21 = New System.Windows.Forms.Button()
        Me.xy02 = New System.Windows.Forms.Button()
        Me.xy12 = New System.Windows.Forms.Button()
        Me.xy22 = New System.Windows.Forms.Button()
        Me.txtWhosPlaying = New System.Windows.Forms.TextBox()
        Me.txtScore = New System.Windows.Forms.TextBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'xy00
        '
        Me.xy00.Font = New System.Drawing.Font("Lucida Console", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xy00.Location = New System.Drawing.Point(12, 12)
        Me.xy00.Name = "xy00"
        Me.xy00.Size = New System.Drawing.Size(75, 75)
        Me.xy00.TabIndex = 0
        Me.xy00.UseVisualStyleBackColor = True
        '
        'xy10
        '
        Me.xy10.Font = New System.Drawing.Font("Lucida Console", 36.0!)
        Me.xy10.Location = New System.Drawing.Point(93, 12)
        Me.xy10.Name = "xy10"
        Me.xy10.Size = New System.Drawing.Size(75, 75)
        Me.xy10.TabIndex = 1
        Me.xy10.UseVisualStyleBackColor = True
        '
        'xy20
        '
        Me.xy20.Font = New System.Drawing.Font("Lucida Console", 36.0!)
        Me.xy20.Location = New System.Drawing.Point(174, 12)
        Me.xy20.Name = "xy20"
        Me.xy20.Size = New System.Drawing.Size(75, 75)
        Me.xy20.TabIndex = 2
        Me.xy20.UseVisualStyleBackColor = True
        '
        'xy01
        '
        Me.xy01.Font = New System.Drawing.Font("Lucida Console", 36.0!)
        Me.xy01.Location = New System.Drawing.Point(12, 93)
        Me.xy01.Name = "xy01"
        Me.xy01.Size = New System.Drawing.Size(75, 75)
        Me.xy01.TabIndex = 3
        Me.xy01.UseVisualStyleBackColor = True
        '
        'xy11
        '
        Me.xy11.Font = New System.Drawing.Font("Lucida Console", 36.0!)
        Me.xy11.Location = New System.Drawing.Point(93, 93)
        Me.xy11.Name = "xy11"
        Me.xy11.Size = New System.Drawing.Size(75, 75)
        Me.xy11.TabIndex = 4
        Me.xy11.UseVisualStyleBackColor = True
        '
        'xy21
        '
        Me.xy21.Font = New System.Drawing.Font("Lucida Console", 36.0!)
        Me.xy21.Location = New System.Drawing.Point(174, 93)
        Me.xy21.Name = "xy21"
        Me.xy21.Size = New System.Drawing.Size(75, 75)
        Me.xy21.TabIndex = 5
        Me.xy21.UseVisualStyleBackColor = True
        '
        'xy02
        '
        Me.xy02.Font = New System.Drawing.Font("Lucida Console", 36.0!)
        Me.xy02.Location = New System.Drawing.Point(12, 174)
        Me.xy02.Name = "xy02"
        Me.xy02.Size = New System.Drawing.Size(75, 75)
        Me.xy02.TabIndex = 6
        Me.xy02.UseVisualStyleBackColor = True
        '
        'xy12
        '
        Me.xy12.Font = New System.Drawing.Font("Lucida Console", 36.0!)
        Me.xy12.Location = New System.Drawing.Point(93, 174)
        Me.xy12.Name = "xy12"
        Me.xy12.Size = New System.Drawing.Size(75, 75)
        Me.xy12.TabIndex = 7
        Me.xy12.UseVisualStyleBackColor = True
        '
        'xy22
        '
        Me.xy22.Font = New System.Drawing.Font("Lucida Console", 36.0!)
        Me.xy22.Location = New System.Drawing.Point(174, 174)
        Me.xy22.Name = "xy22"
        Me.xy22.Size = New System.Drawing.Size(75, 75)
        Me.xy22.TabIndex = 8
        Me.xy22.UseVisualStyleBackColor = True
        '
        'txtWhosPlaying
        '
        Me.txtWhosPlaying.Enabled = False
        Me.txtWhosPlaying.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWhosPlaying.Location = New System.Drawing.Point(12, 255)
        Me.txtWhosPlaying.Name = "txtWhosPlaying"
        Me.txtWhosPlaying.Size = New System.Drawing.Size(237, 18)
        Me.txtWhosPlaying.TabIndex = 9
        Me.txtWhosPlaying.Text = "Player O's Turn!"
        Me.txtWhosPlaying.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtScore
        '
        Me.txtScore.Enabled = False
        Me.txtScore.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScore.Location = New System.Drawing.Point(12, 281)
        Me.txtScore.Name = "txtScore"
        Me.txtScore.Size = New System.Drawing.Size(237, 18)
        Me.txtScore.TabIndex = 10
        Me.txtScore.Text = "Score: O 0 - X 0"
        Me.txtScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(12, 305)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 11
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(174, 305)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 12
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'FriendlyMatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(261, 340)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.txtScore)
        Me.Controls.Add(Me.txtWhosPlaying)
        Me.Controls.Add(Me.xy22)
        Me.Controls.Add(Me.xy12)
        Me.Controls.Add(Me.xy02)
        Me.Controls.Add(Me.xy21)
        Me.Controls.Add(Me.xy11)
        Me.Controls.Add(Me.xy01)
        Me.Controls.Add(Me.xy20)
        Me.Controls.Add(Me.xy10)
        Me.Controls.Add(Me.xy00)
        Me.Name = "FriendlyMatch"
        Me.Text = "Friendly Match Screen - Jarokn Tic-Tac-Toe Club"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents xy00 As System.Windows.Forms.Button
    Friend WithEvents xy10 As System.Windows.Forms.Button
    Friend WithEvents xy20 As System.Windows.Forms.Button
    Friend WithEvents xy01 As System.Windows.Forms.Button
    Friend WithEvents xy11 As System.Windows.Forms.Button
    Friend WithEvents xy21 As System.Windows.Forms.Button
    Friend WithEvents xy02 As System.Windows.Forms.Button
    Friend WithEvents xy12 As System.Windows.Forms.Button
    Friend WithEvents xy22 As System.Windows.Forms.Button
    Friend WithEvents txtWhosPlaying As System.Windows.Forms.TextBox
    Friend WithEvents txtScore As System.Windows.Forms.TextBox
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
End Class
