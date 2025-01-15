using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.TypeSupervisions
{
    /// <remarks>
    /// Schema : SW.PlcBlocks.TypeSupervisions (SW.Common)
    /// </remarks>
    [Serializable]
    public class BlockTypeSupervisionsType
    {
        [XmlElement("BlockTypeSupervision")]
        public BlockTypeSupervision[] BlockTypeSupervision { get; set; }
    }

    /// <remarks>
    /// Schema : SW.PlcBlocks.TypeSupervisions_v2 (SW.Common_v2)
    ///          SW.PlcBlocks.TypeSupervisions_v3 (SW.Common_v3)
    /// </remarks>
    [Serializable]
    public class BlockTypeSupervisionsType_v2 : BlockTypeSupervisionsType
    {
        [XmlElement("BlockTypeSupervision")]
        public new BlockTypeSupervision_v2[] BlockTypeSupervision { get; set; }
    }
}
