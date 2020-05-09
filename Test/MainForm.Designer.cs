namespace AmmunitionProject
{
    partial class MainForm
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
            this.btnCases = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProjectiles = new System.Windows.Forms.Button();
            this.btnPowders = new System.Windows.Forms.Button();
            this.btnPrimers = new System.Windows.Forms.Button();
            this.btnRilfes = new System.Windows.Forms.Button();
            this.btnSessions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCases
            // 
            this.btnCases.Location = new System.Drawing.Point(12, 54);
            this.btnCases.Name = "btnCases";
            this.btnCases.Size = new System.Drawing.Size(75, 23);
            this.btnCases.TabIndex = 2;
            this.btnCases.Text = "Cases";
            this.btnCases.UseVisualStyleBackColor = true;
            this.btnCases.Click += new System.EventHandler(this.btnCases_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(214, 70);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(94, 36);
            this.btnReport.TabIndex = 4;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(355, 83);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "View/Modify Components:";
            // 
            // btnProjectiles
            // 
            this.btnProjectiles.Location = new System.Drawing.Point(12, 83);
            this.btnProjectiles.Name = "btnProjectiles";
            this.btnProjectiles.Size = new System.Drawing.Size(75, 23);
            this.btnProjectiles.TabIndex = 7;
            this.btnProjectiles.Text = "Projectiles";
            this.btnProjectiles.UseVisualStyleBackColor = true;
            this.btnProjectiles.Click += new System.EventHandler(this.btnProjectiles_Click);
            // 
            // btnPowders
            // 
            this.btnPowders.Location = new System.Drawing.Point(93, 83);
            this.btnPowders.Name = "btnPowders";
            this.btnPowders.Size = new System.Drawing.Size(75, 23);
            this.btnPowders.TabIndex = 8;
            this.btnPowders.Text = "Powders";
            this.btnPowders.UseVisualStyleBackColor = true;
            this.btnPowders.Click += new System.EventHandler(this.btnPowders_Click);
            // 
            // btnPrimers
            // 
            this.btnPrimers.Location = new System.Drawing.Point(93, 54);
            this.btnPrimers.Name = "btnPrimers";
            this.btnPrimers.Size = new System.Drawing.Size(75, 23);
            this.btnPrimers.TabIndex = 9;
            this.btnPrimers.Text = "Primers";
            this.btnPrimers.UseVisualStyleBackColor = true;
            this.btnPrimers.Click += new System.EventHandler(this.btnPrimers_Click);
            // 
            // btnRilfes
            // 
            this.btnRilfes.Location = new System.Drawing.Point(52, 25);
            this.btnRilfes.Name = "btnRilfes";
            this.btnRilfes.Size = new System.Drawing.Size(75, 23);
            this.btnRilfes.TabIndex = 10;
            this.btnRilfes.Text = "Rifles";
            this.btnRilfes.UseVisualStyleBackColor = true;
            this.btnRilfes.Click += new System.EventHandler(this.btnRilfes_Click);
            // 
            // btnSessions
            // 
            this.btnSessions.Location = new System.Drawing.Point(214, 18);
            this.btnSessions.Name = "btnSessions";
            this.btnSessions.Size = new System.Drawing.Size(94, 36);
            this.btnSessions.TabIndex = 11;
            this.btnSessions.Text = "Sessions";
            this.btnSessions.UseVisualStyleBackColor = true;
            this.btnSessions.Click += new System.EventHandler(this.btnSessions_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 118);
            this.Controls.Add(this.btnSessions);
            this.Controls.Add(this.btnRilfes);
            this.Controls.Add(this.btnPrimers);
            this.Controls.Add(this.btnPowders);
            this.Controls.Add(this.btnProjectiles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnCases);
            this.Name = "MainForm";
            this.Text = "Main Page";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCases;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProjectiles;
        private System.Windows.Forms.Button btnPowders;
        private System.Windows.Forms.Button btnPrimers;
        private System.Windows.Forms.Button btnRilfes;
        private System.Windows.Forms.Button btnSessions;
    }
}

