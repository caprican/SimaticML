using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace SimaticML.SW.Blocks
{
    [Serializable]
    //[XmlType(AnonymousType = true)]
    public class GlobalDB : Object_T
    {
        public AttributeGlobalDB AttributeList { get; set; }

        public class AttributeGlobalDB : AttributeList_G
        {
            public AttributeGlobalDB() : base()
            {
                IsOnlyStoredInLoadMemory = false;
                IsPLCDB = false;

                IsIECCheckEnabled = false;
                IsRetainMemResEnabled = false;
                MemoryReserve = 0;
                RetainMemoryReserve = 0;

                DownloadWithoutReinit = false;

            }

            [DefaultValue(false)]
            public bool IsOnlyStoredInLoadMemory { get; set; }
            [XmlIgnore]
            public bool IsOnlyStoredInLoadMemorySpecified { get; set; }

            [DefaultValue(false)]
            public bool IsPLCDB { get; set; }
            [XmlIgnore]
            public bool IsPLCDBSpecified { get; set; }

            public bool IsWriteProtectedInAS { get; set; }

            [DefaultValue(false)]
            public bool IsIECCheckEnabled { get; set; }

            [DefaultValue(false)]
            public bool IsRetainMemResEnabled { get; set; }

            [DefaultValue(0)]
            public uint MemoryReserve { get; set; }

            [DefaultValue(0)]
            public uint RetainMemoryReserve { get; set; }

            [DefaultValue(false)]
            public bool DownloadWithoutReinit { get; set; }
        }
    }

}
