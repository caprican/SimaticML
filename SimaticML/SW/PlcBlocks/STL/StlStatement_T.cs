using System;
using System.Xml.Serialization;

using SimaticML.SW.Common;
using SimaticML.SW.PlcBlocks.Access;
using SimaticML.SW.PlcBlocks.CompileUnitCommon;

namespace SimaticML.SW.PlcBlocks.STL
{
    [Serializable]
    [XmlRoot("StlStatement", Namespace = "", IsNullable = false)]
    public class StlStatement_T
    {
        [XmlElement("Comment", typeof(Comment), Order = 0)]
        [XmlElement("LineComment", typeof(LineComment_T), Order = 0)]
        [XmlElement("Blank", typeof(Blank_T), Order = 0)]
        [XmlElement("NewLine", typeof(NewLine_T), Order = 0)]
        public Comment_G[] Items { get; set; }

        [XmlElement(Order = 1)]
        public LabelDeclaration_T LabelDeclaration { get; set; }

        /// <summary>
        /// missing for empty lines
        /// </summary>
        [XmlElement(Order = 2)]
        public StlToken_T StlToken { get; set; }

        [XmlElement("Comment", typeof(Comment), Order = 3)]
        [XmlElement("LineComment", typeof(LineComment_T), Order = 3)]
        [XmlElement("Blank", typeof(Blank_T), Order = 3)]
        [XmlElement("NewLine", typeof(NewLine_T), Order = 3)]
        public Comment_G[] Items1 { get; set; }

        [XmlElement(Order = 4)]
        public Access_T Access { get; set; }

        /// <summary>
        /// Not allowed in STL
        /// </summary>
        [XmlAttribute]
        public int UId { get; set; }
        [XmlIgnore]
        public bool UIdSpecified { get; set; }
    }
}
