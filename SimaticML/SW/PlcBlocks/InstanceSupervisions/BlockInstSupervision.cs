using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.InstanceSupervisions
{
    [Serializable]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class BlockInstSupervision
    {
        public int Number { get; set; }

        public StateStruct StateStruct { get; set; }

        public int BlockTypeSupervisionNumber { get; set; }
    }
}
