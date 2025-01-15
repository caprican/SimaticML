using System;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Access
{
    /// <remarks>
    /// Schema : SW_PlcBlocks_Access (SW.Common)
    /// </remarks>
    [Serializable]
    [XmlRoot("Access", Namespace = "", IsNullable = false)]
    public class Access_T
    {
        /// <summary>
        /// for NumBLs. NumBLs is informative. Not for LAD/FBD.
        /// </summary>
        public Common.IntegerAttribute_T IntegerAttribute { get; set; }

        [XmlElement("Address", typeof(Address_T))]              // for absolute addresses
        [XmlElement("CallInfo", typeof(CallInfo_T))]              // call of a user block. Not in Graph ActionList.
        [XmlElement("Constant", typeof(Constant_T))]
        [XmlElement("Expression", typeof(Expression_T))]        // SCL specific
        [XmlElement("Indirect", typeof(Indirect_T))]            // STL specific
        [XmlElement("Instruction", typeof(Instruction_T))]      // call of an instruction. Not for LAD/FBD, Graph ActionList.
        [XmlElement("Label", typeof(Label_T))]
        [XmlElement("Statusword", typeof(Statusword_T))]
        [XmlElement("Symbol", typeof(Symbol_T))]
        public object Item { get; set; }

        [XmlElement("Comment", typeof(Common.Comment_T))]
        [XmlElement("LineComment", typeof(Common.LineComment_T))]
        public Common.Comment_G[] Items { get; set; }

        [XmlAttribute]
        public Scope_TE Scope { get; set; }

        /// <summary>
        /// Not allowed in STL
        /// </summary>
        [XmlAttribute]
        public int UId { get; set; }
        [XmlIgnore]
        public bool UIdSpecified { get; set; }
    }

    /// <remarks>
    /// Schema : SW_PlcBlocks_Access_v2 (SW.Common_v2)
    /// </remarks>
    [Serializable]
    [XmlRoot("Access", Namespace = "", IsNullable = false)]
    public class Access_T_v2 : Access_T
    {
        /// <summary>
        /// for NumBLs. NumBLs is informative. Not for LAD/FBD.
        /// </summary>
        public new Common.IntegerAttribute_T_v2 IntegerAttribute { get; set; }

        [XmlElement("Address", typeof(Address_T_v2))]              // for absolute addresses
        [XmlElement("CallInfo", typeof(CallInfo_T_v2))]              // call of a user block. Not in Graph ActionList.
        [XmlElement("Constant", typeof(Constant_T_v2))]
        [XmlElement("Expression", typeof(Expression_T_v2))]        // SCL specific
        [XmlElement("Indirect", typeof(Indirect_T_v2))]            // STL specific
        [XmlElement("Instruction", typeof(Instruction_T_v2))]      // call of an instruction. Not for LAD/FBD, Graph ActionList.
        [XmlElement("Label", typeof(Label_T_v2))]
        [XmlElement("Statusword", typeof(Statusword_T))]
        [XmlElement("Symbol", typeof(Symbol_T_v2))]
        [XmlElement("DataType", typeof(DataType_T))]
        [XmlElement("PredefinedVariable", typeof(PredefinedVariable_T))] // Only in SCL
        [XmlElement("Reference", typeof(Reference_T))]
        public new object Item { get; set; }

        [XmlElement("Blank", typeof(Common.Blank_T))]
        [XmlElement("Comment", typeof(Common.Comment_T_v2))]
        [XmlElement("LineComment", typeof(Common.LineComment_T_v2))]
        [XmlElement("NewLine", typeof(Common.NewLine_T))]
        public new Common.Comment_G[] Items { get; set; }

        [XmlAttribute]
        public new Scope_TE_v2 Scope { get; set; }
    }

    /// <remarks>
    /// Schema : SW_PlcBlocks_Access_v3 (SW.Common_v2)
    /// </remarks>
    [Serializable]
    [XmlRoot("Access", Namespace = "", IsNullable = false)]
    public class Access_T_v3 : Access_T_v2
    {
        /// <summary>
        /// for NumBLs. NumBLs is informative. Not for LAD/FBD.
        /// </summary>
        public new Common.IntegerAttribute_T_v2 IntegerAttribute { get; set; }

        [XmlElement("Address", typeof(Address_T_v2))]              // for absolute addresses
        [XmlElement("CallInfo", typeof(CallInfo_T_v3))]              // call of a user block. Not in Graph ActionList.
        [XmlElement("Constant", typeof(Constant_T_v2))]
        [XmlElement("Expression", typeof(Expression_T_v3))]        // SCL specific
        [XmlElement("Indirect", typeof(Indirect_T_v3))]            // STL specific
        [XmlElement("Instruction", typeof(Instruction_T_v3))]      // call of an instruction. Not for LAD/FBD, Graph ActionList.
        [XmlElement("Label", typeof(Label_T_v2))]
        [XmlElement("Statusword", typeof(Statusword_T))]
        [XmlElement("Symbol", typeof(Symbol_T_v2))]
        [XmlElement("DataType", typeof(DataType_T))]
        [XmlElement("PredefinedVariable", typeof(PredefinedVariable_T))] // Only in SCL
        [XmlElement("Reference", typeof(Reference_T_v3))]
        public new object Item { get; set; }
    }

    /// <remarks>
    /// Schema : SW_PlcBlocks_Access_v4 (SW.Common_v3)
    /// </remarks>
    [Serializable]
    [XmlRoot("Access", Namespace = "", IsNullable = false)]
    public class Access_T_v4 : Access_T_v3
    {
        [XmlElement("Address", typeof(Address_T_v2))]              // for absolute addresses
        [XmlElement("CallInfo", typeof(CallInfo_T_v4))]              // call of a user block. Not in Graph ActionList.
        [XmlElement("Constant", typeof(Constant_T_v2))]
        [XmlElement("Expression", typeof(Expression_T_v4))]        // SCL specific
        [XmlElement("Indirect", typeof(Indirect_T_v4))]            // STL specific
        [XmlElement("Instruction", typeof(Instruction_T_v4))]      // call of an instruction. Not for LAD/FBD, Graph ActionList.
        [XmlElement("Label", typeof(Label_T_v4))]
        [XmlElement("Statusword", typeof(Statusword_T))]
        [XmlElement("Symbol", typeof(Symbol_T_v4))]
        [XmlElement("DataType", typeof(DataType_T))]
        [XmlElement("PredefinedVariable", typeof(PredefinedVariable_T))] // Only in SCL
        [XmlElement("Reference", typeof(Reference_T_v4))]
        public new object Item { get; set; }

        [XmlElement("Blank", typeof(Common.Blank_T))]
        [XmlElement("Comment", typeof(Common.Comment_T_v2))]
        [XmlElement("LineComment", typeof(Common.LineComment_T_v3))]
        [XmlElement("NewLine", typeof(Common.NewLine_T))]
        public new Common.Comment_G[] Items { get; set; }
    }

    /// <remarks>
    /// Schema : SW_PlcBlocks_Access_v5 (SW.Common_v3)
    /// </remarks>
    [Serializable]
    [XmlRoot("Access", Namespace = "", IsNullable = false)]
    public class Access_T_v5 : Access_T_v4
    {
        [XmlElement("Address", typeof(Address_T_v2))]              // for absolute addresses
        [XmlElement("CallInfo", typeof(CallInfo_T_v5))]              // call of a user block. Not in Graph ActionList.
        [XmlElement("Constant", typeof(Constant_T_v2))]
        [XmlElement("Expression", typeof(Expression_T_v5))]        // SCL specific
        [XmlElement("Indirect", typeof(Indirect_T_v5))]            // STL specific
        [XmlElement("Instruction", typeof(Instruction_T_v5))]      // call of an instruction. Not for LAD/FBD, Graph ActionList.
        [XmlElement("Label", typeof(Label_T_v4))]
        [XmlElement("Statusword", typeof(Statusword_T))]
        [XmlElement("Symbol", typeof(Symbol_T_v5))]
        [XmlElement("DataType", typeof(DataType_T))]
        [XmlElement("PredefinedVariable", typeof(PredefinedVariable_T))] // Only in SCL
        [XmlElement("Reference", typeof(Reference_T_v5))]
        public new object Item { get; set; }

        [XmlAttribute]
        public new Scope_TE_v5 Scope { get; set; }
    }
}
