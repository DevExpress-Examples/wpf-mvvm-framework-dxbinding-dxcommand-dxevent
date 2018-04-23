Imports DevExpress.Mvvm.DataAnnotations

Namespace DXBindingExample.ViewModel
    <POCOViewModel>
    Public Class BasicExpressionsViewModel
        Inherits BaseViewModel

        Public Overrides ReadOnly Property Title() As Object
            Get
                Return "Basic Expressions"
            End Get
        End Property
        Public Overridable Property IntValue() As Integer
        Public Overridable Property DoubleValue() As Double
        Public Overridable Property StringValue() As String
        Public Overridable Property BooleanValue() As Boolean
        Public Sub New()
            IntValue = 5
            DoubleValue = 6.1
            StringValue = "String"
        End Sub
    End Class
End Namespace
