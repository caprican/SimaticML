using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.TypeSupervisions
{
    [Serializable]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class SpecificField
    {
        [XmlArrayItem("AssociatedValue", IsNullable = false)]
        public AssociatedValue[] AssociatedValues { get; set; }

        public SpecificFieldText SpecificFieldText { get; set; }
    }
}
