using DevExpress.Mvvm.DataAnnotations;

namespace DXBindingExample.ViewModel {
    [POCOViewModel]
    public class RelativeSourcesViewModel : BaseViewModel {
        public override object Title { get { return "Relative Sources"; } }

        public virtual int Value { get; set; }
        public RelativeSourcesViewModel() {
            Value = 5;
        }
    }
}
