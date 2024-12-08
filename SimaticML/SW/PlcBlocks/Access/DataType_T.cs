using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Access
{
    [Serializable]
    [XmlRoot("DataType", Namespace = "", IsNullable = false)]
    public class DataType_T
    {
        [XmlAttribute]
        public bool Informative { get; set; }
        [XmlIgnore]
        public bool InformativeSpecified { get; set; }

        [XmlAttribute]
        public int UId { get; set; }
        [XmlIgnore]
        public bool UIdSpecified { get; set; }

        [XmlText]
        public string Value { get; set; }
    }
}
