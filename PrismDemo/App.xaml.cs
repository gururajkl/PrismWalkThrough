using Prism.DryIoc;
using Prism.Ioc;
using PrismDemo.Views;
using System.Windows;

namespace PrismDemo
{
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<ShellWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }
}
