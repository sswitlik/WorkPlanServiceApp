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
    /// Logika interakcji dla klasy AvailibilityPage.xaml
    /// </summary>
    public partial class AvailibilityPage : Page
    {
        public List<Task> taskList;
        private UserPage parentPage;

        public AvailibilityPage(UserPage parent)
        {
            InitializeComponent();
            taskList = new List<Task>();    //= web.getTasks()
            parentPage = parent;
            this.DataContext = this;

            init();
        }

        private void init()
        {
            var items = new List<Task>();
            for (int i = 0; i < 15; i++)    //while i don't have webmethod
            {
                taskList.Add(new Task { shortName = "a" + i.ToString(), shiftSum = 0 });
            }
            visualTaskList.ItemsSource = taskList;

            //for (int i = 0; i < taskList.Count; i++)
            //{
            //    var but = new Button
            //    {
            //        Content = taskList[i].shortName,
            //        Height = 25,
            //        Width = 100,
            //        HorizontalAlignment = HorizontalAlignment.Left,
            //        Margin = new Thickness(5),
            //        Uid = i.ToString(),
            //    };
            //    but.Click += taskClick;
            //    //taskView.Children.Add(but);
            //}
        }

        private void TaskClick(object sender, RoutedEventArgs e)
        {
            Button but = sender as Button;
            Task clickedTask = but.DataContext as Task;
            parentPage.ActiveFuctionality.Content = new TaskPage(clickedTask);
        }
        //private void taskClick(object sender, RoutedEventArgs e)
        //{
        //    var but = sender as Button;
        //    parentPage.ActiveFuctionality.Content = new TaskPage(taskList[Int32.Parse(but.Uid)]);
        //}
    }
    public class TaskElement
    {
        public string shortName { get; set; }
        public int shiftSum { get; set; }
    }
}
