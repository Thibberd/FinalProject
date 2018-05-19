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
    public partial class ReportsWindow : Form
    {
        public ReportsWindow()
        {
            InitializeComponent();
        }

        private void UserAdminbtn_Click(object sender, EventArgs e)
        {
            UserAdmin userAdmin = new UserAdmin();
            userAdmin.Show();
            this.Hide();
        }

        private void Stockbtn_Click(object sender, EventArgs e)
        {
            StockControl stockControl = new StockControl();
            stockControl.Show();
            this.Hide();
        }

        private void Bankingbtn_Click(object sender, EventArgs e)
        {
            BankingWindow bankingWindow = new BankingWindow();
            bankingWindow.Show();
            this.Hide();
        }

        
       

       

        private void userSalesViewbtn_Click_1(object sender, EventArgs e)
        {
            UserSalesReportWindow userSalesReportWindow = new UserSalesReportWindow();
            userSalesReportWindow.Show();
            this.Hide();
        }

        private void WeeklySalesbtn_Click_1(object sender, EventArgs e)
        {
            WeeklySalesReportWindow weeklySalesReportWindow = new WeeklySalesReportWindow();
            weeklySalesReportWindow.Show();
            this.Hide();
        }

        private void MonthlySalesbtn_Click_1(object sender, EventArgs e)
        {
            MonthlySalesReportWindow monthlySalesReportWindow = new MonthlySalesReportWindow();
            monthlySalesReportWindow.Show();
            this.Hide();
        }

        private void ProductsaboveAveragebtn_Click(object sender, EventArgs e)
        {
            ProductsAboveAveragePrice productsAboveAverage = new ProductsAboveAveragePrice();
            productsAboveAverage.Show();
            this.Hide();
        }

        private void ProductListbtn_Click(object sender, EventArgs e)
        {
            ProductListView productListView = new ProductListView();
            productListView.Show();
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
            this.Hide();
        }

        private void LogOutbtn_Click(object sender, EventArgs e)
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
