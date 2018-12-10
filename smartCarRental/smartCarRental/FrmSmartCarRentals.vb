'Program Name: Smart Car Rental
'October 20 2018
'A basic program to calculate cost of renting a smart car
'For X * $29.99 days with a cost of Y * $0.39 miles

Option Strict On 'disables automatic data conversion

Public Class frmRentASmartCar

    Const _cdecPricePerDay As Decimal = 29.99D 'constant cost of per day rental
    Const _cdecPricePerMile As Decimal = 0.39D 'constant cost of per mile rental

    Private Sub txtMiles_TextChanged(sender As Object, e As EventArgs) Handles txtMiles.TextChanged

    End Sub

    Private Sub frmRentASmartCar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTotalCost.Text = "" 'starts the program with a clear total cost field
        txtDays.Focus() 'start the program with focus on the total days field

    End Sub

    Private Sub btnDisplayFare_Click(sender As Object, e As EventArgs) Handles btnDisplayFare.Click
        'This button calculates and displays the total cost of renting the smart car
        'it takes the number of days entered, multiplies it by the cost per day
        'multiples the number of miles driven by cost per miles
        'adds the two totals together

        Dim strNumberOfDays As String 'Variable for the number of days the car is rented
        Dim intNumberOfDays As Integer 'Is the number of days user entered in text box
        Dim strNumberOfMiles As String 'Variable for the number of miles the rented car was driven
        Dim intNumberOfMiles As Integer 'Number of miles user entered
        Dim decTotalCost As Decimal 'Variable for the total cost days + miles

        strNumberOfDays = txtDays.Text 'sets the number of days to the string input to the text
        strNumberOfMiles = txtMiles.Text 'set the number of miles to the string input
        intNumberOfDays = Convert.ToInt32(strNumberOfDays) 'Converts the string input to an integer
        intNumberOfMiles = Convert.ToInt32(strNumberOfMiles) 'Converts the string input to an integer

        decTotalCost = intNumberOfDays * _cdecPricePerDay + intNumberOfMiles * _cdecPricePerMile

        lblTotalCost.Text = decTotalCost.ToString("C") 'sets the decimal value to string in the text field

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clears all entry fields and put the focus back onto the number of days for data entry
        txtDays.Clear() 'clears the field
        txtMiles.Clear() 'clears the field
        lblTotalCost.Text = "" 'clears the field
        txtDays.Focus() 'sets the cursor into the days text box
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Closes the application and stops it from running
        Close()
    End Sub

    Private Sub lblHeadingTotalCost_Click(sender As Object, e As EventArgs) Handles lblHeadingTotalCost.Click

    End Sub

    Private Sub txtDays_TextChanged(sender As Object, e As EventArgs) Handles txtDays.TextChanged

    End Sub
End Class
