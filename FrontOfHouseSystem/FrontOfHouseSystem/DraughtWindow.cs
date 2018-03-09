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
    public partial class DraughtWindow : Form
    {
        public DraughtWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Homebtn_Click(object sender, EventArgs e)
        {
            this.Close();
            FOHDashboard mainMenu = new FOHDashboard();
            mainMenu.Show();
            
        }
    }
}
