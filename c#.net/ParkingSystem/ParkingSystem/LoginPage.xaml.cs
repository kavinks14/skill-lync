using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace ParkingSystem
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : UserControl
    {
        public LoginPage()
        {
            InitializeComponent();
        }


        private void bnt1_Click_1(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Server=(LocalDB)\MSSQLLocalDB;Database=Parking Slots;Trusted_Connection=True;");
            try
            {
                if (sqlCon.State ==System.Data.ConnectionState.Closed)
                    sqlCon.Open();
                string query = "SELECT COUNT (1) FROM ParkingLoginPage WHERE UserName=@username AND PassWord=@password";
                SqlCommand sqlCommand = new SqlCommand(query, sqlCon);
                sqlCommand.CommandType = System.Data.CommandType.Text;
                sqlCommand.Parameters.AddWithValue("@Username", txt1.Text);
                sqlCommand.Parameters.AddWithValue("@password", pass1.Password);
                int count = Convert.ToInt32(sqlCommand.ExecuteScalar());
                if (count == 1)
                {
                    EvenNotifier.RaisePageChanged("vehicleSlot");
                }
                else
                {
                    MessageBox.Show("username or password wrong");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }

           
    }   }    
}
 
