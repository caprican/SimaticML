using System;
using System.Xml.Serialization;

using SimaticML.SW.Common;

namespace SimaticML.SW.PlcBlocks.STL
{
    [Serializable]
    [XmlRoot("StlToken", Namespace = "", IsNullable = false)]
    public class StlToken_T
    {
        /// <summary>
        /// for NumBLs. NumBLs is informative
        /// </summary>
        public IntegerAttribute_T IntegerAttribute { get; set; }

        [XmlElement("Blank", typeof(Blank_T))]
        [XmlElement("Comment", typeof(Comment_T))]
        [XmlElement("LineComment", typeof(LineComment_T))]
        [XmlElement("NewLine", typeof(NewLine_T))]
        public Comment_G[] Items { get; set; }

        /// <summary>
        /// e.g 0 1 for NOP 0, NOP 1; STW for L STW or DILG for L DILG; only if separated by comment
        /// </summary>
        public Token_T Token { get; set; }

        /// <summary>
        /// Not allowed in STL
        /// </summary>
        [XmlAttribute]
        public int UId { get; set; }
        [XmlIgnore]
        public bool UIdSpecified { get; set; }

        [XmlAttribute]
        public STL_TE Text { get; set; }
    }
}
