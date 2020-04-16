namespace Test
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
            this.SuspendLayout();
            // 
            // btnNewCase
            // 
            this.btnNewCase.Location = new System.Drawing.Point(115, 38);
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
            this.lblCaseManufacturer.Location = new System.Drawing.Point(12, 15);
            this.lblCaseManufacturer.Name = "lblCaseManufacturer";
            this.lblCaseManufacturer.Size = new System.Drawing.Size(70, 13);
            this.lblCaseManufacturer.TabIndex = 1;
            this.lblCaseManufacturer.Text = "Manufacturer";
            // 
            // txtCaseManufacturer
            // 
            this.txtCaseManufacturer.Location = new System.Drawing.Point(88, 12);
            this.txtCaseManufacturer.Name = "txtCaseManufacturer";
            this.txtCaseManufacturer.Size = new System.Drawing.Size(209, 20);
            this.txtCaseManufacturer.TabIndex = 0;
            // 
            // CaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 71);
            this.Controls.Add(this.txtCaseManufacturer);
            this.Controls.Add(this.lblCaseManufacturer);
            this.Controls.Add(this.btnNewCase);
            this.Name = "CaseForm";
            this.Text = "Add Case";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewCase;
        private System.Windows.Forms.Label lblCaseManufacturer;
        private System.Windows.Forms.TextBox txtCaseManufacturer;
    }
}