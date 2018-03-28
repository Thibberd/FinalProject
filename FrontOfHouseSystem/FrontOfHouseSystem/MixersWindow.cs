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

   

    public partial class MixersWindow : Form
    {
        int userID;
        string firstName;
        string lastName;
        public float NewTotal;
        public float OriginalTotal;
        public float ItemPrice; 

        public MixersWindow(int UserID, string FirstName, string LastName, ListBox.ObjectCollection orderItems, string userName)
        {
            InitializeComponent();

            OrderList.Items.AddRange(orderItems);
            Usernamelbl.Text = userName;

            userID = UserID;
            firstName = FirstName;
            lastName = LastName;
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

            SpiritsWindow spiritsWindow = new SpiritsWindow(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text);

            spiritsWindow.Show();
            this.Close();

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

            SpiritsWindow spiritsWindow = new SpiritsWindow(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text);

            spiritsWindow.Show();
            this.Close();
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

            SpiritsWindow spiritsWindow = new SpiritsWindow(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text);

            spiritsWindow.Show();
            this.Close();
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

            SpiritsWindow spiritsWindow = new SpiritsWindow(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text);

            spiritsWindow.Show();
            this.Close();
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

            SpiritsWindow spiritsWindow = new SpiritsWindow(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text);

            spiritsWindow.Show();
            this.Close();
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

            SpiritsWindow spiritsWindow = new SpiritsWindow(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text);

            spiritsWindow.Show();
            this.Close();
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

            SpiritsWindow spiritsWindow = new SpiritsWindow(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text);

            spiritsWindow.Show();
            this.Close();
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

            SpiritsWindow spiritsWindow = new SpiritsWindow(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text);

            spiritsWindow.Show();
            this.Close();

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

            SpiritsWindow spiritsWindow = new SpiritsWindow(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text);

            spiritsWindow.Show();
            this.Close();
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

            SpiritsWindow spiritsWindow = new SpiritsWindow(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text);

            spiritsWindow.Show();
            this.Close();
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

            SpiritsWindow spiritsWindow = new SpiritsWindow(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text);

            spiritsWindow.Show();
            this.Close();

        }

        private void Backmixerbtn_Click(object sender, EventArgs e)
        {
            SpiritsWindow spiritsWindow = new SpiritsWindow(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text);

            spiritsWindow.Show();
            this.Close();
        }
    }
}
