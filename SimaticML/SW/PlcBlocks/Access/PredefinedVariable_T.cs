using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Access
{
    /// <remarks>
    /// Schema : SW_PlcBlocks_Access_v2 (SW.Common_v2)
    ///          SW_PlcBlocks_Access_v3 (SW.Common_v2)
    ///          SW_PlcBlocks_Access_v4 (SW.Common_v3)
    ///          SW_PlcBlocks_Access_v5 (SW.Common_v3)
    /// </remarks>
    [Serializable]
    [XmlRoot("PredefinedVariable", Namespace = "", IsNullable = false)]
    public class PredefinedVariable_T
    {
        [XmlAttribute]
        public PredefinedVariable_TE Name { get; set; }

        [XmlAttribute]
        public int UId { get; set; }
    }
}
