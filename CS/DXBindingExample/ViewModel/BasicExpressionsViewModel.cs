using DevExpress.Mvvm.DataAnnotations;

namespace DXBindingExample.ViewModel {
    [POCOViewModel]
    public class BasicExpressionsViewModel : BaseViewModel {
        public override object Title { get { return "Basic Expressions"; } }
        public virtual int IntValue { get; set; }
        public virtual double DoubleValue { get; set; }
        public virtual string StringValue { get; set; }
        public virtual bool BooleanValue { get; set; }
        public BasicExpressionsViewModel() {
            IntValue = 5;
            DoubleValue = 6.1;
            StringValue = "String";
        }
    }
}
