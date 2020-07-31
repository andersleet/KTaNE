using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;



//using KTaNE.InternalConstants

namespace KTaNE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    internal partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            /* OFF TO THE RACES! */
            InitializeComponent();
            ProgramStartup();
        }

        private void ProgramStartup() // all the initialzation goes here
        {
            Hoosker.Title = GameConstants.titlePrefix + " - V" + GameConstants.AssistantVersion;            
        }

        public void ManualClick(object sender, RoutedEventArgs e)
        {
            Process.Start(GameConstants.manualURL); // launches the PDF Manual in default browser
        }

        private void NumericValidation(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !char.IsDigit(e.Text, e.Text.Length - 1); // Ensures only numbers can be entered to the Control
        }
    }
}
