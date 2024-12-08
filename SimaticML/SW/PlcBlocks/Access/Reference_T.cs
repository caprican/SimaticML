using System;
using System.Xml.Serialization;

using SimaticML.SW.Common;

namespace SimaticML.SW.PlcBlocks.Access
{
    /// <summary>
    /// SCL
    /// </summary>
    [Serializable]
    public class Reference_T
    {
        [XmlElement("Blank", typeof(Blank_T), Order = 0)]
        [XmlElement("Comment", typeof(Comment_T), Order = 0)]
        [XmlElement("LineComment", typeof(LineComment_T), Order = 0)]
        [XmlElement("NewLine", typeof(NewLine_T), Order = 0)]
        public Comment_G[] Items { get; set; }

        [XmlElement(Order = 1)]
        public Token_T Token { get; set; }

        [XmlElement("Blank", typeof(Blank_T), Order = 2)]
        [XmlElement("Comment", typeof(Comment_T), Order = 2)]
        [XmlElement("LineComment", typeof(LineComment_T), Order = 2)]
        [XmlElement("NewLine", typeof(NewLine_T), Order = 2)]
        public Comment_G[] Items1 { get; set; }

        [XmlElement(Order = 3)]
        public Access_T Access { get; set; }

        [XmlElement("Blank", typeof(Blank_T), Order = 4)]
        [XmlElement("Comment", typeof(Comment_T), Order = 4)]
        [XmlElement("LineComment", typeof(LineComment_T), Order = 4)]
        [XmlElement("NewLine", typeof(NewLine_T), Order = 4)]
        public Comment_G[] Items2 { get; set; }

        [XmlElement("Token", Order = 5)]
        public Token_T Token1 { get; set; }
    }
}
