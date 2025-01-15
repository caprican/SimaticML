using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.CompileUnitCommon
{
    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.CompileUnitCommon => SW.PlcBlocks.Access + SW.Common</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("LabelDeclaration", Namespace = "", IsNullable = false)]
    public class LabelDeclaration_T
    {
        [XmlElement("IntegerAttribute", typeof(Common.IntegerAttribute_T), Order = 0)]             // for NumBLs. NumBLs is informative
        [XmlElement("Label", typeof(Access.Label_T), Order = 1)]
        [XmlElement("Comment", typeof(Common.Comment_T), Order = 2 | 4)]
        [XmlElement("LineComment", typeof(Common.LineComment_T), Order = 2 | 4)]
        [XmlElement("Token", typeof(Common.Token_T), Order = 3)]     // the COLON; only if separated
        public object[] Items { get; set; }

        /// <summary>
        /// Not allowed in STL
        /// </summary>
        [XmlAttribute]
        public int UId { get; set; }
        [XmlIgnore]
        public bool UIdSpecified { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.CompileUnitCommon_v2 => SW.PlcBlocks.Access_v2 + SW.Common_v2</item>
    /// <item>SW.PlcBlocks.CompileUnitCommon_v3 => SW.PlcBlocks.Access_v3 + SW.Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("LabelDeclaration", Namespace = "", IsNullable = false)]
    public class LabelDeclaration_T_v2 : LabelDeclaration_T
    {
        [XmlElement("IntegerAttribute", typeof(Common.IntegerAttribute_T_v2), Order = 0)]     // for NumBLs. NumBLs is informative
        [XmlElement("Label", typeof(Access.Label_T_v4), Order = 1)]
        [XmlElement("Blank", typeof(Common.Blank_T), Order = 2 | 4)]
        [XmlElement("Comment", typeof(Common.Comment_T_v2), Order = 2 | 4)]
        [XmlElement("LineComment", typeof(Common.LineComment_T_v2), Order = 2 | 4)]
        [XmlElement("NewLine", typeof(Common.NewLine_T), Order = 2 | 4)]
        [XmlElement("Token", typeof(Common.Token_T_v2), Order = 3)]           // the COLON; only if separated
        public new object[] Items { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.CompileUnitCommon_v4 => SW.PlcBlocks.Access_v4 + SW.Common_v3</item>
    /// <item>SW.PlcBlocks.CompileUnitCommon_v5 => SW.PlcBlocks.Access_v5 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("LabelDeclaration", Namespace = "", IsNullable = false)]
    public class LabelDeclaration_T_v4 : LabelDeclaration_T_v2
    {
        [XmlElement("IntegerAttribute", typeof(Common.IntegerAttribute_T_v2), Order = 0)]     // for NumBLs. NumBLs is informative
        [XmlElement("Label", typeof(Access.Label_T_v4), Order = 1)]
        [XmlElement("Blank", typeof(Common.Blank_T), Order = 2 | 4)]
        [XmlElement("Comment", typeof(Common.Comment_T_v2), Order = 2 | 4)]
        [XmlElement("LineComment", typeof(Common.LineComment_T_v3), Order = 2 | 4)]
        [XmlElement("NewLine", typeof(Common.NewLine_T), Order = 2 | 4)]
        [XmlElement("Token", typeof(Common.Token_T_v2), Order = 3)]           // the COLON; only if separated
        public new object[] Items { get; set; }
    }
}
