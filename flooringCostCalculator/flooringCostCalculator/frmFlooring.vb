'Program Name: Flooring Cost Calculator
'Justin Cook October 25 2018
'This program calculates the cost for flooring based on material and size.
'User enters the amount of square feet of flooring needed, if a non-positive number is entered an error is given
'It gives the option of Tile, Carpet, or hardwood; each with different material cost
'Program then provides estimate after multiplying cost of material by the square footage entered by user
Option Strict On

Public Class frmFlooringCost
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'This button calculates the cost of the square footage and material type
        'it gives an error message if square footage entered isn't a positive number
        Dim decFootage As Decimal 'holds the square footage
        Dim decCostPerSquareFoot As Decimal 'holds the cost per square footage based on material
        Dim decCostEstimate As Decimal 'final calculated value
        Dim decTileCost As Decimal = 4.49D
        Dim decCarpetCost As Decimal = 4.99D
        Dim DecHardwoodCost As Decimal = 7.49D
        If IsNumeric(txtFootage.Text) Then
            decFootage = Convert.ToDecimal(txtFootage.Text)
            'Is the square footage > 0
            If decFootage > 0 Then
                'determine the cost per square foot based on selected material
                If radTile.Checked Then
                    decCostPerSquareFoot = decTileCost
                ElseIf radCarpet.Checked Then
                    decCostPerSquareFoot = decCarpetCost
                ElseIf radHardwood.Checked Then
                    decCostPerSquareFoot = DecHardwoodCost
                End If
                'Calculate and display the cost estimate
                decCostEstimate = decFootage * decCostPerSquareFoot
                lblCostEstimate.Text = decCostEstimate.ToString("C")
            Else
                'Displays message if user entered a numberic value
                MsgBox("Enter the Square Footage of Flooring", , "Input Error")
                txtFootage.Text = ""
                txtFootage.Focus()
            End If
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'This sets the clear button to clear out the text fields, clears the radial buttons and set the tile as the default
        'And sets the focus on the square footage text box
        txtFootage.Clear()
        lblCostEstimate.Text = ""
        radTile.Checked = True
        radCarpet.Checked = False
        radHardwood.Checked = False
        txtFootage.Focus()


    End Sub

    Private Sub frmFlooringCost_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This starts the form with the focus on the square footage text box and clears the cost estimate
        txtFootage.Focus()
        lblCostEstimate.Text = ""

    End Sub
End Class
