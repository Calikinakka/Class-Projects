Public Class frmSellTickets

    Public mainArray(intSizeOfArray) As String
    Public Shared intSizeOfArray As Integer = 3
    Public Shared strGameDate(intSizeOfArray) As String
    Public Shared strGameType(intSizeOfArray) As String
    Public Shared intGameSeats(intSizeOfArray) As String
    Public Shared decGamePrice(intSizeOfArray) As String

    Private Sub frmSellTickets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objReader As IO.StreamReader
        Dim strLocationAndNameOfFile As String = "f:\Games.txt"
        Dim intCount As Integer = 0
        ' Dim intFill As Integer
        Dim strFileError As String = "The file is not available. Please restart when the file is available."
        'If else statement to verify the file exists
        Try
            If IO.File.Exists(strLocationAndNameOfFile) Then
                objReader = IO.File.OpenText(strLocationAndNameOfFile)
                'read the file line by line until complete
                Do While objReader.Peek <> -1
                    Dim fields() As String = objReader.ReadLine().Split(","c)
                    strGameDate(intCount) = fields(0)
                    strGameType(intCount) = fields(1)
                    intGameSeats(intCount) = fields(2)
                    decGamePrice(intCount) = fields(3)
                    intCount = +1
                Loop
                objReader.Close()

                'The listbox object is filled with inventory IDs
                For intFill = 0 To UBound(mainArray)
                    lstGameDates.Items.Add(strGameDate(intFill))
                Next

            Else
                MsgBox(strFileError, , "Error")
                Close()
            End If
        Catch Exception As FormatException
            MsgBox("error format", ,)
        Catch Exception As OverflowException
            MsgBox("error overflow", ,)
        Catch Exception As SystemException
            MsgBox("error system", ,)

        End Try


    End Sub

    'file is set as: Date/Type/Seats/Price






    Private Sub btnClearSell_Click(sender As Object, e As EventArgs)
        'This clear button resets the information in all the text boxes and makes the form ready for use. 

        lblDiscountIs.Text = "Discount is: "
        lblDiscountIs.Visible = False
        lblAmountDue.Text = "Amount Due: "
        txtNumberOfTickets.Text = ""
        lblAvailableSeats.Text = "Available Seats: "
        lstGameDates.Focus()

    End Sub

    Private Sub btnMainMenuSell_Click(sender As Object, e As EventArgs) Handles btnMainMenuSell.Click
        Buttons.GoToMain()
    End Sub

    Private Sub mnuReturnToMain_Click(sender As Object, e As EventArgs) Handles mnuReturnToMain.Click
        Buttons.GoToMain()
    End Sub

    Private Sub btnCreateGameSell_Click(sender As Object, e As EventArgs) Handles btnCreateGameSell.Click
        Buttons.GoToNewGame()
    End Sub

    Private Sub mnuCreateGame_Click(sender As Object, e As EventArgs) Handles mnuCreateGame.Click
        Buttons.GoToNewGame()
    End Sub

    Private Sub mnuReports_Click(sender As Object, e As EventArgs) Handles mnuReports.Click
        Buttons.GoToReports()
    End Sub

    Private Sub btnDailyReportSell_Click(sender As Object, e As EventArgs) Handles btnDailyReportSell.Click
        Buttons.GoToReports()
    End Sub

    Private Sub btnSellTickets_Click(sender As Object, e As EventArgs) Handles btnSellTickets.Click


        Buttons.ValidateNumberOfTickets()

    End Sub

    Public Sub lstGameDates_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstGameDates.SelectedIndexChanged

    End Sub
End Class