using System;
using System.Xml.Serialization;

namespace SimaticML.Ident
{
    [Serializable]
    [XmlType(Namespace = "http://www.siemens.com/automation/2010/IECPL")]
    public class ImplementationDetails_Type
    {
        public ImplementationDetails_TypeDetailsBlock DetailsBlock { get; set; }

        [XmlAttribute]
        public string Type { get; set; }
    }
}
