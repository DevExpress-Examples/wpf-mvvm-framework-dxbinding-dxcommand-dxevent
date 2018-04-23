using DXBindingExample.ViewModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System;

namespace DXBindingExample.View {
    public abstract class ViewSelectorBase : DataTemplateSelector {
        public DataTemplate AttachedPropertiesViewTemplate { get; set; }
        public DataTemplate RelativeSourcesViewTemplate { get; set; }
        public DataTemplate BindingToMethodViewTemplate { get; set; }
        public DataTemplate BasicExpressionsViewTemplate { get; set; }
        public DataTemplate TwoWayViewTemplate { get; set; }
        public DataTemplate CommandViewTemplate { get; set; }
        public DataTemplate EventViewTemplate { get; set; }
        public override DataTemplate SelectTemplate(object item, DependencyObject container) {
            if(item is StaticPropertiesViewModel)
                return AttachedPropertiesViewTemplate;
            else if(item is RelativeSourcesViewModel)
                return RelativeSourcesViewTemplate;
            else if(item is BindingToMethodViewModel)
                return BindingToMethodViewTemplate;
            else if(item is BasicExpressionsViewModel)
                return BasicExpressionsViewTemplate;
            else if(item is TwoWayViewModel)
                return TwoWayViewTemplate;
            else if(item is CommandViewModel)
                return CommandViewTemplate;
            else if(item is EventViewModel)
                return EventViewTemplate;
            return null;
        }
    }
    public partial class ViewSelector : ViewSelectorBase {
        public ViewSelector() {
            InitializeComponent();
        }
    }
    public class ViewSelectorExtension : MarkupExtension {
        public override object ProvideValue(IServiceProvider serviceProvider) {
            return new ViewSelector();
        }
    }
}
