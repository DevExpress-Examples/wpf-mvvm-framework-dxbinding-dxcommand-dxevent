Imports DevExpress.Mvvm.DataAnnotations

Namespace DXBindingExample.ViewModel
    <POCOViewModel>
    Public Class BindingToMethodViewModel
        Inherits BaseViewModel

        Public Overrides ReadOnly Property Title() As Object
            Get
                Return "Binding To Function"
            End Get
        End Property

        Public Function Sum(ByVal x As Integer, ByVal y As Integer) As Integer
            Return x + y
        End Function
    End Class
End Namespace
