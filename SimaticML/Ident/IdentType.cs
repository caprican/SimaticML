using System;
using System.Xml.Serialization;

namespace SimaticML.Ident
{
    [Serializable()]
    [XmlType(Namespace = "http://www.siemens.com/automation/2010/IECPL")]
    [XmlRoot("Ident", Namespace = "http://www.siemens.com/automation/2010/IECPL", IsNullable = false)]
    public class IdentType
    {
        [XmlArrayItem("XRefItem", IsNullable = false)]
        public XRefItemType[] CrossRefInfo { get; set; }

        public AccessType Access { get; set; }

        [XmlAttribute()]
        public string Name { get; set; }

        [XmlAttribute()]
        public string Scope { get; set; }

        [XmlAttribute()]
        public int RefId { get; set; }
        [XmlIgnore()]
        public bool RefIdSpecified { get; set; }

        [XmlAttribute()]
        public string Version { get; set; }

        [XmlAttribute()]
        public string FailSafe { get; set; }

        [XmlAttribute()]
        public long IdentState { get; set; }

        [XmlIgnore()]
        public bool IdentStateSpecified { get; set; }
    }
}
