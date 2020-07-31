using Caliburn.Micro;



namespace KTaNE.ViewModels
{
    public class WireViewModel : Screen
    {
        private string _tempDisplayHeader = "THIS IS WIRE PAGE";
        
        public class WireLevel
        {
            public int Level { get; set; }
            public int Display { get; set; }
            public int Position { get; set; }
            public int Number { get; set; }
            public string Action { get; set; }
        }

        private WireLevel _one;
        private WireLevel _two;
        private WireLevel _three;
        private WireLevel _four;
        private WireLevel _five;
        private WireLevel _six;

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

        public WireViewModel()
        {
            WireLevelResults.Add(new WireLevel {Action = "Test1", Display = 1, Level = 1, Number = 1, Position = 1});
        }

        // TEST MODE BELOW HERE

        public void TestVoid()
        {
        }

        private int _currentLevel;

        public int CUrrentLevel
        {
            get => _currentLevel;
            set
            {
                if (value.Equals(_currentLevel)) return;
                _currentLevel = value;
                NotifyOfPropertyChange(() => CUrrentLevel);
            }
        }



        private BindableCollection<WireLevel> _wireLevelResults = new BindableCollection<WireLevel>();

        public BindableCollection<WireLevel> WireLevelResults
        {
            get { return _wireLevelResults; }
            set { _wireLevelResults = value; }
        }

        public WireLevel One
        {
            get => _one;
            set
            {
                if (value.Equals(_one)) return;
                _one = value;
                NotifyOfPropertyChange(() => One);

            }
        }

        public WireLevel Two
        {
            get => _two;
            set
            {
                if (value.Equals(_two)) return;
                _two = value;
                NotifyOfPropertyChange(() => Two);

            }
        }

        public WireLevel Three
        {
            get => _three;
            set
            {
                if (value.Equals(_three)) return;
                _three = value;
                NotifyOfPropertyChange(() => Three);

            }

        }

        public WireLevel Four
        {
            get => _four;
            set
            {
                if (value.Equals(_four)) return;
                _four = value;
                NotifyOfPropertyChange(() => Four);

            }
        }

        public WireLevel Five
        {
            get => _five;
            set
            {
                if (value.Equals(_five)) return;
                _five = value;
                NotifyOfPropertyChange(() => Five);

            }
        }

        public WireLevel Six // may not be necessary
        {
            get => _six;
            set
            {
                if (value.Equals(_six)) return;
                _six = value;
                NotifyOfPropertyChange(() => Six);

            }
        }
        
        // TEST MODE ENDS HERE
    }
}