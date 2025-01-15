using System;
using System.Xml.Serialization;

namespace SimaticML.SW.InterfaceSections
{
    /// <remarks>
    /// Schema : SW_InterfaceSections_v2 (SW.Common)
    /// </remarks>
    [Serializable]
    [XmlRoot("Sections", Namespace = "", IsNullable = false)]
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

    /// <remarks>
    /// Schema : SW_InterfaceSections_v3 (SW.Common_v2)
    ///          SW_InterfaceSections_v4 (SW.Common_v3)
    /// </remarks>
    [Serializable]
    [XmlRoot("Sections", Namespace = "", IsNullable = false)]
    public class Sections_T_v3 : Sections_T
    {
        [XmlArrayItem("BooleanAttribute", typeof(Common.BooleanAttribute_T_v2), IsNullable = false)]
        [XmlArrayItem("DateAttribute", typeof(Common.DateAttribute_T_v2), IsNullable = false)]
        [XmlArrayItem("IntegerAttribute", typeof(Common.IntegerAttribute_T_v2), IsNullable = false)]
        [XmlArrayItem("RealAttribute", typeof(Common.RealAttribute_T_v2), IsNullable = false)]
        [XmlArrayItem("StringAttribute", typeof(Common.StringAttribute_T_v2), IsNullable = false)]
        public new Common.AttributeBase[] AttributeList { get; set; }

        [XmlElement("Section")]
        public new Section_T_v3[] Section { get; set; }
    }

    /// <remarks>
    /// Schema : SW_InterfaceSections_v5 (SW.Common_v3)
    /// </remarks>
    [Serializable]
    [XmlRoot("Sections", Namespace = "", IsNullable = false)]
    public class Sections_T_v5 : Sections_T_v3
    {
        [XmlArrayItem("BooleanAttribute", typeof(Common.BooleanAttribute_T_v2), IsNullable = false)]
        [XmlArrayItem("DateAttribute", typeof(Common.DateAttribute_T_v2), IsNullable = false)]
        [XmlArrayItem("IntegerAttribute", typeof(Common.IntegerAttribute_T_v2), IsNullable = false)]
        [XmlArrayItem("RealAttribute", typeof(Common.RealAttribute_T_v2), IsNullable = false)]
        [XmlArrayItem("StringAttribute", typeof(Common.StringAttribute_T_v2), IsNullable = false)]
        public new Common.AttributeBase[] AttributeList { get; set; }

        [XmlElement("Section")]
        public new Section_T_v5[] Section { get; set; }
    }
}
