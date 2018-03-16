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
    public partial class SpiritsWindow : Form
    {
        public SpiritsWindow(ListBox.ObjectCollection orderItems)
        {
            InitializeComponent();

            OrderList.Items.AddRange(orderItems);
        }

        private void Homebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FOHDashboard mainMenu = new FOHDashboard();
            mainMenu.Show();
        }

        private void Draughtbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DraughtWindow draughtWindow = new DraughtWindow(OrderList.Items);
            draughtWindow.Show();
        }

        private void Bottlesbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            BottlesWindow bottlesWindow = new BottlesWindow(OrderList.Items);
            bottlesWindow.Show();
        }

        private void Sparklingbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SparklingWindow sparklingWindow = new SparklingWindow(OrderList.Items);
            sparklingWindow.Show();
        }

        private void Winebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            WineWindow wineWindow = new WineWindow(OrderList.Items);
            wineWindow.Show();

        }

        private void Liquersbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LiquersWindow liquersWindow = new LiquersWindow(OrderList.Items);
            liquersWindow.Show();
        }

        private void Cocktailsbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CocktailsWindow cocktailsWindow = new CocktailsWindow(OrderList.Items);
            cocktailsWindow.Show();
        }

        private void Softsbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SoftdrinksWindow softdrinksWindow = new SoftdrinksWindow(OrderList.Items);
            softdrinksWindow.Show();
        }
    }
}
