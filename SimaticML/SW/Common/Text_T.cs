using System;
using System.Xml.Serialization;

namespace SimaticML.SW.Common
{
    /// <remarks>
    /// Schema : SW_Common
    /// </remarks>
    [Serializable]
    [XmlRoot("Text", Namespace = "", IsNullable = false)]
    public class Text_T
    {
        [XmlText]
        public string Value { get; set; }
    }

    /// <remarks>
    /// Schema : SW_Common_v2
    ///          SW_Common_v3
    /// </remarks>
    [Serializable]
    [XmlRoot("Text", Namespace = "", IsNullable = false)]
    public class Text_T_v2 : Text_T
    {
        [XmlAttribute]
        public int UId { get; set; }
        [XmlIgnore]
        public bool UIdSpecified { get; set; }
    }
}
