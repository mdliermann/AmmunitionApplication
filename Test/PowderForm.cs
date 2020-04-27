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
    public partial class PowderForm : Form
    {
        SqlCommand cmd;
        SqlConnection con = new SqlConnection("Data Source=MITCHELLDESKTOP;Initial Catalog=CompSciProject;Integrated Security=True");
        public PowderForm()
        {
            InitializeComponent();
        }

        private void btnNewPowder_Click(object sender, EventArgs e)
        {
            string manufacturer = txtPowderManufacturer.Text;

            if (string.IsNullOrWhiteSpace(manufacturer))
                MessageBox.Show("Error: Manufacturer is blank");
            else
            {
                Powder p = new Powder(manufacturer);
                Add_Powder(p);
                MessageBox.Show("New Powder Added");
            }

        }

        private void Add_Powder(Powder p)
        {
            cmd = new SqlCommand("INSERT INTO dbo.Powders Values ('" + p.Manufacturer + "')", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
