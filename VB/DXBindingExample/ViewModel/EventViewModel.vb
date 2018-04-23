Imports DevExpress.Mvvm.DataAnnotations

Namespace DXBindingExample.ViewModel
    <POCOViewModel>
    Public Class EventViewModel
        Inherits BaseViewModel

        Public Overrides ReadOnly Property Title() As Object
            Get
                Return "Event Bindings"
            End Get
        End Property
    End Class
End Namespace
