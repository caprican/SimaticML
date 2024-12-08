using System;
using System.Xml.Serialization;

using SimaticML.SW.Common;

namespace SimaticML.SW.PlcBlocks.Access
{
    [Serializable]
    [XmlRoot("Indirect", Namespace = "", IsNullable = false)]
    public class Indirect_T
    {
        [XmlElement("Blank", typeof(Blank_T))]
        [XmlElement("Comment", typeof(Comment_T))]
        [XmlElement("LineComment", typeof(LineComment_T))]
        [XmlElement("NewLine", typeof(NewLine_T))]
        [XmlElement("Token", typeof(Token_T))]
        public object[] Items { get; set; }

        public Access_T Access { get; set; }

        [XmlAttribute]
        public Width_TE Width { get; set; }

        [XmlAttribute]
        public Area_TE Area { get; set; }
        [XmlIgnore]
        public bool AreaSpecified { get; set; }

        [XmlAttribute]
        public Register_TE Register { get; set; }
        [XmlIgnore]
        public bool RegisterSpecified { get; set; }

        [XmlAttribute]
        public string BitOffset { get; set; }
    }
}
