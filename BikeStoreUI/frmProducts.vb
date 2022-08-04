Public Class frmProducts
    Private Sub ProductBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProductBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProductBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BikeStoreDataSet)

    End Sub

    Private Sub frmProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BikeStoreDataSet.Product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me.BikeStoreDataSet.Product)

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