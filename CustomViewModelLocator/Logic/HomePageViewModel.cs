using Prism.Mvvm;

namespace CustomViewModelLocator.Logic
{
    public class HomePageViewModel : BindableBase
    {
        private string title = "Home page view model";
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }
    }
}
