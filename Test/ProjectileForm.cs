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
            else if(string.IsNullOrWhiteSpace(brand))
            {
                MessageBox.Show("Error: brand is empty");
                success = false;
            }
            else if(string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("Error: description is empty");
                success = false;
            }
            else if(string.IsNullOrWhiteSpace(weight))
            {
                MessageBox.Show("Error: weight is empty");
                success = false; 
            }
            else if (!Decimal.TryParse(txtDiameter.Text, out diameter)) 
            {
                MessageBox.Show("Error: diameter is not correctly formatted. Must be a decimal");
                success = false;
            }
            else if (!Decimal.TryParse(txtBCG1.Text, out bc_g1)) 
            {
                MessageBox.Show("Error: BC_G1 is not correctly formatted. Must be a decimal");
                success = false;
            }
            else if (!Decimal.TryParse(txtBCG7.Text, out bc_g7) || string.IsNullOrEmpty(txtBCG7.Text)) 
            {
                MessageBox.Show("Error: BC_G7 is not correctly formatted. Must be a decimal");
                success = false; 
            }

            if (success)
            {
  
            }
        }

    }
}
