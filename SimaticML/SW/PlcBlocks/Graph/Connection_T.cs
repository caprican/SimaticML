using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Graph
{
    [Serializable]
    [XmlRoot("Connection", Namespace = "", IsNullable = false)]
    public class Connection_T
    {
        public Node_T NodeFrom { get; set; }

        public Node_T NodeTo { get; set; }

        public Link_TE LinkType { get; set; }
    }
}
