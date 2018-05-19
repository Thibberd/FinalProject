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
    public partial class SpiritsWindow : Form
    {
        int userID;
        string firstName;
        string lastName;
        public float NewTotal;
        public float OriginalTotal;
        public float ItemPrice;
        public float RunningTotal;
        public float CalculatedChange;

        public SpiritsWindow(int UserID, string FirstName, string LastName, ListBox.ObjectCollection orderItems, string userName, string amount, float runningTotal)
        {
            InitializeComponent();

            OrderList.Items.AddRange(orderItems);
            Usernamelbl.Text = userName;
            AmountLabel.Text = amount;
            RunningTotal = runningTotal;

            userID = UserID;
            firstName = FirstName;
            lastName = LastName;
        }

        

       

        private void Bellsbtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();

            connection.ConnectionString = "Server =.; Database = systembar; Trusted_Connection = True;";

            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandText = "SELECT [ProductName],[UnitPrice] FROM systembar.dbo.Product WHERE [ProductName] = 'Bells Whiskey'";
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

                    OrderList.Items.Add(product.productName + "       " + product.unitPrice.ToString("£#0.00"));



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
            this.Hide();


        }

        private void Bombaybtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();

            connection.ConnectionString = "Server =.; Database = systembar; Trusted_Connection = True;";

            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandText = "SELECT [ProductName],[UnitPrice] FROM systembar.dbo.Product WHERE [ProductName] = 'Bombay Sapphire'";
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

                    OrderList.Items.Add(product.productName + "       " + product.unitPrice.ToString("£#0.00"));

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
            this.Hide();
        }

        private void Gordansbtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();

            connection.ConnectionString = "Server =.; Database = systembar; Trusted_Connection = True;";

            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandText = "SELECT [ProductName],[UnitPrice] FROM systembar.dbo.Product WHERE [ProductName] = 'Gordons'";
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

                    OrderList.Items.Add(product.productName + "       " + product.unitPrice.ToString("£#0.00"));

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
            this.Hide();
        }

        private void Greygoosebtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();

            connection.ConnectionString = "Server =.; Database = systembar; Trusted_Connection = True;";

            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandText = "SELECT [ProductName],[UnitPrice] FROM systembar.dbo.Product WHERE [ProductName] = 'Grey Goose'";
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

                    OrderList.Items.Add(product.productName + "       " + product.unitPrice.ToString("£#0.00"));

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
            this.Hide();
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

                    OrderList.Items.Add(product.productName + "       " + product.unitPrice.ToString("£#0.00"));

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
            this.Hide();
        }

        private void Krakenbtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();

            connection.ConnectionString = "Server =.; Database = systembar; Trusted_Connection = True;";

            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandText = "SELECT [ProductName],[UnitPrice] FROM systembar.dbo.Product WHERE [ProductName] = 'Kraken Black Spiced'";
            command.CommandType = CommandType.Text;

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Product product = new Product();
                    product.productName = "Kraken";
                    product.unitPrice = float.Parse((string)reader["UnitPrice"].ToString());
                    ItemPrice = product.unitPrice;

                    OrderList.Items.Add(product.productName + "       " + product.unitPrice.ToString("£#0.00"));

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
            this.Hide();
        }

        private void Morgansbtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();

            connection.ConnectionString = "Server =.; Database = systembar; Trusted_Connection = True;";

            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandText = "SELECT [ProductName],[UnitPrice] FROM systembar.dbo.Product WHERE [ProductName] = 'Captain Morgans Spiced'";
            command.CommandType = CommandType.Text;

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Product product = new Product();
                    product.productName = "Kraken";
                    product.unitPrice = float.Parse((string)reader["UnitPrice"].ToString());
                    ItemPrice = product.unitPrice;

                    OrderList.Items.Add(product.productName + "       " + product.unitPrice.ToString("£#0.00"));

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
            this.Hide();
        }

        private void Smirnoffbtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();

            connection.ConnectionString = "Server =.; Database = systembar; Trusted_Connection = True;";

            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandText = "SELECT [ProductName],[UnitPrice] FROM systembar.dbo.Product WHERE [ProductName] = 'Captain Morgans Spiced'";
            command.CommandType = CommandType.Text;

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Product product = new Product();
                    product.productName = "Kraken";
                    product.unitPrice = float.Parse((string)reader["UnitPrice"].ToString());
                    ItemPrice = product.unitPrice;

                    OrderList.Items.Add(product.productName + "       " + product.unitPrice.ToString("£#0.00"));

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
            this.Hide();
        }

        private void Cashbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnterAmount enterAmount = new EnterAmount(RunningTotal, OrderList.Items, userID, 4);
            enterAmount.Show();
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

        private void TwentyPoundsbtn_Click(object sender, EventArgs e)
        {
            float calc;
            this.Hide();
            Transaction transaction = new Transaction();
            transaction.transactionID = 4;
            calc = RunningTotal;
            CalculatedChange = 20.00f - calc;
            PaymentSucessfulwindow paymentSucessfulwindow = new PaymentSucessfulwindow(transaction.transactionID, RunningTotal, CalculatedChange, OrderList.Items, userID);
            paymentSucessfulwindow.Show();
        }

        private void EFTbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transaction transaction = new Transaction();
            transaction.transactionID = 2;
            EFTpaymentWindow eFTpayment = new EFTpaymentWindow(RunningTotal, OrderList.Items, userID, transaction.transactionID);
            eFTpayment.Show();
        }

        private void Voidbtn_Click(object sender, EventArgs e)
        {
            int iLastInd = OrderList.Items.Count - 1;
            if (iLastInd >= 0)
            {
                OrderList.Items.RemoveAt(iLastInd);
                NewTotal = RunningTotal - ItemPrice;
                RunningTotal = NewTotal;
                AmountLabel.Text = NewTotal.ToString("#£0.00");
            }
        }

        private void Homebtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FOHDashboard mainMenu = new FOHDashboard(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text, AmountLabel.Text, RunningTotal);
            mainMenu.Show();
        }

        private void Draughtbtn_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            DraughtWindow draughtWindow = new DraughtWindow(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text, AmountLabel.Text, RunningTotal);
            draughtWindow.Show();
        }

        private void Bottlesbtn_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            BottlesWindow bottlesWindow = new BottlesWindow(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text, AmountLabel.Text, RunningTotal);
            bottlesWindow.Show();
        }

        private void Spiritsbtn_Click(object sender, EventArgs e)
        {

        }

        private void Winebtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            WineWindow wineWindow = new WineWindow(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text, AmountLabel.Text, RunningTotal);
            wineWindow.Show();
        }

        private void Liquersbtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LiquersWindow liquersWindow = new LiquersWindow(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text, AmountLabel.Text, RunningTotal);
            liquersWindow.Show();
        }

        private void Cocktailsbtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            CocktailsWindow cocktailsWindow = new CocktailsWindow(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text, AmountLabel.Text, RunningTotal);
            cocktailsWindow.Show();
        }

        private void Sparklingbtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            SparklingWindow sparklingWindow = new SparklingWindow(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text, AmountLabel.Text, RunningTotal);
            sparklingWindow.Show();
        }

        private void Softsbtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            SoftdrinksWindow softdrinksWindow = new SoftdrinksWindow(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text, AmountLabel.Text, RunningTotal);
            softdrinksWindow.Show();
        }
    }
}
