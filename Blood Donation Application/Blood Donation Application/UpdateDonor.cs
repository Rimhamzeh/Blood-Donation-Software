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
    public partial class UpdateDonor : Form
    {
        function fn = new function();
        public UpdateDonor()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text.ToString());
            string query = "select * from newDonor where donorId=" + id + "";
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count!=0)
            {
                txtName.Text = ds.Tables[0].Rows[0][1].ToString();
                txtFatherName.Text = ds.Tables[0].Rows[0][2].ToString();
                txtMotherName.Text = ds.Tables[0].Rows[0][3].ToString(); 
                txtDate.Text = ds.Tables[0].Rows[0][4].ToString();
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

        private void UpdateDonor_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                txtName.Clear();
                txtFatherName.Clear();
                txtMotherName.Clear();
                txtDate.ResetText();
                txtMobileNum.Clear();
                txtGender.ResetText();
                txtRh.ResetText();
                txtCity.Clear();
                txtAdress.Clear();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtFatherName.Clear();
            txtMotherName.Clear();
            txtDate.ResetText();
            txtMobileNum.Clear();
            txtGender.ResetText();
            txtRh.ResetText();
            txtCity.Clear();
            txtAdress.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            string query = "update newDonor set donorname='" + txtName.Text + "' ,fathername='" + txtFatherName.Text + "',mothername='" + txtMotherName.Text + "',dateOfBirth='" + txtDate.Text + "',mobile=" + txtMobileNum.Text + ",gender='" + txtGender.Text + "',Rh='" + txtRh.Text + "',bloodGroup='" + txtBloodGroup.Text + "',city='" + txtCity.Text + "',addres='" + txtAdress.Text + "' where donorId=" + textBox1.Text + "";
            fn.setData(query);
            UpdateDonor_Load(this, null);

        }
    }
}
