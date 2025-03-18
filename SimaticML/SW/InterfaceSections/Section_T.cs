using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.InterfaceSections
{
    public interface ISection
    {
        Common.SectionName_TE Name { get; set; }

        ISections Sections { get; set; }
        IMember[] Members { get; set; }
    }

    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_InterfaceSections_v2 => SW.Common</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [DebuggerDisplay("{Name}")]
    [XmlRoot("Section", Namespace = "http://www.siemens.com/automation/Openness/SW/Interface/v2", IsNullable = false)]
    public class Section_T : Object_G, ISection
    {
        [XmlAttribute]
        public Common.SectionName_TE Name { get; set; }

        /// <summary>
        /// Base Class
        /// </summary>
        public ISections Sections { get; set; }

        [XmlElement("Member")]
        public IMember[] Members { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(Name):
                        Enum.TryParse<Common.SectionName_TE>(reader.ReadContentAsString(), out var name);
                        Name = name;
                        break;

                    default:
                        break;
                }
            }

            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var members = new List<Member_T>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Member":
                            var member = new Member_T();
                            member.ReadXml(reader);
                            members.Add(member);
                            break;
                        case nameof(Sections) :
                            var sections = new Sections_T();
                            sections.ReadXml(reader);
                            Sections = sections;
                            break;

                        default:
                            reader.Skip();
                            break;
                    }
                }
                if (members.Count > 0) Members = members.ToArray();
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
    /// <item>SW_InterfaceSections_v3 => SW.Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [DebuggerDisplay("{Name}")]
    [XmlRoot("Section", Namespace = "http://www.siemens.com/automation/Openness/SW/Interface/v3", IsNullable = false)]
    public class Section_T_v3 : Section_T, ISection
    {
        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(Name):
                        Enum.TryParse<Common.SectionName_TE>(reader.ReadContentAsString(), out var name);
                        Name = name;
                        break;

                    default:
                        break;
                }
            }

            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var members = new List<Member_T_v3>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Member":
                            var member = new Member_T_v3();
                            member.ReadXml(reader);
                            members.Add(member);
                            break;
                        case nameof(Sections) :
                            var sections = new Sections_T_v3();
                            sections.ReadXml(reader);
                            Sections = sections;
                            break;
                        
                        default:
                            reader.Skip();
                            break;
                    }
                }
                if (members.Count > 0) Members = members.ToArray();
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
    /// <item>SW_InterfaceSections_v4 => SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [DebuggerDisplay("{Name}")]
    [XmlRoot("Section", Namespace = "http://www.siemens.com/automation/Openness/SW/Interface/v4", IsNullable = false)]
    public class Section_T_v4 : Section_T_v3, ISection
    {
        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(Name):
                        Enum.TryParse<Common.SectionName_TE>(reader.ReadContentAsString(), out var name);
                        Name = name;
                        break;
                    
                    default:
                        break;
                }
            }

            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var members = new List<Member_T_v4>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Member":
                            var member = new Member_T_v4();
                            member.ReadXml(reader);
                            members.Add(member);
                            break;
                        case nameof(Sections) :
                            var sections = new Sections_T_v4();
                            sections.ReadXml(reader);
                            Sections = sections;
                            break;
                        
                        default:
                            reader.Skip();
                            break;
                    }
                }
                if (members.Count > 0) Members = members.ToArray();
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
    /// <item>SW_InterfaceSections_v5 => SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [DebuggerDisplay("{Name}")]
    [XmlRoot("Section", Namespace = "http://www.siemens.com/automation/Openness/SW/Interface/v5", IsNullable = false)]
    public class Section_T_v5 : Section_T_v4, ISection
    {
        public override void ReadXml(XmlReader reader)
        {
            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case nameof(Name):
                        Enum.TryParse<Common.SectionName_TE>(reader.ReadContentAsString(), out var name);
                        Name = name;
                        break;
                    
                    default:
                        break;
                }
            }

            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var members = new List<Member_T_v5>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Member":
                            var member = new Member_T_v5();
                            member.ReadXml(reader);
                            members.Add(member);
                            break;
                        case nameof(Sections) :
                            var sections = new Sections_T_v5();
                            sections.ReadXml(reader);
                            Sections = sections;
                            break;

                        default:
                            reader.Skip();
                            break;
                    }
                }
                if (members.Count > 0) Members = members.ToArray();
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
