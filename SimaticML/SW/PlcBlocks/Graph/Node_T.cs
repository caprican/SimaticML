using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Graph
{
    [Serializable]
    [XmlRoot("NodeFrom", Namespace = "", IsNullable = false)]
    public class Node_T
    {
        [XmlElement("BranchRef", typeof(BranchRef_T))]
        [XmlElement("EndConnection", typeof(object))]
        [XmlElement("StepRef", typeof(StepRef_T))]
        [XmlElement("TransitionRef", typeof(TransitionRef_T))]
        public object Item { get; set; }
    }
}
