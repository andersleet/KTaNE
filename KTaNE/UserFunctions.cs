using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace KTaNE
{
    public class UserFunctions
    {
        public UserFunctions()
        {
        }

        public static string Test(int num)
        {
            return "TeSt " + num;
        }

        

        public static void ResetLabelValue(Label l)
        {
            if (l != null) l.Content = string.Empty;
        }

        public static void ResetTextBoxValue(TextBox t)
        {
            if (t != null) t.Text = string.Empty;
        }

        public static void ResetTextBlockValue(object l)
        {
            var i = (TextBlock)l;
            if (i == null) return;
            i.Text = string.Empty;
        }

        public static void NumericValidation(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !char.IsDigit(e.Text, e.Text.Length - 1); // Ensures only numbers can be entered to the Control
        }

        public static bool IsNull(object o)
        {
            return (o == null);
        }

        /// <summary>
        /// Finds a Child of a given item in the visual tree. 
        /// </summary>
        /// <param name="parent">A direct parent of the queried item.</param>
        /// <typeparam name="T">The type of the queried item.</typeparam>
        /// <param name="childName">x:Name or Name of child. </param>
        /// <returns>The first parent item that matches the submitted type parameter. 
        /// If not matching item can be found, 
        /// a null parent is being returned.</returns>

        public static T FindChild<T>(DependencyObject parent, string childName)
            where T : DependencyObject
        {
            // Confirm parent and childName are valid. 
            if (parent == null) return null;

            T foundChild = null;

            int childrenCount = VisualTreeHelper.GetChildrenCount(parent);
            for (int i = 0; i < childrenCount; i++)
            {
                var child = VisualTreeHelper.GetChild(parent, i);
                // If the child is not of the request child type child
                if (!(child is T childType))
                {
                    // recursively drill down the tree
                    foundChild = FindChild<T>(child, childName);

                    // If the child is found, break so we do not overwrite the found child. 
                    if (foundChild != null) break;
                }
                else if (!string.IsNullOrEmpty(childName))
                {
                    // If the child's name is set for search
                    if (!(child is FrameworkElement frameworkElement) || frameworkElement.Name != childName) continue;
                    // if the child's name is of the request name
                    foundChild = (T)child;
                    break;
                }
                else
                {
                    // child element found.
                    foundChild = (T)child;
                    break;
                }
            }

            return foundChild;
        }
    }
}