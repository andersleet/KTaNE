using System;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using MahApps.Metro.Controls;

namespace KTaNE
{
    internal partial class MainWindow
    {

        private const string ControlRegex = @"Mem_Lvl(?<Level>\d)_Input_(?<Stage>Display|Position|Number)";

        private class LineResult
        {
            internal string Display { get; set; }
            internal int NumPosition { get; set; }

            public LineResult()
            {
                Display = string.Empty;
                NumPosition = 0;
            }
        }

        private void ClearMemoryBoxes(object sender, RoutedEventArgs e)
        {

            var interaction = MessageBox.Show("Reset This Module?", "Reset", MessageBoxButton.YesNo, MessageBoxImage.Question);

            switch (interaction)
            {
                case MessageBoxResult.Yes:

                    break;

                case MessageBoxResult.No:

                    return;

                default:
                    break;
            }

            // Level 1
            Functions.ResetTextBoxValue(Mem_Lvl1_Input_Display);
            Functions.ResetTextBoxValue(Mem_Lvl1_Input_Position);
            Functions.ResetTextBoxValue(Mem_Lvl1_Input_Number);

            Functions.ResetTextBlockValue(Mem_Lvl1_Output);

            // Level 2
            Functions.ResetTextBoxValue(Mem_Lvl2_Input_Display);
            Functions.ResetTextBoxValue(Mem_Lvl2_Input_Position);
            Functions.ResetTextBoxValue(Mem_Lvl2_Input_Number);

            Functions.ResetTextBlockValue(Mem_Lvl2_Output);

            // Level 3
            Functions.ResetTextBoxValue(Mem_Lvl3_Input_Display);
            Functions.ResetTextBoxValue(Mem_Lvl3_Input_Position);
            Functions.ResetTextBoxValue(Mem_Lvl3_Input_Number);

            Functions.ResetTextBlockValue(Mem_Lvl3_Output);

            // Level 4
            Functions.ResetTextBoxValue(Mem_Lvl4_Input_Display);
            Functions.ResetTextBoxValue(Mem_Lvl4_Input_Position);
            Functions.ResetTextBoxValue(Mem_Lvl4_Input_Number);

            Functions.ResetTextBlockValue(Mem_Lvl4_Output);

            // Level 5
            Functions.ResetTextBoxValue(Mem_Lvl5_Input_Display);
            Functions.ResetTextBoxValue(Mem_Lvl5_Input_Position);
            Functions.ResetTextBoxValue(Mem_Lvl5_Input_Number);

            Functions.ResetTextBlockValue(Mem_Lvl5_Output);
        }

        private void HandleMemoryModuleInput(object s, TextChangedEventArgs e)
        {
            var r = new Regex(ControlRegex);
            var t = (TextBox)s;
            var validateControl = r.IsMatch(t.Tag.ToString());
            if(!validateControl) return;

            var inputControl = r.GetGroupNames();

            foreach (var n in inputControl)
            {
                switch (n)
                {
                    case "Level":
                        MessageBox.Show("Level Hit" );
                        break;
                    case "Stage":
                        MessageBox.Show("Stage Hit");
                        break;
                    //default:
                    //    MessageBox.Show("NBothing Hit");
                    //    break;
                }
            }

            //var currentLevel = inputControl["Level"];
            //var currentBox = inputControl[2];

            Debugger.Break();

            if (t.Text.Length <= 0)
            {
                // TODO: reset output label if invalid
                t.Text = "NULL";

                return;
            }



            var input = int.Parse(t.Text);



            if (!Enumerable.Range(1, 5).Contains(input))                // Ensures only 1-5 can be entered
            {
                t.Text = string.Empty; MessageBox.Show("Please Enter a Number Between 1 and 5",
                    "Invalid Input",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);

                return;
            }



            SetMemoryModuleResults(t, input);

            r = null;
        }

        private void SetMemoryModuleResults(TextBox box, int input)
        {
            if (box == null || input < 0) return;                       // Ensure input is not empty

            var t = new MemoryModule(box, input);

            if (t.Stage <= 0 || t.Position == string.Empty) return;
            TextBlock outputLabel = null;

            switch (t.Stage)                                            // each CASE is a stage
            {
                case 1:
                    outputLabel = Mem_Lvl1_Output;
                    break;
                case 2:
                    outputLabel = Mem_Lvl2_Output;
                    break;
                case 3:
                    outputLabel = Mem_Lvl3_Output;
                    break;
                case 4:
                    outputLabel = Mem_Lvl4_Output;
                    break;
                case 5:
                    outputLabel = Mem_Lvl5_Output;
                    break;
                default:
                    MessageBox.Show("ERROR");
                    break;
            }



            outputLabel.Text = "I was Hit With - " + t.Number;

            t = null;

            //Debugger.Break();

        }

        private LineResult LevelOne(int d)
        {
            var ret = new LineResult();
            switch (d)
            {
                case 1 - 2:
                    ret.Display = "Second Position";
                    ret.NumPosition = 2;
                    break;
                case 3:
                    ret.Display = "Third Position";
                    ret.NumPosition = 3;
                    break;
                case 4:
                    ret.Display = "Fourth Position";
                    ret.NumPosition = 4;
                    break;
                default:
                    MessageBox.Show("ERROR");
                    break;
            }

            return ret;
        }
    }
}
