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
    public partial class ProductListView : Form
    {
        public ProductListView()
        {
            InitializeComponent();
        }

        private void ProductListView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productListViewData.ProductList_View' table. You can move, or remove it, as needed.
            this.productList_ViewTableAdapter.Fill(this.productListViewData.ProductList_View);

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
    }
}
