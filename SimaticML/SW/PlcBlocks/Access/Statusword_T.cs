using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Access
{
    /// <summary>
    /// Only for S7-300/400/WinAC
    /// </summary>
    [Serializable]
    [XmlRoot("Statusword", Namespace = "", IsNullable = false)]
    public class Statusword_T
    {
        [XmlAttribute]
        public Statusword_TE Combination { get; set; }
    }
}
