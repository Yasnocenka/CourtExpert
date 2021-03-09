using CourtExpert.FormsToFillOut;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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

namespace CourtExpert.UsersWindow
{
    public partial class EmployeeWindow : Window
    {
        string connectionString;
        public EmployeeWindow()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["CourtExpertConnectionString"].ConnectionString;
        }

        private void ButtonClientCardClick(object sender, RoutedEventArgs e)
        {
            PersoneClientWindow form1 = new PersoneClientWindow();
            form1.Show();
        }

        private void ButtonLegalEntityClick(object sender, RoutedEventArgs e)
        {
            LegalEntityWindow form2 = new LegalEntityWindow();
            form2.Show();
        }

        private void ButtonIndividualPersonClick(object sender, RoutedEventArgs e)
        {
            PersoneClientWindow personeClientWindow = new PersoneClientWindow();
            personeClientWindow.Show();
        }
        private void DataBasePersoneClient(string sql)
        {
            DataTable employeeDT = new DataTable();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            //command.Parameters.Add("@LoginEmployee", SqlDbType.VarChar).Value = TextBoxLogin.Text;
            //command.Parameters.Add("@PasswordEmployee", SqlDbType.VarChar).Value = PasswordBox.Password;
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
    public class DataClient
    {
        public string FamilyName = "";
        public string FirstName = "";
        public int Patronimic = 0;
        public int Sex = 0;
        public int BirthDate = 0;
        public int BirthPlace = 0;
        public int PassportIssued = 0;
        public int DatePasportIssue = 0;
        public int DepartamentCode = 0;
        public int PasportSeries = 0;
        public int PassportNumber = 0;
        public int NumberINN = 0;
        public int NumberSnils = 0;
    }
}
