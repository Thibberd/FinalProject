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

        public EnterAmount(float runningTotal)
        {
            InitializeComponent();
            RunningTotal = runningTotal;
        }

        private void Enterbtn_Click(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction();
            if (transaction.transactionID == 2)
            {
                EFTpaymentWindow eFTpaymentWindow = new EFTpaymentWindow(RunningTotal);
                this.Hide();
                eFTpaymentWindow.Show();
            }
            else if (transaction.transactionID == 4)
            {
                CalculatedChange = (float.Parse(EnteredAmountlbl.Text) - RunningTotal);
                PaymentSucessfulwindow paymentSucessfulwindow = new PaymentSucessfulwindow(transaction.transactionID,RunningTotal, CalculatedChange);
                paymentSucessfulwindow.Show(); //show payment sucesful window
            }
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
    }
}
