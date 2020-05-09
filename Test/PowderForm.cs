using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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
            for (int i = 0; i < dgvPowders.Columns.Count; i++)
            {
                dgvPowders.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
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
                using (con)
                {
                    try
                    {
                        cmd = new SqlCommand("INSERT INTO dbo.Powders(manufacturer) Values (@manufacturer)", con);

                        con.Open();
                        cmd.Parameters.AddWithValue("@manufacturer", txtPowderManufacturer.Text);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Powder updated successfully");
                        DisplayData();
                        ClearData();
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Error: Duplicate entry");
                    }
                }
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

            if (string.IsNullOrWhiteSpace(manufacturer) || id == -1)
                MessageBox.Show("Please select a powder to edit");
            else
            {
                using (con)
                {
                    try
                    {
                        cmd = new SqlCommand("UPDATE dbo.Powders " +
                        "SET manufacturer = @manufacturer " +
                        "WHERE Powder_ID=@id", con);
                        con.Open();
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@manufacturer", manufacturer);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Powder updated Successfully");
                        DisplayData();
                        ClearData();
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Error: Duplicate entry");
                    }
                }
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
                MessageBox.Show("Please select a powder to delete");
            }
        }
    }
}
