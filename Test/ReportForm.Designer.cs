namespace AmmunitionProject
{
    partial class ReportForm
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
            this.SessionsList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSessions = new System.Windows.Forms.DataGridView();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.SeriesNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvgSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StdDev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExtremeSpread = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CBTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupAvg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Case = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Primer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Powder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PowderAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BCG1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BCG7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessions)).BeginInit();
            this.SuspendLayout();
            // 
            // SessionsList
            // 
            this.SessionsList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SessionsList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.SessionsList.FormattingEnabled = true;
            this.SessionsList.Location = new System.Drawing.Point(265, 37);
            this.SessionsList.Name = "SessionsList";
            this.SessionsList.Size = new System.Drawing.Size(269, 21);
            this.SessionsList.TabIndex = 0;
            this.SessionsList.SelectedIndexChanged += new System.EventHandler(this.SessionsList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select a Benchrest Session";
            // 
            // dgvSessions
            // 
            this.dgvSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSessions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SeriesNumber,
            this.MinSpeed,
            this.MaxSpeed,
            this.AvgSpeed,
            this.StdDev,
            this.ExtremeSpread,
            this.COAL,
            this.CBTO,
            this.GroupHeight,
            this.GroupWidth,
            this.GroupAvg,
            this.Case,
            this.Primer,
            this.Powder,
            this.PowderAmount,
            this.PN,
            this.ProjBrand,
            this.ProjDesc,
            this.ProjWeight,
            this.BCG1,
            this.BCG7});
            this.dgvSessions.Location = new System.Drawing.Point(12, 64);
            this.dgvSessions.Name = "dgvSessions";
            this.dgvSessions.Size = new System.Drawing.Size(808, 333);
            this.dgvSessions.TabIndex = 2;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(540, 35);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // SeriesNumber
            // 
            this.SeriesNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SeriesNumber.HeaderText = "Series #";
            this.SeriesNumber.Name = "SeriesNumber";
            this.SeriesNumber.Width = 71;
            // 
            // MinSpeed
            // 
            this.MinSpeed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MinSpeed.HeaderText = "Min Speed";
            this.MinSpeed.Name = "MinSpeed";
            this.MinSpeed.Width = 83;
            // 
            // MaxSpeed
            // 
            this.MaxSpeed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaxSpeed.HeaderText = "Max Speed";
            this.MaxSpeed.Name = "MaxSpeed";
            this.MaxSpeed.Width = 86;
            // 
            // AvgSpeed
            // 
            this.AvgSpeed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AvgSpeed.HeaderText = "Avg Speed";
            this.AvgSpeed.Name = "AvgSpeed";
            this.AvgSpeed.Width = 85;
            // 
            // StdDev
            // 
            this.StdDev.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.StdDev.HeaderText = "S-D";
            this.StdDev.Name = "StdDev";
            this.StdDev.Width = 50;
            // 
            // ExtremeSpread
            // 
            this.ExtremeSpread.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ExtremeSpread.HeaderText = "ES";
            this.ExtremeSpread.Name = "ExtremeSpread";
            this.ExtremeSpread.Width = 46;
            // 
            // COAL
            // 
            this.COAL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.COAL.HeaderText = "COAL";
            this.COAL.Name = "COAL";
            this.COAL.Width = 60;
            // 
            // CBTO
            // 
            this.CBTO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CBTO.HeaderText = "CBTO";
            this.CBTO.Name = "CBTO";
            this.CBTO.Width = 61;
            // 
            // GroupHeight
            // 
            this.GroupHeight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.GroupHeight.HeaderText = "Group Height";
            this.GroupHeight.Name = "GroupHeight";
            this.GroupHeight.Width = 95;
            // 
            // GroupWidth
            // 
            this.GroupWidth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.GroupWidth.HeaderText = "Group Width";
            this.GroupWidth.Name = "GroupWidth";
            this.GroupWidth.Width = 92;
            // 
            // GroupAvg
            // 
            this.GroupAvg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.GroupAvg.HeaderText = "Group Avg";
            this.GroupAvg.Name = "GroupAvg";
            this.GroupAvg.Width = 83;
            // 
            // Case
            // 
            this.Case.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Case.HeaderText = "Case";
            this.Case.Name = "Case";
            this.Case.Width = 56;
            // 
            // Primer
            // 
            this.Primer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Primer.HeaderText = "Primer";
            this.Primer.Name = "Primer";
            this.Primer.Width = 61;
            // 
            // Powder
            // 
            this.Powder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Powder.HeaderText = "Powder";
            this.Powder.Name = "Powder";
            this.Powder.Width = 68;
            // 
            // PowderAmount
            // 
            this.PowderAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PowderAmount.HeaderText = "Amount";
            this.PowderAmount.Name = "PowderAmount";
            this.PowderAmount.Width = 68;
            // 
            // PN
            // 
            this.PN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PN.HeaderText = "P/N";
            this.PN.Name = "PN";
            this.PN.Width = 52;
            // 
            // ProjBrand
            // 
            this.ProjBrand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProjBrand.HeaderText = "Projectile Brand";
            this.ProjBrand.Name = "ProjBrand";
            this.ProjBrand.Width = 97;
            // 
            // ProjDesc
            // 
            this.ProjDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProjDesc.HeaderText = "Description";
            this.ProjDesc.Name = "ProjDesc";
            this.ProjDesc.Width = 85;
            // 
            // ProjWeight
            // 
            this.ProjWeight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProjWeight.HeaderText = "Weight";
            this.ProjWeight.Name = "ProjWeight";
            this.ProjWeight.Width = 66;
            // 
            // BCG1
            // 
            this.BCG1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BCG1.HeaderText = "BC (G1)";
            this.BCG1.Name = "BCG1";
            this.BCG1.Width = 64;
            // 
            // BCG7
            // 
            this.BCG7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BCG7.HeaderText = "BC (G7)";
            this.BCG7.Name = "BCG7";
            this.BCG7.Width = 64;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 409);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.dgvSessions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SessionsList);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SessionsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSessions;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeriesNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvgSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn StdDev;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExtremeSpread;
        private System.Windows.Forms.DataGridViewTextBoxColumn COAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn CBTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupHeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupAvg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Case;
        private System.Windows.Forms.DataGridViewTextBoxColumn Primer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Powder;
        private System.Windows.Forms.DataGridViewTextBoxColumn PowderAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn BCG1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BCG7;
    }
}