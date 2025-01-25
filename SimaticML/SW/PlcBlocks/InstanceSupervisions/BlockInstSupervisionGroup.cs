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
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public class BlockInstSupervisionGroup : Object_G
    {
        public Multiinstance Multiinstance { get; set; }

        [XmlElement("BlockInstSupervision")]
        public BlockInstSupervision[] BlockInstSupervision { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            if (!reader.IsEmptyElement)
            {
                reader.Read();
                var blocks = new List<BlockInstSupervision>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Multiinstance":
                            Multiinstance = new Multiinstance();
                            Multiinstance.ReadXml(reader);
                            break;
                        case "BlockInstSupervision":
                            var blockInstSupervision = new BlockInstSupervision();
                            blockInstSupervision.ReadXml(reader);
                            blocks.Add(blockInstSupervision);
                            break;
                    }
                }
                if(blocks.Count > 0) BlockInstSupervision = blocks.ToArray();
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
