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

namespace WorkPlanServiceApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private bool usernameClicked = false;

        private void username_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (!usernameClicked)
            {
                var obj = sender as TextBox;
                obj.Text = String.Empty;
                obj.Foreground = Brushes.Black;

                usernameClicked = true;
            }

            //username.Focusable = false;
            
        }

        private void nextFocus_EnterKeyDown(object sender, KeyEventArgs e)
        {
            var obj = sender as Control;
            int i = 0;
            for (i = 0; i < stack.Children.Count; i++)
                if (obj == stack.Children[i])
                    break;

            if (e.Key.Equals(Key.Enter))
            {
                stack.Children[i].Focusable = false;
                stack.Children[i+1].Focusable = true;
                Keyboard.Focus(stack.Children[i+1]);
            }
        }

        private void logIn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
