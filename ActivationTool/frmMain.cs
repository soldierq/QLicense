using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using QL=QLicense;
using QLicense;

namespace ActivationTool
{
    public partial class frmMain : Form
    {
        LicenseEntity _lic;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            pgLicenseSettings.SelectedObject = _lic;

        }

        private void lnkCopy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(txtLicense.Text);
        }


        private void btnGenLicense_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtHardwareID.Text))
            {
                if (QL.LicenseHandler.ValidateHardwareID(txtHardwareID.Text.Trim()))
                {
                    //_lic.RunAs = LicenseObject.RUN_AS_CLIENT;
                    //_lic.HardwareID = txtHardwareID.Text.Trim();
                    //_lic.CreateDateTime = DateTime.Now;

                    txtLicense.Text = SerializeLicToBASE64(_lic);
                }
                else
                {
                    MessageBox.Show("客户机序列号格式不正确", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("客户机序列号不能为空", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnGenSvrMgmLic_Click(object sender, EventArgs e)
        {
            

            txtLicense.Text = SerializeLicToBASE64(_lic);
        }

        private string SerializeLicToBASE64(LicenseEntity lic)
        {
            //Serialize license object into XML                    
            XmlSerializer _serializer = new XmlSerializer(typeof(LicenseEntity));
            StringWriter _writer = new StringWriter();

            _serializer.Serialize(_writer, _lic);

            return QL.LicenseHandler.GenerateLicenseBASE64String(_writer.ToString(), "LicenseSign.pfx", "pass"); 
        }

        private void lnkSaveToFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dlgSaveFile.ShowDialog() == DialogResult.OK)
            {
                //Save license data into local file
                File.WriteAllText(dlgSaveFile.FileName, txtLicense.Text.Trim(), Encoding.UTF8);
            }
        }

    }
}
