namespace AmmunitionProject
{
    partial class CaseForm
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
            this.btnNewCase = new System.Windows.Forms.Button();
            this.lblCaseManufacturer = new System.Windows.Forms.Label();
            this.txtCaseManufacturer = new System.Windows.Forms.TextBox();
            this.dgvCases = new System.Windows.Forms.DataGridView();
            this.btnDeleteCase = new System.Windows.Forms.Button();
            this.btnEditCase = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCases)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewCase
            // 
            this.btnNewCase.Location = new System.Drawing.Point(335, 10);
            this.btnNewCase.Name = "btnNewCase";
            this.btnNewCase.Size = new System.Drawing.Size(75, 23);
            this.btnNewCase.TabIndex = 1;
            this.btnNewCase.Text = "Add";
            this.btnNewCase.UseVisualStyleBackColor = true;
            this.btnNewCase.Click += new System.EventHandler(this.btnNewCase_Click);
            // 
            // lblCaseManufacturer
            // 
            this.lblCaseManufacturer.AutoSize = true;
            this.lblCaseManufacturer.Location = new System.Drawing.Point(9, 15);
            this.lblCaseManufacturer.Name = "lblCaseManufacturer";
            this.lblCaseManufacturer.Size = new System.Drawing.Size(70, 13);
            this.lblCaseManufacturer.TabIndex = 1;
            this.lblCaseManufacturer.Text = "Manufacturer";
            // 
            // txtCaseManufacturer
            // 
            this.txtCaseManufacturer.Location = new System.Drawing.Point(85, 10);
            this.txtCaseManufacturer.Name = "txtCaseManufacturer";
            this.txtCaseManufacturer.Size = new System.Drawing.Size(244, 20);
            this.txtCaseManufacturer.TabIndex = 0;
            // 
            // dgvCases
            // 
            this.dgvCases.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvCases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCases.Location = new System.Drawing.Point(12, 38);
            this.dgvCases.MultiSelect = false;
            this.dgvCases.Name = "dgvCases";
            this.dgvCases.ReadOnly = true;
            this.dgvCases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCases.Size = new System.Drawing.Size(317, 215);
            this.dgvCases.TabIndex = 2;
            this.dgvCases.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCases_CellClick);
            // 
            // btnDeleteCase
            // 
            this.btnDeleteCase.Location = new System.Drawing.Point(335, 68);
            this.btnDeleteCase.Name = "btnDeleteCase";
            this.btnDeleteCase.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCase.TabIndex = 3;
            this.btnDeleteCase.Text = "Delete";
            this.btnDeleteCase.UseVisualStyleBackColor = true;
            this.btnDeleteCase.Click += new System.EventHandler(this.btnDeleteCase_Click);
            // 
            // btnEditCase
            // 
            this.btnEditCase.Location = new System.Drawing.Point(335, 39);
            this.btnEditCase.Name = "btnEditCase";
            this.btnEditCase.Size = new System.Drawing.Size(75, 23);
            this.btnEditCase.TabIndex = 4;
            this.btnEditCase.Text = "Edit";
            this.btnEditCase.UseVisualStyleBackColor = true;
            this.btnEditCase.Click += new System.EventHandler(this.btnEditCase_Click);
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
            // CaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 261);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnEditCase);
            this.Controls.Add(this.btnDeleteCase);
            this.Controls.Add(this.dgvCases);
            this.Controls.Add(this.txtCaseManufacturer);
            this.Controls.Add(this.lblCaseManufacturer);
            this.Controls.Add(this.btnNewCase);
            this.Name = "CaseForm";
            this.Text = "Modify Cases";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCases)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewCase;
        private System.Windows.Forms.Label lblCaseManufacturer;
        private System.Windows.Forms.TextBox txtCaseManufacturer;
        private System.Windows.Forms.DataGridView dgvCases;
        private System.Windows.Forms.Button btnDeleteCase;
        private System.Windows.Forms.Button btnEditCase;
        private System.Windows.Forms.TextBox textBox1;
    }
}