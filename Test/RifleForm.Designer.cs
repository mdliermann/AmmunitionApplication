namespace AmmunitionProject
{
    partial class RifleForm
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
            this.lblMakeModel = new System.Windows.Forms.Label();
            this.lblCaliber = new System.Windows.Forms.Label();
            this.lblBarrel = new System.Windows.Forms.Label();
            this.lblScope = new System.Windows.Forms.Label();
            this.txtScope = new System.Windows.Forms.TextBox();
            this.txtBarrel = new System.Windows.Forms.TextBox();
            this.txtCaliber = new System.Windows.Forms.TextBox();
            this.txtMakeAndModel = new System.Windows.Forms.TextBox();
            this.btnNewRifle = new System.Windows.Forms.Button();
            this.btnDeleteRifles = new System.Windows.Forms.Button();
            this.btnEditRifles = new System.Windows.Forms.Button();
            this.dgvRifles = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRifles)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMakeModel
            // 
            this.lblMakeModel.AutoSize = true;
            this.lblMakeModel.Location = new System.Drawing.Point(9, 15);
            this.lblMakeModel.Name = "lblMakeModel";
            this.lblMakeModel.Size = new System.Drawing.Size(87, 13);
            this.lblMakeModel.TabIndex = 0;
            this.lblMakeModel.Text = "Make and Model";
            // 
            // lblCaliber
            // 
            this.lblCaliber.AutoSize = true;
            this.lblCaliber.Location = new System.Drawing.Point(9, 44);
            this.lblCaliber.Name = "lblCaliber";
            this.lblCaliber.Size = new System.Drawing.Size(39, 13);
            this.lblCaliber.TabIndex = 1;
            this.lblCaliber.Text = "Caliber";
            // 
            // lblBarrel
            // 
            this.lblBarrel.AutoSize = true;
            this.lblBarrel.Location = new System.Drawing.Point(9, 73);
            this.lblBarrel.Name = "lblBarrel";
            this.lblBarrel.Size = new System.Drawing.Size(34, 13);
            this.lblBarrel.TabIndex = 2;
            this.lblBarrel.Text = "Barrel";
            // 
            // lblScope
            // 
            this.lblScope.AutoSize = true;
            this.lblScope.Location = new System.Drawing.Point(9, 99);
            this.lblScope.Name = "lblScope";
            this.lblScope.Size = new System.Drawing.Size(38, 13);
            this.lblScope.TabIndex = 3;
            this.lblScope.Text = "Scope";
            // 
            // txtScope
            // 
            this.txtScope.Location = new System.Drawing.Point(54, 99);
            this.txtScope.Name = "txtScope";
            this.txtScope.Size = new System.Drawing.Size(418, 20);
            this.txtScope.TabIndex = 3;
            // 
            // txtBarrel
            // 
            this.txtBarrel.Location = new System.Drawing.Point(54, 70);
            this.txtBarrel.Name = "txtBarrel";
            this.txtBarrel.Size = new System.Drawing.Size(418, 20);
            this.txtBarrel.TabIndex = 2;
            // 
            // txtCaliber
            // 
            this.txtCaliber.Location = new System.Drawing.Point(54, 41);
            this.txtCaliber.Name = "txtCaliber";
            this.txtCaliber.Size = new System.Drawing.Size(418, 20);
            this.txtCaliber.TabIndex = 1;
            // 
            // txtMakeAndModel
            // 
            this.txtMakeAndModel.Location = new System.Drawing.Point(102, 12);
            this.txtMakeAndModel.Name = "txtMakeAndModel";
            this.txtMakeAndModel.Size = new System.Drawing.Size(370, 20);
            this.txtMakeAndModel.TabIndex = 0;
            // 
            // btnNewRifle
            // 
            this.btnNewRifle.Location = new System.Drawing.Point(478, 10);
            this.btnNewRifle.Name = "btnNewRifle";
            this.btnNewRifle.Size = new System.Drawing.Size(89, 23);
            this.btnNewRifle.TabIndex = 4;
            this.btnNewRifle.Text = "Add";
            this.btnNewRifle.UseVisualStyleBackColor = true;
            this.btnNewRifle.Click += new System.EventHandler(this.btnNewRifle_Click);
            // 
            // btnDeleteRifles
            // 
            this.btnDeleteRifles.Location = new System.Drawing.Point(478, 68);
            this.btnDeleteRifles.Name = "btnDeleteRifles";
            this.btnDeleteRifles.Size = new System.Drawing.Size(88, 23);
            this.btnDeleteRifles.TabIndex = 5;
            this.btnDeleteRifles.Text = "Delete";
            this.btnDeleteRifles.UseVisualStyleBackColor = true;
            this.btnDeleteRifles.Click += new System.EventHandler(this.btnDeleteRifles_Click);
            // 
            // btnEditRifles
            // 
            this.btnEditRifles.Location = new System.Drawing.Point(478, 39);
            this.btnEditRifles.Name = "btnEditRifles";
            this.btnEditRifles.Size = new System.Drawing.Size(89, 23);
            this.btnEditRifles.TabIndex = 6;
            this.btnEditRifles.Text = "Edit";
            this.btnEditRifles.UseVisualStyleBackColor = true;
            this.btnEditRifles.Click += new System.EventHandler(this.btnEditRifles_Click);
            // 
            // dgvRifles
            // 
            this.dgvRifles.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvRifles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRifles.Location = new System.Drawing.Point(12, 125);
            this.dgvRifles.Name = "dgvRifles";
            this.dgvRifles.Size = new System.Drawing.Size(460, 215);
            this.dgvRifles.TabIndex = 7;
            this.dgvRifles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRifles_CellClick);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(478, 97);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(89, 243);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "To edit an entry, select it from the list, change the desired values in the textb" +
    "ox, and then click Edit. To remove an entry, select it from the list and click R" +
    "emove. ";
            // 
            // RifleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 347);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgvRifles);
            this.Controls.Add(this.btnEditRifles);
            this.Controls.Add(this.btnDeleteRifles);
            this.Controls.Add(this.btnNewRifle);
            this.Controls.Add(this.txtMakeAndModel);
            this.Controls.Add(this.txtCaliber);
            this.Controls.Add(this.txtBarrel);
            this.Controls.Add(this.txtScope);
            this.Controls.Add(this.lblScope);
            this.Controls.Add(this.lblBarrel);
            this.Controls.Add(this.lblCaliber);
            this.Controls.Add(this.lblMakeModel);
            this.Name = "RifleForm";
            this.Text = "Modify Rifles";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRifles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMakeModel;
        private System.Windows.Forms.Label lblCaliber;
        private System.Windows.Forms.Label lblBarrel;
        private System.Windows.Forms.Label lblScope;
        private System.Windows.Forms.TextBox txtScope;
        private System.Windows.Forms.TextBox txtBarrel;
        private System.Windows.Forms.TextBox txtCaliber;
        private System.Windows.Forms.TextBox txtMakeAndModel;
        private System.Windows.Forms.Button btnNewRifle;
        private System.Windows.Forms.Button btnDeleteRifles;
        private System.Windows.Forms.Button btnEditRifles;
        private System.Windows.Forms.DataGridView dgvRifles;
        private System.Windows.Forms.TextBox textBox1;
    }
}