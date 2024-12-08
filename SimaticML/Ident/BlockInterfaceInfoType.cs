using System;
using System.Xml.Serialization;

namespace SimaticML.Ident
{
    [Serializable]
    [XmlType(Namespace = "http://www.siemens.com/automation/2010/IECPL")]
    public class BlockInterfaceInfoType
    {
        [XmlElement("Parameter")]
        public ParameterType[] Parameter { get; set; }

        public IdentType Ident { get; set; }

        [XmlAttribute]
        public string ParameterModifiedTS { get; set; }

        [XmlAttribute]
        public string StructureModifiedTS { get; set; }

        [XmlAttribute]
        public string CreationId { get; set; }

        [XmlAttribute]
        public string BlockType { get; set; }
    }
}
