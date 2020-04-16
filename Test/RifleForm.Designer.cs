namespace Test
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
            this.SuspendLayout();
            // 
            // lblMakeModel
            // 
            this.lblMakeModel.AutoSize = true;
            this.lblMakeModel.Location = new System.Drawing.Point(12, 15);
            this.lblMakeModel.Name = "lblMakeModel";
            this.lblMakeModel.Size = new System.Drawing.Size(87, 13);
            this.lblMakeModel.TabIndex = 0;
            this.lblMakeModel.Text = "Make and Model";
            // 
            // lblCaliber
            // 
            this.lblCaliber.AutoSize = true;
            this.lblCaliber.Location = new System.Drawing.Point(12, 41);
            this.lblCaliber.Name = "lblCaliber";
            this.lblCaliber.Size = new System.Drawing.Size(39, 13);
            this.lblCaliber.TabIndex = 1;
            this.lblCaliber.Text = "Caliber";
            // 
            // lblBarrel
            // 
            this.lblBarrel.AutoSize = true;
            this.lblBarrel.Location = new System.Drawing.Point(12, 67);
            this.lblBarrel.Name = "lblBarrel";
            this.lblBarrel.Size = new System.Drawing.Size(34, 13);
            this.lblBarrel.TabIndex = 2;
            this.lblBarrel.Text = "Barrel";
            // 
            // lblScope
            // 
            this.lblScope.AutoSize = true;
            this.lblScope.Location = new System.Drawing.Point(12, 93);
            this.lblScope.Name = "lblScope";
            this.lblScope.Size = new System.Drawing.Size(38, 13);
            this.lblScope.TabIndex = 3;
            this.lblScope.Text = "Scope";
            // 
            // txtScope
            // 
            this.txtScope.Location = new System.Drawing.Point(57, 90);
            this.txtScope.Name = "txtScope";
            this.txtScope.Size = new System.Drawing.Size(240, 20);
            this.txtScope.TabIndex = 3;
            // 
            // txtBarrel
            // 
            this.txtBarrel.Location = new System.Drawing.Point(57, 64);
            this.txtBarrel.Name = "txtBarrel";
            this.txtBarrel.Size = new System.Drawing.Size(240, 20);
            this.txtBarrel.TabIndex = 2;
            // 
            // txtCaliber
            // 
            this.txtCaliber.Location = new System.Drawing.Point(57, 38);
            this.txtCaliber.Name = "txtCaliber";
            this.txtCaliber.Size = new System.Drawing.Size(240, 20);
            this.txtCaliber.TabIndex = 1;
            // 
            // txtMakeAndModel
            // 
            this.txtMakeAndModel.Location = new System.Drawing.Point(105, 12);
            this.txtMakeAndModel.Name = "txtMakeAndModel";
            this.txtMakeAndModel.Size = new System.Drawing.Size(192, 20);
            this.txtMakeAndModel.TabIndex = 0;
            // 
            // btnNewRifle
            // 
            this.btnNewRifle.Location = new System.Drawing.Point(115, 116);
            this.btnNewRifle.Name = "btnNewRifle";
            this.btnNewRifle.Size = new System.Drawing.Size(75, 23);
            this.btnNewRifle.TabIndex = 4;
            this.btnNewRifle.Text = "Add";
            this.btnNewRifle.UseVisualStyleBackColor = true;
            this.btnNewRifle.Click += new System.EventHandler(this.btnNewRifle_Click);
            // 
            // RifleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 148);
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
            this.Text = "Add Rifle";
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
    }
}