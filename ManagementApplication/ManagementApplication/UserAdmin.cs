using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementApplication
{
    public partial class UserAdmin : Form
    {
        public UserAdmin()
        {
            InitializeComponent();
        }

        private void UserAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userData.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.userData.Users);
            

            
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.usersBindingSource.EndEdit();
                this.usersTableAdapter.Update(this.userData.Users);

                MessageBox.Show("Update successful");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }
        }
    }
}
