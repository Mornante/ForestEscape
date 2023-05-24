Public Class Game
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        MoveToStart()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub houseWin_MouseEnter(sender As Object, e As EventArgs) Handles houseWin.MouseEnter
        Me.Visible = False
        win.Visible = True
    End Sub
    Private Sub houseDead1_MouseEnter(sender As Object, e As EventArgs) Handles houseDead1.MouseEnter
        Me.Visible = False
        dead.Visible = True
    End Sub
    Private Sub houseDead2_MouseEnter(sender As Object, e As EventArgs) Handles houseDead2.MouseEnter
        Me.Visible = False
        dead.Visible = True
    End Sub
    Private Sub houseDead3_MouseEnter(sender As Object, e As EventArgs) Handles houseDead3.MouseEnter
        Me.Visible = False
        dead.Visible = True
    End Sub
    Private Sub houseDead4_MouseEnter(sender As Object, e As EventArgs) Handles houseDead4.MouseEnter
        Me.Visible = False
        dead.Visible = True
    End Sub
    Private Sub MoveToStart()
        Dim StartingPoint = Panel1.Location()
        StartingPoint.Offset(437, 22)
        Cursor.Position = PointToScreen(StartingPoint)
        Timer.Start()
    End Sub

    Private Sub Wall_MouseEnter(sender As Object, e As EventArgs) Handles Label70.MouseEnter, Panel1.MouseEnter, Label9.MouseEnter, Label8.MouseEnter, Label73.MouseEnter, Label72.MouseEnter, Label71.MouseEnter, Label7.MouseEnter, Label69.MouseEnter, Label68.MouseEnter, Label67.MouseEnter, Label66.MouseEnter, Label65.MouseEnter, Label64.MouseEnter, Label63.MouseEnter, Label62.MouseEnter, Label61.MouseEnter, Label60.MouseEnter, Label6.MouseEnter, Label59.MouseEnter, Label58.MouseEnter, Label57.MouseEnter, Label56.MouseEnter, Label55.MouseEnter, Label54.MouseEnter, Label53.MouseEnter, Label52.MouseEnter, Label51.MouseEnter, Label50.MouseEnter, Label5.MouseEnter, Label49.MouseEnter, Label48.MouseEnter, Label47.MouseEnter, Label46.MouseEnter, Label45.MouseEnter, Label44.MouseEnter, Label43.MouseEnter, Label42.MouseEnter, Label41.MouseEnter, Label40.MouseEnter, Label4.MouseEnter, Label39.MouseEnter, Label38.MouseEnter, Label37.MouseEnter, Label36.MouseEnter, Label35.MouseEnter, Label34.MouseEnter, Label33.MouseEnter, Label32.MouseEnter, Label31.MouseEnter, Label30.MouseEnter, Label3.MouseEnter, Label29.MouseEnter, Label28.MouseEnter, Label27.MouseEnter, Label26.MouseEnter, Label25.MouseEnter, Label24.MouseEnter, Label23.MouseEnter, Label22.MouseEnter, Label21.MouseEnter, Label20.MouseEnter, Label2.MouseEnter, Label19.MouseEnter, Label18.MouseEnter, Label17.MouseEnter, Label16.MouseEnter, Label15.MouseEnter, Label14.MouseEnter, Label13.MouseEnter, Label12.MouseEnter, Label11.MouseEnter, Label10.MouseEnter, Label1.MouseEnter
        MoveToStart()
    End Sub
End Class