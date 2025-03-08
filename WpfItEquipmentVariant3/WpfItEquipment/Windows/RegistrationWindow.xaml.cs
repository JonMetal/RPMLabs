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
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
            comboBoxRole.ItemsSource = Enum.GetValues(typeof(UserRole));
            comboBoxRole.SelectedIndex = 0;
        }

        private void buttonAgree_Click(object sender, RoutedEventArgs e)
        {
            if(textBoxLogin.Text != "" && textBoxPassword.Text != "")
            {
                SingleTonStorage.Storage.AddUser(textBoxLogin.Text, textBoxPassword.Text, comboBoxRole.SelectedIndex);
            }
            Close();
        }

        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
