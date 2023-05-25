Public Class frmcCharacter4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If rb4.Checked = True Then
            jawBetul += 1
            MsgBox("Good Guess")
        ElseIf rb2.Checked = True Or rb1.Checked Then
            MsgBox("Wrong guess")
        End If
        lblJawBetul.Text = jawBetul
        Button1.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Congratulations for finishing THE GAME")
        Me.Hide()
        Form1.Show()
    End Sub
End Class