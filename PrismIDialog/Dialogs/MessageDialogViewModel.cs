using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using System;

namespace PrismIDialog.Dialogs
{
    public class MessageDialogViewModel : BindableBase, IDialogAware
    {
        private string message;

        public event Action<IDialogResult> RequestClose;

        public string Message
        {
            get { return message; }
            set { SetProperty(ref message, value); }
        }

        public DelegateCommand CloseDialogCommand { get; set; }

        public string Title => "Confirmation";

        public MessageDialogViewModel()
        {
            CloseDialogCommand = new DelegateCommand(CloseDialog);
        }

        private void CloseDialog()
        {
            var result = ButtonResult.OK;
            var parames = new DialogParameters
            {
                { "myParams", "The dialog was closed by the user" }
            };
            RequestClose?.Invoke(new DialogResult(result, parames));
        }

        public bool CanCloseDialog()
        {
            return true;
        }

        public void OnDialogClosed()
        {

        }

        public void OnDialogOpened(IDialogParameters parameters)
        {
            Message = parameters.GetValue<string>("message");
        }
    }
}
