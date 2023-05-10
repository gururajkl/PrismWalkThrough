using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using PrismIDialog.Dialogs;
using System;

namespace PrismIDialog.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly IDialogService dialogService;

        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private string messageReceived;
        public string MessageReceived
        {
            get { return messageReceived; }
            set { SetProperty(ref messageReceived, value); }
        }

        public DelegateCommand ShowDialogCommand { get; set; }

        public MainWindowViewModel(IDialogService dialogService)
        {
            ShowDialogCommand = new DelegateCommand(ShowDialog);
            this.dialogService = dialogService;
        }

        private void ShowDialog()
        {
            dialogService.ShowMessageDialog("Just a message", result =>
            {
                if (result.Result == ButtonResult.OK)
                {
                    MessageReceived = result.Parameters.GetValue<string>("myParams");
                }
                else
                {
                    MessageReceived = "Okay button not clicked";
                }
            });
        }
    }
}
