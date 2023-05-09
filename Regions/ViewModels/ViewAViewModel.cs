using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Windows;

namespace Regions.ViewModels
{
    public class ViewAViewModel : BindableBase, INavigationAware, IConfirmNavigationRequest
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

        public void ConfirmNavigationRequest(NavigationContext navigationContext, Action<bool> continuationCallback)
        {
            bool result = false;
            if (MessageBox.Show("Do you want to continue", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                result = true;
            }
            continuationCallback(result);
        }
    }
}
