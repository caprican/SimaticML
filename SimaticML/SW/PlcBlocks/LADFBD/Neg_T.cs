using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.LADFBD
{
    /// <summary>
    /// The negated pins of this part.
    /// </summary>
    [Serializable]
    [XmlRoot("Negated", Namespace = "", IsNullable = false)]
    public class Neg_T
    {
        /// <summary>
        /// The name of the negated pin.
        /// </summary>
        [XmlAttribute]
        public string Name { get; set; }
    }
}
