using System;
using System.Windows.Forms;
using System.IO;
using System.Security;
using System.Reflection;
using QLicense;
using DemoLicense;

namespace DemoActivationTool
{
    public partial class frmMain : Form
    {
        private byte[] _certPubicKeyData;
        private SecureString _certPwd = new SecureString();

        public frmMain()
        {
            InitializeComponent();

            _certPwd.AppendChar('d');
            _certPwd.AppendChar('e');
            _certPwd.AppendChar('m');
            _certPwd.AppendChar('o');
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //Read public key from assembly
            Assembly _assembly = Assembly.GetExecutingAssembly();
            using (MemoryStream _mem = new MemoryStream())
            {
                _assembly.GetManifestResourceStream("DemoActivationTool.LicenseSign.pfx").CopyTo(_mem);

                _certPubicKeyData = _mem.ToArray();
            }

            //Initialize the path for the certificate to sign the XML license file
            licSettings.CertificatePrivateKeyData = _certPubicKeyData;
            licSettings.CertificatePassword = _certPwd;

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
                _certPubicKeyData,
                _certPwd);
        }

    }
}
