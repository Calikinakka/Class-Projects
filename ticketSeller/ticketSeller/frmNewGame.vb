'Program Name: Ticket Seller
'Justin Cook
'December 3rd 2018
'This application enable the user to create games with number of seats available, price per seat and the date selected. 
'There are additional options for running reports for daily and weekly. These take information from the text files used in the new game form and sell tickets. 
'In the sell tickets form the user sells seat for the specified game and tracks the total seats available after sales in the Reports.txt

Option Strict On


Public Class frmNewGame
    'variables used within frmNewGame class

    Dim strTicketCost As String
    Dim strSeats As String
    Dim strGameType As String
    Dim blnGameSelected As Boolean

    Sub WriteToGames()
        'Writes the game information to the Games.txt file after checking to make sure that the file is available.
        Dim strGamesTextFileLocation As String = "F:\Games.txt"
        Try
            Dim objWriter As IO.StreamWriter = IO.File.AppendText(strGamesTextFileLocation)

            objWriter.Write(cldGames.SelectionStart.ToString("MM/dd/yyyy") & ",")
            objWriter.Write(strGameType & ",")
            objWriter.Write(strSeats & ",")
            objWriter.WriteLine(strTicketCost)
            objWriter.Close()

            MsgBox("Game Created for: " & cldGames.SelectionStart, , "Game Created")
            txtSetTicketCost.Text = ""
            radAway.Checked = False
            radHome.Checked = False
            txtSeats.Text = ""
            cldGames.ShowToday = True
        Catch ex As Exception
            MsgBox("File Not Available", , "Error")
        End Try
    End Sub

    Sub btnCreateGame_Click(sender As Object, e As EventArgs) Handles btnCreateGame.Click
        'This is the button for the New Games class that does all the work. 

        'Check to make a game type is selected, set the game type string.
        If radAway.Checked Then
            blnGameSelected = True
            strGameType = "Away"
        End If
        If radHome.Checked Then
            blnGameSelected = True
            strGameType = "Home"
        End If

        'If statements to make sure everything has entries that is required so a game gets created with 4 values, date/gametype/number of seats/ticket cost
        If blnGameSelected = False Then
            MsgBox("Select a Game Type", , "Error")
        Else
            If cldGames.SelectionStart < cldGames.TodayDate Then
                MsgBox("Select Future Date", , "Error")
            Else
                If txtSeats.TextLength < 1 Then
                    MsgBox("Enter Seats For Game", , "Error")
                Else
                    If txtSetTicketCost.TextLength < 1 Then
                        MsgBox("Enter Ticket Value", , "Error")
                    Else
                        strTicketCost = txtSetTicketCost.Text
                        strSeats = txtSeats.Text
                        WriteToGames()
                    End If
                End If
            End If
        End If

    End Sub
    Private Sub mnuReturnToMain_Click(sender As Object, e As EventArgs) Handles mnuReturnToMain.Click
        Buttons.GoToMain()
    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        Buttons.GoToMain()
    End Sub

    Private Sub mnuSellTickets_Click(sender As Object, e As EventArgs) Handles mnuSellTickets.Click
        Buttons.GoToSellTickets()
    End Sub

    Private Sub btnSellTickets_Click(sender As Object, e As EventArgs) Handles btnSellTickets.Click
        Buttons.GoToSellTickets()
    End Sub

    Private Sub mnuReports_Click(sender As Object, e As EventArgs) Handles mnuReports.Click
        Buttons.GoToReports()
    End Sub

    Private Sub btnDailyReport_Click(sender As Object, e As EventArgs) Handles btnDailyReport.Click
        Buttons.GoToReports()
    End Sub
End Class