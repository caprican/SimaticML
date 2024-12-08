using System;
using System.Xml.Serialization;

namespace SimaticML
{
    [Serializable]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class Document
    {
        public Engineering Engineering { get; set; }

        public DocumentInfo DocumentInfo { get; set; }

        //[XmlElement("SW.Blocks.OB", typeof(SW.Blocks.OB))]
        [XmlElement("SW.Blocks.FC", typeof(SW.Blocks.FC))]
        [XmlElement("SW.Blocks.FB", typeof(SW.Blocks.FB))]
        [XmlElement("SW.Blocks.GlobalDB", typeof(SW.Blocks.GlobalDB))]
        //[XmlElement("SW.Blocks.InstanceDB", typeof(SW.Blocks.InstanceDB))]
        //[XmlElement("SW.Blocks.ArrayDB", typeof(SW.Blocks.ArrayDB))]

        //[XmlElement("SW.Tags.PlcTagTable", typeof(SW.Tags.PlcTagTable))]
        //[XmlElement("SW.Types.PlcStruct", typeof(SW.Types.PlcStruct))]

        //[XmlElement("SW.WatchAndForceTables.PlcWatchTable", typeof(SW.WatchAndForceTables.PlcWatchTable))]
        public Object_T[] Items { get; set; }
    }
}
