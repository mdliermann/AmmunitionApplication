using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AmmunitionProject
{
    public partial class PrimerForm : Form
    {
        SqlCommand cmd;
        SqlConnection con = new SqlConnection("Data Source=MITCHELLDESKTOP;Initial Catalog=CompSciProject;Integrated Security=True");
        SqlDataAdapter adapt;
        int id = -1;

        public PrimerForm()
        {
            InitializeComponent();
            DisplayData();
        }

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT * FROM dbo.Primers", con);
            adapt.Fill(dt);
            dgvPrimers.DataSource = dt;
            dgvPrimers.Columns[0].Visible = false;
            dgvPrimers.ReadOnly = true;
            dgvPrimers.MultiSelect = false;
            for (int i = 0; i < dgvPrimers.Columns.Count; i++)
            {
                dgvPrimers.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            con.Close();
        }

        private void ClearData()
        {
            txtDescription.Text = "";
            id = -1;
        }

        private void btnNewPrimer_Click(object sender, EventArgs e)
        {
            string description = txtDescription.Text;

            if (string.IsNullOrWhiteSpace(description))
                MessageBox.Show("Error: Description is blank");
            else
            {
                using (con)
                {
                    try
                    {
                        cmd = new SqlCommand("INSERT INTO dbo.Primers(description) Values (@description)", con);

                        con.Open();
                        cmd.Parameters.AddWithValue("@description", txtDescription.Text);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Primer added successfully");
                        DisplayData();
                        ClearData();
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Error: duplicate entry");
                    }
                }
            }
        }

        private void dgvPrimers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgvPrimers.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtDescription.Text = dgvPrimers.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnEditPrimers_Click(object sender, EventArgs e)
        {
            string description = txtDescription.Text;

            if (string.IsNullOrWhiteSpace(description) || id == -1)
                MessageBox.Show("Please select a primer to edit");
            else
            {
                using (con)
                {
                    try
                    {
                        cmd = new SqlCommand("UPDATE dbo.Primers " +
                            "SET description = @description " +
                            "WHERE Primer_ID=@id", con);
                        con.Open();
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@description", description);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Primer updated Successfully");
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

        private void btnDeletePrimers_Click(object sender, EventArgs e)
        {
            if (id != -1)
            {
                cmd = new SqlCommand("DELETE from dbo.Primers WHERE Primer_ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Primer deleted successfully");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please select a primer to delete");
            }
        }
    }

}
