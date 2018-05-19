using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementApplication
{
    public partial class ProductsAboveAveragePrice : Form
    {
        public ProductsAboveAveragePrice()
        {
            InitializeComponent();
        }

        private void ProductsAboveAveragePrice_Load(object sender, EventArgs e)
        {
            // loads data into the products above average price data grid view
            this.products_Above_Average_PriceTableAdapter.Fill(this.productsOverAveragePriceView.Products_Above_Average_Price);

        }

        private void UserAdminbtn_Click(object sender, EventArgs e)
        {
            UserAdmin userAdmin = new UserAdmin();
            userAdmin.Show();
            this.Hide();
        }

        private void StockBtn_Click(object sender, EventArgs e)
        {
            StockControl stockControl = new StockControl();
            stockControl.Show();
            this.Hide();
        }


        private void Bankingbtn_Click(object sender, EventArgs e)
        {
            BankingWindow bankingWindow = new BankingWindow();
            bankingWindow.Show();
            this.Close();
        }

        private void Reportsbtn_Click(object sender, EventArgs e)
        {
            ReportsWindow reportsWindow = new ReportsWindow();
            reportsWindow.Show();
            this.Hide();

        }

        private void LogOutbtn_Click(object sender, EventArgs e)
        {
            ManagementLogInWindow managementLogIn = new ManagementLogInWindow();
            managementLogIn.Show();
            this.Hide();
        }

        private void UserAdminbtn_Click_1(object sender, EventArgs e)
        {
            UserAdmin userAdmin = new UserAdmin();
            userAdmin.Show();
            this.Hide();
        }

        private void StockBtn_Click_1(object sender, EventArgs e)
        {
            StockControl stockControl = new StockControl();
            stockControl.Show();
            this.Hide();
        }

        private void Bankingbtn_Click_1(object sender, EventArgs e)
        {
            BankingWindow bankingWindow = new BankingWindow();
            bankingWindow.Show();
            this.Close();
        }

        private void Reportsbtn_Click_1(object sender, EventArgs e)
        {
            ReportsWindow reportsWindow = new ReportsWindow();
            reportsWindow.Show();
            this.Hide();
        }

        private void LogOutbtn_Click_1(object sender, EventArgs e)
        {
            ManagementLogInWindow managementLogIn = new ManagementLogInWindow();
            managementLogIn.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }
    }
}
