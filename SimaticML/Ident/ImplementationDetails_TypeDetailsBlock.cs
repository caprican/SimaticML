using System;
using System.Xml.Serialization;

namespace SimaticML.Ident
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://www.siemens.com/automation/2010/IECPL")]
    public class ImplementationDetails_TypeDetailsBlock
    {
        [XmlAttribute(DataType = "integer")]
        public string Number { get; set; }

        [XmlAttribute]
        public string OrigPartName { get; set; }
    }
}
