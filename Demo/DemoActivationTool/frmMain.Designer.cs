namespace DemoActivationTool
{
    partial class frmMain
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
            this.dlgSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.grpbxLicSettings = new System.Windows.Forms.GroupBox();
            this.licSettings = new QLicense.Windows.Controls.LicenseSettingsControl();
            this.licString = new QLicense.Windows.Controls.LicenseStringContainer();
            this.grpbxLicSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // dlgSaveFile
            // 
            this.dlgSaveFile.FileName = "License.lic";
            this.dlgSaveFile.Filter = "License File(*.lic)|*.lic";
            // 
            // grpbxLicSettings
            // 
            this.grpbxLicSettings.Controls.Add(this.licSettings);
            this.grpbxLicSettings.Location = new System.Drawing.Point(13, 11);
            this.grpbxLicSettings.Name = "grpbxLicSettings";
            this.grpbxLicSettings.Size = new System.Drawing.Size(334, 444);
            this.grpbxLicSettings.TabIndex = 6;
            this.grpbxLicSettings.TabStop = false;
            this.grpbxLicSettings.Text = "License Settings";
            // 
            // licSettings
            // 
            this.licSettings.AllowVolumeLicense = true;
            this.licSettings.Location = new System.Drawing.Point(3, 17);
            this.licSettings.Name = "licSettings";
            this.licSettings.Size = new System.Drawing.Size(328, 427);
            this.licSettings.TabIndex = 7;
            this.licSettings.OnLicenseGenerated += new QLicense.Windows.Controls.LicenseGeneratedHandler(this.licSettings_OnLicenseGenerated);
            // 
            // licString
            // 
            this.licString.LicenseString = "";
            this.licString.Location = new System.Drawing.Point(353, 11);
            this.licString.Name = "licString";
            this.licString.Size = new System.Drawing.Size(348, 444);
            this.licString.TabIndex = 5;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 467);
            this.Controls.Add(this.grpbxLicSettings);
            this.Controls.Add(this.licString);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo Activation Tool";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpbxLicSettings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog dlgSaveFile;
        private QLicense.Windows.Controls.LicenseStringContainer licString;
        private System.Windows.Forms.GroupBox grpbxLicSettings;
        private QLicense.Windows.Controls.LicenseSettingsControl licSettings;
    }
}

