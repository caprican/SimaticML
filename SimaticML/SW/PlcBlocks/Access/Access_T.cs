using System;
using System.Xml.Serialization;

using SimaticML.SW.Common;

namespace SimaticML.SW.PlcBlocks.Access
{
    [Serializable]
    public class Access_T
    {
        /// <summary>
        /// for NumBLs. NumBLs is informative. Not for LAD/FBD.
        /// </summary>
        public IntegerAttribute_T IntegerAttribute { get; set; }

        [XmlElement("Address", typeof(Address_T))]              // for absolute addresses
        [XmlElement("CallInfo", typeof(CallInfo))]              // call of a user block. Not in Graph ActionList.
        [XmlElement("Constant", typeof(Constant_T))]
        [XmlElement("Expression", typeof(Expression_T))]        // SCL specific
        [XmlElement("Indirect", typeof(Indirect_T))]            // STL specific
        [XmlElement("Instruction", typeof(Instruction_T))]      // call of an instruction. Not for LAD/FBD, Graph ActionList.
        [XmlElement("Label", typeof(Label_T))]
        [XmlElement("Statusword", typeof(Statusword_T))]
        [XmlElement("Symbol", typeof(Symbol_T))]
        [XmlElement("DataType", typeof(DataType_T))]
        [XmlElement("PredefinedVariable", typeof(PredefinedVariable_T))] // Only in SCL
        [XmlElement("Reference", typeof(Reference_T))]
        public object Item { get; set; }

        [XmlElement("Blank", typeof(Blank_T))]
        [XmlElement("Comment", typeof(Comment_T))]
        [XmlElement("LineComment", typeof(LineComment_T))]
        [XmlElement("NewLine", typeof(NewLine_T))]
        public Comment_G[] Items { get; set; }

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
}
