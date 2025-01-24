using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography;
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
        [XmlElement("IntegerAttribute" , typeof(Common.IntegerAttribute_T), Order = 0)]                // for NumBLs. NumBLs is informative
        [XmlElement("StringAttribute", typeof(Common.StringAttribute_T), Order = 1)]                   // for InterfaceFlags. InterfaceFlags is informative. The type of the value should be InterfaceFlags_TP. The default value is "S7_Visible"
        [XmlElement("Comment", typeof(Common.Comment_T), Order = 2 | 4)]
        [XmlElement("LineComment", typeof(Common.LineComment_T), Order = 2 | 4)]
        [XmlElement("Access", typeof(Access_T), Order = 3)]
        public Object_G[] Items { get; set; }

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

        public override void ReadXml(XmlReader reader)
        {
            SectionSpecified = Enum.TryParse<Common.SectionName_TE>(reader.GetAttribute("Section"), out var section);
            if(SectionSpecified) Section = section;

            Name = reader.GetAttribute("Name");
            Type = reader.GetAttribute("Type");
            TemplateReference = reader.GetAttribute("TemplateReference");

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

                reader.ReadEndElement();
            }
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
    public class Parameter_T_v2 : Parameter_T
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
        public new Object_G[] Items { get; set; }

        [XmlAttribute]
        [DefaultValue(false)]
        public bool Informative { get; set; } = false;

        [XmlAttribute]
        public int? UId { get; set; } = null;
        [XmlIgnore]
        public bool UIdSpecified { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            _ = bool.TryParse(reader.GetAttribute("Informative"), out var informative);
            Informative = informative;

            SectionSpecified = Enum.TryParse<Common.SectionName_TE>(reader.GetAttribute("Section"), out var section);
            if (SectionSpecified) Section = section;

            Name = reader.GetAttribute("Name");
            Type = reader.GetAttribute("Type");
            TemplateReference = reader.GetAttribute("TemplateReference");

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

                reader.ReadEndElement();
            }
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
    [XmlRoot("Parameter", IsNullable = false)]
    public class Parameter_T_v3 : Parameter_T_v2
    {
        [XmlElement("BooleanAttribute", typeof(Common.BooleanAttribute_T_v2))]
        [XmlElement("Access", typeof(Access_T_v3))]
        [XmlElement("Blank", typeof(Common.Blank_T))]
        [XmlElement("Comment", typeof(Common.Comment_T_v2))]
        [XmlElement("LineComment", typeof(Common.LineComment_T_v2))]
        [XmlElement("NewLine", typeof(Common.NewLine_T))]
        [XmlElement("Token", typeof(Common.Token_T_v2))]
        public new Object_G[] Items { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            _ = bool.TryParse(reader.GetAttribute("Informative"), out var informative);
            Informative = informative;

            SectionSpecified = Enum.TryParse<Common.SectionName_TE>(reader.GetAttribute("Section"), out var section);
            if (SectionSpecified) Section = section;

            Name = reader.GetAttribute("Name");
            Type = reader.GetAttribute("Type");
            TemplateReference = reader.GetAttribute("TemplateReference");

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

                reader.ReadEndElement();
            }
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
    [XmlRoot("Parameter", IsNullable = false)]
    public class Parameter_T_v4 : Parameter_T_v3
    {
        [XmlElement("BooleanAttribute", typeof(Common.BooleanAttribute_T_v2))]
        [XmlElement("Access", typeof(Access_T_v4))]
        [XmlElement("Blank", typeof(Common.Blank_T))]
        [XmlElement("Comment", typeof(Common.Comment_T_v2))]
        [XmlElement("LineComment", typeof(Common.LineComment_T_v3))]
        [XmlElement("NewLine", typeof(Common.NewLine_T))]
        [XmlElement("Token", typeof(Common.Token_T_v2))]
        public new Object_G[] Items { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            _ = bool.TryParse(reader.GetAttribute("Informative"), out var informative);
            Informative = informative;

            SectionSpecified = Enum.TryParse<Common.SectionName_TE>(reader.GetAttribute("Section"), out var section);
            if (SectionSpecified) Section = section;

            Name = reader.GetAttribute("Name");
            Type = reader.GetAttribute("Type");
            TemplateReference = reader.GetAttribute("TemplateReference");

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

                reader.ReadEndElement();
            }
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
    [XmlRoot("Parameter", IsNullable = false)]
    public class Parameter_T_v5 : Parameter_T_v4
    {
        [XmlElement("BooleanAttribute", typeof(Common.BooleanAttribute_T_v2))]
        [XmlElement("Access", typeof(Access_T_v5))]
        [XmlElement("Blank", typeof(Common.Blank_T))]
        [XmlElement("Comment", typeof(Common.Comment_T_v2))]
        [XmlElement("LineComment", typeof(Common.LineComment_T_v3))]
        [XmlElement("NewLine", typeof(Common.NewLine_T))]
        [XmlElement("Token", typeof(Common.Token_T_v2))]
        public new Object_G[] Items { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            _ = bool.TryParse(reader.GetAttribute("Informative"), out var informative);
            Informative = informative;

            SectionSpecified = Enum.TryParse<Common.SectionName_TE>(reader.GetAttribute("Section"), out var section);
            if (SectionSpecified) Section = section;

            Name = reader.GetAttribute("Name");
            Type = reader.GetAttribute("Type");
            TemplateReference = reader.GetAttribute("TemplateReference");

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

                reader.ReadEndElement();
            }
        }

        public override void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }
}
