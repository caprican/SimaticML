using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.InterfaceSections
{
    public interface IMember : IEnumerable<Object_G>
    {
        string Name { get; set; }
        string Datatype { get; set; }
        string Version { get; set; }
        Remanence_TE Remanence { get; set; }
        Accessibility_TE Accessibility { get; set; }
        bool Informative { get; set; }
        Common.AttributeBase[] Attributes {  get; set; }

        Common.IComment_T Comment {  get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_InterfaceSections_v2 => SW.Common</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Member", Namespace = "http://www.siemens.com/automation/Openness/SW/Interface/v2", IsNullable = false)]
    [DebuggerDisplay("{Name}")]
    public class Member_T : Object_G, IMember
    {
        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
        public string Datatype { get; set; }

        /// <summary>
        /// The version of the library type to use. Previous to this, the version was written inside the Datatype attribute itself, like "dtl:v1.0".
        /// Now, this is written in two separate attributes, to mitigate problems with weird names ("dtl:v1.0" could be a UDT name!)
        /// </summary>
        [XmlAttribute]
        public string Version { get; set; }

        [XmlAttribute]
        [DefaultValue(Remanence_TE.NonRetain)]
        public Remanence_TE Remanence { get; set; } = Remanence_TE.NonRetain;

        [XmlAttribute]
        [DefaultValue(Accessibility_TE.Public)]
        public Accessibility_TE Accessibility { get; set; } = Accessibility_TE.Public;

        [XmlAttribute]
        [DefaultValue(false)]
        public bool Informative { get; set; } = false;

        [XmlArray("AttributeList")]
        [XmlArrayItem("BooleanAttribute", typeof(Common.BooleanAttribute_T), IsNullable = false)]
        [XmlArrayItem("IntegerAttribute", typeof(Common.IntegerAttribute_T), IsNullable = false)]
        [XmlArrayItem("RealAttribute", typeof(Common.RealAttribute_T), IsNullable = false)]
        [XmlArrayItem("StringAttribute", typeof(Common.StringAttribute_T), IsNullable = false)]
        public Common.AttributeBase[] Attributes { get; set; }

        public Common.IComment_T Comment { get; set; }

        [XmlElement("Member", typeof(Member_T))]
        [XmlElement("Sections", typeof(Sections_T))]
        [XmlElement("StartValue", typeof(StartValue_T))]
        [XmlElement("Subelement", typeof(Subelement_T))]
        protected internal Object_G[] Items { get; set; }
        public Object_G this[int key] { get => Items[key]; set => Items[key] = value; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(Name):
                        Name = reader.ReadContentAsString();
                        break;
                    case nameof(Datatype):
                        Datatype = reader.ReadContentAsString();
                        break;
                    case nameof(Version):
                        Version = reader.ReadContentAsString();
                        break;
                    case nameof(Informative):
                        Informative = reader.ReadContentAsBoolean();
                        break;
                    case nameof(Accessibility):
                        Enum.TryParse<Accessibility_TE>(reader.ReadContentAsString(), out var accessibility);
                        Accessibility = accessibility;
                        break;
                    case nameof(Remanence):
                        Enum.TryParse<Remanence_TE>(reader.ReadContentAsString(), out var remanence);
                        Remanence = remanence;
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
                        case "AttributeList":
                            var attributes = new Common.AttributList_T();
                            attributes.ReadXml(reader);
                            Attributes = attributes.Items;
                            break;

                        case nameof(Comment) :
                            var comment = new Common.Comment_T();
                            comment.ReadXml(reader);
                            Comment = comment;
                            break;

                        case "Member":
                            var member = new Member_T();
                            member.ReadXml(reader);
                            items.Add(member);
                            break;
                        case "Sections":
                            var section = new Sections_T();
                            section.ReadXml(reader);
                            items.Add(section);
                            break;
                        case "StartValue":
                            var startValue = new StartValue_T();
                            startValue.ReadXml(reader);
                            items.Add(startValue);
                            break;
                        case "Subelement":
                            var subelement = new Subelement_T();
                            subelement.ReadXml(reader);
                            items.Add(subelement);
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
    /// <item>SW_InterfaceSections_v3 => SW.Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Member", Namespace = "http://www.siemens.com/automation/Openness/SW/Interface/v3", IsNullable = false)]
    [DebuggerDisplay("{Name}")]
    public class Member_T_v3 : Member_T, IMember
    {
        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(Name):
                        Name = reader.ReadContentAsString();
                        break;
                    case nameof(Datatype):
                        Datatype = reader.ReadContentAsString();
                        break;
                    case nameof(Version):
                        Version = reader.ReadContentAsString();
                        break;
                    case nameof(Informative):
                        Informative = reader.ReadContentAsBoolean();
                        break;
                    case nameof(Accessibility):
                        Enum.TryParse<Accessibility_TE>(reader.ReadContentAsString(), out var accessibility);
                        Accessibility = accessibility;
                        break;
                    case nameof(Remanence):
                        Enum.TryParse<Remanence_TE>(reader.ReadContentAsString(), out var remanence);
                        Remanence = remanence;
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
                        case "AttributeList":
                            var attributes = new Common.AttributList_T_v2();
                            attributes.ReadXml(reader);
                            Attributes = attributes.Items;
                            break;

                        case nameof(Comment) :
                            var comment = new Common.Comment_T_v2();
                            comment.ReadXml(reader);
                            Comment = comment;
                            break;

                        case "Member":
                            var member = new Member_T_v3();
                            member.ReadXml(reader);
                            items.Add(member);
                            break;
                        case "Sections":
                            var section = new Sections_T_v3();
                            section.ReadXml(reader);
                            items.Add(section);
                            break;
                        case "StartValue":
                            var startValue = new StartValue_T();
                            startValue.ReadXml(reader);
                            items.Add(startValue);
                            break;
                        case "Subelement":
                            var subelement = new Subelement_T_v3();
                            subelement.ReadXml(reader);
                            items.Add(subelement);
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
    /// <item>SW_InterfaceSections_v4 => SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Member", Namespace = "http://www.siemens.com/automation/Openness/SW/Interface/v4", IsNullable = false)]
    [DebuggerDisplay("{Name}")]
    public class Member_T_v4 : Member_T_v3, IMember
    {
        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(Name):
                        Name = reader.ReadContentAsString();
                        break;
                    case nameof(Datatype):
                        Datatype = reader.ReadContentAsString();
                        break;
                    case nameof(Version):
                        Version = reader.ReadContentAsString();
                        break;
                    case nameof(Informative):
                        Informative = reader.ReadContentAsBoolean();
                        break;
                    case nameof(Accessibility):
                        Enum.TryParse<Accessibility_TE>(reader.ReadContentAsString(), out var accessibility);
                        Accessibility = accessibility;
                        break;
                    case nameof(Remanence):
                        Enum.TryParse<Remanence_TE>(reader.ReadContentAsString(), out var remanence);
                        Remanence = remanence;
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
                        case "AttributeList":
                            var attributes = new Common.AttributList_T_v2();
                            attributes.ReadXml(reader);
                            Attributes = attributes.Items;
                            break;

                        case nameof(Comment):
                            var comment = new Common.Comment_T_v2();
                            comment.ReadXml(reader);
                            Comment = comment;
                            break;

                        case "Member":
                            var member = new Member_T_v4();
                            member.ReadXml(reader);
                            items.Add(member);
                            break;
                        case "Sections":
                            var section = new Sections_T_v4();
                            section.ReadXml(reader);
                            items.Add(section);
                            break;
                        case "StartValue":
                            var startValue = new StartValue_T();
                            startValue.ReadXml(reader);
                            items.Add(startValue);
                            break;
                        case "Subelement":
                            var subelement = new Subelement_T_v3();
                            subelement.ReadXml(reader);
                            items.Add(subelement);
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
    /// <item>SW_InterfaceSections_v5 => SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Member", Namespace = "http://www.siemens.com/automation/Openness/SW/Interface/v5", IsNullable = false)]
    [DebuggerDisplay("{Name}")]
    public class Member_T_v5 : Member_T_v4, IMember
    {
        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(Name):
                        Name = reader.ReadContentAsString();
                        break;
                    case nameof(Datatype):
                        Datatype = reader.ReadContentAsString();
                        break;
                    case nameof(Version):
                        Version = reader.ReadContentAsString();
                        break;
                    case nameof(Informative):
                        Informative = reader.ReadContentAsBoolean();
                        break;
                    case nameof(Accessibility):
                        Enum.TryParse<Accessibility_TE>(reader.ReadContentAsString(), out var accessibility);
                        Accessibility = accessibility;
                        break;
                    case nameof(Remanence):
                        Enum.TryParse<Remanence_TE>(reader.ReadContentAsString(), out var remanence);
                        Remanence = remanence;
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
                        case "AttributeList":
                            var attributes = new Common.AttributList_T_v2();
                            attributes.ReadXml(reader);
                            Attributes = attributes.Items;
                            break;

                        case nameof(Comment):
                            var comment = new Common.Comment_T_v2();
                            comment.ReadXml(reader);
                            Comment = comment;
                            break;

                        case "AssignedProDiagFB":
                            var assignedProDiag = new AssignedProDiagFB_T();
                            assignedProDiag.ReadXml(reader);
                            items.Add(assignedProDiag);
                        break;
                        case "Member":
                            var member = new Member_T_v5();
                            member.ReadXml(reader);
                            items.Add(member);
                            break;
                        case "Sections":
                            var section = new Sections_T_v5();
                            section.ReadXml(reader);
                            items.Add(section);
                            break;
                        case "StartValue":
                            var startValue = new StartValue_T();
                            startValue.ReadXml(reader);
                            items.Add(startValue);
                            break;
                        case "Subelement":
                            var subelement = new Subelement_T_v5();
                            subelement.ReadXml(reader);
                            items.Add(subelement);
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
