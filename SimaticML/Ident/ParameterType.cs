using System;
using System.Xml.Serialization;

namespace SimaticML.Ident
{
    [Serializable]
    [XmlType(Namespace = "http://www.siemens.com/automation/2010/IECPL")]
    public class ParameterType
    {
        [XmlAttribute]
        public TypeDataFormat_T TDF { get; set; }
        [XmlIgnore()]
        public bool TDFSpecified { get; set; }

        [XmlAttribute]
        public string TD { get; set; }

        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
        public string Section { get; set; }

        [XmlAttribute]
        public string Area { get; set; }

        [XmlAttribute]
        public string Type { get; set; }

        [XmlAttribute]
        public string InterfaceFlags { get; set; }
    }
}
