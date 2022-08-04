Public Class frmOrder
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ClearInputs()
        Me.Close()
    End Sub

    Private Sub btnPlaceOrder_Click(sender As Object, e As EventArgs) Handles btnPlaceOrder.Click
        If lstShoppingCart.Items.Count < 1 Then
            MsgBox("You have not added anything to the cart.", MsgBoxStyle.Information, "Error")
        ElseIf cboCustomerList.SelectedItem = Nothing Then
            MsgBox("Please select a customer!", MsgBoxStyle.Information, "Error")
        Else
            MsgBox("Order Placed!" & vbCrLf & "Showing Receipt . . .", MsgBoxStyle.Information, "Order Confirmation")
            frmReceiptSummary.ShowDialog()
            'Clear the order page
            cboCustomerList.SelectedItem = Nothing
            lstShoppingCart.Items.Clear()
            modShoppingCart.UpdateShoppingCartTotals()
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ' Search function to look for specific product
        If txtSearch.Text = "" Then
            MsgBox("Please enter a product name.", MsgBoxStyle.Information, "Error")
        Else
            SearchListBox(txtSearch.Text)
        End If
    End Sub

    Private Sub btnAddToCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click
        If lstProducts.SelectedItem = Nothing Then
            MsgBox("Please select a product.", MsgBoxStyle.Information, "Error")
        ElseIf txtProductQuantity.Text = "" Or txtProductQuantity.Text = "0" Then
            MsgBox("Please enter a valid product quantity. (0 is invalid)", MsgBoxStyle.Information, "Error")
        Else
            lstShoppingCart.Items.Add(lstProducts.SelectedItem.ToString + " | Quantity: " + txtProductQuantity.Text)
            txtProductQuantity.Text = ""
        End If
        ' Update the totals
        modShoppingCart.UpdateShoppingCartTotals()
    End Sub

    Private Sub btnEmptyCart_Click(sender As Object, e As EventArgs) Handles btnEmptyCart.Click
        ' Empty the shopping cart
        If lstShoppingCart.Items.Count < 1 Then
            MsgBox("Shopping cart is already empty.", MsgBoxStyle.Information, "Empty")
        Else
            lstShoppingCart.Items.Clear()
        End If
        ' Update the totals
        modShoppingCart.UpdateShoppingCartTotals()
    End Sub

    Private Sub frmOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Clear the old list of customers in combobox and load a new list
        cboCustomerList.Items.Clear()

        'TODO: This line of code loads data into the 'BikeStoreDataSet.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.BikeStoreDataSet.Customer)

        Dim myCustomer As Customer
        Dim myDataRow As DataRow
        cboCustomerList.Items.Add("FILL")
        For Each myDataRow In BikeStoreDataSet.Customer.Rows
            Dim repeatName As Boolean = False
            myCustomer = New Customer
            myCustomer.firstName = myDataRow("FirstName").ToString
            myCustomer.middleName = myDataRow("MiddleName").ToString
            myCustomer.lastName = myDataRow("LastName").ToString
            ' Loop through the combobox for duplicates
            For i = 0 To cboCustomerList.Items.Count - 1
                If cboCustomerList.Items(i).ToString = myCustomer.ToString Then
                    repeatName = True
                End If
            Next
            ' Add new item to combobox only if no duplicate name is found
            If repeatName = False Then
                cboCustomerList.Items.Add(myCustomer.ToString)
            End If
        Next
        cboCustomerList.Items.RemoveAt(0)
        cboCustomerList.Sorted = True


        ' Clear the old list of products in lixtbox and load a new list
        lstProducts.Items.Clear()

        'TODO: This line of code loads data into the 'BikeStoreDataSet.Product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me.BikeStoreDataSet.Product)

        Dim myProduct As Product
        Dim myDataRow2 As DataRow
        For Each myDataRow2 In BikeStoreDataSet.Product.Rows
            myProduct = New Product
            myProduct.productName = myDataRow2("Name").ToString
            myProduct.listPrice = CDbl(myDataRow2("ListPrice").ToString)
            lstProducts.Items.Add(myProduct.ToString)
        Next

        ' Load the totals
        modShoppingCart.UpdateShoppingCartTotals()
    End Sub

    Private Sub ClearInputs()
        ' Clear all inputs and values
        txtSearch.Text = ""
        txtProductQuantity.Text = ""
        lstProducts.Items.Clear()
        lstShoppingCart.Items.Clear()
        cboCustomerList.SelectedItem = Nothing
        lblSubtotal.Text = "0.00"
        lblShippingCost.Text = "5.00"
        lblTax.Text = "0.00"
        lblTotalCost.Text = "0.00"
    End Sub

    Private Sub txtProductQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProductQuantity.KeyPress
        ' Restrict input just for integer numbers
        Dim Ch As Char = e.KeyChar
        If Not Char.IsDigit(Ch) AndAlso Asc(Ch) <> 8 Then
            e.Handled = True
            'MessageBox.Show("You can only input number!")
        End If
    End Sub

    Private Sub btnRemoveFromCart_Click(sender As Object, e As EventArgs) Handles btnRemoveFromCart.Click
        'Remove selected item
        Dim intIndex As Integer
        intIndex = lstShoppingCart.SelectedIndex
        If intIndex <> -1 Then
            lstShoppingCart.Items.RemoveAt(intIndex)
        Else
            MsgBox("No item from cart is selected", MsgBoxStyle.Information, "Error")
        End If
        ' Update the totals
        modShoppingCart.UpdateShoppingCartTotals()
    End Sub

    Private Sub SearchListBox(ByVal searchTerm As String)
        ' Loop items
        Dim resultFound As Boolean
        For Each productItem As Object In lstProducts.Items
            If productItem.StartsWith(txtSearch.Text, StringComparison.CurrentCultureIgnoreCase) Then
                lstProducts.SelectedItem = productItem
                resultFound = True
                MsgBox("Item found and selected.", MsgBoxStyle.Information, "Found")
                Return
            Else
                resultFound = False
            End If
        Next
        If resultFound = False Then
            MsgBox("No results have found, try again.", MsgBoxStyle.Information, "Failed")
        End If
    End Sub
End Class