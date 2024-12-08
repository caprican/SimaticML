using System;
using System.Xml.Serialization;

namespace SimaticML.Ident
{
    [Serializable]
    [XmlType(Namespace = "http://www.siemens.com/automation/2010/IECPL")]
    public class LibraryParameterType
    {
        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
        public string Section { get; set; }

        [XmlAttribute]
        public string Type { get; set; }

        [XmlAttribute]
        public string TemplateReference { get; set; }

        [XmlAttribute]
        public string TemplateCardinality { get; set; }

        [XmlAttribute]
        public string InterfaceFlags { get; set; }
    }
}
