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

namespace FrontOfHouseSystem
{
    public partial class UserLogInWindow : Form

    {

        private string Enteredpassword = "";// string to strore entered password
        //private string CheckPassword;


        public UserLogInWindow()
        {
            InitializeComponent();
            OrderList.Hide();
            DateTime TodayDateandTime = DateTime.Now;
            DandTlbl.Text = TodayDateandTime.ToString();



        }
        
        

        private void Enterbtn_Click(object sender, EventArgs e)
        {

            User currentUser = new User();
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
  
                }

                reader.Close();
            }
            catch
            {
                MessageBox.Show("Please Enter Correct PIN");
                Passwordtxtb.Text = "";
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }


            Usernamelbl.Text = currentUser.firstname + " " + currentUser.secondname;
            this.Hide();
            FOHDashboard fOHDashboard = new FOHDashboard(currentUser.userID, currentUser.firstname, currentUser.secondname, OrderList.Items, Usernamelbl.Text);
            fOHDashboard.Show();
        }

        

        private void Nmbronebtn_Click(object sender, EventArgs e)
        {
            Passwordtxtb.Text = Passwordtxtb.Text + "*";
            Enteredpassword = Enteredpassword + "1";
        }

        private void NmbrTwobtn_Click(object sender, EventArgs e)
        {
            Passwordtxtb.Text = Passwordtxtb.Text + "*";
            Enteredpassword = Enteredpassword + "2";
        }

        private void Nmbrthreebtn_Click(object sender, EventArgs e)
        {
            Passwordtxtb.Text = Passwordtxtb.Text + "*";
            Enteredpassword = Enteredpassword + "3";
        }

        private void Nmbrfourbtn_Click(object sender, EventArgs e)
        {
            Passwordtxtb.Text = Passwordtxtb.Text + "*";
            Enteredpassword = Enteredpassword + "4";
        }

        private void Nmbrfivebtn_Click(object sender, EventArgs e)
        {
            Passwordtxtb.Text = Passwordtxtb.Text + "*";
            Enteredpassword = Enteredpassword + "5";
        }

        private void Nmbrsixbtn_Click(object sender, EventArgs e)
        {
            Passwordtxtb.Text = Passwordtxtb.Text + "*";
            Enteredpassword = Enteredpassword + "6";
        }

        private void Nmbrsevenbtn_Click(object sender, EventArgs e)
        {
            Passwordtxtb.Text = Passwordtxtb.Text + "*";
            Enteredpassword = Enteredpassword + "7";
        }

        private void Nmbreightbtn_Click(object sender, EventArgs e)
        {
            Passwordtxtb.Text = Passwordtxtb.Text + "*";
            Enteredpassword = Enteredpassword + "8";
        }

        private void Nmbrninebtn_Click(object sender, EventArgs e)
        {
            Passwordtxtb.Text = Passwordtxtb.Text + "*";
            Enteredpassword = Enteredpassword + "9";
        }

        private void Nmbrzerobtn_Click(object sender, EventArgs e)
        {
            Passwordtxtb.Text = Passwordtxtb.Text + "*";
            Enteredpassword = Enteredpassword + "0";
        }


        public void clearPassword()
        {
            Passwordtxtb.Text = "";
        }

            
            
        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            clearPassword();
        }
    }
}
