using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AmmunitionProject
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
            dgvCases.Columns[0].Visible = false;
            dgvCases.ReadOnly = true;
            dgvCases.MultiSelect = false;
            for (int i = 0; i < dgvCases.Columns.Count; i++)
            {
                dgvCases.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
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
                using (con)
                {
                    try
                    {
                        cmd = new SqlCommand("INSERT INTO dbo.Cases(manufacturer) Values (@manufacturer)", con);
                        con.Open();
                        cmd.Parameters.AddWithValue("@manufacturer", txtCaseManufacturer.Text);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Case added successfully");
                        DisplayData();
                        ClearData();
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Error updating entry");
                    }
                }
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

            if (string.IsNullOrWhiteSpace(manufacturer) || id == -1)
                MessageBox.Show("Please select a case to edit");
            else
            {
                using (con)
                {
                    try
                    {
                        cmd = new SqlCommand("UPDATE dbo.Cases " +
                            "SET manufacturer = @manufacturer " +
                            "WHERE Case_ID=@id", con);
                        con.Open();
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@manufacturer", manufacturer);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Case updated successfully");
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

        private void btnDeleteCase_Click(object sender, EventArgs e)
        {
            if (id != -1)
            {
                cmd = new SqlCommand("DELETE from dbo.Cases WHERE Case_ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Case deleted successfully");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please select a case to delete");
            }
        }
    }
}
