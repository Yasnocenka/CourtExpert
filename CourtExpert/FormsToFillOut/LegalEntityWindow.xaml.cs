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

namespace CourtExpert.FormsToFillOut
{
    /// <summary>
    /// Логика взаимодействия для LegalEntityWindow.xaml
    /// </summary>
    public partial class LegalEntityWindow : Window
    {
        public LegalEntityWindow()
        {
            InitializeComponent();
        }

        private void CompleteButtonClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
