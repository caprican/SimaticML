using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Graph
{
    [Serializable]
    [XmlRoot("StepRef", Namespace = "", IsNullable = false)]
    public class StepRef_T
    {
        [XmlAttribute]
        public int Number { get; set; }
    }
}
