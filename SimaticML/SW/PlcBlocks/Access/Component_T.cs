using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Access
{
    public interface IComponent : IEnumerable<Object_G>
    {
        string Name { get; set; }
        string SliceAccessModifier { get; set; }
        string SimpleAccessModifier { get; set; }
    }

    public interface IComponent_v2 : IComponent
    {
        AccessModifier_TE AccessModifier { get; set; }
        int UId { get; set; }
    }

    /// <summary>
    /// For the indices of an array
    /// </summary>

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_PlcBlocks_Access => SW.Common</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Component", IsNullable = false)]
    public class Component_T : Object_G, IComponent
    {
        //[XmlElement("Access", typeof(Access_T))]                                 // For the indices of an array
        protected internal Object_G[] Items { get; set; }
        public Object_G this[int key] { get => Items[key]; set => Items[key] = value; }

        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
        [DefaultValue("undef")]
        public string SliceAccessModifier { get; set; } = "undef";

        [XmlAttribute]
        [DefaultValue("None")]
        public string SimpleAccessModifier { get; set; } = "None";

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(Name):
                        Name = reader.ReadContentAsString();
                        break;
                    case nameof(SliceAccessModifier):
                        SliceAccessModifier = reader.ReadContentAsString();
                        break;
                    case nameof(SimpleAccessModifier):
                        SimpleAccessModifier = reader.ReadContentAsString();
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
    /// For the indices of an array
    /// </summary>
    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_PlcBlocks_Access_v2 => SW.Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Component", IsNullable = false)]
    public class Component_T_v2 : Component_T, IComponent_v2
    {
        //[XmlElement("Access", typeof(Access_T_v2))]                                 // For the indices of an array
        //[XmlElement("Blank", typeof(Common.Blank_T))]                               // SCL
        //[XmlElement("BooleanAttribute", typeof(Common.BooleanAttribute_T_v2))]
        //[XmlElement("Comment", typeof(Common.Comment_T_v2))]                        // SCL
        //[XmlElement("LineComment", typeof(Common.LineComment_T_v2))]                // SCL
        //[XmlElement("NewLine", typeof(Common.NewLine_T))]                           // SCL
        //[XmlElement("Token", typeof(Common.Token_T_v2))]                            // SCL

        /// <summary>
        /// If component has child AccessModifier is Array else AccessModifier is None
        /// </summary>
        [XmlAttribute]
        [DefaultValue(AccessModifier_TE.None)]
        public AccessModifier_TE AccessModifier { get; set; } = AccessModifier_TE.None;

        [XmlAttribute]
        public int UId { get; set; }
        [XmlIgnore]
        public bool UIdSpecified { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(Name):
                        Name = reader.ReadContentAsString();
                        break;
                    case nameof(SliceAccessModifier):
                        SliceAccessModifier = reader.ReadContentAsString();
                        break;
                    case nameof(SimpleAccessModifier):
                        SimpleAccessModifier = reader.ReadContentAsString();
                        break;
                    case nameof(AccessModifier):
                        Enum.TryParse<AccessModifier_TE>(reader.ReadContentAsString(), out var accessModifier);
                        AccessModifier = accessModifier;
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
                        case "BooleanAttribute":
                            var booleanAttribute = new Common.BooleanAttribute_T_v2();
                            booleanAttribute.ReadXml(reader);
                            items.Add(booleanAttribute);
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

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }

    /// <summary>
    /// For the indices of an array
    /// </summary>
    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_PlcBlocks_Access_v3 => SW.Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Component", IsNullable = false)]
    public class Component_T_v3 : Component_T_v2, IComponent_v2
    {
        //[XmlElement("Access", typeof(Access_T_v3))]                                 // For the indices of an array
        //[XmlElement("Blank", typeof(Common.Blank_T))]                               // SCL
        //[XmlElement("BooleanAttribute", typeof(Common.BooleanAttribute_T_v2))]
        //[XmlElement("Comment", typeof(Common.Comment_T_v2))]                        // SCL
        //[XmlElement("LineComment", typeof(Common.LineComment_T_v2))]                // SCL
        //[XmlElement("NewLine", typeof(Common.NewLine_T))]                           // SCL
        //[XmlElement("Token", typeof(Common.Token_T_v2))]                            // SCL

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(Name):
                        Name = reader.ReadContentAsString();
                        break;
                    case nameof(SliceAccessModifier):
                        SliceAccessModifier = reader.ReadContentAsString();
                        break;
                    case nameof(SimpleAccessModifier):
                        SimpleAccessModifier = reader.ReadContentAsString();
                        break;
                    case nameof(AccessModifier):
                        Enum.TryParse<AccessModifier_TE>(reader.ReadContentAsString(), out var accessModifier);
                        AccessModifier = accessModifier;
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
                        case "BooleanAttribute":
                            var booleanAttribute = new Common.BooleanAttribute_T_v2();
                            booleanAttribute.ReadXml(reader);
                            items.Add(booleanAttribute);
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

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }

    /// <summary>
    /// For the indices of an array
    /// </summary>
    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_PlcBlocks_Access_v4 => SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Component", IsNullable = false)]
    public class Component_T_v4 : Component_T_v3, IComponent_v2
    {
        //[XmlElement("Access", typeof(Access_T_v4))]                                 // For the indices of an array
        //[XmlElement("Blank", typeof(Common.Blank_T))]                               // SCL
        //[XmlElement("BooleanAttribute", typeof(Common.BooleanAttribute_T_v2))]
        //[XmlElement("Comment", typeof(Common.Comment_T_v2))]                        // SCL
        //[XmlElement("LineComment", typeof(Common.LineComment_T_v3))]                // SCL
        //[XmlElement("NewLine", typeof(Common.NewLine_T))]                           // SCL
        //[XmlElement("Token", typeof(Common.Token_T_v2))]                            // SCL

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(Name):
                        Name = reader.ReadContentAsString();
                        break;
                    case nameof(SliceAccessModifier):
                        SliceAccessModifier = reader.ReadContentAsString();
                        break;
                    case nameof(SimpleAccessModifier):
                        SimpleAccessModifier = reader.ReadContentAsString();
                        break;
                    case nameof(AccessModifier):
                        Enum.TryParse<AccessModifier_TE>(reader.ReadContentAsString(), out var accessModifier);
                        AccessModifier = accessModifier;
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
                        case "BooleanAttribute":
                            var booleanAttribute = new Common.BooleanAttribute_T_v2();
                            booleanAttribute.ReadXml(reader);
                            items.Add(booleanAttribute);
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

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }

    /// <summary>
    /// For the indices of an array
    /// </summary>
    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_PlcBlocks_Access_v5 => SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Component", IsNullable = false)]
    public class Component_T_v5 : Component_T_v4, IComponent_v2
    {
        //[XmlElement("Access", typeof(Access_T_v5))]                                 // For the indices of an array
        //[XmlElement("Blank", typeof(Common.Blank_T))]                               // SCL
        //[XmlElement("BooleanAttribute", typeof(Common.BooleanAttribute_T_v2))]
        //[XmlElement("Comment", typeof(Common.Comment_T_v2))]                        // SCL
        //[XmlElement("LineComment", typeof(Common.LineComment_T_v3))]                // SCL
        //[XmlElement("NewLine", typeof(Common.NewLine_T))]                           // SCL
        //[XmlElement("Token", typeof(Common.Token_T_v2))]                            // SCL

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(Name):
                        Name = reader.ReadContentAsString();
                        break;
                    case nameof(SliceAccessModifier):
                        SliceAccessModifier = reader.ReadContentAsString();
                        break;
                    case nameof(SimpleAccessModifier):
                        SimpleAccessModifier = reader.ReadContentAsString();
                        break;
                    case nameof(AccessModifier):
                        Enum.TryParse<AccessModifier_TE>(reader.ReadContentAsString(), out var accessModifier);
                        AccessModifier = accessModifier;
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
                        case "BooleanAttribute":
                            var booleanAttribute = new Common.BooleanAttribute_T_v2();
                            booleanAttribute.ReadXml(reader);
                            items.Add(booleanAttribute);
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

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
