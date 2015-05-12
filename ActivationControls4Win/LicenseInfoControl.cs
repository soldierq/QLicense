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

namespace ActivationControls4Win
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
            StringBuilder _sb = new StringBuilder(512);

            Type _typeLic = license.GetType();
            FieldInfo[] _fields = _typeLic.GetFields();
            //TODO: debug why fields is empty

            foreach (FieldInfo _fi in _fields)
            {
                ShowInLicenseInfoAttribute _showAttr = (ShowInLicenseInfoAttribute)Attribute.GetCustomAttribute(_fi, typeof(ShowInLicenseInfoAttribute));
                if (_showAttr != null && _showAttr.ShowInLicenseInfo)
                {
                    DisplayNameAttribute _nameAttr = (DisplayNameAttribute)Attribute.GetCustomAttribute(_fi, typeof(DisplayNameAttribute));
                    string _value = _fi.GetValue(license).ToString();
                    if (_nameAttr != null)
                    {
                        _sb.Append(_nameAttr.DisplayName);
                        _sb.Append(": ");
                        _sb.Append(_value);
                        _sb.Append("\r\n");
                    }

                }
            }

            if (string.IsNullOrWhiteSpace(additionalInfo))
            {
                _sb.Append(additionalInfo.Trim());
            }

            txtLicInfo.Text = _sb.ToString();
        }
    }
}
