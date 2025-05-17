using System;

using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Donation_Application
{
    class function
    {
    

        protected SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-177U73I\\SQLEXPRESS01;Initial Catalog=BloodDonationdb;Integrated Security=True";
            return con; 
        }
        public DataSet getData( String query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da= new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public void setData(string query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;

            cmd.ExecuteNonQuery();
            con.Close();
           
             MessageBox.Show("Data Processed successfully", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}