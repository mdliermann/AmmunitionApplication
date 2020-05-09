using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace AmmunitionProject
{
    public partial class SeriesForm : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter adapt;
        int seriesid = -1;
        int shotid = -1;
        int sessionid = -1;

        public SeriesForm()
        {
            InitializeComponent();
            FillComboBoxes();
            DisplaySeriesData();
            sessionid = (int)cmbSessions.SelectedValue;
        }
        private void FillComboBoxes()
        {
            DataTable dt;
            con = new SqlConnection("Data Source=MITCHELLDESKTOP;Initial Catalog=CompSciProject;Integrated Security=True");
            using (con)
            {
                adapt = new SqlDataAdapter("Select Case_ID, Manufacturer From dbo.Cases ORDER BY Manufacturer", con);
                dt = new DataTable();
                adapt.Fill(dt);
                cmbCases.DisplayMember = "Manufacturer";
                cmbCases.ValueMember = "Case_ID";
                cmbCases.DataSource = dt;
                adapt.Dispose();

                adapt = new SqlDataAdapter("Select Powder_ID, Manufacturer From dbo.Powders ORDER BY Manufacturer", con);
                dt = new DataTable();
                adapt.Fill(dt);
                cmbPowders.DisplayMember = "Manufacturer";
                cmbPowders.ValueMember = "Powder_ID";
                cmbPowders.DataSource = dt;
                adapt.Dispose();

                adapt = new SqlDataAdapter("Select Primer_ID, Description From dbo.Primers ORDER BY Description", con);
                dt = new DataTable();
                adapt.Fill(dt);
                cmbPrimers.DisplayMember = "Description";
                cmbPrimers.ValueMember = "Primer_ID";
                cmbPrimers.DataSource = dt;
                adapt.Dispose();

                adapt = new SqlDataAdapter("Select Projectile_ID, PN, Brand, Description, Weight From dbo.Projectiles ORDER BY Brand, PN", con);
                dt = new DataTable();
                adapt.Fill(dt);
                cmbProjectiles.ValueMember = "Projectile_ID";
                dt.Columns.Add("Concatonated", typeof(string), "PN + ' ' + Brand + ' ' + Description + ' ' + Weight");
                cmbProjectiles.DisplayMember = "Concatonated";
                cmbProjectiles.DataSource = dt;
                adapt.Dispose();

                adapt = new SqlDataAdapter("Select Session_ID, CONVERT(Varchar, Date, 101) AS Date, r.Make_Model From dbo.Sessions s " +
                    "Inner Join dbo.Rifles r on r.Rifle_ID = s.Rifle_ID ORDER BY Date", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dt.Columns.Add("Concatonated", typeof(string), "Date + ' ' + Make_Model");
                cmbSessions.DisplayMember = "Concatonated";
                cmbSessions.ValueMember = "Session_ID";
                cmbSessions.DataSource = dt;
                adapt.Dispose();
            }
        }

        private void DisplaySeriesData()
        {
            con = new SqlConnection("Data Source=MITCHELLDESKTOP;Initial Catalog=CompSciProject;Integrated Security=True");
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT s.Series_ID, p.Projectile_ID, c.Case_ID, pr.Primer_ID, po.Powder_ID, s.Series_Number AS '#', p.PN AS 'Projectile', c.Manufacturer AS 'Case', pr.Description AS 'Primer', po.Manufacturer AS 'Powder', s.Powder_Amount, s.COAL, s.CBTO, s.Group_Height, s.Group_Width " +
                "FROM dbo.Series s " +
                "INNER JOIN dbo.Sessions se on se.Session_ID = s.Session_ID " +
                "INNER JOIN dbo.Projectiles p on p.Projectile_ID = s.Projectile_ID " +
                "INNER JOIN dbo.Cases c on c.Case_ID = s.Case_ID " +
                "INNER JOIN dbo.Primers pr on pr.Primer_ID = s.Primer_ID " +
                "INNER JOIN dbo.Powders po on po.Powder_ID = s.Powder_ID " +
                "WHERE s.Session_ID = @id", con);
            adapt.SelectCommand.Parameters.AddWithValue("@id", sessionid);
            adapt.Fill(dt);
            dgvSeries.DataSource = dt;
            dgvSeries.ReadOnly = true;
            dgvSeries.MultiSelect = false;
            for (int i = 0; i <= 4; i++)
            {
                dgvSeries.Columns[i].Visible = false;
            }
            for (int i = 0; i < dgvSeries.Columns.Count; i++)
            {
                dgvSeries.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            con.Close();
        }

        private void ClearSeriesData()
        {
            txtCBTO.Clear();
            txtCOAL.Clear();
            txtHeight.Clear();
            txtPowderAmount.Clear();
            txtWidth.Clear();
            seriesid = -1;
        }

        private void cmbSessions_SelectionChangeCommitted(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=MITCHELLDESKTOP;Initial Catalog=CompSciProject;Integrated Security=True");
            cmbSeries.Text = "";
            sessionid = (int)cmbSessions.SelectedValue;
            DataTable dt;
            using (con)
            {
                adapt = new SqlDataAdapter("Select Series_ID, Series_Number From dbo.Series WHERE Session_ID = @id ORDER BY Series_Number", con);
                adapt.SelectCommand.Parameters.AddWithValue("@id", sessionid);
                dt = new DataTable();
                adapt.Fill(dt);
                cmbSeries.DisplayMember = "Series_Number";
                cmbSeries.ValueMember = "Series_ID";
                cmbSeries.DataSource = dt;
                adapt.Dispose();
            }
            DisplaySeriesData();
        }

        private void cmbSeries_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DisplayShotData();
            txtSpeed.Clear();
        }

        private void dgvSeries_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seriesid = Convert.ToInt32(dgvSeries.Rows[e.RowIndex].Cells[0].Value);

            cmbProjectiles.SelectedValue = dgvSeries.Rows[e.RowIndex].Cells[1].Value;
            cmbCases.SelectedValue = dgvSeries.Rows[e.RowIndex].Cells[2].Value;
            cmbPrimers.SelectedValue = dgvSeries.Rows[e.RowIndex].Cells[3].Value;
            cmbPowders.SelectedValue = dgvSeries.Rows[e.RowIndex].Cells[4].Value;

            txtPowderAmount.Text = dgvSeries.Rows[e.RowIndex].Cells[10].Value.ToString();
            txtCOAL.Text = dgvSeries.Rows[e.RowIndex].Cells[11].Value.ToString();
            txtCBTO.Text = dgvSeries.Rows[e.RowIndex].Cells[12].Value.ToString();
            txtHeight.Text = dgvSeries.Rows[e.RowIndex].Cells[13].Value.ToString();
            txtWidth.Text = dgvSeries.Rows[e.RowIndex].Cells[14].Value.ToString();
        }

        private void btnNewSeries_Click(object sender, EventArgs e)
        {
            sessionid = Convert.ToInt32(cmbSessions.SelectedValue);
            int proj = Convert.ToInt32(cmbProjectiles.SelectedValue);
            int cases = Convert.ToInt32(cmbCases.SelectedValue);
            int powder = Convert.ToInt32(cmbPowders.SelectedValue);
            int primer = Convert.ToInt32(cmbPrimers.SelectedValue);
            decimal powderAmt, COAL, CBTO, height, width;
            int number;

            if (string.IsNullOrWhiteSpace(txtPowderAmount.Text) || !Decimal.TryParse(txtPowderAmount.Text, out powderAmt))
                MessageBox.Show("Error: Powder Amount must be a decimal");
            else if (string.IsNullOrWhiteSpace(txtCOAL.Text) || !Decimal.TryParse(txtCOAL.Text, out COAL))
                MessageBox.Show("Error: COAL must be a decimal");
            else if (string.IsNullOrWhiteSpace(txtCBTO.Text) || !Decimal.TryParse(txtCBTO.Text, out CBTO))
                MessageBox.Show("Error: CBTO must be a decimal");
            else if (string.IsNullOrWhiteSpace(txtHeight.Text) || !Decimal.TryParse(txtHeight.Text, out height))
                MessageBox.Show("Error: Group height must be a decimal");
            else if (string.IsNullOrWhiteSpace(txtWidth.Text) || !Decimal.TryParse(txtWidth.Text, out width))
                MessageBox.Show("Error: Group width must be a decimal");
            else
            {
                using (con = new SqlConnection("Data Source=MITCHELLDESKTOP;Initial Catalog=CompSciProject;Integrated Security=True"))
                {
                    con.Open();
                    using (SqlCommand numb = new SqlCommand("SELECT MAX(Series_Number) AS Next FROM dbo.Series " +
                        "WHERE Session_ID = @id", con))
                    {
                        numb.Parameters.AddWithValue("id", sessionid);
                        using (SqlDataReader read = numb.ExecuteReader())
                        {
                            if (read.Read())
                            {
                                number = Convert.ToInt32(read["Next"]) + 1;
                            }
                            else
                            {
                                number = 0;
                            }
                            MessageBox.Show(number.ToString());
                        }
                    }
                    try
                    {
                        cmd = new SqlCommand("INSERT INTO dbo.Series(Session_ID, Projectile_ID, Case_ID, Primer_ID, Powder_ID," +
                            " Powder_Amount, COAL, CBTO, Group_Height, Group_Width, Series_Number) " +
                                "Values (@id, @proj, @case, @prim, @pow, @powAmt, @COAL, @CBTO, @height, @width, @num)", con);
                        cmd.Parameters.AddWithValue("@id", sessionid);
                        cmd.Parameters.AddWithValue("@proj", proj);
                        cmd.Parameters.AddWithValue("@case", cases);
                        cmd.Parameters.AddWithValue("@prim", primer);
                        cmd.Parameters.AddWithValue("@pow", powder);
                        cmd.Parameters.AddWithValue("@powAmt", powderAmt);
                        cmd.Parameters.AddWithValue("@COAL", COAL);
                        cmd.Parameters.AddWithValue("@CBTO", CBTO);
                        cmd.Parameters.AddWithValue("@height", height);
                        cmd.Parameters.AddWithValue("@width", width);
                        cmd.Parameters.AddWithValue("@num", number);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Series added successfully");
                        ClearSeriesData();
                        DisplaySeriesData();
                        con.Close();
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Error adding entry");
                    }
                }
            }
        }

        private void btnEditSeries_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=MITCHELLDESKTOP;Initial Catalog=CompSciProject;Integrated Security=True");
            sessionid = Convert.ToInt32(cmbSessions.SelectedValue);
            int proj = Convert.ToInt32(cmbProjectiles.SelectedValue);
            int cases = Convert.ToInt32(cmbCases.SelectedValue);
            int powder = Convert.ToInt32(cmbPowders.SelectedValue);
            int primer = Convert.ToInt32(cmbPrimers.SelectedValue);
            decimal powderAmt, COAL, CBTO, height, width;
            int number;

            if (seriesid == -1)
                MessageBox.Show("Please select a series to edit");
            else if (string.IsNullOrWhiteSpace(txtPowderAmount.Text) || !Decimal.TryParse(txtPowderAmount.Text, out powderAmt))
                MessageBox.Show("Error: Powder Amount must be a decimal");
            else if (string.IsNullOrWhiteSpace(txtCOAL.Text) || !Decimal.TryParse(txtCOAL.Text, out COAL))
                MessageBox.Show("Error: COAL must be a decimal");
            else if (string.IsNullOrWhiteSpace(txtCBTO.Text) || !Decimal.TryParse(txtCBTO.Text, out CBTO))
                MessageBox.Show("Error: CBTO must be a decimal");
            else if (string.IsNullOrWhiteSpace(txtHeight.Text) || !Decimal.TryParse(txtHeight.Text, out height))
                MessageBox.Show("Error: Group height must be a decimal");
            else if (string.IsNullOrWhiteSpace(txtWidth.Text) || !Decimal.TryParse(txtWidth.Text, out width))
                MessageBox.Show("Error: Group width must be a decimal");
            else
            {
                using (con)
                {
                    try
                    {
                        cmd = new SqlCommand("UPDATE dbo.Series " +
                            "SET Projectile_ID = @proj, Case_ID = @case, Primer_ID = @prim, Powder_ID = @pow " +
                            "@Powder_Amount = @powAmt, COAL = @COAL, CBTO = @CBTO, Group_Height = @height, Group_Width = @width" +
                            "WHERE Series_ID=@id", con);
                        con.Open();
                        cmd.Parameters.AddWithValue("@id", seriesid);
                        cmd.Parameters.AddWithValue("@proj", proj);
                        cmd.Parameters.AddWithValue("@case", cases);
                        cmd.Parameters.AddWithValue("@prim", primer);
                        cmd.Parameters.AddWithValue("@pow", powder);
                        cmd.Parameters.AddWithValue("@powAmt", powderAmt);
                        cmd.Parameters.AddWithValue("@COAL", COAL);
                        cmd.Parameters.AddWithValue("@CBTO", CBTO);
                        cmd.Parameters.AddWithValue("@height", height);
                        cmd.Parameters.AddWithValue("@width", width);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Series updated successfully");
                        DisplayShotData();
                        ClearShotData();
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Error updating entry");
                    }
                }
            }
        }

        private void btnRemoveSeries_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=MITCHELLDESKTOP;Initial Catalog=CompSciProject;Integrated Security=True"); ;
            if (seriesid != -1)
            {
                cmd = new SqlCommand("DELETE from dbo.Series WHERE Series_ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", seriesid);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Series deleted successfully");
                DisplaySeriesData();
                ClearSeriesData();
            }
            else
            {
                MessageBox.Show("Please select a series to delete");
            }
        }

        private void DisplayShotData()
        {
            seriesid = Convert.ToInt32(cmbSeries.SelectedValue);
            con = new SqlConnection("Data Source=MITCHELLDESKTOP;Initial Catalog=CompSciProject;Integrated Security=True");
            using (con)
            {
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter("SELECT se.Series_ID, sh.Shot_ID, sh.Shot_Number, sh.Speed FROM dbo.Shots sh " +
                    "INNER JOIN dbo.Series se ON sh.Series_ID = se.Series_ID " +
                    "WHERE se.Series_ID = @id", con);
                adapt.SelectCommand.Parameters.AddWithValue("@id", seriesid);
                adapt.Fill(dt);
                dgvShots.DataSource = dt;
                dgvShots.ReadOnly = true;
                dgvShots.MultiSelect = false;
                dgvShots.Columns[0].Visible = false;
                dgvShots.Columns[1].Visible = false;

                for (int i = 0; i < dgvShots.Columns.Count; i++)
                {
                    dgvShots.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }
        }

        private void ClearShotData()
        {
            txtSpeed.Clear();
            shotid = -1;
        }

        private void btnNewShot_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=MITCHELLDESKTOP;Initial Catalog=CompSciProject;Integrated Security=True");
            int speed;
            int number;
            seriesid = Convert.ToInt32(cmbSeries.SelectedValue);

            if (seriesid == -1)
                MessageBox.Show("Error: Series not selected");
            else if (string.IsNullOrWhiteSpace(txtSpeed.Text) || !Int32.TryParse(txtSpeed.Text, out speed))
                MessageBox.Show("Error: speed must be a number");
            else
            {
                using (con)
                {
                    con.Open();
                    using (SqlCommand numb = new SqlCommand("SELECT MAX(Shot_Number) AS Next FROM dbo.Shots " +
                        "WHERE Series_ID = @id", con))
                    {
                        numb.Parameters.AddWithValue("id", seriesid);
                        using (SqlDataReader read = numb.ExecuteReader())
                        {
                            if (read.Read())
                            {
                                number = Convert.ToInt32(read["Next"]) + 1;
                            }
                            else
                            {
                                number = 0;
                            }
                        }
                    }
                    try
                    {
                        cmd = new SqlCommand("INSERT INTO dbo.Shots (Shot_Number, Series_ID, Speed) " +
                                "Values (@numb, @id, @speed)", con);

                        cmd.Parameters.AddWithValue("@numb", number);
                        cmd.Parameters.AddWithValue("@id", seriesid);
                        cmd.Parameters.AddWithValue("@speed", speed);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Shot added successfully");
                        DisplayShotData();
                        ClearShotData();
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Error adding entry");
                    }
                }
            }
        }

        private void btnEditShot_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=MITCHELLDESKTOP;Initial Catalog=CompSciProject;Integrated Security=True");
            int speed;

            if (shotid == -1)
                MessageBox.Show("Please select a shot to edit");
            else if (string.IsNullOrWhiteSpace(txtSpeed.Text) || !Int32.TryParse(txtSpeed.Text, out speed))
                MessageBox.Show("Error: speed must be a number");
            else
            {
                using (con)
                {
                    try
                    {
                        cmd = new SqlCommand("UPDATE dbo.Shots " +
                            "SET Speed = @speed " +
                            "WHERE Shot_ID=@id", con);
                        con.Open();
                        cmd.Parameters.AddWithValue("@id", shotid);
                        cmd.Parameters.AddWithValue("@speed", speed);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Shot updated successfully");
                        DisplayShotData();
                        ClearShotData();
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Error updating entry");
                    }
                }
            }
        }

        private void btnRemoveShot_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=MITCHELLDESKTOP;Initial Catalog=CompSciProject;Integrated Security=True");
            if (shotid != -1)
            {
                cmd = new SqlCommand("DELETE from dbo.Shots WHERE Shot_ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", shotid);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Shot deleted successfully");
                DisplayShotData();
                ClearShotData();
            }
            else
            {
                MessageBox.Show("Please select a shot to delete");
            }
        }

        private void dgvShots_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seriesid = Convert.ToInt32(cmbSeries.SelectedValue);
            shotid = Convert.ToInt32(dgvShots.Rows[e.RowIndex].Cells[1].Value);
            txtSpeed.Text = dgvShots.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
