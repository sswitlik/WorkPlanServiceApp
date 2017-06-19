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
    /// Logika interakcji dla klasy ManagerPage.xaml
    /// </summary>
    public partial class ManagerPage : Page
    {
        public MainWindow appMenu;
        public DefineTaskPage defTaskPage;

        public ManagerPage(MainWindow menu)
        {
            InitializeComponent();
            appMenu = menu;
            defTaskPage = new DefineTaskPage(this);

        }

        private void makePlanButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TaskDefButton_Click(object sender, RoutedEventArgs e)
        {
            ActiveFuctionality.Content = defTaskPage;
        }

        private void LogOutButton_Click(object sender, RoutedEventArgs e)
        {
            appMenu.loginPageClear();
            appMenu.AppNavigation.Content = appMenu.loginPage;
        }

    }
}
