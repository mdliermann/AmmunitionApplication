namespace Test
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
            this.SuspendLayout();
            // 
            // txtPowderManufacturer
            // 
            this.txtPowderManufacturer.Location = new System.Drawing.Point(88, 12);
            this.txtPowderManufacturer.Name = "txtPowderManufacturer";
            this.txtPowderManufacturer.Size = new System.Drawing.Size(209, 20);
            this.txtPowderManufacturer.TabIndex = 0;
            // 
            // lblPowderManufacturer
            // 
            this.lblPowderManufacturer.AutoSize = true;
            this.lblPowderManufacturer.Location = new System.Drawing.Point(12, 15);
            this.lblPowderManufacturer.Name = "lblPowderManufacturer";
            this.lblPowderManufacturer.Size = new System.Drawing.Size(70, 13);
            this.lblPowderManufacturer.TabIndex = 1;
            this.lblPowderManufacturer.Text = "Manufacturer";
            // 
            // btnNewPowder
            // 
            this.btnNewPowder.Location = new System.Drawing.Point(121, 38);
            this.btnNewPowder.Name = "btnNewPowder";
            this.btnNewPowder.Size = new System.Drawing.Size(75, 23);
            this.btnNewPowder.TabIndex = 1;
            this.btnNewPowder.Text = "Add";
            this.btnNewPowder.UseVisualStyleBackColor = true;
            // 
            // PowderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 71);
            this.Controls.Add(this.btnNewPowder);
            this.Controls.Add(this.lblPowderManufacturer);
            this.Controls.Add(this.txtPowderManufacturer);
            this.Name = "PowderForm";
            this.Text = "Add Powder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPowderManufacturer;
        private System.Windows.Forms.Label lblPowderManufacturer;
        private System.Windows.Forms.Button btnNewPowder;
    }
}