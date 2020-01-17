Partial Public Class Person
    Public Function GetMyAmount() As Decimal
        Return Me.Goal / Me.MonthsToSave
    End Function

End Class
