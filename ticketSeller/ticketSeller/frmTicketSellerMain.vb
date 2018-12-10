Public Class frmTicketSellerMain

    Private Sub frmTicketSellerMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnNewGameMain_Click(sender As Object, e As EventArgs) Handles btnNewGameMain.Click
        Buttons.GoToNewGame()
    End Sub

    Private Sub mnuSetupNewGame_Click(sender As Object, e As EventArgs) Handles mnuSetupNewGame.Click
        Buttons.GoToNewGame()
    End Sub

    Private Sub btnSellTicketsMain_Click(sender As Object, e As EventArgs) Handles btnSellTicketsMain.Click
        Buttons.GoToSellTickets()
    End Sub

    Private Sub mnuSellTickets_Click(sender As Object, e As EventArgs) Handles mnuSellTickets.Click
        Buttons.GoToSellTickets()
    End Sub

    Private Sub btnDailyReportMain_Click(sender As Object, e As EventArgs) Handles btnDailyReportMain.Click
        Buttons.GoToReports()
    End Sub

    Private Sub mnuReports_Click(sender As Object, e As EventArgs) Handles mnuReports.Click
        Buttons.GoToReports()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close button exits the application
        Close()
    End Sub


End Class
