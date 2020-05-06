using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AmmunitionProject
{
    public partial class SessionsForm : Form
    {
        SqlCommand cmd;
        SqlConnection con = new SqlConnection("Data Source=MITCHELLDESKTOP;Initial Catalog=CompSciProject;Integrated Security=True");
        SqlDataAdapter adapt;
        int id = -1;
        int rifleid = -1; 
        public SessionsForm()
        {
            InitializeComponent();
            DisplayData();

            con.Open();
            adapt = new SqlDataAdapter("Select Rifle_ID, Make_Model From dbo.Rifles ORDER BY Make_Model", con);
            DataSet ds = new DataSet();
            adapt.Fill(ds, "Rifles");
            cbRifles.DisplayMember = "Make_Model";
            cbRifles.ValueMember = "Rifle_ID";
            cbRifles.DataSource = ds.Tables["Rifles"];
            con.Close(); 
        }

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select s.Session_ID, s.Rifle_ID, r.Make_Model, s.Date, s.Wind_Speed, s.Humidity, s.Distance, s.Temperature " +
                "from dbo.Sessions s Inner Join dbo.Rifles r ON r.Rifle_ID = s.Rifle_ID", con);
            adapt.Fill(dt);
            dgvSessions.DataSource = dt;
            dgvSessions.ReadOnly = true;
            dgvSessions.MultiSelect = false;
            dgvSessions.Columns[0].Visible = false;
            dgvSessions.Columns[1].Visible = false; 

            for (int i = 0; i < dgvSessions.Columns.Count; i++)
            {
                dgvSessions.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            con.Close();
        }

        private void ClearData()
        {
            txtDate.Text = "";
            txtDistance.Text = "";
            txtHumid.Text = "";
            txtTemp.Text = "";
            txtWind.Text = "";
            id = -1;
        }

        private void btnNewSession_Click(object sender, EventArgs e)
        {
            DateTime date;
            string wind = txtWind.Text;
            string distance = txtDistance.Text;
            string humid = txtHumid.Text;
            int temp;

            MessageBox.Show(rifleid.ToString());
            if (string.IsNullOrWhiteSpace(txtDate.Text) || !DateTime.TryParse(txtDate.Text, out date))
                MessageBox.Show("Error: Date must be formatted YYYY-MM-DD");
            else if (string.IsNullOrWhiteSpace(txtWind.Text))
                MessageBox.Show("Error: wind speed is empty");
            else if (string.IsNullOrWhiteSpace(txtTemp.Text) || !Int32.TryParse(txtTemp.Text, out temp))
                MessageBox.Show("Error: temperature must be an integer");
            else if (string.IsNullOrWhiteSpace(txtHumid.Text))
                MessageBox.Show("Error: humidity is empty");
            else if (string.IsNullOrWhiteSpace(txtDistance.Text))
                MessageBox.Show("Error: distance is empty");
            else
            {
                try
                {
                    cmd = new SqlCommand("INSERT INTO dbo.Sessions(Date, Wind_Speed, Humidity, Distance, Rifle_ID, Temperature) " +
                        "Values (@date, @wind, @humidity, @distance, @rifleID, @temperature)", con);

                    con.Open();
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@wind", wind);
                    cmd.Parameters.AddWithValue("@humidity", humid);
                    cmd.Parameters.AddWithValue("@distance", distance);
                    cmd.Parameters.AddWithValue("@rifleID", rifleid);
                    cmd.Parameters.AddWithValue("@temperature", temp);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Session added successfully");
                    DisplayData();
                    ClearData();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error adding entry");
                }
            }
        }

        private void dgvSessions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgvSessions.Rows[e.RowIndex].Cells[0].Value.ToString());
            string tempdate = dgvSessions.Rows[e.RowIndex].Cells[3].Value.ToString();
            
            tempdate = tempdate.Substring(0, tempdate.LastIndexOf(" 12:00:00 AM"));
            txtDate.Text = tempdate;
            
            txtDistance.Text = dgvSessions.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtHumid.Text = dgvSessions.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtTemp.Text = dgvSessions.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtWind.Text = dgvSessions.Rows[e.RowIndex].Cells[4].Value.ToString();
            cbRifles.SelectedValue = dgvSessions.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnEditSession_Click(object sender, EventArgs e)
        {
            DateTime date;
            string wind = txtWind.Text;
            string distance = txtDistance.Text;
            string humid = txtHumid.Text;
            int temp;
            rifleid = (int)(cbRifles.SelectedValue);

            if (id == -1)
                MessageBox.Show("Please select a session to edit");
            else if (string.IsNullOrWhiteSpace(txtDate.Text) || !DateTime.TryParse(txtDate.Text, out date))
                MessageBox.Show("Error: Date is not propery formatted");
            else if (string.IsNullOrWhiteSpace(wind))
                MessageBox.Show("Error: Wind Speed is blank");
            else if (string.IsNullOrWhiteSpace(distance))
                MessageBox.Show("Error: Distance is blank");
            else if (string.IsNullOrWhiteSpace(humid))
                MessageBox.Show("Error: Humidity is blank");
            else if (string.IsNullOrWhiteSpace(txtTemp.Text) || !Int32.TryParse(txtTemp.Text, out temp))
                MessageBox.Show("Error: Temperature must be in integer");
            else
            {
                try
                {
                    cmd = new SqlCommand("UPDATE dbo.Sessions " +
                        "SET Date = @date, Wind_Speed = @wind, Humidity = @humidity, Distance = @distance, Temperature = @temperature, Rifle_ID = @rifleid " +
                        "WHERE Session_ID=@id", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@wind", wind);
                    cmd.Parameters.AddWithValue("@humidity", humid);
                    cmd.Parameters.AddWithValue("@distance", distance);
                    cmd.Parameters.AddWithValue("@temperature", temp);
                    cmd.Parameters.AddWithValue("@rifleid", rifleid);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Session updated successfully");
                    DisplayData();
                    ClearData();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error editing entry");
                }
            }
        }

        private void btnDeleteSession_Click(object sender, EventArgs e)
        {
            if (id != -1)
            {
                cmd = new SqlCommand("DELETE from dbo.Sessions WHERE Session_ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Session deleted successfully");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please select a session to delete");
            }
        }

        private void btnSeries_Click(object sender, EventArgs e)
        {
           
        }

        private void cbRifles_SelectedIndexChanged(object sender, EventArgs e)
        {
            rifleid = (int)(cbRifles.SelectedValue);
        }
    }
}
