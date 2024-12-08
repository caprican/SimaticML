using System;
using System.Xml.Serialization;

namespace SimaticML.Ident
{
    [Serializable]
    [XmlType(Namespace = "http://www.siemens.com/automation/2010/IECPL")]
    public class AccessObjectType
    {
        [XmlElement("Ident")]
        public IdentType[] Ident { get; set; }

        [XmlAttribute]
        public TypeDataFormat_T TDF { get; set; }
        [XmlIgnore]
        public bool TDFSpecified { get; set; }

        [XmlAttribute]
        public string TD { get; set; }

        [XmlAttribute]
        public TypeDataFormat_T ATDF { get; set; }
        [XmlIgnore]
        public bool ATDFSpecified { get; set; }

        [XmlAttribute]
        public string ATD { get; set; }

        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
        public string Type { get; set; }

        [XmlAttribute]
        public string ArrayType { get; set; }

        [XmlAttribute]
        public string DerefFlags { get; set; }
    }
}
