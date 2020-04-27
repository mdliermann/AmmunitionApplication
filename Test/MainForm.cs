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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        /*
        void Fill_Case()
        {
            string connetionString = "Data Source=MITCHELLDESKTOP;Initial Catalog=CompSciProject;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(connetionString);
            string Query = "select * from dbo.cases";
            SqlCommand cmdDatabase = new SqlCommand(Query, cnn);
            SqlDataReader reader;
            try
            {
                cnn.Open();
                reader = cmdDatabase.ExecuteReader();

                while (reader.Read())
                {
                    string case_manufacturer = reader["manufacturer"].ToString();
                    Cases_List.Items.Add(case_manufacturer);
                }

                cnn.Close(); 
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        */

        private void btnCases_Click(object sender, EventArgs e)
        {
            Form casef = new CaseForm();
            casef.Show();
        }

        private void btnPrimers_Click(object sender, EventArgs e)
        {
            Form primf = new PrimerForm();
            primf.Show();
        }

        private void btnPowders_Click(object sender, EventArgs e)
        {
            Form powdf = new PowderForm();
            powdf.Show();
        }

        private void btnProjectiles_Click(object sender, EventArgs e)
        {
            Form projf = new ProjectileForm();
            projf.Show();
        }

        private void btnRilfes_Click(object sender, EventArgs e)
        {
            Form rif = new RifleForm();
            rif.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Form rf = new ReportForm();
            rf.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
