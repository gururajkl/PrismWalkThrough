using CompositeCommands.Core.Commands;
using Prism.Commands;
using Prism.Mvvm;
using System;

namespace CompositeCommandModule.ViewModels
{
    public class TabViewModel : BindableBase
    {
        private string? title;
        public string? Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }

        private bool canUpdate;
        public bool CanUpdate
        {
            get { return canUpdate; }
            set { SetProperty(ref canUpdate, value); }
        }

        private string? updateText;
        public string? UpdateText
        {
            get { return updateText; }
            set { SetProperty(ref updateText, value); }
        }

        public DelegateCommand UpdateCommand { get; set; }

        public TabViewModel(IApplicationCommand applicationCommand)
        {
            UpdateCommand = new DelegateCommand(Update)
                .ObservesCanExecute(() => CanUpdate);
            applicationCommand.SaveAllCommand.RegisterCommand(UpdateCommand);
        }

        private void Update()
        {
            UpdateText = $"Updated: {DateTime.Now}";
        }
    }
}
