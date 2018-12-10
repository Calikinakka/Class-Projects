'Program Name: City Bike Rentals
'Date: October 15th 2018


Option Strict On 'disables automatic data conversion

Public Class frmBikes
    Const _cdecPricePerBike As Decimal = 9.95D 'constant cost of the rental per bike per day

    Private Sub lblPerBike_Click(sender As Object, e As EventArgs) Handles lblCostHeading.Click

    End Sub

    Private Sub frmBikes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This handler starts when the program is loaded. It clears out the text box
        'and clears out the price label. It then puts focus on the text field for
        'number of bikes

        lblCostHeading.Text = _cdecPricePerBike.ToString("C") & " Per Bike Per 24 Hours"
        lblTotalCost.Text = ""
        txtNumberOfBikes.Focus()

    End Sub

    Private Sub picBikes_Click(sender As Object, e As EventArgs) Handles picBikes.Click

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'This button calculates the number of bikes multipled by the price
        'It takes the variables str and int NumberOfBikes, sets the value from the string input as an integer
        'And multiples it by the constant 9.95D stated under the _cdecPricePerBike

        Dim strNumberOfBikes As String 'variable to obtain the number of bike rentals user entered as a string
        Dim intNumberOfBikes As Integer 'is the number of bike rentals user entered as an integer after being converted
        Dim decTotalCost As Decimal 'variable to set the cost for number of rentals

        strNumberOfBikes = txtNumberOfBikes.Text 'sets the string variable to the text input
        intNumberOfBikes = Convert.ToInt32(strNumberOfBikes) 'Converts the string value entered into an integer
        decTotalCost = intNumberOfBikes * _cdecPricePerBike 'Sets the total cost

        lblTotalCost.Text = decTotalCost.ToString("C") 'updates the value listed in the total cost label to the new value

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Button resets the values to their defaults to enable new entry and clear previous values from the screen

        txtNumberOfBikes.Clear()
        lblTotalCost.Text = ""
        txtNumberOfBikes.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Closes the windows and closes the program.
        Close()

    End Sub

    Private Sub lblTotalCost_Click(sender As Object, e As EventArgs) Handles lblTotalCost.Click

    End Sub
End Class
