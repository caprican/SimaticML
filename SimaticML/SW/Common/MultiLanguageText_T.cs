using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SimaticML.SW.Common
{
    [Serializable]
    //[XmlRoot("MultiLanguageText", Namespace = "", IsNullable = false)]
    [DebuggerDisplay("{Value}")]

    public class MultiLanguageText_T
    {
        [XmlAttribute]
        public string Lang { get; set; }

        [XmlText]
        public string Value { get; set; }

        /// <remarks>Add on V2</remarks>
        [XmlAttribute]
        public int UId { get; set; }
        [XmlIgnore]
        public bool UIdSpecified { get; set; }
    }
}
