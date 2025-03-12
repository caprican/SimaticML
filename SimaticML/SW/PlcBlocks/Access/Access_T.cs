using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Access
{
    public interface IAccess
    {
        /// <summary>
        /// for NumBLs. NumBLs is informative. Not for LAD/FBD.
        /// </summary>
        Common.IIntegerAttribute_T IntegerAttribute { get; set; }
        Object_G Item { get; set; }
        Common.Comment_G[] Comments { get; set; }
        Scope_TE Scope { get; set; }
        /// <summary>
        /// Not allowed in STL
        /// </summary>
        int? UId { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_PlcBlocks_Access => SW.Common</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Access", IsNullable = false)]
    public class Access_T : Object_G, IAccess
    {
        /// <summary>
        /// for NumBLs. NumBLs is informative. Not for LAD/FBD.
        /// </summary>
        public Common.IIntegerAttribute_T IntegerAttribute { get; set; }

        [XmlElement("Address", typeof(Address_T))]              // for absolute addresses
        [XmlElement("CallInfo", typeof(CallInfo_T))]              // call of a user block. Not in Graph ActionList.
        [XmlElement("Constant", typeof(Constant_T))]
        [XmlElement("Expression", typeof(Expression_T))]        // SCL specific
        [XmlElement("Indirect", typeof(Indirect_T))]            // STL specific
        [XmlElement("Instruction", typeof(Instruction_T))]      // call of an instruction. Not for LAD/FBD, Graph ActionList.
        [XmlElement("Label", typeof(Label_T))]
        [XmlElement("Statusword", typeof(Statusword_T))]
        [XmlElement("Symbol", typeof(Symbol_T))]
        public Object_G Item { get; set; }

        [XmlElement("Comment", typeof(Common.Comment_T))]
        [XmlElement("LineComment", typeof(Common.LineComment_T))]
        public Common.Comment_G[] Comments { get; set; }

        [XmlAttribute]
        public Scope_TE Scope { get; set; }

        /// <summary>
        /// Not allowed in STL
        /// </summary>
        [XmlAttribute]
        public int? UId { get; set; } = null;
        [XmlIgnore]
        public bool UIdSpecified { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(Scope):
                        Enum.TryParse<Scope_TE>(reader.ReadContentAsString(), out var scope);
                        Scope = scope;
                        break;

                    case nameof(UId):
                        UId = reader.ReadContentAsInt();
                        UIdSpecified = true;
                        break;
                }
            }

            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var items = new List<Common.Comment_G>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "IntegerAttribute":
                            var integerAttribute = new Common.IntegerAttribute_T();
                            integerAttribute.ReadXml(reader);
                            IntegerAttribute = integerAttribute;
                            break;

                        case "Comment":
                            var comment = new Common.Comment_T();
                            comment.ReadXml(reader);
                            items.Add(comment);
                            break;
                        case "LineComment":
                            var lineComment = new Common.LineComment_T();
                            lineComment.ReadXml(reader);
                            items.Add(lineComment);
                            break;

                        case "Address":
                            var address = new Address_T();
                            address.ReadXml(reader);
                            Item = address;
                            break;
                        case "CallInfo":
                            var callInfo = new CallInfo_T();
                            callInfo.ReadXml(reader);
                            Item = callInfo;
                            break;
                        case "Constant":
                            var startValue = new Constant_T();
                            startValue.ReadXml(reader);
                            Item = startValue;
                            break;
                        case "Expression":
                            var expression = new Expression_T();
                            expression.ReadXml(reader);
                            Item = expression;
                            break;
                        case "Indirect":
                            var indirect = new Indirect_T();
                            indirect.ReadXml(reader);
                            Item = indirect;
                            break;
                        case "Instruction":
                            var instruction = new Instruction_T();
                            instruction.ReadXml(reader);
                            Item = instruction;
                            break;
                        case "Label":
                            var label = new Label_T();
                            label.ReadXml(reader);
                            Item = label;
                            break;
                        case "Statusword":
                            var statusword = new Statusword_T();
                            statusword.ReadXml(reader);
                            Item = statusword;
                            break;
                        case "Symbol":
                            var symbol = new Symbol_T();
                            symbol.ReadXml(reader);
                            Item = symbol;
                            break;
                    }
                }
                if (items.Count > 0) Comments = items.ToArray();
            }

            if (reader.IsStartElement())
                reader.Read();
            else
                reader.ReadEndElement();
        }

        public override void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_PlcBlocks_Access_v2 => SW.Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Access", IsNullable = false)]
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
        public new Object_G Item { get; set; }

        [XmlElement("Blank", typeof(Common.Blank_T))]
        [XmlElement("Comment", typeof(Common.Comment_T_v2))]
        [XmlElement("LineComment", typeof(Common.LineComment_T_v2))]
        [XmlElement("NewLine", typeof(Common.NewLine_T))]
        public new Common.Comment_G[] Comments { get; set; }

        [XmlAttribute]
        public new Scope_TE_v2 Scope { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(Scope):
                        Enum.TryParse<Scope_TE_v2>(reader.ReadContentAsString(), out var scope);
                        Scope = scope;
                        break;

                    case nameof(UId):
                        UId = reader.ReadContentAsInt();
                        UIdSpecified = true;
                        break;
                }
            }

            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var items = new List<Common.Comment_G>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "IntegerAttribute":
                            IntegerAttribute = new Common.IntegerAttribute_T_v2();
                            IntegerAttribute.ReadXml(reader);
                            break;

                        case "Blank":
                            var blank = new Common.Blank_T();
                            blank.ReadXml(reader);
                            items.Add(blank);
                            break;
                        case "Comment":
                            var comment = new Common.Comment_T_v2();
                            comment.ReadXml(reader);
                            items.Add(comment);
                            break;
                        case "LineComment":
                            var lineComment = new Common.LineComment_T_v2();
                            lineComment.ReadXml(reader);
                            items.Add(lineComment);
                            break;
                        case "NewLine":
                            var newLine = new Common.NewLine_T();
                            newLine.ReadXml(reader);
                            items.Add(newLine);
                            break;

                        case "Address":
                            var address = new Address_T_v2();
                            address.ReadXml(reader);
                            Item = address;
                            break;
                        case "CallInfo":
                            var callInfo = new CallInfo_T_v2();
                            callInfo.ReadXml(reader);
                            Item = callInfo;
                            break;
                        case "Constant":
                            var startValue = new Constant_T_v2();
                            startValue.ReadXml(reader);
                            Item = startValue;
                            break;
                        case "Expression":
                            var expression = new Expression_T_v2();
                            expression.ReadXml(reader);
                            Item = expression;
                            break;
                        case "Indirect":
                            var indirect = new Indirect_T_v2();
                            indirect.ReadXml(reader);
                            Item = indirect;
                            break;
                        case "Instruction":
                            var instruction = new Instruction_T_v2();
                            instruction.ReadXml(reader);
                            Item = instruction;
                            break;
                        case "Label":
                            var label = new Label_T_v2();
                            label.ReadXml(reader);
                            Item = label;
                            break;
                        case "Statusword":
                            var statusword = new Statusword_T();
                            statusword.ReadXml(reader);
                            Item = statusword;
                            break;
                        case "Symbol":
                            var symbol = new Symbol_T_v2();
                            symbol.ReadXml(reader);
                            Item = symbol;
                            break;
                        case "DataType":
                            var dataType = new DataType_T();
                            dataType.ReadXml(reader);
                            Item = dataType;
                            break;
                        case "PredefinedVariable":
                            var predefinedVariable = new PredefinedVariable_T();
                            predefinedVariable.ReadXml(reader);
                            Item = predefinedVariable;
                            break;
                        case "Reference":
                            var reference = new Reference_T();
                            reference.ReadXml(reader);
                            Item = reference;
                            break;
                    }
                }
                if (items.Count > 0) Comments = items.ToArray();
            }

            if (reader.IsStartElement())
                reader.Read();
            else
                reader.ReadEndElement();
        }

        public override void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_PlcBlocks_Access_v3 => SW.Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Access", IsNullable = false)]
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
        public new Object_G Item { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(Scope):
                        Enum.TryParse<Scope_TE_v2>(reader.ReadContentAsString(), out var scope);
                        Scope = scope;
                        break;

                    case nameof(UId):
                        UId = reader.ReadContentAsInt();
                        UIdSpecified = true;
                        break;
                }
            }

            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var items = new List<Common.Comment_G>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "IntegerAttribute":
                            IntegerAttribute = new Common.IntegerAttribute_T_v2();
                            IntegerAttribute.ReadXml(reader);
                            break;

                        case "Blank":
                            var blank = new Common.Blank_T();
                            blank.ReadXml(reader);
                            items.Add(blank);
                            break;
                        case "Comment":
                            var comment = new Common.Comment_T_v2();
                            comment.ReadXml(reader);
                            items.Add(comment);
                            break;
                        case "LineComment":
                            var lineComment = new Common.LineComment_T_v2();
                            lineComment.ReadXml(reader);
                            items.Add(lineComment);
                            break;
                        case "NewLine":
                            var newLine = new Common.NewLine_T();
                            newLine.ReadXml(reader);
                            items.Add(newLine);
                            break;

                        case "Address":
                            var address = new Address_T_v2();
                            address.ReadXml(reader);
                            Item = address;
                            break;
                        case "CallInfo":
                            var callInfo = new CallInfo_T_v3();
                            callInfo.ReadXml(reader);
                            Item = callInfo;
                            break;
                        case "Constant":
                            var startValue = new Constant_T_v2();
                            startValue.ReadXml(reader);
                            Item = startValue;
                            break;
                        case "Expression":
                            var expression = new Expression_T_v3();
                            expression.ReadXml(reader);
                            Item = expression;
                            break;
                        case "Indirect":
                            var indirect = new Indirect_T_v3();
                            indirect.ReadXml(reader);
                            Item = indirect;
                            break;
                        case "Instruction":
                            var instruction = new Instruction_T_v3();
                            instruction.ReadXml(reader);
                            Item = instruction;
                            break;
                        case "Label":
                            var label = new Label_T_v2();
                            label.ReadXml(reader);
                            Item = label;
                            break;
                        case "Statusword":
                            var statusword = new Statusword_T();
                            statusword.ReadXml(reader);
                            Item = statusword;
                            break;
                        case "Symbol":
                            var symbol = new Symbol_T_v2();
                            symbol.ReadXml(reader);
                            Item = symbol;
                            break;
                        case "DataType":
                            var dataType = new DataType_T();
                            dataType.ReadXml(reader);
                            Item = dataType;
                            break;
                        case "PredefinedVariable":
                            var predefinedVariable = new PredefinedVariable_T();
                            predefinedVariable.ReadXml(reader);
                            Item = predefinedVariable;
                            break;
                        case "Reference":
                            var reference = new Reference_T();
                            reference.ReadXml(reader);
                            Item = reference;
                            break;
                    }
                }
                if (items.Count > 0) Comments = items.ToArray();
            }

            if (reader.IsStartElement())
                reader.Read();
            else
                reader.ReadEndElement();
        }

        public override void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_PlcBlocks_Access_v4 => SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Access", IsNullable = false)]
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
        public new Object_G Item { get; set; }

        [XmlElement("Blank", typeof(Common.Blank_T))]
        [XmlElement("Comment", typeof(Common.Comment_T_v2))]
        [XmlElement("LineComment", typeof(Common.LineComment_T_v3))]
        [XmlElement("NewLine", typeof(Common.NewLine_T))]
        public new Common.Comment_G[] Comments { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(Scope):
                        Enum.TryParse<Scope_TE_v2>(reader.ReadContentAsString(), out var scope);
                        Scope = scope;
                        break;

                    case nameof(UId):
                        UId = reader.ReadContentAsInt();
                        UIdSpecified = true;
                        break;
                }
            }

            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var items = new List<Common.Comment_G>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case nameof(IntegerAttribute):
                            IntegerAttribute = new Common.IntegerAttribute_T_v2();
                            IntegerAttribute.ReadXml(reader);
                            break;

                        case "Blank":
                            var blank = new Common.Blank_T();
                            blank.ReadXml(reader);
                            items.Add(blank);
                            break;
                        case "Comment":
                            var comment = new Common.Comment_T_v2();
                            comment.ReadXml(reader);
                            items.Add(comment);
                            break;
                        case "LineComment":
                            var lineComment = new Common.LineComment_T_v3();
                            lineComment.ReadXml(reader);
                            items.Add(lineComment);
                            break;
                        case "NewLine":
                            var newLine = new Common.NewLine_T();
                            newLine.ReadXml(reader);
                            items.Add(newLine);
                            break;

                        case "Address":
                            var address = new Address_T_v2();
                            address.ReadXml(reader);
                            Item = address;
                            break;
                        case "CallInfo":
                            var callInfo = new CallInfo_T_v4();
                            callInfo.ReadXml(reader);
                            Item = callInfo;
                            break;
                        case "Constant":
                            var startValue = new Constant_T_v2();
                            startValue.ReadXml(reader);
                            Item = startValue;
                            break;
                        case "Expression":
                            var expression = new Expression_T_v4();
                            expression.ReadXml(reader);
                            Item = expression;
                            break;
                        case "Indirect":
                            var indirect = new Indirect_T_v4();
                            indirect.ReadXml(reader);
                            Item = indirect;
                            break;
                        case "Instruction":
                            var instruction = new Instruction_T_v4();
                            instruction.ReadXml(reader);
                            Item = instruction;
                            break;
                        case "Label":
                            var label = new Label_T_v4();
                            label.ReadXml(reader);
                            Item = label;
                            break;
                        case "Statusword":
                            var statusword = new Statusword_T();
                            statusword.ReadXml(reader);
                            Item = statusword;
                            break;
                        case "Symbol":
                            var symbol = new Symbol_T_v4();
                            symbol.ReadXml(reader);
                            Item = symbol;
                            break;
                        case "DataType":
                            var dataType = new DataType_T();
                            dataType.ReadXml(reader);
                            Item = dataType;
                            break;
                        case "PredefinedVariable":
                            var predefinedVariable = new PredefinedVariable_T();
                            predefinedVariable.ReadXml(reader);
                            Item = predefinedVariable;
                            break;
                        case "Reference":
                            var reference = new Reference_T_v4();
                            reference.ReadXml(reader);
                            Item = reference;
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
                if (items.Count > 0) Comments = items.ToArray();
            }

            if (reader.IsStartElement())
                reader.Read();
            else
                reader.ReadEndElement();
        }

        public override void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_PlcBlocks_Access_v5 => SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Access", IsNullable = false)]
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
        public new Object_G Item { get; set; }

        [XmlAttribute]
        public new Scope_TE_v5 Scope { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(Scope):
                        Enum.TryParse<Scope_TE_v5>(reader.ReadContentAsString(), out var scope);
                        Scope = scope;
                        break;

                    case nameof(UId):
                        UId = reader.ReadContentAsInt();
                        UIdSpecified = true;
                        break;
                }
            }

            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var items = new List<Common.Comment_G>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "IntegerAttribute":
                            IntegerAttribute = new Common.IntegerAttribute_T_v2();
                            IntegerAttribute.ReadXml(reader);
                            break;

                        case "Blank":
                            var blank = new Common.Blank_T();
                            blank.ReadXml(reader);
                            items.Add(blank);
                            break;
                        case "Comment":
                            var comment = new Common.Comment_T_v2();
                            comment.ReadXml(reader);
                            items.Add(comment);
                            break;
                        case "LineComment":
                            var lineComment = new Common.LineComment_T_v3();
                            lineComment.ReadXml(reader);
                            items.Add(lineComment);
                            break;
                        case "NewLine":
                            var newLine = new Common.NewLine_T();
                            newLine.ReadXml(reader);
                            items.Add(newLine);
                            break;

                        case "Address":
                            var address = new Address_T_v2();
                            address.ReadXml(reader);
                            Item = address;
                            break;
                        case "CallInfo":
                            var callInfo = new CallInfo_T_v5();
                            callInfo.ReadXml(reader);
                            Item = callInfo;
                            break;
                        case "Constant":
                            var startValue = new Constant_T_v2();
                            startValue.ReadXml(reader);
                            Item = startValue;
                            break;
                        case "Expression":
                            var expression = new Expression_T_v5();
                            expression.ReadXml(reader);
                            Item = expression;
                            break;
                        case "Indirect":
                            var indirect = new Indirect_T_v5();
                            indirect.ReadXml(reader);
                            Item = indirect;
                            break;
                        case "Instruction":
                            var instruction = new Instruction_T_v5();
                            instruction.ReadXml(reader);
                            Item = instruction;
                            break;
                        case "Label":
                            var label = new Label_T_v4();
                            label.ReadXml(reader);
                            Item = label;
                            break;
                        case "Statusword":
                            var statusword = new Statusword_T();
                            statusword.ReadXml(reader);
                            Item = statusword;
                            break;
                        case "Symbol":
                            var symbol = new Symbol_T_v5();
                            symbol.ReadXml(reader);
                            Item = symbol;
                            break;
                        case "DataType":
                            var dataType = new DataType_T();
                            dataType.ReadXml(reader);
                            Item = dataType;
                            break;
                        case "PredefinedVariable":
                            var predefinedVariable = new PredefinedVariable_T();
                            predefinedVariable.ReadXml(reader);
                            Item = predefinedVariable;
                            break;
                        case "Reference":
                            var reference = new Reference_T_v5();
                            reference.ReadXml(reader);
                            Item = reference;
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
                if (items.Count > 0) Comments = items.ToArray();
            }

            if (reader.IsStartElement())
                reader.Read();
            else
                reader.ReadEndElement();
        }

        public override void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }
}
