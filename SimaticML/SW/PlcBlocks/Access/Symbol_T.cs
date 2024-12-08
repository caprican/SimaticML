using System;
using System.Xml.Serialization;

using SimaticML.SW.Common;

namespace SimaticML.SW.PlcBlocks.Access
{
    [Serializable]
    public class Symbol_T
    {
        [XmlElement("AbsoluteOffset", typeof(AbsoluteOffset_T))]
        [XmlElement("Component", typeof(Component_T))]
        [XmlElement("Token", typeof(Token_T))]                          // the DOT; only if separated. Not in Graph ActionList, not in LAD/FBD.
        [XmlElement("Access", typeof(Access_T))]
        [XmlElement("Blank", typeof(Blank_T))]
        [XmlElement("Comment", typeof(Comment_T))]
        [XmlElement("LineComment", typeof(LineComment_T))]
        [XmlElement("NewLine", typeof(NewLine_T))]
        [XmlElement("Address", typeof(Address_T))]                      // additional address for a symbol. it is informative
        public object[] Items { get; set; }

        /// <summary>
        /// Not allowed in STL
        /// </summary>
        [XmlAttribute]
        public int UId { get; set; }
        [XmlIgnore]
        public bool UIdSpecified { get; set; }

        [XmlAttribute]
        public Scope_TE Scope { get; set; }
        [XmlIgnore]
        public bool ScopeSpecified { get; set; }
    }
}
