﻿using System;
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
    /// Logika interakcji dla klasy UserPage.xaml
    /// </summary>
    public partial class UserPage : Page
    {
        public MainWindow appMenu;
        public AvailibilityPage availPage;
        public UserPage(MainWindow menu)
        {
            InitializeComponent();
            appMenu = menu;
            availPage = new AvailibilityPage(this);

            ActiveFuctionality.Content = new HelloPage();
        }

        private void AvailDefButton_Click(object sender, RoutedEventArgs e)
        {
            ActiveFuctionality.Content = availPage;
            
        }

        private void LogOutButton_Click(object sender, RoutedEventArgs e)
        {
            appMenu.loginPageClear();
            appMenu.AppNavigation.Content = appMenu.loginPage; 
        }
    }
}
