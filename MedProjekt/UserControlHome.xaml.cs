﻿using System;
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
    /// Логика взаимодействия для UserControlHome.xaml
    /// </summary>
    public partial class UserControlHome : UserControl
    {
        public UserControlHome()
        {
            InitializeComponent();

        }

       

        private void Bolnica(object sender, RoutedEventArgs e)
        {
            Bolnica bolnica = new Bolnica();
            bolnica.Show();
           
        }

        private void Poliklinika(object sender, RoutedEventArgs e)
        {

        }
    }
}
