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

namespace CourtExpert
{
    public partial class Registration : Window
    {
        string connectionString;
        public Registration()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["CourtExpertConnectionString"].ConnectionString;
        }

        private void ButtonLog_Click(object sender, RoutedEventArgs e)
        {
            bool english = true;
            bool number = false;
            string message = ""; 

            if (PasswordBox.Password == PasswordBoxRepeat.Password)
            {
                for (int i = 0; i < PasswordBox.Password.Length; i++) // перебираем символы
                {
                    if (PasswordBox.Password[i] >= 'А' && PasswordBox.Password[i] <= 'Я')
                        english = false; 
                    if (PasswordBox.Password[i] >= '0' && PasswordBox.Password[i] <= '9') 
                        number = true; 
                }

                if (!english)
                {
                    message += "Доступна только английская раскладка\n"; 
                } 
                 
                if (!number)
                {
                    message += "Добавьте хотя бы одну цифру\n"; 
                }
                
                if (english && number) 
                {
                    string sqlSave = "insert into Employee values (@LoginEmployee, @PasswordEmployee, 2)";
                    DataBaseRegistration(sqlSave);
                    this.Close();
                }
                     
                if (PasswordBox.Password.Length < 6)
                {
                    message += "Пароль слишком короткий, минимум 6 символов\n"; 
                }

                LabelMeessage.Content = message;
            }
        }
        private void DataBaseRegistration(string sql)
        {
            DataTable employeeDT = new DataTable();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.Add("@LoginEmployee", SqlDbType.VarChar).Value = TextBoxLogin.Text;
            command.Parameters.Add("@PasswordEmployee", SqlDbType.VarChar).Value = PasswordBox.Password;
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
