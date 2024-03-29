﻿using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace MedProjekt
{
    /// <summary>
    /// Логика взаимодействия для Employees.xaml
    /// </summary>
    public partial class Employees : Window
    {
        public Employees()
        {
          
            InitializeComponent();
           

        }
        //public void Text()
        //{
        //    const string con = @"Data Source=SBD\MSSQL;Initial Catalog=AProektSK;Integrated Security=True";
        //    string sqlcmd = "SELECT Name FROM Employees";

        //    using (OleDbConnection c = new OleDbConnection(con))
        //    {
        //        OleDbCommand cmd = new OleDbCommand(sqlcmd, c);
        //        c.Open();
        //        OleDbDataReader rd;
        //        rd = cmd.ExecuteReader();
        //        while (rd.Read())
        //        {
        //            testTextBox.Text = rd[0].ToString();
        //        }
        //    }
        //}




        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            ButtonOpenMenu.Visibility = Visibility.Visible;
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Visible;
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UserControl usc = null;
            GridMain.Children.Clear();

            switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
            {
                case "ItemCreate":
                    usc = new UserControlHome();
                    GridMain.Children.Add(usc);
                    break;

                default:
                    break;
            }
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Close(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
