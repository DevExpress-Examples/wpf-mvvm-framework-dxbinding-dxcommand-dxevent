using DevExpress.Mvvm.DataAnnotations;

namespace DXBindingExample.ViewModel {
    [POCOViewModel]
    public class CommandViewModel : BaseViewModel {
        public override object Title { get { return "Command Bindings"; } }
    }
}
