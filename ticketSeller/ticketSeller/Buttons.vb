Public Class Buttons
    Inherits frmNewGame


    Sub ClearScreen()
        'Clears the data entry fields
        txtSetTicketCost.Text = ""
        txtSeats.Text = ""
        radAway.Checked = False
        radHome.Checked = True
        cldGames.ShowToday = True
        txtSeats.Focus()

    End Sub


    Sub GoToMain() 'Goes back to the form listed below this line and hides the previous
        Dim frmMainScreen As New frmTicketSellerMain
        Hide()
        frmNewGame.ShowDialog()

    End Sub

    Sub GoToNewGame() 'Goes back to the form listed below this line and hides the previous
        Dim frmNewGameScreen As New frmNewGame
        Hide()
        frmNewGameScreen.ShowDialog()
    End Sub


    Sub GoToSellTickets() 'Goes back to the form listed below this line and hides the previous
        Dim frmSellTicketsScreen As New frmSellTickets
        Hide()
        frmSellTicketsScreen.ShowDialog()
    End Sub

    Sub GoToReports() 'Goes back to the form listed below this line and hides the previous
        Dim frmReportsScreen As New frmReports
        Hide()
        frmReportsScreen.ShowDialog()
    End Sub

    Public Function ValidateNumberOfTickets() As Boolean 'Not yet used, but ready to go
        'this function validates the number of tickets purchased
        Dim intTicketNumber As Integer
        Dim blnValidityCheck As Boolean = False
        Dim strTicketMessage As String = "Enter the number of tickets needed (1 - 100) "
        Dim strTicketMessageTitle As String = "Error"
        'Error check for the number of tickets to make sure invalid entry is caught
        Try
            intTicketNumber = Convert.ToInt32(frmSellTickets.txtNumberOfTickets.Text)
            If intTicketNumber >= 1 Then
                blnValidityCheck = True
            Else
                MsgBox(strTicketMessage, , strTicketMessageTitle)
                frmSellTickets.txtNumberOfTickets.Clear()
                frmSellTickets.txtNumberOfTickets.Focus()
            End If
        Catch Exception As FormatException
            MsgBox(strTicketMessage, , strTicketMessageTitle)
            frmSellTickets.txtNumberOfTickets.Clear()
            frmSellTickets.txtNumberOfTickets.Focus()
        Catch Exception As OverflowException
            MsgBox(strTicketMessage, , strTicketMessageTitle)
            frmSellTickets.txtNumberOfTickets.Clear()
            frmSellTickets.txtNumberOfTickets.Focus()
        Catch Exception As SystemException
            MsgBox(strTicketMessage, , strTicketMessageTitle)
            frmSellTickets.txtNumberOfTickets.Clear()
            frmSellTickets.txtNumberOfTickets.Focus()
        End Try
        Return blnValidityCheck
    End Function

    'failed attempt to get the reader to load into an array so I can make a clickable list in the sell tickets.
    'Sub ReadGames()

    '    'Variables for generating reports

    '    Dim intGameCount As Integer
    '    ' Dim arrGameDate(arrGameCount) As String
    '    Dim arrGameInfo(4, (intGameCount)) As String
    '    'Dim arrGameCost(arrGameCount) As String
    '    'Dim arrGameSeats(arrGameCount) As Integer

    '    'Intializes the reader
    '    Dim objReader As IO.StreamReader
    '    Dim strLocationAndNameOfFile As String = "f:\Games.txt"
    '    Dim intCount As Integer = 0
    '    Dim intFill As Integer
    '    Dim strFileError As String = "The file is not available. Please restart when the file is available."

    '    'If else statement to verify the file exists
    '    If IO.File.Exists(strLocationAndNameOfFile) Then
    '        objReader = IO.File.OpenText(strLocationAndNameOfFile)
    '        'read the file line by line until complete
    '        Do While objReader.Peek <> -1
    '            arrGameInfo(intGameCount, intCount) = objReader.ReadLine()
    '            ' arrGameCost(intCount) = Convert.ToString(objReader.ReadLine())
    '            intCount += 1
    '            intGameCount += 1
    '        Loop
    '        objReader.Close()

    '        'The listbox object is filled with inventory IDs
    '        For intFill = 0 To (arrGameDate.Length - 1)
    '            frmSellTickets.lstGameDates.Items.Add(arrGameDate(intFill))
    '        Next
    '    Else
    '        MsgBox(strFileError, , "Error")
    '        Close()
    '    End If
    'End Sub

    'Dim myCust As New List(Of String)
    'Dim myTrans As New List(Of String)


    'Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
    '    Try
    '        Dim reader As New Microsoft.VisualBasic.FileIO.TextFieldParser("F:/Games.txt")
    '        reader.TextFieldType = FileIO.FieldType.Delimited
    '        reader.SetDelimiters(",")

    '        While Not reader.EndOfData
    '            Dim Fields() As String = reader.ReadFields
    '            myCust.Add(Fields(0))
    '            myTrans.Add(Fields(1))
    '        End While
    '        reader.Close()
    '    Catch ex As Exception
    '        MessageBox.Show(Err.Description)
    '    End Try

    '    lstGameDates.DataSource = myCust
    'End Sub

    'Private Sub ListBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstGameDates.Click
    '    MessageBox.Show(myTrans(lstGameDates.SelectedIndex).ToString)
    'End Sub


End Class
