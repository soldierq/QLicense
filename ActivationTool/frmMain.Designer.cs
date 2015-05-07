namespace ActivationTool
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHardwareID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pgLicenseSettings = new System.Windows.Forms.PropertyGrid();
            this.txtLicense = new System.Windows.Forms.TextBox();
            this.lnkCopy = new System.Windows.Forms.LinkLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lnkSaveToFile = new System.Windows.Forms.LinkLabel();
            this.btnGenLicense = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenSvrMgmLic = new System.Windows.Forms.Button();
            this.dlgSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtHardwareID);
            this.groupBox1.Location = new System.Drawing.Point(5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 56);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "客户机序列号";
            // 
            // txtHardwareID
            // 
            this.txtHardwareID.Location = new System.Drawing.Point(6, 19);
            this.txtHardwareID.Name = "txtHardwareID";
            this.txtHardwareID.Size = new System.Drawing.Size(296, 20);
            this.txtHardwareID.TabIndex = 0;
            this.txtHardwareID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pgLicenseSettings);
            this.groupBox2.Location = new System.Drawing.Point(5, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 330);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "许可证信息设置";
            // 
            // pgLicenseSettings
            // 
            this.pgLicenseSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgLicenseSettings.Location = new System.Drawing.Point(6, 19);
            this.pgLicenseSettings.Name = "pgLicenseSettings";
            this.pgLicenseSettings.Size = new System.Drawing.Size(296, 305);
            this.pgLicenseSettings.TabIndex = 0;
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
            this.txtLicense.Size = new System.Drawing.Size(335, 403);
            this.txtLicense.TabIndex = 0;
            // 
            // lnkCopy
            // 
            this.lnkCopy.AutoSize = true;
            this.lnkCopy.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkCopy.Location = new System.Drawing.Point(262, 431);
            this.lnkCopy.Name = "lnkCopy";
            this.lnkCopy.Size = new System.Drawing.Size(79, 13);
            this.lnkCopy.TabIndex = 1;
            this.lnkCopy.TabStop = true;
            this.lnkCopy.Text = "复制到剪贴板";
            this.lnkCopy.VisitedLinkColor = System.Drawing.Color.Blue;
            this.lnkCopy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCopy_LinkClicked);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lnkSaveToFile);
            this.groupBox3.Controls.Add(this.lnkCopy);
            this.groupBox3.Controls.Add(this.txtLicense);
            this.groupBox3.Location = new System.Drawing.Point(360, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(347, 459);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "许可证字符串";
            // 
            // lnkSaveToFile
            // 
            this.lnkSaveToFile.AutoSize = true;
            this.lnkSaveToFile.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkSaveToFile.Location = new System.Drawing.Point(3, 431);
            this.lnkSaveToFile.Name = "lnkSaveToFile";
            this.lnkSaveToFile.Size = new System.Drawing.Size(67, 13);
            this.lnkSaveToFile.TabIndex = 2;
            this.lnkSaveToFile.TabStop = true;
            this.lnkSaveToFile.Text = "保存到文件";
            this.lnkSaveToFile.VisitedLinkColor = System.Drawing.Color.Blue;
            this.lnkSaveToFile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSaveToFile_LinkClicked);
            // 
            // btnGenLicense
            // 
            this.btnGenLicense.Location = new System.Drawing.Point(177, 399);
            this.btnGenLicense.Name = "btnGenLicense";
            this.btnGenLicense.Size = new System.Drawing.Size(142, 23);
            this.btnGenLicense.TabIndex = 2;
            this.btnGenLicense.Text = "生成客户机许可证[&L]";
            this.btnGenLicense.UseVisualStyleBackColor = true;
            this.btnGenLicense.Click += new System.EventHandler(this.btnGenLicense_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(342, 459);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnGenLicense);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(334, 433);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "客户机许可证";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnGenSvrMgmLic);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(334, 433);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "节点内容维护许可证";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 67);
            this.label1.TabIndex = 6;
            this.label1.Text = "此许可证允许程序维护服务器节点上的内容。\r\n\r\n注：不绑定客户机序列号\r\n        不占用活动客户机计数。";
            // 
            // btnGenSvrMgmLic
            // 
            this.btnGenSvrMgmLic.Location = new System.Drawing.Point(130, 77);
            this.btnGenSvrMgmLic.Name = "btnGenSvrMgmLic";
            this.btnGenSvrMgmLic.Size = new System.Drawing.Size(184, 23);
            this.btnGenSvrMgmLic.TabIndex = 5;
            this.btnGenSvrMgmLic.Text = "生成节点内容维护许可证[&S]";
            this.btnGenSvrMgmLic.UseVisualStyleBackColor = true;
            this.btnGenSvrMgmLic.Click += new System.EventHandler(this.btnGenSvrMgmLic_Click);
            // 
            // dlgSaveFile
            // 
            this.dlgSaveFile.FileName = "License.lic";
            this.dlgSaveFile.Filter = "许可证文件(*.lic)|*.lic";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 490);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "激活工具";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtHardwareID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PropertyGrid pgLicenseSettings;
        private System.Windows.Forms.TextBox txtLicense;
        private System.Windows.Forms.LinkLabel lnkCopy;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGenLicense;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnGenSvrMgmLic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnkSaveToFile;
        private System.Windows.Forms.SaveFileDialog dlgSaveFile;
    }
}

