using System;
using System.Xml.Serialization;

namespace SimaticML.Ident
{
    [Serializable]
    [XmlType(Namespace = "http://www.siemens.com/automation/2010/IECPL")]
    public class NamedValueTypeType
    {
        public NamedValueTypeDefaultValueType DefaultValue { get; set; }

        [XmlAttribute]
        public string Type { get; set; }

        [XmlAttribute]
        public int TypeRId { get; set; }

        [XmlAttribute]
        public string AccessQualifier { get; set; }
    }
}
