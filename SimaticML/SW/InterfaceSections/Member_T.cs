using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.InterfaceSections
{
    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_InterfaceSections_v2 => SW.Common</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Member", Namespace = "", IsNullable = false)]
    public class Member_T
    {
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
        public Remanence_TE Remanence { get; set; } = Remanence_TE.NonRetain;

        [XmlAttribute]
        [DefaultValue(Accessibility_TE.Public)]
        public Accessibility_TE Accessibility { get; set; } = Accessibility_TE.Public;

        [XmlAttribute]
        [DefaultValue(false)]
        public bool Informative { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_InterfaceSections_v3 => SW.Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Member", Namespace = "http://www.siemens.com/automation/Openness/SW/Interface/v3", IsNullable = false)]
    [DebuggerDisplay("{Name}")]
    public class Member_T_v3 : Member_T
    {
        [XmlArray("AttributeList")]
        [XmlArrayItem("BooleanAttribute", typeof(Common.BooleanAttribute_T_v2), IsNullable = false)]
        [XmlArrayItem("DateAttribute", typeof(Common.DateAttribute_T_v2), IsNullable = false)]
        [XmlArrayItem("IntegerAttribute", typeof(Common.IntegerAttribute_T_v2), IsNullable = false)]
        [XmlArrayItem("RealAttribute", typeof(Common.RealAttribute_T_v2), IsNullable = false)]
        [XmlArrayItem("StringAttribute", typeof(Common.StringAttribute_T_v2), IsNullable = false)]
        public new Common.AttributeBase[] Attributes { get; set; }

        public new Common.Comment_T_v2 Comment { get; set; }

        [XmlElement("Comment", typeof(Common.Comment_T_v2))]
        [XmlElement("Member", typeof(Member_T_v3))]
        [XmlElement("Sections", typeof(Sections_T_v3))]
        [XmlElement("StartValue", typeof(StartValue_T))]
        [XmlElement("Subelement", typeof(Subelement_T))]
        public new object[] Items { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_InterfaceSections_v5 => SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Member", Namespace = "http://www.siemens.com/automation/Openness/SW/Interface/v5", IsNullable = false)]
    [DebuggerDisplay("{Name}")]
    public class Member_T_v5 : Member_T_v4
    {
        [XmlElement("AssignedProDiagFB", typeof(string))]
        [XmlElement("Member", typeof(Member_T_v5))]
        [XmlElement("Sections", typeof(Sections_T_v5))]
        [XmlElement("StartValue", typeof(StartValue_T))]
        [XmlElement("Subelement", typeof(Subelement_T_v5))]
        public new object[] Items { get; set; }
    }
}
