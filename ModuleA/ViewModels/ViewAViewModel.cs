using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
