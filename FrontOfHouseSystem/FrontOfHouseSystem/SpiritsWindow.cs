﻿using System;
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

        public SpiritsWindow(int UserID, string FirstName, string LastName, ListBox.ObjectCollection orderItems, string userName)
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

        private void Sparklingbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SparklingWindow sparklingWindow = new SparklingWindow(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text);
            sparklingWindow.Show();
        }

        private void Winebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            WineWindow wineWindow = new WineWindow(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text);
            wineWindow.Show();

        }

        private void Liquersbtn_Click(object sender, EventArgs e)
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

        private void Softsbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SoftdrinksWindow softdrinksWindow = new SoftdrinksWindow(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text);
            softdrinksWindow.Show();
        }

        private void Draughtbtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            DraughtWindow draughtWindow = new DraughtWindow(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text);
            draughtWindow.Show();
        }

        private void Bottlesbtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            BottlesWindow bottlesWindow = new BottlesWindow(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text);
            bottlesWindow.Show();

        }

        private void Bellsbtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();

            connection.ConnectionString = "Server =.; Database = systembar; Trusted_Connection = True;";

            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandText = "SELECT [ProductName],[UnitPrice] FROM systembar.dbo.Product WHERE [ProductName] = 'Bell's Whiskey'";
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

            MixersWindow mixersWindow = new MixersWindow(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text);
            mixersWindow.Show();
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

            MixersWindow mixersWindow = new MixersWindow(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text);
            mixersWindow.Show();
        }

        private void Gordansbtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();

            connection.ConnectionString = "Server =.; Database = systembar; Trusted_Connection = True;";

            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandText = "SELECT [ProductName],[UnitPrice] FROM systembar.dbo.Product WHERE [ProductName] = 'Gordon's'";
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

            MixersWindow mixersWindow = new MixersWindow(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text);
            mixersWindow.Show();
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

            MixersWindow mixersWindow = new MixersWindow(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text);
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

            MixersWindow mixersWindow = new MixersWindow(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text);
            mixersWindow.Show();
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

            MixersWindow mixersWindow = new MixersWindow(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text);
            mixersWindow.Show();
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

            MixersWindow mixersWindow = new MixersWindow(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text);
            mixersWindow.Show();
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

            MixersWindow mixersWindow = new MixersWindow(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text);
            mixersWindow.Show();
        }
    }
}
