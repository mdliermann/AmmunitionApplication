namespace AmmunitionProject
{
    partial class PowderForm
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
            this.txtPowderManufacturer = new System.Windows.Forms.TextBox();
            this.lblPowderManufacturer = new System.Windows.Forms.Label();
            this.btnNewPowder = new System.Windows.Forms.Button();
            this.dgvPowders = new System.Windows.Forms.DataGridView();
            this.btnDeletePowder = new System.Windows.Forms.Button();
            this.btnEditPowder = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPowders)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPowderManufacturer
            // 
            this.txtPowderManufacturer.Location = new System.Drawing.Point(85, 10);
            this.txtPowderManufacturer.Name = "txtPowderManufacturer";
            this.txtPowderManufacturer.Size = new System.Drawing.Size(244, 20);
            this.txtPowderManufacturer.TabIndex = 0;
            // 
            // lblPowderManufacturer
            // 
            this.lblPowderManufacturer.AutoSize = true;
            this.lblPowderManufacturer.Location = new System.Drawing.Point(9, 15);
            this.lblPowderManufacturer.Name = "lblPowderManufacturer";
            this.lblPowderManufacturer.Size = new System.Drawing.Size(70, 13);
            this.lblPowderManufacturer.TabIndex = 1;
            this.lblPowderManufacturer.Text = "Manufacturer";
            // 
            // btnNewPowder
            // 
            this.btnNewPowder.Location = new System.Drawing.Point(335, 10);
            this.btnNewPowder.Name = "btnNewPowder";
            this.btnNewPowder.Size = new System.Drawing.Size(75, 23);
            this.btnNewPowder.TabIndex = 1;
            this.btnNewPowder.Text = "Add";
            this.btnNewPowder.UseVisualStyleBackColor = true;
            this.btnNewPowder.Click += new System.EventHandler(this.btnNewPowder_Click);
            // 
            // dgvPowders
            // 
            this.dgvPowders.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPowders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPowders.Location = new System.Drawing.Point(12, 38);
            this.dgvPowders.Name = "dgvPowders";
            this.dgvPowders.Size = new System.Drawing.Size(317, 215);
            this.dgvPowders.TabIndex = 2;
            this.dgvPowders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPowders_CellClick);
            // 
            // btnDeletePowder
            // 
            this.btnDeletePowder.Location = new System.Drawing.Point(335, 68);
            this.btnDeletePowder.Name = "btnDeletePowder";
            this.btnDeletePowder.Size = new System.Drawing.Size(75, 23);
            this.btnDeletePowder.TabIndex = 3;
            this.btnDeletePowder.Text = "Delete";
            this.btnDeletePowder.UseVisualStyleBackColor = true;
            this.btnDeletePowder.Click += new System.EventHandler(this.btnDeletePowder_Click);
            // 
            // btnEditPowder
            // 
            this.btnEditPowder.Location = new System.Drawing.Point(335, 39);
            this.btnEditPowder.Name = "btnEditPowder";
            this.btnEditPowder.Size = new System.Drawing.Size(75, 23);
            this.btnEditPowder.TabIndex = 4;
            this.btnEditPowder.Text = "Edit";
            this.btnEditPowder.UseVisualStyleBackColor = true;
            this.btnEditPowder.Click += new System.EventHandler(this.btnEditPowder_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(335, 97);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(89, 156);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "To edit an entry, select it from the list, change the desired values in the textb" +
    "ox, and then click Edit. To remove an entry, select it from the list and click R" +
    "emove. ";
            // 
            // PowderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 261);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnEditPowder);
            this.Controls.Add(this.btnDeletePowder);
            this.Controls.Add(this.dgvPowders);
            this.Controls.Add(this.btnNewPowder);
            this.Controls.Add(this.lblPowderManufacturer);
            this.Controls.Add(this.txtPowderManufacturer);
            this.Name = "PowderForm";
            this.Text = "Modify Powders";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPowders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPowderManufacturer;
        private System.Windows.Forms.Label lblPowderManufacturer;
        private System.Windows.Forms.Button btnNewPowder;
        private System.Windows.Forms.DataGridView dgvPowders;
        private System.Windows.Forms.Button btnDeletePowder;
        private System.Windows.Forms.Button btnEditPowder;
        private System.Windows.Forms.TextBox textBox1;
    }
}