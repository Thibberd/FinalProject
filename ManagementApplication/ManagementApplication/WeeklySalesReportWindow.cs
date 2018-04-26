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
    public partial class WeeklySalesReportWindow : Form
    {
        public WeeklySalesReportWindow()
        {
            InitializeComponent();
        }

        private void WeeklySalesReportWindow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'weeklySalesView.TypeOfSaleByAmountLastWeek' table. You can move, or remove it, as needed.
            this.typeOfSaleByAmountLastWeekTableAdapter.Fill(this.weeklySalesView.TypeOfSaleByAmountLastWeek);

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
    }
}
