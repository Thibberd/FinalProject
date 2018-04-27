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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

            //chart1.Series["User"].XValueMember = "User";
            //chart1.Series["User"].YValueMembers = "Total Sales";
            //chart1.DataSource = 

        }

        private void Bankingbtn_Click(object sender, EventArgs e)
        {
            BankingWindow bankingWindow = new BankingWindow();
            bankingWindow.Show();
            this.Hide();
        }

        private void Reportsbtn_Click(object sender, EventArgs e)
        {
            ReportsWindow reportsWindow = new ReportsWindow();
            reportsWindow.Show();
            this.Hide();
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

        private void LogOutbtn_Click(object sender, EventArgs e)
        {
            ManagementLogInWindow managementLogIn = new ManagementLogInWindow();
            managementLogIn.Show();
            this.Hide();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productsOverAveragePriceView.Products_Above_Average_Price' table. You can move, or remove it, as needed.
            this.products_Above_Average_PriceTableAdapter.Fill(this.productsOverAveragePriceView.Products_Above_Average_Price);
            // TODO: This line of code loads data into the 'userSalesbyWeek._userSalesbyWeek' table. You can move, or remove it, as needed.
            this.userSalesbyWeekTableAdapter.Fill(this.userSalesbyWeek._userSalesbyWeek);
            // TODO: This line of code loads data into the 'typeOfsalebyAmount.TypeOfSaleByAmount' table. You can move, or remove it, as needed.
            this.typeOfSaleByAmountTableAdapter.Fill(this.typeOfsalebyAmount.TypeOfSaleByAmount);

        }
    }
}
