using System;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace SimaticML
{
    //[Serializable]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class Document //: IXmlSerializable
    {
        public Engineering Engineering { get; set; }

        public DocumentInfo DocumentInfo { get; set; }
        [XmlIgnore]
        public bool DocumentInfoSpecified { get; set; }

        //[XmlElement("SW.Blocks.OB", typeof(SW.Blocks.OB))]
        //[XmlElement("SW.Blocks.FC", typeof(SW.Blocks.FC))]
        //[XmlElement("SW.Blocks.FB", typeof(SW.Blocks.FB))]
        [XmlElement("SW.Blocks.GlobalDB", typeof(SW.Blocks.GlobalDB))]
        //[XmlElement("SW.Blocks.InstanceDB", typeof(SW.Blocks.InstanceDB))]
        //[XmlElement("SW.Blocks.ArrayDB", typeof(SW.Blocks.ArrayDB))]

        //[XmlElement("SW.Tags.PlcTagTable", typeof(SW.Tags.PlcTagTable))]
        //[XmlElement("SW.Types.PlcStruct", typeof(SW.Types.PlcStruct))]

        //[XmlElement("SW.WatchAndForceTables.PlcWatchTable", typeof(SW.WatchAndForceTables.PlcWatchTable))]
        public Object_T[] Items { get; set; }

        //public XmlSchema GetSchema() => null;

        //public void ReadXml(XmlReader reader)
        //{
        //    reader.ReadStartElement();
        //    reader.ReadStartElement("Engineering");
            
        //    //if (reader.Name != "prop")
        //    //{ throw new InvalidOperationException(); }

        //    do
        //    {
        //        if (!reader.MoveToAttribute("name"))
        //        { throw new InvalidOperationException(); }

        //        string name = reader.Value;

        //        if (!reader.MoveToAttribute("value"))
        //        { throw new InvalidOperationException(); }

        //        //switch (name)
        //        //{
        //        //    case "Label": Label = reader.Value; break;
        //        //    case "Enable": Enable = XmlConvert.ToBoolean(reader.Value); break;
        //        //    case "PosX": PosX = XmlConvert.ToInt32(reader.Value); break;
        //        //    case "PosY": PosY = XmlConvert.ToInt32(reader.Value); break;
        //        //}
        //    }
        //    while (reader.ReadToNextSibling("prop"));

        //    reader.ReadEndElement();
        //    reader.ReadEndElement();
        //}

        //public void WriteXml(XmlWriter writer)
        //{
            
        //}
    }
}
