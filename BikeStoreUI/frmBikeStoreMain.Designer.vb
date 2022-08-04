<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBikeStoreMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBikeStoreMain))
        Me.mnuMenu = New System.Windows.Forms.MenuStrip()
        Me.mnuLogIn = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLogOut = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOrder = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPurchase = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMaintenance = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProducts = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCustomers = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotAvailableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuVersion = New System.Windows.Forms.ToolStripMenuItem()
        Me.picBikeImg = New System.Windows.Forms.PictureBox()
        Me.lblLabel1 = New System.Windows.Forms.Label()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.btnProducts = New System.Windows.Forms.Button()
        Me.btnCustomers = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.mnuMenu.SuspendLayout()
        CType(Me.picBikeImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuMenu
        '
        Me.mnuMenu.ImageScalingSize = New System.Drawing.Size(18, 18)
        Me.mnuMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuLogIn, Me.mnuOrder, Me.mnuMaintenance, Me.mnuReport, Me.mnuAbout})
        Me.mnuMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnuMenu.Name = "mnuMenu"
        Me.mnuMenu.Size = New System.Drawing.Size(1003, 27)
        Me.mnuMenu.TabIndex = 0
        Me.mnuMenu.Text = "MenuStrip1"
        '
        'mnuLogIn
        '
        Me.mnuLogIn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuLogOut})
        Me.mnuLogIn.Name = "mnuLogIn"
        Me.mnuLogIn.Size = New System.Drawing.Size(57, 23)
        Me.mnuLogIn.Text = "Login"
        '
        'mnuLogOut
        '
        Me.mnuLogOut.Enabled = False
        Me.mnuLogOut.Name = "mnuLogOut"
        Me.mnuLogOut.Size = New System.Drawing.Size(137, 24)
        Me.mnuLogOut.Text = "Log Out"
        '
        'mnuOrder
        '
        Me.mnuOrder.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPurchase})
        Me.mnuOrder.Name = "mnuOrder"
        Me.mnuOrder.Size = New System.Drawing.Size(59, 23)
        Me.mnuOrder.Text = "Order"
        '
        'mnuPurchase
        '
        Me.mnuPurchase.Name = "mnuPurchase"
        Me.mnuPurchase.Size = New System.Drawing.Size(206, 24)
        Me.mnuPurchase.Text = "Shop"
        '
        'mnuMaintenance
        '
        Me.mnuMaintenance.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProducts, Me.mnuCustomers})
        Me.mnuMaintenance.Name = "mnuMaintenance"
        Me.mnuMaintenance.Size = New System.Drawing.Size(102, 23)
        Me.mnuMaintenance.Text = "Maintenance"
        '
        'mnuProducts
        '
        Me.mnuProducts.Name = "mnuProducts"
        Me.mnuProducts.Size = New System.Drawing.Size(152, 24)
        Me.mnuProducts.Text = "Products"
        '
        'mnuCustomers
        '
        Me.mnuCustomers.Name = "mnuCustomers"
        Me.mnuCustomers.Size = New System.Drawing.Size(152, 24)
        Me.mnuCustomers.Text = "Customers"
        '
        'mnuReport
        '
        Me.mnuReport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NotAvailableToolStripMenuItem})
        Me.mnuReport.Name = "mnuReport"
        Me.mnuReport.Size = New System.Drawing.Size(64, 23)
        Me.mnuReport.Text = "Report"
        '
        'NotAvailableToolStripMenuItem
        '
        Me.NotAvailableToolStripMenuItem.Name = "NotAvailableToolStripMenuItem"
        Me.NotAvailableToolStripMenuItem.Size = New System.Drawing.Size(206, 24)
        Me.NotAvailableToolStripMenuItem.Text = "Not Available"
        '
        'mnuAbout
        '
        Me.mnuAbout.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuVersion})
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(61, 23)
        Me.mnuAbout.Text = "About"
        '
        'mnuVersion
        '
        Me.mnuVersion.Name = "mnuVersion"
        Me.mnuVersion.Size = New System.Drawing.Size(131, 24)
        Me.mnuVersion.Text = "Version"
        '
        'picBikeImg
        '
        Me.picBikeImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picBikeImg.Image = CType(resources.GetObject("picBikeImg.Image"), System.Drawing.Image)
        Me.picBikeImg.Location = New System.Drawing.Point(245, 105)
        Me.picBikeImg.Name = "picBikeImg"
        Me.picBikeImg.Size = New System.Drawing.Size(514, 306)
        Me.picBikeImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBikeImg.TabIndex = 1
        Me.picBikeImg.TabStop = False
        '
        'lblLabel1
        '
        Me.lblLabel1.AutoSize = True
        Me.lblLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblLabel1.Location = New System.Drawing.Point(282, 67)
        Me.lblLabel1.Name = "lblLabel1"
        Me.lblLabel1.Size = New System.Drawing.Size(431, 35)
        Me.lblLabel1.TabIndex = 2
        Me.lblLabel1.Text = "~ Welcome to the Bike Store ~"
        '
        'btnOrder
        '
        Me.btnOrder.AutoSize = True
        Me.btnOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnOrder.Location = New System.Drawing.Point(164, 434)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(130, 54)
        Me.btnOrder.TabIndex = 3
        Me.btnOrder.Text = "Order"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'btnProducts
        '
        Me.btnProducts.AutoSize = True
        Me.btnProducts.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnProducts.Location = New System.Drawing.Point(300, 434)
        Me.btnProducts.Name = "btnProducts"
        Me.btnProducts.Size = New System.Drawing.Size(186, 54)
        Me.btnProducts.TabIndex = 4
        Me.btnProducts.Text = "Products"
        Me.btnProducts.UseVisualStyleBackColor = True
        '
        'btnCustomers
        '
        Me.btnCustomers.AutoSize = True
        Me.btnCustomers.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnCustomers.Location = New System.Drawing.Point(492, 434)
        Me.btnCustomers.Name = "btnCustomers"
        Me.btnCustomers.Size = New System.Drawing.Size(221, 54)
        Me.btnCustomers.TabIndex = 5
        Me.btnCustomers.Text = "Customers"
        Me.btnCustomers.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.AutoSize = True
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnExit.Location = New System.Drawing.Point(719, 434)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(130, 54)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmBikeStoreMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1003, 548)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCustomers)
        Me.Controls.Add(Me.btnProducts)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.lblLabel1)
        Me.Controls.Add(Me.picBikeImg)
        Me.Controls.Add(Me.mnuMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.mnuMenu
        Me.MaximizeBox = False
        Me.Name = "frmBikeStoreMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bike Store"
        Me.mnuMenu.ResumeLayout(False)
        Me.mnuMenu.PerformLayout()
        CType(Me.picBikeImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuMenu As MenuStrip
    Friend WithEvents mnuLogIn As ToolStripMenuItem
    Friend WithEvents mnuLogOut As ToolStripMenuItem
    Friend WithEvents mnuOrder As ToolStripMenuItem
    Friend WithEvents mnuPurchase As ToolStripMenuItem
    Friend WithEvents mnuMaintenance As ToolStripMenuItem
    Friend WithEvents mnuProducts As ToolStripMenuItem
    Friend WithEvents mnuCustomers As ToolStripMenuItem
    Friend WithEvents mnuReport As ToolStripMenuItem
    Friend WithEvents NotAvailableToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents picBikeImg As PictureBox
    Friend WithEvents lblLabel1 As Label
    Friend WithEvents btnOrder As Button
    Friend WithEvents btnProducts As Button
    Friend WithEvents btnCustomers As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents mnuAbout As ToolStripMenuItem
    Friend WithEvents mnuVersion As ToolStripMenuItem
End Class
