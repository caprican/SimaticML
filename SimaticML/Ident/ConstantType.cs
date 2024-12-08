using System;
using System.Xml.Serialization;

namespace SimaticML.Ident
{
    [XmlInclude(typeof(NamedValueType))]
    [Serializable]
    [XmlType(Namespace = "http://www.siemens.com/automation/2010/IECPL")]
    public class ConstantType
    {
        [XmlAttribute]
        public TypeDataFormat_T TDF { get; set; }
        [XmlIgnore]
        public bool TDFSpecified { get; set; }

        [XmlAttribute]
        public string TD { get; set; }

        [XmlAttribute]
        public string Type { get; set; }

        [XmlAttribute]
        public string TypeName { get; set; }

        [XmlAttribute]
        public int RId { get; set; }

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
