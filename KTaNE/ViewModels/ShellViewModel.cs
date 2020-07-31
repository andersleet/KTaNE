using System;
using System.Diagnostics;
using Caliburn.Micro;

namespace KTaNE.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        //private int _programMajorVersion = 0;

        private int _programMajorVersion;
        private int _programMinorVersion = 1;
        private string _displayTitlePrefix = "Keep Talking and Nobody Explodes Helper";
        private string _currentModule = string.Empty;


        public string WindowTitle => $"{DisplayTitlePrefix} v{ProgramMajorVersion}.{ProgramMinorVersion}";

        //private string _firstName = "Bob";
        //private string _lastName = "Dole";

        public ShellViewModel()
        {
            //People.Add(new PersonModel {FirstName = "Darren", LastName = "Johnson"});
            //ActivateItem(new StartPageViewModel());

            LoadStartPageModule();
        }

        public string DisplayTitlePrefix
        {
            get => _displayTitlePrefix;
            set
            {
                if (value.Equals(_displayTitlePrefix)) return;
                _displayTitlePrefix = value;
                NotifyOfPropertyChange(() => DisplayTitlePrefix);
            }
        }

        public string CurrentModule
        {
            get => _currentModule;
            set
            {
                if (value.Equals(_currentModule)) return;
                _currentModule = value;
                NotifyOfPropertyChange(() => CurrentModule);
                Console.WriteLine($@"Current Module is {CurrentModule}");
            }
        }

        public int ProgramMajorVersion
        {
            get => _programMajorVersion;
            set
            {
                if (value.Equals(_programMajorVersion)) return;
                _programMajorVersion = value;
                NotifyOfPropertyChange(() => ProgramMajorVersion);
            }
        }

        public int ProgramMinorVersion
        {
            get => _programMinorVersion;
            set
            {
                if (value.Equals(_programMinorVersion)) return;
                _programMajorVersion = value;
                NotifyOfPropertyChange(() => ProgramMinorVersion);
            }
        }

        //public string SetWindowTitle(string extras) // WIP
        //{
        //    var oRet = $"{DisplayTitle} v{ProgramVersion}";
        //    if (string.IsNullOrWhiteSpace(extras))
        //        oRet += " - " + extras;

        //    return oRet;
        //}

        //public bool CanClearText(string firstName, string lastName)
        //{
        //    if (string.IsNullOrWhiteSpace(firstName) && string.IsNullOrWhiteSpace(lastName))
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}

        //public void ClearText(string firstName, string lastName)
        //{
        //    FirstName = string.Empty;
        //    LastName = string.Empty;
        //}

        public void LoadStartPageModule()
        {
            CurrentModule = "Startup Page";
            ActivateItem(new StartPageViewModel());
        }
        
        /*
            Navigation Buttons 
        */

        public void LoadWiresModule()
        {
            CurrentModule = "Wires";
            ActivateItem(new WireViewModel());
        }

        public void LoadButtonModule()
        {
            CurrentModule = "Buttons";
            ActivateItem(new ButtonViewModel());
        }

        public void LoadKeypadModule()
        {
            CurrentModule = "Keypads";
            ActivateItem(new KeypadViewModel());
        }

        public void LoadSimonSaysModule()
        {
            CurrentModule = "Simon Says";
            ActivateItem(new SimonSaysViewModel());
        }

        public void LoadWhosOnFirstModule()
        {
            CurrentModule = "Who's On First";
            ActivateItem(new WhosOnFirstViewModel());
        }

        public void LoadMemoryModule()
        {
            CurrentModule = "Memory";
            ActivateItem(new MemoryViewModel());
        }

        public void LoadMorseCodeModule()
        {
            CurrentModule = "Morse COde";
            ActivateItem(new MorseCodeViewModel());
        }

        public void LoadCompWiresModule()
        {
            CurrentModule = "Complicated Wires";
            ActivateItem(new CompWiresViewModel());
        }

        public void LoadWireSequenceModule()
        {
            CurrentModule = "Wire Sequences";
            ActivateItem(new WireSequenceViewModel());
        }

        public void LoadMazeModule()
        {
            CurrentModule = "Mazes";
            ActivateItem(new MazeViewModel());
        }

        public void LoadPasswordsModule()
        {
            CurrentModule = "Passwords";
            ActivateItem(new PasswordsViewModel());
        }



        /* OTHER STUFF */

        public void OpenManual()
        {
            Process.Start(GameConstants.manualURL); // launches the PDF Manual in default browser. Requires internet connection.
        }
        

        //public string FirstName
        //{
        //    get => _firstName;
        //    set
        //    {
        //        _firstName = value;
        //        NotifyOfPropertyChange(() => FirstName);
        //        NotifyOfPropertyChange(() => FullName);
        //    } 
        //}

        //public string LastName
        //{
        //    get => _lastName;
        //    set
        //    {
        //        _lastName = value;
        //        NotifyOfPropertyChange(() => LastName);
        //        NotifyOfPropertyChange(() => FullName);
        //    }
        //}

        //public BindableCollection<PersonModel> People { get; set; } = new BindableCollection<PersonModel>();

        //public PersonModel SelectedPerson
        //{
        //    get { return _selectedPerson; }
        //    set
        //    {
        //        _selectedPerson = value;
        //        NotifyOfPropertyChange(() => SelectedPerson);
        //    }
        //}

    }
}