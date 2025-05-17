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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteDonor de = new DeleteDonor();
            de.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewDonor add = new AddNewDonor();
            add.Show();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDonor update = new UpdateDonor();
            update.Show();
        }

        private void allDonorDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Donor_Details don = new Donor_Details();
            don.Show();
        }

        private void locationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bloodGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchDonor ser=new SearchDonor();
            ser.Show();
        }

        private void doToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchName se = new SearchName();
            se.Show();
        }

        private void increaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
