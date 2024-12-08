using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.TypeSupervisions
{
    [Serializable]
    public class BlockTypeSupervisionsType
    {
        [XmlElement("BlockTypeSupervision")]
        public BlockTypeSupervision[] BlockTypeSupervision { get; set; }
    }
}
