using System;
using System.Xml.Serialization;

namespace SimaticML.Ident
{
    [Serializable]
    [XmlType(Namespace = "http://www.siemens.com/automation/2010/IECPL")]
    public class NamedValueTypeDefaultValueType
    {
        [XmlAttribute]
        public string SourceDefaultValue { get; set; }

        [XmlAttribute]
        public string Type { get; set; }

        [XmlAttribute]
        public string Format { get; set; }

        [XmlAttribute]
        public string Value { get; set; }

        [XmlAttribute]
        public string ValueString { get; set; }

        [XmlAttribute]
        public string FormatFlags { get; set; }
    }
}
