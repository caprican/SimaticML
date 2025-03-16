using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.InstanceSupervisions
{
    public interface IBlockInstSupervisionGroupsType : IEnumerable<IBlockInstSupervisionGroup>
    {
        
    }

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
    public class BlockInstSupervisionGroupsType_T : Object_G, IBlockInstSupervisionGroupsType
    {
        [XmlElement("BlockInstSupervisionGroup")]
        protected internal IBlockInstSupervisionGroup[] BlockInstSupervisionGroup { get; set; }
        public IBlockInstSupervisionGroup this[int key] { get => BlockInstSupervisionGroup[key]; set => BlockInstSupervisionGroup[key] = value; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    default:
                        reader.Skip();
                        break;
                }
            }

            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var blocks = new List<IBlockInstSupervisionGroup>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "BlockInstSupervisionGroup":
                            var block = new BlockInstSupervisionGroup_T();
                            block.ReadXml(reader);
                            blocks.Add(block);
                            break;

                        default:
                            reader.Skip();
                            break;
                    }
                }
                if(blocks.Count > 0) BlockInstSupervisionGroup = blocks.ToArray();
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

        public IEnumerator<IBlockInstSupervisionGroup> GetEnumerator()
        {
            if (BlockInstSupervisionGroup is null) yield break;
            foreach (var blockGroup in BlockInstSupervisionGroup)
            {
                yield return blockGroup;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
