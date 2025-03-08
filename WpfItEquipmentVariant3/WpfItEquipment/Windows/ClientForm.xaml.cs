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
using WpfItEquipment.Models;

namespace WpfItEquipment.Windows
{
    /// <summary>
    /// Логика взаимодействия для ClientForm.xaml
    /// </summary>
    public partial class ClientForm : Window
    {
        List<Client> clientList = new() { new Client() { Id = 0, FullName= "MyasnikovAK", Telephone="79612320514"} };
        public ClientForm()
        {
            InitializeComponent();
            MainDataGrid.ItemsSource = clientList;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            List<Equipment> equipment123 = new();
            AddEquipment addEquipment = new();
            addEquipment.ShowDialog();
            if (addEquipment.DialogResult == true)
            {
                MainDataGrid.Items.Refresh();
            }
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            EditEquipment editEquipment = new((Equipment)MainDataGrid.SelectedItem);
            editEquipment.ShowDialog();
            if (editEquipment.DialogResult == true)
            {
                MainDataGrid.Items.Refresh();
            }
        }
    }
}
