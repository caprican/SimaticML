using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.SCL
{
    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.SCL => SW.PlcBlocks.Access_v2 + SW.Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("StructuredText", IsNullable = false)]
    public class StructuredText_T : Object_G
    {
        [XmlElement("Access", typeof(Access.Access_T_v2))]
        [XmlElement("Blank", typeof(Common.Blank_T))]
        [XmlElement("Comment", typeof(Common.Comment_T_v2))]
        [XmlElement("LineComment", typeof(Common.LineComment_T_v2))]
        [XmlElement("NewLine", typeof(Common.NewLine_T))]
        [XmlElement("Parameter", typeof(Access.Parameter_T_v2))]
        [XmlElement("Text", typeof(Common.Text_T_v2))]
        [XmlElement("Token", typeof(Common.Token_T_v2))]
        protected internal Object_G[] Items { get; set; }
        public Object_G this[int key]
        {
            get => Items[key];
            set => Items[key] = value;
        }

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
                        case "Access":
                            var access = new Access.Access_T_v2();
                            access.ReadXml(reader);
                            items.Add(access);
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
                        case "Parameter":
                            var parameter = new Access.Parameter_T_v2();
                            parameter.ReadXml(reader);
                            items.Add(parameter);
                            break;
                        case "Text":
                            var text = new Common.Text_T_v2();
                            text.ReadXml(reader);
                            items.Add(text);
                            break;
                        case "Token":
                            var token = new Common.Token_T_v2();
                            token.ReadXml(reader);
                            items.Add(token);
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
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.SCL_v2 => SW.PlcBlocks.Access_v3 + SW.Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("StructuredText", IsNullable = false)]
    public class StructuredText_T_v2 : StructuredText_T
    {
        [XmlElement("Access", typeof(Access.Access_T_v3))]
        [XmlElement("Blank", typeof(Common.Blank_T))]
        [XmlElement("Comment", typeof(Common.Comment_T_v2))]
        [XmlElement("LineComment", typeof(Common.LineComment_T_v2))]
        [XmlElement("NewLine", typeof(Common.NewLine_T))]
        [XmlElement("Parameter", typeof(Access.Parameter_T_v3))]
        [XmlElement("Text", typeof(Common.Text_T_v2))]
        [XmlElement("Token", typeof(Common.Token_T_v2))]
        protected internal new Object_G[] Items { get; set; }
        public new Object_G this[int key]
        {
            get => Items[key];
            set => Items[key] = value;
        }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
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
                        case "Access":
                            var access = new Access.Access_T_v3();
                            access.ReadXml(reader);
                            items.Add(access);
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
                        case "Parameter":
                            var parameter = new Access.Parameter_T_v3();
                            parameter.ReadXml(reader);
                            items.Add(parameter);
                            break;
                        case "Text":
                            var text = new Common.Text_T_v2();
                            text.ReadXml(reader);
                            items.Add(text);
                            break;
                        case "Token":
                            var token = new Common.Token_T_v2();
                            token.ReadXml(reader);
                            items.Add(token);
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
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.SCL_v3 => SW.PlcBlocks.Access_v4 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("StructuredText", IsNullable = false)]
    public class StructuredText_T_v3 : StructuredText_T_v2
    {
        [XmlElement("Access", typeof(Access.Access_T_v4))]
        [XmlElement("Blank", typeof(Common.Blank_T))]
        [XmlElement("Comment", typeof(Common.Comment_T_v2))]
        [XmlElement("LineComment", typeof(Common.LineComment_T_v3))]
        [XmlElement("NewLine", typeof(Common.NewLine_T))]
        [XmlElement("Parameter", typeof(Access.Parameter_T_v4))]
        [XmlElement("Text", typeof(Common.Text_T_v2))]
        [XmlElement("Token", typeof(Common.Token_T_v2))]
        protected internal new Object_G[] Items { get; set; }
        public new Object_G this[int key]
        {
            get => Items[key];
            set => Items[key] = value;
        }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
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
                        case "Access":
                            var access = new Access.Access_T_v4();
                            access.ReadXml(reader);
                            items.Add(access);
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
                        case "Parameter":
                            var parameter = new Access.Parameter_T_v4();
                            parameter.ReadXml(reader);
                            items.Add(parameter);
                            break;
                        case "Text":
                            var text = new Common.Text_T_v2();
                            text.ReadXml(reader);
                            items.Add(text);
                            break;
                        case "Token":
                            var token = new Common.Token_T_v2();
                            token.ReadXml(reader);
                            items.Add(token);
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
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.SCL_v4 => SW.PlcBlocks.Access_v5 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("StructuredText", IsNullable = false)]
    public class StructuredText_T_v4 : StructuredText_T_v3
    {
        [XmlElement("Access", typeof(Access.Access_T_v5))]
        [XmlElement("Blank", typeof(Common.Blank_T))]
        [XmlElement("Comment", typeof(Common.Comment_T_v2))]
        [XmlElement("LineComment", typeof(Common.LineComment_T_v3))]
        [XmlElement("NewLine", typeof(Common.NewLine_T))]
        [XmlElement("Parameter", typeof(Access.Parameter_T_v5))]
        [XmlElement("Text", typeof(Common.Text_T_v2))]
        [XmlElement("Token", typeof(Common.Token_T_v2))]
        protected internal new Object_G[] Items { get; set; }
        public new Object_G this[int key]
        {
            get => Items[key];
            set => Items[key] = value;
        }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
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
                        case "Access":
                            var access = new Access.Access_T_v5();
                            access.ReadXml(reader);
                            items.Add(access);
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
                        case "Parameter":
                            var parameter = new Access.Parameter_T_v5();
                            parameter.ReadXml(reader);
                            items.Add(parameter);
                            break;
                        case "Text":
                            var text = new Common.Text_T_v2();
                            text.ReadXml(reader);
                            items.Add(text);
                            break;
                        case "Token":
                            var token = new Common.Token_T_v2();
                            token.ReadXml(reader);
                            items.Add(token);
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
    }
}
