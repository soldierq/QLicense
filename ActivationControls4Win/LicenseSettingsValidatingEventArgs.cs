using QLicense;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivationControls4Win
{
    public class LicenseSettingsValidatingEventArgs:EventArgs
    {
        public LicenseEntity License { get; set; }
        public bool CancelGenerating { get; set; }
    }
}
