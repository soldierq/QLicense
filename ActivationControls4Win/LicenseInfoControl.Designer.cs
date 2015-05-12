namespace QLicense.Windows.Controls
{
    partial class LicenseInfoControl
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
            this.grpbxLicInfo = new System.Windows.Forms.GroupBox();
            this.txtLicInfo = new System.Windows.Forms.TextBox();
            this.grpbxLicInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbxLicInfo
            // 
            this.grpbxLicInfo.Controls.Add(this.txtLicInfo);
            this.grpbxLicInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbxLicInfo.Location = new System.Drawing.Point(0, 0);
            this.grpbxLicInfo.Name = "grpbxLicInfo";
            this.grpbxLicInfo.Size = new System.Drawing.Size(300, 300);
            this.grpbxLicInfo.TabIndex = 0;
            this.grpbxLicInfo.TabStop = false;
            this.grpbxLicInfo.Text = "许可证信息";
            // 
            // txtLicInfo
            // 
            this.txtLicInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLicInfo.Location = new System.Drawing.Point(3, 16);
            this.txtLicInfo.Multiline = true;
            this.txtLicInfo.Name = "txtLicInfo";
            this.txtLicInfo.ReadOnly = true;
            this.txtLicInfo.Size = new System.Drawing.Size(294, 281);
            this.txtLicInfo.TabIndex = 0;
            this.txtLicInfo.WordWrap = false;
            // 
            // LicenseInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpbxLicInfo);
            this.Name = "LicenseInfoControl";
            this.Size = new System.Drawing.Size(300, 300);
            this.grpbxLicInfo.ResumeLayout(false);
            this.grpbxLicInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxLicInfo;
        private System.Windows.Forms.TextBox txtLicInfo;
    }
}
