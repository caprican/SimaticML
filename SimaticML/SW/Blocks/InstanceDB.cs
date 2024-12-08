using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace SimaticML.SW.Blocks
{
    [Serializable]
    [XmlType(AnonymousType = true)]
    public class InstanceDB : Object_T
    {
        public AttributeIDB AttributeList { get; set; }

        public class AttributeIDB : AttributeList_G
        {
            public AttributeIDB() : base()
            {
                DownloadWithoutReinit = false;
                UDABlockProperties = "";
                UDAEnableTagReadback = false;
                InstanceOfName = "";

                OfSystemLibElement = "";
                OfSystemLibVersion = "";
            }

            [DefaultValue(false)]
            public bool DownloadWithoutReinit { get; set; }
            [XmlIgnore]
            public bool DownloadWithoutReinitSpecified { get; set; }

            [DefaultValue("")]
            public string UDABlockProperties { get; set; }
            [XmlIgnore]
            public bool UDABlockPropertiesSpecified { get; set; }

            [DefaultValue(false)]
            public bool UDAEnableTagReadback { get; set; }
            [XmlIgnore]
            public bool UDAEnableTagReadbackSpecified { get; set; }

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
        }
    }
}
