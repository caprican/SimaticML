using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.InstanceSupervisions
{
    [Serializable]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class BlockInstSupervisionGroup
    {
        public Multiinstance Multiinstance { get; set; }

        [XmlElement("BlockInstSupervision")]
        public BlockInstSupervision[] BlockInstSupervision { get; set; }
    }
}
