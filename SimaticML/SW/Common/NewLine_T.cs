using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace SimaticML.SW.Common
{
    /// <remarks>
    /// Inserted on v2
    /// </remarks>
    [Serializable]
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
