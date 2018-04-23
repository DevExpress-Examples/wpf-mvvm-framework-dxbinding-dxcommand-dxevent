Imports DevExpress.Mvvm.DataAnnotations

Namespace DXBindingExample.ViewModel
    <POCOViewModel>
    Public Class StaticPropertiesViewModel
        Inherits BaseViewModel

        Public Overrides ReadOnly Property Title() As Object
            Get
                Return "Static and Attached Properties"
            End Get
        End Property
    End Class
End Namespace
