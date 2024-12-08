using System;
using System.Xml.Serialization;

namespace SimaticML.Ident
{
    [Serializable]
    [XmlType(Namespace = "http://www.siemens.com/automation/2010/IECPL")]
    public class TemplateParameterInfoType
    {
        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute(DataType = "integer")]
        public string Min { get; set; }

        [XmlAttribute(DataType = "integer")]
        public string Max { get; set; }

        [XmlAttribute]
        public string Type { get; set; }

        [XmlAttribute]
        public string Pos { get; set; }

        [XmlAttribute]
        public string Visible { get; set; }
    }
}
