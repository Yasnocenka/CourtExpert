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
    /// Логика взаимодействия для ClientCardWindow.xaml
    /// </summary>
    public partial class ClientCardWindow : Window
    {
        int PageNumber = 0; //Номер страницы (бланка)
        bool PersonNumber; //Тип лица (true - Физическое лицо; false - Юридическое лицо)

        /*Список страниц (бланков)*/
        ClientPassportData IndividualPage0 = new ClientPassportData();
        ClientSNILSData IndividualPage1 = new ClientSNILSData();
        LegalEntityData LegalPage0 = new LegalEntityData();
        public ClientCardWindow()
        {
            InitializeComponent();
        }

        private void ButtonLegalEntityClick(object sender, RoutedEventArgs e)
        {
            PersonNumber = false;
            SelectPage();
            VisibilityElements();
        }

        private void ButtonIndividualPersonClick(object sender, RoutedEventArgs e)
        {
            PersonNumber = true;
            SelectPage();
            VisibilityElements();
        }

        private void VisibilityElements() //Функция скрытия объектов
        {
            ButtonIndividualPerson.Visibility = Visibility.Hidden;
            ButtonLegalEntity.Visibility = Visibility.Hidden;
            ButtonNextPage.Visibility = Visibility.Visible;
            ButtonPreviousPage.Visibility = Visibility.Visible;
        }

        private void ButtonNextPageClick(object sender, RoutedEventArgs e)
        {
            PageNumber++;
            SelectPage();
        }

        private void ButtonPreviousPageClick(object sender, RoutedEventArgs e)
        {
            PageNumber--;
            SelectPage();
        }
        private void SelectPage() //функция отображения нужной страницы
        {
            if (PersonNumber)
            {
                switch (PageNumber)
                {
                    case -1: { PageNumber = 0; break; }
                    case 0: { ClientCardFrame.Navigate(IndividualPage0); break; }
                    case 1: { ClientCardFrame.Navigate(IndividualPage1); break; }
                    default: { PageNumber = 1; break; }
                }
            }
            else
            {
                switch (PageNumber)
                {
                    case 0: { ClientCardFrame.Navigate(LegalPage0); break; }
                    default: { PageNumber = 0; break; }
                }
            }
        }
    }
}
