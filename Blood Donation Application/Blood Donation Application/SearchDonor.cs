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
    
    public partial class SearchDonor : Form
    {
        function fn = new function();
        public SearchDonor()
        {
            InitializeComponent();
        }

        private void SearchDonor_Load(object sender, EventArgs e)
        {


            string query = "select * from newDonor ";

            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string query = "select * from newDonor where bloodGroup  Like'"+textBox1.Text+"%'";
              
                DataSet ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];

            }

        }
    }
}
