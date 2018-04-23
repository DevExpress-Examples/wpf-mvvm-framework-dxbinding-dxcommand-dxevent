using DevExpress.Mvvm.DataAnnotations;

namespace DXBindingExample.ViewModel {
    [POCOViewModel]
    public class TwoWayViewModel : BaseViewModel {
        public override object Title { get { return "TwoWay Binding"; } }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public TwoWayViewModel() {
            FirstName = "John";
            LastName = "Smith";
        }
        public int Sum(int x, int y) {
            return x + y;
        }
    }
}
