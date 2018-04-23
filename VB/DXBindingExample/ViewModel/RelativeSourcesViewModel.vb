Imports DevExpress.Mvvm.DataAnnotations

Namespace DXBindingExample.ViewModel
    <POCOViewModel>
    Public Class RelativeSourcesViewModel
        Inherits BaseViewModel

        Public Overrides ReadOnly Property Title() As Object
            Get
                Return "Relative Sources"
            End Get
        End Property

        Public Overridable Property Value() As Integer
        Public Sub New()
            Value = 5
        End Sub
    End Class
End Namespace
