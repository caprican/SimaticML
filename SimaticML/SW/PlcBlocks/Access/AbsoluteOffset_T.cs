using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Access
{
    [Serializable]
    public class AbsoluteOffset_T
    {
        /// <summary>
        /// Byte * 8 + Bit
        /// </summary>
        [XmlAttribute]
        public int BitOffset { get; set; }

        [XmlAttribute]
        public string Type { get; set; }
    }
}
