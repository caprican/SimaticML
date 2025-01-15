using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Access
{
    /// <summary>
    /// Only for S7-300/400/WinAC
    /// </summary>
    /// <remarks>
    /// Schema : SW_PlcBlocks_Access (SW.Common)
    ///          SW_PlcBlocks_Access_v2 (SW.Common_v2)
    ///          SW_PlcBlocks_Access_v3 (SW.Common_v2)
    ///          SW_PlcBlocks_Access_v4 (SW.Common_v3)
    ///          SW_PlcBlocks_Access_v5 (SW.Common_v3)
    /// </remarks>
    [Serializable]
    [XmlRoot("Statusword", Namespace = "", IsNullable = false)]
    public class Statusword_T
    {
        [XmlAttribute]
        public Statusword_TE Combination { get; set; }
    }
}
