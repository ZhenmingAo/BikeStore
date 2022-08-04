Public Class Product
    Public Property productName As String
    Public Property listPrice As Double
    Public Overrides Function ToString() As String
        Return productName + " | $" + CStr(listPrice)
    End Function
End Class
