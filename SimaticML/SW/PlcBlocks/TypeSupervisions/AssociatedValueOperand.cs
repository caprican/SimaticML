using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.TypeSupervisions
{
    [Serializable]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class AssociatedValueOperand
    {
        [XmlAttribute]
        public int Number { get; set; }

        [XmlAttribute]
        public string Name { get; set; }
    }
}
