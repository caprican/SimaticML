using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.STL
{
    /// <remarks>
    /// Schema : SW.PlcBlocks.STL (SW.PlcBlocks.CompileUnitCommon + SW.PlcBlocks.Access + SW.Common)
    /// </remarks>
    [Serializable]
    [XmlRoot("StlStatement", Namespace = "", IsNullable = false)]
    public class StlStatement_T
    {
        [XmlElement("Comment", typeof(Common.Comment_T), Order = 0 | 3)]
        [XmlElement("LineComment", typeof(Common.LineComment_T), Order = 0 | 3)]
        [XmlElement("LabelDeclaration", typeof(CompileUnitCommon.LabelDeclaration_T), Order = 1)]
        [XmlElement("StlToken", typeof(StlToken_T), Order = 2)]                 // missing for empty lines
        [XmlElement("Access", typeof(Access.Access_T), Order = 4)]
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
    /// Schema : SW.PlcBlocks.STL_v2 (SW.PlcBlocks.CompileUnitCommon_v2 + SW.PlcBlocks.Access_v2 + SW.Common_v2)
    /// </remarks>
    [Serializable]
    [XmlRoot("StlStatement", Namespace = "", IsNullable = false)]
    public class StlStatement_T_v2 : StlStatement_T
    {
        [XmlElement("Blank", typeof(Common.Blank_T), Order = 0 | 3)]
        [XmlElement("Comment", typeof(Common.Comment_T_v2), Order = 0 | 3)]
        [XmlElement("LineComment", typeof(Common.LineComment_T_v2), Order = 0 | 3)]
        [XmlElement("NewLine", typeof(Common.NewLine_T), Order = 0 | 3)]
        [XmlElement("LabelDeclaration", typeof(CompileUnitCommon.LabelDeclaration_T_v2), Order = 1)]
        [XmlElement("StlToken", typeof(StlToken_T_v2), Order = 2)]                 // missing for empty lines
        [XmlElement("Access", typeof(Access.Access_T_v2), Order = 4)]
        public new object[] Items { get; set; }
    }

    /// <remarks>
    /// Schema : SW.PlcBlocks.STL_v3 (SW.PlcBlocks.CompileUnitCommon_v3 + SW.PlcBlocks.Access_v3 + SW.Common_v2)
    /// </remarks>
    [Serializable]
    [XmlRoot("StlStatement", Namespace = "", IsNullable = false)]
    public class StlStatement_T_v3 : StlStatement_T_v2
    {
        [XmlElement("Blank", typeof(Common.Blank_T), Order = 0 | 3)]
        [XmlElement("Comment", typeof(Common.Comment_T_v2), Order = 0 | 3)]
        [XmlElement("LineComment", typeof(Common.LineComment_T_v2), Order = 0 | 3)]
        [XmlElement("NewLine", typeof(Common.NewLine_T), Order = 0 | 3)]
        [XmlElement("LabelDeclaration", typeof(CompileUnitCommon.LabelDeclaration_T_v2), Order = 1)]
        [XmlElement("StlToken", typeof(StlToken_T_v2), Order = 2)]                 // missing for empty lines
        [XmlElement("Access", typeof(Access.Access_T_v3), Order = 4)]
        public new object[] Items { get; set; }
    }

    /// <remarks>
    /// Schema : SW.PlcBlocks.STL_v4 (SW.PlcBlocks.CompileUnitCommon_v4 + SW.PlcBlocks.Access_v4 + SW.Common_v3)
    /// </remarks>
    [Serializable]
    [XmlRoot("StlStatement", Namespace = "", IsNullable = false)]
    public class StlStatement_T_v4 : StlStatement_T_v2
    {
        [XmlElement("Blank", typeof(Common.Blank_T), Order = 0 | 3)]
        [XmlElement("Comment", typeof(Common.Comment_T_v2), Order = 0 | 3)]
        [XmlElement("LineComment", typeof(Common.LineComment_T_v3), Order = 0 | 3)]
        [XmlElement("NewLine", typeof(Common.NewLine_T), Order = 0 | 3)]
        [XmlElement("LabelDeclaration", typeof(CompileUnitCommon.LabelDeclaration_T_v4), Order = 1)]
        [XmlElement("StlToken", typeof(StlToken_T_v4), Order = 2)]                 // missing for empty lines
        [XmlElement("Access", typeof(Access.Access_T_v4), Order = 4)]
        public new object[] Items { get; set; }
    }

    /// <remarks>
    /// Schema : SW.PlcBlocks.STL_v5 (SW.PlcBlocks.CompileUnitCommon_v5 + SW.PlcBlocks.Access_v5 + SW.Common_v3)
    /// </remarks>
    [Serializable]
    [XmlRoot("StlStatement", Namespace = "", IsNullable = false)]
    public class StlStatement_T_v5 : StlStatement_T_v4
    {
        [XmlElement("Blank", typeof(Common.Blank_T), Order = 0 | 3)]
        [XmlElement("Comment", typeof(Common.Comment_T_v2), Order = 0 | 3)]
        [XmlElement("LineComment", typeof(Common.LineComment_T_v3), Order = 0 | 3)]
        [XmlElement("NewLine", typeof(Common.NewLine_T), Order = 0 | 3)]
        [XmlElement("LabelDeclaration", typeof(CompileUnitCommon.LabelDeclaration_T_v4), Order = 1)]
        [XmlElement("StlToken", typeof(StlToken_T_v4), Order = 2)]                 // missing for empty lines
        [XmlElement("Access", typeof(Access.Access_T_v5), Order = 4)]
        public new object[] Items { get; set; }
    }
}
