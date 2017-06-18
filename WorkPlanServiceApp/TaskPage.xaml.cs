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
        public TaskPage(Task clickedTask)
        {
            InitializeComponent();
            usingTask = clickedTask;

            init();
        }

        private void init()
        {
            var items = new List<ShiftElement>();
            items.Add(new ShiftElement { Date = "14.12.1996", Hour = "nwm" });
            items.Add(new ShiftElement { Date = "02.06.1997", Hour = "20:45" });
            items.Add(new ShiftElement { Date = "02.06.1997", Hour = "20:45" });
            items.Add(new ShiftElement { Date = "02.06.1997", Hour = "20:45" });
            items.Add(new ShiftElement { Date = "02.06.1997", Hour = "20:45" });
            items.Add(new ShiftElement { Date = "02.06.1997", Hour = "20:45" });
            items.Add(new ShiftElement { Date = "02.06.1997", Hour = "20:45" });
            items.Add(new ShiftElement { Date = "02.06.1997", Hour = "20:45" });
            items.Add(new ShiftElement { Date = "02.06.1997", Hour = "20:45" });
            items.Add(new ShiftElement { Date = "02.06.1997", Hour = "20:45" });
            items.Add(new ShiftElement { Date = "02.06.1997", Hour = "20:45" });
            items.Add(new ShiftElement { Date = "02.06.1997", Hour = "20:45" });
            items.Add(new ShiftElement { Date = "02.06.1997", Hour = "20:45" });
            visualTaskList.ItemsSource = items;
        }
    }

    public class ShiftElement
    {
        public string Date { get; set; }
        public string Hour { get; set; }
    }
}
