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
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
        }
        private void JoinButton_Click(object sender, RoutedEventArgs e)
        {
            User user = SingleTonStorage.Storage.GetUser(LoginTextBox.Text, PasswordTextBox.Text);
            this.Hide();
            EquipmentForm MW = new EquipmentForm(user);
            MW.ShowDialog();
            LoginTextBox.Text = String.Empty;
            PasswordTextBox.Text = String.Empty;
            this.Show();
        }

        private void RegistryButton_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow window = new RegistrationWindow();
            this.Hide();
            window.ShowDialog();
            this.Show();
        }
    }
}
