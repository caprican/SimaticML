using System;
using System.Xml.Serialization;

using SimaticML.SW.Common;

namespace SimaticML.SW.PlcBlocks.CompileUnitCommon
{
    [Serializable]
    public class LabelDeclaration_T
    {
        /// <summary>
        /// for NumBLs. NumBLs is informative
        /// </summary>
        [XmlElement(Order = 0)]
        public IntegerAttribute_T IntegerAttribute { get; set; }

        [XmlElement(Order = 1)]
        public Access.Label_T Label { get; set; }

        [XmlElement("Comment", typeof(Comment), Order = 2)]
        [XmlElement("LineComment", typeof(LineComment_T), Order = 2)]
        [XmlElement("Blank", typeof(Blank_T), Order = 2)]
        [XmlElement("NewLine", typeof(NewLine_T), Order = 2)]
        public Comment_G[] Items { get; set; }

        /// <summary>
        /// the COLON; only if separated
        /// </summary>
        [XmlElement(Order = 3)]
        public Token_T Token { get; set; }

        [XmlElement("Comment", typeof(Comment), Order = 4)]
        [XmlElement("LineComment", typeof(LineComment_T), Order = 4)]
        [XmlElement("Blank", typeof(Blank_T), Order = 4)]
        [XmlElement("NewLine", typeof(NewLine_T), Order = 4)]
        public Comment_G[] Items1 { get; set; }

        /// <summary>
        /// Not allowed in STL
        /// </summary>
        [XmlAttribute]
        public int UId { get; set; }
        [XmlIgnore]
        public bool UIdSpecified { get; set; }
    }
}
