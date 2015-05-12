using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace QLicense
{
    public enum LicenseTypes
    {
        [Description("未知")]
        Unknown = 0,
        [Description("单机许可")]
        Single = 1,
        [Description("批量许可")]
        Volume = 2
    }
}
