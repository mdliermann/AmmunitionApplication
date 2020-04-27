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
    public partial class PrimerForm : Form
    {
        SqlCommand cmd;
        SqlConnection con = new SqlConnection("Data Source=MITCHELLDESKTOP;Initial Catalog=CompSciProject;Integrated Security=True");

        public PrimerForm()
        {
            InitializeComponent();
        }

        private void btnNewPrimer_Click(object sender, EventArgs e)
        {
            string description = txtDescription.Text;

            if (string.IsNullOrWhiteSpace(description))
                MessageBox.Show("Error: Description is blank");
            else
            {
                Primer p = new Primer(description);
                Add_Primer(p);
                MessageBox.Show("New Primer Added");
                txtDescription.Text = "";
            }
        }

        private void Add_Primer(Primer p)
        {
           
            cmd = new SqlCommand("INSERT INTO dbo.Primers Values ('" + p.Description + "')", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

    }
    
}
