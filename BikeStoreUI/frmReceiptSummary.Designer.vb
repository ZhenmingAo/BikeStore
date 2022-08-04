<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReceiptSummary
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpReceiptSummary = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lstSummary = New System.Windows.Forms.ListBox()
        Me.grpReceiptSummary.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(132, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(275, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Order Confirmation"
        '
        'grpReceiptSummary
        '
        Me.grpReceiptSummary.Controls.Add(Me.lstSummary)
        Me.grpReceiptSummary.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.grpReceiptSummary.Location = New System.Drawing.Point(54, 81)
        Me.grpReceiptSummary.Name = "grpReceiptSummary"
        Me.grpReceiptSummary.Size = New System.Drawing.Size(458, 399)
        Me.grpReceiptSummary.TabIndex = 1
        Me.grpReceiptSummary.TabStop = False
        Me.grpReceiptSummary.Text = "Receipt Summary"
        '
        'btnExit
        '
        Me.btnExit.AutoSize = True
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnExit.Location = New System.Drawing.Point(223, 508)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(122, 39)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "OK / Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lstSummary
        '
        Me.lstSummary.FormattingEnabled = True
        Me.lstSummary.HorizontalScrollbar = True
        Me.lstSummary.ItemHeight = 18
        Me.lstSummary.Location = New System.Drawing.Point(6, 24)
        Me.lstSummary.Name = "lstSummary"
        Me.lstSummary.Size = New System.Drawing.Size(446, 364)
        Me.lstSummary.TabIndex = 0
        '
        'frmReceiptSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 582)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.grpReceiptSummary)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmReceiptSummary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Receipt"
        Me.grpReceiptSummary.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents grpReceiptSummary As GroupBox
    Friend WithEvents btnExit As Button
    Friend WithEvents lstSummary As ListBox
End Class
