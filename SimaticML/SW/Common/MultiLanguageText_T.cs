using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SimaticML.SW.Common
{
    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_Common</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [DebuggerDisplay("{Value}")]
    [XmlRoot("MultiLanguageText", Namespace = "", IsNullable = false)]
    public class MultiLanguageText_T
    {
        [XmlAttribute]
        public string Lang { get; set; }

        [XmlText]
        public string Value { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_Common_v2</item>
    /// <item>SW_Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [DebuggerDisplay("{Value}")]
    [XmlRoot("MultiLanguageText", Namespace = "", IsNullable = false)]
    public class MultiLanguageText_T_v2 : MultiLanguageText_T
    {
        [XmlAttribute]
        public int UId { get; set; }
        [XmlIgnore]
        public bool UIdSpecified { get; set; }
    }
}
