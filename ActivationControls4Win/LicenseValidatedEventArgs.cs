using QLicense;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivationControls4Win
{
    public class LicenseValidatedEventArgs : EventArgs
    {
        public LicenseEntity License { get; set; }

        public LicenseStatus ValidationStatus { get; set; }

        public bool CustomizedValidationFailed { get; set; }

        public LicenseValidatedEventArgs()
        {
            CustomizedValidationFailed = false;
        }
    }
}
