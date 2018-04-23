using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DXBindingExample.ViewModel;
using System.Collections.ObjectModel;

namespace DXBindingExample {
    [POCOViewModel]
    public class MainViewModel {
        public ObservableCollection<BaseViewModel> Modules { get; private set; }
        public virtual BaseViewModel SelectedModule { get; set; }
        public MainViewModel() {
            Modules = new ObservableCollection<BaseViewModel>();
            Modules.Add(ViewModelSource.Create(() => new BasicExpressionsViewModel()));
            Modules.Add(ViewModelSource.Create(() => new RelativeSourcesViewModel()));
            Modules.Add(ViewModelSource.Create(() => new StaticPropertiesViewModel()));
            Modules.Add(ViewModelSource.Create(() => new BindingToMethodViewModel()));
            Modules.Add(ViewModelSource.Create(() => new TwoWayViewModel()));
            Modules.Add(ViewModelSource.Create(() => new CommandViewModel()));
            Modules.Add(ViewModelSource.Create(() => new EventViewModel()));
            SelectedModule = Modules[0];
        }
    }
}
