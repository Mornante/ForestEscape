Public Class dead
    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        Me.Visible = False
        Game.Visible = True
    End Sub
End Class