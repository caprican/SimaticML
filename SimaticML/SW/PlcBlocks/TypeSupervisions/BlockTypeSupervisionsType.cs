using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.TypeSupervisions
{
    /// <remarks>
    /// Schema : SW.PlcBlocks.TypeSupervisions (SW.Common)
    /// </remarks>
    [Serializable]
    public class BlockTypeSupervisionsType : Object_G
    {
        [XmlElement("BlockTypeSupervision")]
        public BlockTypeSupervision[] BlockTypeSupervision { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var blocks = new List<BlockTypeSupervision>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "BlockTypeSupervision":
                            var block = new BlockTypeSupervision();
                            block.ReadXml(reader);
                            blocks.Add(block);
                            break;
                    }
                }
                if (blocks.Count > 0) BlockTypeSupervision = blocks.ToArray();
            }

            if (reader.IsStartElement())
                reader.Read();
            else
                reader.ReadEndElement();
        }

        public override void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
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

        public override void ReadXml(XmlReader reader)
        {
            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var blocks = new List<BlockTypeSupervision_v2>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "BlockTypeSupervision":
                            var block = new BlockTypeSupervision_v2();
                            block.ReadXml(reader);
                            blocks.Add(block);
                            break;
                    }
                }
                if (blocks.Count > 0) BlockTypeSupervision = blocks.ToArray();
            }

            if (reader.IsStartElement())
                reader.Read();
            else
                reader.ReadEndElement();
        }

        public override void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }
}
