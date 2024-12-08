using System;
using System.Xml.Serialization;

using SimaticML.SW.Common;

namespace SimaticML.SW.PlcBlocks.Access
{
    [Serializable]
    [XmlRoot("Expression", Namespace = "", IsNullable = false)]
    public class Expression_T
    {
        [XmlElement("Access", typeof(Access_T))]
        [XmlElement("Token", typeof(Token_T))]
        public object[] Items { get; set; }

        [XmlElement("Blank", typeof(Blank_T))]
        [XmlElement("Comment", typeof(Comment_T))]
        [XmlElement("LineComment", typeof(LineComment_T))]
        [XmlElement("NewLine", typeof(NewLine_T))]
        public Comment_G[] Items1 { get; set; }

        [XmlAttribute]
        public int UId { get; set; }
        [XmlIgnore]
        public bool UIdSpecified { get; set; }
    }
}
