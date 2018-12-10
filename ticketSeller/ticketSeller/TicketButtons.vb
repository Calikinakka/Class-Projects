Public Class TicketButtons
    Dim frmMainScreen As New frmTicketSellerMain
    Dim frmSellTicketsScreen As New frmSellTickets
    Dim frmNewGameScreen As New frmNewGame
    Dim frmReportsScreen As New frmReports

        Hide()
        frmMainScreen.ShowDialog()
        frmNewGameScreen.ShowDialog()
        frmReportsScreen.ShowDialog()
        frmSellTicketsScreen.ShowDialog()


End Class
