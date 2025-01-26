using System;
using System.Collections.Generic;
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
    [XmlRoot("Sections", IsNullable = false)]
    public class Sections_T : Object_G
    {
        [XmlArray("AttributeList")]
        [XmlArrayItem("BooleanAttribute", typeof(Common.BooleanAttribute_T), IsNullable = false)]
        [XmlArrayItem("IntegerAttribute", typeof(Common.IntegerAttribute_T), IsNullable = false)]
        [XmlArrayItem("RealAttribute", typeof(Common.RealAttribute_T), IsNullable = false)]
        [XmlArrayItem("StringAttribute", typeof(Common.StringAttribute_T), IsNullable = false)]
        public Common.AttributeBase[] Attributes { get; set; }

        [XmlElement("Section")]
        public Section_T[] Sections { get; set; }

        [XmlAttribute]
        public string Datatype { get; set; }

        [XmlAttribute]
        public string Version { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            Datatype = reader.GetAttribute("Datatype");
            Version = reader.GetAttribute("Version");

            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var sections = new List<Section_T>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "AttributeList":
                            var attributes = new Common.AttributList_T();
                            attributes.ReadXml(reader);
                            Attributes = attributes.Items;
                            break;
                        case "Section":
                            var section = new Section_T();
                            section.ReadXml(reader);
                            sections.Add(section);
                            break;
                    }
                }
                if (sections.Count > 0) Sections = sections.ToArray();

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
    /// <item>SW_InterfaceSections_v3 => SW.Common_v2</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Sections", IsNullable = false)]
    public class Sections_T_v3 : Sections_T
    {
        [XmlArray("AttributeList")]
        [XmlArrayItem("BooleanAttribute", typeof(Common.BooleanAttribute_T_v2), IsNullable = false)]
        [XmlArrayItem("DateAttribute", typeof(Common.DateAttribute_T_v2), IsNullable = false)]
        [XmlArrayItem("IntegerAttribute", typeof(Common.IntegerAttribute_T_v2), IsNullable = false)]
        [XmlArrayItem("RealAttribute", typeof(Common.RealAttribute_T_v2), IsNullable = false)]
        [XmlArrayItem("StringAttribute", typeof(Common.StringAttribute_T_v2), IsNullable = false)]
        public new Common.AttributeBase[] Attributes { get; set; }

        [XmlElement("Section")]
        public new Section_T_v3[] Sections { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            Datatype = reader.GetAttribute("Datatype");
            Version = reader.GetAttribute("Version");

            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var sections = new List<Section_T_v3>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "AttributeList":
                            var attributes = new Common.AttributList_T_v2();
                            attributes.ReadXml(reader);
                            Attributes = attributes.Items;
                            break;
                        case "Section":
                            var section = new Section_T_v3();
                            section.ReadXml(reader);
                            sections.Add(section);
                            break;
                    }
                }
                if (sections.Count > 0) Sections = sections.ToArray();

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
    /// <item>SW_InterfaceSections_v4 => SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Sections", IsNullable = false)]
    public class Sections_T_v4 : Sections_T_v3
    {
        [XmlArray("AttributeList")]
        [XmlArrayItem("BooleanAttribute", typeof(Common.BooleanAttribute_T_v2), IsNullable = false)]
        [XmlArrayItem("DateAttribute", typeof(Common.DateAttribute_T_v2), IsNullable = false)]
        [XmlArrayItem("IntegerAttribute", typeof(Common.IntegerAttribute_T_v2), IsNullable = false)]
        [XmlArrayItem("RealAttribute", typeof(Common.RealAttribute_T_v2), IsNullable = false)]
        [XmlArrayItem("StringAttribute", typeof(Common.StringAttribute_T_v2), IsNullable = false)]
        public new Common.AttributeBase[] Attributes { get; set; }

        [XmlElement("Section")]
        public new Section_T_v4[] Sections { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            Datatype = reader.GetAttribute("Datatype");
            Version = reader.GetAttribute("Version");

            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var sections = new List<Section_T_v4>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "AttributeList":
                            var attributes = new Common.AttributList_T_v2();
                            attributes.ReadXml(reader);
                            Attributes = attributes.Items;
                            break;
                        case "Section":
                            var section = new Section_T_v4();
                            section.ReadXml(reader);
                            sections.Add(section);
                            break;
                    }
                }
                if (sections.Count > 0) Sections = sections.ToArray();

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
    /// <item>SW_InterfaceSections_v5 => SW.Common_v3</item>
    /// </list>
    /// </remarks>
    [Serializable]
    [XmlRoot("Sections", IsNullable = false)]
    public class Sections_T_v5 : Sections_T_v4
    {
        [XmlElement("Section")]
        public new Section_T_v5[] Sections { get; set; }

        public override void ReadXml(XmlReader reader)
        {
            Datatype = reader.GetAttribute("Datatype");
            Version = reader.GetAttribute("Version");

            if (!reader.IsEmptyElement)
            {
                reader.Read();

                var sections = new List<Section_T_v5>();
                while (reader.MoveToContent() == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "AttributeList":
                            var attributes = new Common.AttributList_T_v2();
                            attributes.ReadXml(reader);
                            Attributes = attributes.Items;
                            break;
                        case "Section":
                            var section = new Section_T_v5();
                            section.ReadXml(reader);
                            sections.Add(section);
                            break;
                    }
                }
                if (sections.Count > 0) Sections = sections.ToArray();
            }
            //reader.ReadEndElement();
        }

        public override void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }
}
