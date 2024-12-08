using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SimaticML.SW.InterfaceSections
{
    [Serializable]
    [DebuggerDisplay("{Name}")]
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
}
