namespace ActivationControls4Win
{
    partial class LicenseSettingsControl
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpbxLicenseType = new System.Windows.Forms.GroupBox();
            this.rdoVolumeLicense = new System.Windows.Forms.RadioButton();
            this.rdoSingleLicense = new System.Windows.Forms.RadioButton();
            this.grpbxUniqueID = new System.Windows.Forms.GroupBox();
            this.txtUUID = new System.Windows.Forms.TextBox();
            this.grpbxLicenseInfo = new System.Windows.Forms.GroupBox();
            this.pgLicenseSettings = new System.Windows.Forms.PropertyGrid();
            this.btnGenLicense = new System.Windows.Forms.Button();
            this.grpbxLicenseType.SuspendLayout();
            this.grpbxUniqueID.SuspendLayout();
            this.grpbxLicenseInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbxLicenseType
            // 
            this.grpbxLicenseType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbxLicenseType.Controls.Add(this.rdoVolumeLicense);
            this.grpbxLicenseType.Controls.Add(this.rdoSingleLicense);
            this.grpbxLicenseType.Location = new System.Drawing.Point(4, 7);
            this.grpbxLicenseType.Name = "grpbxLicenseType";
            this.grpbxLicenseType.Size = new System.Drawing.Size(466, 55);
            this.grpbxLicenseType.TabIndex = 10;
            this.grpbxLicenseType.TabStop = false;
            this.grpbxLicenseType.Text = "许可证类型";
            // 
            // rdoVolumeLicense
            // 
            this.rdoVolumeLicense.AutoSize = true;
            this.rdoVolumeLicense.Location = new System.Drawing.Point(118, 24);
            this.rdoVolumeLicense.Name = "rdoVolumeLicense";
            this.rdoVolumeLicense.Size = new System.Drawing.Size(73, 17);
            this.rdoVolumeLicense.TabIndex = 1;
            this.rdoVolumeLicense.Text = "批量许可";
            this.rdoVolumeLicense.UseVisualStyleBackColor = true;
            this.rdoVolumeLicense.CheckedChanged += new System.EventHandler(this.LicenseTypeRadioButtons_CheckedChanged);
            // 
            // rdoSingleLicense
            // 
            this.rdoSingleLicense.AutoSize = true;
            this.rdoSingleLicense.Checked = true;
            this.rdoSingleLicense.Location = new System.Drawing.Point(6, 24);
            this.rdoSingleLicense.Name = "rdoSingleLicense";
            this.rdoSingleLicense.Size = new System.Drawing.Size(73, 17);
            this.rdoSingleLicense.TabIndex = 0;
            this.rdoSingleLicense.TabStop = true;
            this.rdoSingleLicense.Text = "单机许可";
            this.rdoSingleLicense.UseVisualStyleBackColor = true;
            this.rdoSingleLicense.CheckedChanged += new System.EventHandler(this.LicenseTypeRadioButtons_CheckedChanged);
            // 
            // grpbxUniqueID
            // 
            this.grpbxUniqueID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbxUniqueID.Controls.Add(this.txtUUID);
            this.grpbxUniqueID.Location = new System.Drawing.Point(4, 67);
            this.grpbxUniqueID.Name = "grpbxUniqueID";
            this.grpbxUniqueID.Size = new System.Drawing.Size(466, 56);
            this.grpbxUniqueID.TabIndex = 11;
            this.grpbxUniqueID.TabStop = false;
            this.grpbxUniqueID.Text = "许可证标识号";
            // 
            // txtUUID
            // 
            this.txtUUID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUUID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUUID.Location = new System.Drawing.Point(6, 19);
            this.txtUUID.Name = "txtUUID";
            this.txtUUID.Size = new System.Drawing.Size(454, 20);
            this.txtUUID.TabIndex = 0;
            this.txtUUID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpbxLicenseInfo
            // 
            this.grpbxLicenseInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbxLicenseInfo.Controls.Add(this.pgLicenseSettings);
            this.grpbxLicenseInfo.Location = new System.Drawing.Point(4, 130);
            this.grpbxLicenseInfo.Name = "grpbxLicenseInfo";
            this.grpbxLicenseInfo.Size = new System.Drawing.Size(466, 302);
            this.grpbxLicenseInfo.TabIndex = 12;
            this.grpbxLicenseInfo.TabStop = false;
            this.grpbxLicenseInfo.Text = "许可证信息";
            // 
            // pgLicenseSettings
            // 
            this.pgLicenseSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgLicenseSettings.Location = new System.Drawing.Point(6, 19);
            this.pgLicenseSettings.Name = "pgLicenseSettings";
            this.pgLicenseSettings.PropertySort = System.Windows.Forms.PropertySort.NoSort;
            this.pgLicenseSettings.Size = new System.Drawing.Size(454, 277);
            this.pgLicenseSettings.TabIndex = 0;
            // 
            // btnGenLicense
            // 
            this.btnGenLicense.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenLicense.Location = new System.Drawing.Point(322, 438);
            this.btnGenLicense.Name = "btnGenLicense";
            this.btnGenLicense.Size = new System.Drawing.Size(142, 23);
            this.btnGenLicense.TabIndex = 13;
            this.btnGenLicense.Text = "生成许可证[&L]";
            this.btnGenLicense.UseVisualStyleBackColor = true;
            this.btnGenLicense.Click += new System.EventHandler(this.btnGenLicense_Click);
            // 
            // LicenseSettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpbxLicenseType);
            this.Controls.Add(this.grpbxUniqueID);
            this.Controls.Add(this.grpbxLicenseInfo);
            this.Controls.Add(this.btnGenLicense);
            this.Name = "LicenseSettingsControl";
            this.Size = new System.Drawing.Size(474, 468);
            this.grpbxLicenseType.ResumeLayout(false);
            this.grpbxLicenseType.PerformLayout();
            this.grpbxUniqueID.ResumeLayout(false);
            this.grpbxUniqueID.PerformLayout();
            this.grpbxLicenseInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxLicenseType;
        private System.Windows.Forms.RadioButton rdoVolumeLicense;
        private System.Windows.Forms.RadioButton rdoSingleLicense;
        private System.Windows.Forms.GroupBox grpbxUniqueID;
        private System.Windows.Forms.TextBox txtUUID;
        private System.Windows.Forms.GroupBox grpbxLicenseInfo;
        private System.Windows.Forms.PropertyGrid pgLicenseSettings;
        private System.Windows.Forms.Button btnGenLicense;


    }
}
