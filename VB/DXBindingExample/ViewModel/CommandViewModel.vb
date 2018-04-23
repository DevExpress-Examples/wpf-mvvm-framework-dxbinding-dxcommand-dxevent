Imports DevExpress.Mvvm.DataAnnotations

Namespace DXBindingExample.ViewModel
    <POCOViewModel>
    Public Class CommandViewModel
        Inherits BaseViewModel

        Public Overrides ReadOnly Property Title() As Object
            Get
                Return "Command Bindings"
            End Get
        End Property
    End Class
End Namespace
