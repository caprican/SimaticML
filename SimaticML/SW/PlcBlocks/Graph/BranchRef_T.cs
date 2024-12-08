using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Graph
{
    [Serializable]
    [XmlRoot("BranchRef", Namespace = "", IsNullable = false)]
    public class BranchRef_T
    {
        [XmlAttribute]
        public int Number { get; set; }

        [XmlAttribute]
        public int In { get; set; }
        [XmlIgnore]
        public bool InSpecified { get; set; }

        [XmlAttribute]
        public int Out { get; set; }
        [XmlIgnore]
        public bool OutSpecified { get; set; }
    }
}
