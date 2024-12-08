using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace SimaticML.SW.Blocks
{
    [Serializable]
    [XmlType(AnonymousType = true)]
    public class FC : Object_T
    {
        public AttributeFC AttributeList { get; set; }

        public class AttributeFC : AttributeList_G
        {
            public AttributeFC() : base()
            {
                ParameterPassing = false;
                UDABlockProperties = "";
                UDAEnableTagReadback = false;
                HandleErrorsWithinBlock = false;

                CheckArrayLimits = false;
                ExtendedStatus = false;
                DBAccessibleFromOPCUA = true;
            }

            public string LibraryType { get; set; }
            [XmlIgnore]
            public bool LibraryTypeSpecified { get; set; }

            public string LibraryTypeVersionGuid { get; set; }
            [XmlIgnore]
            public bool LibraryTypeVersionGuidSpecified { get; set; }

            [DefaultValue(false)]
            public bool ParameterPassing { get; set; }
            [XmlIgnore]
            public bool ParameterPassingSpecified { get; set; }

            [DefaultValue("")]
            public string UDABlockProperties { get; set; }
            [XmlIgnore]
            public bool UDABlockPropertiesSpecified { get; set; }

            [DefaultValue(false)]
            public bool UDAEnableTagReadback { get; set; }
            [XmlIgnore]
            public bool UDAEnableTagReadbackSpecified { get; set; }

            [DefaultValue(false)]
            public bool HandleErrorsWithinBlock { get; set; }
            [XmlIgnore]
            public bool HandleErrorsWithinBlockSpecified { get; set; }

            public string LibraryConformanceStatus { get; set; }
            [XmlIgnore]
            public bool LibraryConformanceStatusSpecified { get; set; }

            [DefaultValue(false)]
            public bool CheckArrayLimits { get; set; }
            [XmlIgnore]
            public bool CheckArrayLimitsSpecified { get; set; }

            [DefaultValue(false)]
            public bool ExtendedStatus { get; set; }
            [XmlIgnore]
            public bool ExtendedStatusSpecified { get; set; }

            [DefaultValue(true)]
            public bool DBAccessibleFromOPCUA { get; set; }
            [XmlIgnore]
            public bool DBAccessibleFromOPCUASpecified { get; set; }

            public bool SetENOAutomatically { get; set; }
            [XmlIgnore]
            public bool SetENOAutomaticallySpecified { get; set; }
        }
    }
}
