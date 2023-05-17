using Prism.Regions;
using System.Windows.Controls;

namespace Regions.Views
{
    public partial class ViewB : UserControl, INavigationAware
    {
        public ViewB()
        {
            InitializeComponent();
        }

        private int count = 0;

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {

        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            tbCount.Text = $"{++count}";
        }
    }
}
