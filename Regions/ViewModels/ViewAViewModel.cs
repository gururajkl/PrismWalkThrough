using Prism.Mvvm;
using Prism.Regions;

namespace Regions.ViewModels
{
    public class ViewAViewModel : BindableBase, INavigationAware
    {
        private int pageCount = 0;
        public int PageCount
        {
            get { return pageCount; }
            set { SetProperty(ref pageCount, value); }
        }

        private string text = "View A";
        public string Text
        {
            get { return text; }
            set { SetProperty(ref text, value); }
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {

        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            var value = navigationContext.Parameters.GetValue<string>("key");
            PageCount++;
            Text = $"View A {value}";
        }
    }
}
