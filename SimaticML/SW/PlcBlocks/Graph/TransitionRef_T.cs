using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Graph
{
    [Serializable]
    [XmlRoot("TransitionRef", Namespace = "", IsNullable = false)]
    public class TransitionRef_T
    {
        [XmlAttribute]
        public int Number { get; set; }
    }
}
