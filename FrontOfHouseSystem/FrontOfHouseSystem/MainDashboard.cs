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
    public partial class FOHDashboard : Form
    {
        public FOHDashboard()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Sparklingbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SparklingWindow sparklingWindow = new SparklingWindow();
            sparklingWindow.Show();
        }

        private void Softbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SoftdrinksWindow softdrinksWindow = new SoftdrinksWindow();
            softdrinksWindow.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void Draught_Click(object sender, EventArgs e)
        {
            this.Hide();
            DraughtWindow draughtWindow = new DraughtWindow();
            draughtWindow.Show();
            
        }

        private void Bottlesbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            BottlesWindow bottlesWindow = new BottlesWindow();
            bottlesWindow.Show();
        }

        private void Spiritsbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SpiritsWindow spiritsWindow = new SpiritsWindow();
            spiritsWindow.Show();
        }

        private void Winebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            WineWindow wineWindow = new WineWindow();
            wineWindow.Show();
        }

        private void Liquersbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LiquersWindow liquersWindow  = new LiquersWindow();
            liquersWindow.Show();
        }

        private void Cocktailsbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CocktailsWindow cocktailsWindow = new CocktailsWindow();
            cocktailsWindow.Show();
        }
    }
}
