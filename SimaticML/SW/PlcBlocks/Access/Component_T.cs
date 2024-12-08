using System;
using System.ComponentModel;
using System.Xml.Serialization;

using SimaticML.SW.Common;

namespace SimaticML.SW.PlcBlocks.Access
{
    /// <summary>
    /// For the indices of an array
    /// </summary>
    [Serializable]
    public class Component_T
    {
        public Component_T()
        {
            SliceAccessModifier = "undef";
            SimpleAccessModifier = "None";

            AccessModifier = AccessModifier_TE.None;
        }

        [XmlElement("Access", typeof(Access_T))]                                 // For the indices of an array
        [XmlElement("Blank", typeof(Blank_T))]                            // SCL
        [XmlElement("BooleanAttribute", typeof(BooleanAttribute_T))]
        [XmlElement("Comment", typeof(Comment_T))]                        // SCL
        [XmlElement("LineComment", typeof(LineComment_T))]                // SCL
        [XmlElement("NewLine", typeof(NewLine_T))]                        // SCL
        [XmlElement("Token", typeof(Token_T))]                            // SCL
        public object[] Items { get; set; }

        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
        [DefaultValue("undef")]
        public string SliceAccessModifier { get; set; }

        [XmlAttribute]
        [DefaultValue("None")]
        public string SimpleAccessModifier { get; set; }

        /// <summary>
        /// If component has child AccessModifier is Array else AccessModifier is None
        /// </summary>
        [XmlAttribute]
        [DefaultValue(AccessModifier_TE.None)]
        public AccessModifier_TE AccessModifier { get; set; }

        [XmlAttribute]
        public int UId { get; set; }
        [XmlIgnore]
        public bool UIdSpecified { get; set; }
    }
}
