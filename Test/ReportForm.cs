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

namespace Test
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
            Fill_Reports();
        }

        void Fill_Reports()
        {
            string connetionString = "Data Source=MITCHELLDESKTOP;Initial Catalog=CompSciProject;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(connetionString);
            string Query = "select convert(varchar(10), s.Date, 120) AS Date, r.Make_Model  from dbo.Sessions s Inner Join dbo.Rifles r ON r.Rifle_ID = s.Rifle_ID";
            SqlCommand cmdDatabase = new SqlCommand(Query, cnn);
            SqlDataReader reader;
            try
            {
                cnn.Open();
                reader = cmdDatabase.ExecuteReader();

                while (reader.Read())
                {
                    string date = reader["Date"].ToString();
                    string rifle = reader["make_model"].ToString();
                    SessionsList.Items.Add(date + ": " + rifle);
                }

                cnn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
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
