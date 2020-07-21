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


namespace KTaNE
{
    public class GameConstants
    {
        internal const int manualID = 241;
        internal const string manualURL = "https://bombmanual.com/web/index.html";
        internal static string titlePrefix = "Keep Talking and Nobody Explodes Helper";
        internal static string AssistantVersion = "0.1";


    }

    public class MemoryModule
    {
        internal int Stage { get; set; }
        internal int Display { get; set; }
        internal string Position { get; set; }
        internal int Number { get; set; }

        internal string SourceName { get; set; }
        internal TextBox Source { get; set; }

        internal Label FinalOutput { get; set; }

        public MemoryModule()
        {
            Stage = 0;
            Display = 0;
            Position = string.Empty;
            Number = 0;

            SourceName = string.Empty;
            Source = null;

            FinalOutput = null;
        }

        public MemoryModule(TextBox source, int number)
        {
            Stage = int.Parse(source.Name.Substring(7, 1));    // get the stage number from the Control Name
            Position = source.Name.Substring(15);              // get the type of Control from the Name
            Number = number;

            //FinalOutput = 
            //Debugger.Break();


        }

    }


    public class Morse // TODO: try to calculate clicks to recognise dots or dashes
    {
        private const int Dot = 0;
        private const int Dash = 1;

        private string Translate(object input)
        {
            return "";
        }
    }
}