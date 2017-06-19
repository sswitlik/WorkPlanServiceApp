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
        public LoginPage loginPage;

        public MainWindow()
        {
            InitializeComponent();
            loginPage = new LoginPage(this);
            AppNavigation.Content = loginPage;
        }

        public void loginPageClear()
        {
            loginPage.username.Text = "Username";
            loginPage.username.Foreground = Brushes.Gray;
            loginPage.password.Password = String.Empty;
        }
       
    }
}
