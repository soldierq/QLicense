using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace QLicense
{
    /// <summary>
    /// This attribute defines whether the property of LicenseEntity object will be shown in LicenseInfoControl
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class ShowInLicenseInfoAttribute : Attribute
    {
        protected bool _showInLicenseInfo = true;

        public ShowInLicenseInfoAttribute()
        {
        }

        public ShowInLicenseInfoAttribute(bool showInLicenseInfo)
        {
            _showInLicenseInfo = showInLicenseInfo;
        }

        public bool ShowInLicenseInfo
        {
            get
            {
                return _showInLicenseInfo;
            }
        }
    }


    public abstract class LicenseEntity
    {
        [Browsable(false)]
        [XmlElement("UUID")]
        [ShowInLicenseInfo(false)]
        public string UUID { get; set; }

        [Browsable(false)]
        [XmlElement("Type")]
        [ShowInLicenseInfo(true)]
        public LicenseTypes Type { get; set; }

        [Browsable(false)]
        [XmlElement("CreateDateTime")]
        [ShowInLicenseInfo(true)]
        public DateTime CreateDateTime { get; set; }

    }
}
