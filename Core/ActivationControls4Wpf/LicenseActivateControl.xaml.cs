using QLicense;
using System;
using System.Windows;
using System.Windows.Controls;

namespace ActivationControls4Wpf
{
    /// <summary>
    /// Interaction logic for LicenseActivateControl.xaml
    /// </summary>
    public partial class LicenseActivateControl : UserControl
    {

        public string AppName { get; set; }

        public byte[] CertificatePublicKeyData { get; set; }

        public bool ShowMessageAfterValidation { get; set; }

        public Type LicenseObjectType { get; set; }

        public string LicenseBASE64String
        {
            get
            {
                return this.txtLicense.Text.Trim();
            }
        }

        public LicenseActivateControl()
        {
            InitializeComponent();
        }

        public void ShowUID()
        {
            this.txtUID.Text = LicenseHandler.GenerateUID(AppName);
        }

        public bool ValidateLicense()
        {
            if (string.IsNullOrWhiteSpace(txtLicense.Text))
            {
                MessageBox.Show("Please input license", string.Empty, MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }

            //Check the activation string
            LicenseStatus _licStatus = LicenseStatus.UNDEFINED;
            string _msg = string.Empty;
            try
            {
                LicenseEntity _lic = LicenseHandler.ParseLicenseFromBASE64String(LicenseObjectType, txtLicense.Text.Trim(), CertificatePublicKeyData, out _licStatus, out _msg);
                switch (_licStatus)
                {
                    case LicenseStatus.VALID:
                        if (ShowMessageAfterValidation)
                        {
                            MessageBox.Show(_msg, "License is valid", MessageBoxButton.OK, MessageBoxImage.Information);
                        }

                        return true;

                    case LicenseStatus.CRACKED:
                    case LicenseStatus.INVALID:
                    case LicenseStatus.UNDEFINED:
                        if (ShowMessageAfterValidation)
                        {
                            MessageBox.Show(_msg, "License is INVALID", MessageBoxButton.OK, MessageBoxImage.Error);
                        }

                        return false;

                    default:
                        return false;
                }
            }
            catch (Exception e)
            {
                
                throw e;
            }
            
        }
    }
}
