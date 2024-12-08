using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Graph
{
    [Serializable]
    [XmlRoot("Steps", Namespace = "", IsNullable = false)]
    public class Steps_T
    {
        [XmlElement("Step")]
        public Step_T[] Step { get; set; }
    }
}
