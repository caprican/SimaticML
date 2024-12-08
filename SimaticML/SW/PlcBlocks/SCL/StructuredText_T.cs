using System;
using System.Xml.Serialization;

using SimaticML.SW.Common;
using SimaticML.SW.PlcBlocks.Access;

namespace SimaticML.SW.PlcBlocks.SCL
{
    [Serializable]
    public class StructuredText_T
    {
        [XmlElement("Access", typeof(Access_T))]
        [XmlElement("Blank", typeof(Blank_T))]
        [XmlElement("Comment", typeof(Comment_T))]
        [XmlElement("LineComment", typeof(LineComment_T))]
        [XmlElement("NewLine", typeof(NewLine_T))]
        [XmlElement("Parameter", typeof(Parameter_T))]
        [XmlElement("Text", typeof(Text_T))]
        [XmlElement("Token", typeof(Token_T))]
        public object[] Items { get; set; }

        [XmlAttribute]
        public int UId { get; set; }
        [XmlIgnore]
        public bool UIdSpecified { get; set; }
    }

}
