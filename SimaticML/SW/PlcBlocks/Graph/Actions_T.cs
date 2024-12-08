using System;
using System.Xml.Serialization;

using SimaticML.SW.Common;

namespace SimaticML.SW.PlcBlocks.Graph
{
    [Serializable()]
    [XmlRoot("Actions", Namespace = "", IsNullable = false)]
    public class Actions_T
    {
        public Comment_T Title { get; set; }

        [XmlElement("Action")]
        public Action_T[] Action { get; set; }
    }
}
