using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.Access
{
    public interface IInstance : IEnumerable<Object_G>
    {
        Scope_TE Scope { get; set; }
        int? UId { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_PlcBlocks_Access => SW.Common</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Instance", IsNullable=false)]
    public class Instance_T : Object_G, IInstance
    {
        [XmlAttribute]
        public Scope_TE Scope { get; set; }

        /// <summary>
        /// Not allowed in STL
        /// </summary>
        [XmlAttribute]
        public int? UId { get; set; } = null;
        [XmlIgnore]
        public bool UIdSpecified { get; set; }

        //[XmlElement("AbsoluteOffset", typeof(AbsoluteOffset_T))]
        //[XmlElement("Component", typeof(Component_T))]
        //[XmlElement("Token", typeof(Common.Token_T))]                           // the DOT; only if separated. Not in Graph ActionList, not in LAD/FBD.
        //[XmlElement("Comment", typeof(Common.Comment_T))]
        //[XmlElement("LineComment", typeof(Common.LineComment_T))]
        //[XmlElement("Address", typeof(Address_T))]                              // additional address for a symbol. it is informative
        protected internal Object_G[] Items { get; set; }
        public Object_G this[int key] { get => Items[key]; set => Items[key] = value; }

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

                var items = new List<Object_G>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "AbsoluteOffset":
                            var absoluteOffset = new AbsoluteOffset_T();
                            absoluteOffset.ReadXml(reader);
                            items.Add(absoluteOffset);
                            break;
                        case "Component":
                            var component = new Component_T();
                            component.ReadXml(reader);
                            items.Add(component);
                            break;
                        case "Token":
                            var token = new Common.Token_T();
                            token.ReadXml(reader);
                            items.Add(token);
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
                            items.Add(address);
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
    [XmlRoot("Instance", IsNullable = false)]
    public class Instance_T_v2 : Instance_T, IInstance
    {
        //[XmlElement("AbsoluteOffset", typeof(AbsoluteOffset_T))]
        //[XmlElement("Address", typeof(Address_T_v2))]                           // additional address for a symbol. it is informative
        //[XmlElement("Component", typeof(Component_T_v2))]
        //[XmlElement("Token", typeof(Common.Token_T_v2))]                        // the DOT; only if separated. Not in Graph ActionList, not in LAD/FBD.
        //[XmlElement("Blank", typeof(Common.Blank_T))]
        //[XmlElement("Comment", typeof(Common.Comment_T_v2))]
        //[XmlElement("LineComment", typeof(Common.LineComment_T_v2))]
        //[XmlElement("NewLine", typeof(Common.NewLine_T))]

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

                var items = new List<Object_G>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "AbsoluteOffset":
                            var absoluteOffset = new AbsoluteOffset_T();
                            absoluteOffset.ReadXml(reader);
                            items.Add(absoluteOffset);
                            break;
                        case "Address":
                            var address = new Address_T_v2();
                            address.ReadXml(reader);
                            items.Add(address);
                            break;
                        case "Component":
                            var component = new Component_T_v2();
                            component.ReadXml(reader);
                            items.Add(component);
                            break;
                        case "Token":
                            var token = new Common.Token_T_v2();
                            token.ReadXml(reader);
                            items.Add(token);
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
    [XmlRoot("Instance", IsNullable = false)]
    public class Instance_T_v3 : Instance_T_v2, IInstance
    {
        //[XmlElement("AbsoluteOffset", typeof(AbsoluteOffset_T))]
        //[XmlElement("Address", typeof(Address_T_v2))]                           // additional address for a symbol. it is informative
        //[XmlElement("Component", typeof(Component_T_v3))]
        //[XmlElement("Token", typeof(Common.Token_T_v2))]                        // the DOT; only if separated. Not in Graph ActionList, not in LAD/FBD.
        //[XmlElement("Blank", typeof(Common.Blank_T))]
        //[XmlElement("Comment", typeof(Common.Comment_T_v2))]
        //[XmlElement("LineComment", typeof(Common.LineComment_T_v2))]
        //[XmlElement("NewLine", typeof(Common.NewLine_T))]

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

                var items = new List<Object_G>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "AbsoluteOffset":
                            var absoluteOffset = new AbsoluteOffset_T();
                            absoluteOffset.ReadXml(reader);
                            items.Add(absoluteOffset);
                            break;
                        case "Address":
                            var address = new Address_T_v2();
                            address.ReadXml(reader);
                            items.Add(address);
                            break;
                        case "Component":
                            var component = new Component_T_v3();
                            component.ReadXml(reader);
                            items.Add(component);
                            break;
                        case "Token":
                            var token = new Common.Token_T_v2();
                            token.ReadXml(reader);
                            items.Add(token);
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
    [XmlRoot("Instance", IsNullable = false)]
    public class Instance_T_v4 : Instance_T_v3, IInstance
    {
        //[XmlElement("AbsoluteOffset", typeof(AbsoluteOffset_T))]
        //[XmlElement("Address", typeof(Address_T_v2))]                           // additional address for a symbol. it is informative
        //[XmlElement("Component", typeof(Component_T_v4))]
        //[XmlElement("Token", typeof(Common.Token_T_v2))]                        // the DOT; only if separated. Not in Graph ActionList, not in LAD/FBD.
        //[XmlElement("Blank", typeof(Common.Blank_T))]
        //[XmlElement("Comment", typeof(Common.Comment_T_v2))]
        //[XmlElement("LineComment", typeof(Common.LineComment_T_v3))]
        //[XmlElement("NewLine", typeof(Common.NewLine_T))]

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

                var items = new List<Object_G>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "AbsoluteOffset":
                            var absoluteOffset = new AbsoluteOffset_T();
                            absoluteOffset.ReadXml(reader);
                            items.Add(absoluteOffset);
                            break;
                        case "Address":
                            var address = new Address_T_v2();
                            address.ReadXml(reader);
                            items.Add(address);
                            break;
                        case "Component":
                            var component = new Component_T_v4();
                            component.ReadXml(reader);
                            items.Add(component);
                            break;
                        case "Token":
                            var token = new Common.Token_T_v2();
                            token.ReadXml(reader);
                            items.Add(token);
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
    [XmlRoot("Instance", IsNullable = false)]
    public class Instance_T_v5 : Instance_T_v4, IInstance
    {
        //[XmlElement("AbsoluteOffset", typeof(AbsoluteOffset_T))]
        //[XmlElement("Address", typeof(Address_T_v2))]                           // additional address for a symbol. it is informative
        //[XmlElement("Component", typeof(Component_T_v5))]
        //[XmlElement("Token", typeof(Common.Token_T_v2))]                        // the DOT; only if separated. Not in Graph ActionList, not in LAD/FBD.
        //[XmlElement("Blank", typeof(Common.Blank_T))]
        //[XmlElement("Comment", typeof(Common.Comment_T_v2))]
        //[XmlElement("LineComment", typeof(Common.LineComment_T_v3))]
        //[XmlElement("NewLine", typeof(Common.NewLine_T))]

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

                var items = new List<Object_G>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "AbsoluteOffset":
                            var absoluteOffset = new AbsoluteOffset_T();
                            absoluteOffset.ReadXml(reader);
                            items.Add(absoluteOffset);
                            break;
                        case "Address":
                            var address = new Address_T_v2();
                            address.ReadXml(reader);
                            items.Add(address);
                            break;
                        case "Component":
                            var component = new Component_T_v5();
                            component.ReadXml(reader);
                            items.Add(component);
                            break;
                        case "Token":
                            var token = new Common.Token_T_v2();
                            token.ReadXml(reader);
                            items.Add(token);
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
