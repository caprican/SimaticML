using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SimaticML.SW.InterfaceSections
{
    /// <remarks>
    /// Schema : SW_InterfaceSections_v2 (SW.Common)
    /// </remarks>
    [Serializable]
    [DebuggerDisplay("{Name}")]
    [XmlRoot("Section", Namespace = "", IsNullable = false)]
    public class Section_T
    {
        /// <summary>
        /// Base Class
        /// </summary>
        public Sections_T Sections { get; set; }

        [XmlElement("Member")]
        public Member_T[] Member { get; set; }

        [XmlAttribute]
        public Common.SectionName_TE Name { get; set; }
    }

    /// <remarks>
    /// Schema : SW_InterfaceSections_v3 (SW.Common_v2)
    ///          SW_InterfaceSections_v4 (SW.Common_v3)
    /// </remarks>
    [Serializable]
    [DebuggerDisplay("{Name}")]
    [XmlRoot("Section", Namespace = "", IsNullable = false)]
    public class Section_T_v3 : Section_T
    {
        /// <summary>
        /// Base Class
        /// </summary>
        public new Sections_T_v3 Sections { get; set; }

        [XmlElement("Member")]
        public new Member_T_v3[] Member { get; set; }
    }

    /// <remarks>
    /// Schema : SW_InterfaceSections_v5 (SW.Common_v3)
    /// </remarks>
    [Serializable]
    [DebuggerDisplay("{Name}")]
    [XmlRoot("Section", Namespace = "", IsNullable = false)]
    public class Section_T_v5 : Section_T_v3
    {
        /// <summary>
        /// Base Class
        /// </summary>
        public new Sections_T_v5 Sections { get; set; }

        [XmlElement("Member")]
        public new Member_T_v5[] Member { get; set; }
    }
}
