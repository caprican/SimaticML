using System;
using System.Xml.Serialization;

namespace SimaticML.Ident
{
    [Serializable]
    [XmlType(Namespace = "http://www.siemens.com/automation/2010/IECPL")]
    public class DirectTypeType
    {
        [XmlAttribute]
        public TypeDataFormat_T TDF { get; set; }
        [XmlIgnore]
        public bool TDFSpecified { get; set; }

        [XmlAttribute]
        public string TD { get; set; }

        [XmlAttribute]
        public uint TypeRId { get; set; }
    }
}
