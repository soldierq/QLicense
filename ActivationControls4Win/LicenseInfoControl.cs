using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLicense;
using System.Reflection;

namespace QLicense.Windows.Controls
{
    public partial class LicenseInfoControl : UserControl
    {
        public LicenseInfoControl()
        {
            InitializeComponent();
        }

        public void ShowLicenseInfo(LicenseEntity license)
        {
            this.ShowLicenseInfo(license, string.Empty);
        }

        public void ShowLicenseInfo(LicenseEntity license, string additionalInfo)
        {
            try
            {
                StringBuilder _sb = new StringBuilder(512);

                Type _typeLic = license.GetType();
                PropertyInfo[] _props = _typeLic.GetProperties();

                object _value=null;
                foreach (PropertyInfo _p in _props)
                {
                    ShowInLicenseInfoAttribute _showAttr = (ShowInLicenseInfoAttribute)Attribute.GetCustomAttribute(_p, typeof(ShowInLicenseInfoAttribute));
                    if (_showAttr != null && _showAttr.ShowInLicenseInfo)
                    {
                        //TODO: change for datetime & enum type
                        _value = _p.GetValue(license, null);
                        _sb.Append(_showAttr.DisplayAs);
                        _sb.Append(": ");
                        if (_value != null)
                        {
                            _sb.Append(_value.ToString());
                        }
                        _sb.Append("\r\n");

                    }
                }
                

                if (string.IsNullOrWhiteSpace(additionalInfo))
                {
                    _sb.Append(additionalInfo.Trim());
                }

                txtLicInfo.Text = _sb.ToString();
            }
            catch (Exception ex)
            {
                txtLicInfo.Text = ex.Message;
            }
        }
    }
}
