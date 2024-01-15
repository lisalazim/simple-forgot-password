using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simple__forgot_password
{
    public partial class Form3 : Form
    {
        public string NewPassword { get; private set; }
        public Form3()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string newPassword = txtNewpassword.Text;
            string confirm = txtConfimpassword.Text;

            if (newPassword.Equals(confirm)) 
            {
                NewPassword = newPassword;

                MessageBox.Show("Password has been changed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("New password and confirm password do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
