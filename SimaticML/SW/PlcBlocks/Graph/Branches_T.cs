using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Graph
{
    [Serializable]
    [XmlRoot("Branches", Namespace = "", IsNullable = false)]
    public class Branches_T
    {
        [XmlElement("Branch")]
        public Branch_T[] Branch { get; set; }
    }
}
