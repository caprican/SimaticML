using System;
using System.Xml.Serialization;

namespace SimaticML.Ident
{
    [Serializable]
    [XmlType(Namespace = "http://www.siemens.com/automation/2010/IECPL")]
    public class Location_Type
    {
        [XmlAttribute(DataType = "integer")]
        public string NetId { get; set; }

        [XmlAttribute(DataType = "integer")]
        public string UId { get; set; }
    }
}
