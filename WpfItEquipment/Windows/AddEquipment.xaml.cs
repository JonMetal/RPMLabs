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
    /// Логика взаимодействия для AddEquipment.xaml
    /// </summary>
    public partial class AddEquipment : Window
    {
        List<Equipment> _equipments = new();
        public AddEquipment(ref List<Equipment> equipments)
        {
            InitializeComponent();
            _equipments = equipments;
            comboBoxEquipmentType.ItemsSource = Enum.GetValues(typeof(EquipmentType));
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxId.Text != null && textBoxModel.Text != null)
            {
                _equipments.Add(new Equipment() { Id = int.Parse(textBoxId.Text), Model = textBoxModel.Text, Type = (EquipmentType)comboBoxEquipmentType.SelectedItem });
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
