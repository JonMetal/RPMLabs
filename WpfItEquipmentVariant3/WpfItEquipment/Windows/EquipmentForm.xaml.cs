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
using WpfItEquipment.UTILS;

namespace WpfItEquipment.Windows
{
    /// <summary>
    /// Логика взаимодействия для EquipmentForm.xaml
    /// </summary>
    public partial class EquipmentForm : Window
    {
        List<Equipment> equipmentList = SingleTonStorage.Storage.GetEquipments();
        public EquipmentForm(User user)
        {
            InitializeComponent();
            MainDataGrid.ItemsSource = equipmentList;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            AddEquipment addEquipment = new();
            addEquipment.ShowDialog();
            if(addEquipment.DialogResult == true)
            {
                Update();
            }
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            Equipment equipment = (Equipment)MainDataGrid.SelectedItem;
            EditEquipment editEquipment = new(equipment);
            editEquipment.ShowDialog();
            if (editEquipment.DialogResult == true)
            {
                SingleTonStorage.Storage.UpdateEquipment(equipment);
                Update();
            }
        }

        private void Update()
        {
            equipmentList = SingleTonStorage.Storage.GetEquipments();
            MainDataGrid.ItemsSource = equipmentList;
            MainDataGrid.Items.Refresh();
        }
    }
}
