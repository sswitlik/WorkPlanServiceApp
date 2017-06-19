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
using WorkPlanServiceApp.localhost;
using System.Data.SQLite;

namespace WorkPlanServiceApp
{
    /// <summary>
    /// Logika interakcji dla klasy LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public MainWindow appMenu;
        private bool usernameClicked = false;

        public LoginPage(MainWindow menu)
        {
            InitializeComponent();
            appMenu = menu;
        }

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
            //Set Focus to next element in stackPacel
            var obj = sender as Control;
            int i = 0;
            for (i = 0; i < stack.Children.Count; i++)
                if (obj == stack.Children[i])
                    break;

            if (e.Key.Equals(Key.Enter))
            {
                stack.Children[i].Focusable = false;
                stack.Children[i + 1].Focusable = true;
                Keyboard.Focus(stack.Children[i + 1]);
            }
        }

        private void logIn_Click(object sender, RoutedEventArgs e)
        {
            appMenu.AppNavigation.Content = new UserPage(appMenu);




        }
    }
}



//HOW TO ADD DYNAMICLY
//Button but = new Button
//{
//    Name = "but",
//    Content = "but",
//    Height = 100
//};
//stack.Children.Add(but);


////Use webmethod
//var lol = new DyspozytorService();
//username.Text = lol.HelloWorld();


//SQLiteConnection.CreateFile("Placek.sqlite");

//SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Placek.sqlite;Version=3;");
//m_dbConnection.Open();

//string sql = "CREATE TABLE pracownik (id int, imie varchar(20), username varchar(20), password varchar(20), iduprawnienia int)";
//SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
//command.ExecuteNonQuery();

//sql = "insert into Pracownik (id, imie, username, password, iduprawnienia) values (1, 'Andrzej', 'a123', 'a123', 1)";
//command = new SQLiteCommand(sql, m_dbConnection);
//command.ExecuteNonQuery();

//sql = "insert into pracownik (id, imie, username, password, iduprawnienia) values (2, 'Bartosz', 'b123', 'b123', 1)";
//command = new SQLiteCommand(sql, m_dbConnection);
//command.ExecuteNonQuery();

//sql = "insert into pracownik (id, imie, username, password, iduprawnienia) values (3, 'Cezary', 'c123', 'c123', 2)";
//command = new SQLiteCommand(sql, m_dbConnection);
//command.ExecuteNonQuery();

////--

//sql = "CREATE TABLE zadanie (id int, nazwa varchar(20), skrotnazwy varchar(20), idListyzmian varchar(20))";
//command = new SQLiteCommand(sql, m_dbConnection);
//command.ExecuteNonQuery();

//sql = "insert into zadanie (id, nazwa, skrotnazwy, idListyzmian) values (1, 'Sprzatanie w Magazynie', 'Sprzatanie', 1)";
//command = new SQLiteCommand(sql, m_dbConnection);
//command.ExecuteNonQuery();

//sql = "insert into zadanie (id, nazwa, skrotnazwy, idListyzmian) values (2, 'Gotowanie w Kuchni', 'Gotownie', 2)";
//command = new SQLiteCommand(sql, m_dbConnection);
//command.ExecuteNonQuery();

////--

//sql = "CREATE TABLE zmiana (id int, dzien varchar(20), godzStart varchar(20), godzStop varchar(20), idListyZmian int)";
//command = new SQLiteCommand(sql, m_dbConnection);
//command.ExecuteNonQuery();

//sql = "insert into zmiana (id, dzien, godzStart, godzStop, idListyZmian) values (1, '14.12.1996', '08:00', '16:00', 1)";
//command = new SQLiteCommand(sql, m_dbConnection);
//command.ExecuteNonQuery();

//sql = "insert into zmiana (id, dzien, godzStart, godzStop, idListyZmian) values (2, '14.12.1996', '16:00', '24:00', 1)";
//command = new SQLiteCommand(sql, m_dbConnection);
//command.ExecuteNonQuery();

//sql = "insert into zmiana (id, dzien, godzStart, godzStop, idListyZmian) values (3, '15.12.1996', '08:00', '16:00', 1)";
//command = new SQLiteCommand(sql, m_dbConnection);
//command.ExecuteNonQuery();

//sql = "insert into zmiana (id, dzien, godzStart, godzStop, idListyZmian) values (4, '02.06.1997', '08:00', '14:00', 2)";
//command = new SQLiteCommand(sql, m_dbConnection);
//command.ExecuteNonQuery();

//sql = "insert into zmiana (id, dzien, godzStart, godzStop, idListyZmian) values (5, '02.06.1997', '08:00', '14:00', 2)";
//command = new SQLiteCommand(sql, m_dbConnection);
//command.ExecuteNonQuery();

//sql = "insert into zmiana (id, dzien, godzStart, godzStop, idListyZmian) values (6, '02.06.1997', '08:00', '14:00', 2)";
//command = new SQLiteCommand(sql, m_dbConnection);
//command.ExecuteNonQuery();

////--

//sql = "CREATE TABLE Listazmian (id int, idZadania)";
//command = new SQLiteCommand(sql, m_dbConnection);
//command.ExecuteNonQuery();

//sql = "insert into listazmian (id, idZadania) values (1,1)";
//command = new SQLiteCommand(sql, m_dbConnection);
//command.ExecuteNonQuery();

//sql = "insert into listazmian (id, idZadania) values (1,2)";
//command = new SQLiteCommand(sql, m_dbConnection);
//command.ExecuteNonQuery();

////--

//sql = "CREATE TABLE przydzialzadan(id int, idPracownika int, preferencja int, idzmiany int)";
//command = new SQLiteCommand(sql, m_dbConnection);
//command.ExecuteNonQuery();
