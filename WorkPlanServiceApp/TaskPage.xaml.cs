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
using System.Data.SQLite;

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
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Placek.sqlite;Version=3;");
            m_dbConnection.Open();

            string sql = "select * from zmiana";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                shiftList.Add(new Shift { id = Int32.Parse(reader["id"].ToString()), dayDate = reader["dzien"].ToString(), hourStart = reader["godzstart"].ToString(), hourStop = reader["godzstop"].ToString(), preference = 0});
            }

            //shiftList.Add(new Shift { dayDate = "14.12.1996", hourStart = "8:00", hourStop = "16:00"});
            //shiftList.Add(new Shift { dayDate = "02.06.1997", hourStart = "20:45", hourStop = "20:50" });
            //shiftList.Add(new Shift { dayDate = "4.12.2016", hourStart = "8:00", hourStop = "16:00" });
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
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Placek.sqlite;Version=3;");
            m_dbConnection.Open();

            //string sql = "insert into przydzialzadan (id, idPracownika, preferencja, idzmiany) values (1,"+ " '14.12.1996', '08:00', '16:00', 1)";
            //SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            //command.ExecuteNonQuery();
        }
    }
}
