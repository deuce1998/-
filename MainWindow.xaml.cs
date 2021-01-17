using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
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

namespace Ресторан
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

       
        }

        private void Aut_Click(object sender, RoutedEventArgs e)
        {
            DataBaseAcc.DBConnection connection = new DataBaseAcc.DBConnection();
       
            string query = "SELECT Имя, Отчество FROM Сотрудники WHERE Пароль='" + pass.Text + "'";

            OleDbCommand command = new OleDbCommand(query, connection.myConnection);
            string name;
            if (connection.myConnection.State == ConnectionState.Open)
            {
               name= command.ExecuteScalar().ToString();
                MessageBox.Show("Добро пожаловать " + name);
                Window1 window1 = new Window1();
                window1.Show();
                this.Close();
            }    
                
            else
                throw new Exception("Подключение к базе данных отсутствует!");

            

            connection.Dispose();

        }


       
    }
}
