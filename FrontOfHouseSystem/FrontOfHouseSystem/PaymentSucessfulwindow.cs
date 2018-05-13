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
        

        
        public float RunningTotal;
        public float userID;
        public float transID;


        public PaymentSucessfulwindow(int TransID, float runningTotal, float Change, ListBox.ObjectCollection orderItems, int UserID)
        {
            InitializeComponent();
            

            Transaction transaction = new Transaction();
            transaction.transactionID = TransID;

            OrderList.Items.AddRange(orderItems);
            userID = UserID;
            transID = TransID;

            RunningTotal = runningTotal;
            TotalAmountLbl.Text = RunningTotal.ToString("£#0.00");
            ChangeAmountlbl.Text = Change.ToString("£#0.00");
        }

        
            
private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            UserLogInWindow userLogInWindow = new UserLogInWindow();
            userLogInWindow.Show();
        }
        
    }
}
