namespace Test
{
    partial class AddForm
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
            this.btnAddSession = new System.Windows.Forms.Button();
            this.btnAddPowder = new System.Windows.Forms.Button();
            this.btnAddPrimer = new System.Windows.Forms.Button();
            this.btnAddProjectile = new System.Windows.Forms.Button();
            this.btnAddCase = new System.Windows.Forms.Button();
            this.btnAddRifle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddSession
            // 
            this.btnAddSession.Location = new System.Drawing.Point(168, 101);
            this.btnAddSession.Name = "btnAddSession";
            this.btnAddSession.Size = new System.Drawing.Size(94, 76);
            this.btnAddSession.TabIndex = 0;
            this.btnAddSession.Text = "Add Session";
            this.btnAddSession.UseVisualStyleBackColor = true;
            this.btnAddSession.Click += new System.EventHandler(this.btnAddSession_Click);
            // 
            // btnAddPowder
            // 
            this.btnAddPowder.Location = new System.Drawing.Point(12, 81);
            this.btnAddPowder.Name = "btnAddPowder";
            this.btnAddPowder.Size = new System.Drawing.Size(75, 23);
            this.btnAddPowder.TabIndex = 1;
            this.btnAddPowder.Text = "Add Power";
            this.btnAddPowder.UseVisualStyleBackColor = true;
            this.btnAddPowder.Click += new System.EventHandler(this.btnAddPowder_Click);
            // 
            // btnAddPrimer
            // 
            this.btnAddPrimer.Location = new System.Drawing.Point(12, 128);
            this.btnAddPrimer.Name = "btnAddPrimer";
            this.btnAddPrimer.Size = new System.Drawing.Size(75, 23);
            this.btnAddPrimer.TabIndex = 2;
            this.btnAddPrimer.Text = "Add Primer";
            this.btnAddPrimer.UseVisualStyleBackColor = true;
            this.btnAddPrimer.Click += new System.EventHandler(this.btnAddPrimer_Click);
            // 
            // btnAddProjectile
            // 
            this.btnAddProjectile.Location = new System.Drawing.Point(12, 222);
            this.btnAddProjectile.Name = "btnAddProjectile";
            this.btnAddProjectile.Size = new System.Drawing.Size(88, 23);
            this.btnAddProjectile.TabIndex = 4;
            this.btnAddProjectile.Text = "Add Projectile";
            this.btnAddProjectile.UseVisualStyleBackColor = true;
            this.btnAddProjectile.Click += new System.EventHandler(this.btnAddProjectile_Click);
            // 
            // btnAddCase
            // 
            this.btnAddCase.Location = new System.Drawing.Point(12, 30);
            this.btnAddCase.Name = "btnAddCase";
            this.btnAddCase.Size = new System.Drawing.Size(75, 23);
            this.btnAddCase.TabIndex = 0;
            this.btnAddCase.Text = "Add Case";
            this.btnAddCase.UseVisualStyleBackColor = true;
            this.btnAddCase.Click += new System.EventHandler(this.btnAddCase_Click);
            // 
            // btnAddRifle
            // 
            this.btnAddRifle.Location = new System.Drawing.Point(12, 174);
            this.btnAddRifle.Name = "btnAddRifle";
            this.btnAddRifle.Size = new System.Drawing.Size(75, 23);
            this.btnAddRifle.TabIndex = 3;
            this.btnAddRifle.Text = "Add Rifle";
            this.btnAddRifle.UseVisualStyleBackColor = true;
            this.btnAddRifle.Click += new System.EventHandler(this.btnAddRifle_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 297);
            this.Controls.Add(this.btnAddRifle);
            this.Controls.Add(this.btnAddCase);
            this.Controls.Add(this.btnAddProjectile);
            this.Controls.Add(this.btnAddPrimer);
            this.Controls.Add(this.btnAddPowder);
            this.Controls.Add(this.btnAddSession);
            this.Name = "AddForm";
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Addform_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddSession;
        private System.Windows.Forms.Button btnAddPowder;
        private System.Windows.Forms.Button btnAddPrimer;
        private System.Windows.Forms.Button btnAddProjectile;
        private System.Windows.Forms.Button btnAddCase;
        private System.Windows.Forms.Button btnAddRifle;
    }
}