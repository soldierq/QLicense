using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace QLicense
{
    public abstract class LicenseEntity
    {
        [BrowsableAttribute(false)]
        public string RSAPubKey { get; set; }


        [BrowsableAttribute(false)]
        [XmlElementAttribute("CreateDateTime")]
        public string CreateDateTime { get; protected set; }
    }
}
