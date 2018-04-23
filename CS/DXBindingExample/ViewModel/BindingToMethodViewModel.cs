using DevExpress.Mvvm.DataAnnotations;

namespace DXBindingExample.ViewModel {
    [POCOViewModel]
    public class BindingToMethodViewModel : BaseViewModel {
        public override object Title { get { return "Binding To Function"; } }

        public int Sum(int x, int y) {
            return x + y;
        }
    }
}
