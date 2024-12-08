using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Graph
{
    [Serializable]
    [XmlRoot("Branch", Namespace = "", IsNullable = false)]
    public class Branch_T
    {
        [XmlAttribute]
        public int Number { get; set; }

        [XmlAttribute]
        public Branch_TE Type { get; set; }

        [XmlAttribute]
        public int Cardinality { get; set; }
    }
}
