using CompositeCommand.Views;
using CompositeCommands.Core.Commands;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;

namespace CompositeCommand
{
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IApplicationCommand, ApplicationCommand>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            base.ConfigureModuleCatalog(moduleCatalog);
            moduleCatalog.AddModule<CompositeCommandModule.CompositeCmdModule>();
        }
    }
}
