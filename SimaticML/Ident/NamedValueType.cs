using System;
using System.Xml.Serialization;

namespace SimaticML.Ident
{
    [Serializable]
    [XmlType(Namespace = "http://www.siemens.com/automation/2010/IECPL")]
    public class NamedValueType : ConstantType
    {
        [XmlAttribute]
        public string NamedValueTypeName { get; set; }

        [XmlAttribute]
        public int NamedValueTypeRefId { get; set; }
    }
}
