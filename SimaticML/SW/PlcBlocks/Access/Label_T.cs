using System;
using System.Xml.Serialization;

using SimaticML.SW.Common;

namespace SimaticML.SW.PlcBlocks.Access
{
    /// <summary>
    /// SCL only
    /// </summary>
    [Serializable]
    [XmlRoot("Label", Namespace = "", IsNullable = false)]
    public class Label_T
    {
        [XmlAttribute]
        public string Name { get; set; }

        public BooleanAttribute_T BooleanAttribute { get; set; }

        [XmlElement("Blank", typeof(Blank_T))]
        [XmlElement("Comment", typeof(Comment_T))]
        [XmlElement("LineComment", typeof(LineComment_T))]
        [XmlElement("NewLine", typeof(NewLine_T))]
        public Comment_G[] Items { get; set; }

        public Token_T Token { get; set; }

        [XmlAttribute]
        public int UId { get; set; }
        [XmlIgnore]
        public bool UIdSpecified { get; set; }
    }
}
