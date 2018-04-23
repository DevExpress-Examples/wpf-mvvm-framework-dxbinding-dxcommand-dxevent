Imports DXBindingExample.ViewModel
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Markup
Imports System

Namespace DXBindingExample.View
    Public MustInherit Class ViewSelectorBase
        Inherits DataTemplateSelector

        Public Property AttachedPropertiesViewTemplate() As DataTemplate
        Public Property RelativeSourcesViewTemplate() As DataTemplate
        Public Property BindingToMethodViewTemplate() As DataTemplate
        Public Property BasicExpressionsViewTemplate() As DataTemplate
        Public Property TwoWayViewTemplate() As DataTemplate
        Public Property CommandViewTemplate() As DataTemplate
        Public Property EventViewTemplate() As DataTemplate
        Public Overrides Function SelectTemplate(ByVal item As Object, ByVal container As DependencyObject) As DataTemplate
            If TypeOf item Is StaticPropertiesViewModel Then
                Return AttachedPropertiesViewTemplate
            ElseIf TypeOf item Is RelativeSourcesViewModel Then
                Return RelativeSourcesViewTemplate
            ElseIf TypeOf item Is BindingToMethodViewModel Then
                Return BindingToMethodViewTemplate
            ElseIf TypeOf item Is BasicExpressionsViewModel Then
                Return BasicExpressionsViewTemplate
            ElseIf TypeOf item Is TwoWayViewModel Then
                Return TwoWayViewTemplate
            ElseIf TypeOf item Is CommandViewModel Then
                Return CommandViewTemplate
            ElseIf TypeOf item Is EventViewModel Then
                Return EventViewTemplate
            End If
            Return Nothing
        End Function
    End Class
    Partial Public Class ViewSelector
        Inherits ViewSelectorBase

        Public Sub New()
            InitializeComponent()
        End Sub
    End Class
    Public Class ViewSelectorExtension
        Inherits MarkupExtension

        Public Overrides Function ProvideValue(ByVal serviceProvider As IServiceProvider) As Object
            Return New ViewSelector()
        End Function
    End Class
End Namespace
