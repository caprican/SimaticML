using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace SimaticML
{
    [Serializable]
    //[XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public class Document : IXmlSerializable
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

        public Object_T this[int key] 
        { 
            get => Items[key]; 
            set => Items[key] = value; 
        }

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
                        case "SW.Blocks.GlobalDB":
                            var globalDb = new SW.Blocks.GlobalDB();
                            globalDb.ReadXml(reader);
                            items.Add(globalDb);
                            break;

                        case "SW.Blocks.FB":
                            var fb = new SW.Blocks.FB();
                            fb.ReadXml(reader);
                            items.Add(fb);
                            break;
                    }
                }
                if (items.Count > 0) Items = items.ToArray();
            }
            reader.ReadEndElement();
        }

        public void WriteXml(XmlWriter writer)
        {

        }
    }
}
