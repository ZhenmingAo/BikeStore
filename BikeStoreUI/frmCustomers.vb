Public Class frmCustomers
    Private Sub CustomerBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CustomerBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustomerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BikeStoreDataSet)

    End Sub

    Private Sub frmCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BikeStoreDataSet.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.BikeStoreDataSet.Customer)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Confirmation before exit
        Dim answer As Integer
        answer = MsgBox("Are you sure you want to close?", vbQuestion + vbYesNo + vbDefaultButton2, "Confirmation")
        If answer = vbYes Then
            Me.Close()
        End If
    End Sub
End Class