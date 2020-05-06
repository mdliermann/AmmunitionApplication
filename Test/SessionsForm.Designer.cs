namespace AmmunitionProject
{
    partial class SessionsForm
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
            this.txtHumid = new System.Windows.Forms.TextBox();
            this.txtWind = new System.Windows.Forms.TextBox();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.cbRifles = new System.Windows.Forms.ComboBox();
            this.dgvSessions = new System.Windows.Forms.DataGridView();
            this.btnNewSession = new System.Windows.Forms.Button();
            this.btnEditSession = new System.Windows.Forms.Button();
            this.btnDeleteSession = new System.Windows.Forms.Button();
            this.btnSeries = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessions)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHumid
            // 
            this.txtHumid.Location = new System.Drawing.Point(85, 99);
            this.txtHumid.Name = "txtHumid";
            this.txtHumid.Size = new System.Drawing.Size(387, 20);
            this.txtHumid.TabIndex = 0;
            // 
            // txtWind
            // 
            this.txtWind.Location = new System.Drawing.Point(84, 41);
            this.txtWind.Name = "txtWind";
            this.txtWind.Size = new System.Drawing.Size(388, 20);
            this.txtWind.TabIndex = 1;
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(85, 70);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(387, 20);
            this.txtTemp.TabIndex = 2;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(125, 12);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(347, 20);
            this.txtDate.TabIndex = 3;
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(85, 127);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(386, 20);
            this.txtDistance.TabIndex = 4;
            // 
            // cbRifles
            // 
            this.cbRifles.FormattingEnabled = true;
            this.cbRifles.Location = new System.Drawing.Point(84, 153);
            this.cbRifles.Name = "cbRifles";
            this.cbRifles.Size = new System.Drawing.Size(387, 21);
            this.cbRifles.TabIndex = 5;
            this.cbRifles.SelectedIndexChanged += new System.EventHandler(this.cbRifles_SelectedIndexChanged);
            // 
            // dgvSessions
            // 
            this.dgvSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSessions.Location = new System.Drawing.Point(12, 180);
            this.dgvSessions.Name = "dgvSessions";
            this.dgvSessions.Size = new System.Drawing.Size(459, 228);
            this.dgvSessions.TabIndex = 6;
            this.dgvSessions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSessions_CellClick);
            // 
            // btnNewSession
            // 
            this.btnNewSession.Location = new System.Drawing.Point(478, 10);
            this.btnNewSession.Name = "btnNewSession";
            this.btnNewSession.Size = new System.Drawing.Size(88, 23);
            this.btnNewSession.TabIndex = 7;
            this.btnNewSession.Text = "Add";
            this.btnNewSession.UseVisualStyleBackColor = true;
            this.btnNewSession.Click += new System.EventHandler(this.btnNewSession_Click);
            // 
            // btnEditSession
            // 
            this.btnEditSession.Location = new System.Drawing.Point(478, 39);
            this.btnEditSession.Name = "btnEditSession";
            this.btnEditSession.Size = new System.Drawing.Size(88, 23);
            this.btnEditSession.TabIndex = 8;
            this.btnEditSession.Text = "Edit";
            this.btnEditSession.UseVisualStyleBackColor = true;
            this.btnEditSession.Click += new System.EventHandler(this.btnEditSession_Click);
            // 
            // btnDeleteSession
            // 
            this.btnDeleteSession.Location = new System.Drawing.Point(478, 68);
            this.btnDeleteSession.Name = "btnDeleteSession";
            this.btnDeleteSession.Size = new System.Drawing.Size(88, 23);
            this.btnDeleteSession.TabIndex = 9;
            this.btnDeleteSession.Text = "Delete";
            this.btnDeleteSession.UseVisualStyleBackColor = true;
            this.btnDeleteSession.Click += new System.EventHandler(this.btnDeleteSession_Click);
            // 
            // btnSeries
            // 
            this.btnSeries.Location = new System.Drawing.Point(477, 97);
            this.btnSeries.Name = "btnSeries";
            this.btnSeries.Size = new System.Drawing.Size(89, 23);
            this.btnSeries.TabIndex = 10;
            this.btnSeries.Text = "Modify Series";
            this.btnSeries.UseVisualStyleBackColor = true;
            this.btnSeries.Click += new System.EventHandler(this.btnSeries_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Date (YYYY-MM-DD)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Wind Speed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Humidity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Distance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Temperature";
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(477, 128);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(89, 289);
            this.textBox6.TabIndex = 16;
            this.textBox6.Text = "To edit an entry, select it from the list, change the desired values in the textb" +
    "ox, and then click Edit. To remove an entry, select it from the list and click R" +
    "emove. ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Rifles";
            // 
            // SessionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 420);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSeries);
            this.Controls.Add(this.btnDeleteSession);
            this.Controls.Add(this.btnEditSession);
            this.Controls.Add(this.btnNewSession);
            this.Controls.Add(this.dgvSessions);
            this.Controls.Add(this.cbRifles);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.txtWind);
            this.Controls.Add(this.txtHumid);
            this.Name = "SessionsForm";
            this.Text = "SessionsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHumid;
        private System.Windows.Forms.TextBox txtWind;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.ComboBox cbRifles;
        private System.Windows.Forms.DataGridView dgvSessions;
        private System.Windows.Forms.Button btnNewSession;
        private System.Windows.Forms.Button btnEditSession;
        private System.Windows.Forms.Button btnDeleteSession;
        private System.Windows.Forms.Button btnSeries;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
    }
}