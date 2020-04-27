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
    public partial class ProjectileForm : Form
    {
        SqlCommand cmd;
        SqlConnection con = new SqlConnection("Data Source=MITCHELLDESKTOP;Initial Catalog=CompSciProject;Integrated Security=True");
        public ProjectileForm()
        {
            InitializeComponent();
        }

        private void btnNewProjectile_Click(object sender, EventArgs e)
        {
            string PN = txtPN.Text;
            string brand = txtBrand.Text;
            string description = txtProjDescription.Text;
            string weight = txtWeight.Text;

            decimal diameter = 0;
            decimal bc_g1 = 0;
            decimal bc_g7 = 0;
            bool success = true;
            if(string.IsNullOrWhiteSpace(PN))
            {
                MessageBox.Show("Error: PN is empty");
                success = false;
            }
            if(string.IsNullOrWhiteSpace(brand))
            {
                MessageBox.Show("Error: brand is empty");
                success = false;
            }
            if(string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("Error: description is empty");
                success = false;
            }
            if(string.IsNullOrWhiteSpace(weight))
            {
                MessageBox.Show("Error: weight is empty");
                success = false; 
            }
            if (Decimal.TryParse(txtDiameter.Text, out diameter)) ;
            else
            {
                MessageBox.Show("Error: diameter is not correctly formatted. Must be a decimal");
                success = false;
            }

            if (Decimal.TryParse(txtBCG1.Text, out bc_g1)) ;
            else
            {
                MessageBox.Show("Error: BC_G1 is not correctly formatted. Must be a decimal");
                success = false;
            }

            if (Decimal.TryParse(txtBCG7.Text, out bc_g7) || string.IsNullOrEmpty(txtBCG7.Text)) ;
            else
            {
                MessageBox.Show("Error: BC_G7 is not correctly formatted. Must be a decimal");
                success = false; 
            }

            if (success)
            {
                Projectile proj = new Projectile(PN, brand, diameter, description, weight, bc_g1, bc_g7);
                Add_Projectile(proj);
                MessageBox.Show("New Projectile Added");
            }
        }

        private void Add_Projectile(Projectile p)
        {
            
            string insert;
            insert = "INSERT INTO dbo.Projectiles Values " +
                "('" + p.Pn + "' , '" + p.Brand + "' , " + p.Diameter + " , '" + p.Description + "' , '" + p.Weight + "' , " + p.BC_G1;
            if (p.BC_G7 == 0)
                insert += ", null)";
            else
                insert += " , " + p.BC_G7 + ")"; 

            cmd = new SqlCommand(insert, con);

            con.Open();
            cmd.ExecuteNonQuery();

            con.Close();
        }
    }
}
