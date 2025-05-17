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
    public partial class DeleteDonor : Form
    {
        function fn = new function();
        public DeleteDonor()
        {
            InitializeComponent();
        }

        private void DeleteDonor_Load(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtFatherName.Clear();
            txtMotherName.Clear();
            textBox2.Clear();
            txtMobileNum.Clear();
            txtGender.Clear();
            txtRh.Clear();
            txtBloodGroup.Clear();
            txtCity.Clear();
            txtAdress.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string query = "select * from newDonor where donorId=" + textBox1.Text + "";
                DataSet ds = fn.getData(query);



                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtName.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtFatherName.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtMotherName.Text = ds.Tables[0].Rows[0][3].ToString();
                    textBox2.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtMobileNum.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtGender.Text = ds.Tables[0].Rows[0][6].ToString();
                    txtRh.Text = ds.Tables[0].Rows[0][7].ToString();
                    txtBloodGroup.Text = ds.Tables[0].Rows[0][8].ToString();
                    txtCity.Text = ds.Tables[0].Rows[0][9].ToString();
                    txtAdress.Text = ds.Tables[0].Rows[0][10].ToString();

                }
                else
                {
                    MessageBox.Show("Invalid Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure ?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)==DialogResult.OK)
            {
                string query = "delete from newDonor where donorId = " + textBox1.Text + "";
                fn.setData(query);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {


                txtName.Clear();
                txtFatherName.Clear();
                txtMotherName.Clear();
                textBox2.Clear();
                txtMobileNum.Clear();
                txtGender.Clear();
                txtRh.Clear();
                txtCity.Clear();
                txtAdress.Clear();
            }
        }
    }
}
