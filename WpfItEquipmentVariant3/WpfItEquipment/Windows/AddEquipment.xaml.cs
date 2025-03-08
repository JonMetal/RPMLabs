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
    /// Логика взаимодействия для AddEquipment.xaml
    /// </summary>
    public partial class AddEquipment : Window
    {
        public AddEquipment()
        {
            InitializeComponent();
            comboBoxEquipmentType.ItemsSource = Enum.GetValues(typeof(EquipmentType));
            comboBoxEquipmentType.SelectedIndex = 0;
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxModel.Text != "")
            {
                SingleTonStorage.Storage.AddEquipment(textBoxModel.Text, comboBoxEquipmentType.SelectedIndex);
                this.DialogResult = true;
            }
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            Close();
        }
    }
}
