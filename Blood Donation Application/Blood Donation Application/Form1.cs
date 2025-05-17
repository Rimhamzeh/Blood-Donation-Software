using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Donation_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnshow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (btnshow.Text == "Show")
            {
                btnshow.Text = "Hide";
                txtPassword.PasswordChar = '\0';

            }
            else
            {
                btnshow.Text = "Show";
                txtPassword.PasswordChar = '*';

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnLogin.Enabled = true;
        }

        private void X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //be generous
            if (txtUserName.Text == "hi" && txtPassword.Text == "pass")
            {
                Dashboard db = new Dashboard();
                db.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Enter valid Username Or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
