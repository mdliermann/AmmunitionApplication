namespace AmmunitionProject
{
    partial class PrimerForm
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
            this.btnNewPrimer = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.dgvPrimers = new System.Windows.Forms.DataGridView();
            this.btnEditPrimers = new System.Windows.Forms.Button();
            this.btnDeletePrimers = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrimers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewPrimer
            // 
            this.btnNewPrimer.Location = new System.Drawing.Point(335, 10);
            this.btnNewPrimer.Name = "btnNewPrimer";
            this.btnNewPrimer.Size = new System.Drawing.Size(89, 23);
            this.btnNewPrimer.TabIndex = 1;
            this.btnNewPrimer.Text = "Add";
            this.btnNewPrimer.UseVisualStyleBackColor = true;
            this.btnNewPrimer.Click += new System.EventHandler(this.btnNewPrimer_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(9, 15);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(75, 12);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(254, 20);
            this.txtDescription.TabIndex = 0;
            // 
            // dgvPrimers
            // 
            this.dgvPrimers.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPrimers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrimers.Location = new System.Drawing.Point(12, 38);
            this.dgvPrimers.Name = "dgvPrimers";
            this.dgvPrimers.Size = new System.Drawing.Size(317, 215);
            this.dgvPrimers.TabIndex = 2;
            this.dgvPrimers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrimers_CellClick);
            // 
            // btnEditPrimers
            // 
            this.btnEditPrimers.Location = new System.Drawing.Point(335, 39);
            this.btnEditPrimers.Name = "btnEditPrimers";
            this.btnEditPrimers.Size = new System.Drawing.Size(89, 23);
            this.btnEditPrimers.TabIndex = 3;
            this.btnEditPrimers.Text = "Edit";
            this.btnEditPrimers.UseVisualStyleBackColor = true;
            this.btnEditPrimers.Click += new System.EventHandler(this.btnEditPrimers_Click);
            // 
            // btnDeletePrimers
            // 
            this.btnDeletePrimers.Location = new System.Drawing.Point(335, 68);
            this.btnDeletePrimers.Name = "btnDeletePrimers";
            this.btnDeletePrimers.Size = new System.Drawing.Size(89, 23);
            this.btnDeletePrimers.TabIndex = 4;
            this.btnDeletePrimers.Text = "Delete";
            this.btnDeletePrimers.UseVisualStyleBackColor = true;
            this.btnDeletePrimers.Click += new System.EventHandler(this.btnDeletePrimers_Click);
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
            // PrimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 261);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnDeletePrimers);
            this.Controls.Add(this.btnEditPrimers);
            this.Controls.Add(this.dgvPrimers);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnNewPrimer);
            this.Name = "PrimerForm";
            this.Text = "Modify Primers";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrimers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewPrimer;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DataGridView dgvPrimers;
        private System.Windows.Forms.Button btnEditPrimers;
        private System.Windows.Forms.Button btnDeletePrimers;
        private System.Windows.Forms.TextBox textBox1;
    }
}