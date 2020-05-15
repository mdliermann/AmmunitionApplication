using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AmmunitionProject
{
    public partial class ProjectileForm : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter adapt;
        int id = -1;
        public ProjectileForm()
        {
            InitializeComponent();
            DisplayData();
        }

        private void DisplayData()
        {
            con = new SqlConnection("Data Source=MITCHELLDESKTOP;Initial Catalog=CompSciProject;Integrated Security=True");
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT * FROM dbo.projectiles", con);
            adapt.Fill(dt);
            dgvProjectiles.DataSource = dt;
            dgvProjectiles.Columns[0].Visible = false;
            dgvProjectiles.ReadOnly = true;
            dgvProjectiles.MultiSelect = false;
            for (int i = 0; i < dgvProjectiles.Columns.Count; i++)
            {
                dgvProjectiles.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            con.Close();
        }

        private void ClearData()
        {
            txtPN.Text = "";
            txtProjDescription.Text = "";
            txtBrand.Text = "";
            txtDiameter.Text = "";
            txtWeight.Text = "";
            txtBCG7.Text = "";
            txtBCG1.Text = "";
            id = -1;
        }

        private void btnNewProjectile_Click(object sender, EventArgs e)
        {
            string PN = txtPN.Text;
            string brand = txtBrand.Text;
            string description = txtProjDescription.Text;
            string weight = txtWeight.Text;

            decimal diameter;
            decimal bc_g1;
            decimal bc_g7 = -1;

            if (string.IsNullOrWhiteSpace(PN))
                MessageBox.Show("Error: PN is empty");
            else if (string.IsNullOrWhiteSpace(brand))
                MessageBox.Show("Error: brand is empty");
            else if (string.IsNullOrWhiteSpace(description))
                MessageBox.Show("Error: description is empty");
            else if (string.IsNullOrWhiteSpace(weight))
                MessageBox.Show("Error: weight is empty");
            else if (!Decimal.TryParse(txtDiameter.Text, out diameter))
                MessageBox.Show("Error: diameter is not correctly formatted. Must be a decimal");
            else if (!Decimal.TryParse(txtBCG1.Text, out bc_g1))
                MessageBox.Show("Error: BC_G1 is not correctly formatted. Must be a decimal");
            else if (!string.IsNullOrWhiteSpace(txtBCG7.Text) && !Decimal.TryParse(txtBCG7.Text, out bc_g7))
                MessageBox.Show("Error: BC_G7 is not correctly formatted. Must be a decimal");
            else
            {
                con = new SqlConnection("Data Source=MITCHELLDESKTOP;Initial Catalog=CompSciProject;Integrated Security=True");
                try
                {
                    cmd = new SqlCommand("INSERT INTO dbo.Projectiles(PN, Brand, Diameter, Description, Weight, BC_G1, BC_G7) " +
                        "Values (@pn, @brand, @diameter, @description, @weight, @bcg1, @bcg7)", con);

                    con.Open();
                    cmd.Parameters.AddWithValue("@pn", PN);
                    cmd.Parameters.AddWithValue("@brand", brand);
                    cmd.Parameters.AddWithValue("@diameter", diameter);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@weight", weight);
                    cmd.Parameters.AddWithValue("@bcg1", bc_g1);

                    if (bc_g7 == -1)
                        cmd.Parameters.AddWithValue("@bcg7", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@bcg7", bc_g7);

                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Projectile added successfully");
                    DisplayData();
                    ClearData();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Error adding entry");
                }
            }
        }

        private void dgvProjectiles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgvProjectiles.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtPN.Text = dgvProjectiles.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtBrand.Text = dgvProjectiles.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtDiameter.Text = dgvProjectiles.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtProjDescription.Text = dgvProjectiles.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtWeight.Text = dgvProjectiles.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtBCG1.Text = dgvProjectiles.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtBCG7.Text = dgvProjectiles.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void btnEditProj_Click(object sender, EventArgs e)
        {
            string PN = txtPN.Text;
            string brand = txtBrand.Text;
            string description = txtProjDescription.Text;
            string weight = txtWeight.Text;

            decimal diameter;
            decimal bc_g1;
            decimal bc_g7 = -1;

            if (id == -1)
                MessageBox.Show("Please select a projectile to edit");
            else if (string.IsNullOrWhiteSpace(PN))
                MessageBox.Show("Error: PN is empty");
            else if (string.IsNullOrWhiteSpace(brand))
                MessageBox.Show("Error: brand is empty");
            else if (string.IsNullOrWhiteSpace(description))
                MessageBox.Show("Error: description is empty");
            else if (string.IsNullOrWhiteSpace(weight))
                MessageBox.Show("Error: weight is empty");
            else if (!Decimal.TryParse(txtDiameter.Text, out diameter))
                MessageBox.Show("Error: diameter is not correctly formatted. Must be a decimal");
            else if (!Decimal.TryParse(txtBCG1.Text, out bc_g1))
                MessageBox.Show("Error: BC_G1 is not correctly formatted. Must be a decimal");
            else if (!string.IsNullOrWhiteSpace(txtBCG7.Text) && !Decimal.TryParse(txtBCG7.Text, out bc_g7))
                MessageBox.Show("Error: BC_G7 is not correctly formatted. Must be a decimal");
            else
            {
                con = new SqlConnection("Data Source=MITCHELLDESKTOP;Initial Catalog=CompSciProject;Integrated Security=True");
                try
                {
                    cmd = new SqlCommand("UPDATE dbo.Projectiles " +
                        "SET PN = @pn, Brand = @brand, Description = @description, Weight = @weight, Diameter = @diameter, BC_G1 = @bcg1, BC_G7 = @bcg7 " +
                        "WHERE Projectile_ID=@id", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@pn", PN);
                    cmd.Parameters.AddWithValue("@brand", brand);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@weight", weight);
                    cmd.Parameters.AddWithValue("@diameter", diameter);
                    cmd.Parameters.AddWithValue("@bcg1", bc_g1);
                    if (bc_g7 == -1)
                        cmd.Parameters.AddWithValue("@bcg7", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@bcg7", bc_g7);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Projectile updated successfully");
                    DisplayData();
                    ClearData();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Error updating entry");
                }
            }
        }

        private void btnDeleteProj_Click(object sender, EventArgs e)
        {
            if (id != -1)
            {
                con = new SqlConnection("Data Source=MITCHELLDESKTOP;Initial Catalog=CompSciProject;Integrated Security=True");
                cmd = new SqlCommand("DELETE from dbo.Projectiles WHERE Projectile_ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Projectile deleted successfully");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please select a projectile to delete");
            }
        }
    }
}
