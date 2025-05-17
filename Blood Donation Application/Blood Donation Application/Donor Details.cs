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
    public partial class Donor_Details : Form
    {
        public Donor_Details()
        {
            InitializeComponent();
        }

        private void bloodDonationdbDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Donor_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bloodDonationdbDataSet.newDonor' table. You can move, or remove it, as needed.
            this.newDonorTableAdapter.Fill(this.bloodDonationdbDataSet.newDonor);

        }
    }
}
