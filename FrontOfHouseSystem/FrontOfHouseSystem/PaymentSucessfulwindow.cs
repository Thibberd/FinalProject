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
    public partial class PaymentSucessfulwindow : Form
    {
        

        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public PaymentSucessfulwindow(int TransID, string AmountTotal, float Change)
        {
            InitializeComponent();
            timer.Interval = 10000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();

            Transaction transaction = new Transaction();
            transaction.transactionID = TransID;
            TotalAmountLbl.Text = AmountTotal;
            ChangeAmountlbl.Text = Change.ToString("£#0.00");
        }

        void timer_Tick(object sender, EventArgs e)
        {
            this.Close();
            UserLogInWindow userLogInWindow = new UserLogInWindow();
            userLogInWindow.Show();
        }
    }
}
