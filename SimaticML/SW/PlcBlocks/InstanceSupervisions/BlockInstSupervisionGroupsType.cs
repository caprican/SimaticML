using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.InstanceSupervisions
{
    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.InstanceSupervisions => SW.Common</item>
    /// <item>SW.PlcBlocks.InstanceSupervisions_v2 => SW.Common_v2</item>
    /// <item>SW.PlcBlocks.InstanceSupervisions_v3 => SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("BlockInstSupervisionGroups", Namespace = "", IsNullable = false)]
    public class BlockInstSupervisionGroupsType
    {
        [XmlElement("BlockInstSupervisionGroup")]
        public BlockInstSupervisionGroup[] BlockInstSupervisionGroup { get; set; }
    }
}
