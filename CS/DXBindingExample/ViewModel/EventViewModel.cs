using DevExpress.Mvvm.DataAnnotations;

namespace DXBindingExample.ViewModel {
    [POCOViewModel]
    public class EventViewModel : BaseViewModel {
        public override object Title { get { return "Event Bindings"; } }
    }
}
