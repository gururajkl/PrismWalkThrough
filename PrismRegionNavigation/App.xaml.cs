using Prism.Ioc;
using Prism.Modularity;
using PrismRegionNavigation.Views;
using System.Windows;

namespace PrismRegionNavigation
{
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            base.ConfigureModuleCatalog(moduleCatalog);
            moduleCatalog.AddModule<Regions.RegionModule>();
        }
    }
}
