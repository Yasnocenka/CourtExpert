using CourtExpert.UsersWindow;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows;
using System.Configuration;

namespace CourtExpert
{
    public partial class LoginWindow : Window
    {
        string connectionString;

        public LoginWindow()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["CourtExpertConnectionString"].ConnectionString;
        }

        private void WinLogin_Loaded(object sender, RoutedEventArgs e)
        {
           
        }

        private void ButtonLog_Click(object sender, RoutedEventArgs e)
        {
            //string sql = "select UserID, LoginEmployee, PasswordEmployee, NameRole from Employee join Roles on RoleFK = Roles.RolesID ";
            string sqlEmployee = "select * from Employee where LoginEmployee = @TextBoxLogin and PasswordEmployee = @PasswordBox and RoleFK = 2";
            string sqlAdministrator = "select * from Employee where LoginEmployee = @TextBoxLogin and PasswordEmployee = @PasswordBox and RoleFK = 1";

            if (DataBaseLogin(sqlEmployee) > 0)
            {
                EmployeeWindow form2 = new EmployeeWindow();
                this.Hide();
                form2.ShowDialog();
                this.Show();
            }
            if (DataBaseLogin(sqlAdministrator) > 0)
            {
                AdministatorWindow form2 = new AdministatorWindow();
                this.Hide();
                form2.ShowDialog();
                this.Show();
            }
        }
        private void ButtonRegister_Click(object sender, RoutedEventArgs e)
        {
            Registration form2 = new Registration();
            this.Hide();
            form2.ShowDialog();
            this.Show();
        }
        private int DataBaseLogin(string sql)
        {
            DataTable employeeDT = new DataTable();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.Add("@TextBoxLogin", SqlDbType.VarChar).Value = TextBoxLogin.Text;
            command.Parameters.Add("@PasswordBox", SqlDbType.VarChar).Value = PasswordBox.Password;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(employeeDT);
            connection.Close();
            return employeeDT.Rows.Count;
        }
    }
}
