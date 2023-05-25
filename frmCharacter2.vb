Public Class frmCharacter2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If rb2.Checked = True Then
            jawBetul += 1
            MsgBox("Good Guess")
        ElseIf rb1.Checked = True Or rb4.Checked Then
            MsgBox("Wrong guess")
        End If
        lblJawBetul.Text = jawBetul
        Button1.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmCharacter3.Show()
        Me.Hide()

    End Sub
End Class