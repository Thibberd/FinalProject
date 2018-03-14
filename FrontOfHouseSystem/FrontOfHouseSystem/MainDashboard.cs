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

        public float NewTotal = 0;
        public float OriginalTotal = 0;
        public float ItemPrice = 0;

        public FOHDashboard()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Sparklingbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SparklingWindow sparklingWindow = new SparklingWindow();
            sparklingWindow.Show();
        }

        private void Softbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SoftdrinksWindow softdrinksWindow = new SoftdrinksWindow();
            softdrinksWindow.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void Draught_Click(object sender, EventArgs e)
        {
            this.Hide();
            DraughtWindow draughtWindow = new DraughtWindow();
            draughtWindow.Show();
            
        }

        private void Bottlesbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            BottlesWindow bottlesWindow = new BottlesWindow();
            bottlesWindow.Show();
        }

        private void Spiritsbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SpiritsWindow spiritsWindow = new SpiritsWindow();
            spiritsWindow.Show();
        }

        private void Winebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            WineWindow wineWindow = new WineWindow();
            wineWindow.Show();
        }

        private void Liquersbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LiquersWindow liquersWindow  = new LiquersWindow();
            liquersWindow.Show();
        }

        private void Cocktailsbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CocktailsWindow cocktailsWindow = new CocktailsWindow();
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
                   
                    //string unitp = product.unitPrice.ToString();

                    //string item = string.Format(product.productName + "     " + "{00.00}", product.unitPrice);

                    this.OrderList.Items.Add(product.productName + "              " +  product.unitPrice.ToString("£#0.00"));

                    NewTotal = NewTotal + product.unitPrice;
                    
                    
                    this.AmountLabel.Text = NewTotal.ToString("£#0.00");
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
            if (this.OrderList.SelectedIndex >= 0) {
                this.OrderList.Items.RemoveAt(this.OrderList.SelectedIndex);
                NewTotal = NewTotal - ItemPrice;
                AmountLabel.Text = NewTotal.ToString("#£0.00");            }
        }
    }
}

