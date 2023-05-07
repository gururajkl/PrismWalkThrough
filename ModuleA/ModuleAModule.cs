using ModuleA.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System.Windows;
using System.Windows.Controls;

namespace ModuleA
{
    public class ModuleAModule : IModule
    {
        private readonly IRegionManager regionManager;
        public ModuleAModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            // ViewDiscovery method
            // regionManager.RegisterViewWithRegion("ContentRegion", typeof(ViewA));

            // ViewInjection method
            IRegion region = regionManager.Regions["ContentRegion"];
            var view1 = containerProvider.Resolve<ViewA>();
            region.Add(view1);

            var view2 = containerProvider.Resolve<ViewA>();
            view2.Content = new TextBlock()
            { 
                Text = "View 2",
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
            };
            region.Deactivate(view1);
            region.Add(view2);
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}
