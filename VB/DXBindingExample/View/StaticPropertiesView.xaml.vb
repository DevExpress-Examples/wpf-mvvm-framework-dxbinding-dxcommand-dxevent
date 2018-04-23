Imports DevExpress.Mvvm.UI
Imports System.Linq
Imports System.Windows
Imports System.Windows.Controls

Namespace DXBindingExample.View
    Partial Public Class StaticPropertiesView
        Inherits UserControl

        Public Sub New()
            InitializeComponent()
        End Sub
    End Class
    Public NotInheritable Class AttachedPropertiesHelper

        Private Sub New()
        End Sub

        Public Shared ReadOnly AttachedTitleProperty As DependencyProperty = DependencyProperty.RegisterAttached("AttachedTitle", GetType(String), GetType(AttachedPropertiesHelper), New PropertyMetadata("Title"))
        Public Shared Function GetAttachedTitle(ByVal obj As DependencyObject) As String
            Return DirectCast(obj.GetValue(AttachedTitleProperty), String)
        End Function
        Public Shared Sub SetAttachedTitle(ByVal obj As DependencyObject, ByVal value As String)
            obj.SetValue(AttachedTitleProperty, value)
        End Sub
    End Class
    Public NotInheritable Class StaticPropertiesHelper

        Private Sub New()
        End Sub

        Public Shared StaticObject As StaticObj
        Shared Sub New()
            StaticObject = New StaticObj() With {.Value = "StaticValue"}
        End Sub
        Public Class StaticObj
            Public Property Value() As String
        End Class
    End Class
End Namespace
