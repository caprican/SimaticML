using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

using SimaticML.SW;

namespace SimaticML
{
    [Serializable]
    public class NetworkSource_T : IXmlSerializable, IEnumerable<Object_G>
    {
        protected internal Object_G[] Items { get; set; }
        public Object_G this[int key] { get => Items[key]; set => Items[key] = value; }

        public XmlSchema GetSchema() => null;

        public void ReadXml(XmlReader reader)
        {
            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var items = new List<Object_G>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch(reader.Name)
                    {
                        case "StatementList":
                            var stl = new SW.PlcBlocks.STL.StatementList_T();
                            stl.ReadXml(reader);
                            items.Add(stl);
                            break;
                        default:
                            switch (reader.NamespaceURI)
                            {
                                case "http://www.siemens.com/automation/Openness/SW/NetworkSource/FlgNet":
                                    var flgNet = new SW.PlcBlocks.LADFBD.FlgNet_T();
                                    flgNet.ReadXml(reader);
                                    items.Add(flgNet);
                                    break;
                                case "http://www.siemens.com/automation/Openness/SW/NetworkSource/FlgNet/v2":
                                    var flgNet_v2 = new SW.PlcBlocks.LADFBD.FlgNet_T_v2();
                                    flgNet_v2.ReadXml(reader);
                                    items.Add(flgNet_v2);
                                    break;
                                case "http://www.siemens.com/automation/Openness/SW/NetworkSource/FlgNet/v3":
                                    var flgNet_v3 = new SW.PlcBlocks.LADFBD.FlgNet_T_v3();
                                    flgNet_v3.ReadXml(reader);
                                    items.Add(flgNet_v3);
                                    break;
                                case "http://www.siemens.com/automation/Openness/SW/NetworkSource/FlgNet/v4":
                                    var flgNet_v4 = new SW.PlcBlocks.LADFBD.FlgNet_T_v4();
                                    flgNet_v4.ReadXml(reader);
                                    items.Add(flgNet_v4);
                                    break;
                                case "http://www.siemens.com/automation/Openness/SW/NetworkSource/FlgNet/v5":
                                    var flgNet_v5 = new SW.PlcBlocks.LADFBD.FlgNet_T_v5();
                                    flgNet_v5.ReadXml(reader);
                                    items.Add(flgNet_v5);
                                    break;

                                case "http://www.siemens.com/automation/Openness/SW/NetworkSource/StructuredText":
                                    var structuredText = new SW.PlcBlocks.SCL.StructuredText_T();
                                    structuredText.ReadXml(reader);
                                    items.Add(structuredText);
                                    break;
                                case "http://www.siemens.com/automation/Openness/SW/NetworkSource/StructuredText/v2":
                                    var structuredText_v2 = new SW.PlcBlocks.SCL.StructuredText_T_v2();
                                    structuredText_v2.ReadXml(reader);
                                    items.Add(structuredText_v2);
                                    break;
                                case "http://www.siemens.com/automation/Openness/SW/NetworkSource/StructuredText/v3":
                                    var structuredText_v3 = new SW.PlcBlocks.SCL.StructuredText_T_v3();
                                    structuredText_v3.ReadXml(reader);
                                    items.Add(structuredText_v3);
                                    break;
                                case "http://www.siemens.com/automation/Openness/SW/NetworkSource/StructuredText/v4":
                                    var structuredText_v4 = new SW.PlcBlocks.SCL.StructuredText_T_v4();
                                    structuredText_v4.ReadXml(reader);
                                    items.Add(structuredText_v4);
                                    break;

                                case "http://www.siemens.com/automation/Openness/SW/NetworkSource/Graph":
                                    var graph = new SW.PlcBlocks.Graph.Graph_T();
                                    graph.ReadXml(reader);
                                    items.Add(graph);
                                    break;
                                case "http://www.siemens.com/automation/Openness/SW/NetworkSource/Graph/v2":
                                    var graph_v2 = new SW.PlcBlocks.Graph.Graph_T_v2();
                                    graph_v2.ReadXml(reader);
                                    items.Add(graph_v2);
                                    break;
                                case "http://www.siemens.com/automation/Openness/SW/NetworkSource/Graph/v4":
                                    var graph_v4 = new SW.PlcBlocks.Graph.Graph_T_v4();
                                    graph_v4.ReadXml(reader);
                                    items.Add(graph_v4);
                                    break;
                                case "http://www.siemens.com/automation/Openness/SW/NetworkSource/Graph/v5":
                                    var graph_v5 = new SW.PlcBlocks.Graph.Graph_T_v5();
                                    graph_v5.ReadXml(reader);
                                    items.Add(graph_v5);
                                    break;
                                case "http://www.siemens.com/automation/Openness/SW/NetworkSource/Graph/v6":
                                    var graph_v6 = new SW.PlcBlocks.Graph.Graph_T_v6();
                                    graph_v6.ReadXml(reader);
                                    items.Add(graph_v6);
                                    break;

                                default:
                                    reader.Skip();
                                    break;
                            }
                            break;
                    }
                }
                if (items.Count > 0) Items = items.ToArray();
            }

            if (reader.IsStartElement())
                reader.Skip();
            else
                reader.ReadEndElement();
        }

        public void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Object_G> GetEnumerator()
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
