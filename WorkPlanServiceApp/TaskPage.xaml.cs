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
    /// Logika interakcji dla klasy TaskPage.xaml
    /// </summary>
    public partial class TaskPage : Page
    {
        public Task usingTask;
        public List<Shift> shiftList;
        public TaskPage(Task clickedTask)
        {
            InitializeComponent();
            usingTask = clickedTask;
            shiftList = new List<Shift>();  //webmethod needed

            init();
        }

        private void init()
        {
            shiftList.Add(new Shift { dayDate = "14.12.1996", hourStart = "8:00", hourStop = "16:00"});
            shiftList.Add(new Shift { dayDate = "02.06.1997", hourStart = "20:45", hourStop = "20:50" });
            shiftList.Add(new Shift { dayDate = "4.12.2016", hourStart = "8:00", hourStop = "16:00" });
            visualShiftList.ItemsSource = shiftList;
        }
        
        private void preference_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            var comboBox = sender as ComboBox;
            var checkedShift = comboBox.DataContext as Shift;

            checkedShift.preference = comboBox.SelectedIndex;
        }

        private void sendShiftsButtonClick(object sender, RoutedEventArgs e)
        {
            //send 
        }
    }
}
