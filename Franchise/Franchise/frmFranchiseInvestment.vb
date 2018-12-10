'Program Name: Franchise Invenstments
'Justin Cook
'November 16 2018
'This program loads the investments.txt from a removable drive into the listbox. the user is then able to select
'a restaurant from the list and see the initial investment cost and the average investment cost.

Option Strict On
Public Class frmFranchiseInvestment
    'class level variables and arrays
    Public _strInvestID(_intSizeOfArray) As String
    Public Shared _intSizeOfArray As Integer = 10
    Public Shared _strRestaurant(_intSizeOfArray) As String
    Public Shared _intRestaurantInvestCost(_intSizeOfArray) As Integer

    Private Sub frmFranchiseInvestment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'loads the franchise.txt file and fills the listbox with the contents. The value is stored in the _DecRestartuantInvestCost array

        'Intializes the reader
        Dim objReader As IO.StreamReader
        Dim strLocationAndNameOfFile As String = "f:\franchise.txt"
        Dim intCount As Integer = 0
        Dim intFill As Integer
        Dim strFileError As String = "The file is not available. Please restart when the file is available."

        'If else statement to verify the file exists
        If IO.File.Exists(strLocationAndNameOfFile) Then
            objReader = IO.File.OpenText(strLocationAndNameOfFile)
            'read the file line by line until complete
            Do While objReader.Peek <> -1
                _strRestaurant(intCount) = objReader.ReadLine()
                _intRestaurantInvestCost(intCount) = Convert.ToInt32(objReader.ReadLine())
                intCount += 1
            Loop
            objReader.Close()

            'The listbox object is filled with inventory IDs
            For intFill = 0 To (_strInvestID.Length - 1)
                lstFranchise.Items.Add(_strRestaurant(intFill))
            Next
        Else
            MsgBox(strFileError, , "Error")
            Close()
        End If
    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        'Calculates the average cost of the investments and sets the remaining field visible.
        Dim intSelectedRestaurant As Integer
        Dim strMissingSelection As String = "Missing Selection"
        'For loop to make sure the information is valid and a selection is made.
        If lstFranchise.SelectedIndex >= 0 Then
            intSelectedRestaurant = lstFranchise.SelectedIndex
            ComputeInvestmentOption(intSelectedRestaurant)
        Else
            MsgBox("Select a Franchise for Investment Information", , "Error")
        End If
    End Sub

    Private Sub ComputeInvestmentOption(ByRef intSelectedRestaurant As Integer)
        'This sub procedure computes the average of the investments and displays the amount.
        Dim intFranchiseCount As Integer
        Dim decFranchiseTotal As Decimal
        Dim decFranchiseAverage As Decimal
        'Sets the text display for the results.
        lblSelected.Text = "The Selected Restaurant's Investment Cost of " & _intRestaurantInvestCost(intSelectedRestaurant).ToString("C")
        lblSelected.Visible = True
        lblAverageCost.Visible = True
        lblAverageInvestment.Visible = True
        'finds the average by taking the total of the costs and divides but the number of restaurants in the text file.
        For intFranchiseCount = 0 To (_intRestaurantInvestCost.Length - 1)
            decFranchiseTotal += _intRestaurantInvestCost(intFranchiseCount)
        Next
        decFranchiseAverage = decFranchiseTotal / _intSizeOfArray
        lblAverageCost.Text = decFranchiseAverage.ToString("c")
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        'this menu option exits the programs
        Application.Exit()

    End Sub

    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        'The mnuClear clears all entries and resets the form for new use
        lstFranchise.SelectedIndex = -1
        lblSelected.Visible = False
        lblAverageCost.Visible = False
        lblAverageInvestment.Visible = False


    End Sub

    Private Sub mnuDisplay_Click(sender As Object, e As EventArgs) Handles mnuDisplay.Click
        'the mnuDisplay  click event creates and instance of the frmDisplayInventory
        Dim frmSecond As New frmDisplayRestaurants

        'hides this form and shows the Display Inventory form
        Hide()
        frmSecond.ShowDialog()

    End Sub
End Class
