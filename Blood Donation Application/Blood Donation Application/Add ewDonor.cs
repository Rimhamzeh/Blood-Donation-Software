using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Donation_Application
{
    public partial class AddNewDonor : Form
    {
        function fn = new function();
        public AddNewDonor()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (txtName.Text!="" && txtFatherName.Text!="" && txtMotherName.Text!="" && txtDate.Text!="" && txtMobileNum.Text!="" && txtGender.Text!="" && txtRh.Text!="" && txtBloodGroup.Text != ""  && txtCity.Text != "" && txtAdress.Text != "")
            {
                string dname = txtName.Text;
                string fname = txtFatherName.Text;
                string mname = txtMotherName.Text;
                string date = txtDate.Text;
                Int64 mobile = Int64.Parse(txtMobileNum.Text);
                string gender = txtGender.Text;
                string rh = txtRh.Text;
                string bloodgroup = txtBloodGroup.Text;
                string city = txtCity.Text;
                string address =txtAdress.Text;

                

               String query = "insert into newDonor(donorname,fathername,mothername,dateOfBirth,mobile,gender,Rh,bloodGroup,city,addres) values ('" + dname + "','" + fname + "','" + mname + "','" + date + "'," + mobile + ",'" + gender + "','" + rh + "','" + bloodgroup + "','" + city + "','" + address + "')";

                fn.setData(query);
               

            }
            else
            {
                MessageBox.Show("Fill all Fields", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddNewDonor_Load(object sender, EventArgs e)
        {
           
            
            String query = "select max(donorId) from newDonor";
            DataSet ds = fn.getData(query);
            int count= int.Parse(ds.Tables[0].Rows[0][0].ToString());
            labelNewID.Text = (count+1).ToString();
        }

        private void Id_Click(object sender, EventArgs e)
        {

        }

        private void txtGender_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            txtBloodGroup.ResetText();
            txtCity.Clear();
            txtAdress.Clear();
                
        }
    }
}
