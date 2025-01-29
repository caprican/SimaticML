using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace SimaticML
{
    [Serializable]
    //[XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public class Document : IXmlSerializable, IEnumerable<Object_T>
    {
        public Engineering Engineering { get; set; }

        public DocumentInfo DocumentInfo { get; set; } = null;
        [XmlIgnore]
        public bool DocumentInfoSpecified { get; set; }

        [XmlElement("SW.Blocks.OB", typeof(SW.Blocks.OB))]
        [XmlElement("SW.Blocks.FC", typeof(SW.Blocks.FC))]
        [XmlElement("SW.Blocks.FB", typeof(SW.Blocks.FB))]
        [XmlElement("SW.Blocks.GlobalDB", typeof(SW.Blocks.GlobalDB))]
        [XmlElement("SW.Blocks.InstanceDB", typeof(SW.Blocks.InstanceDB))]
        [XmlElement("SW.Blocks.ArrayDB", typeof(SW.Blocks.ArrayDB))]

        [XmlElement("SW.Tags.PlcTagTable", typeof(SW.Tags.PlcTagTable))]
        [XmlElement("SW.Types.PlcStruct", typeof(SW.Types.PlcStruct))]

        [XmlElement("SW.WatchAndForceTables.PlcWatchTable", typeof(SW.WatchAndForceTables.PlcWatchTable))]
        private Object_T[] Items { get; set; }

        public Object_T this[int key]  {  get => Items[key];  set => Items[key] = value;  }

        public XmlSchema GetSchema() => null;

        public void ReadXml(XmlReader reader)
        {
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var engSerialize = new XmlSerializer(typeof(Engineering));
                Engineering = engSerialize.Deserialize(reader) as Engineering;
                reader.MoveToContent();

                if(reader.Name == "DocumentInfo")
                {
                    var docSerialize = new XmlSerializer(typeof(DocumentInfo));
                    if (docSerialize.Deserialize(reader) is DocumentInfo documentInfo)
                    {
                        DocumentInfo = documentInfo;
                        DocumentInfoSpecified = true;
                    }
                    else
                    {
                        DocumentInfo = null;
                        DocumentInfoSpecified = false;
                    }
                }
                else
                {
                    DocumentInfo = null;
                    DocumentInfoSpecified = false;
                }

                var items = new List<Object_T>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "SW.Blocks.OB":
                            var ob = new SW.Blocks.OB();
                            ob.ReadXml(reader);
                            items.Add(ob);
                            break;
                        case "SW.Blocks.FC":
                            var fc = new SW.Blocks.FC();
                            fc.ReadXml(reader);
                            items.Add(fc);
                            break;
                        case "SW.Blocks.FB":
                            var fb = new SW.Blocks.FB();
                            fb.ReadXml(reader);
                            items.Add(fb);
                            break;
                        case "SW.Blocks.GlobalDB":
                            var globalDb = new SW.Blocks.GlobalDB();
                            globalDb.ReadXml(reader);
                            items.Add(globalDb);
                            break;
                        case "SW.Blocks.InstanceDB":
                            var instanceDb = new SW.Blocks.InstanceDB();
                            instanceDb.ReadXml(reader);
                            items.Add(instanceDb);
                            break;
                        case "SW.Blocks.ArrayDB":
                            var arrayDb = new SW.Blocks.ArrayDB();
                            arrayDb.ReadXml(reader);
                            items.Add(arrayDb);
                            break;

                        case "SW.Tags.PlcTagTable":
            throw new NotImplementedException();
                            break;

                        case "SW.Types.PlcStruct":
                            var plcStruct = new SW.Types.PlcStruct();
                            plcStruct.ReadXml(reader);
                            items.Add(plcStruct);
                            break;

                        case "SW.WatchAndForceTables.PlcWatchTable":
            throw new NotImplementedException();
                            break;
                    }
                }
                if (items.Count > 0) Items = items.ToArray();
            }
            reader.ReadEndElement();
        }

        public void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Object_T> GetEnumerator()
        {
            foreach (var item in Items)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

    }
}
