using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Access
{
    public interface ICallInfo_T : IEnumerable<Object_G>
    {
        string Name { get; set; }
        BlockType_TE BlockType { get; set; }
    }

    public interface ICallInfo_T_v2 : ICallInfo_T
    {
        int? UId { get; set; }
    }

    /// <summary>
    /// Not for LAD/FBD.
    /// </summary>

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_PlcBlocks_Access => SW.Common</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("CallInfo", IsNullable = false)]
    public class CallInfo_T : Object_G, ICallInfo_T
    {
        //[XmlElement(Order = 0)]
        //public IntegerAttribute_T IntegerAttribute { get; set; }

        //[XmlElement(Order = 1)]
        //public DateAttribute_T DateAttribute { get; set; }

        //[XmlElement("IntegerAttribute", typeof(Common.IntegerAttribute_T), Order = 0)]
        //[XmlElement("Comment", typeof(Common.Comment_T), Order = 2 | 4)]
        //[XmlElement("LineComment", typeof(Common.LineComment_T), Order = 2 | 4)]
        //[XmlElement("DateAttribute", typeof(Common.DateAttribute_T), Order = 1)]
        //[XmlElement("Token", typeof(Common.Token_T), Order = 3)]
        //[XmlElement("Instance", typeof(Instance_T), Order = 5)]
        //[XmlElement("Parameter", typeof(Parameter_T), Order = 6)]
        protected internal Object_G[] Items { get; set; }
        public Object_G this[int key] { get => Items[key]; set => Items[key] = value; }

        //[XmlElement(Order = 3)]
        //public Token_T Token { get; set; }

        //[XmlElement("Comment", typeof(Comment), Order = 4)]
        //[XmlElement("LineComment", typeof(LineComment_T), Order = 4)]
        //public object[] Items1 { get; set; }

        //[XmlElement(Order = 5)]
        //public Instance_T Instance { get; set; }

        //[XmlElement("Parameter", Order = 6)]
        //public Parameter_T[] Parameter { get; set; }

        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
        public BlockType_TE BlockType { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(BlockType):
                        Enum.TryParse<BlockType_TE>(reader.ReadContentAsString(), out var blockType);
                        BlockType = blockType;
                        break;
                    case nameof(Name):
                        Name = reader.ReadContentAsString();
                        break;
                }
            }

            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var items = new List<Object_G>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "IntegerAttribute":
                            var integerAttribute = new Common.IntegerAttribute_T();
                            integerAttribute.ReadXml(reader);
                            items.Add(integerAttribute);
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
                        case "DateAttribute":
                            var dateAttribute = new Common.DateAttribute_T();
                            dateAttribute.ReadXml(reader);
                            items.Add(dateAttribute);
                            break;
                        case "Token":
                            var token = new Common.Token_T();
                            token.ReadXml(reader);
                            items.Add(token);
                            break;
                        case "Instance":
                            var instance = new Instance_T();
                            instance.ReadXml(reader);
                            items.Add(instance);
                            break;
                        case "Parameter":
                            var parameter = new Parameter_T();
                            parameter.ReadXml(reader);
                            items.Add(parameter);
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
                if (items.Count > 0) Items = items.ToArray();
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

        public IEnumerator<Object_G> GetEnumerator()
        {
            if (Items is null) yield break; 
            foreach (var item in Items)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }

    /// <summary>
    /// Not for LAD/FBD.
    /// </summary>
    /// <remarks>
    /// Schema :
    /// <list type="bullet">
    /// <item>SW_PlcBlocks_Access_v2 => SW.Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("CallInfo", IsNullable = false)]
    public class CallInfo_T_v2 : CallInfo_T, ICallInfo_T_v2
    {
        //[XmlElement("Blank", typeof(Common.Blank_T), Order = 0 | 3 | 6 | 9)]
        //[XmlElement("Comment", typeof(Common.Comment_T_v2), Order = 0 | 3 | 6 | 9)]
        //[XmlElement("DateAttribute", typeof(Common.DateAttribute_T_v2), Order = 0)]                // for ParameterModifiedTS. ParameterModifiedTS is informative
        //[XmlElement("IntegerAttribute", typeof(Common.IntegerAttribute_T_v2), Order = 0)]          // for BlockNumber. BlockNumber is informative.
        //[XmlElement("LineComment", typeof(Common.LineComment_T_v2), Order = 0 | 3 | 6 | 9)]
        //[XmlElement("NewLine", typeof(Common.NewLine_T), Order = 0 | 3 | 6 | 9)]
        //[XmlElement("Token", typeof(Common.Token_T_v2), Order = 0 | 2 | 5 | 8)]
        //[XmlElement("Instance", typeof(Instance_T_v2), Order = 1)]
        //[XmlElement("NamelessParameter", typeof(NamelessParameter_T), Order = 4)]
        //[XmlElement("Parameter", typeof(Parameter_T_v2), Order = 7)]
        //protected internal new Object_G[] Items { get; set; }
        //public new Object_G this[int key] { get => Items[key]; set => Items[key] = value; }

        //[XmlElement(Order = 1)]
        //public Instance_T Instance { get; set; }

        //[XmlElement("Token", Order = 2)]
        //public Token_T[] Token { get; set; }

        //[XmlElement("Blank", typeof(Common.Blank_T), Order = 3)]
        //[XmlElement("Comment", typeof(Common.Comment_T_v2), Order = 3)]
        //[XmlElement("LineComment", typeof(Common.LineComment_T_v2), Order = 3)]
        //[XmlElement("NewLine", typeof(Common.NewLine_T), Order = 3)]
        //public object[] Items1 { get; set; }

        //[XmlElement("NamelessParameter", Order = 4)]
        //public NamelessParameter_T[] NamelessParameter {  get; set; }

        //[XmlElement("Token", Order = 5)]
        //public Token_T[] Token1 { get; set; }

        //[XmlElement("Blank", typeof(Blank_T), Order = 6)]
        //[XmlElement("Comment", typeof(Common.Comment_T_v2), Order = 6)]
        //[XmlElement("LineComment", typeof(Common.LineComment_T_v2), Order = 6)]
        //[XmlElement("NewLine", typeof(Common.NewLine_T), Order = 6)]
        //public object[] Items2 { get; set; }

        //[XmlElement("Parameter", Order = 7)]
        //public Parameter_T[] Parameter { get; set; }

        //[XmlElement("Token", Order = 8)]
        //public Token_T[] Token2 { get; set; }

        //[XmlElement("Blank", typeof(Blank_T), Order = 9)]
        //[XmlElement("Comment", typeof(Comment_T), Order = 9)]
        //[XmlElement("LineComment", typeof(LineComment_T), Order = 9)]
        //[XmlElement("NewLine", typeof(NewLine_T), Order = 9)]
        //public object[] Items3 { get; set; }

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
                    case nameof(BlockType):
                        Enum.TryParse<BlockType_TE>(reader.ReadContentAsString(), out var blockType);
                        BlockType = blockType;
                        break;
                    case nameof(Name):
                        Name = reader.ReadContentAsString();
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

                var items = new List<Object_G>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
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
                        case "DateAttribute":
                            var dateAttribute = new Common.DateAttribute_T_v2();
                            dateAttribute.ReadXml(reader);
                            items.Add(dateAttribute);
                            break;
                        case "IntegerAttribute":
                            var integerAttribute = new Common.IntegerAttribute_T_v2();
                            integerAttribute.ReadXml(reader);
                            items.Add(integerAttribute);
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
                        case "Token":
                            var token = new Common.Token_T_v2();
                            token.ReadXml(reader);
                            items.Add(token);
                            break;
                        case "Instance":
                            var instance = new Instance_T_v2();
                            instance.ReadXml(reader);
                            items.Add(instance);
                            break;
                        case "NamelessParameter":
                            var namelessParameter = new NamelessParameter_T();
                            namelessParameter.ReadXml(reader);
                            items.Add(namelessParameter);
                            break;
                        case "Parameter":
                            var parameter = new Parameter_T_v2();
                            parameter.ReadXml(reader);
                            items.Add(parameter);
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
                if (items.Count > 0) Items = items.ToArray();
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

        //public new IEnumerator<Object_G> GetEnumerator()
        //{
        //    foreach (var item in Items)
        //    {
        //        yield return item;
        //    }
        //}

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }

    /// <summary>
    /// Not for LAD/FBD.
    /// </summary>
    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_PlcBlocks_Access_v3 => SW.Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("CallInfo", IsNullable = false)]
    public class CallInfo_T_v3 : CallInfo_T_v2, ICallInfo_T_v2
    {
        //[XmlElement("Blank", typeof(Common.Blank_T))]
        //[XmlElement("Comment", typeof(Common.Comment_T_v2))]
        //[XmlElement("DateAttribute", typeof(Common.DateAttribute_T_v2))]                // for ParameterModifiedTS. ParameterModifiedTS is informative
        //[XmlElement("Instance", typeof(Instance_T_v3))]
        //[XmlElement("IntegerAttribute", typeof(Common.IntegerAttribute_T_v2))]          // for BlockNumber. BlockNumber is informative.
        //[XmlElement("LineComment", typeof(Common.LineComment_T_v2))]
        //[XmlElement("NamelessParameter", typeof(NamelessParameter_T_v3))]
        //[XmlElement("NewLine", typeof(Common.NewLine_T))]
        //[XmlElement("Parameter", typeof(Parameter_T_v3))]
        //[XmlElement("Token", typeof(Common.Token_T_v2))]
        //protected internal new Object_G[] Items { get; set; }
        //public new Object_G this[int key] { get => Items[key]; set => Items[key] = value; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(BlockType):
                        Enum.TryParse<BlockType_TE>(reader.ReadContentAsString(), out var blockType);
                        BlockType = blockType;
                        break;
                    case nameof(Name):
                        Name = reader.ReadContentAsString();
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

                var items = new List<Object_G>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
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
                        case "DateAttribute":
                            var dateAttribute = new Common.DateAttribute_T_v2();
                            dateAttribute.ReadXml(reader);
                            items.Add(dateAttribute);
                            break;
                        case "IntegerAttribute":
                            var integerAttribute = new Common.IntegerAttribute_T_v2();
                            integerAttribute.ReadXml(reader);
                            items.Add(integerAttribute);
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
                        case "Token":
                            var token = new Common.Token_T_v2();
                            token.ReadXml(reader);
                            items.Add(token);
                            break;
                        case "Instance":
                            var instance = new Instance_T_v3();
                            instance.ReadXml(reader);
                            items.Add(instance);
                            break;
                        case "NamelessParameter":
                            var namelessParameter = new NamelessParameter_T_v3();
                            namelessParameter.ReadXml(reader);
                            items.Add(namelessParameter);
                            break;
                        case "Parameter":
                            var parameter = new Parameter_T_v3();
                            parameter.ReadXml(reader);
                            items.Add(parameter);
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
                if (items.Count > 0) Items = items.ToArray();
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

        //public new IEnumerator<Object_G> GetEnumerator()
        //{
        //    foreach (var item in Items)
        //    {
        //        yield return item;
        //    }
        //}

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }

    /// <summary>
    /// Not for LAD/FBD.
    /// </summary>
    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_PlcBlocks_Access_v4 => SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("CallInfo", IsNullable = false)]
    public class CallInfo_T_v4 : CallInfo_T_v3, ICallInfo_T_v2
    {
        //[XmlElement("Blank", typeof(Common.Blank_T))]
        //[XmlElement("Comment", typeof(Common.Comment_T_v2))]
        //[XmlElement("DateAttribute", typeof(Common.DateAttribute_T_v2))]                // for ParameterModifiedTS. ParameterModifiedTS is informative
        //[XmlElement("Instance", typeof(Instance_T_v4))]
        //[XmlElement("IntegerAttribute", typeof(Common.IntegerAttribute_T_v2))]          // for BlockNumber. BlockNumber is informative.
        //[XmlElement("LineComment", typeof(Common.LineComment_T_v3))]
        //[XmlElement("NamelessParameter", typeof(NamelessParameter_T_v4))]
        //[XmlElement("NewLine", typeof(Common.NewLine_T))]
        //[XmlElement("Parameter", typeof(Parameter_T_v4))]
        //[XmlElement("Token", typeof(Common.Token_T_v2))]
        //protected internal new Object_G[] Items { get; set; }
        //public new Object_G this[int key] { get => Items[key]; set => Items[key] = value; }

        public override void ReadXml(XmlReader reader)
        {
            _ = Enum.TryParse<BlockType_TE>(reader.GetAttribute("BlockType"), out var blockType);
            BlockType = blockType;

            Name = reader.GetAttribute("Name");

            UIdSpecified = int.TryParse(reader.GetAttribute("UId"), out var uId);
            if (UIdSpecified) UId = uId;

            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var items = new List<Object_G>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
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
                        case "DateAttribute":
                            var dateAttribute = new Common.DateAttribute_T_v2();
                            dateAttribute.ReadXml(reader);
                            items.Add(dateAttribute);
                            break;
                        case "IntegerAttribute":
                            var integerAttribute = new Common.IntegerAttribute_T_v2();
                            integerAttribute.ReadXml(reader);
                            items.Add(integerAttribute);
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
                        case "Token":
                            var token = new Common.Token_T_v2();
                            token.ReadXml(reader);
                            items.Add(token);
                            break;
                        case "Instance":
                            var instance = new Instance_T_v4();
                            instance.ReadXml(reader);
                            items.Add(instance);
                            break;
                        case "NamelessParameter":
                            var namelessParameter = new NamelessParameter_T_v4();
                            namelessParameter.ReadXml(reader);
                            items.Add(namelessParameter);
                            break;
                        case "Parameter":
                            var parameter = new Parameter_T_v4();
                            parameter.ReadXml(reader);
                            items.Add(parameter);
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
                if (items.Count > 0) Items = items.ToArray();
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

        //public new IEnumerator<Object_G> GetEnumerator()
        //{
        //    foreach (var item in Items)
        //    {
        //        yield return item;
        //    }
        //}

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }

    /// <summary>
    /// Not for LAD/FBD.
    /// </summary>
    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_PlcBlocks_Access_v5 => SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("CallInfo", IsNullable = false)]
    public class CallInfo_T_v5 : CallInfo_T_v4, ICallInfo_T_v2
    {
        //[XmlElement("Blank", typeof(Common.Blank_T))]
        //[XmlElement("Comment", typeof(Common.Comment_T_v2))]
        //[XmlElement("DateAttribute", typeof(Common.DateAttribute_T_v2))]                // for ParameterModifiedTS. ParameterModifiedTS is informative
        //[XmlElement("Instance", typeof(Instance_T_v5))]
        //[XmlElement("IntegerAttribute", typeof(Common.IntegerAttribute_T_v2))]          // for BlockNumber. BlockNumber is informative.
        //[XmlElement("LineComment", typeof(Common.LineComment_T_v3))]
        //[XmlElement("NamelessParameter", typeof(NamelessParameter_T_v5))]
        //[XmlElement("NewLine", typeof(Common.NewLine_T))]
        //[XmlElement("Parameter", typeof(Parameter_T_v5))]
        //[XmlElement("Token", typeof(Common.Token_T_v2))]
        //protected internal new Object_G[] Items { get; set; }
        //public new Object_G this[int key] { get => Items[key]; set => Items[key] = value; }

        public override void ReadXml(XmlReader reader)
        {
            _ = Enum.TryParse<BlockType_TE>(reader.GetAttribute("BlockType"), out var blockType);
            BlockType = blockType;

            Name = reader.GetAttribute("Name");

            UIdSpecified = int.TryParse(reader.GetAttribute("UId"), out var uId);
            if (UIdSpecified) UId = uId;

            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var items = new List<Object_G>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
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
                        case "DateAttribute":
                            var dateAttribute = new Common.DateAttribute_T_v2();
                            dateAttribute.ReadXml(reader);
                            items.Add(dateAttribute);
                            break;
                        case "IntegerAttribute":
                            var integerAttribute = new Common.IntegerAttribute_T_v2();
                            integerAttribute.ReadXml(reader);
                            items.Add(integerAttribute);
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
                        case "Token":
                            var token = new Common.Token_T_v2();
                            token.ReadXml(reader);
                            items.Add(token);
                            break;
                        case "Instance":
                            var instance = new Instance_T_v5();
                            instance.ReadXml(reader);
                            items.Add(instance);
                            break;
                        case "NamelessParameter":
                            var namelessParameter = new NamelessParameter_T_v5();
                            namelessParameter.ReadXml(reader);
                            items.Add(namelessParameter);
                            break;
                        case "Parameter":
                            var parameter = new Parameter_T_v5();
                            parameter.ReadXml(reader);
                            items.Add(parameter);
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
                if (items.Count > 0) Items = items.ToArray();
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

        //public new IEnumerator<Object_G> GetEnumerator()
        //{
        //    foreach (var item in Items)
        //    {
        //        yield return item;
        //    }
        //}

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
