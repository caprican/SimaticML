using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.TypeSupervisions
{
    [Serializable]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class AssociatedValues
    {
        [XmlElement("AssociatedValue")]
        public AssociatedValue[] AssociatedValue { get; set; }
    }
}
