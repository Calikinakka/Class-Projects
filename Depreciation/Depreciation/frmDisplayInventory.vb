Public Class frmDisplayInventory
    Private Sub frmDisplayInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This is the secondary form that displays the sorted items
        Dim strItem As String
        'sorts the _strInventoryItems array
        Array.Sort(frmDepreciation._strInventoryItem)

        'displays the inventory items array
        For Each strItem In frmDepreciation._strInventoryItem
            lstDisplay.Items.Add(strItem)
        Next
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        'this sub opens the first form

        Dim frmFirst As New frmDepreciation
        Hide()
        frmFirst.ShowDialog()

    End Sub
End Class