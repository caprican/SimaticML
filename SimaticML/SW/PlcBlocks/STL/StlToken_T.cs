using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.STL
{
    /// <remarks>
    /// Schema : SW.PlcBlocks.STL (SW.PlcBlocks.CompileUnitCommon + SW.PlcBlocks.Access + SW.Common)
    /// </remarks>
    [Serializable]
    [XmlRoot("StlToken", Namespace = "", IsNullable = false)]
    public class StlToken_T
    {
        /// <summary>
        /// for NumBLs. NumBLs is informative
        /// </summary>
        public Common.IntegerAttribute_T IntegerAttribute { get; set; }

        [XmlElement("Comment", typeof(Common.Comment_T))]
        [XmlElement("LineComment", typeof(Common.LineComment_T))]
        public object[] Items { get; set; }

        /// <summary>
        /// e.g 0 1 for NOP 0, NOP 1; STW for L STW or DILG for L DILG; only if separated by comment
        /// </summary>
        public Common.Token_T Token { get; set; }

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

    /// <remarks>
    /// Schema : SW.PlcBlocks.STL_v2 (SW.PlcBlocks.CompileUnitCommon_v2 + SW.PlcBlocks.Access_v2 + SW.Common_v2)
    ///          SW.PlcBlocks.STL_v3 (SW.PlcBlocks.CompileUnitCommon_v3 + SW.PlcBlocks.Access_v3 + SW.Common_v2)
    /// </remarks>
    [Serializable]
    [XmlRoot("StlToken", Namespace = "", IsNullable = false)]
    public class StlToken_T_v2 : StlToken_T
    {
        /// <summary>
        /// for NumBLs. NumBLs is informative
        /// </summary>
        public new Common.IntegerAttribute_T_v2 IntegerAttribute { get; set; }

        [XmlElement("Blank", typeof(Common.Blank_T))]
        [XmlElement("Comment", typeof(Common.Comment_T_v2))]
        [XmlElement("LineComment", typeof(Common.LineComment_T_v2))]
        [XmlElement("NewLine", typeof(Common.NewLine_T))]
        public new object[] Items { get; set; }

        /// <summary>
        /// e.g 0 1 for NOP 0, NOP 1; STW for L STW or DILG for L DILG; only if separated by comment
        /// </summary>
        public new Common.Token_T_v2 Token { get; set; }
    }

    /// <remarks>
    /// Schema : SW.PlcBlocks.STL_v4 (SW.PlcBlocks.CompileUnitCommon_v4 + SW.PlcBlocks.Access_v4 + SW.Common_v3)
    ///          SW.PlcBlocks.STL_v5 (SW.PlcBlocks.CompileUnitCommon_v5 + SW.PlcBlocks.Access_v5 + SW.Common_v3)
    /// </remarks>
    [Serializable]
    [XmlRoot("StlToken", Namespace = "", IsNullable = false)]
    public class StlToken_T_v4 : StlToken_T_v2
    {
        /// <summary>
        /// for NumBLs. NumBLs is informative
        /// </summary>
        public new Common.IntegerAttribute_T_v2 IntegerAttribute { get; set; }

        [XmlElement("Blank", typeof(Common.Blank_T))]
        [XmlElement("Comment", typeof(Common.Comment_T_v2))]
        [XmlElement("LineComment", typeof(Common.LineComment_T_v3))]
        [XmlElement("NewLine", typeof(Common.NewLine_T))]
        public new object[] Items { get; set; }
    }
}
