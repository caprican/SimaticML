using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace SimaticML.SW.InterfaceSections
{
    /// <remarks>
    /// Schema : 
    /// <list type="bullet">
    /// <item>SW_InterfaceSections_v2 => SW.Common</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Member", Namespace = "http://www.siemens.com/automation/Openness/SW/Interface/v2", IsNullable = false)]
    [DebuggerDisplay("{Name}")]
    public class Member_T : Object_G
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

        public Common.Comment_T Comment { get; set; }

        [XmlElement("Member", typeof(Member_T))]
        [XmlElement("Sections", typeof(Sections_T))]
        [XmlElement("StartValue", typeof(StartValue_T))]
        [XmlElement("Subelement", typeof(Subelement_T))]
        public object[] Items { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            Name = reader.GetAttribute("Name");
            Datatype = reader.GetAttribute("Datatype");
            Version = reader.GetAttribute("Version");

            _ = Enum.TryParse<Remanence_TE>(reader.GetAttribute("Remanence"), out var remanence);
            Remanence = remanence;

            _ = Enum.TryParse<Accessibility_TE>(reader.GetAttribute("Accessibility"), out var accessibility);
            Accessibility = accessibility;

            _ = bool.TryParse(reader.GetAttribute("Informative"), out var informative);
            Informative = informative;

            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var items = new List<object>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "AttributeList":
                            var attributes = new Common.AttributList_T();
                            attributes.ReadXml(reader);
                            Attributes = attributes.Items;
                            break;

                        case "Comment":
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
                    }
                }
                if (items.Count > 0) Items = items.ToArray();

                reader.ReadEndElement();
            }
        }

        public override void WriteXml(XmlWriter writer)
        {
        }
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
    public class Member_T_v3 : Member_T
    {
        [XmlArray("AttributeList")]
        [XmlArrayItem("BooleanAttribute", typeof(Common.BooleanAttribute_T_v2), IsNullable = false)]
        [XmlArrayItem("DateAttribute", typeof(Common.DateAttribute_T_v2), IsNullable = false)]
        [XmlArrayItem("IntegerAttribute", typeof(Common.IntegerAttribute_T_v2), IsNullable = false)]
        [XmlArrayItem("RealAttribute", typeof(Common.RealAttribute_T_v2), IsNullable = false)]
        [XmlArrayItem("StringAttribute", typeof(Common.StringAttribute_T_v2), IsNullable = false)]
        public new Common.AttributeBase[] Attributes { get; set; }

        public new Common.Comment_T_v2 Comment { get; set; }

        [XmlElement("Member", typeof(Member_T_v3))]
        [XmlElement("Sections", typeof(Sections_T_v3))]
        [XmlElement("StartValue", typeof(StartValue_T))]
        [XmlElement("Subelement", typeof(Subelement_T_v3))]
        public new object[] Items { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            Name = reader.GetAttribute("Name");
            Datatype = reader.GetAttribute("Datatype");
            Version = reader.GetAttribute("Version");

            _ = Enum.TryParse<Remanence_TE>(reader.GetAttribute("Remanence"), out var remanence);
            Remanence = remanence;

            _ = Enum.TryParse<Accessibility_TE>(reader.GetAttribute("Accessibility"), out var accessibility);
            Accessibility = accessibility;

            _ = bool.TryParse(reader.GetAttribute("Informative"), out var informative);
            Informative = informative;

            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var items = new List<object>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "AttributeList":
                            var attributes = new Common.AttributList_T_v2();
                            attributes.ReadXml(reader);
                            Attributes = attributes.Items;
                            break;

                        case "Comment":
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
                    }
                }
                if (items.Count > 0) Items = items.ToArray();

                reader.ReadEndElement();
            }
        }

        public override void WriteXml(XmlWriter writer)
        {
        }
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
    public class Member_T_v4 : Member_T_v3
    {
        [XmlElement("Member", typeof(Member_T_v4))]
        [XmlElement("Sections", typeof(Sections_T_v4))]
        [XmlElement("StartValue", typeof(StartValue_T))]
        [XmlElement("Subelement", typeof(Subelement_T_v3))]
        public new object[] Items { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            Name = reader.GetAttribute("Name");
            Datatype = reader.GetAttribute("Datatype");
            Version = reader.GetAttribute("Version");

            _ = Enum.TryParse<Remanence_TE>(reader.GetAttribute("Remanence"), out var remanence);
            Remanence = remanence;

            _ = Enum.TryParse<Accessibility_TE>(reader.GetAttribute("Accessibility"), out var accessibility);
            Accessibility = accessibility;

            _ = bool.TryParse(reader.GetAttribute("Informative"), out var informative);
            Informative = informative;

            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var items = new List<object>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "AttributeList":
                            var attributes = new Common.AttributList_T_v2();
                            attributes.ReadXml(reader);
                            Attributes = attributes.Items;
                            break;

                        case "Comment":
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
                    }
                }
                if (items.Count > 0) Items = items.ToArray();

                reader.ReadEndElement();
            }
        }

        public override void WriteXml(XmlWriter writer)
        {
        }
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
    public class Member_T_v5 : Member_T_v4
    {
        [XmlElement("AssignedProDiagFB", typeof(string))]
        [XmlElement("Member", typeof(Member_T_v5))]
        [XmlElement("Sections", typeof(Sections_T_v5))]
        [XmlElement("StartValue", typeof(StartValue_T))]
        [XmlElement("Subelement", typeof(Subelement_T_v5))]
        public new object[] Items { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            Name = reader.GetAttribute("Name");
            Datatype = reader.GetAttribute("Datatype");
            Version = reader.GetAttribute("Version");

            _ = Enum.TryParse<Remanence_TE>(reader.GetAttribute("Remanence"), out var remanence);
            Remanence = remanence;

            _ = Enum.TryParse<Accessibility_TE>(reader.GetAttribute("Accessibility"), out var accessibility);
            Accessibility = accessibility;

            _ = bool.TryParse(reader.GetAttribute("Informative"), out var informative);
            Informative = informative;

            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var items = new List<object>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "AttributeList":
                            var attributes = new Common.AttributList_T_v2();
                            attributes.ReadXml(reader);
                            Attributes = attributes.Items;
                            break;

                        case "Comment":
                            var comment = new Common.Comment_T_v2();
                            comment.ReadXml(reader);
                            Comment = comment;
                            break;

                        case "AssignedProDiagFB":
                            reader.Read();
                            items.Add(reader.Value);
                            reader.Read();
                            reader.ReadEndElement();
                            throw new NotImplementedException();
                            //break;
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
                    }
                }
                if (items.Count > 0) Items = items.ToArray();

                reader.ReadEndElement();
            }
        }

        public override void WriteXml(XmlWriter writer)
        {
        }
    }
}
