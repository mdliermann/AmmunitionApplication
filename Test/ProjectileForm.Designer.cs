namespace AmmunitionProject
{
    partial class ProjectileForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNewProjectile = new System.Windows.Forms.Button();
            this.lblPN = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblDiameter = new System.Windows.Forms.Label();
            this.lblProjDescription = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblBCG1 = new System.Windows.Forms.Label();
            this.lblBCG7 = new System.Windows.Forms.Label();
            this.txtBCG7 = new System.Windows.Forms.TextBox();
            this.txtBCG1 = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtProjDescription = new System.Windows.Forms.TextBox();
            this.txtDiameter = new System.Windows.Forms.TextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtPN = new System.Windows.Forms.TextBox();
            this.dgvProjectiles = new System.Windows.Forms.DataGridView();
            this.btnEditProj = new System.Windows.Forms.Button();
            this.btnDeleteProj = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectiles)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewProjectile
            // 
            this.btnNewProjectile.Location = new System.Drawing.Point(478, 10);
            this.btnNewProjectile.Name = "btnNewProjectile";
            this.btnNewProjectile.Size = new System.Drawing.Size(88, 23);
            this.btnNewProjectile.TabIndex = 7;
            this.btnNewProjectile.Text = "Add";
            this.btnNewProjectile.UseVisualStyleBackColor = true;
            this.btnNewProjectile.Click += new System.EventHandler(this.btnNewProjectile_Click);
            // 
            // lblPN
            // 
            this.lblPN.AutoSize = true;
            this.lblPN.Location = new System.Drawing.Point(9, 15);
            this.lblPN.Name = "lblPN";
            this.lblPN.Size = new System.Drawing.Size(22, 13);
            this.lblPN.TabIndex = 1;
            this.lblPN.Text = "PN";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(9, 44);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(35, 13);
            this.lblBrand.TabIndex = 2;
            this.lblBrand.Text = "Brand";
            // 
            // lblDiameter
            // 
            this.lblDiameter.AutoSize = true;
            this.lblDiameter.Location = new System.Drawing.Point(9, 73);
            this.lblDiameter.Name = "lblDiameter";
            this.lblDiameter.Size = new System.Drawing.Size(49, 13);
            this.lblDiameter.TabIndex = 3;
            this.lblDiameter.Text = "Diameter";
            // 
            // lblProjDescription
            // 
            this.lblProjDescription.AutoSize = true;
            this.lblProjDescription.Location = new System.Drawing.Point(9, 100);
            this.lblProjDescription.Name = "lblProjDescription";
            this.lblProjDescription.Size = new System.Drawing.Size(60, 13);
            this.lblProjDescription.TabIndex = 4;
            this.lblProjDescription.Text = "Description";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(9, 126);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(41, 13);
            this.lblWeight.TabIndex = 5;
            this.lblWeight.Text = "Weight";
            // 
            // lblBCG1
            // 
            this.lblBCG1.AutoSize = true;
            this.lblBCG1.Location = new System.Drawing.Point(9, 152);
            this.lblBCG1.Name = "lblBCG1";
            this.lblBCG1.Size = new System.Drawing.Size(41, 13);
            this.lblBCG1.TabIndex = 6;
            this.lblBCG1.Text = "BC_G1";
            // 
            // lblBCG7
            // 
            this.lblBCG7.AutoSize = true;
            this.lblBCG7.Location = new System.Drawing.Point(9, 178);
            this.lblBCG7.Name = "lblBCG7";
            this.lblBCG7.Size = new System.Drawing.Size(87, 13);
            this.lblBCG7.TabIndex = 7;
            this.lblBCG7.Text = "BC_G7 (optional)";
            // 
            // txtBCG7
            // 
            this.txtBCG7.Location = new System.Drawing.Point(105, 175);
            this.txtBCG7.Name = "txtBCG7";
            this.txtBCG7.Size = new System.Drawing.Size(367, 20);
            this.txtBCG7.TabIndex = 6;
            // 
            // txtBCG1
            // 
            this.txtBCG1.Location = new System.Drawing.Point(78, 149);
            this.txtBCG1.Name = "txtBCG1";
            this.txtBCG1.Size = new System.Drawing.Size(394, 20);
            this.txtBCG1.TabIndex = 5;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(78, 123);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(394, 20);
            this.txtWeight.TabIndex = 4;
            // 
            // txtProjDescription
            // 
            this.txtProjDescription.Location = new System.Drawing.Point(78, 97);
            this.txtProjDescription.Name = "txtProjDescription";
            this.txtProjDescription.Size = new System.Drawing.Size(394, 20);
            this.txtProjDescription.TabIndex = 3;
            // 
            // txtDiameter
            // 
            this.txtDiameter.Location = new System.Drawing.Point(78, 70);
            this.txtDiameter.Name = "txtDiameter";
            this.txtDiameter.Size = new System.Drawing.Size(394, 20);
            this.txtDiameter.TabIndex = 2;
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(78, 41);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(394, 20);
            this.txtBrand.TabIndex = 1;
            // 
            // txtPN
            // 
            this.txtPN.Location = new System.Drawing.Point(78, 12);
            this.txtPN.Name = "txtPN";
            this.txtPN.Size = new System.Drawing.Size(394, 20);
            this.txtPN.TabIndex = 0;
            // 
            // dgvProjectiles
            // 
            this.dgvProjectiles.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvProjectiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjectiles.Location = new System.Drawing.Point(12, 201);
            this.dgvProjectiles.Name = "dgvProjectiles";
            this.dgvProjectiles.Size = new System.Drawing.Size(460, 215);
            this.dgvProjectiles.TabIndex = 8;
            this.dgvProjectiles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProjectiles_CellClick);
            // 
            // btnEditProj
            // 
            this.btnEditProj.Location = new System.Drawing.Point(478, 39);
            this.btnEditProj.Name = "btnEditProj";
            this.btnEditProj.Size = new System.Drawing.Size(88, 23);
            this.btnEditProj.TabIndex = 9;
            this.btnEditProj.Text = "Edit";
            this.btnEditProj.UseVisualStyleBackColor = true;
            this.btnEditProj.Click += new System.EventHandler(this.btnEditProj_Click);
            // 
            // btnDeleteProj
            // 
            this.btnDeleteProj.Location = new System.Drawing.Point(478, 68);
            this.btnDeleteProj.Name = "btnDeleteProj";
            this.btnDeleteProj.Size = new System.Drawing.Size(88, 23);
            this.btnDeleteProj.TabIndex = 10;
            this.btnDeleteProj.Text = "Delete";
            this.btnDeleteProj.UseVisualStyleBackColor = true;
            this.btnDeleteProj.Click += new System.EventHandler(this.btnDeleteProj_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(478, 97);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(89, 319);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "To edit an entry, select it from the list, change the desired values in the textb" +
    "ox, and then click Edit. To remove an entry, select it from the list and click R" +
    "emove. ";
            // 
            // ProjectileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 420);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnDeleteProj);
            this.Controls.Add(this.btnEditProj);
            this.Controls.Add(this.dgvProjectiles);
            this.Controls.Add(this.txtPN);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.txtDiameter);
            this.Controls.Add(this.txtProjDescription);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtBCG1);
            this.Controls.Add(this.txtBCG7);
            this.Controls.Add(this.lblBCG7);
            this.Controls.Add(this.lblBCG1);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblProjDescription);
            this.Controls.Add(this.lblDiameter);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblPN);
            this.Controls.Add(this.btnNewProjectile);
            this.Name = "ProjectileForm";
            this.Text = "Modify Projectiles";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewProjectile;
        private System.Windows.Forms.Label lblPN;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblDiameter;
        private System.Windows.Forms.Label lblProjDescription;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblBCG1;
        private System.Windows.Forms.Label lblBCG7;
        private System.Windows.Forms.TextBox txtBCG7;
        private System.Windows.Forms.TextBox txtBCG1;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtProjDescription;
        private System.Windows.Forms.TextBox txtDiameter;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtPN;
        private System.Windows.Forms.DataGridView dgvProjectiles;
        private System.Windows.Forms.Button btnEditProj;
        private System.Windows.Forms.Button btnDeleteProj;
        private System.Windows.Forms.TextBox textBox1;
    }
}