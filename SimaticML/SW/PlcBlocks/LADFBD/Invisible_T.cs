using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.LADFBD
{
    /// <summary>
    /// The invisible pins of this part.
    /// </summary>
    [Serializable]
    [XmlRoot("Invisible", Namespace = "", IsNullable = false)]
    public class Invisible_T
    {
        /// <summary>
        /// The name of the invisible pin.
        /// </summary>
        [XmlAttribute]
        public string Name { get; set; }
    }
}
