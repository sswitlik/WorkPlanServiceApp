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
    /// Logika interakcji dla klasy DefineTaskPage.xaml
    /// </summary>
    public partial class DefineTaskPage : Page
    {
        List<Shift> newShiftList;
        private ManagerPage parentPage;

        public DefineTaskPage(ManagerPage parent)
        {
            InitializeComponent();
            newShiftList = new List<Shift>();
            parentPage = parent;

            init();
            a = 1;
        }

        private void init()
        {

        }

        private void sendNewTaskButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private int a;
        private void addNewShiftButton_Click(object sender, RoutedEventArgs e)
        {
            newShiftList.Add(new Shift { dayDate = "01.01.2000", hourStart = "00:00", hourStop = "00:00" });
            a++;
            visualNewShiftList.ItemsSource = null;
            visualNewShiftList.ItemsSource = newShiftList;
        }
    }
}
