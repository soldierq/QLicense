namespace DemoWinFormApp
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
            this.licInfo = new QLicense.Windows.Controls.LicenseInfoControl();
            this.SuspendLayout();
            // 
            // licInfo
            // 
            this.licInfo.DateFormat = null;
            this.licInfo.DateTimeFormat = null;
            this.licInfo.Location = new System.Drawing.Point(12, 12);
            this.licInfo.Name = "licInfo";
            this.licInfo.Size = new System.Drawing.Size(300, 300);
            this.licInfo.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 330);
            this.Controls.Add(this.licInfo);
            this.Name = "frmMain";
            this.Text = "DemoWinFormApp";
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private QLicense.Windows.Controls.LicenseInfoControl licInfo;
    }
}

