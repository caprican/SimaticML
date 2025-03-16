using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Access
{
    public interface IIndirect : IEnumerable<Object_G>
    {
        Width_TE Width { get; set; }
        Area_TE? Area { get; set; }
        Register_TE? Register { get; set; }
        string BitOffset { get; set; }
        IAccess_T Access { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_PlcBlocks_Access => SW.Common</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Indirect", IsNullable = false)]
    public class Indirect_T : Object_G, IIndirect
    {
        [XmlAttribute]
        public Width_TE Width { get; set; }

        [XmlAttribute]
        public Area_TE? Area { get; set; } = null;
        [XmlIgnore]
        public bool AreaSpecified { get; set; }

        [XmlAttribute]
        public Register_TE? Register { get; set; } = null;
        [XmlIgnore]
        public bool RegisterSpecified { get; set; }

        [XmlAttribute]
        public string BitOffset { get; set; }

        //[XmlElement("Comment", typeof(Common.Comment_T))]
        //[XmlElement("LineComment", typeof(Common.LineComment_T))]
        //[XmlElement("Token", typeof(Common.Token_T))]
        protected internal Object_G[] Items { get; set; }
        public Object_G this[int key] { get => Items[key]; set => Items[key] = value; }

        public IAccess_T Access { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(Area):
                        Enum.TryParse<Area_TE>(reader.ReadContentAsString(), out var area);
                        Area = area;
                        AreaSpecified = true;
                        break;
                    case nameof(Width):
                        Enum.TryParse<Width_TE>(reader.ReadContentAsString(), out var width);
                        Width = width;
                        break;
                    case nameof(Register):
                        Enum.TryParse<Register_TE>(reader.ReadContentAsString(), out var register);
                        Register = register;
                        RegisterSpecified = true;
                        break;
                    case nameof(BitOffset):
                        BitOffset = reader.ReadContentAsString();
                        break;

                    default:
                        reader.Skip();
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
                        case "Access":
                            var access = new Access_T();
                            access.ReadXml(reader);
                            Access = access;
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
                        case "Token":
                            var token = new Common.Token_T_v2();
                            token.ReadXml(reader);
                            items.Add(token);
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

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_PlcBlocks_Access_v2 => SW.Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Indirect", IsNullable = false)]
    public class Indirect_T_v2 : Indirect_T, IIndirect
    {
        //[XmlElement("Blank", typeof(Common.Blank_T))]
        //[XmlElement("Comment", typeof(Common.Comment_T_v2))]
        //[XmlElement("LineComment", typeof(Common.LineComment_T_v2))]
        //[XmlElement("NewLine", typeof(Common.NewLine_T))]
        //[XmlElement("Token", typeof(Common.Token_T_v2))]

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(Area):
                        Enum.TryParse<Area_TE>(reader.ReadContentAsString(), out var area);
                        Area = area;
                        AreaSpecified = true;
                        break;
                    case nameof(Width):
                        Enum.TryParse<Width_TE>(reader.ReadContentAsString(), out var width);
                        Width = width;
                        break;
                    case nameof(Register):
                        Enum.TryParse<Register_TE>(reader.ReadContentAsString(), out var register);
                        Register = register;
                        RegisterSpecified = true;
                        break;
                    case nameof(BitOffset):
                        BitOffset = reader.ReadContentAsString();
                        break;

                    default:
                        reader.Skip();
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
                        case "Access":
                            var access = new Access_T_v2();
                            access.ReadXml(reader);
                            Access = access;
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
                        case "Token":
                            var token = new Common.Token_T_v2();
                            token.ReadXml(reader);
                            items.Add(token);
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

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_PlcBlocks_Access_v3 => SW.Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Indirect", IsNullable = false)]
    public class Indirect_T_v3 : Indirect_T_v2, IIndirect
    {
        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(Area):
                        Enum.TryParse<Area_TE>(reader.ReadContentAsString(), out var area);
                        Area = area;
                        AreaSpecified = true;
                        break;
                    case nameof(Width):
                        Enum.TryParse<Width_TE>(reader.ReadContentAsString(), out var width);
                        Width = width;
                        break;
                    case nameof(Register):
                        Enum.TryParse<Register_TE>(reader.ReadContentAsString(), out var register);
                        Register = register;
                        RegisterSpecified = true;
                        break;
                    case nameof(BitOffset):
                        BitOffset = reader.ReadContentAsString();
                        break;

                    default:
                        reader.Skip();
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
                        case "Access":
                            var access = new Access_T_v3();
                            access.ReadXml(reader);
                            Access = access;
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
                        case "Token":
                            var token = new Common.Token_T_v2();
                            token.ReadXml(reader);
                            items.Add(token);
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

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_PlcBlocks_Access_v4 => SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Indirect", IsNullable = false)]
    public class Indirect_T_v4 : Indirect_T_v3, IIndirect
    {
        //[XmlElement("Blank", typeof(Common.Blank_T))]
        //[XmlElement("Comment", typeof(Common.Comment_T_v2))]
        //[XmlElement("LineComment", typeof(Common.LineComment_T_v3))]
        //[XmlElement("NewLine", typeof(Common.NewLine_T))]
        //[XmlElement("Token", typeof(Common.Token_T_v2))]

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(Area):
                        Enum.TryParse<Area_TE>(reader.ReadContentAsString(), out var area);
                        Area = area;
                        AreaSpecified = true;
                        break;
                    case nameof(Width):
                        Enum.TryParse<Width_TE>(reader.ReadContentAsString(), out var width);
                        Width = width;
                        break;
                    case nameof(Register):
                        Enum.TryParse<Register_TE>(reader.ReadContentAsString(), out var register);
                        Register = register;
                        RegisterSpecified = true;
                        break;
                    case nameof(BitOffset):
                        BitOffset = reader.ReadContentAsString();
                        break;

                    default:
                        reader.Skip();
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
                        case "Access":
                            var access = new Access_T_v4();
                            access.ReadXml(reader);
                            Access = access;
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
                        case "Token":
                            var token = new Common.Token_T_v2();
                            token.ReadXml(reader);
                            items.Add(token);
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

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_PlcBlocks_Access_v5 => SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Indirect", IsNullable = false)]
    public class Indirect_T_v5 : Indirect_T_v4, IIndirect
    {
        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(Area):
                        Enum.TryParse<Area_TE>(reader.ReadContentAsString(), out var area);
                        Area = area;
                        AreaSpecified = true;
                        break;
                    case nameof(Width):
                        Enum.TryParse<Width_TE>(reader.ReadContentAsString(), out var width);
                        Width = width;
                        break;
                    case nameof(Register):
                        Enum.TryParse<Register_TE>(reader.ReadContentAsString(), out var register);
                        Register = register;
                        RegisterSpecified = true;
                        break;
                    case nameof(BitOffset):
                        BitOffset = reader.ReadContentAsString();
                        break;

                    default:
                        reader.Skip();
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
                        case "Access":
                            var access = new Access_T_v5();
                            access.ReadXml(reader);
                            Access = access;
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
                        case "Token":
                            var token = new Common.Token_T_v2();
                            token.ReadXml(reader);
                            items.Add(token);
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

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
