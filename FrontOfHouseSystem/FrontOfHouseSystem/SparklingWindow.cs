using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontOfHouseSystem
{
    public partial class SparklingWindow : Form

    {
        int userID;
        string firstName;
        string lastName;


        public SparklingWindow(int UserID, string FirstName, string LastName, ListBox.ObjectCollection orderItems, string userName)
        {
            InitializeComponent();

            OrderList.Items.AddRange(orderItems);

            Usernamelbl.Text = userName;

            userID = UserID;
            firstName = FirstName;
            lastName = LastName;
        }

        private void Liquersbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void Homebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FOHDashboard mainMenu = new FOHDashboard(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text);
            mainMenu.Show();
        }

        private void Draughtbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DraughtWindow draughtWindow = new DraughtWindow(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text);
            draughtWindow.Show();
        }

        private void Bottlesbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            BottlesWindow bottlesWindow = new BottlesWindow(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text);
            bottlesWindow.Show();
        }



        private void Softsbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SoftdrinksWindow softdrinksWindow = new SoftdrinksWindow(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text);
            softdrinksWindow.Show();
        }

        private void Spiritsbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SpiritsWindow spiritsWindow = new SpiritsWindow(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text);
            spiritsWindow.Show();
        }

        private void Winebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            WineWindow wineWindow = new WineWindow(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text);
            wineWindow.Show();
        }

        private void Liquersbtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LiquersWindow liquersWindow = new LiquersWindow(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text);
            liquersWindow.Show();
        }

        private void Cocktailsbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CocktailsWindow cocktailsWindow = new CocktailsWindow(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text);
            cocktailsWindow.Show();
        }

        private void Draughtbtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            DraughtWindow draughtWindow = new DraughtWindow(userID, firstName, lastName, OrderList.Items, Usernamelbl.Text);
            draughtWindow.Show();
        }
    }
}
