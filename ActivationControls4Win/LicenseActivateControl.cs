using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLicense;

namespace ActivationControls4Win
{
    public delegate void LicenseValidatedHandler(object sender, LicenseValidatedEventArgs e);
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

        public event LicenseValidatedHandler OnLicenseValidatedOK;

        public event LicenseValidatedHandler OnLicenseValidatedFailed;

        public LicenseActivateControl()
        {
            InitializeComponent();

            ShowMessageAfterValidation = true;
        }

        private void LicenseActivateControl_Load(object sender, EventArgs e)
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
            LicenseEntity _lic = LicenseHandler.ParseLicenseFromBASE64String(LicenseObjectType, txtLicense.Text.Trim(), CertificatePublicKeyFilePath, out _licStatus);
            switch (_licStatus)
            {
                case LicenseStatus.VALID:
                    if (OnLicenseValidatedOK != null)
                    {
                        LicenseValidatedEventArgs _args = new LicenseValidatedEventArgs() { License = _lic, ValidationStatus = _licStatus };
                        OnLicenseValidatedOK(this, _args);

                        if (_args.CustomizedValidationFailed)
                        {
                            return false;
                        }
                    }
                   
                    if (ShowMessageAfterValidation)
                    {
                        MessageBox.Show("本地许可证激活成功", "激活成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    return true;
                    
                case LicenseStatus.CRACKED:
                case LicenseStatus.INVALID:
                case LicenseStatus.UNDEFINED:
                    if (OnLicenseValidatedFailed != null)
                    {
                        OnLicenseValidatedFailed(this, new LicenseValidatedEventArgs { License = _lic, ValidationStatus = _licStatus });
                    }

                    if (ShowMessageAfterValidation)
                    {
                        MessageBox.Show("许可证不正确, 请获取新的激活码", "激活失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
