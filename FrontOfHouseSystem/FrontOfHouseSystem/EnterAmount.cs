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
    public partial class EnterAmount : Form
    {

        public float CalculatedChange ;
        public float RunningTotal;
        public int userID;
        public int transID;

        public EnterAmount(float runningTotal, ListBox.ObjectCollection orderItems, int UserID, int TransID)

            
        {
            InitializeComponent();
            RunningTotal = runningTotal;
            OrderList.Items.AddRange(orderItems);
            userID = UserID;
            transID = TransID;
            
        }

        private void Enterbtn_Click(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction();
            
            transaction.transactionID = 4;
            
                CalculatedChange = (float.Parse(EnteredAmountlbl.Text) - RunningTotal);
                PaymentSucessfulwindow paymentSucessfulwindow = new PaymentSucessfulwindow(transaction.transactionID,RunningTotal, CalculatedChange, OrderList.Items, userID);
                paymentSucessfulwindow.Show(); //show payment sucesful window
                this.Close();

        }

        private void Number1btn_Click(object sender, EventArgs e)
        {
            EnteredAmountlbl.Text = EnteredAmountlbl.Text + "1";
        }

        private void Number2btn_Click(object sender, EventArgs e)
        {
            EnteredAmountlbl.Text = EnteredAmountlbl.Text + "2";
        }

        private void Number3btn_Click(object sender, EventArgs e)
        {
            EnteredAmountlbl.Text = EnteredAmountlbl.Text + "3";
        }

        private void Number4btn_Click(object sender, EventArgs e)
        {
            EnteredAmountlbl.Text = EnteredAmountlbl.Text + "4";
        }

        private void Number5btn_Click(object sender, EventArgs e)
        {
            EnteredAmountlbl.Text = EnteredAmountlbl.Text + "5";
        }

        private void Number6btn_Click(object sender, EventArgs e)
        {
            EnteredAmountlbl.Text = EnteredAmountlbl.Text + "6";
        }

        private void Number7btn_Click(object sender, EventArgs e)
        {
            EnteredAmountlbl.Text = EnteredAmountlbl.Text + "7";
        }

        private void Number8btn_Click(object sender, EventArgs e)
        {
            EnteredAmountlbl.Text = EnteredAmountlbl.Text + "8";
        }

        private void Number9btn_Click(object sender, EventArgs e)
        {
            EnteredAmountlbl.Text = EnteredAmountlbl.Text + "9";
        }

        private void Pointbtn_Click(object sender, EventArgs e)
        {
            EnteredAmountlbl.Text = EnteredAmountlbl.Text + ".";
        }

        private void Number0btn_Click(object sender, EventArgs e)
        {
            EnteredAmountlbl.Text = EnteredAmountlbl.Text + "0";
        }

        private void Doulbe0btn_Click(object sender, EventArgs e)
        {
            EnteredAmountlbl.Text = EnteredAmountlbl.Text + "00";
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            EnteredAmountlbl.Text = "";
        }
    }
}
