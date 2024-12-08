using System;
using System.Xml.Serialization;

namespace SimaticML.SW.InterfaceSections
{
    [Serializable]
    public class Sections_T
    {
        [XmlArrayItem("BooleanAttribute", typeof(Common.BooleanAttribute_T), IsNullable = false)]
        [XmlArrayItem("IntegerAttribute", typeof(Common.IntegerAttribute_T), IsNullable = false)]
        [XmlArrayItem("RealAttribute", typeof(Common.RealAttribute_T), IsNullable = false)]
        [XmlArrayItem("StringAttribute", typeof(Common.StringAttribute_T), IsNullable = false)]
        public Common.AttributeBase[] AttributeList { get; set; }

        [XmlElement("Section")]
        public Section_T[] Section { get; set; }

        [XmlAttribute]
        public string Datatype { get; set; }

        [XmlAttribute]
        public string Version { get; set; }
    }
}
