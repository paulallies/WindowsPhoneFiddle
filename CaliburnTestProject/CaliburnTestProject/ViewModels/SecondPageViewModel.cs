using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaliburnTestProject.ViewModels
{
    public class SecondPageViewModel : PropertyChangedBase
    {

        private bool _focus;

        public bool SetFocus
        {
            get { return _focus; }
            set
            {
                _focus = value;
                NotifyOfPropertyChange(() => SetFocus);
            }
        }

        public void Focus()
        {
            SetFocus = true;
        }
    }
}
