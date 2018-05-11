Friend Class ItemComboBox
    Private _display As String
    Private _value As String

    Public Sub New()
        _display = String.Empty
        _value = "''"
    End Sub

    Public Sub New(display As String, value As String)
        _display = display
        _value = value
    End Sub

End Class
