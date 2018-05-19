using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

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
            
            this.stockTableAdapter.Fill(this.datSourceStock.Stock);
            

            //  This line of code loads data into the 'systembarDataSet1.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.systembarDataSet1.Product);
            //This line of code loads data into the 'systembarDataSet.StockControlView' table. You can move, or remove it, as needed.
            //this.stockControlViewTableAdapter.Fill(this.systembarDataSet.StockControlView);

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Updates Stock table from creating, reading and deleting

                this.Validate();
                this.stockBindingSource3.EndEdit();
                this.stockTableAdapter.Update(this.datSourceStock.Stock);
                



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

        private void LogOutbtn_Click(object sender, EventArgs e)
        {
            ManagementLogInWindow managementLogIn = new ManagementLogInWindow();
            managementLogIn.Show();
            this.Hide();
        }

        private void ScreenShotbtn_Click(object sender, EventArgs e)
        {
            PrintScreen();
        }

        private static void PrintScreen()
        {
            SaveFileDialog sfg = new SaveFileDialog();
            sfg.Filter = "(*.jpeg)|*.jpeg";
            if (sfg.ShowDialog() == DialogResult.OK)
            {
                Bitmap scr = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                Graphics grp = Graphics.FromImage(scr as Image);
                grp.CopyFromScreen(0, 0, 0, 0, scr.Size);
                scr.Save(sfg.FileName, ImageFormat.Jpeg);
            }
        }

        private void UserAdminbtn_Click_1(object sender, EventArgs e)
        {
            UserAdmin userAdmin = new UserAdmin();
            userAdmin.Show();
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

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }
    }
}