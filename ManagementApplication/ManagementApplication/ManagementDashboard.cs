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
    }
}
