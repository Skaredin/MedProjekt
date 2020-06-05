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
using System.Data;
using System.Data.SqlClient;

namespace MedProjekt
{
    /// <summary>
    /// Логика взаимодействия для Bolnica.xaml
    /// </summary>
    public partial class Bolnica : Window
    {
        public Bolnica()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            MedProjekt.AProektSK1DataSet aProektSK1DataSet = ((MedProjekt.AProektSK1DataSet)(this.FindResource("aProektSK1DataSet")));
            // Загрузить данные в таблицу Priom_Hospital. Можно изменить этот код как требуется.
            MedProjekt.AProektSK1DataSetTableAdapters.Priom_HospitalTableAdapter aProektSK1DataSetPriom_HospitalTableAdapter = new MedProjekt.AProektSK1DataSetTableAdapters.Priom_HospitalTableAdapter();
            aProektSK1DataSetPriom_HospitalTableAdapter.Fill(aProektSK1DataSet.Priom_Hospital);
            System.Windows.Data.CollectionViewSource priom_HospitalViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("priom_HospitalViewSource")));
            priom_HospitalViewSource.View.MoveCurrentToFirst();
        }

        private void priom_HospitalDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {

            MedProjekt.AProektSK1DataSet aProektSK1DataSet = ((MedProjekt.AProektSK1DataSet)(this.FindResource("aProektSK1DataSet")));
            // Загрузить данные в таблицу Priom_Hospital. Можно изменить этот код как требуется.
            MedProjekt.AProektSK1DataSetTableAdapters.Priom_HospitalTableAdapter aProektSK1DataSetPriom_HospitalTableAdapter = new MedProjekt.AProektSK1DataSetTableAdapters.Priom_HospitalTableAdapter();
            aProektSK1DataSetPriom_HospitalTableAdapter.Fill(aProektSK1DataSet.Priom_Hospital);
            System.Windows.Data.CollectionViewSource priom_HospitalViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("priom_HospitalViewSource")));
            priom_HospitalViewSource.View.MoveCurrentToFirst();
        }

        private void Zapisatsa(object sender, RoutedEventArgs e)
        {

            ZapisatsaVi Zapisatsa = new ZapisatsaVi();
            Zapisatsa.Show();
        }
    }
}
