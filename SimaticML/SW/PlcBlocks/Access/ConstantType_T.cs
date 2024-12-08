using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Access
{
    [Serializable]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class ConstantType
    {
        [XmlAttribute]
        public bool Informative { get; set; }
        [XmlIgnore]
        public bool InformativeSpecified { get; set; }

        [XmlText]
        public string Value { get; set; }

        /// <remarks> Add on v2</remarks>
        [XmlAttribute]
        public int UId { get; set; }
        [XmlIgnore]
        public bool UIdSpecified { get; set; }
    }
}
