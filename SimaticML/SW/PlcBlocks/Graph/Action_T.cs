using System;
using System.Xml.Serialization;

using SimaticML.SW.Common;
using SimaticML.SW.PlcBlocks.Access;

namespace SimaticML.SW.PlcBlocks.Graph
{
    [Serializable]
    [XmlRoot("Action", Namespace = "", IsNullable = false)]
    public class Action_T
    {
        [XmlElement("Access", typeof(Access_T))]
        [XmlElement("Comment", typeof(Comment))]
        [XmlElement("LineComment", typeof(LineComment_T))]
        [XmlElement("Token", typeof(Token_T))]
        [XmlElement("Blank", typeof(Blank_T))]
        [XmlElement("NewLine", typeof(NewLine_T))]
        public object[] Items { get; set; }

        [XmlAttribute]
        public Event_TE? Event { get; set; }
        [XmlIgnore]
        public bool EventSpecified { get; set; }

        [XmlAttribute]
        public bool Interlock { get; set; }
        [XmlIgnore]
        public bool InterlockSpecified { get; set; }

        [XmlAttribute]
        public Qualifier_TE? Qualifier { get; set; }
        [XmlIgnore]
        public bool QualifierSpecified { get; set; }
    }
}
