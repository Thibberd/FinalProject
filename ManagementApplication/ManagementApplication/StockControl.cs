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
    public partial class StockControl : Form
    {
        public StockControl()
        {
            InitializeComponent();
        }

        private void StockControl_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stockDataSet.Stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(this.stockDataSet.Stock);
            // TODO: This line of code loads data into the 'systembarDataSet1.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.systembarDataSet1.Product);
            // TODO: This line of code loads data into the 'systembarDataSet.StockControlView' table. You can move, or remove it, as needed.
            this.stockControlViewTableAdapter.Fill(this.systembarDataSet.StockControlView);

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.StockGridView.EndEdit();
                this.stockTableAdapter.Update(this.stockDataSet.Stock);
                

                MessageBox.Show("Update successful");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }

            // Pull data from datasetgrid view and update to table from view
        }

        private void UserAdminbtn_Click(object sender, EventArgs e)
        {
            UserAdmin userAdmin = new UserAdmin();
            userAdmin.Show();
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

