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
    public partial class CaseForm : Form
    {
        public CaseForm()
        {
            InitializeComponent();
        }

        private void btnNewCase_Click(object sender, EventArgs e)
        {
            string manufacturer = txtCaseManufacturer.Text;
            
            if (string.IsNullOrWhiteSpace(manufacturer))
                MessageBox.Show("Error: Manufacturer is blank");
            else
            {
                Case cs = new Case(manufacturer);
                Add_Case(cs);
                MessageBox.Show("New case added");
            }
            
        }

        private void Add_Case(Case c)
        {
            string cs;
            SqlCommand cmd;
            cs = "Data Source=MITCHELLDESKTOP;Initial Catalog=CompSciProject;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            cmd = new SqlCommand("INSERT INTO dbo.Cases Values ('" + c.Manufacturer +"')" , con);

            con.Open();
            cmd.ExecuteNonQuery();

            con.Close();

        }
    }
}
