Public Class Home
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Me.Visible = False
        Game.Visible = True
    End Sub

    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        MessageBox.Show("you are a lost stranger in a hedge maze being followed by a killer" & Environment.NewLine &
                         "Use your mouse to navigate through the maze and find the right house" & Environment.NewLine &
                         "if you dont you might end up in a house of killers")
    End Sub
End Class
