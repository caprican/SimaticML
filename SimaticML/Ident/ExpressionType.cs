using System;
using System.Xml.Serialization;

namespace SimaticML.Ident
{
    [Serializable]
    [XmlType(Namespace = "http://www.siemens.com/automation/2010/IECPL")]
    public class ExpressionType
    {
        [XmlAttribute]
        public TypeDataFormat_T TDF { get; set; }
        [XmlIgnore]
        public bool TDFSpecified { get; set; }

        [XmlAttribute]
        public string TD { get; set; }

        [XmlAttribute]
        public int SCL_UId { get; set; }

        [XmlAttribute]
        public int ConstantValue { get; set; }
        [XmlIgnore]
        public bool ConstantValueSpecified { get; set; }

        [XmlAttribute]
        public string Type { get; set; }

        [XmlAttribute]
        public string TypeName { get; set; }

        [XmlAttribute]
        public int RId { get; set; }
    }
}
