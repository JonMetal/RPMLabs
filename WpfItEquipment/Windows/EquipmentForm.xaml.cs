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
    /// Логика взаимодействия для EquipmentForm.xaml
    /// </summary>
    public partial class EquipmentForm : Window
    {
        List<Equipment> equipmentList = new() { new Equipment() { Id=0, Model="One", Type = EquipmentType.Printer} };
        public EquipmentForm(User user)
        {
            InitializeComponent();
            MainDataGrid.ItemsSource = equipmentList;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            AddEquipment addEquipment = new(ref equipmentList);
            addEquipment.ShowDialog();
            if(addEquipment.DialogResult == true)
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
