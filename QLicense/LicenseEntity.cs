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
        [Browsable(false)]
        [XmlElement("UUID")]
        public string UUID { get; set; }

        [Browsable(false)]
        [XmlElement("Type")]
        public LicenseTypes Type { get; set; }

        [Browsable(false)]
        [XmlElement("CreateDateTime")]
        public DateTime CreateDateTime { get; set; }

    }
}
