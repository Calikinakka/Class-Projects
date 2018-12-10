'Program Name: Fitness Challenge
'November 2, 2018
'This program takes the teams entered weight, displays it and then averages the weight loss

Option Strict On


Public Class frmFitnessChallenge
    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        'closes the application
        Close()

    End Sub

    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        'clears the entered information and hides the average weight label.
        'It also enables the weight loss button
        lstWeightLoss.Items.Clear()
        lblAverageLoss.Visible = False
        btnWeightLoss.Enabled = True


    End Sub

    Private Sub btnWeightLoss_Click(sender As Object, e As EventArgs) Handles btnWeightLoss.Click
        'the WeightLoss button accepts the entered weight loss, displays them and averages them from
        'the number of entries, giving the team's average weight loss for that week.

        Dim strWeightLoss As String
        Dim decWeightLoss As Decimal
        Dim decAverageLoss As Decimal
        Dim decTotalWeightLoss As Decimal = 0D
        Dim strInputMessage As String = "Enter the weight loss for team member #"
        Dim strInputHeading As String = "Weight loss"
        Dim strNormalMessage As String = "Enter the weight loss for team member #"
        Dim strNonNumericError As String = "Error - Enter a number for the weight loss for team member #"
        Dim strNegativeError As String = "Error - Enter a positive number for the weight loss for team member #"

        Dim strCancelClicked As String = ""
        Dim intMaxNumberOfEntries As Integer = 8
        Dim intNumberOfEntries As Integer = 1

        'The loop that allows data entry by the user. it stops after 8 entries are made or until the user hits cancel or closes the window.
        strWeightLoss = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, " ")
        Do Until intNumberOfEntries > intMaxNumberOfEntries Or strWeightLoss = strCancelClicked
            If IsNumeric(strWeightLoss) Then
                decWeightLoss = Convert.ToDecimal(strWeightLoss)
                If decWeightLoss > 0 Then
                    lstWeightLoss.Items.Add(decWeightLoss)
                    decTotalWeightLoss += decWeightLoss
                    intNumberOfEntries += 1
                    strInputMessage = strNormalMessage
                Else
                    strInputMessage = strNegativeError
                End If
            Else
                strInputMessage = strNonNumericError
            End If
            If intNumberOfEntries <= intMaxNumberOfEntries Then
                strWeightLoss = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, " ")
            End If
        Loop
        'does the calculation and displays the results for the user
        If intNumberOfEntries > 1 Then
            lblAverageLoss.Visible = True
            decAverageLoss = decTotalWeightLoss / (intNumberOfEntries - 1)
            lblAverageLoss.Text = "Average weight loss for the team is " & decAverageLoss.ToString("f1") & "lbs"
        Else
            MsgBox("No weight loss value entered")
        End If
        'Removes the weight loss button
        btnWeightLoss.Enabled = False

    End Sub
End Class
