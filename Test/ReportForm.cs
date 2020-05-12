using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AmmunitionProject
{
    public partial class ReportForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=MITCHELLDESKTOP;Initial Catalog=CompSciProject;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt; 
        public ReportForm()
        {
            InitializeComponent();
            Fill_Combobox();
        }

        void Fill_Combobox()
        {
            adapt = new SqlDataAdapter("Select Session_ID, CONVERT(Varchar, Date, 101) AS Date, r.Make_Model From dbo.Sessions s " +
                    "Inner Join dbo.Rifles r on r.Rifle_ID = s.Rifle_ID ORDER BY Date", con);

            DataTable dt = new DataTable();

            using (con)
            {
                con.Open();
                try
                {
                    adapt.Fill(dt);
                    dt.Columns.Add("Concatonated", typeof(string), "Date + ' ' + Make_Model");
                    cmbSessionsList.DisplayMember = "Concatonated";
                    cmbSessionsList.ValueMember = "Session_ID";
                    cmbSessionsList.DataSource = dt;
                    adapt.Dispose();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
           
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {

        }

        private void SessionsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
