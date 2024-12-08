using System;
using System.Xml.Serialization;

namespace SimaticML.Ident
{
    [Serializable]
    [XmlType(Namespace = "http://www.siemens.com/automation/2010/IECPL")]
    public class DataTypeBlockType : TypeOperandType
    {
        [XmlAttribute]
        public string InterfaceModifiedTS { get; set; }

        [XmlAttribute]
        public string TypeRId { get; set; }
    }
}
