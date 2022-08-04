Public Class Customer
    Public Property firstName As String
    Public Property lastName As String
    Public Property middleName As String
    Public Overrides Function ToString() As String
        Return lastName + " " + middleName + " " + firstName
    End Function
End Class
