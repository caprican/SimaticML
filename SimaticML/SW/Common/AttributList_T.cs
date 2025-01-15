using System;
using System.Xml.Serialization;

namespace SimaticML.SW.Common
{
    /// <remarks>Schema : SW_Common</remarks>
    [Serializable]
    public class AttributList_T
    {
        [XmlElement("BooleanAttribute", typeof(BooleanAttribute_T))]        // A member attribute with a type restriction of boolean
        [XmlElement("IntegerAttribute", typeof(IntegerAttribute_T))]        // A member attribute with a type restriction of integer.
        [XmlElement("RealAttribute", typeof(RealAttribute_T))]              // A member attribute with a type restriction of real.
        [XmlElement("StringAttribute", typeof(StringAttribute_T))]          // A member attribute with a type restriction of string.
        public AttributeBase[] Items { get; set; }
    }

    /// <remarks>Schema : SW_Common_v2</remarks>
    [Serializable]
    public class AttributList_T_v2 : AttributList_T
    {
        [XmlElement("BooleanAttribute", typeof(BooleanAttribute_T_v2))]         // A member attribute with a type restriction of boolean
        [XmlElement("DateAttribute", typeof(DateAttribute_T_v2))]               // A member attribute with a type restriction of date.
        [XmlElement("IntegerAttribute", typeof(IntegerAttribute_T_v2))]         // A member attribute with a type restriction of integer.
        [XmlElement("RealAttribute", typeof(RealAttribute_T_v2))]               // A member attribute with a type restriction of real.
        [XmlElement("StringAttribute", typeof(StringAttribute_T_v2))]           // A member attribute with a type restriction of string.
        public new AttributeBase[] Items { get; set; }
    }
}
