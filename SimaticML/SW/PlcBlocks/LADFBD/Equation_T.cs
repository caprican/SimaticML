using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.LADFBD
{
    [Serializable]
    [XmlRoot("Equation", Namespace = "", IsNullable = false)]
    public class Equation_T
    {
        [XmlText]
        public string Value { get; set; }
    }
}
