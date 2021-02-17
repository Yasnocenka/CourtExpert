using CourtExpert.UsersWindow;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CourtExpert
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void ButtonLog_Click(object sender, RoutedEventArgs e)
        {
            EmployeeWindow form2 = new EmployeeWindow();
            this.Hide();
            form2.ShowDialog();
            this.Show();
        }

        private void ButtonRegister_Click(object sender, RoutedEventArgs e)
        {
            Registration form2 = new Registration();
            this.Hide();
            form2.ShowDialog();
            this.Show();
        }
    }
}
