using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace PrismRegionNavigation.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public DelegateCommand<string> NavigateCommand { get; set; }

        private readonly IRegionManager regionManager;

        public MainWindowViewModel(IRegionManager regionManager)
        {
            NavigateCommand = new DelegateCommand<string>(Navigate);
            this.regionManager = regionManager;
        }

        private void Navigate(string uri)
        {
            regionManager.RequestNavigate("ContentRegion", uri);
        }
    }
}
