using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.LADFBD
{
    [Serializable]
    [XmlRoot("Wires", Namespace = "", IsNullable = false)]
    public class Wires_T
    {
        [XmlElement("Wire")]
        public Wire_T[] Wire { get; set; }
    }
}
