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
    public partial class CocktailsWindow : Form
    {

        int userID ;
        string firstName ;
        string lastName;
        public float NewTotal = 0;
        public float OriginalTotal = 0;
        public float ItemPrice = 0;
        public float RunningTotal;
        public float CalculatedChange;

        public CocktailsWindow(int UserID, string FirstName, string LastName, ListBox.ObjectCollection orderItems, string userName, string amount, float runningTotal)
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

        private void CocktailsWindow_Load(object sender, EventArgs e)
        {

        }

        public void Homebtn_Click(object sender, EventArgs e)
        {

            
            this.Hide();
            FOHDashboard mainMenu = new FOHDashboard(userID, firstName,lastName, OrderList.Items, Usernamelbl.Text, AmountLabel.Text, RunningTotal);
            mainMenu.Show();
        }

        private void Draughtbtn_Click(object sender, EventArgs e)
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

        private void Sparklingbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SparklingWindow sparklingWindow = new SparklingWindow(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text, AmountLabel.Text, RunningTotal);
            sparklingWindow.Show();
        }

        
        private void Softsbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SoftdrinksWindow softdrinksWindow = new SoftdrinksWindow(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text, AmountLabel.Text, RunningTotal);
            softdrinksWindow.Show();
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
            LiquersWindow liquersWindow = new LiquersWindow(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text, AmountLabel.Text, RunningTotal);
            liquersWindow.Show();
        }

        private void Bluelagoonbtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();

            connection.ConnectionString = "Server =.; Database = systembar; Trusted_Connection = True;";

            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandText = "SELECT [ProductName],[UnitPrice] FROM systembar.dbo.Product WHERE [ProductName] = 'Blue Lagoon'";
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

                    //string unitp = product.unitPrice.ToString();

                    //string item = string.Format(product.productName + "     " + "{00.00}", product.unitPrice);

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

        private void Godfatherbtn_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection();

            connection.ConnectionString = "Server =.; Database = systembar; Trusted_Connection = True;";

            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandText = "SELECT [ProductName],[UnitPrice] FROM systembar.dbo.Product WHERE [ProductName] = 'The Godfather'";
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

                    //string unitp = product.unitPrice.ToString();

                    //string item = string.Format(product.productName + "     " + "{00.00}", product.unitPrice);

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

        private void LIITbtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();

            connection.ConnectionString = "Server =.; Database = systembar; Trusted_Connection = True;";

            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandText = "SELECT [ProductName],[UnitPrice] FROM systembar.dbo.Product WHERE [ProductName] = 'Long Island Ice Tea'";
            command.CommandType = CommandType.Text;

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Product product = new Product();
                    product.productName = "LIIT";
                    product.unitPrice = float.Parse((string)reader["UnitPrice"].ToString());
                    ItemPrice = product.unitPrice;

                    //string unitp = product.unitPrice.ToString();

                    //string item = string.Format(product.productName + "     " + "{00.00}", product.unitPrice);

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

        private void Mojitobtn_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection();

            connection.ConnectionString = "Server =.; Database = systembar; Trusted_Connection = True;";

            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandText = "SELECT [ProductName],[UnitPrice] FROM systembar.dbo.Product WHERE [ProductName] = 'Mojito '";
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

                    //string unitp = product.unitPrice.ToString();

                    //string item = string.Format(product.productName + "     " + "{00.00}", product.unitPrice);

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

        private void Pawnstarbtn_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection();

            connection.ConnectionString = "Server =.; Database = systembar; Trusted_Connection = True;";

            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandText = "SELECT [ProductName],[UnitPrice] FROM systembar.dbo.Product WHERE [ProductName] = 'Porn Star Martini'";
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

                    //string unitp = product.unitPrice.ToString();

                    //string item = string.Format(product.productName + "     " + "{00.00}", product.unitPrice);

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

        private void Purplerainbtn_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection();

            connection.ConnectionString = "Server =.; Database = systembar; Trusted_Connection = True;";

            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandText = "SELECT [ProductName],[UnitPrice] FROM systembar.dbo.Product WHERE [ProductName] = 'Purple Rain'";
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

                    //string unitp = product.unitPrice.ToString();

                    //string item = string.Format(product.productName + "     " + "{00.00}", product.unitPrice);

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

        private void Sotbbtn_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection();

            connection.ConnectionString = "Server =.; Database = systembar; Trusted_Connection = True;";

            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandText = "SELECT [ProductName],[UnitPrice] FROM systembar.dbo.Product WHERE [ProductName] = 'Sex On The Beach'";
            command.CommandType = CommandType.Text;

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Product product = new Product();
                    product.productName = "SOTB";
                    product.unitPrice = float.Parse((string)reader["UnitPrice"].ToString());
                    ItemPrice = product.unitPrice;

                    //string unitp = product.unitPrice.ToString();

                    //string item = string.Format(product.productName + "     " + "{00.00}", product.unitPrice);

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
            EnterAmount enterAmount = new EnterAmount(RunningTotal);
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
            PaymentSucessfulwindow paymentSucessfulwindow = new PaymentSucessfulwindow(transaction.transactionID, RunningTotal, CalculatedChange);
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
            PaymentSucessfulwindow paymentSucessfulwindow = new PaymentSucessfulwindow(transaction.transactionID, RunningTotal, CalculatedChange);
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
            PaymentSucessfulwindow paymentSucessfulwindow = new PaymentSucessfulwindow(transaction.transactionID, RunningTotal, CalculatedChange);
            paymentSucessfulwindow.Show();
        }

        private void EFTbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transaction transaction = new Transaction();
            transaction.transactionID = 2;
            EFTpaymentWindow eFTpayment = new EFTpaymentWindow(RunningTotal);
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
}
