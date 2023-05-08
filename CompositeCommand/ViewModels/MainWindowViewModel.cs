using CompositeCommands.Core.Commands;
using Prism.Mvvm;

namespace CompositeCommand.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private IApplicationCommand applicationCommand;
        public IApplicationCommand ApplicationCommand
        {
            get { return applicationCommand; }
            set { SetProperty(ref applicationCommand, value); }
        }

        public MainWindowViewModel(IApplicationCommand applicationCommand)
        {
            ApplicationCommand = applicationCommand;
        }
    }
}
