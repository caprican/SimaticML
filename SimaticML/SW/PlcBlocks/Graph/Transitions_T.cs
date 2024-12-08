using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Graph
{
    [Serializable]
    [XmlRoot("Transitions", Namespace = "", IsNullable = false)]
    public class Transitions_T
    {
        [XmlElement("Transition")]
        public Transition_T[] Transition { get; set; }
    }
}
