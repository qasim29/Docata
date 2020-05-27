namespace docata
{
    partial class activation_panel
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
            this.EnterLicenseKeyButton = new System.Windows.Forms.Button();
            this.TrialDaysLeftlabel = new System.Windows.Forms.Label();
            this.LicenseKeyTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EnterLicenseKeyButton
            // 
            this.EnterLicenseKeyButton.Location = new System.Drawing.Point(93, 328);
            this.EnterLicenseKeyButton.Name = "EnterLicenseKeyButton";
            this.EnterLicenseKeyButton.Size = new System.Drawing.Size(248, 34);
            this.EnterLicenseKeyButton.TabIndex = 0;
            this.EnterLicenseKeyButton.Text = "EnterLicenseKey";
            this.EnterLicenseKeyButton.UseVisualStyleBackColor = true;
            this.EnterLicenseKeyButton.Click += new System.EventHandler(this.EnterLicenseKeyButton_Click);
            // 
            // TrialDaysLeftlabel
            // 
            this.TrialDaysLeftlabel.AutoSize = true;
            this.TrialDaysLeftlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrialDaysLeftlabel.Location = new System.Drawing.Point(185, 102);
            this.TrialDaysLeftlabel.Name = "TrialDaysLeftlabel";
            this.TrialDaysLeftlabel.Size = new System.Drawing.Size(388, 25);
            this.TrialDaysLeftlabel.TabIndex = 6;
            this.TrialDaysLeftlabel.Text = "You have 30 day left in your trial period";
            // 
            // LicenseKeyTextBox
            // 
            this.LicenseKeyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LicenseKeyTextBox.Location = new System.Drawing.Point(224, 215);
            this.LicenseKeyTextBox.Mask = ">AAAAA-AAAAA-AAAAA-AAAAA-AAAAA";
            this.LicenseKeyTextBox.Name = "LicenseKeyTextBox";
            this.LicenseKeyTextBox.Size = new System.Drawing.Size(491, 26);
            this.LicenseKeyTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "LicenseKey";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(375, 328);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(248, 34);
            this.ExitButton.TabIndex = 10;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // activation_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LicenseKeyTextBox);
            this.Controls.Add(this.TrialDaysLeftlabel);
            this.Controls.Add(this.EnterLicenseKeyButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "activation_panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "activation_panel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.activation_panel_FormClosed);
            this.Load += new System.EventHandler(this.activation_panel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EnterLicenseKeyButton;
        private System.Windows.Forms.Label TrialDaysLeftlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox LicenseKeyTextBox;
        private System.Windows.Forms.Button ExitButton;
    }
}