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
    public partial class FOHDashboard : Form


    {

        public float NewTotal ;
        public float OriginalTotal ;
        public float ItemPrice  ;
        public float RunningTotal;
        int userID;
        string firstName;
        string lastName;
        float CalculatedChange;
        public FOHDashboard(int UserID, string FirstName, string LastName,ListBox.ObjectCollection orderItems, string userName, string amountLabel, float runningTotal)
        {
            InitializeComponent();

           OrderList.Items.AddRange(orderItems);
           Usernamelbl.Text = FirstName + " " + LastName;
           RunningTotal = runningTotal;

            userID = UserID;
            firstName = FirstName;
            lastName = LastName;

            
            AmountLabel.Text = RunningTotal.ToString("£#0.00");


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Sparklingbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SparklingWindow sparklingWindow = new SparklingWindow(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text, AmountLabel.Text, RunningTotal);
            sparklingWindow.Show();
        }

        private void Softbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SoftdrinksWindow softdrinksWindow = new SoftdrinksWindow(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text, AmountLabel.Text, RunningTotal);
            softdrinksWindow.Show();
        }

        

        private void Draught_Click(object sender, EventArgs e)
        {
            this.Hide();
            DraughtWindow draughtWindow = new DraughtWindow(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text, AmountLabel.Text, RunningTotal);
            draughtWindow.Show();
            
        }

        private void Bottlesbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            BottlesWindow bottlesWindow = new BottlesWindow(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text, AmountLabel.Text, RunningTotal);
            bottlesWindow.Show();
        }

        private void Spiritsbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SpiritsWindow spiritsWindow = new SpiritsWindow(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text, AmountLabel.Text, RunningTotal);
            spiritsWindow.Show();
        }

        private void Winebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            WineWindow wineWindow = new WineWindow(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text, AmountLabel.Text, RunningTotal);
            wineWindow.Show();
        }

        private void Liquersbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LiquersWindow liquersWindow  = new LiquersWindow(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text, AmountLabel.Text, RunningTotal);
            liquersWindow.Show();
        }

        private void Cocktailsbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CocktailsWindow cocktailsWindow = new CocktailsWindow(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text, AmountLabel.Text, RunningTotal);
            cocktailsWindow.Show();
        }

        private void Carlingbtn_Click(object sender, EventArgs e)
        {
            
            SqlConnection connection = new SqlConnection();

            connection.ConnectionString = "Server =.; Database = systembar; Trusted_Connection = True;";

            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandText = "SELECT [ProductName],[UnitPrice] FROM systembar.dbo.Product WHERE [ProductName] = 'Carling'";
            command.CommandType = CommandType.Text;

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Product product = new Product();
                    product.productName = (string)reader["ProductName"];          
                    product.unitPrice = float.Parse((string)reader["UnitPrice"].ToString());
                    ItemPrice = product.unitPrice;
                   
                   

                    OrderList.Items.Add(product.productName + "              " +  product.unitPrice.ToString("£#0.00"));

                    NewTotal = NewTotal + product.unitPrice;

                    RunningTotal = NewTotal;
                    AmountLabel.Text = NewTotal.ToString("£#0.00");
                }

                reader.Close();
            }
            catch
            {
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            

        }

        private void Voidbtn_Click(object sender, EventArgs e)
        {
            int iLastInd = OrderList.Items.Count - 1;
            if (iLastInd >= 0) {
                OrderList.Items.RemoveAt(iLastInd);
                NewTotal = RunningTotal - ItemPrice;
                RunningTotal = NewTotal;
                AmountLabel.Text = NewTotal.ToString("#£0.00");            }
        }

        private void Amstelbtn_Click(object sender, EventArgs e)
        {


            SqlConnection connection = new SqlConnection();

            connection.ConnectionString = "Server =.; Database = systembar; Trusted_Connection = True;";

            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandText = "SELECT [ProductName],[UnitPrice] FROM systembar.dbo.Product WHERE [ProductName] = 'Amstel'";
            command.CommandType = CommandType.Text;

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Product product = new Product();
                    product.productName = (string)reader["ProductName"];
                    product.unitPrice = float.Parse((string)reader["UnitPrice"].ToString());
                    ItemPrice = product.unitPrice;

                    OrderList.Items.Add(product.productName + "              " + product.unitPrice.ToString("£#0.00"));

                    NewTotal = RunningTotal + product.unitPrice;
                    RunningTotal = NewTotal;


                    AmountLabel.Text = NewTotal.ToString("£#0.00");
                }

                reader.Close();
            }
            catch
            {
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

        }

        private void Guinessbtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();

            connection.ConnectionString = "Server =.; Database = systembar; Trusted_Connection = True;";

            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandText = "SELECT [ProductName],[UnitPrice] FROM systembar.dbo.Product WHERE [ProductName] = 'Guiness'";
            command.CommandType = CommandType.Text;

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Product product = new Product();
                    product.productName = (string)reader["ProductName"];
                    product.unitPrice = float.Parse((string)reader["UnitPrice"].ToString());
                    ItemPrice = product.unitPrice;

                   
                    OrderList.Items.Add(product.productName + "              " + product.unitPrice.ToString("£#0.00"));

                    NewTotal = RunningTotal + product.unitPrice;
                    RunningTotal = NewTotal;


                    AmountLabel.Text = NewTotal.ToString("£#0.00");
                }

                reader.Close();
            }
            catch
            {
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void Strongbowbtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();

            connection.ConnectionString = "Server =.; Database = systembar; Trusted_Connection = True;";

            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandText = "SELECT [ProductName],[UnitPrice] FROM systembar.dbo.Product WHERE [ProductName] = 'Strongbow'";
            command.CommandType = CommandType.Text;

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Product product = new Product();
                    product.productName = (string)reader["ProductName"];
                    product.unitPrice = float.Parse((string)reader["UnitPrice"].ToString());
                    ItemPrice = product.unitPrice;


                    OrderList.Items.Add(product.productName + "              " + product.unitPrice.ToString("£#0.00"));

                    NewTotal = RunningTotal + product.unitPrice;
                    RunningTotal = NewTotal;


                    AmountLabel.Text = NewTotal.ToString("£#0.00");
                }

                reader.Close();
            }
            catch
            {
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

        }

        private void Thatchersbtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();

            connection.ConnectionString = "Server =.; Database = systembar; Trusted_Connection = True;";

            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandText = "SELECT [ProductName],[UnitPrice] FROM systembar.dbo.Product WHERE [ProductName] = 'Thatchers Original'";
            command.CommandType = CommandType.Text;

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Product product = new Product();
                    product.productName = (string)reader["ProductName"];
                    product.unitPrice = float.Parse((string)reader["UnitPrice"].ToString());
                    ItemPrice = product.unitPrice;


                    OrderList.Items.Add(product.productName + "              " + product.unitPrice.ToString("£#0.00"));

                    NewTotal = RunningTotal + product.unitPrice;
                    RunningTotal = NewTotal;


                    AmountLabel.Text = NewTotal.ToString("£#0.00");
                }

                reader.Close();
            }
            catch
            {
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void RattlerObtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();

            connection.ConnectionString = "Server =.; Database = systembar; Trusted_Connection = True;";

            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandText = "SELECT [ProductName],[UnitPrice] FROM systembar.dbo.Product WHERE [ProductName] = 'Rattler Original'";
            command.CommandType = CommandType.Text;

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Product product = new Product();
                    product.productName = (string)reader["ProductName"];
                    product.unitPrice = float.Parse((string)reader["UnitPrice"].ToString());
                    ItemPrice = product.unitPrice;


                    OrderList.Items.Add(product.productName + "              " + product.unitPrice.ToString("£#0.00"));

                    NewTotal = RunningTotal + product.unitPrice;
                    RunningTotal = NewTotal;


                    AmountLabel.Text = NewTotal.ToString("£#0.00");
                }

                reader.Close();
            }
            catch
            {
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void Smirnoffbtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();

            connection.ConnectionString = "Server =.; Database = systembar; Trusted_Connection = True;";

            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandText = "SELECT [ProductName],[UnitPrice] FROM systembar.dbo.Product WHERE [ProductName] = 'Smirnoff Vodka'";
            command.CommandType = CommandType.Text;

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Product product = new Product();
                    product.productName = (string)reader["ProductName"];
                    product.unitPrice = float.Parse((string)reader["UnitPrice"].ToString());
                    ItemPrice = product.unitPrice;


                    OrderList.Items.Add(product.productName + "              " + product.unitPrice.ToString("£#0.00"));

                    NewTotal = RunningTotal + product.unitPrice;
                    RunningTotal = NewTotal;


                    AmountLabel.Text = NewTotal.ToString("£#0.00");
                }

                reader.Close();
            }
            catch
            {
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            MixersWindow mixersWindow = new MixersWindow(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text, AmountLabel.Text, RunningTotal);
            mixersWindow.Show();
        }

        private void Gordansbtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();

            connection.ConnectionString = "Server =.; Database = systembar; Trusted_Connection = True;";

            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandText = "SELECT [ProductName],[UnitPrice] FROM systembar.dbo.Product WHERE [ProductName] = 'Gordan's'";
            command.CommandType = CommandType.Text;

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Product product = new Product();
                    product.productName = (string)reader["ProductName"];
                    product.unitPrice = float.Parse((string)reader["UnitPrice"].ToString());
                    ItemPrice = product.unitPrice;


                    OrderList.Items.Add(product.productName + "              " + product.unitPrice.ToString("£#0.00"));

                    NewTotal = RunningTotal + product.unitPrice;
                    RunningTotal = NewTotal;


                    AmountLabel.Text = NewTotal.ToString("£#0.00");
                }

                reader.Close();
            }
            catch
            {
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            MixersWindow mixersWindow = new MixersWindow(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text, AmountLabel.Text, RunningTotal);
            mixersWindow.Show();
        }

        private void Jackdanielsbtn_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection();

            connection.ConnectionString = "Server =.; Database = systembar; Trusted_Connection = True;";

            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandText = "SELECT [ProductName],[UnitPrice] FROM systembar.dbo.Product WHERE [ProductName] = 'Jack Daniels'";
            command.CommandType = CommandType.Text;

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Product product = new Product();
                    product.productName = (string)reader["ProductName"];
                    product.unitPrice = float.Parse((string)reader["UnitPrice"].ToString());
                    ItemPrice = product.unitPrice;


                    OrderList.Items.Add(product.productName + "              " + product.unitPrice.ToString("£#0.00"));

                    NewTotal = RunningTotal + product.unitPrice;
                    RunningTotal = NewTotal;


                    AmountLabel.Text = NewTotal.ToString("£#0.00");
                }

                reader.Close();
            }
            catch
            {
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
            MixersWindow mixersWindow = new MixersWindow(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text, AmountLabel.Text, RunningTotal);
            mixersWindow.Show();

        }

        private void Chardonnaybtn_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection();

            connection.ConnectionString = "Server =.; Database = systembar; Trusted_Connection = True;";

            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandText = "SELECT [ProductName],[UnitPrice] FROM systembar.dbo.Product WHERE [ProductName] = 'Hardys Chardonnay'";
            command.CommandType = CommandType.Text;

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Product product = new Product();
                    product.productName = (string)reader["ProductName"];
                    product.unitPrice = float.Parse((string)reader["UnitPrice"].ToString());
                    ItemPrice = product.unitPrice;


                    OrderList.Items.Add(product.productName + "              " + product.unitPrice.ToString("£#0.00"));

                    NewTotal = RunningTotal + product.unitPrice;
                    RunningTotal = NewTotal;


                    AmountLabel.Text = NewTotal.ToString("£#0.00");
                }

                reader.Close();
            }
            catch
            {
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }


        }

        private void Blossomhillbtn_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection();

            connection.ConnectionString = "Server =.; Database = systembar; Trusted_Connection = True;";

            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandText = "SELECT [ProductName],[UnitPrice] FROM systembar.dbo.Product WHERE [ProductName] = 'Blossom Hill Rose'";
            command.CommandType = CommandType.Text;

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Product product = new Product();
                    product.productName = (string)reader["ProductName"];
                    product.unitPrice = float.Parse((string)reader["UnitPrice"].ToString());
                    ItemPrice = product.unitPrice;


                    OrderList.Items.Add(product.productName + "              " + product.unitPrice.ToString("£#0.00"));

                    NewTotal = RunningTotal + product.unitPrice;
                    RunningTotal = NewTotal;


                    AmountLabel.Text = NewTotal.ToString("£#0.00");
                }

                reader.Close();
            }
            catch
            {
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void Shirazbtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();

            connection.ConnectionString = "Server =.; Database = systembar; Trusted_Connection = True;";

            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandText = "SELECT [ProductName],[UnitPrice] FROM systembar.dbo.Product WHERE [ProductName] = 'Hardys Shiraz'";
            command.CommandType = CommandType.Text;

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Product product = new Product();
                    product.productName = (string)reader["ProductName"];
                    product.unitPrice = float.Parse((string)reader["UnitPrice"].ToString());
                    ItemPrice = product.unitPrice;


                    OrderList.Items.Add(product.productName + "              " + product.unitPrice.ToString("£#0.00"));

                    NewTotal = RunningTotal + product.unitPrice;
                    RunningTotal = NewTotal;


                    AmountLabel.Text = NewTotal.ToString("£#0.00");
                }

                reader.Close();
            }
            catch
            {
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void Cocacolabtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();

            connection.ConnectionString = "Server =.; Database = systembar; Trusted_Connection = True;";

            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandText = "SELECT [ProductName],[UnitPrice] FROM systembar.dbo.Product WHERE [ProductName] = 'Coca - Cola'";
            command.CommandType = CommandType.Text;

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Product product = new Product();
                    product.productName = (string)reader["ProductName"];
                    product.unitPrice = float.Parse((string)reader["UnitPrice"].ToString());
                    ItemPrice = product.unitPrice;


                    OrderList.Items.Add(product.productName + "              " + product.unitPrice.ToString("£#0.00"));

                    NewTotal = RunningTotal + product.unitPrice;
                    RunningTotal = NewTotal;


                    AmountLabel.Text = NewTotal.ToString("£#0.00");
                }

                reader.Close();
            }
            catch
            {
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void Lemonadebtn_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection();

            connection.ConnectionString = "Server =.; Database = systembar; Trusted_Connection = True;";

            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandText = "SELECT [ProductName],[UnitPrice] FROM systembar.dbo.Product WHERE [ProductName] = 'Scwepps Lemonade'";
            command.CommandType = CommandType.Text;

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Product product = new Product();
                    product.productName = (string)reader["ProductName"];
                    product.unitPrice = float.Parse((string)reader["UnitPrice"].ToString());
                    ItemPrice = product.unitPrice;


                    OrderList.Items.Add(product.productName + "              " + product.unitPrice.ToString("£#0.00"));

                    NewTotal = RunningTotal + product.unitPrice;
                    RunningTotal = NewTotal;


                    AmountLabel.Text = NewTotal.ToString("£#0.00");
                }

                reader.Close();
            }
            catch
            {
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

        }

        private void Cashbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transaction transaction = new Transaction();
            transaction.transactionID = 4;
            EnterAmount enterAmount = new EnterAmount(RunningTotal, OrderList.Items, userID, transaction.transactionID);
            enterAmount.Show();
            //need to pass through total label so user is aware of order total and can then check if correct amount is present
        }

        private void EFTbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transaction transaction = new Transaction();
            transaction.transactionID = 2;
            EFTpaymentWindow eFTpayment = new EFTpaymentWindow(RunningTotal, OrderList.Items, userID, transaction.transactionID);
            eFTpayment.Show();

            
        }

        private void FivePoundsbtn_Click(object sender, EventArgs e)
        {
            float calc;
            this.Hide();
            Transaction transaction = new Transaction();
            transaction.transactionID = 4;
            calc = RunningTotal;
            CalculatedChange = 5.00f - calc;
            PaymentSucessfulwindow paymentSucessfulwindow = new PaymentSucessfulwindow(transaction.transactionID, RunningTotal, CalculatedChange, OrderList.Items, userID);
            paymentSucessfulwindow.Show();
            
        }

        private void TenPoundsbtn_Click(object sender, EventArgs e)
        {
            float calc;
            this.Hide();
            Transaction transaction = new Transaction();
            transaction.transactionID = 4;
            calc = RunningTotal;
            CalculatedChange = 10.00f - calc;
            PaymentSucessfulwindow paymentSucessfulwindow = new PaymentSucessfulwindow(transaction.transactionID, RunningTotal, CalculatedChange, OrderList.Items, userID);
            paymentSucessfulwindow.Show();
          
        }

        private void TwentyPoundbtn_Click(object sender, EventArgs e)
        {
            float calc;
            this.Hide();
            Transaction transaction = new Transaction();
            transaction.transactionID = 4;
            calc = RunningTotal;
            CalculatedChange = 20.00f - calc;
            PaymentSucessfulwindow paymentSucessfulwindow = new PaymentSucessfulwindow(transaction.transactionID, RunningTotal, CalculatedChange, OrderList.Items,userID);
            paymentSucessfulwindow.Show();
            
        }

        private void LogOutbtn_Click(object sender, EventArgs e)
        {
            UserLogInWindow userLogIn = new UserLogInWindow();
            userLogIn.Show();
            this.Hide();
        }

        private void OpenDrawerBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cash Register Open");
        }
    }
}

