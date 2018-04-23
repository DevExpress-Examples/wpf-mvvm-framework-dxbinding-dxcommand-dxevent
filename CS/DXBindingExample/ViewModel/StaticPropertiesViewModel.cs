using DevExpress.Mvvm.DataAnnotations;

namespace DXBindingExample.ViewModel {
    [POCOViewModel]
    public class StaticPropertiesViewModel : BaseViewModel {
        public override object Title { get { return "Static and Attached Properties"; } }
    }
}
