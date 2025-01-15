using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace SimaticML.SW.Common
{
    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    ///<item>SW_Common_v2</item>
    ///<item>SW_Common_v3</item>
    ///</list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Blank", Namespace = "", IsNullable = false)]
    public class Blank_T : Comment_G
    {
        [XmlAttribute(DataType = "positiveInteger")]
        [DefaultValue("1")]
        public string Num { get; set; } = "1";

        [XmlAttribute]
        public int UId { get; set; }
        [XmlIgnore]
        public bool UIdSpecified { get; set; }
    }
}
