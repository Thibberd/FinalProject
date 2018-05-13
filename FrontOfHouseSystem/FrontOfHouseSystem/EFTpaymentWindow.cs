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
    public partial class EFTpaymentWindow : Form
    {

        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public float RunningTotal;

        public EFTpaymentWindow(float runningTotal)
        {
            InitializeComponent();
            timer.Interval = 10000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
            RunningTotal = runningTotal;
            
        }

        void timer_Tick(object sender, EventArgs e)
        {
            this.Close();
            PaymentSucessfulwindow paymentSucessfulwindow = new PaymentSucessfulwindow(2,RunningTotal,0);
            paymentSucessfulwindow.Show();
        }
    }
}
