Module modShoppingCart
    ' Login credentials
    Public Const LOGIN_PASSWORD As String = "admin"
    Public Const LOGIN_USERNAME As String = "admin"

    ' Calculation values
    Public Const dblSTATE_SALES_TAX_RATE As Double = 0.07
    Public Const dblSHIPPING_FEE As Double = 4.55
    Public Sub UpdateShoppingCartTotals()
        Dim dblSubtotal As Double = 0.00
        Dim dblTax As Double = 0.00
        Dim dblTotal As Double = 0.00
        Dim dblItemPrice As Double = 0.00

        Dim dblListPrice As Double = 0.0
        Dim intQuantity As Integer = 0

        If frmOrder.lstShoppingCart.Items.Count < 1 Then
            frmOrder.lblSubtotal.Text = CStr(dblSubtotal)
            frmOrder.lblShippingCost.Text = "0"
            frmOrder.lblTax.Text = CStr(dblTax)
            frmOrder.lblTotalCost.Text = CStr(dblTotal)
        Else
            For i = 0 To frmOrder.lstShoppingCart.Items.Count - 1
                Dim strCartItem As String = frmOrder.lstShoppingCart.Items(i).ToString
                Dim strArray() As String = Split(strCartItem, "|")

                dblListPrice = CDbl(Replace(strArray(1), "$", "").Trim)
                intQuantity = CInt(Replace(strArray(2), "Quantity:", "").Trim)
                dblItemPrice = dblListPrice * intQuantity
                dblSubtotal += dblItemPrice
            Next

            ' Calculate the toals
            dblTax = Math.Round(dblSubtotal * dblSTATE_SALES_TAX_RATE, 2)
            dblTotal = dblSubtotal + dblTax + dblSHIPPING_FEE
            ' Display the Totals
            frmOrder.lblSubtotal.Text = CStr(dblSubtotal)
            frmOrder.lblShippingCost.Text = CStr(dblSHIPPING_FEE)
            frmOrder.lblTax.Text = CStr(dblTax)
            frmOrder.lblTotalCost.Text = CStr(dblTotal)
        End If
    End Sub
End Module
