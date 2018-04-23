Imports DevExpress.Mvvm.DataAnnotations

Namespace DXBindingExample.ViewModel
    <POCOViewModel>
    Public Class TwoWayViewModel
        Inherits BaseViewModel

        Public Overrides ReadOnly Property Title() As Object
            Get
                Return "TwoWay Binding"
            End Get
        End Property
        Public Overridable Property FirstName() As String
        Public Overridable Property LastName() As String
        Public Sub New()
            FirstName = "John"
            LastName = "Smith"
        End Sub
        Public Function Sum(ByVal x As Integer, ByVal y As Integer) As Integer
            Return x + y
        End Function
    End Class
End Namespace
