using System;
using System.Xml.Serialization;

using SimaticML.SW.Common;

namespace SimaticML.SW.PlcBlocks.Access
{
    [Serializable]
    public class Instance_T
    {
        [XmlElement("AbsoluteOffset", typeof(AbsoluteOffset_T))]
        [XmlElement("Address", typeof(Address_T))]                      // additional address for a symbol. it is informative
        [XmlElement("Component", typeof(Component_T))]
        [XmlElement("Token", typeof(Token_T))]                          // the DOT; only if separated. Not in Graph ActionList, not in LAD/FBD.
        public object[] Items { get; set; }

        [XmlElement("Blank", typeof(Blank_T))]
        [XmlElement("Comment", typeof(Comment_T))]
        [XmlElement("LineComment", typeof(LineComment_T))]
        [XmlElement("NewLine", typeof(NewLine_T))]
        public Comment_G[] Items1 { get; set; }

        /// <summary>
        /// Not allowed in STL
        /// </summary>
        [XmlAttribute]
        public int UId { get; set; }
        [XmlIgnore]
        public bool UIdSpecified { get; set; }

        [XmlAttribute]
        public Scope_TE Scope { get; set; }
    }
}
