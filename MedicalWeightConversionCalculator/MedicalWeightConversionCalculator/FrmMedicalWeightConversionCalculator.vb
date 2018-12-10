'program name: Medical Weight Conversion Calculator
'Justin Cook
'This program takes the entered weight and converts it to pounds or kilograms, depending on user's need.
'User enters the total weight up to 3 decimal places, selects the radial conversion needed and clicks display weight
'The entered data is then converted from the entered weight into the new value.



Public Class FrmMedicalWeightConversionCalculator
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        'this button calculates the conversion of the entered weight into the other measurement
        'it will give an error if an invalid entry is received
        Dim decStartWeight As Decimal 'entered weight after being converted to decimal from string
        Dim decPoundToKilogram As Decimal = 2.2046 'Divide
        Dim decKilogramToPound As Decimal = 2.2046 'Multiply
        Dim decConvertedWeight As Decimal 'converted weight
        Dim decConvertedRemainder As Decimal 'remainder of the converted weight
        Dim decNewWeight As Decimal 'combines the dividend and mod


        If IsNumeric(txtWeight.Text) Then
            decStartWeight = Convert.ToDecimal(txtWeight.Text) 'making sure there is a number entered
            If decStartWeight > 0 Then 'checks to make sure a positive number has been entered
                If radPounds.Checked Then
                    decConvertedWeight = decStartWeight \ decPoundToKilogram 'divides the entered weight by the variable's set amount
                    decConvertedRemainder = decStartWeight Mod decPoundToKilogram 'obtains the remainder of the conversion
                    decNewWeight = decConvertedWeight + decConvertedRemainder 'concatonates the dividend and remainder
                    lblConvertedWeight.Text = decNewWeight.ToString("N3") + " Kilograms." '
                ElseIf radKilograms.Checked Then
                    decNewWeight = decStartWeight * decKilogramToPound
                    lblConvertedWeight.Text = decNewWeight.ToString("N3") + " Pounds."
                End If
            Else
                'Message box that reminds the user to enter a valid weight if a non-integer is entered
                MsgBox("Enter the patients weight", , "Input Error")
                txtWeight.Text = "" 'clears the text box
                txtWeight.Focus() ' set the text box as the focus
            End If
        Else
            'Message box that reminds the user to enter a valid weight if no entry is made
            MsgBox("Enter the patients weight", , "Input Error")
            txtWeight.Text = "" 'clears the text box
            txtWeight.Focus() 'sets the text box as the focus
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'This sets the clear button to clear out the text fields, clears the radial buttons and set the pound as the default
        'And sets the focus on the weight text box
        txtWeight.Clear()
        lblConvertedWeight.Text = ""
        radPounds.Checked = True
        radKilograms.Checked = False
        txtWeight.Focus()
    End Sub

    Private Sub FrmMedicalWeightConversionCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'This starts the form with the focus on the weight text box and clears the converted weight
        txtWeight.Focus()
        radPounds.Checked = True
        lblConvertedWeight.Text = ""
    End Sub
End Class
