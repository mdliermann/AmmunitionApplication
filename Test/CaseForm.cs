using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Test
{

    public partial class CaseForm : Form
    {
        SqlCommand cmd;
        SqlConnection con = new SqlConnection("Data Source=MITCHELLDESKTOP;Initial Catalog=CompSciProject;Integrated Security=True");
        SqlDataAdapter adapt;
        int id = -1;   

        public CaseForm()
        {
            InitializeComponent();
            DisplayData();
        }

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT * FROM dbo.Cases", con);
            adapt.Fill(dt);
            dgvCases.DataSource = dt;
            dgvCases.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvCases.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            con.Close();
        }

        private void ClearData()
        {
            txtCaseManufacturer.Text = "";
            id = -1; 
        }

        private void btnNewCase_Click(object sender, EventArgs e)
        {
            string manufacturer = txtCaseManufacturer.Text;
            
            if (string.IsNullOrWhiteSpace(manufacturer))
                MessageBox.Show("Error: Manufacturer is blank");
            else
            {
                cmd = new SqlCommand("INSERT INTO dbo.Cases(manufacturer) Values (@manufacturer)", con);

                con.Open();
                cmd.Parameters.AddWithValue("@manufacturer", txtCaseManufacturer.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("New case added");
                DisplayData();
                ClearData(); 
            }
            
        }

        private void dgvCases_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgvCases.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtCaseManufacturer.Text = dgvCases.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnEditCase_Click(object sender, EventArgs e)
        {
            string manufacturer = txtCaseManufacturer.Text;

            if (string.IsNullOrWhiteSpace(manufacturer))
                MessageBox.Show("Error: Manufacturer is blank");
            else
            {
                cmd = new SqlCommand("UPDATE dbo.Cases " +
                    "SET manufacturer = @manufacturer " +
                    "WHERE Case_ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@manufacturer", manufacturer);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Case Updated Successfully");
                DisplayData();
                ClearData();
            }
        }

        private void btnDeleteCase_Click(object sender, EventArgs e)
        {

        }
    }
}
