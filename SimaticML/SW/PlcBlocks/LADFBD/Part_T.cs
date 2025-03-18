using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.PlcBlocks.LADFBD
{
    public interface IPart : IEnumerable<Object_G>
    {
        int UId { get; set; }
        string Name { get; }
        string Version { get; set; }
        bool DisabledENO { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW.PlcBlocks.LADFBD => SW.PlcBlocks.CompileUnitCommon + SW.PlcBlocks.Access + </item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Part", IsNullable = false)]
    public class Part_T : Object_G, IPart
    {
        //[XmlElement("Equation", typeof(Equation_T))]                    // The equation of this part. This is only used for the Calculate box.
        //[XmlElement("Instance", typeof(Access.Instance_T))]
        //[XmlElement("TemplateValue", typeof(Access.TemplateValue_T))]
        //[XmlElement("AutomaticTyped", typeof(AutomaticTyped_T))]
        //[XmlElement("Invisible", typeof(Invisible_T))]
        //[XmlElement("Negated", typeof(Neg_T))]
        protected internal Object_G[] Items { get; set; }
        public Object_G this[int key] { get => Items[key]; set => Items[key] = value; }

        public Common.IComment_T Comment { get; set; }

        [XmlAttribute]
        public int UId { get; set; }

        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
        public string Version { get; set; }

        [XmlAttribute]
        [DefaultValue(false)]
        public bool DisabledENO { get; set; } = false;

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(DisabledENO):
                        DisabledENO = reader.ReadContentAsBoolean();
                        break;
                    case nameof(UId):
                        UId = reader.ReadContentAsInt();
                        break;
                    case nameof(Name):
                        Name = reader.ReadContentAsString();
                        break;
                    case nameof (Version):
                        Version = reader.ReadContentAsString();
                        break;

                    default:
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
                        case "Equation":
                            var equation = new Equation_T();
                            equation.ReadXml(reader);
                            items.Add(equation);
                            break;
                        case "Instance":
                            var instance = new Access.Instance_T();
                            instance.ReadXml(reader);
                            items.Add(instance);
                            break;
                        case nameof(Comment) :
                            var comment = new Common.Comment_T();
                            comment.ReadXml(reader);
                            Comment = comment;
                            break;
                        case "TemplateValue":
                            var template = new Access.TemplateValue_T();
                            template.ReadXml(reader);
                            items.Add(template);
                            break;
                        case "AutomaticTyped":
                            var type = new AutomaticTyped_T();
                            type.ReadXml(reader);
                            items.Add(type);
                            break;
                        case "Invisible":
                            var invisible = new Invisible_T();
                            invisible.ReadXml(reader);
                            items.Add(invisible);
                            break;
                        case "Negated":
                            var neg = new Neg_T();
                            neg.ReadXml(reader);
                            items.Add(neg);
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
    /// <item>SW.PlcBlocks.LADFBD_v2 => SW.PlcBlocks.CompileUnitCommon_v2 + SW.PlcBlocks.Access_v2 + SW.Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Part", IsNullable = false)]
    public class Part_T_v2 : Part_T, IPart
    {
        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(DisabledENO):
                        DisabledENO = reader.ReadContentAsBoolean();
                        break;
                    case nameof(UId):
                        UId = reader.ReadContentAsInt();
                        break;
                    case nameof(Name):
                        Name = reader.ReadContentAsString();
                        break;
                    case nameof(Version):
                        Version = reader.ReadContentAsString();
                        break;

                    default:
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
                        case "Equation":
                            var equation = new Equation_T();
                            equation.ReadXml(reader);
                            items.Add(equation);
                            break;
                        case "Instance":
                            var instance = new Access.Instance_T_v2();
                            instance.ReadXml(reader);
                            items.Add(instance);
                            break;
                        case nameof(Comment) :
                            var comment = new Common.Comment_T_v2();
                            comment.ReadXml(reader);
                            Comment = comment;
                            break;
                        case "TemplateValue":
                            var template = new Access.TemplateValue_T_v2();
                            template.ReadXml(reader);
                            items.Add(template);
                            break;
                        case "AutomaticTyped":
                            var type = new AutomaticTyped_T();
                            type.ReadXml(reader);
                            items.Add(type);
                            break;
                        case "Invisible":
                            var invisible = new Invisible_T();
                            invisible.ReadXml(reader);
                            items.Add(invisible);
                            break;
                        case "Negated":
                            var neg = new Neg_T();
                            neg.ReadXml(reader);
                            items.Add(neg);
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
    /// <item>SW.PlcBlocks.LADFBD_v3 => SW.PlcBlocks.CompileUnitCommon_v3 + SW.PlcBlocks.Access_v3 + SW.Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Part", IsNullable = false)]
    public class Part_T_v3 : Part_T_v2, IPart
    {
        //[XmlElement("Instance", typeof(Access.Instance_T_v3))]

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(DisabledENO):
                        DisabledENO = reader.ReadContentAsBoolean();
                        break;
                    case nameof(UId):
                        UId = reader.ReadContentAsInt();
                        break;
                    case nameof(Name):
                        Name = reader.ReadContentAsString();
                        break;
                    case nameof(Version):
                        Version = reader.ReadContentAsString();
                        break;

                    default:
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
                        case "Equation":
                            var equation = new Equation_T();
                            equation.ReadXml(reader);
                            items.Add(equation);
                            break;
                        case "Instance":
                            var instance = new Access.Instance_T_v3();
                            instance.ReadXml(reader);
                            items.Add(instance);
                            break;
                        case nameof(Comment) :
                            var comment = new Common.Comment_T_v2();
                            comment.ReadXml(reader);
                            Comment = comment;
                            break;
                        case "TemplateValue":
                            var template = new Access.TemplateValue_T_v2();
                            template.ReadXml(reader);
                            items.Add(template);
                            break;
                        case "AutomaticTyped":
                            var type = new AutomaticTyped_T();
                            type.ReadXml(reader);
                            items.Add(type);
                            break;
                        case "Invisible":
                            var invisible = new Invisible_T();
                            invisible.ReadXml(reader);
                            items.Add(invisible);
                            break;
                        case "Negated":
                            var neg = new Neg_T();
                            neg.ReadXml(reader);
                            items.Add(neg);
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
    /// <item>SW.PlcBlocks.LADFBD_v4 => SW.PlcBlocks.CompileUnitCommon_v4 + SW.PlcBlocks.Access_v4 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Part", IsNullable = false)]
    public class Part_T_v4 : Part_T_v3, IPart
    {
        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(DisabledENO):
                        DisabledENO = reader.ReadContentAsBoolean();
                        break;
                    case nameof(UId):
                        UId = reader.ReadContentAsInt();
                        break;
                    case nameof(Name):
                        Name = reader.ReadContentAsString();
                        break;
                    case nameof(Version):
                        Version = reader.ReadContentAsString();
                        break;

                    default:
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
                        case "Equation":
                            var equation = new Equation_T();
                            equation.ReadXml(reader);
                            items.Add(equation);
                            break;
                        case "Instance":
                            var instance = new Access.Instance_T_v4();
                            instance.ReadXml(reader);
                            items.Add(instance);
                            break;
                        case nameof(Comment):
                            var comment = new Common.Comment_T_v2();
                            comment.ReadXml(reader);
                            Comment = comment;
                            break;
                        case "TemplateValue":
                            var template = new Access.TemplateValue_T_v2();
                            template.ReadXml(reader);
                            items.Add(template);
                            break;
                        case "AutomaticTyped":
                            var type = new AutomaticTyped_T();
                            type.ReadXml(reader);
                            items.Add(type);
                            break;
                        case "Invisible":
                            var invisible = new Invisible_T();
                            invisible.ReadXml(reader);
                            items.Add(invisible);
                            break;
                        case "Negated":
                            var neg = new Neg_T();
                            neg.ReadXml(reader);
                            items.Add(neg);
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
    /// <item>SW.PlcBlocks.LADFBD_v5 => SW.PlcBlocks.CompileUnitCommon_v5 + SW.PlcBlocks.Access_v5 + SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Part", IsNullable = false)]
    public class Part_T_v5 : Part_T_v4, IPart
    {
        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(DisabledENO):
                        DisabledENO = reader.ReadContentAsBoolean();
                        break;
                    case nameof(UId):
                        UId = reader.ReadContentAsInt();
                        break;
                    case nameof(Name):
                        Name = reader.ReadContentAsString();
                        break;
                    case nameof(Version):
                        Version = reader.ReadContentAsString();
                        break;

                    default:
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
                        case "Equation":
                            var equation = new Equation_T();
                            equation.ReadXml(reader);
                            items.Add(equation);
                            break;
                        case "Instance":
                            var instance = new Access.Instance_T_v5();
                            instance.ReadXml(reader);
                            items.Add(instance);
                            break;
                        case nameof(Comment):
                            var comment = new Common.Comment_T_v2();
                            comment.ReadXml(reader);
                            Comment = comment;
                            break;
                        case "TemplateValue":
                            var template = new Access.TemplateValue_T_v2();
                            template.ReadXml(reader);
                            items.Add(template);
                            break;
                        case "AutomaticTyped":
                            var type = new AutomaticTyped_T();
                            type.ReadXml(reader);
                            items.Add(type);
                            break;
                        case "Invisible":
                            var invisible = new Invisible_T();
                            invisible.ReadXml(reader);
                            items.Add(invisible);
                            break;
                        case "Negated":
                            var neg = new Neg_T();
                            neg.ReadXml(reader);
                            items.Add(neg);
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
