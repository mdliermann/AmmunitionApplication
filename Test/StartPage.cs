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
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void StartPage_Load(object sender, EventArgs e)
        {

        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlCommand cmd;
            SqlDataReader datareader;
            String sql = "";
            String output = "";

            connetionString = "Data Source=MITCHELLDESKTOP;Initial Catalog=CompSciProject;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(connetionString);
            cnn.Open();

            sql = "Select * from Rifles";
            cmd = new SqlCommand(sql, cnn);

            datareader = cmd.ExecuteReader();
            
            while (datareader.Read())
            {
                output += datareader.GetValue(0) + " - " + datareader.GetValue(1) + 
                    " - " + datareader.GetValue(2) + " - " + datareader.GetValue(3) + " - " + datareader.GetValue(4) + "\n";
            }
            MessageBox.Show(output);

            datareader.Close();
            cmd.Dispose();
            cnn.Close();
        }
    }
}
