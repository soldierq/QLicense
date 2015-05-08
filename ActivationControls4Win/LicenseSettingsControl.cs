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
using System.Security;

namespace ActivationControls4Win
{
    public delegate void LicenseSettingsValidatingHandler(object sender, LicenseSettingsValidatingEventArgs e);
    public delegate void LicenseGeneratedHandler(object sender, LicenseGeneratedEventArgs e);

    public partial class LicenseSettingsControl : UserControl
    {

        public event LicenseSettingsValidatingHandler OnLicenseSettingsValidating;
        public event LicenseGeneratedHandler OnLicenseGenerated;

        protected LicenseEntity _lic;

        public string CertificatePrivateKeyFilePath { set; private get; }

        public string CertificatePassword { set; private get; }

        public bool ShowVolumeLicenseType
        {
            get
            {
                return grpbxLicenseType.Visible;
            }
            set
            {
                if (!value)
                {
                    rdoSingleLicense.Checked = true;
                }

                grpbxLicenseType.Visible = value;
            }
        }

        public LicenseSettingsControl()
        {
            InitializeComponent();
        }

        public void ShowLicense(LicenseEntity license)
        {
            _lic = license;

            pgLicenseSettings.SelectedObject = _lic;
        }

        private void LicenseTypeRadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            txtUUID.Text = string.Empty;

            txtUUID.Enabled = rdoSingleLicense.Checked;
        }

        private void btnGenLicense_Click(object sender, EventArgs e)
        {
            if (_lic == null) throw new ArgumentException("LicenseEntity is invalid");

            if (rdoSingleLicense.Checked)
            {
                if (LicenseHandler.ValidateUUIDFormat(txtUUID.Text.Trim()))
                {
                    _lic.Type = LicenseTypes.Single;
                    _lic.UUID = txtUUID.Text.Trim();
                }
                else
                {
                    MessageBox.Show("许可证标识号为空或者格式不正确", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else if (rdoVolumeLicense.Checked)
            {
                _lic.Type = LicenseTypes.Volume;
                _lic.UUID = string.Empty;
            }

            _lic.CreateDateTime = DateTime.Now;

            if (OnLicenseSettingsValidating != null)
            {
                LicenseSettingsValidatingEventArgs _args=new LicenseSettingsValidatingEventArgs() { License=_lic, CancelGenerating = false };

                OnLicenseSettingsValidating(this, _args);

                if (_args.CancelGenerating)
                {
                    return;
                }
            }

            if (OnLicenseGenerated != null)
            {
                string _licStr = LicenseHandler.GenerateLicenseBASE64String(_lic, CertificatePrivateKeyFilePath, CertificatePassword);

                OnLicenseGenerated(this, new LicenseGeneratedEventArgs() { LicenseBASE64String = _licStr });
            }
        }
    }
}
