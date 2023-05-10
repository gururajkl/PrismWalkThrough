using Prism.Ioc;
using PrismIDialog.Dialogs;
using PrismIDialog.Views;
using System.Windows;

namespace PrismIDialog
{
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterDialog<MessageDialog, MessageDialogViewModel>();
        }
    }
}
