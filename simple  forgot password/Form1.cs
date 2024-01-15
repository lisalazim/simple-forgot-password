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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string storedPassword;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "lalisa" && txtPassword.Text == storedPassword)
            {
                new Form2().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Oops !, Your password is incorrect.", "incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.ResetText();
                txtPassword.ResetText();
                txtUsername.Focus();
            }

        }

        private void linkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
            storedPassword = form3.NewPassword;
        }
    }
}
