<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrder
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblLabel1 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lstProducts = New System.Windows.Forms.ListBox()
        Me.lblLabel3 = New System.Windows.Forms.Label()
        Me.cboCustomerList = New System.Windows.Forms.ComboBox()
        Me.lblLabel4 = New System.Windows.Forms.Label()
        Me.txtProductQuantity = New System.Windows.Forms.TextBox()
        Me.btnAddToCart = New System.Windows.Forms.Button()
        Me.grpProductList = New System.Windows.Forms.GroupBox()
        Me.grpShoppingCart = New System.Windows.Forms.GroupBox()
        Me.lstShoppingCart = New System.Windows.Forms.ListBox()
        Me.grpOrderDetails = New System.Windows.Forms.GroupBox()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblShippingCost = New System.Windows.Forms.Label()
        Me.lblLabel7 = New System.Windows.Forms.Label()
        Me.lblLabel6 = New System.Windows.Forms.Label()
        Me.lblLabel5 = New System.Windows.Forms.Label()
        Me.lblLabel2 = New System.Windows.Forms.Label()
        Me.btnPlaceOrder = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnEmptyCart = New System.Windows.Forms.Button()
        Me.btnRemoveFromCart = New System.Windows.Forms.Button()
        Me.BikeStoreDataSet = New BikeStoreUI.BikeStoreDataSet()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerTableAdapter = New BikeStoreUI.BikeStoreDataSetTableAdapters.CustomerTableAdapter()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductTableAdapter = New BikeStoreUI.BikeStoreDataSetTableAdapters.ProductTableAdapter()
        Me.grpProductList.SuspendLayout()
        Me.grpShoppingCart.SuspendLayout()
        Me.grpOrderDetails.SuspendLayout()
        CType(Me.BikeStoreDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblLabel1
        '
        Me.lblLabel1.AutoSize = True
        Me.lblLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblLabel1.Location = New System.Drawing.Point(28, 34)
        Me.lblLabel1.Name = "lblLabel1"
        Me.lblLabel1.Size = New System.Drawing.Size(146, 20)
        Me.lblLabel1.TabIndex = 0
        Me.lblLabel1.Text = "Search for Product:"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(32, 57)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(268, 28)
        Me.txtSearch.TabIndex = 1
        '
        'btnSearch
        '
        Me.btnSearch.AutoSize = True
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(306, 57)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(76, 28)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lstProducts
        '
        Me.lstProducts.FormattingEnabled = True
        Me.lstProducts.HorizontalScrollbar = True
        Me.lstProducts.ItemHeight = 15
        Me.lstProducts.Location = New System.Drawing.Point(6, 19)
        Me.lstProducts.Name = "lstProducts"
        Me.lstProducts.Size = New System.Drawing.Size(260, 409)
        Me.lstProducts.TabIndex = 4
        '
        'lblLabel3
        '
        Me.lblLabel3.AutoSize = True
        Me.lblLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblLabel3.Location = New System.Drawing.Point(742, 359)
        Me.lblLabel3.Name = "lblLabel3"
        Me.lblLabel3.Size = New System.Drawing.Size(158, 20)
        Me.lblLabel3.TabIndex = 5
        Me.lblLabel3.Text = "Select the Customer:"
        '
        'cboCustomerList
        '
        Me.cboCustomerList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCustomerList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.cboCustomerList.FormattingEnabled = True
        Me.cboCustomerList.Location = New System.Drawing.Point(746, 383)
        Me.cboCustomerList.Name = "cboCustomerList"
        Me.cboCustomerList.Size = New System.Drawing.Size(207, 30)
        Me.cboCustomerList.TabIndex = 6
        '
        'lblLabel4
        '
        Me.lblLabel4.AutoSize = True
        Me.lblLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblLabel4.Location = New System.Drawing.Point(310, 124)
        Me.lblLabel4.Name = "lblLabel4"
        Me.lblLabel4.Size = New System.Drawing.Size(142, 20)
        Me.lblLabel4.TabIndex = 7
        Me.lblLabel4.Text = "Enter the Quantity:"
        '
        'txtProductQuantity
        '
        Me.txtProductQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtProductQuantity.Location = New System.Drawing.Point(314, 147)
        Me.txtProductQuantity.MaxLength = 5
        Me.txtProductQuantity.Name = "txtProductQuantity"
        Me.txtProductQuantity.Size = New System.Drawing.Size(138, 28)
        Me.txtProductQuantity.TabIndex = 8
        '
        'btnAddToCart
        '
        Me.btnAddToCart.AutoSize = True
        Me.btnAddToCart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnAddToCart.Location = New System.Drawing.Point(314, 181)
        Me.btnAddToCart.Name = "btnAddToCart"
        Me.btnAddToCart.Size = New System.Drawing.Size(138, 28)
        Me.btnAddToCart.TabIndex = 9
        Me.btnAddToCart.Text = "Add to Cart"
        Me.btnAddToCart.UseVisualStyleBackColor = True
        '
        'grpProductList
        '
        Me.grpProductList.Controls.Add(Me.lstProducts)
        Me.grpProductList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.grpProductList.Location = New System.Drawing.Point(32, 105)
        Me.grpProductList.Name = "grpProductList"
        Me.grpProductList.Size = New System.Drawing.Size(272, 444)
        Me.grpProductList.TabIndex = 12
        Me.grpProductList.TabStop = False
        Me.grpProductList.Text = "List of Products"
        '
        'grpShoppingCart
        '
        Me.grpShoppingCart.Controls.Add(Me.lstShoppingCart)
        Me.grpShoppingCart.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.grpShoppingCart.Location = New System.Drawing.Point(464, 105)
        Me.grpShoppingCart.Name = "grpShoppingCart"
        Me.grpShoppingCart.Size = New System.Drawing.Size(272, 444)
        Me.grpShoppingCart.TabIndex = 13
        Me.grpShoppingCart.TabStop = False
        Me.grpShoppingCart.Text = "Shopping Cart"
        '
        'lstShoppingCart
        '
        Me.lstShoppingCart.FormattingEnabled = True
        Me.lstShoppingCart.HorizontalScrollbar = True
        Me.lstShoppingCart.ItemHeight = 15
        Me.lstShoppingCart.Location = New System.Drawing.Point(6, 19)
        Me.lstShoppingCart.Name = "lstShoppingCart"
        Me.lstShoppingCart.Size = New System.Drawing.Size(260, 409)
        Me.lstShoppingCart.TabIndex = 4
        '
        'grpOrderDetails
        '
        Me.grpOrderDetails.Controls.Add(Me.lblTotalCost)
        Me.grpOrderDetails.Controls.Add(Me.lblSubtotal)
        Me.grpOrderDetails.Controls.Add(Me.lblTax)
        Me.grpOrderDetails.Controls.Add(Me.lblShippingCost)
        Me.grpOrderDetails.Controls.Add(Me.lblLabel7)
        Me.grpOrderDetails.Controls.Add(Me.lblLabel6)
        Me.grpOrderDetails.Controls.Add(Me.lblLabel5)
        Me.grpOrderDetails.Controls.Add(Me.lblLabel2)
        Me.grpOrderDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.grpOrderDetails.Location = New System.Drawing.Point(746, 105)
        Me.grpOrderDetails.Name = "grpOrderDetails"
        Me.grpOrderDetails.Size = New System.Drawing.Size(251, 220)
        Me.grpOrderDetails.TabIndex = 14
        Me.grpOrderDetails.TabStop = False
        Me.grpOrderDetails.Text = "Order Details"
        '
        'lblTotalCost
        '
        Me.lblTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(97, 160)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(131, 22)
        Me.lblTotalCost.TabIndex = 15
        Me.lblTotalCost.Text = "0.00"
        Me.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSubtotal
        '
        Me.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblSubtotal.Location = New System.Drawing.Point(97, 47)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(131, 22)
        Me.lblSubtotal.TabIndex = 6
        Me.lblSubtotal.Text = "0.00"
        Me.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTax
        '
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblTax.Location = New System.Drawing.Point(97, 109)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(131, 22)
        Me.lblTax.TabIndex = 5
        Me.lblTax.Text = "0.00"
        Me.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblShippingCost
        '
        Me.lblShippingCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblShippingCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblShippingCost.Location = New System.Drawing.Point(97, 80)
        Me.lblShippingCost.Name = "lblShippingCost"
        Me.lblShippingCost.Size = New System.Drawing.Size(131, 22)
        Me.lblShippingCost.TabIndex = 4
        Me.lblShippingCost.Text = "0.00"
        Me.lblShippingCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLabel7
        '
        Me.lblLabel7.AutoSize = True
        Me.lblLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblLabel7.Location = New System.Drawing.Point(16, 161)
        Me.lblLabel7.Name = "lblLabel7"
        Me.lblLabel7.Size = New System.Drawing.Size(77, 20)
        Me.lblLabel7.TabIndex = 3
        Me.lblLabel7.Text = "Total:     $"
        '
        'lblLabel6
        '
        Me.lblLabel6.AutoSize = True
        Me.lblLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblLabel6.Location = New System.Drawing.Point(16, 110)
        Me.lblLabel6.Name = "lblLabel6"
        Me.lblLabel6.Size = New System.Drawing.Size(75, 20)
        Me.lblLabel6.TabIndex = 2
        Me.lblLabel6.Text = "Tax (7%):"
        '
        'lblLabel5
        '
        Me.lblLabel5.AutoSize = True
        Me.lblLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblLabel5.Location = New System.Drawing.Point(16, 80)
        Me.lblLabel5.Name = "lblLabel5"
        Me.lblLabel5.Size = New System.Drawing.Size(75, 20)
        Me.lblLabel5.TabIndex = 1
        Me.lblLabel5.Text = "Shipping:"
        '
        'lblLabel2
        '
        Me.lblLabel2.AutoSize = True
        Me.lblLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblLabel2.Location = New System.Drawing.Point(16, 50)
        Me.lblLabel2.Name = "lblLabel2"
        Me.lblLabel2.Size = New System.Drawing.Size(73, 20)
        Me.lblLabel2.TabIndex = 0
        Me.lblLabel2.Text = "Subtotal:"
        '
        'btnPlaceOrder
        '
        Me.btnPlaceOrder.AutoSize = True
        Me.btnPlaceOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnPlaceOrder.Location = New System.Drawing.Point(746, 442)
        Me.btnPlaceOrder.Name = "btnPlaceOrder"
        Me.btnPlaceOrder.Size = New System.Drawing.Size(207, 30)
        Me.btnPlaceOrder.TabIndex = 15
        Me.btnPlaceOrder.Text = "Place Order"
        Me.btnPlaceOrder.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.AutoSize = True
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnExit.Location = New System.Drawing.Point(746, 501)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(207, 30)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnEmptyCart
        '
        Me.btnEmptyCart.AutoSize = True
        Me.btnEmptyCart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnEmptyCart.Location = New System.Drawing.Point(314, 446)
        Me.btnEmptyCart.Name = "btnEmptyCart"
        Me.btnEmptyCart.Size = New System.Drawing.Size(138, 28)
        Me.btnEmptyCart.TabIndex = 17
        Me.btnEmptyCart.Text = "Empty Cart"
        Me.btnEmptyCart.UseVisualStyleBackColor = True
        '
        'btnRemoveFromCart
        '
        Me.btnRemoveFromCart.AutoSize = True
        Me.btnRemoveFromCart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnRemoveFromCart.Location = New System.Drawing.Point(314, 215)
        Me.btnRemoveFromCart.Name = "btnRemoveFromCart"
        Me.btnRemoveFromCart.Size = New System.Drawing.Size(138, 28)
        Me.btnRemoveFromCart.TabIndex = 18
        Me.btnRemoveFromCart.Text = "Remove"
        Me.btnRemoveFromCart.UseVisualStyleBackColor = True
        '
        'BikeStoreDataSet
        '
        Me.BikeStoreDataSet.DataSetName = "BikeStoreDataSet"
        Me.BikeStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me.BikeStoreDataSet
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataMember = "Product"
        Me.ProductBindingSource.DataSource = Me.BikeStoreDataSet
        '
        'ProductTableAdapter
        '
        Me.ProductTableAdapter.ClearBeforeFill = True
        '
        'frmOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1027, 586)
        Me.Controls.Add(Me.btnRemoveFromCart)
        Me.Controls.Add(Me.btnEmptyCart)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPlaceOrder)
        Me.Controls.Add(Me.grpOrderDetails)
        Me.Controls.Add(Me.grpShoppingCart)
        Me.Controls.Add(Me.grpProductList)
        Me.Controls.Add(Me.btnAddToCart)
        Me.Controls.Add(Me.txtProductQuantity)
        Me.Controls.Add(Me.lblLabel4)
        Me.Controls.Add(Me.cboCustomerList)
        Me.Controls.Add(Me.lblLabel3)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lblLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Order"
        Me.grpProductList.ResumeLayout(False)
        Me.grpShoppingCart.ResumeLayout(False)
        Me.grpOrderDetails.ResumeLayout(False)
        Me.grpOrderDetails.PerformLayout()
        CType(Me.BikeStoreDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLabel1 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents lstProducts As ListBox
    Friend WithEvents lblLabel3 As Label
    Friend WithEvents cboCustomerList As ComboBox
    Friend WithEvents lblLabel4 As Label
    Friend WithEvents txtProductQuantity As TextBox
    Friend WithEvents btnAddToCart As Button
    Friend WithEvents grpProductList As GroupBox
    Friend WithEvents grpShoppingCart As GroupBox
    Friend WithEvents lstShoppingCart As ListBox
    Friend WithEvents grpOrderDetails As GroupBox
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblShippingCost As Label
    Friend WithEvents lblLabel7 As Label
    Friend WithEvents lblLabel6 As Label
    Friend WithEvents lblLabel5 As Label
    Friend WithEvents lblLabel2 As Label
    Friend WithEvents btnPlaceOrder As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnEmptyCart As Button
    Friend WithEvents btnRemoveFromCart As Button
    Friend WithEvents BikeStoreDataSet As BikeStoreDataSet
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As BikeStoreDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents ProductBindingSource As BindingSource
    Friend WithEvents ProductTableAdapter As BikeStoreDataSetTableAdapters.ProductTableAdapter
End Class
