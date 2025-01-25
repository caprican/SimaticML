using System;
using System.Collections.Generic;
using System.Xml;
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
    [XmlRoot("BlockInstSupervisionGroups", IsNullable = false)]
    public class BlockInstSupervisionGroupsType : Object_G
    {
        [XmlElement("BlockInstSupervisionGroup")]
        public BlockInstSupervisionGroup[] BlockInstSupervisionGroup { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var blocks = new List<BlockInstSupervisionGroup>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "BlockInstSupervisionGroup":
                            var block = new BlockInstSupervisionGroup();
                            block.ReadXml(reader);
                            break;
                    }
                }
                if(blocks.Count > 0) BlockInstSupervisionGroup = blocks.ToArray();
            }
            reader.ReadEndElement();
            throw new NotImplementedException();
        }

        public override void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }
}
