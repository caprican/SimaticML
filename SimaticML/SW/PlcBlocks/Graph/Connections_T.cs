using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Graph
{
    [Serializable]
    [XmlRoot("Connections", Namespace = "", IsNullable = false)]
    public class Connections_T
    {
        [XmlElement("Connection")]
        public Connection_T[] Connection { get; set; }
    }

}
