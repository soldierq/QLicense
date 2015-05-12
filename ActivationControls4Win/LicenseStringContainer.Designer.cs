namespace QLicense.Windows.Controls
{
    partial class LicenseStringContainer
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lnkSaveToFile = new System.Windows.Forms.LinkLabel();
            this.lnkCopy = new System.Windows.Forms.LinkLabel();
            this.txtLicense = new System.Windows.Forms.TextBox();
            this.dlgSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lnkSaveToFile);
            this.groupBox3.Controls.Add(this.lnkCopy);
            this.groupBox3.Controls.Add(this.txtLicense);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(348, 453);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "许可证字符串";
            // 
            // lnkSaveToFile
            // 
            this.lnkSaveToFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lnkSaveToFile.AutoSize = true;
            this.lnkSaveToFile.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkSaveToFile.Location = new System.Drawing.Point(3, 425);
            this.lnkSaveToFile.Name = "lnkSaveToFile";
            this.lnkSaveToFile.Size = new System.Drawing.Size(67, 13);
            this.lnkSaveToFile.TabIndex = 2;
            this.lnkSaveToFile.TabStop = true;
            this.lnkSaveToFile.Text = "保存到文件";
            this.lnkSaveToFile.VisitedLinkColor = System.Drawing.Color.Blue;
            this.lnkSaveToFile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSaveToFile_LinkClicked);
            // 
            // lnkCopy
            // 
            this.lnkCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkCopy.AutoSize = true;
            this.lnkCopy.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkCopy.Location = new System.Drawing.Point(263, 425);
            this.lnkCopy.Name = "lnkCopy";
            this.lnkCopy.Size = new System.Drawing.Size(79, 13);
            this.lnkCopy.TabIndex = 1;
            this.lnkCopy.TabStop = true;
            this.lnkCopy.Text = "复制到剪贴板";
            this.lnkCopy.VisitedLinkColor = System.Drawing.Color.Blue;
            this.lnkCopy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCopy_LinkClicked);
            // 
            // txtLicense
            // 
            this.txtLicense.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLicense.Location = new System.Drawing.Point(6, 19);
            this.txtLicense.Multiline = true;
            this.txtLicense.Name = "txtLicense";
            this.txtLicense.ReadOnly = true;
            this.txtLicense.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLicense.Size = new System.Drawing.Size(336, 397);
            this.txtLicense.TabIndex = 0;
            // 
            // dlgSaveFile
            // 
            this.dlgSaveFile.FileName = "License.lic";
            this.dlgSaveFile.Filter = "许可证文件(*.lic)|*.lic";
            // 
            // LicenseStringContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Name = "LicenseStringContainer";
            this.Size = new System.Drawing.Size(348, 453);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.LinkLabel lnkSaveToFile;
        private System.Windows.Forms.LinkLabel lnkCopy;
        private System.Windows.Forms.TextBox txtLicense;
        private System.Windows.Forms.SaveFileDialog dlgSaveFile;
    }
}
