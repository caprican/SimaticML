using System;
using System.Xml.Serialization;

namespace SimaticML.SW.Common
{
    [Serializable]
    //[XmlRoot("AttributeList", Namespace = "", IsNullable = false)]
    public class AttributList_T
    {
        [XmlElement("BooleanAttribute", typeof(BooleanAttribute_T))]        // A member attribute with a type restriction of boolean
        [XmlElement("IntegerAttribute", typeof(IntegerAttribute_T))]        // A member attribute with a type restriction of integer.
        [XmlElement("RealAttribute", typeof(RealAttribute_T))]              // A member attribute with a type restriction of real.
        [XmlElement("StringAttribute", typeof(StringAttribute_T))]          // A member attribute with a type restriction of string.
        public AttributeBase[] Items { get; set; }
    }

}
