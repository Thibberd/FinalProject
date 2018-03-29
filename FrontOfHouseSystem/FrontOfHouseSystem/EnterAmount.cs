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

        private int CalculatedChange;

        public EnterAmount()
        {
            InitializeComponent();
        }

        private void Enterbtn_Click(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction();
            if (transaction.transactionID == 2)
            {
                EFTpaymentWindow eFTpaymentWindow = new EFTpaymentWindow();
                this.Hide();
                eFTpaymentWindow.Show();
            }
            else if (transaction.transactionID == 4)
            {
                PaymentSucessfulwindow paymentSucessfulwindow = new PaymentSucessfulwindow(transaction.transactionID,EnteredAmountlbl.Text, CalculatedChange);
                paymentSucessfulwindow.Show(); //show payment sucesful window
            }
        }
    }
}
