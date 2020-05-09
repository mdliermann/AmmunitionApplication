namespace AmmunitionProject
{
    partial class SeriesForm
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
            this.dgvSeries = new System.Windows.Forms.DataGridView();
            this.btnNewShot = new System.Windows.Forms.Button();
            this.btnRemoveSeries = new System.Windows.Forms.Button();
            this.btnEditSeries = new System.Windows.Forms.Button();
            this.btnNewSeries = new System.Windows.Forms.Button();
            this.dgvShots = new System.Windows.Forms.DataGridView();
            this.btnRemoveShot = new System.Windows.Forms.Button();
            this.btnEditShot = new System.Windows.Forms.Button();
            this.cmbPowders = new System.Windows.Forms.ComboBox();
            this.cmbPrimers = new System.Windows.Forms.ComboBox();
            this.cmbCases = new System.Windows.Forms.ComboBox();
            this.cmbProjectiles = new System.Windows.Forms.ComboBox();
            this.cmbSessions = new System.Windows.Forms.ComboBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtPowderAmount = new System.Windows.Forms.TextBox();
            this.txtCBTO = new System.Windows.Forms.TextBox();
            this.txtCOAL = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.cmbSeries = new System.Windows.Forms.ComboBox();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShots)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSeries
            // 
            this.dgvSeries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeries.Location = new System.Drawing.Point(12, 248);
            this.dgvSeries.Name = "dgvSeries";
            this.dgvSeries.Size = new System.Drawing.Size(823, 187);
            this.dgvSeries.TabIndex = 0;
            this.dgvSeries.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSeries_CellClick);
            // 
            // btnNewShot
            // 
            this.btnNewShot.Location = new System.Drawing.Point(471, 91);
            this.btnNewShot.Name = "btnNewShot";
            this.btnNewShot.Size = new System.Drawing.Size(75, 23);
            this.btnNewShot.TabIndex = 3;
            this.btnNewShot.Text = "Add";
            this.btnNewShot.UseVisualStyleBackColor = true;
            this.btnNewShot.Click += new System.EventHandler(this.btnNewShot_Click);
            // 
            // btnRemoveSeries
            // 
            this.btnRemoveSeries.Location = new System.Drawing.Point(174, 217);
            this.btnRemoveSeries.Name = "btnRemoveSeries";
            this.btnRemoveSeries.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveSeries.TabIndex = 4;
            this.btnRemoveSeries.Text = "Remove";
            this.btnRemoveSeries.UseVisualStyleBackColor = true;
            this.btnRemoveSeries.Click += new System.EventHandler(this.btnRemoveSeries_Click);
            // 
            // btnEditSeries
            // 
            this.btnEditSeries.Location = new System.Drawing.Point(93, 217);
            this.btnEditSeries.Name = "btnEditSeries";
            this.btnEditSeries.Size = new System.Drawing.Size(75, 23);
            this.btnEditSeries.TabIndex = 5;
            this.btnEditSeries.Text = "Edit";
            this.btnEditSeries.UseVisualStyleBackColor = true;
            this.btnEditSeries.Click += new System.EventHandler(this.btnEditSeries_Click);
            // 
            // btnNewSeries
            // 
            this.btnNewSeries.Location = new System.Drawing.Point(12, 217);
            this.btnNewSeries.Name = "btnNewSeries";
            this.btnNewSeries.Size = new System.Drawing.Size(75, 23);
            this.btnNewSeries.TabIndex = 6;
            this.btnNewSeries.Text = "Add";
            this.btnNewSeries.UseVisualStyleBackColor = true;
            this.btnNewSeries.Click += new System.EventHandler(this.btnNewSeries_Click);
            // 
            // dgvShots
            // 
            this.dgvShots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShots.Location = new System.Drawing.Point(598, 12);
            this.dgvShots.Name = "dgvShots";
            this.dgvShots.Size = new System.Drawing.Size(237, 160);
            this.dgvShots.TabIndex = 7;
            this.dgvShots.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShots_CellClick);
            // 
            // btnRemoveShot
            // 
            this.btnRemoveShot.Location = new System.Drawing.Point(471, 149);
            this.btnRemoveShot.Name = "btnRemoveShot";
            this.btnRemoveShot.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveShot.TabIndex = 8;
            this.btnRemoveShot.Text = "Remove";
            this.btnRemoveShot.UseVisualStyleBackColor = true;
            this.btnRemoveShot.Click += new System.EventHandler(this.btnRemoveShot_Click);
            // 
            // btnEditShot
            // 
            this.btnEditShot.Location = new System.Drawing.Point(471, 120);
            this.btnEditShot.Name = "btnEditShot";
            this.btnEditShot.Size = new System.Drawing.Size(75, 23);
            this.btnEditShot.TabIndex = 9;
            this.btnEditShot.Text = "Edit";
            this.btnEditShot.UseVisualStyleBackColor = true;
            this.btnEditShot.Click += new System.EventHandler(this.btnEditShot_Click);
            // 
            // cmbPowders
            // 
            this.cmbPowders.FormattingEnabled = true;
            this.cmbPowders.Location = new System.Drawing.Point(73, 138);
            this.cmbPowders.Name = "cmbPowders";
            this.cmbPowders.Size = new System.Drawing.Size(142, 21);
            this.cmbPowders.TabIndex = 10;
            this.cmbPowders.Text = "Powders";
            // 
            // cmbPrimers
            // 
            this.cmbPrimers.FormattingEnabled = true;
            this.cmbPrimers.Location = new System.Drawing.Point(73, 111);
            this.cmbPrimers.Name = "cmbPrimers";
            this.cmbPrimers.Size = new System.Drawing.Size(324, 21);
            this.cmbPrimers.TabIndex = 11;
            this.cmbPrimers.Text = "Primers";
            // 
            // cmbCases
            // 
            this.cmbCases.FormattingEnabled = true;
            this.cmbCases.Location = new System.Drawing.Point(73, 84);
            this.cmbCases.Name = "cmbCases";
            this.cmbCases.Size = new System.Drawing.Size(324, 21);
            this.cmbCases.TabIndex = 12;
            this.cmbCases.Text = "Cases";
            // 
            // cmbProjectiles
            // 
            this.cmbProjectiles.FormattingEnabled = true;
            this.cmbProjectiles.Location = new System.Drawing.Point(73, 57);
            this.cmbProjectiles.Name = "cmbProjectiles";
            this.cmbProjectiles.Size = new System.Drawing.Size(325, 21);
            this.cmbProjectiles.TabIndex = 13;
            this.cmbProjectiles.Text = "Projectiles";
            // 
            // cmbSessions
            // 
            this.cmbSessions.FormattingEnabled = true;
            this.cmbSessions.Location = new System.Drawing.Point(54, 10);
            this.cmbSessions.Name = "cmbSessions";
            this.cmbSessions.Size = new System.Drawing.Size(237, 21);
            this.cmbSessions.TabIndex = 14;
            this.cmbSessions.SelectionChangeCommitted += new System.EventHandler(this.cmbSessions_SelectionChangeCommitted);
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(88, 191);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(115, 20);
            this.txtHeight.TabIndex = 15;
            // 
            // txtPowderAmount
            // 
            this.txtPowderAmount.Location = new System.Drawing.Point(309, 138);
            this.txtPowderAmount.Name = "txtPowderAmount";
            this.txtPowderAmount.Size = new System.Drawing.Size(89, 20);
            this.txtPowderAmount.TabIndex = 16;
            // 
            // txtCBTO
            // 
            this.txtCBTO.Location = new System.Drawing.Point(281, 164);
            this.txtCBTO.Name = "txtCBTO";
            this.txtCBTO.Size = new System.Drawing.Size(116, 20);
            this.txtCBTO.TabIndex = 17;
            // 
            // txtCOAL
            // 
            this.txtCOAL.Location = new System.Drawing.Point(73, 165);
            this.txtCOAL.Name = "txtCOAL";
            this.txtCOAL.Size = new System.Drawing.Size(130, 20);
            this.txtCOAL.TabIndex = 18;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(282, 191);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(115, 20);
            this.txtWidth.TabIndex = 19;
            // 
            // cmbSeries
            // 
            this.cmbSeries.FormattingEnabled = true;
            this.cmbSeries.Location = new System.Drawing.Point(471, 25);
            this.cmbSeries.Name = "cmbSeries";
            this.cmbSeries.Size = new System.Drawing.Size(121, 21);
            this.cmbSeries.TabIndex = 20;
            this.cmbSeries.SelectionChangeCommitted += new System.EventHandler(this.cmbSeries_SelectionChangeCommitted);
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(471, 65);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(121, 20);
            this.txtSpeed.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "COAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Group Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "CBTO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Powder Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(468, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Shot Speed";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(209, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Group Width";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Projectiles";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Cases";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Primers";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Powders";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(468, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Series";
            // 
            // SeriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 447);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.cmbSeries);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtCOAL);
            this.Controls.Add(this.txtCBTO);
            this.Controls.Add(this.txtPowderAmount);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.cmbSessions);
            this.Controls.Add(this.cmbProjectiles);
            this.Controls.Add(this.cmbCases);
            this.Controls.Add(this.cmbPrimers);
            this.Controls.Add(this.cmbPowders);
            this.Controls.Add(this.btnEditShot);
            this.Controls.Add(this.btnRemoveShot);
            this.Controls.Add(this.dgvShots);
            this.Controls.Add(this.btnNewSeries);
            this.Controls.Add(this.btnEditSeries);
            this.Controls.Add(this.btnRemoveSeries);
            this.Controls.Add(this.btnNewShot);
            this.Controls.Add(this.dgvSeries);
            this.Name = "SeriesForm";
            this.Text = "Modify Series";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShots)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSeries;
        private System.Windows.Forms.Button btnNewShot;
        private System.Windows.Forms.Button btnRemoveSeries;
        private System.Windows.Forms.Button btnEditSeries;
        private System.Windows.Forms.Button btnNewSeries;
        private System.Windows.Forms.DataGridView dgvShots;
        private System.Windows.Forms.Button btnRemoveShot;
        private System.Windows.Forms.Button btnEditShot;
        private System.Windows.Forms.ComboBox cmbPowders;
        private System.Windows.Forms.ComboBox cmbPrimers;
        private System.Windows.Forms.ComboBox cmbCases;
        private System.Windows.Forms.ComboBox cmbProjectiles;
        private System.Windows.Forms.ComboBox cmbSessions;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtPowderAmount;
        private System.Windows.Forms.TextBox txtCBTO;
        private System.Windows.Forms.TextBox txtCOAL;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.ComboBox cmbSeries;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}