using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void Addform_Load(object sender, EventArgs e)
        {

        }

        private void btnAddCase_Click(object sender, EventArgs e)
        {
            Form cs = new CaseForm();
            cs.Show(); 
        }

        private void btnAddPowder_Click(object sender, EventArgs e)
        {
            Form pof = new PowderForm();
            pof.Show();
        }

        private void btnAddPrimer_Click(object sender, EventArgs e)
        {
            Form prf = new PrimerForm();
            prf.Show();
        }

        private void btnAddRifle_Click(object sender, EventArgs e)
        {
            Form rf = new RifleForm();
            rf.Show(); 
        }

        private void btnAddProjectile_Click(object sender, EventArgs e)
        {
            Form projf = new ProjectileForm();
            projf.Show();
        }

        private void btnAddSession_Click(object sender, EventArgs e)
        {
            
        }
    }
}
