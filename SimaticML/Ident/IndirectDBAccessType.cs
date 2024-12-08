using System;
using System.Xml.Serialization;

namespace SimaticML.Ident
{
    [Serializable]
    [XmlType(Namespace = "http://www.siemens.com/automation/2010/IECPL")]
    public class IndirectDBAccessType
    {
        [XmlElement("AccessObject")]
        public AccessObjectType[] AccessObject { get; set; }

        [XmlAttribute]
        public TypeDataFormat_T TDF { get; set; }
        [XmlIgnore]
        public bool TDFSpecified { get; set; }

        [XmlAttribute]
        public string TD { get; set; }

        [XmlAttribute]
        public uint AbsOffset { get; set; }

        [XmlAttribute]
        public string Type { get; set; }

        [XmlAttribute]
        public string TypeName { get; set; }

        [XmlAttribute]
        public int RId { get; set; }
    }
}
