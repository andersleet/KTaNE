using Caliburn.Micro;

namespace KTaNE.ViewModels
{
    public class ButtonViewModel : Screen
    {
        private string _tempDisplayHeader = "THIS IS BUTTON PAGE";

        public ButtonViewModel()
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
