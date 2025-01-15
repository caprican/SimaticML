using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace SimaticML.SW.Common
{
    /// <remarks>
    /// Schema : SW_Common_v2
    ///          SW_Common_v3
    /// </remarks>
    [Serializable]
    [XmlRoot("NewLine", Namespace = "", IsNullable = false)]
    public class NewLine_T : Comment_G
    {
        public NewLine_T()
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
