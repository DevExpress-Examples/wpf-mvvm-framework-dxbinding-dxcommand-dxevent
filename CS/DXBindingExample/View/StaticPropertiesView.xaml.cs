using DevExpress.Mvvm.UI;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace DXBindingExample.View {
    public partial class StaticPropertiesView : UserControl {
        public StaticPropertiesView() {
            InitializeComponent();
        }
    }
    public static class AttachedPropertiesHelper {
        public static readonly DependencyProperty AttachedTitleProperty = DependencyProperty.RegisterAttached("AttachedTitle", typeof(string), typeof(AttachedPropertiesHelper), new PropertyMetadata("Title"));
        public static string GetAttachedTitle(DependencyObject obj) { return (string)obj.GetValue(AttachedTitleProperty); }
        public static void SetAttachedTitle(DependencyObject obj, string value) { obj.SetValue(AttachedTitleProperty, value); }
    }
    public static class StaticPropertiesHelper {
        public static StaticObj StaticObject;
        static StaticPropertiesHelper() {
            StaticObject = new StaticObj() { Value = "StaticValue" };
        }
        public class StaticObj {
            public string Value { get; set; }
        }
    }
}
