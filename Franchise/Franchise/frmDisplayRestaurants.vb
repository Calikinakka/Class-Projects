Public Class frmDisplayRestaurants
    Private Sub frmDisplayRestaurants_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This is the secondary form that displays the sorted items
        Dim intFill As Integer
        'sorts the _strInventoryItems array
        Array.Sort(frmFranchiseInvestment._strRestaurant, frmFranchiseInvestment._intRestaurantInvestCost)
        'displays the inventory items array
        'takes the variables from the main form and runs them here to display the data from the text file with the name and cost. 
        For intFill = 0 To frmFranchiseInvestment._strInvestID.Length - 1
            lstRestaurantAndCost.Items.Add(frmFranchiseInvestment._strRestaurant(intFill) & " Investment Cost: $" & frmFranchiseInvestment._intRestaurantInvestCost(intFill))
        Next

    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click

        'this sub opens the first form
        Dim frmFirst As New frmFranchiseInvestment
        Hide()
        frmFirst.ShowDialog()

    End Sub
End Class

'This took me days to figure out how to do this in the second form. I feel very validated now.