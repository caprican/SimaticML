using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.InstanceSupervisions
{
    [Serializable]
    [XmlRoot("BlockInstSupervisionGroups", Namespace = "", IsNullable = false)]
    public class BlockInstSupervisionGroupsType
    {
        [XmlElement("BlockInstSupervisionGroup")]
        public BlockInstSupervisionGroup[] BlockInstSupervisionGroup { get; set; }
    }
}
