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
    public partial class RifleForm : Form

    {
        SqlCommand cmd;
        SqlConnection con = new SqlConnection("Data Source=MITCHELLDESKTOP;Initial Catalog=CompSciProject;Integrated Security=True");
        public RifleForm()
        {
            InitializeComponent();
        }

        private void btnNewRifle_Click(object sender, EventArgs e)
        {
            string makeModel = txtMakeAndModel.Text;
            string caliber = txtCaliber.Text;
            string barrel = txtBarrel.Text;
            string scope = txtScope.Text;
            bool success = true;

            if (string.IsNullOrWhiteSpace(makeModel))
            {
                MessageBox.Show("Error: Make and Model is blank");
                success = false;
            }
            if (string.IsNullOrWhiteSpace(caliber))
            {
                MessageBox.Show("Error: Caliber is blank");
                success = false;
            }
            if (string.IsNullOrWhiteSpace(barrel))
            {
                MessageBox.Show("Error: Barrel is blank");
                success = false;
            }
            if (string.IsNullOrWhiteSpace(scope))
            {
                MessageBox.Show("Error: Scope is blank");
                success = false;
            }

            if(success)
            {
                Rifle rf = new Rifle(makeModel, caliber, barrel, scope);
                Add_New_Rifle(rf);
                MessageBox.Show("New rifle added");
            }
        }

        private void Add_New_Rifle(Rifle r)
        {
            cmd = new SqlCommand("INSERT INTO dbo.Rifles Values " +
                "('" + r.MakeModel + "' , '"  + r.Caliber + "' , '" + r.Barrel + "' , '" + r.Scope + "')", con);

            con.Open();
            cmd.ExecuteNonQuery();

            con.Close();
        }
    }
}
