using Prism.Services.Dialogs;
using System;

namespace PrismIDialog.Dialogs
{
    public static class DialogServiceExtension
    {
        public static void ShowMessageDialog(this IDialogService dialogService, string message,
            Action<IDialogResult> callBack)
        {
            DialogParameters parames = new()
            {
                { "message", message }
            };

            dialogService.ShowDialog("MessageDialog", parames, callBack);
        }
    }
}
