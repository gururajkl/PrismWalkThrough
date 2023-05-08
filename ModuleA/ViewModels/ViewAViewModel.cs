using Prism.Commands;
using Prism.Mvvm;

namespace ModuleA.ViewModels
{
    public class ViewAViewModel : BindableBase
    {
        private string title = "View A View Model";
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }

        public DelegateCommand ClickCommand { get; private set; }

        public ViewAViewModel()
        {
            ClickCommand = new DelegateCommand(Click)
                .ObservesCanExecute(() => CanExecute);
        }

        private bool canExecute;
        public bool CanExecute
        {
            get { return canExecute; }
            set
            {
                SetProperty(ref canExecute, value);
            }
        }

        private void Click()
        {
            Title = "Button Clicked";
        }
    }
}
