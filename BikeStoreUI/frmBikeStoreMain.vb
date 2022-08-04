'Affirmation of Authorship:

'Name: Andre Aragon, German Alvarenga, Zhenming Ao

'Date: 7/11/2022

'We affirm that this program was created by us (Group 1). It is solely our work and ‘does not include any work done by anyone else.
Public Class frmBikeStoreMain
    Private Sub mnuLogOut_Click(sender As Object, e As EventArgs) Handles mnuLogOut.Click
        ' Logout menu button will logs out the user and bring the user back to login page
        Dim answer As Integer
        answer = MsgBox("Are you sure you want to log out?", vbQuestion + vbYesNo + vbDefaultButton2, "Confirmation")
        If answer = vbYes Then
            mnuLogOut.Enabled = False
            Me.Close()
        End If
    End Sub

    Private Sub frmBikeStoreMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ' In the event of main form closing, application logs out user and bring user back to login page
        frmLogin.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Logout button logs out the user and closes the main form
        Dim answer As Integer
        answer = MsgBox("Are you sure you want to log out?", vbQuestion + vbYesNo + vbDefaultButton2, "Confirmation")
        If answer = vbYes Then
            mnuLogOut.Enabled = False
            Me.Close()
        End If
    End Sub

    Private Sub mnuCustomers_Click(sender As Object, e As EventArgs) Handles mnuCustomers.Click
        frmCustomers.ShowDialog()
    End Sub

    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        frmCustomers.ShowDialog()
    End Sub

    Private Sub NotAvailableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotAvailableToolStripMenuItem.Click
        MsgBox("Report Unavailable: " & vbCrLf & "Currently Under Maintenance!" & vbCrLf & "(Not enough group member)", MsgBoxStyle.Information, "Information")
    End Sub

    Private Sub mnuVersion_Click(sender As Object, e As EventArgs) Handles mnuVersion.Click
        MsgBox("Program: Bike Store Application" & vbCrLf & "Version: 1.0" & vbCrLf & "Authors (Group 1): " & vbCrLf & "Andre Aragon, German Alvarenga, Zhenming Ao", MsgBoxStyle.Information, "About")
    End Sub

    Private Sub mnuProducts_Click(sender As Object, e As EventArgs) Handles mnuProducts.Click
        frmProducts.ShowDialog()
    End Sub

    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click
        frmProducts.ShowDialog()
    End Sub

    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        frmOrder.ShowDialog()
    End Sub

    Private Sub mnuPurchase_Click(sender As Object, e As EventArgs) Handles mnuPurchase.Click
        frmOrder.ShowDialog()
    End Sub
End Class
