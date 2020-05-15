using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AmmunitionProject
{
    public partial class RifleForm : Form

    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter adapt;
        int id = -1;

        public RifleForm()
        {
            InitializeComponent();
            DisplayData();
        }

        private void DisplayData()
        {
            con = new SqlConnection("Data Source=MITCHELLDESKTOP;Initial Catalog=CompSciProject;Integrated Security=True");
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT * FROM dbo.Rifles", con);
            adapt.Fill(dt);
            dgvRifles.DataSource = dt;
            dgvRifles.Columns[0].Visible = false;
            dgvRifles.ReadOnly = true;
            dgvRifles.MultiSelect = false;
            for (int i = 0; i < dgvRifles.Columns.Count; i++)
            {
                dgvRifles.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            con.Close();
        }

        private void ClearData()
        {
            txtBarrel.Text = "";
            txtCaliber.Text = "";
            txtMakeAndModel.Text = "";
            txtScope.Text = "";
            id = -1;
        }

        private void btnNewRifle_Click(object sender, EventArgs e)
        {
            string makeModel = txtMakeAndModel.Text;
            string caliber = txtCaliber.Text;
            string barrel = txtBarrel.Text;
            string scope = txtScope.Text;

            if (string.IsNullOrWhiteSpace(makeModel))
                MessageBox.Show("Error: Make and Model is blank");
            else if (string.IsNullOrWhiteSpace(caliber))
                MessageBox.Show("Error: Caliber is blank");
            else if (string.IsNullOrWhiteSpace(barrel))
                MessageBox.Show("Error: Barrel is blank");
            else if (string.IsNullOrWhiteSpace(scope))
                MessageBox.Show("Error: Scope is blank");
            else
            {
                con = new SqlConnection("Data Source=MITCHELLDESKTOP;Initial Catalog=CompSciProject;Integrated Security=True");
                using (con)
                {
                    try
                    {
                        cmd = new SqlCommand("INSERT INTO dbo.Rifles(Make_Model, Caliber, Barrel, Scope) " +
                            "Values (@makeModel, @caliber, @barrel, @scope)", con);

                        con.Open();
                        cmd.Parameters.AddWithValue("@makeModel", makeModel);
                        cmd.Parameters.AddWithValue("@caliber", caliber);
                        cmd.Parameters.AddWithValue("@barrel", barrel);
                        cmd.Parameters.AddWithValue("@scope", scope);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Rifle added successfully");
                        DisplayData();
                        ClearData();
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Error adding entry");
                    }
                }
            }
        }

        private void dgvRifles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgvRifles.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtMakeAndModel.Text = dgvRifles.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCaliber.Text = dgvRifles.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtBarrel.Text = dgvRifles.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtScope.Text = dgvRifles.Rows[e.RowIndex].Cells[4].Value.ToString();

        }

        private void btnEditRifles_Click(object sender, EventArgs e)
        {
            string makeModel = txtMakeAndModel.Text;
            string barrel = txtBarrel.Text;
            string caliber = txtCaliber.Text;
            string scope = txtScope.Text;

            if (id == -1)
                MessageBox.Show("Please select a rifle to edit");
            else if (string.IsNullOrWhiteSpace(makeModel))
                MessageBox.Show("Error: Make and Model is blank");
            else if (string.IsNullOrWhiteSpace(caliber))
                MessageBox.Show("Error: Caliber is blank");
            else if (string.IsNullOrWhiteSpace(barrel))
                MessageBox.Show("Error: Barrel is blank");
            else if (string.IsNullOrWhiteSpace(scope))
                MessageBox.Show("Error: Scope is blank");
            else
            {
                con = new SqlConnection("Data Source=MITCHELLDESKTOP;Initial Catalog=CompSciProject;Integrated Security=True");
                using (con)
                {
                    try
                    {
                        cmd = new SqlCommand("UPDATE dbo.Rifles " +
                            "SET Make_Model = @makeModel, Caliber = @caliber, Barrel = @barrel, Scope = @scope " +
                            "WHERE Rifle_ID=@id", con);
                        con.Open();
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@makeModel", makeModel);
                        cmd.Parameters.AddWithValue("@caliber", caliber);
                        cmd.Parameters.AddWithValue("@barrel", barrel);
                        cmd.Parameters.AddWithValue("@scope", scope);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Rifle updated successfully");
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

        private void btnDeleteRifles_Click(object sender, EventArgs e)
        {
            if (id != -1)
            {
                con = new SqlConnection("Data Source=MITCHELLDESKTOP;Initial Catalog=CompSciProject;Integrated Security=True");
                cmd = new SqlCommand("DELETE from dbo.Rifles WHERE Rifle_ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Rifle deleted successfully");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please select a rifle to delete");
            }
        }

    }
}
