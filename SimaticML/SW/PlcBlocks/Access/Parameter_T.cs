using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Access
{
    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_PlcBlocks_Access => SW.Common</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Parameter", IsNullable = false)]
    public class Parameter_T : Object_G
    {
        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
        public Common.SectionName_TE? Section { get; set; } = null;
        [XmlIgnore]
        public bool SectionSpecified { get; set; }

        [XmlAttribute]
        public string Type { get; set; }

        [XmlAttribute]
        public string TemplateReference { get; set; }

        [XmlElement("IntegerAttribute" , typeof(Common.IntegerAttribute_T), Order = 0)]                // for NumBLs. NumBLs is informative
        [XmlElement("StringAttribute", typeof(Common.StringAttribute_T), Order = 1)]                   // for InterfaceFlags. InterfaceFlags is informative. The type of the value should be InterfaceFlags_TP. The default value is "S7_Visible"
        [XmlElement("Comment", typeof(Common.Comment_T), Order = 2 | 4)]
        [XmlElement("LineComment", typeof(Common.LineComment_T), Order = 2 | 4)]
        [XmlElement("Access", typeof(Access_T), Order = 3)]
        protected internal Object_G[] Items { get; set; }
        public Object_G this[int key] { get => Items[key]; set => Items[key] = value; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(Section):
                        Enum.TryParse<Common.SectionName_TE>(reader.ReadContentAsString(), out var section);
                        SectionSpecified = true;
                        break;
                    case nameof(Name):
                        Name = reader.ReadContentAsString();
                        break;
                    case nameof(Type):
                        Type = reader.ReadContentAsString();
                        break;
                    case nameof(TemplateReference):
                        TemplateReference = reader.ReadContentAsString();
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
                        case "StringAttribute":
                            var stringAttribute = new Common.StringAttribute_T();
                            stringAttribute.ReadXml(reader);
                            items.Add(stringAttribute);
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
                        case "Access":
                            var access = new Access_T();
                            access.ReadXml(reader);
                            items.Add(access);
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
    /// <item>SW_PlcBlocks_Access_v2 => SW.Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Parameter", IsNullable = false)]
    public class Parameter_T_v2 : Parameter_T, IEnumerable<Object_G>
    {
        /// <summary>
        /// for NumBLs. NumBLs is informative
        /// </summary>
        [XmlElement]
        public Common.IntegerAttribute_T_v2 IntegerAttribute { get; set; }

        /// <summary>
        /// for InterfaceFlags. InterfaceFlags is informative
        /// The type of the value should be InterfaceFlags_TP
        /// The default value is "S7_Visible"
        /// </summary>
        [XmlElement]
        public Common.StringAttribute_T_v2 StringAttribute { get; set; }

        [XmlElement("BooleanAttribute", typeof(Common.BooleanAttribute_T_v2))]
        [XmlElement("Access", typeof(Access_T_v2))]
        [XmlElement("Blank", typeof(Common.Blank_T))]
        [XmlElement("Comment", typeof(Common.Comment_T_v2))]
        [XmlElement("LineComment", typeof(Common.LineComment_T_v2))]
        [XmlElement("NewLine", typeof(Common.NewLine_T))]
        [XmlElement("Token", typeof(Common.Token_T_v2))]
        protected internal new Object_G[] Items { get; set; }
        public new Object_G this[int key] { get => Items[key]; set => Items[key] = value; }

        [XmlAttribute]
        [DefaultValue(false)]
        public bool Informative { get; set; } = false;

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
                    case nameof(Informative):
                        Informative = reader.ReadContentAsBoolean();
                        break;
                    case nameof(Section):
                        Enum.TryParse<Common.SectionName_TE>(reader.ReadContentAsString(), out var section);
                        SectionSpecified = true;
                        break;
                    case nameof(Name):
                        Name = reader.ReadContentAsString();
                        break;
                    case nameof(Type):
                        Type = reader.ReadContentAsString();
                        break;
                    case nameof(TemplateReference):
                        TemplateReference = reader.ReadContentAsString();
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
                        case "IntegerAttribute":
                            IntegerAttribute = new Common.IntegerAttribute_T_v2();
                            IntegerAttribute.ReadXml(reader);
                            break;
                        case "StringAttribute":
                            StringAttribute = new Common.StringAttribute_T_v2();
                            StringAttribute.ReadXml(reader);
                            break;
                        case "BooleanAttribute":
                            var booleanAttribute = new Common.BooleanAttribute_T_v2();
                            booleanAttribute.ReadXml(reader);
                            items.Add(booleanAttribute);
                            break;
                        case "Access":
                            var access = new Access_T_v2();
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

        public IEnumerator<Object_G> GetEnumerator()
        {
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
    /// <item>SW_PlcBlocks_Access_v3 => SW.Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Parameter", IsNullable = false)]
    public class Parameter_T_v3 : Parameter_T_v2, IEnumerable<Object_G>
    {
        [XmlElement("BooleanAttribute", typeof(Common.BooleanAttribute_T_v2))]
        [XmlElement("Access", typeof(Access_T_v3))]
        [XmlElement("Blank", typeof(Common.Blank_T))]
        [XmlElement("Comment", typeof(Common.Comment_T_v2))]
        [XmlElement("LineComment", typeof(Common.LineComment_T_v2))]
        [XmlElement("NewLine", typeof(Common.NewLine_T))]
        [XmlElement("Token", typeof(Common.Token_T_v2))]
        protected internal new Object_G[] Items { get; set; }
        public new Object_G this[int key] { get => Items[key]; set => Items[key] = value; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(Informative):
                        Informative = reader.ReadContentAsBoolean();
                        break;
                    case nameof(Section):
                        Enum.TryParse<Common.SectionName_TE>(reader.ReadContentAsString(), out var section);
                        SectionSpecified = true;
                        break;
                    case nameof(Name):
                        Name = reader.ReadContentAsString();
                        break;
                    case nameof(Type):
                        Type = reader.ReadContentAsString();
                        break;
                    case nameof(TemplateReference):
                        TemplateReference = reader.ReadContentAsString();
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
                        case "IntegerAttribute":
                            IntegerAttribute = new Common.IntegerAttribute_T_v2();
                            IntegerAttribute.ReadXml(reader);
                            break;
                        case "StringAttribute":
                            StringAttribute = new Common.StringAttribute_T_v2();
                            StringAttribute.ReadXml(reader);
                            break;
                        case "BooleanAttribute":
                            var booleanAttribute = new Common.BooleanAttribute_T_v2();
                            booleanAttribute.ReadXml(reader);
                            items.Add(booleanAttribute);
                            break;
                        case "Access":
                            var access = new Access_T_v3();
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

        public new IEnumerator<Object_G> GetEnumerator()
        {
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
    /// <item>SW_PlcBlocks_Access_v4 => SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Parameter", IsNullable = false)]
    public class Parameter_T_v4 : Parameter_T_v3, IEnumerable<Object_G>
    {
        [XmlElement("BooleanAttribute", typeof(Common.BooleanAttribute_T_v2))]
        [XmlElement("Access", typeof(Access_T_v4))]
        [XmlElement("Blank", typeof(Common.Blank_T))]
        [XmlElement("Comment", typeof(Common.Comment_T_v2))]
        [XmlElement("LineComment", typeof(Common.LineComment_T_v3))]
        [XmlElement("NewLine", typeof(Common.NewLine_T))]
        [XmlElement("Token", typeof(Common.Token_T_v2))]
        protected internal new Object_G[] Items { get; set; }
        public new Object_G this[int key] { get => Items[key]; set => Items[key] = value; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(Informative):
                        Informative = reader.ReadContentAsBoolean();
                        break;
                    case nameof(Section):
                        Enum.TryParse<Common.SectionName_TE>(reader.ReadContentAsString(), out var section);
                        SectionSpecified = true;
                        break;
                    case nameof(Name):
                        Name = reader.ReadContentAsString();
                        break;
                    case nameof(Type):
                        Type = reader.ReadContentAsString();
                        break;
                    case nameof(TemplateReference):
                        TemplateReference = reader.ReadContentAsString();
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
                        case "IntegerAttribute":
                            IntegerAttribute = new Common.IntegerAttribute_T_v2();
                            IntegerAttribute.ReadXml(reader);
                            break;
                        case "StringAttribute":
                            StringAttribute = new Common.StringAttribute_T_v2();
                            StringAttribute.ReadXml(reader);
                            break;
                        case "BooleanAttribute":
                            var booleanAttribute = new Common.BooleanAttribute_T_v2();
                            booleanAttribute.ReadXml(reader);
                            items.Add(booleanAttribute);
                            break;
                        case "Access":
                            var access = new Access_T_v4();
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

        public new IEnumerator<Object_G> GetEnumerator()
        {
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
    /// <item>SW_PlcBlocks_Access_v5 => SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Parameter", IsNullable = false)]
    public class Parameter_T_v5 : Parameter_T_v4, IEnumerable<Object_G>
    {
        [XmlElement("BooleanAttribute", typeof(Common.BooleanAttribute_T_v2))]
        [XmlElement("Access", typeof(Access_T_v5))]
        [XmlElement("Blank", typeof(Common.Blank_T))]
        [XmlElement("Comment", typeof(Common.Comment_T_v2))]
        [XmlElement("LineComment", typeof(Common.LineComment_T_v3))]
        [XmlElement("NewLine", typeof(Common.NewLine_T))]
        [XmlElement("Token", typeof(Common.Token_T_v2))]
        protected internal new Object_G[] Items { get; set; }
        public new Object_G this[int key] { get => Items[key]; set => Items[key] = value; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(Informative):
                        Informative = reader.ReadContentAsBoolean();
                        break;
                    case nameof(Section):
                        Enum.TryParse<Common.SectionName_TE>(reader.ReadContentAsString(), out var section);
                        SectionSpecified = true;
                        break;
                    case nameof(Name):
                        Name = reader.ReadContentAsString();
                        break;
                    case nameof(Type):
                        Type = reader.ReadContentAsString();
                        break;
                    case nameof(TemplateReference):
                        TemplateReference = reader.ReadContentAsString();
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
                        case "IntegerAttribute":
                            IntegerAttribute = new Common.IntegerAttribute_T_v2();
                            IntegerAttribute.ReadXml(reader);
                            break;
                        case "StringAttribute":
                            StringAttribute = new Common.StringAttribute_T_v2();
                            StringAttribute.ReadXml(reader);
                            break;
                        case "BooleanAttribute":
                            var booleanAttribute = new Common.BooleanAttribute_T_v2();
                            booleanAttribute.ReadXml(reader);
                            items.Add(booleanAttribute);
                            break;
                        case "Access":
                            var access = new Access_T_v5();
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

        public new IEnumerator<Object_G> GetEnumerator()
        {
            foreach (var item in Items)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
