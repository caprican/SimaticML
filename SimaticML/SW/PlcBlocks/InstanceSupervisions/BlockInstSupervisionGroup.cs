using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.InstanceSupervisions
{
    public interface IBlockInstSupervisionGroup : IEnumerable<IBlockInstSupervision>
    {
        IMultiinstance Multiinstance { get; set; }
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
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public class BlockInstSupervisionGroup : Object_G, IBlockInstSupervisionGroup
    {
        public IMultiinstance Multiinstance { get; set; }

        //[XmlArray("BlockInstSupervision")]
        //[XmlElement("BlockInstSupervision")]
        protected internal IBlockInstSupervision[] BlockInstSupervisions { get; set; }
        public IBlockInstSupervision this[int key] { get => BlockInstSupervisions[key]; set => BlockInstSupervisions[key] = value; }

        public override void ReadXml(XmlReader reader)
        {
            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();
                var blocks = new List<BlockInstSupervision>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Multiinstance":
                            var multiinstance = new Multiinstance();
                            multiinstance.ReadXml(reader);
                            Multiinstance = multiinstance;
                            break;
                        case "BlockInstSupervision":
                            var blockInstSupervision = new BlockInstSupervision();
                            blockInstSupervision.ReadXml(reader);
                            blocks.Add(blockInstSupervision);
                            break;
                    }
                }
                if(blocks.Count > 0) BlockInstSupervisions = blocks.ToArray();
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

        public IEnumerator<IBlockInstSupervision> GetEnumerator()
        {
            if (BlockInstSupervisions is null) yield break;
            foreach (var block in BlockInstSupervisions)
            {
                yield return block;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
