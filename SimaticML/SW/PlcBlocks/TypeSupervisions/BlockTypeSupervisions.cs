﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

using SimaticML.SW.Common;

namespace SimaticML.SW.PlcBlocks.TypeSupervisions
{
    [Serializable]
    public class BlockTypeSupervisions : IXmlSerializable, IEnumerable<IBlockTypeSupervision>
    {
        //[XmlElement("BlockTypeSupervision")]
        protected internal IBlockTypeSupervision[] Items { get; set; }
        public IBlockTypeSupervision this[int key] { get => Items[key]; set => Items[key] = value; }

        public XmlSchema GetSchema() => null;

        public void ReadXml(XmlReader reader)
        {
            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var blocks = new List<IBlockTypeSupervision>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch(reader.NamespaceURI)
                    {
                        case "http://www.siemens.com/automation/Openness/SW/BlockTypeSupervisions/v2":
                        case "http://www.siemens.com/automation/Openness/SW/BlockTypeSupervisions/v3":

                            reader.MoveToContent();
                            if(!reader.IsEmptyElement)
                            {
                                reader.Read();
                                
                                while (reader.MoveToContent() == XmlNodeType.Element)
                                {
                                    switch(reader.Name)
                                    {
                                        case "BlockTypeSupervision":
                                            var block = new BlockTypeSupervision_v2();
                                            block.ReadXml(reader);
                                            blocks.Add(block);
                                            break;
                                    }
                                }
                            }

                            if (reader.IsStartElement())
                                reader.Read();
                            else
                                reader.ReadEndElement();
                            break;
                    }
                }
                if (blocks.Count > 0) Items = blocks.ToArray();
            }

            if (reader.IsStartElement())
                reader.Read();
            else
                reader.ReadEndElement();
        }

        public void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<IBlockTypeSupervision> GetEnumerator()
        {
            if (Items is null) yield break;
            foreach (var item in Items)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
