using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.TypeSupervisions
{
    [Serializable]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class Condition
    {
        public ConditionOperand ConditionOperand { get; set; }

        public bool TriggeringStatus { get; set; }
    }
}
