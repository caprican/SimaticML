using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace SimaticML.SW.InterfaceSections
{
    /// <remarks>
    /// Schema : SW_InterfaceSections_v2 (SW.Common)
    /// </remarks>
    [Serializable]
    [XmlRoot("Member", Namespace = "", IsNullable = false)]
    public class Member_T
    {
        public Member_T()
        {
            Remanence = Remanence_TE.NonRetain;
            Accessibility = Accessibility_TE.Public;
            Informative = false;
        }

        [XmlArrayItem("BooleanAttribute", typeof(Common.BooleanAttribute_T), IsNullable = false)]
        [XmlArrayItem("IntegerAttribute", typeof(Common.IntegerAttribute_T), IsNullable = false)]
        [XmlArrayItem("RealAttribute", typeof(Common.RealAttribute_T), IsNullable = false)]
        [XmlArrayItem("StringAttribute", typeof(Common.StringAttribute_T), IsNullable = false)]
        public Common.AttributeBase[] AttributeList { get; set; }

        [XmlElement("Comment", typeof(Common.Comment_T))]
        [XmlElement("Member", typeof(Member_T))]
        [XmlElement("Sections", typeof(Sections_T))]
        [XmlElement("StartValue", typeof(StartValue_T))]
        [XmlElement("Subelement", typeof(Subelement_T))]
        public object[] Items { get; set; }

        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
        public string Datatype { get; set; }

        /// <summary>
        /// The version of the library type to use. Previous to this, the version was written inside the Datatype attribute itself, like "dtl:v1.0".
        /// Now, this is written in two separate attributes, to mitigate problems with weird names ("dtl:v1.0" could be a UDT name!)
        /// </summary>
        [XmlAttribute]
        public string Version { get; set; }

        [XmlAttribute]
        [DefaultValue(Remanence_TE.NonRetain)]
        public Remanence_TE Remanence { get; set; }

        [XmlAttribute]
        [DefaultValue(Accessibility_TE.Public)]
        public Accessibility_TE Accessibility { get; set; }

        [XmlAttribute]
        [DefaultValue(false)]
        public bool Informative { get; set; }
    }

    /// <remarks>
    /// Schema : SW_InterfaceSections_v3 (SW.Common_v2)
    ///          SW_InterfaceSections_v4 (SW.Common_v3)
    /// </remarks>
    [Serializable]
    [XmlRoot("Member", Namespace = "", IsNullable = false)]
    public class Member_T_v3 : Member_T
    {
        [XmlArrayItem("BooleanAttribute", typeof(Common.BooleanAttribute_T_v2), IsNullable = false)]
        [XmlArrayItem("DateAttribute", typeof(Common.DateAttribute_T_v2), IsNullable = false)]
        [XmlArrayItem("IntegerAttribute", typeof(Common.IntegerAttribute_T_v2), IsNullable = false)]
        [XmlArrayItem("RealAttribute", typeof(Common.RealAttribute_T_v2), IsNullable = false)]
        [XmlArrayItem("StringAttribute", typeof(Common.StringAttribute_T_v2), IsNullable = false)]
        public new Common.AttributeBase[] AttributeList { get; set; }

        [XmlElement("Comment", typeof(Common.Comment_T_v2))]
        [XmlElement("Member", typeof(Member_T_v3))]
        [XmlElement("Sections", typeof(Sections_T_v3))]
        [XmlElement("StartValue", typeof(StartValue_T))]
        [XmlElement("Subelement", typeof(Subelement_T))]
        public new object[] Items { get; set; }
    }

    /// <remarks>
    /// Schema : SW_InterfaceSections_v5 (SW.Common_v3)
    /// </remarks>
    [Serializable]
    [XmlRoot("Member", Namespace = "", IsNullable = false)]
    public class Member_T_v5 : Member_T_v3
    {
        [XmlElement("AssignedProDiagFB", typeof(string))]
        [XmlElement("Comment", typeof(Common.Comment_T_v2))]
        [XmlElement("Member", typeof(Member_T_v5))]
        [XmlElement("Sections", typeof(Sections_T_v5))]
        [XmlElement("StartValue", typeof(StartValue_T))]
        [XmlElement("Subelement", typeof(Subelement_T_v5))]
        public new object[] Items { get; set; }
    }
}
