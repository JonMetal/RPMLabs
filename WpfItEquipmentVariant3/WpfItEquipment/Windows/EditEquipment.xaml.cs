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
    /// Логика взаимодействия для EditEquipment.xaml
    /// </summary>
    public partial class EditEquipment : Window
    {
        Equipment editingEquip;
        public EditEquipment(Equipment equipment)
        {
            editingEquip = equipment;
            InitializeComponent();
            textBoxModel.Text = editingEquip.Model;
            comboBoxEquipmentType.ItemsSource = Enum.GetValues(typeof(EquipmentType));
            comboBoxEquipmentType.SelectedItem = editingEquip.Type;
        }

        private void ButtonConfirm_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxModel.Text != "")
            {
                editingEquip.Model = textBoxModel.Text;
                editingEquip.Type = (EquipmentType)comboBoxEquipmentType.SelectedItem;
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
