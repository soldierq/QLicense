using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace QLicense
{
    public abstract class LicenseEntity
    {
        [BrowsableAttribute(false)]
        [XmlElementAttribute("HardwareID")]
        public string HardwareID { get; set; }

        [BrowsableAttribute(true)]
        [XmlElementAttribute("ExpiryDate")]
        public DateTime ExpiryDate { get; set; }

        [BrowsableAttribute(false)]
        [XmlElementAttribute("CreateDateTime")]
        public DateTime CreateDateTime { get; protected set; }


    }
}
