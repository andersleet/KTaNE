using System.Diagnostics;
using System.Windows;
using MahApps.Metro.Controls;
using Caliburn.Micro;
using KTaNE.ViewModels;

namespace KTaNE.Views
{
    /// <summary>
    /// Interaction logic for ShellView.xaml
    /// </summary>
    public partial class ShellView
    {
        public ShellView()
        {
            InitializeComponent();

            


        }

        public void ResetClick(object sender, RoutedEventArgs e)
        {
            // TODO: Use the framework to determine which x:Name module is active then loop through the controls and set them to default

            
            MessageBox.Show("Use the framework to determine which x:Name module is active then loop through the controls and set them to default");
        }
    }
}
