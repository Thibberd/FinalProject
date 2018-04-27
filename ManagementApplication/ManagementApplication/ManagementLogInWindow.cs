using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ManagementApplication
{
    public partial class ManagementLogInWindow : Form
    {
        public ManagementLogInWindow()
        {
            InitializeComponent();
        }

        private void EnterPwordbtn_Click(object sender, EventArgs e)
        {

            
            bool CorrectUserPin = false;

            User currentUser = new User();
            string Enteredpassword = PinEnterTb.Text;
            SqlConnection connection = new SqlConnection();

            connection.ConnectionString = "Server =.; Database = systembar; Trusted_Connection = True;";

            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandText = "SELECT [UserID] ,[UserTypeID] ,[FirstName],[SecondName],[Pin] FROM systembar.dbo.Users WHERE [PIN] = " + Enteredpassword;
            command.CommandType = CommandType.Text;


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    currentUser.userID = (int)reader["UserID"];
                    currentUser.userType = (int)reader["UserTypeID"];
                    currentUser.firstname = (string)reader["FirstName"];
                    currentUser.secondname = (string)reader["SecondName"];
                    currentUser.PIN = (int)reader["Pin"];
                    CorrectUserPin = true;
                }

                    if (CorrectUserPin == false)
                    {
                        
                        CheckUserTypeAndPin(currentUser.userType, CorrectUserPin);
                    }
                    else if (CorrectUserPin == true)
                    {
                        CheckUserTypeAndPin(currentUser.userType, CorrectUserPin);
                    }


                reader.Close();
            }
            catch
            {
                CorrectUserPin = false;
                CheckUserTypeAndPin(1, CorrectUserPin);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }




          void CheckUserTypeAndPin (int userType, bool CorrectPin){


                if (CorrectPin == true)
                {
                    if (userType == 1)
                    {

                        this.Hide();
                        Dashboard managementDashboard = new Dashboard();
                        managementDashboard.Show();
                    }
                    else
                    {
                        MessageBox.Show("You are not permitted access");
                        PinEnterTb.Text = "";
                    }
                }
                else if(CorrectPin == false)
                {
                    MessageBox.Show("please Enter a corrrect Pin");
                    PinEnterTb.Text = "";
                }
            }

             
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            PinEnterTb.Text = "";
        }
    }
}
