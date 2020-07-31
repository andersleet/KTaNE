using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace KTaNE.ViewModels
{
    public class MazeViewModel : Screen
    {
        private string _tempDisplayHeader = "THIS IS MAZE PAGE";

        public MazeViewModel()
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
