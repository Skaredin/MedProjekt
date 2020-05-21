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
using System.Data.SqlClient;
using System.Data;


namespace MedProjekt
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

        private void ToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            // Метод если будут не предвиденные ошибки при выполнение
            try
            {
                // Подключение к базе
                string con = @"Data Source=SBD\MSSQL;Initial Catalog=AProektSK;Integrated Security=True";

                string com = " Select * From Employees Where login='" + Login.Text.Trim() + "' and passvord = '" + Passvord.Text.Trim() + "'";

                string com1 = " Select * From Patients Where login='" + Login.Text.Trim() + "' and passvord = '" + Passvord.Text.Trim() + "'";


                using (SqlConnection connection = new SqlConnection(con))
                {
                    // Открываем соединение
                    connection.Open();
                    //Задаем переменные
                    SqlDataAdapter adapter = new SqlDataAdapter(com, connection);
                    SqlDataAdapter adapter1 = new SqlDataAdapter(com1, connection);
                    DataTable table = new DataTable();
                    DataTable table1 = new DataTable();
                    adapter.Fill(table);
                    adapter1.Fill(table1);
                    // Проверка на Executor


                    if (table.Rows.Count == 1)
                    {
                        Patients patients = new Patients();
                        patients.Show();
                        Hide();
                    }



                    // Проверка на Mesager
                    if (table1.Rows.Count == 1)
                    {
                        Employees employees = new Employees();
                        employees.Show();
                        Hide();
                    }

                }

            }
            catch
            {// Если в системе есть ошибка выводить в ошибку 
                MessageBox.Show("Не получены данные");

            }


        }

        private void ToggleButton_Checked_1(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            Hide();
        }
    }
}
