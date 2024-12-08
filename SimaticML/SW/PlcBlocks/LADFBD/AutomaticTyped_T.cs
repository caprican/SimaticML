using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.LADFBD
{
    [Serializable]
    [XmlRoot("AutomaticTyped", Namespace = "", IsNullable = false)]
    public class AutomaticTyped_T
    {
        /// <summary>
        /// The name of the automatic chosen template parameter.
        /// Not for InstructionRef
        /// </summary>
        [XmlAttribute]
        public string Name { get; set; }
    }
}
