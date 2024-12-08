using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace SimaticML.SW.Common
{
    /// <remark>
    /// Inseted on v2
    /// </remark>
    [Serializable]
    public class Blank_T : Comment_G
    {
        public Blank_T()
        {
            Num = "1";
        }

        [XmlAttribute(DataType = "positiveInteger")]
        [DefaultValue("1")]
        public string Num { get; set; }

        [XmlAttribute]
        public int UId { get; set; }
        [XmlIgnore]
        public bool UIdSpecified { get; set; }
    }
}
