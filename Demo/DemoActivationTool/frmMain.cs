using System;
using System.Windows.Forms;
using System.IO;
using QLicense;
using DemoLicense;

namespace ActivationTool
{
    public partial class frmMain : Form
    {
        private const string CERT_PWD = "";
        private const string CERT_NAME = "LicenseSign.pfx";

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //Initialize the path for the certificate to sign the XML license file
            licSettings.CertificatePrivateKeyFilePath = Path.Combine(Application.StartupPath, CERT_NAME);
            licSettings.CertificatePassword = CERT_PWD;

            //Initialize a new license object
            licSettings.License = new MyLicense(); 
        }

        private void licSettings_OnLicenseGenerated(object sender, QLicense.Windows.Controls.LicenseGeneratedEventArgs e)
        {
            //Event raised when license string is generated. Just show it in the text box
            licString.LicenseString = e.LicenseBASE64String;
        }


        private void btnGenSvrMgmLic_Click(object sender, EventArgs e)
        {
            //Event raised when "Generate License" button is clicked. 
            //Call the core library to generate the license
            licString.LicenseString = LicenseHandler.GenerateLicenseBASE64String(
                new MyLicense(),
                Path.Combine(Application.StartupPath, CERT_NAME),
                CERT_PWD);
        }
    }
}
