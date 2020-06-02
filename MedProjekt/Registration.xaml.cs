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
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;

namespace MedProjekt
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        string con = @"Data Source=SBD\MSSQL;Initial Catalog=AProektSK;Integrated Security=True";

        public Registration()
        {
            InitializeComponent();
        }

        private void Regist(object sender, RoutedEventArgs e)
        {
            // Метод если будут не предвиденные ошибки при выполнение
            try
            {
                //if (textBox4.Text == "create mask" && textBox5.Text == "create mask" && textBox5.Text == "create mask" != create mask )
                //{
                //    MessageBox.Show("В полях (фамилия, имя, отчество) не должны содержаться цифры ");
                //}
                //else

                // Проверка на заполнение полей

                if (Login.Text == "" || Passvord.Text == "")
                {
                    MessageBox.Show("Незаполнены поля проверти и повторите попытку");
                }
                // на схожесть паролей
                else if (Passvord.Text != Dooble_passvord.Text)
                {
                    MessageBox.Show("Неправильно был ведён пароль (Повтор пароля)");
                }
                else
                {

                    using (SqlConnection sqlCon = new SqlConnection(con))
                    {
                        // Открываем соединение
                        sqlCon.Open();
                        //Соотношение полей в базе
                        SqlCommand sqlCmd = new SqlCommand("PatientsAdd", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@id_Patients", " ");                      
                        sqlCmd.Parameters.AddWithValue("@Login", Login.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Passvord", Passvord.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Surname", Familia.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Name", Name.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Middle_name", Otcestvo.Text.Trim());
                        sqlCmd.ExecuteNonQuery();
                        //Если всё было введено правильно вы водит MessageBox текст "ВЫ зарегистрировались" 
                        MessageBox.Show("ВЫ зарегистрировались");
                        clar();
                        //Переходит на форму Avtorizacia
                        MainWindow mainWindow = new MainWindow();
                        mainWindow.Show();
                        Hide();
                    }
                }

            }
            catch
            {
                // Если в системе есть ошибка выводить в ошибку 
                MessageBox.Show("Не получены данные");

            }

            void clar()
            {
                Login.Text = Passvord.Text = Familia.Text = Name.Text = Otcestvo.Text;
            }
        

        }

        private void Nazad(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Hide();
        }
    }
}
