using System;
using System.Collections.Generic;
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

namespace KTaNE.Views
{
    /// <summary>
    /// Interaction logic for MemoryView.xaml
    /// </summary>
    public partial class WireView : UserControl
    {
        public WireView()
        {
            InitializeComponent();
        }

        public void NumericValidation(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !char.IsDigit(e.Text, e.Text.Length - 1); // Ensures only numbers can be entered to the Control
        }


        private void WireInputGotFocus(object sender, RoutedEventArgs e)
        {
            //this fires when a textbox gets focus
            var s = ((TextBox)sender);
            //MessageBox.Show($"{s.Name} was focused");
            Console.WriteLine($@"{s.Name} was focused");
        }

        private void WireInputLostFocus(object sender, RoutedEventArgs e)
        {
            
            //this fires when a textbox loses focus
            var s = ((TextBox) sender);
            //MessageBox.Show($"{s.Name} was focused");
            Console.WriteLine($@"{s.Name} lost focus");
        }
    }
}
