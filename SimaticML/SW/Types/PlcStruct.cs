using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace SimaticML.SW.Types
{
    [Serializable]
    [XmlType(AnonymousType = true)]
    public class PlcStruct : Object_T
    {
        public new AttributeList_T AttributeList { get; set; }

        public class AttributeList_T : AttributeList_G
        {
            public AttributeList_T() : base()
            {
                InstanceOfName = "";
                OfSystemLibElement = "";
                OfSystemLibVersion = "";
            }

            [DefaultValue("")]
            public string InstanceOfName { get; set; }
            [XmlIgnore]
            public bool InstanceOfNameSpecified { get; set; }

            public ushort InstanceOfNumber { get; set; }
            [XmlIgnore]
            public bool InstanceOfNumberSpecified { get; set; }

            public InstanceOfType_TE InstanceOfType { get; set; }

            [DefaultValue("")]
            public string OfSystemLibElement { get; set; }
            [XmlIgnore]
            public bool OfSystemLibElementSpecified { get; set; }

            [DefaultValue("")]
            public string OfSystemLibVersion { get; set; }
            [XmlIgnore]
            public string OfSystemLibVersionSpecified { get; set; }

            public string LibraryConformanceStatus { get; set; }
            [XmlIgnore]
            public bool LibraryConformanceStatusSpecified { get; set; }
        }
    }
}
