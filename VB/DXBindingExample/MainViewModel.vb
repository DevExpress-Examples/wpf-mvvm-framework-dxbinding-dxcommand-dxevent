Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.POCO
Imports DXBindingExample.ViewModel
Imports System.Collections.ObjectModel

Namespace DXBindingExample
    <POCOViewModel>
    Public Class MainViewModel
        Private privateModules As ObservableCollection(Of BaseViewModel)
        Public Property Modules() As ObservableCollection(Of BaseViewModel)
            Get
                Return privateModules
            End Get
            Private Set(ByVal value As ObservableCollection(Of BaseViewModel))
                privateModules = value
            End Set
        End Property
        Public Overridable Property SelectedModule() As BaseViewModel
        Public Sub New()
            Modules = New ObservableCollection(Of BaseViewModel)()
            Modules.Add(ViewModelSource.Create(Function() New BasicExpressionsViewModel()))
            Modules.Add(ViewModelSource.Create(Function() New RelativeSourcesViewModel()))
            Modules.Add(ViewModelSource.Create(Function() New StaticPropertiesViewModel()))
            Modules.Add(ViewModelSource.Create(Function() New BindingToMethodViewModel()))
            Modules.Add(ViewModelSource.Create(Function() New TwoWayViewModel()))
            Modules.Add(ViewModelSource.Create(Function() New CommandViewModel()))
            Modules.Add(ViewModelSource.Create(Function() New EventViewModel()))
            SelectedModule = Modules(0)
        End Sub
    End Class
End Namespace
