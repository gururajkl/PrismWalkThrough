using CustomViewModelLocator.Logic;
using CustomViewModelLocator.Pages;
using Prism.Ioc;
using Prism.Mvvm;
using System.Windows;

namespace CustomViewModelLocator
{
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<HomePage>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            ViewModelLocationProvider.Register<HomePage, HomePageViewModel>();
        }
    }
}
