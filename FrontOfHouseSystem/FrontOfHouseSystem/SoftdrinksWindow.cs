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
    public partial class SoftdrinksWindow : Form
    {
        int userID;
        string firstName;
        string lastName;
        public float NewTotal;
        public float OriginalTotal;
        public float ItemPrice;

        public SoftdrinksWindow(int UserID, string FirstName, string LastName, ListBox.ObjectCollection orderItems, string userName)
        {
            InitializeComponent();

            OrderList.Items.AddRange(orderItems);
            Usernamelbl.Text = userName;

            userID = UserID;
            firstName = FirstName;
            lastName = LastName;
        }

        private void Homebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FOHDashboard mainMenu = new FOHDashboard(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text);
            mainMenu.Show();
        }

        private void Draughtbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DraughtWindow draughtWindow = new DraughtWindow(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text);
            draughtWindow.Show();
        }

        private void Bottlesbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            BottlesWindow bottlesWindow = new BottlesWindow(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text);
            bottlesWindow.Show();
        }



        private void Spiritsbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SpiritsWindow spiritsWindow = new SpiritsWindow(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text);
            spiritsWindow.Show();
        }

        private void Winebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            WineWindow wineWindow = new WineWindow(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text);
            wineWindow.Show();
        }

        private void Liquersbtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LiquersWindow liquersWindow = new LiquersWindow(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text);
            liquersWindow.Show();
        }

        private void Cocktailsbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CocktailsWindow cocktailsWindow = new CocktailsWindow(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text);
            cocktailsWindow.Show();
        }

        private void Sparklingbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SparklingWindow sparklingWindow = new SparklingWindow(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text);
            sparklingWindow.Show();
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

                    NewTotal = NewTotal + product.unitPrice;


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

        private void Dietcokebtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();

            connection.ConnectionString = "Server =.; Database = systembar; Trusted_Connection = True;";

            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandText = "SELECT [ProductName],[UnitPrice] FROM systembar.dbo.Product WHERE [ProductName] = 'Diet Coca - Cola'";
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

                    NewTotal = NewTotal + product.unitPrice;


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

        private void Zerocokebtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();

            connection.ConnectionString = "Server =.; Database = systembar; Trusted_Connection = True;";

            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandText = "SELECT [ProductName],[UnitPrice] FROM systembar.dbo.Product WHERE [ProductName] = 'Coca - Cola Zero'";
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

                    NewTotal = NewTotal + product.unitPrice;


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

        private void Orangejbtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();

            connection.ConnectionString = "Server =.; Database = systembar; Trusted_Connection = True;";

            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandText = "SELECT [ProductName],[UnitPrice] FROM systembar.dbo.Product WHERE [ProductName] = 'Orange Juice'";
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

                    NewTotal = NewTotal + product.unitPrice;


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

        private void Applejbtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();

            connection.ConnectionString = "Server =.; Database = systembar; Trusted_Connection = True;";

            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandText = "SELECT [ProductName],[UnitPrice] FROM systembar.dbo.Product WHERE [ProductName] = 'Apple Juice'";
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

                    NewTotal = NewTotal + product.unitPrice;


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

        private void Cranberryjbtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();

            connection.ConnectionString = "Server =.; Database = systembar; Trusted_Connection = True;";

            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandText = "SELECT [ProductName],[UnitPrice] FROM systembar.dbo.Product WHERE [ProductName] = 'Cranberry Juice'";
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

                    NewTotal = NewTotal + product.unitPrice;


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

        private void Fevertreebtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();

            connection.ConnectionString = "Server =.; Database = systembar; Trusted_Connection = True;";

            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandText = "SELECT [ProductName],[UnitPrice] FROM systembar.dbo.Product WHERE [ProductName] = 'Fever Tree Tonic'";
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

                    NewTotal = NewTotal + product.unitPrice;


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

        private void Lowcaltonicbtn_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection();

            connection.ConnectionString = "Server =.; Database = systembar; Trusted_Connection = True;";

            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandText = "SELECT [ProductName],[UnitPrice] FROM systembar.dbo.Product WHERE [ProductName] = 'Fever Tree Low Cal'";
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

                    NewTotal = NewTotal + product.unitPrice;


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

        private void Elderflowerbtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();

            connection.ConnectionString = "Server =.; Database = systembar; Trusted_Connection = True;";

            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandText = "SELECT [ProductName],[UnitPrice] FROM systembar.dbo.Product WHERE [ProductName] = 'Fever Tree Elderflower'";
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

                    NewTotal = NewTotal + product.unitPrice;


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

                    OrderList.Items.Add(product.productName + "       " + product.unitPrice.ToString("£#0.00"));

                    NewTotal = NewTotal + product.unitPrice;


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

        private void Redbullbtn_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection();

            connection.ConnectionString = "Server =.; Database = systembar; Trusted_Connection = True;";

            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandText = "SELECT [ProductName],[UnitPrice] FROM systembar.dbo.Product WHERE [ProductName] = 'Red Bull'";
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

                    NewTotal = NewTotal + product.unitPrice;


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
    }
}
