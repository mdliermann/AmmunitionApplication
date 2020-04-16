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

            if (string.IsNullOrWhiteSpace(makeModel))
                MessageBox.Show("Error: Make and Model is blank");
            else if (string.IsNullOrWhiteSpace(caliber))
                MessageBox.Show("Error: Caliber is blank");
            else if (string.IsNullOrWhiteSpace(barrel))
                MessageBox.Show("Error: Barrel is blank");
            else if (string.IsNullOrWhiteSpace(scope))
                MessageBox.Show("Error: Scope is blank");
            else
            {
                Rifle rf = new Rifle(makeModel, caliber, barrel, scope);
                Add_New_Rifle(rf);
                MessageBox.Show("New rifle added");
            }
        }

        private void Add_New_Rifle(Rifle rifle)
        {
            string cs;
            SqlCommand cmd;
            cs = "Data Source=MITCHELLDESKTOP;Initial Catalog=CompSciProject;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            cmd = new SqlCommand("INSERT INTO dbo.Rifles Values " +
                "('" + rifle.MakeModel + "' , '"  + rifle.Caliber + "' , '" + rifle.Barrel + "' , '" + rifle.Scope + "')", con);

            con.Open();
            cmd.ExecuteNonQuery();

            con.Close();
        }
    }
}
