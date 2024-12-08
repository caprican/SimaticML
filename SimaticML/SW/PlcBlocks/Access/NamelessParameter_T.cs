using System;
using System.Xml.Serialization;

using SimaticML.SW.Common;

namespace SimaticML.SW.PlcBlocks.Access
{
    [Serializable]
    [XmlRoot("NamelessParameter", Namespace = "", IsNullable = false)]
    public class NamelessParameter_T
    {
        /// <summary>
        /// for InterfaceFlags. InterfaceFlags is informative
        /// The type of the value should be InterfaceFlags_TP
        /// The default value is "S7_Visible"
        /// </summary>
        [XmlElement("StringAttribute")]
        public StringAttribute_T[] StringAttribute { get; set; }

        [XmlElement("Access", typeof(Access_T))]
        [XmlElement("Blank", typeof(Blank_T))]
        [XmlElement("Comment", typeof(Comment_T))]
        [XmlElement("LineComment", typeof(LineComment_T))]
        [XmlElement("NewLine", typeof(NewLine_T))]
        [XmlElement("Token", typeof(Token_T))]
        public object[] Items { get; set; }

        [XmlAttribute]
        public int UId { get; set; }
        [XmlIgnore]
        public bool UIdSpecified { get; set; }
    }
}
