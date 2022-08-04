Public Class frmReceiptSummary
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmReceiptSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstSummary.Items.Add("- - - - -  Bike Store Receipt  - - - - -")
        lstSummary.Items.Add("Dear customer, thank you for your purchase!")
        lstSummary.Items.Add(" ")
        lstSummary.Items.Add("Customer Name: " + frmOrder.cboCustomerList.SelectedItem.ToString)
        lstSummary.Items.Add("Purchase Date: " + Date.Now.ToString)
        lstSummary.Items.Add(" ")
        lstSummary.Items.Add("--- List of Items ------------------------------")
        lstSummary.Items.Add(" ")
        For i = 0 To frmOrder.lstShoppingCart.Items.Count - 1
            lstSummary.Items.Add(frmOrder.lstShoppingCart.Items(i).ToString)
        Next
        lstSummary.Items.Add(" ")
        lstSummary.Items.Add("--- End of List --------------------------------")
        lstSummary.Items.Add(" ")
        lstSummary.Items.Add("Subtotal:  " + frmOrder.lblSubtotal.Text)
        lstSummary.Items.Add("Shipping Fee:  " + frmOrder.lblShippingCost.Text)
        lstSummary.Items.Add("Tax (7%):  " + frmOrder.lblTax.Text)
        lstSummary.Items.Add("--------------------")
        lstSummary.Items.Add("Total: $" + frmOrder.lblTotalCost.Text)
    End Sub

    Private Sub frmReceiptSummary_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        lstSummary.Items.Clear()
    End Sub
End Class