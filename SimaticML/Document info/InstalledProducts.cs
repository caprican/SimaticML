using System;
using System.Diagnostics;

namespace SimaticML
{
    [Serializable]
    [DebuggerDisplay("{DisplayName} ({DisplayVersion})")]
    public class InstalledProduct
    {
        public string DisplayName { get; set; }

        public string DisplayVersion { get; set; }

        public class OptionPackage : InstalledProduct
        {
        }

        public class Product : InstalledProduct
        {
        }
    }
}
