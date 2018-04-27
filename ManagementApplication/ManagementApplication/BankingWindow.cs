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
    public partial class BankingWindow : Form
    {
        public BankingWindow()
        {
            InitializeComponent();
        }

        private void BankingWindow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'systembarDataSet2.Bank' table. You can move, or remove it, as needed.
            this.bankTableAdapter.Fill(this.systembarDataSet2.Bank);

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                
                this.BankingView.EndEdit();
                this.bankTableAdapter.Update(this.systembarDataSet2.Bank);
                


                MessageBox.Show("Update successful");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }
        }

        private void UserAdminbtn_Click(object sender, EventArgs e)
        {
            UserAdmin userAdmin = new UserAdmin();
            userAdmin.Show();
            this.Hide();
        }

        private void StockControlbtn_Click(object sender, EventArgs e)
        {
            StockControl stockControl = new StockControl();
            stockControl.Show();
            this.Hide();
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
    }
}
