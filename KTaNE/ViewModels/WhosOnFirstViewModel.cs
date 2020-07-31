using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace KTaNE.ViewModels
{
    public class WhosOnFirstViewModel : Screen
    {
        private string _tempDisplayHeader = "THIS IS WHO'S ON FIRST PAGE";

        public WhosOnFirstViewModel()
        {

        }

        public string TempDisplayHeader
        {
            get => _tempDisplayHeader;
            set
            {
                if (value.Equals(_tempDisplayHeader)) return;
                _tempDisplayHeader = value;
                NotifyOfPropertyChange(() => TempDisplayHeader);
            }
        }
    }
}
