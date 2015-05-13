using System;
using System.Windows.Forms;

namespace QLicense.Windows.Controls
{
    public partial class LicenseActivateControl : UserControl
    {
        public string AppName { get; set; }

        public string CertificatePublicKeyFilePath { private get; set; }

        public bool ShowMessageAfterValidation { get; set; }

        public Type LicenseObjectType { get; set; }

        public string LicenseBASE64String
        {
            get
            {
                return txtLicense.Text.Trim();
            }
        }

        public LicenseActivateControl()
        {
            InitializeComponent();

            ShowMessageAfterValidation = true;
        }

        public void ShowUUID()
        {
            txtUUID.Text = LicenseHandler.GenerateUUID(AppName);
        }

        public bool ValidateLicense()
        {
            if (string.IsNullOrWhiteSpace(txtLicense.Text))
            {
                MessageBox.Show("请输入许可证", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            //Check the activation string
            LicenseStatus _licStatus= LicenseStatus.UNDEFINED;
            string _msg = string.Empty;
            LicenseEntity _lic = LicenseHandler.ParseLicenseFromBASE64String(LicenseObjectType, txtLicense.Text.Trim(), CertificatePublicKeyFilePath, out _licStatus, out _msg);
            switch (_licStatus)
            {
                case LicenseStatus.VALID:                   
                    if (ShowMessageAfterValidation)
                    {
                        MessageBox.Show(_msg, "激活成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    return true;
                    
                case LicenseStatus.CRACKED:
                case LicenseStatus.INVALID:
                case LicenseStatus.UNDEFINED:
                    if (ShowMessageAfterValidation)
                    {
                        MessageBox.Show(_msg, "激活失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    return false;

                default:
                    return false;
            }
        }


        private void lnkCopy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(txtUUID.Text);
        }
    }
}
