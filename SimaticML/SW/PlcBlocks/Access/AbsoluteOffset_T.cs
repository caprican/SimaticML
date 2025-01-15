using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Access
{
    /// <remarks>
    /// Schema : SW_PlcBlocks_Access (SW.Common)
    ///          SW_PlcBlocks_Access_v2 (SW.Common_v2)
    ///          SW_PlcBlocks_Access_v3 (SW.Common_v2)
    ///          SW_PlcBlocks_Access_v4 (SW.Common_v3)
    ///          SW_PlcBlocks_Access_v5 (SW.Common_v3)
    /// </remarks>
    [Serializable]
    [XmlRoot("AbsoluteOffset", Namespace = "", IsNullable = false)]
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
