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

namespace AmmunitionProject
{
    public partial class PowderForm : Form
    {
        SqlCommand cmd;
        SqlConnection con = new SqlConnection("Data Source=MITCHELLDESKTOP;Initial Catalog=CompSciProject;Integrated Security=True");
        SqlDataAdapter adapt;
        int id = -1;

        public PowderForm()
        {
            InitializeComponent();
            DisplayData(); 
        }

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT * FROM dbo.Powders", con);
            adapt.Fill(dt);
            dgvPowders.DataSource = dt;
            dgvPowders.Columns[0].Visible = false;
            dgvPowders.ReadOnly = true;
            dgvPowders.MultiSelect = false;
            con.Close();
        }

        private void ClearData()
        {
            txtPowderManufacturer.Text = "";
            id = -1;
        }

        private void btnNewPowder_Click(object sender, EventArgs e)
        {
            string manufacturer = txtPowderManufacturer.Text;

            if (string.IsNullOrWhiteSpace(manufacturer))
                MessageBox.Show("Error: Manufacturer is blank");
            else
            {
                cmd = new SqlCommand("INSERT INTO dbo.Powders(manufacturer) Values (@manufacturer)", con);

                con.Open();
                cmd.Parameters.AddWithValue("@manufacturer", txtPowderManufacturer.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Powder updated successfully");
                DisplayData();
                ClearData();
            }

        }

        private void dgvPowders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgvPowders.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtPowderManufacturer.Text = dgvPowders.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnEditPowder_Click(object sender, EventArgs e)
        {
            string manufacturer = txtPowderManufacturer.Text;

            if (string.IsNullOrWhiteSpace(manufacturer))
                MessageBox.Show("Error: Manufacturer is blank");
            else
            {
                cmd = new SqlCommand("UPDATE dbo.Powders " +
                    "SET manufacturer = @manufacturer " +
                    "WHERE Powder_ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@manufacturer", manufacturer);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Powder updated Successfully");
                DisplayData();
                ClearData();
            }
        }

        private void btnDeletePowder_Click(object sender, EventArgs e)
        {
            if (id != -1)
            {
                cmd = new SqlCommand("DELETE from dbo.Powders WHERE Powder_ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Powder deleted successfully");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please select Powder to delete");
            }
        }
    }
}
