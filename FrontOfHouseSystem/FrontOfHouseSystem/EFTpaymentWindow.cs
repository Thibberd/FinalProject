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

        //System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public float RunningTotal;
        public int userID;
        public int transID;

        public EFTpaymentWindow(float runningTotal, ListBox.ObjectCollection orderItems, int UserID, int TransID)
        {
            InitializeComponent();
            //timer.Interval = 10000;
            //timer.Tick += new EventHandler(timer_Tick);
           // timer.Start();
            RunningTotal = runningTotal;
            OrderList.Items.AddRange(orderItems);
            userID = UserID;
            transID = TransID;
            
        }

        //void timer_Tick(object sender, EventArgs e)
        //{
           // this.Close();
            

        private void button1_Click(object sender, EventArgs e)
        {
            PaymentSucessfulwindow paymentSucessfulwindow = new PaymentSucessfulwindow(transID, RunningTotal, 00.00f, OrderList.Items, userID);
            paymentSucessfulwindow.Show();
            this.Hide();
        }

        //paymentSucessfulwindow.Show();
        //}
    }
}
