using Prism.Ioc;
using Prism.Modularity;
using Regions.Views;

namespace Regions
{
    public class RegionModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        { }
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ViewA>();
            containerRegistry.RegisterForNavigation<ViewB>();
        }
    }
}
