using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Graph
{
    [Serializable]
    [XmlRoot("Graph", Namespace = "", IsNullable = false)]
    public class Graph_T
    {
        public PermanentOperations_T PreOperations { get; set; }

        [XmlElement("Sequence")]
        public Sequence_T[] Sequence { get; set; }

        public PermanentOperations_T PostOperations { get; set; }

        public AlarmsSettings_T AlarmsSettings { get; set; }
    }
}
